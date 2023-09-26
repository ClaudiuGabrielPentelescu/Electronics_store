using Proiect_BD_Magazin_Electronice.Forms;
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
    public partial class FormLogin : Form
    {
        public string usr1 = "{?}";
        public string psr1 = "{?}";
        public FormLogin()
        {
            InitializeComponent();
        }

        private void EmptyBox()
        {

            txtUsername.Clear();
            txtPassword.Clear();
        }
        

        private void picClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text.Trim() == string.Empty && txtUsername.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Introduceti un nume de utilizator si o parola!", "Informare", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (txtPassword.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Introduceti o parola!", "Informare", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (txtUsername.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Introduceti un nume de utilizator!", "Informare", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if(txtUsername.Text.Trim() == "ClaudiuGP" && txtPassword.Text.Trim() == "parolasimpla123"|| txtUsername.Text.Trim() == "AndreiGS" && txtPassword.Text.Trim() == "simionescu12"|| txtUsername.Text.Trim() == "OnicaDI" && txtPassword.Text.Trim() == "onica11" || txtUsername.Text.Trim() == "RobertaMC" && txtPassword.Text.Trim() == "roberta77" || txtUsername.Text.Trim() == usr1 && txtPassword.Text.Trim() == psr1|| txtUsername.Text.Trim() == "VladutSO" && txtPassword.Text.Trim() == "vlad10"|| txtUsername.Text.Trim() == "ArturO" && txtPassword.Text.Trim() == "artur10"|| txtUsername.Text.Trim() == "IonutRot" && txtPassword.Text.Trim() == "ionutrot")
            {
                MessageBox.Show("Conectat ca utilizator", "Notificare", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormMainUser formMainUser= new FormMainUser();
                formMainUser.name1 = txtUsername.Text;
                formMainUser.ShowDialog();
                EmptyBox();
            }
            else if (txtUsername.Text.Trim() == "Claudiu" && txtPassword.Text.Trim() == "pcgelec17" || txtUsername.Text.Trim() == "Admin" && txtPassword.Text.Trim() == "nvidia78")
            {
                MessageBox.Show("Conectat ca administrator", "Notificare", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormMainAdmin formMainAdmin = new FormMainAdmin();
                formMainAdmin.name = txtUsername.Text;
                formMainAdmin.ShowDialog();
                EmptyBox();
            }
            else if (txtUsername.Text.Trim() == "Claudiu" && txtPassword.Text.Trim() != "pcgelec17" || txtUsername.Text.Trim() == "Admin" && txtPassword.Text.Trim() != "nvidia78")
            {
                MessageBox.Show("Parola administrator gresita!", "Notificare", MessageBoxButtons.OK, MessageBoxIcon.Information);
                EmptyBox();
            }
            else if (txtUsername.Text.Trim() != "Claudiu" && txtPassword.Text.Trim() == "pcgelec17" || txtUsername.Text.Trim() != "Admin" && txtPassword.Text.Trim() == "nvidia78")
            {
                MessageBox.Show("Nume administrator gresit!", "Notificare", MessageBoxButtons.OK, MessageBoxIcon.Information);
                EmptyBox();
            }
        }
        private void btnInregistrare_Click(object sender, EventArgs e)
        {
            FormInregistrare formInregistrare = new FormInregistrare();
            formInregistrare.ShowDialog();
        }

        
    }
}
