namespace WF_Form_List
{
    partial class FormAra
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.RbVar = new System.Windows.Forms.RadioButton();
            this.RbYok = new System.Windows.Forms.RadioButton();
            this.TxtAra = new System.Windows.Forms.TextBox();
            this.BtnAra = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "elma",
            "armut",
            "üzüm",
            "incir",
            "kivi",
            "nar"});
            this.listBox1.Location = new System.Drawing.Point(31, 24);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(133, 134);
            this.listBox1.TabIndex = 0;
            // 
            // RbVar
            // 
            this.RbVar.AutoSize = true;
            this.RbVar.Location = new System.Drawing.Point(31, 180);
            this.RbVar.Name = "RbVar";
            this.RbVar.Size = new System.Drawing.Size(47, 17);
            this.RbVar.TabIndex = 1;
            this.RbVar.TabStop = true;
            this.RbVar.Text = "VAR";
            this.RbVar.UseVisualStyleBackColor = true;
            // 
            // RbYok
            // 
            this.RbYok.AutoSize = true;
            this.RbYok.Location = new System.Drawing.Point(103, 180);
            this.RbYok.Name = "RbYok";
            this.RbYok.Size = new System.Drawing.Size(47, 17);
            this.RbYok.TabIndex = 2;
            this.RbYok.TabStop = true;
            this.RbYok.Text = "YOK";
            this.RbYok.UseVisualStyleBackColor = true;
            // 
            // TxtAra
            // 
            this.TxtAra.Location = new System.Drawing.Point(211, 24);
            this.TxtAra.Name = "TxtAra";
            this.TxtAra.Size = new System.Drawing.Size(100, 20);
            this.TxtAra.TabIndex = 3;
            // 
            // BtnAra
            // 
            this.BtnAra.Location = new System.Drawing.Point(225, 50);
            this.BtnAra.Name = "BtnAra";
            this.BtnAra.Size = new System.Drawing.Size(75, 23);
            this.BtnAra.TabIndex = 4;
            this.BtnAra.Text = "ara";
            this.BtnAra.UseVisualStyleBackColor = true;
            this.BtnAra.Click += new System.EventHandler(this.BtnAra_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(365, 24);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(168, 147);
            this.listBox2.TabIndex = 5;
            // 
            // FormAra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.BtnAra);
            this.Controls.Add(this.TxtAra);
            this.Controls.Add(this.RbYok);
            this.Controls.Add(this.RbVar);
            this.Controls.Add(this.listBox1);
            this.Name = "FormAra";
            this.Text = "FormAra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RadioButton RbVar;
        private System.Windows.Forms.RadioButton RbYok;
        private System.Windows.Forms.TextBox TxtAra;
        private System.Windows.Forms.Button BtnAra;
        private System.Windows.Forms.ListBox listBox2;
    }
}