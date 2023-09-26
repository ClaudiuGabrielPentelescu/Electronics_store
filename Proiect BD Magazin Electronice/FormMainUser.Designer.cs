
namespace Proiect_BD_Magazin_Electronice
{
    partial class FormMainUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainUser));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnIstoric = new System.Windows.Forms.Button();
            this.btnCos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMagazin = new System.Windows.Forms.Button();
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
            this.panel1.Controls.Add(this.btnIstoric);
            this.panel1.Controls.Add(this.btnCos);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnMagazin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 560);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            // btnIstoric
            // 
            this.btnIstoric.BackColor = System.Drawing.Color.Black;
            this.btnIstoric.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIstoric.FlatAppearance.BorderSize = 0;
            this.btnIstoric.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIstoric.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIstoric.ForeColor = System.Drawing.SystemColors.Window;
            this.btnIstoric.Image = global::Proiect_BD_Magazin_Electronice.Properties.Resources.external_content_duckduckgo_Z78_icon;
            this.btnIstoric.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIstoric.Location = new System.Drawing.Point(3, 269);
            this.btnIstoric.Name = "btnIstoric";
            this.btnIstoric.Size = new System.Drawing.Size(162, 38);
            this.btnIstoric.TabIndex = 0;
            this.btnIstoric.Text = "        Istoric";
            this.btnIstoric.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIstoric.UseVisualStyleBackColor = false;
            this.btnIstoric.Click += new System.EventHandler(this.btnIstoric_Click);
            // 
            // btnCos
            // 
            this.btnCos.BackColor = System.Drawing.Color.Black;
            this.btnCos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCos.FlatAppearance.BorderSize = 0;
            this.btnCos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCos.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCos.Image = global::Proiect_BD_Magazin_Electronice.Properties.Resources.cart_2_24;
            this.btnCos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCos.Location = new System.Drawing.Point(3, 214);
            this.btnCos.Name = "btnCos";
            this.btnCos.Size = new System.Drawing.Size(162, 38);
            this.btnCos.TabIndex = 0;
            this.btnCos.Text = "          Coș";
            this.btnCos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCos.UseVisualStyleBackColor = false;
            this.btnCos.Click += new System.EventHandler(this.btnCos_Click);
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
            // btnMagazin
            // 
            this.btnMagazin.BackColor = System.Drawing.Color.Black;
            this.btnMagazin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMagazin.FlatAppearance.BorderSize = 0;
            this.btnMagazin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMagazin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMagazin.ForeColor = System.Drawing.SystemColors.Window;
            this.btnMagazin.Image = global::Proiect_BD_Magazin_Electronice.Properties.Resources.store_24;
            this.btnMagazin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMagazin.Location = new System.Drawing.Point(3, 163);
            this.btnMagazin.Name = "btnMagazin";
            this.btnMagazin.Size = new System.Drawing.Size(162, 38);
            this.btnMagazin.TabIndex = 0;
            this.btnMagazin.Text = "          Magazin";
            this.btnMagazin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMagazin.UseVisualStyleBackColor = false;
            this.btnMagazin.Click += new System.EventHandler(this.btnMagazin_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(1)))), ((int)(((byte)(34)))));
            this.panel2.Controls.Add(this.lblDateAndTime);
            this.panel2.Controls.Add(this.lblUsername);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(168, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(813, 61);
            this.panel2.TabIndex = 0;
            // 
            // lblDateAndTime
            // 
            this.lblDateAndTime.AutoSize = true;
            this.lblDateAndTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(1)))), ((int)(((byte)(34)))));
            this.lblDateAndTime.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateAndTime.ForeColor = System.Drawing.SystemColors.Window;
            this.lblDateAndTime.Location = new System.Drawing.Point(550, 21);
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
            this.lblUsername.Location = new System.Drawing.Point(181, 21);
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
            this.label2.Location = new System.Drawing.Point(82, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bine ai venit, ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // timerDateAndTime
            // 
            this.timerDateAndTime.Tick += new System.EventHandler(this.timerDateAndTime_Tick);
            // 
            // FormMainUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::Proiect_BD_Magazin_Electronice.Properties.Resources.electronic_gadgets;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(981, 560);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMainUser";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PCG Electronics | User Page";
            this.Load += new System.EventHandler(this.FormMainUser_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMagazin;
        private System.Windows.Forms.Button btnCos;
        private System.Windows.Forms.Button btnIstoric;
        private System.Windows.Forms.Button btnLogout;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblDateAndTime;
        private System.Windows.Forms.Timer timerDateAndTime;
    }
}

