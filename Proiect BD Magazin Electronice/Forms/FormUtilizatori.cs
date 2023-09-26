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
    public partial class FormUtilizatori : Form
    {

        private const int PRIMA_COLOANA = 0;
        private const bool SUCCES = true;

        //initializare obiecte utilizate pentru salvarea datelor in baza de date (sau alte medii de stocare...daca exista implementare corespunzatoare)
        IStocareUtilizatori stocareUtilizatori = (IStocareUtilizatori)new StocareFactory().GetTipStocare(typeof(Utilizator));
        public FormUtilizatori()
        {
            InitializeComponent();
            if (stocareUtilizatori == null)
            {
                MessageBox.Show("Eroare la initializare");
            }
        }
        private void FormUtilizatori_Load(object sender, EventArgs e)
        {
            timerDateAndTime.Start();
            AfiseazaUtilizatori();
        }

        private void timerDateAndTime_Tick(object sender, EventArgs e)
        {
            lblDateAndTime.Text = DateTime.Now.ToString("dd/MM/yyyy  HH:mm:ss ");
        }

        private void btnInapoi_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AfiseazaUtilizatori()
        {
            try
            {
                var utilizatori = stocareUtilizatori.GetUtilizatori();
                if (utilizatori!= null && utilizatori.Any())
                {
                    dataGridView1.DataSource = utilizatori.Select(u => new { u.Nume, u.Prenume, u.NumeUtilizator, u.Parola, u.Email, u.Telefon}).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
