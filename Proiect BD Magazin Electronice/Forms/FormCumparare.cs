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
    public partial class FormCumparare : Form
    {
        public int Stoc;
        public string name3="(?)";

        private const int PRIMA_COLOANA = 0;
        private const bool SUCCES = true;

        //initializare obiecte utilizate pentru salvarea datelor in baza de date (sau alte medii de stocare...daca exista implementare corespunzatoare)
        IStocareElectronice stocareElectronice = (IStocareElectronice)new StocareFactory().GetTipStocare(typeof(Electronic));
        IStocareCosuri stocareCosuri = (IStocareCosuri)new StocareFactory().GetTipStocare(typeof(Cos));
        
        public FormCumparare()
        {
            InitializeComponent();

        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Close();
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
                    dataGridView1.Columns["IdElectronic"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void FormCumparare_Load(object sender, EventArgs e)
        {  
            lblName.Text = name3;
            AfiseazaElectronice();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentRowIndex = dataGridView1.CurrentCell.RowIndex;
            string idElectronic = dataGridView1[PRIMA_COLOANA, currentRowIndex].Value.ToString();
            try
            {
                Electronic electronic = stocareElectronice.GetElectronic(Int32.Parse(idElectronic));
                 Stoc = electronic.Nr_Produse;
                //incarcarea datelor in controalele de pe forma
                if (electronic != null)
                {
                    lblIdelectronic.Text = electronic.IdElectronic.ToString();
                    lblNumeprodus.Text = electronic.Nume_produs;
                    lblfirma.Text = electronic.Firma;
                    lblmodel.Text = electronic.Model;
                    lblspecificatii.Text = electronic.Specificatii;
                    lblculoare.Text = electronic.Culoare;
                    numericUpDownNrproduse.Text = electronic.Nr_Produse.ToString();
                    lblpret.Text = electronic.Pret.ToString();
                    labelTotalPlata.Text = (numericUpDownNrproduse.Value * Int32.Parse(lblpret.Text)).ToString();
                }
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            
            
            
        }

        private void btnCalculeaza_Click(object sender, EventArgs e)
        {
            labelTotalPlata.Text = (numericUpDownNrproduse.Value * Int32.Parse(lblpret.Text)).ToString();
        }

        private void btnAdaugaincos_Click(object sender, EventArgs e)
        {
            Electronic electronicActualizat = new Electronic(Int32.Parse(lblIdelectronic.Text), lblNumeprodus.Text, lblfirma.Text, lblmodel.Text, lblspecificatii.Text, lblculoare.Text, Int32.Parse(numericUpDownNrproduse.Text), Int32.Parse(lblpret.Text));
            Electronic elec_modificare = electronicActualizat;
            elec_modificare.Nr_Produse = Stoc - Convert.ToInt32(numericUpDownNrproduse.Text);
            if (Stoc==0)
            {
                MessageBox.Show("Stoc insuficient!");
            }
            else if(Stoc < Convert.ToInt32(numericUpDownNrproduse.Text))
            {
                MessageBox.Show("Stoc insuficient!");
            }
            else if (Convert.ToInt32(numericUpDownNrproduse.Text)==0)
            {
                MessageBox.Show("Numarul minim de produse cumparate este 1!");
            }
            else
            try
                {
                
                var cos = new Cos(lblName.Text, Convert.ToInt32( lblIdelectronic.Text), lblNumeprodus.Text, lblfirma.Text, lblmodel.Text, lblspecificatii.Text, lblculoare.Text, Convert.ToInt32(lblpret.Text), Convert.ToInt32(numericUpDownNrproduse.Text), Convert.ToInt32(labelTotalPlata.Text), comboBoxModalitatePlata.Text);
                //lblUsername e numeutilizator
                
                var rez = stocareElectronice.UpdateElectronicLaCumparare(elec_modificare);
                var rezultat = stocareCosuri.AddCos(cos);
                    if (rezultat == SUCCES && rez== SUCCES)
                    {

                        MessageBox.Show("Produs adaugat in cos cu succes!");
                        SqlDBHelper.ExecuteNonQuery("Commit", CommandType.Text);
                    }

                    else
                    {
                        MessageBox.Show("Eroare la adaugare");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exceptie" + ex.Message);
                }
            AfiseazaElectronice();
        }
    }
}
