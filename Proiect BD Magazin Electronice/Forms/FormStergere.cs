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
    public partial class formStergere : Form
    {
        private const int PRIMA_COLOANA = 0;
        private const bool SUCCES = true;

        //initializare obiecte utilizate pentru salvarea datelor in baza de date (sau alte medii de stocare...daca exista implementare corespunzatoare)
        IStocareElectronice stocareElectronice = (IStocareElectronice)new StocareFactory().GetTipStocare(typeof(Electronic));
        public formStergere()
        {
            InitializeComponent();
            if (stocareElectronice == null)
            {
                MessageBox.Show("Eroare la initializare");
            }
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void btnSterge_Click(object sender, EventArgs e)
        {
            try
            {
                var electronic = new Electronic(
                    Int32.Parse(lbldElectronic.Text),
                    lblNumeProdus.Text,
                    lblFirma.Text,
                    lblModel.Text,
                    lblSpecificatii.Text,
                    lblCuloare.Text,
                    Int32.Parse(lblNrProduse.Text),
                    Int32.Parse(lblPret.Text)
                    );
                var rez = stocareElectronice.DeleteElectronic(electronic);
                if (rez == SUCCES)
                {
                    MessageBox.Show("Produs electronic sters cu succes!");
                    AfiseazaElectronice();
                }
                else
                {
                    MessageBox.Show("Eroare stergere produs electronic!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exceptie" + ex.Message);
            }
            lbldElectronic.Text = "";
            lblNumeProdus.Text = "";
            lblFirma.Text = "";
            lblModel.Text = "";
            lblSpecificatii.Text = "";
            lblCuloare.Text = "";
            lblNrProduse.Text = "";
            lblPret.Text = "";
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

        private void FormStergere_Load(object sender, EventArgs e)
        {
            AfiseazaElectronice();
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
                        lbldElectronic.Text = electronic.IdElectronic.ToString();
                        lblNumeProdus.Text = electronic.Nume_produs;
                        lblFirma.Text = electronic.Firma;
                        lblModel.Text = electronic.Model;
                        lblSpecificatii.Text = electronic.Specificatii;
                        lblCuloare.Text = electronic.Culoare;
                        lblNrProduse.Text = electronic.Nr_Produse.ToString();
                        lblPret.Text = electronic.Pret.ToString();
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
