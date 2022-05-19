using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Starter.FormMain
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();

            this.Text = DB.MSSQLCreateConnection();
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Text = DB.MSSQLCloseConnection();
        }

        private void ts_Test_Click(object sender, EventArgs e)
        {
            //check connection MSSQL - ok
            //this.Text = DB.MSSQLCheckConnection();

            //check encrpyt appconfig - ok
            //string begin = "010101";
            //DB.Password = begin;
            //MessageBox.Show(
            //    $"begin \t: {begin}\n" +
            //    $"encrypt \t: {Program.AppSettings("password")}\n" +
            //    $"decrypt \t: {DB.Password}");
        }

        private void tsMaster_Kelas_Click(object sender, EventArgs e)
        {
            FormMaster.Kelas originfrm = new FormMaster.Kelas();

            string q = $"exec m_kelas_DML 'SELECT'{DB.MultiplyNULL(3)}";
            Mastergrid mastergrid = new Mastergrid(originfrm, q);
            mastergrid.MdiParent = this;
            mastergrid.Show();
        }

        private void tsMaster_Matpel_Click(object sender, EventArgs e)
        {
            FormMaster.Pelajaran originfrm = new FormMaster.Pelajaran();

            string q = $"exec m_pelajaran_DML 'SELECT'{DB.MultiplyNULL(3)}";
            Mastergrid mastergrid = new Mastergrid(originfrm, q);
            mastergrid.MdiParent = this;
            mastergrid.Show();
        }

        private void tsMaster_Guru_Click(object sender, EventArgs e)
        {
            FormMaster.Guru originfrm = new FormMaster.Guru();

            string q = $"exec m_guru_DML 'SELECT'{DB.MultiplyNULL(7)}";
            Mastergrid mastergrid = new Mastergrid(originfrm, q);
            mastergrid.MdiParent = this;
            mastergrid.Show();
        }

    }
}
