namespace WF_Form_List
{
    partial class Dortislem
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
            this.TxtSayi2 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtSayi1 = new System.Windows.Forms.TextBox();
            this.BtnArtı = new System.Windows.Forms.Button();
            this.BtnBol = new System.Windows.Forms.Button();
            this.BtnCarpi = new System.Windows.Forms.Button();
            this.BtnEksi = new System.Windows.Forms.Button();
            this.LblSonuc = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtSayi2
            // 
            this.TxtSayi2.Location = new System.Drawing.Point(194, 28);
            this.TxtSayi2.Name = "TxtSayi2";
            this.TxtSayi2.Size = new System.Drawing.Size(29, 20);
            this.TxtSayi2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LblSonuc);
            this.panel1.Controls.Add(this.BtnEksi);
            this.panel1.Controls.Add(this.BtnCarpi);
            this.panel1.Controls.Add(this.BtnBol);
            this.panel1.Controls.Add(this.BtnArtı);
            this.panel1.Controls.Add(this.TxtSayi1);
            this.panel1.Controls.Add(this.TxtSayi2);
            this.panel1.Location = new System.Drawing.Point(211, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(353, 256);
            this.panel1.TabIndex = 2;
            // 
            // TxtSayi1
            // 
            this.TxtSayi1.Location = new System.Drawing.Point(130, 28);
            this.TxtSayi1.Name = "TxtSayi1";
            this.TxtSayi1.Size = new System.Drawing.Size(29, 20);
            this.TxtSayi1.TabIndex = 2;
            // 
            // BtnArtı
            // 
            this.BtnArtı.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnArtı.Location = new System.Drawing.Point(73, 75);
            this.BtnArtı.Name = "BtnArtı";
            this.BtnArtı.Size = new System.Drawing.Size(36, 23);
            this.BtnArtı.TabIndex = 3;
            this.BtnArtı.Text = "+";
            this.BtnArtı.UseVisualStyleBackColor = false;
            this.BtnArtı.Click += new System.EventHandler(this.BtnArtı_Click);
            // 
            // BtnBol
            // 
            this.BtnBol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnBol.Location = new System.Drawing.Point(245, 75);
            this.BtnBol.Name = "BtnBol";
            this.BtnBol.Size = new System.Drawing.Size(36, 23);
            this.BtnBol.TabIndex = 4;
            this.BtnBol.Text = "/";
            this.BtnBol.UseVisualStyleBackColor = false;
            this.BtnBol.Click += new System.EventHandler(this.BtnBol_Click);
            // 
            // BtnCarpi
            // 
            this.BtnCarpi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnCarpi.Location = new System.Drawing.Point(187, 75);
            this.BtnCarpi.Name = "BtnCarpi";
            this.BtnCarpi.Size = new System.Drawing.Size(36, 23);
            this.BtnCarpi.TabIndex = 5;
            this.BtnCarpi.Text = "*";
            this.BtnCarpi.UseVisualStyleBackColor = false;
            this.BtnCarpi.Click += new System.EventHandler(this.BtnCarpi_Click);
            // 
            // BtnEksi
            // 
            this.BtnEksi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnEksi.Location = new System.Drawing.Point(130, 75);
            this.BtnEksi.Name = "BtnEksi";
            this.BtnEksi.Size = new System.Drawing.Size(36, 23);
            this.BtnEksi.TabIndex = 6;
            this.BtnEksi.Text = "-";
            this.BtnEksi.UseVisualStyleBackColor = false;
            this.BtnEksi.Click += new System.EventHandler(this.BtnEksi_Click);
            // 
            // LblSonuc
            // 
            this.LblSonuc.AutoSize = true;
            this.LblSonuc.Location = new System.Drawing.Point(100, 121);
            this.LblSonuc.Name = "LblSonuc";
            this.LblSonuc.Size = new System.Drawing.Size(44, 13);
            this.LblSonuc.TabIndex = 7;
            this.LblSonuc.Text = "Sonuç :";
            // 
            // Dortislem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Dortislem";
            this.Text = "Dortislem";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TxtSayi2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblSonuc;
        private System.Windows.Forms.Button BtnEksi;
        private System.Windows.Forms.Button BtnCarpi;
        private System.Windows.Forms.Button BtnBol;
        private System.Windows.Forms.Button BtnArtı;
        private System.Windows.Forms.TextBox TxtSayi1;
    }
}