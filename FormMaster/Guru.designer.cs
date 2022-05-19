
namespace Starter.FormMaster
{
    partial class Guru
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txt_Alamat = new System.Windows.Forms.TextBox();
            this.txt_Telp = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cb_Matpel = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_TTL = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.nud_Jamkerja = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Nama = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Jamkerja)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(138, 78);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(158, 20);
            this.txt_ID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Matpel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Alamat";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(43, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(347, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txt_Alamat
            // 
            this.txt_Alamat.Location = new System.Drawing.Point(138, 151);
            this.txt_Alamat.Name = "txt_Alamat";
            this.txt_Alamat.Size = new System.Drawing.Size(158, 20);
            this.txt_Alamat.TabIndex = 1;
            // 
            // txt_Telp
            // 
            this.txt_Telp.Location = new System.Drawing.Point(138, 222);
            this.txt_Telp.Name = "txt_Telp";
            this.txt_Telp.Size = new System.Drawing.Size(158, 20);
            this.txt_Telp.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(25, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "D";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cb_Matpel
            // 
            this.cb_Matpel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Matpel.FormattingEnabled = true;
            this.cb_Matpel.Location = new System.Drawing.Point(138, 114);
            this.cb_Matpel.Name = "cb_Matpel";
            this.cb_Matpel.Size = new System.Drawing.Size(158, 21);
            this.cb_Matpel.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "TTL";
            // 
            // dtp_TTL
            // 
            this.dtp_TTL.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_TTL.Location = new System.Drawing.Point(138, 186);
            this.dtp_TTL.Name = "dtp_TTL";
            this.dtp_TTL.Size = new System.Drawing.Size(158, 20);
            this.dtp_TTL.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Telp";
            // 
            // nud_Jamkerja
            // 
            this.nud_Jamkerja.Location = new System.Drawing.Point(138, 260);
            this.nud_Jamkerja.Name = "nud_Jamkerja";
            this.nud_Jamkerja.Size = new System.Drawing.Size(158, 20);
            this.nud_Jamkerja.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Jam Kerja";
            // 
            // txt_Nama
            // 
            this.txt_Nama.Location = new System.Drawing.Point(138, 297);
            this.txt_Nama.Name = "txt_Nama";
            this.txt_Nama.Size = new System.Drawing.Size(158, 20);
            this.txt_Nama.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Nama";
            // 
            // Guru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 371);
            this.Controls.Add(this.nud_Jamkerja);
            this.Controls.Add(this.dtp_TTL);
            this.Controls.Add(this.cb_Matpel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txt_Nama);
            this.Controls.Add(this.txt_Telp);
            this.Controls.Add(this.txt_Alamat);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Guru";
            this.Text = "Guru";
            this.Load += new System.EventHandler(this.Guru_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_Jamkerja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txt_Alamat;
        private System.Windows.Forms.TextBox txt_Telp;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cb_Matpel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_TTL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nud_Jamkerja;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Nama;
        private System.Windows.Forms.Label label7;
    }
}