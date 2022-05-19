
namespace Starter.FormMain
{
    partial class Menu
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
            this.menustrip = new System.Windows.Forms.MenuStrip();
            this.ts_Master = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMaster_Kelas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMaster_Matpel = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMaster_Guru = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_Test = new System.Windows.Forms.ToolStripMenuItem();
            this.menustrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menustrip
            // 
            this.menustrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_Master,
            this.ts_Test});
            this.menustrip.Location = new System.Drawing.Point(0, 0);
            this.menustrip.Name = "menustrip";
            this.menustrip.Size = new System.Drawing.Size(800, 24);
            this.menustrip.TabIndex = 0;
            // 
            // ts_Master
            // 
            this.ts_Master.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMaster_Kelas,
            this.tsMaster_Matpel,
            this.tsMaster_Guru});
            this.ts_Master.Name = "ts_Master";
            this.ts_Master.Size = new System.Drawing.Size(55, 20);
            this.ts_Master.Text = "Master";
            // 
            // tsMaster_Kelas
            // 
            this.tsMaster_Kelas.Name = "tsMaster_Kelas";
            this.tsMaster_Kelas.Size = new System.Drawing.Size(111, 22);
            this.tsMaster_Kelas.Text = "Kelas";
            this.tsMaster_Kelas.Click += new System.EventHandler(this.tsMaster_Kelas_Click);
            // 
            // tsMaster_Matpel
            // 
            this.tsMaster_Matpel.Name = "tsMaster_Matpel";
            this.tsMaster_Matpel.Size = new System.Drawing.Size(111, 22);
            this.tsMaster_Matpel.Text = "Matpel";
            this.tsMaster_Matpel.Click += new System.EventHandler(this.tsMaster_Matpel_Click);
            // 
            // tsMaster_Guru
            // 
            this.tsMaster_Guru.Name = "tsMaster_Guru";
            this.tsMaster_Guru.Size = new System.Drawing.Size(111, 22);
            this.tsMaster_Guru.Text = "Guru";
            this.tsMaster_Guru.Click += new System.EventHandler(this.tsMaster_Guru_Click);
            // 
            // ts_Test
            // 
            this.ts_Test.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ts_Test.Name = "ts_Test";
            this.ts_Test.Size = new System.Drawing.Size(39, 20);
            this.ts_Test.Text = "Test";
            this.ts_Test.Click += new System.EventHandler(this.ts_Test_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menustrip);
            this.IsMdiContainer = true;
            this.Name = "Menu";
            this.Text = "MainMenu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenu_FormClosing);
            this.menustrip.ResumeLayout(false);
            this.menustrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menustrip;
        private System.Windows.Forms.ToolStripMenuItem ts_Master;
        private System.Windows.Forms.ToolStripMenuItem ts_Test;
        private System.Windows.Forms.ToolStripMenuItem tsMaster_Kelas;
        private System.Windows.Forms.ToolStripMenuItem tsMaster_Matpel;
        private System.Windows.Forms.ToolStripMenuItem tsMaster_Guru;
    }
}