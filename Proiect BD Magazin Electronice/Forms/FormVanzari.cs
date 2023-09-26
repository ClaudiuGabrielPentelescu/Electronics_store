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
    public partial class FormVanzari : Form
    {
        IStocareCosuri stocareCosuri = (IStocareCosuri)new StocareFactory().GetTipStocare(typeof(Cos));
        public FormVanzari()
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

        private void FormVanzari_Load(object sender, EventArgs e)
        {
            timerDateAndTime.Start();
            OracleDataAdapter da = new OracleDataAdapter("SELECT * FROM Comercializari_PCG", "server = 80.96.123.131/ora09; UID =hr; password = oracletest");
            DataSet ds = new DataSet();
            da.Fill(ds, "Comercializari_PCG");
            dataGridView1.DataSource = ds.Tables["Comercializari_PCG"];
            dataGridView1.Columns["IdElectronic"].HeaderText = "Id_Electronic";
            dataGridView1.Columns["NumeUtilizator"].HeaderText = "NumeUtilizator";
            dataGridView1.Columns["Nr_produse"].HeaderText = "Nr_produse";
            dataGridView1.Columns["Total"].HeaderText = "Total";
            dataGridView1.Columns["Modalitate_plata"].HeaderText = "Modalitate_plata";
            
        }
    }
}
