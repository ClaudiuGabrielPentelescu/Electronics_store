using LibrarieModele;
using NivelAccesDate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_BD_Magazin_Electronice
{     
    public partial class FormCos : Form
    {
        
        private const int PRIMA_COLOANA = 0;
        private const bool SUCCES = true;

        //initializare obiecte utilizate pentru salvarea datelor in baza de date (sau alte medii de stocare...daca exista implementare corespunzatoare)
        IStocareCosuri stocareCosuri = (IStocareCosuri)new StocareFactory().GetTipStocare(typeof(Cos));
        public FormCos()
        {
            InitializeComponent();
        }

        private void timerDateAndTime_Tick(object sender, EventArgs e)
        {
            lblDateAndTime.Text = DateTime.Now.ToString("dd/MM/yyyy  HH:mm:ss ");
        }

        private void btnInapoi_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void AfiseazaCosuri()
        {
            try
            {
                var cosuri = stocareCosuri.GetCosuri();
                if (cosuri != null && cosuri.Any())
                {
                    dataGridView1.DataSource = cosuri.Select(c => new { c.Nume_Utilizator, c.IdElectronic, c.Nume_produs, c.Firma, c.Model, c.Specificatii, c.Culoare, c.Pret,c.Nr_Produse,c.Total,c.Modalitate_plata }).ToList();
                    dataGridView1.Columns["IdElectronic"].Visible = false;
                    dataGridView1.Columns["Nume_Utilizator"].Visible = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        private void FormCos_Load(object sender, EventArgs e)
        {
            AfiseazaCosuri();
            timerDateAndTime.Start();
        }

        private void btnPlateste_Click(object sender, EventArgs e)
        {
            AfiseazaCosuri();
            SqlDBHelper.ExecuteNonQuery("INSERT INTO Cumparaturi_PCG SELECT * FROM Cos_PCG", CommandType.Text);
            SqlDBHelper.ExecuteNonQuery("Commit", CommandType.Text);
            SqlDBHelper.ExecuteNonQuery("INSERT INTO Comercializari_PCG SELECT Nume_Utilizator,IdElectronic,Nr_produse,Total,Modalitate_plata FROM Cumparaturi_PCG", CommandType.Text);
            SqlDBHelper.ExecuteNonQuery("Commit", CommandType.Text);
            SqlDBHelper.ExecuteNonQuery("TRUNCATE TABLE Cos_PCG", CommandType.Text); 
            SqlDBHelper.ExecuteNonQuery("Commit", CommandType.Text);
            MessageBox.Show("Plata a fost inregistrata cu succes!");
            dataGridView1.DataSource = null;
        }
    }
}
