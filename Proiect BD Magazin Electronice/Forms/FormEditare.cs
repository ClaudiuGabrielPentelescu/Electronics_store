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

namespace Proiect_BD_Magazin_Electronice.Forms
{
    public partial class FormEditare : Form
    {
        private const int PRIMA_COLOANA = 0;
        private const bool SUCCES = true;

        //initializare obiecte utilizate pentru salvarea datelor in baza de date (sau alte medii de stocare...daca exista implementare corespunzatoare)
        IStocareElectronice stocareElectronice = (IStocareElectronice)new StocareFactory().GetTipStocare(typeof(Electronic));
        public FormEditare()
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentRowIndex = dataGridView1.CurrentCell.RowIndex;
            string idElectronic = dataGridView1[PRIMA_COLOANA, currentRowIndex].Value.ToString();
            try
            {
                Electronic electronic = stocareElectronice.GetElectronic(Int32.Parse(idElectronic));

                //incarcarea datelor in controalele de pe forma
                if (electronic != null)
                {
                    numericUpDownIdElectronic.Text = electronic.IdElectronic.ToString();
                    textBoxNumeprodus.Text = electronic.Nume_produs;
                    textBoxFirma.Text = electronic.Firma;
                    textBoxModel.Text = electronic.Model;
                    textBoxSpecificatii.Text = electronic.Specificatii;
                    textBoxCuloare.Text = electronic.Culoare;
                    numericUpDownNrproduse.Text = electronic.Nr_Produse.ToString();
                    textBoxPret.Text = electronic.Pret.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void FormEditare_Load(object sender, EventArgs e)
        {
            AfiseazaElectronice();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnActualizeaza_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(textBoxPret.Text) <= 0 || Int32.Parse(textBoxPret.Text) > 1000000)
            {
                MessageBox.Show("Introduceti o valoare a pretului intre 1 si 1000000");
            }
             else if (Int32.Parse(numericUpDownNrproduse.Text) < 0 || Int32.Parse(numericUpDownNrproduse.Text) > 100)
            {
                MessageBox.Show("Introduceti o valoare a numarului de produse cuprinsa intre 0 si 100");
             }
             else if(numericUpDownIdElectronic.Text == "" || textBoxNumeprodus.Text == "" || textBoxFirma.Text == "" || textBoxModel.Text == "" || textBoxSpecificatii.Text == "" || textBoxCuloare.Text ==""|| numericUpDownNrproduse.Text=="" || textBoxPret.Text=="")
            {
                MessageBox.Show("Format incorect!");
            }
            else
            {
                try
                {
                    var electronic = new Electronic(
                    Int32.Parse(numericUpDownIdElectronic.Text),
                    textBoxNumeprodus.Text,
                    textBoxFirma.Text,
                    textBoxModel.Text,
                    textBoxSpecificatii.Text,
                    textBoxCuloare.Text,
                    Int32.Parse(numericUpDownNrproduse.Text),
                    Int32.Parse(textBoxPret.Text)
                    );
                    var rez = stocareElectronice.UpdateElectronic(electronic);
                    if (rez == SUCCES)
                    {
                        MessageBox.Show("Produs electronic actualizat cu succes!");
                        AfiseazaElectronice();
                    }
                    else
                    {
                        MessageBox.Show("Eroare actualizare produs electronic!");
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
        }
    }
}
