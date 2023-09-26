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
    public partial class FormGestiune : Form
    {

        private const int PRIMA_COLOANA = 0;
        private const bool SUCCES = true;

        //initializare obiecte utilizate pentru salvarea datelor in baza de date (sau alte medii de stocare...daca exista implementare corespunzatoare)
        IStocareElectronice stocareElectronice = (IStocareElectronice)new StocareFactory().GetTipStocare(typeof(Electronic));
        public FormGestiune()
        {
            InitializeComponent();
            if (stocareElectronice == null )
            {
                MessageBox.Show("Eroare la initializare");
            }
        }

        private void timerDateAndTime_Tick(object sender, EventArgs e)
        {
            lblDateAndTime.Text = DateTime.Now.ToString("dd/MM/yyyy  HH:mm:ss ");
        }


        private void FormGestiune_Load(object sender, EventArgs e)
        {
            AfiseazaElectronice();
            timerDateAndTime.Start();
        }

        private void btnInapoi_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            FormAdaugare formAdaugare = new FormAdaugare();
            formAdaugare.ShowDialog();
            AfiseazaElectronice();
        }


        private void AfiseazaElectronice()
        {
            try
            {
                var electronice = stocareElectronice.GetElectronice();
                if (electronice != null && electronice.Any())
                {
                    dataGridView1.DataSource = electronice.Select(e => new { e.IdElectronic, e.Nume_produs, e.Firma, e.Model, e.Specificatii, e.Culoare,e.Nr_Produse,e.Pret }).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

       
        private void btnStergere_Click(object sender, EventArgs e)
        {
            formStergere formStergere = new formStergere();
            formStergere.ShowDialog();
            AfiseazaElectronice();
        }

        private void btnEditare_Click(object sender, EventArgs e)
        {
            FormEditare formEditare = new FormEditare();
            formEditare.ShowDialog();
            AfiseazaElectronice();
        }

       
    }
}
