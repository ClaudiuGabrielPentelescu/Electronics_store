
namespace Proiect_BD_Magazin_Electronice
{
    partial class FormGestiune
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGestiune));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDateAndTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timerDateAndTime = new System.Windows.Forms.Timer(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnEditare = new System.Windows.Forms.Button();
            this.btnInapoi = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnStergere = new System.Windows.Forms.Button();
            this.btnAdaugare = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btnInapoi);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 560);
            this.panel1.TabIndex = 3;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(1)))), ((int)(((byte)(34)))));
            this.panel2.Controls.Add(this.lblDateAndTime);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(157, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(825, 61);
            this.panel2.TabIndex = 4;
            // 
            // lblDateAndTime
            // 
            this.lblDateAndTime.AutoSize = true;
            this.lblDateAndTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(1)))), ((int)(((byte)(34)))));
            this.lblDateAndTime.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateAndTime.ForeColor = System.Drawing.SystemColors.Window;
            this.lblDateAndTime.Location = new System.Drawing.Point(587, 21);
            this.lblDateAndTime.Name = "lblDateAndTime";
            this.lblDateAndTime.Size = new System.Drawing.Size(31, 21);
            this.lblDateAndTime.TabIndex = 3;
            this.lblDateAndTime.Text = "(?) ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(1)))), ((int)(((byte)(34)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(152, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gestionarea produselor electronice";
            // 
            // timerDateAndTime
            // 
            this.timerDateAndTime.Tick += new System.EventHandler(this.timerDateAndTime_Tick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(0)))), ((int)(((byte)(90)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(1)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(167, 57);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(0)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Size = new System.Drawing.Size(802, 416);
            this.dataGridView1.TabIndex = 5;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this.btnAdaugare;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this.btnStergere;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.TargetControl = this.btnEditare;
            // 
            // btnEditare
            // 
            this.btnEditare.BackColor = System.Drawing.Color.Black;
            this.btnEditare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditare.FlatAppearance.BorderSize = 0;
            this.btnEditare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditare.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditare.ForeColor = System.Drawing.SystemColors.Window;
            this.btnEditare.Image = global::Proiect_BD_Magazin_Electronice.Properties.Resources.edit_property_24;
            this.btnEditare.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditare.Location = new System.Drawing.Point(768, 490);
            this.btnEditare.Name = "btnEditare";
            this.btnEditare.Size = new System.Drawing.Size(162, 38);
            this.btnEditare.TabIndex = 0;
            this.btnEditare.Text = "         Editare";
            this.btnEditare.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditare.UseVisualStyleBackColor = false;
            this.btnEditare.Click += new System.EventHandler(this.btnEditare_Click);
            // 
            // btnInapoi
            // 
            this.btnInapoi.BackColor = System.Drawing.Color.Black;
            this.btnInapoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInapoi.FlatAppearance.BorderSize = 0;
            this.btnInapoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInapoi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInapoi.ForeColor = System.Drawing.SystemColors.Window;
            this.btnInapoi.Image = global::Proiect_BD_Magazin_Electronice.Properties.Resources.arrow_112_24;
            this.btnInapoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInapoi.Location = new System.Drawing.Point(29, 490);
            this.btnInapoi.Name = "btnInapoi";
            this.btnInapoi.Size = new System.Drawing.Size(119, 38);
            this.btnInapoi.TabIndex = 8;
            this.btnInapoi.Text = "       Înapoi";
            this.btnInapoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInapoi.UseVisualStyleBackColor = false;
            this.btnInapoi.Click += new System.EventHandler(this.btnInapoi_Click);
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
            // btnStergere
            // 
            this.btnStergere.BackColor = System.Drawing.Color.Black;
            this.btnStergere.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStergere.FlatAppearance.BorderSize = 0;
            this.btnStergere.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStergere.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStergere.ForeColor = System.Drawing.SystemColors.Window;
            this.btnStergere.Image = global::Proiect_BD_Magazin_Electronice.Properties.Resources.delete_property_24;
            this.btnStergere.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStergere.Location = new System.Drawing.Point(488, 490);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(162, 38);
            this.btnStergere.TabIndex = 0;
            this.btnStergere.Text = "          Ștergere";
            this.btnStergere.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStergere.UseVisualStyleBackColor = false;
            this.btnStergere.Click += new System.EventHandler(this.btnStergere_Click);
            // 
            // btnAdaugare
            // 
            this.btnAdaugare.BackColor = System.Drawing.Color.Black;
            this.btnAdaugare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdaugare.FlatAppearance.BorderSize = 0;
            this.btnAdaugare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdaugare.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdaugare.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAdaugare.Image = global::Proiect_BD_Magazin_Electronice.Properties.Resources.add_list_24;
            this.btnAdaugare.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdaugare.Location = new System.Drawing.Point(223, 490);
            this.btnAdaugare.Name = "btnAdaugare";
            this.btnAdaugare.Size = new System.Drawing.Size(162, 38);
            this.btnAdaugare.TabIndex = 0;
            this.btnAdaugare.Text = "          Adăugare";
            this.btnAdaugare.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdaugare.UseVisualStyleBackColor = false;
            this.btnAdaugare.Click += new System.EventHandler(this.btnAdaugare_Click);
            // 
            // FormGestiune
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(1)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(981, 560);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnEditare);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnStergere);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnAdaugare);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormGestiune";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PCG Electronics | Gestion Page";
            this.Load += new System.EventHandler(this.FormGestiune_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEditare;
        private System.Windows.Forms.Button btnStergere;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAdaugare;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblDateAndTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timerDateAndTime;
        private System.Windows.Forms.Button btnInapoi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
    }
}