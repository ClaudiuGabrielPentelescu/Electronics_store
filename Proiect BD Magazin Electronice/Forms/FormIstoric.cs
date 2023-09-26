using LibrarieModele;
using NivelAccesDate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_BD_Magazin_Electronice
{
    public partial class FormIstoric : Form
    {
        IStocareCumparaturi stocareCumparaturi = (IStocareCumparaturi)new StocareFactory().GetTipStocare(typeof(Cumparatura));
        public FormIstoric()
        {
            InitializeComponent();
        }

        private void btnInapoi_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void timerDateAndTime_Tick(object sender, EventArgs e)
        {
            lblDateAndTime.Text = DateTime.Now.ToString("dd/MM/yyyy  HH:mm:ss ");
        }

        private void FormIstoric_Load(object sender, EventArgs e)
        {
            OracleDataAdapter da = new OracleDataAdapter("SELECT * FROM Cumparaturi_PCG", "server = 80.96.123.131/ora09; UID =hr; password = oracletest");
            DataSet ds = new DataSet();
            da.Fill(ds, "Cumparaturi_PCG");
            dataGridView1.DataSource = ds.Tables["Cumparaturi_PCG"];
            dataGridView1.Columns["IdElectronic"].Visible = false;
            dataGridView1.Columns["Nume_Utilizator"].HeaderText = "Nume_Utilizator";
            dataGridView1.Columns["Nume_produs"].HeaderText = "Nume_produs";
            dataGridView1.Columns["Firma"].HeaderText = "Firma";
            dataGridView1.Columns["Model"].HeaderText = "Model";
            dataGridView1.Columns["Specificatii"].HeaderText = "Specificatii";
            dataGridView1.Columns["Culoare"].HeaderText = "Culoare";
            dataGridView1.Columns["Pret"].HeaderText = "Pret";
            dataGridView1.Columns["Nr_produse"].HeaderText = "Nr_produse";
            dataGridView1.Columns["Total"].HeaderText = "Total";
            dataGridView1.Columns["Modalitate_plata"].HeaderText = "Modalitate_plata";
            timerDateAndTime.Start();
        }

        private void btnGolesteIstoric_Click(object sender, EventArgs e)
        {
            SqlDBHelper.ExecuteNonQuery("TRUNCATE TABLE Cumparaturi_PCG", CommandType.Text);
            SqlDBHelper.ExecuteNonQuery("Commit", CommandType.Text);
            MessageBox.Show("Istoricul cumparaturilor a fost sters!");
            dataGridView1.DataSource = null;
        }
    }
}

