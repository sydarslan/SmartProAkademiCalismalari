namespace WF_Form_List
{
    partial class AnaForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.formToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yavruFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listelerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listboxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dortislemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topluislemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sınıfÖdeviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formAraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formToolStripMenuItem,
            this.listelerToolStripMenuItem,
            this.dortislemToolStripMenuItem,
            this.topluislemlerToolStripMenuItem,
            this.sınıfÖdeviToolStripMenuItem,
            this.formAraToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(717, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // formToolStripMenuItem
            // 
            this.formToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.normalFormToolStripMenuItem,
            this.yavruFormToolStripMenuItem});
            this.formToolStripMenuItem.Name = "formToolStripMenuItem";
            this.formToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.formToolStripMenuItem.Text = "Form";
            // 
            // normalFormToolStripMenuItem
            // 
            this.normalFormToolStripMenuItem.Name = "normalFormToolStripMenuItem";
            this.normalFormToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.normalFormToolStripMenuItem.Text = "Normal Form";
            this.normalFormToolStripMenuItem.Click += new System.EventHandler(this.normalFormToolStripMenuItem_Click);
            // 
            // yavruFormToolStripMenuItem
            // 
            this.yavruFormToolStripMenuItem.Name = "yavruFormToolStripMenuItem";
            this.yavruFormToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.yavruFormToolStripMenuItem.Text = "Yavru Form";
            this.yavruFormToolStripMenuItem.Click += new System.EventHandler(this.yavruFormToolStripMenuItem_Click);
            // 
            // listelerToolStripMenuItem
            // 
            this.listelerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listboxToolStripMenuItem});
            this.listelerToolStripMenuItem.Name = "listelerToolStripMenuItem";
            this.listelerToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.listelerToolStripMenuItem.Text = "Listeler";
            this.listelerToolStripMenuItem.Click += new System.EventHandler(this.listelerToolStripMenuItem_Click);
            // 
            // listboxToolStripMenuItem
            // 
            this.listboxToolStripMenuItem.Name = "listboxToolStripMenuItem";
            this.listboxToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.listboxToolStripMenuItem.Text = "Listbox";
            this.listboxToolStripMenuItem.Click += new System.EventHandler(this.listboxToolStripMenuItem_Click);
            // 
            // dortislemToolStripMenuItem
            // 
            this.dortislemToolStripMenuItem.Name = "dortislemToolStripMenuItem";
            this.dortislemToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.dortislemToolStripMenuItem.Text = "Dortislem";
            this.dortislemToolStripMenuItem.Click += new System.EventHandler(this.dortislemToolStripMenuItem_Click);
            // 
            // topluislemlerToolStripMenuItem
            // 
            this.topluislemlerToolStripMenuItem.Name = "topluislemlerToolStripMenuItem";
            this.topluislemlerToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.topluislemlerToolStripMenuItem.Text = "Topluislemler";
            this.topluislemlerToolStripMenuItem.Click += new System.EventHandler(this.topluislemlerToolStripMenuItem_Click);
            // 
            // sınıfÖdeviToolStripMenuItem
            // 
            this.sınıfÖdeviToolStripMenuItem.Name = "sınıfÖdeviToolStripMenuItem";
            this.sınıfÖdeviToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.sınıfÖdeviToolStripMenuItem.Text = "Sınıf Ödevi";
            this.sınıfÖdeviToolStripMenuItem.Click += new System.EventHandler(this.sınıfÖdeviToolStripMenuItem_Click);
            // 
            // formAraToolStripMenuItem
            // 
            this.formAraToolStripMenuItem.Name = "formAraToolStripMenuItem";
            this.formAraToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.formAraToolStripMenuItem.Text = "FormAra";
            this.formAraToolStripMenuItem.Click += new System.EventHandler(this.formAraToolStripMenuItem_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 426);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnaForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem formToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normalFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yavruFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listelerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listboxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dortislemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topluislemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sınıfÖdeviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formAraToolStripMenuItem;
    }
}