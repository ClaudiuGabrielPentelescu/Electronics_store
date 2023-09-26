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
    public partial class FormMainAdmin : Form
    {
        public string name = "{?}";
        public FormMainAdmin()
        {
            InitializeComponent();
        }

        private void FormMainAdmin_Load(object sender, EventArgs e)
        {
            lblUsername.Text = name;
            timerDateAndTime.Start();
        }

        private void timerDateAndTime_Tick(object sender, EventArgs e)
        {
            lblDateAndTime.Text = DateTime.Now.ToString("dd/MM/yyyy  HH:mm:ss ");
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Esti sigur ca vrei sa te deconectezi?", "Atentionare", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                timerDateAndTime.Stop();
                Close();
            }
        }

        private void btnGestiune_Click(object sender, EventArgs e)
        {
            FormGestiune formGestiune = new FormGestiune();
            formGestiune.ShowDialog();
        }

        private void btnUtilizatori_Click(object sender, EventArgs e)
        {
            FormUtilizatori formUtilizatori = new FormUtilizatori();
            formUtilizatori.ShowDialog();
        }

        private void btnVanzari_Click(object sender, EventArgs e)
        {
            FormVanzari formVanzari = new FormVanzari();
            formVanzari.ShowDialog();
        }

    }
}
