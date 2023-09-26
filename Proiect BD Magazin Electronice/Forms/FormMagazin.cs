using LibrarieModele;
using NivelAccesDate;
using Proiect_BD_Magazin_Electronice.Forms;
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
    public partial class FormMagazin : Form
    {
        private const int PRIMA_COLOANA = 0;
        private const bool SUCCES = true;

        //initializare obiecte utilizate pentru salvarea datelor in baza de date (sau alte medii de stocare...daca exista implementare corespunzatoare)
        IStocareElectronice stocareElectronice = (IStocareElectronice)new StocareFactory().GetTipStocare(typeof(Electronic));
        public string name2 = "(?)";
        public FormMagazin()
        {
            InitializeComponent();
            if (stocareElectronice == null)
            {
                MessageBox.Show("Eroare la initializare");
            }
        }

        private void btnInapoi_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void timerDateAndTime_Tick(object sender, EventArgs e)
        {
            lblDateAndTime.Text = DateTime.Now.ToString("dd/MM/yyyy  HH:mm:ss ");
        }

        private void FormMagazin_Load(object sender, EventArgs e)
        {
            timerDateAndTime.Start();
            lblUsername.Text = name2;
            AfiseazaElectronice();

        }

        private void AfiseazaElectronice()
        {
            try
            {
                var electronice = stocareElectronice.GetElectronice();
                if (electronice != null && electronice.Any())
                {
                    dataGridView1.DataSource = electronice.Select(e => new { e.IdElectronic, e.Nume_produs, e.Firma, e.Model, e.Specificatii, e.Culoare, e.Nr_Produse, e.Pret }).ToList();
                    dataGridView1.Columns["IdElectronic"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                int currentRowIndex = dataGridView1.CurrentCell.RowIndex;
                string idElectronic = dataGridView1[PRIMA_COLOANA, currentRowIndex].Value.ToString();
                try
                {
                    Electronic electronic = stocareElectronice.GetElectronic(Int32.Parse(idElectronic));

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
        }

        private void btnCumpara_Click(object sender, EventArgs e)
        {
            FormCumparare formCumparare = new FormCumparare();
            formCumparare.name3 = name2;
            formCumparare.ShowDialog();
            AfiseazaElectronice();
        }
    }
}
