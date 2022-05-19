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

namespace Starter.FormMaster
{
    public partial class Pelajaran : Form
    {
        private FormMain.Mastergrid form = null;

        public Pelajaran()
        {
            InitializeComponent();
        }

        private void Pelajaran_Load(object sender, EventArgs e)
        {
            if (form == null)
            {
                //IMPORTANT
                form = (FormMain.Mastergrid)Tag;
            }

            if (form.M_ActionMode == FormMain.Mastergrid.ActionMode.New)
            {
                btnDelete.Visible = false;

                txt_ID.Text = "";
                txt_Nama.Text = "";
                nud_Jam.Value = 0;
            }
            else
            {
                btnDelete.Visible = true;

                txt_ID.Text = form.M_Row["matpel_id"].ToString();
                txt_Nama.Text = form.M_Row["matpel_nama"].ToString();
                nud_Jam.Value = Convert.ToInt32(form.M_Row["matpel_hour"]);
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            DML_Command(form.M_ActionMode == FormMain.Mastergrid.ActionMode.New ? "INSERT" : "UPDATE");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Program.WarningTwice("Hapus Data?") == DialogResult.Cancel) return;

            DML_Command("DELETE");
        }

        private void DML_Command(string dmlcommand)
        {
            string query =
                $"exec m_Pelajaran_DML '{dmlcommand}', '" +
                $"{txt_ID.Text}', '" +
                $"{txt_Nama.Text}', " +
                $"{nud_Jam.Value}";

            string executeddml = DB.DMLExecute(query);

            if (executeddml == "")
            {
                Close();
            }
            else
            {
                MessageBox.Show(executeddml);
            }
        }




    }
}
