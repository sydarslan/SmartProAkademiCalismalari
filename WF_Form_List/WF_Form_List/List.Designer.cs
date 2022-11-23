namespace WF_Form_List
{
    partial class List
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ChbHepsi = new System.Windows.Forms.CheckBox();
            this.BtnSecerekSil = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtSil = new System.Windows.Forms.TextBox();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtEklenecek = new System.Windows.Forms.TextBox();
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
            this.panel1.Size = new System.Drawing.Size(150, 450);
            this.panel1.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "DOMATES",
            "BİBER",
            "LİMON"});
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(146, 446);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.ChbHepsi);
            this.panel2.Controls.Add(this.BtnSecerekSil);
            this.panel2.Controls.Add(this.BtnSil);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.TxtSil);
            this.panel2.Controls.Add(this.BtnEkle);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.TxtEklenecek);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(418, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(241, 450);
            this.panel2.TabIndex = 1;
            // 
            // ChbHepsi
            // 
            this.ChbHepsi.AutoSize = true;
            this.ChbHepsi.Location = new System.Drawing.Point(6, 197);
            this.ChbHepsi.Margin = new System.Windows.Forms.Padding(2);
            this.ChbHepsi.Name = "ChbHepsi";
            this.ChbHepsi.Size = new System.Drawing.Size(75, 17);
            this.ChbHepsi.TabIndex = 7;
            this.ChbHepsi.Text = "Hepsini Sil";
            this.ChbHepsi.UseVisualStyleBackColor = true;
            this.ChbHepsi.CheckedChanged += new System.EventHandler(this.ChbHepsi_CheckedChanged);
            // 
            // BtnSecerekSil
            // 
            this.BtnSecerekSil.Location = new System.Drawing.Point(2, 128);
            this.BtnSecerekSil.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSecerekSil.Name = "BtnSecerekSil";
            this.BtnSecerekSil.Size = new System.Drawing.Size(126, 39);
            this.BtnSecerekSil.TabIndex = 6;
            this.BtnSecerekSil.Text = "Seçerek Sil";
            this.BtnSecerekSil.UseVisualStyleBackColor = true;
            this.BtnSecerekSil.Click += new System.EventHandler(this.BtnSecerekSil_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.BtnSil.Location = new System.Drawing.Point(137, 125);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(75, 37);
            this.BtnSil.TabIndex = 5;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Silinecek Veri";
            // 
            // TxtSil
            // 
            this.TxtSil.Location = new System.Drawing.Point(89, 99);
            this.TxtSil.Name = "TxtSil";
            this.TxtSil.Size = new System.Drawing.Size(123, 20);
            this.TxtSil.TabIndex = 3;
            this.TxtSil.TextChanged += new System.EventHandler(this.TxtSil_TextChanged);
            // 
            // BtnEkle
            // 
            this.BtnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.BtnEkle.Location = new System.Drawing.Point(137, 39);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(75, 37);
            this.BtnEkle.TabIndex = 2;
            this.BtnEkle.Text = "Ekle\r\n";
            this.BtnEkle.UseVisualStyleBackColor = true;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Eklenecek Veri";
            // 
            // TxtEklenecek
            // 
            this.TxtEklenecek.Location = new System.Drawing.Point(89, 13);
            this.TxtEklenecek.Name = "TxtEklenecek";
            this.TxtEklenecek.Size = new System.Drawing.Size(123, 20);
            this.TxtEklenecek.TabIndex = 0;
            // 
            // List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "List";
            this.Text = "List";
            this.Load += new System.EventHandler(this.List_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtEklenecek;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtSil;
        private System.Windows.Forms.Button BtnSecerekSil;
        private System.Windows.Forms.CheckBox ChbHepsi;
    }
}