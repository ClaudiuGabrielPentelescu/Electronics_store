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
    public partial class FormMainUser : Form
    {


        public string name1 = "{?}";
        public FormMainUser()
        {
            InitializeComponent();
        }

        private void FormMainUser_Load(object sender, EventArgs e)
        {
            lblUsername.Text = name1;
            timerDateAndTime.Start();
        }

        private void btnMagazin_Click(object sender, EventArgs e)
        {
            FormMagazin formMagazin = new FormMagazin();
            formMagazin.name2 = name1;
            formMagazin.ShowDialog();
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            FormCos formCos = new FormCos();
            formCos.ShowDialog();
        }

        private void btnIstoric_Click(object sender, EventArgs e)
        {
            FormIstoric formIstoric = new FormIstoric();
            formIstoric.ShowDialog();
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timerDateAndTime_Tick(object sender, EventArgs e)
        {
            lblDateAndTime.Text = DateTime.Now.ToString("dd/MM/yyyy  HH:mm:ss ");
        }

        
    }
}
