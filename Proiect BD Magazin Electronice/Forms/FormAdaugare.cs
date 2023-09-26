using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibrarieModele;
using NivelAccesDate;

namespace Proiect_BD_Magazin_Electronice
{
    public partial class FormAdaugare : Form
    {
        private const bool SUCCES = true;

        //initializare obiecte utilizate pentru salvarea datelor in baza de date (sau alte medii de stocare...daca exista implementare corespunzatoare)
        IStocareElectronice stocareElectronice = (IStocareElectronice)new StocareFactory().GetTipStocare(typeof(Electronic));
        public FormAdaugare()
        {
            InitializeComponent();
            if (stocareElectronice == null )
            {
                MessageBox.Show("Eroare la initializare");
            }
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            if(Int32.Parse(textBoxPret.Text) <0 || Int32.Parse(textBoxPret.Text) > 1000000)
            {
                MessageBox.Show("Introduceti o valoare a pretului intre 1 si 1000000");
            }
            else if (Int32.Parse(numericUpDownNrproduse.Text) < 1 || Int32.Parse(numericUpDownNrproduse.Text) > 100)
            {
                MessageBox.Show("Introduceti o valoare a numarului de produse cuprinsa intre 1 si 100");
            }
            else
            try
            {
                var rezultat = stocareElectronice.AddElectronic(new Electronic(Convert.ToInt32(numericUpDownIdElectronic.Text), textBoxNumeprodus.Text, textBoxFirma.Text, textBoxModel.Text, textBoxSpecificatii.Text, textBoxCuloare.Text, Convert.ToInt32(numericUpDownNrproduse.Text), Convert.ToInt32(textBoxPret.Text)));
                if (rezultat == SUCCES)
                {
                    MessageBox.Show("Produs electronic adaugat!");
                    AfiseazaElectronice();
                }
                else
                {
                    MessageBox.Show("Eroare la adaugarea produsului electronic");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exceptie" + ex.Message);
            }
            numericUpDownIdElectronic.Text = "";
            textBoxNumeprodus.Text = "";
            textBoxFirma.Text = "";
            textBoxModel.Text = "";
            textBoxSpecificatii.Text = "";
            textBoxCuloare.Text = "";
            numericUpDownNrproduse.Text = "";
            textBoxPret.Text = "";
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormAdaugare_Load(object sender, EventArgs e)
        {
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnInapoi_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
