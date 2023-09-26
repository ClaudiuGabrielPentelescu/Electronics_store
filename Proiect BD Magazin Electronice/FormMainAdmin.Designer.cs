
namespace Proiect_BD_Magazin_Electronice
{
    partial class FormMainAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainAdmin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnVanzari = new System.Windows.Forms.Button();
            this.btnUtilizatori = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGestiune = new System.Windows.Forms.Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDateAndTime = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timerDateAndTime = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnVanzari);
            this.panel1.Controls.Add(this.btnUtilizatori);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnGestiune);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 560);
            this.panel1.TabIndex = 1;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Black;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.Window;
            this.btnLogout.Image = global::Proiect_BD_Magazin_Electronice.Properties.Resources.logout_24;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(3, 460);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(162, 38);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "          Log Out";
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnVanzari
            // 
            this.btnVanzari.BackColor = System.Drawing.Color.Black;
            this.btnVanzari.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVanzari.FlatAppearance.BorderSize = 0;
            this.btnVanzari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVanzari.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVanzari.ForeColor = System.Drawing.SystemColors.Window;
            this.btnVanzari.Image = global::Proiect_BD_Magazin_Electronice.Properties.Resources.us_dollar_24;
            this.btnVanzari.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVanzari.Location = new System.Drawing.Point(3, 269);
            this.btnVanzari.Name = "btnVanzari";
            this.btnVanzari.Size = new System.Drawing.Size(162, 38);
            this.btnVanzari.TabIndex = 0;
            this.btnVanzari.Text = "          Vânzări";
            this.btnVanzari.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVanzari.UseVisualStyleBackColor = false;
            this.btnVanzari.Click += new System.EventHandler(this.btnVanzari_Click);
            // 
            // btnUtilizatori
            // 
            this.btnUtilizatori.BackColor = System.Drawing.Color.Black;
            this.btnUtilizatori.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUtilizatori.FlatAppearance.BorderSize = 0;
            this.btnUtilizatori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUtilizatori.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUtilizatori.ForeColor = System.Drawing.SystemColors.Window;
            this.btnUtilizatori.Image = global::Proiect_BD_Magazin_Electronice.Properties.Resources.user_24;
            this.btnUtilizatori.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUtilizatori.Location = new System.Drawing.Point(3, 214);
            this.btnUtilizatori.Name = "btnUtilizatori";
            this.btnUtilizatori.Size = new System.Drawing.Size(162, 38);
            this.btnUtilizatori.TabIndex = 0;
            this.btnUtilizatori.Text = "          Utilizatori";
            this.btnUtilizatori.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUtilizatori.UseVisualStyleBackColor = false;
            this.btnUtilizatori.Click += new System.EventHandler(this.btnUtilizatori_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(25, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "PCG Electronics";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proiect_BD_Magazin_Electronice.Properties.Resources.logo_fococlipping_standard;
            this.pictureBox1.Location = new System.Drawing.Point(43, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnGestiune
            // 
            this.btnGestiune.BackColor = System.Drawing.Color.Black;
            this.btnGestiune.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGestiune.FlatAppearance.BorderSize = 0;
            this.btnGestiune.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestiune.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestiune.ForeColor = System.Drawing.SystemColors.Window;
            this.btnGestiune.Image = global::Proiect_BD_Magazin_Electronice.Properties.Resources.inbox_6_24;
            this.btnGestiune.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestiune.Location = new System.Drawing.Point(3, 163);
            this.btnGestiune.Name = "btnGestiune";
            this.btnGestiune.Size = new System.Drawing.Size(162, 38);
            this.btnGestiune.TabIndex = 0;
            this.btnGestiune.Text = "          Gestiune";
            this.btnGestiune.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGestiune.UseVisualStyleBackColor = false;
            this.btnGestiune.Click += new System.EventHandler(this.btnGestiune_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(1)))), ((int)(((byte)(34)))));
            this.panel2.Controls.Add(this.lblDateAndTime);
            this.panel2.Controls.Add(this.lblUsername);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(166, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(816, 61);
            this.panel2.TabIndex = 2;
            // 
            // lblDateAndTime
            // 
            this.lblDateAndTime.AutoSize = true;
            this.lblDateAndTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(1)))), ((int)(((byte)(34)))));
            this.lblDateAndTime.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateAndTime.ForeColor = System.Drawing.SystemColors.Window;
            this.lblDateAndTime.Location = new System.Drawing.Point(562, 21);
            this.lblDateAndTime.Name = "lblDateAndTime";
            this.lblDateAndTime.Size = new System.Drawing.Size(31, 21);
            this.lblDateAndTime.TabIndex = 3;
            this.lblDateAndTime.Text = "(?) ";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(1)))), ((int)(((byte)(34)))));
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.SystemColors.Window;
            this.lblUsername.Location = new System.Drawing.Point(255, 21);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(31, 21);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "(?) ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(1)))), ((int)(((byte)(34)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(52, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pagina Administratorului: ";
            // 
            // timerDateAndTime
            // 
            this.timerDateAndTime.Tick += new System.EventHandler(this.timerDateAndTime_Tick);
            // 
            // FormMainAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Proiect_BD_Magazin_Electronice.Properties.Resources.electronic_gadgets;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(981, 560);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMainAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PCG Electronics | Admin Page";
            this.Load += new System.EventHandler(this.FormMainAdmin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnVanzari;
        private System.Windows.Forms.Button btnUtilizatori;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnGestiune;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblDateAndTime;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timerDateAndTime;
    }
}