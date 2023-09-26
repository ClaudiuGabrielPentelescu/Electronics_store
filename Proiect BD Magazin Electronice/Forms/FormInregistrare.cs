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
    
    public partial class FormInregistrare : Form
    {
        public string usr="";
        public string psr="";

        private const bool SUCCES = true;
        //initializare obiecte utilizate pentru salvarea datelor in baza de date (sau alte medii de stocare...daca exista implementare corespunzatoare)
        IStocareUtilizatori stocareUtilizatori = (IStocareUtilizatori)new StocareFactory().GetTipStocare(typeof(Utilizator));
        public FormInregistrare()
        {
            InitializeComponent();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Close();
        }
       
           
    private void btnInregistreaza_Click(object sender, EventArgs e)
        {
            if(textBoxConfirmaParola.Text != textBoxParola.Text)
            {
                MessageBox.Show("Parolele nu corespund!");
            }
            else
            try
            {
                var rezultat = stocareUtilizatori.AddUtilizator(new Utilizator(textBoxNume.Text, textBoxPrenume.Text, textBoxUsername.Text, textBoxParola.Text, textBoxEmail.Text, textBoxTelefon.Text));
                if (rezultat == SUCCES && textBoxParola.Text == textBoxConfirmaParola.Text)
                {
                    MessageBox.Show("Utilizator nou inregistrat!");
                        FormLogin formLogin = new FormLogin();
                        usr = textBoxUsername.Text;
                        psr = textBoxParola.Text;
                        formLogin.usr1 = textBoxUsername.Text;
                        formLogin.psr1 = textBoxParola.Text;
                }
                else
                {
                    MessageBox.Show("Eroare la inregistrare!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exceptie" + ex.Message);
            }
            textBoxNume.Text = "";
            textBoxPrenume.Text = "";
            textBoxUsername.Text = "";
            textBoxParola.Text = "";
            textBoxConfirmaParola.Text= "";
            textBoxEmail.Text = "";
            textBoxTelefon.Text = "";
        }

        private void textBoxParola_TextChanged(object sender, EventArgs e)
        {
           
                textBoxParola.UseSystemPasswordChar = true;
            
        }

        private void textBoxConfirmaParola_TextChanged(object sender, EventArgs e)
        {
            textBoxConfirmaParola.UseSystemPasswordChar = true;
        }
    }
}
