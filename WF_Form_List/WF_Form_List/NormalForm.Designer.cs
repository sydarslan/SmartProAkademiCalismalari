namespace WF_Form_List
{
    partial class NormalForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtEklenecek = new System.Windows.Forms.TextBox();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtSil = new System.Windows.Forms.TextBox();
            this.BtnSecerek = new System.Windows.Forms.Button();
            this.ChbHepsiSil = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 487);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.ChbHepsiSil);
            this.panel2.Controls.Add(this.BtnSecerek);
            this.panel2.Controls.Add(this.TxtSil);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.BtnSil);
            this.panel2.Controls.Add(this.BtnEkle);
            this.panel2.Controls.Add(this.TxtEklenecek);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.listBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(565, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 487);
            this.panel2.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "MAVİ",
            "KAHVERENGİ",
            "YEŞİL",
            "MOR",
            "BORDO"});
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(196, 483);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(0, 0);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(246, 483);
            this.listBox2.TabIndex = 0;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Eklenecek Renk";
            // 
            // TxtEklenecek
            // 
            this.TxtEklenecek.Location = new System.Drawing.Point(108, 36);
            this.TxtEklenecek.Name = "TxtEklenecek";
            this.TxtEklenecek.Size = new System.Drawing.Size(100, 20);
            this.TxtEklenecek.TabIndex = 2;
            // 
            // BtnEkle
            // 
            this.BtnEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnEkle.Location = new System.Drawing.Point(83, 75);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(75, 23);
            this.BtnEkle.TabIndex = 3;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.UseVisualStyleBackColor = false;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnSil.Location = new System.Drawing.Point(133, 239);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(75, 23);
            this.BtnSil.TabIndex = 4;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = false;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Silinecek Renk";
            // 
            // TxtSil
            // 
            this.TxtSil.BackColor = System.Drawing.SystemColors.Window;
            this.TxtSil.Location = new System.Drawing.Point(108, 186);
            this.TxtSil.Name = "TxtSil";
            this.TxtSil.Size = new System.Drawing.Size(100, 20);
            this.TxtSil.TabIndex = 6;
            // 
            // BtnSecerek
            // 
            this.BtnSecerek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnSecerek.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.BtnSecerek.Location = new System.Drawing.Point(38, 239);
            this.BtnSecerek.Name = "BtnSecerek";
            this.BtnSecerek.Size = new System.Drawing.Size(75, 23);
            this.BtnSecerek.TabIndex = 7;
            this.BtnSecerek.Text = "Seçerek Sil";
            this.BtnSecerek.UseVisualStyleBackColor = false;
            this.BtnSecerek.Click += new System.EventHandler(this.BtnSecerek_Click);
            // 
            // ChbHepsiSil
            // 
            this.ChbHepsiSil.AutoSize = true;
            this.ChbHepsiSil.Location = new System.Drawing.Point(78, 294);
            this.ChbHepsiSil.Name = "ChbHepsiSil";
            this.ChbHepsiSil.Size = new System.Drawing.Size(72, 17);
            this.ChbHepsiSil.TabIndex = 8;
            this.ChbHepsiSil.Text = "HepsiniSil";
            this.ChbHepsiSil.UseVisualStyleBackColor = true;
            this.ChbHepsiSil.CheckedChanged += new System.EventHandler(this.ChbHepsiSil_CheckedChanged);
            // 
            // NormalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 487);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "NormalForm";
            this.Text = "NormalForm";
            this.Load += new System.EventHandler(this.NormalForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.TextBox TxtEklenecek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.TextBox TxtSil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnSecerek;
        private System.Windows.Forms.CheckBox ChbHepsiSil;
    }
}