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
    public partial class Kelas : Form
    {
        private FormMain.Mastergrid form = null;

        public Kelas()
        {
            InitializeComponent();
        }

        private void Kelas_Load(object sender, EventArgs e)
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
                txt_Remark.Text = "";
                txt_Location.Text = "";
            }
            else
            {
                btnDelete.Visible = true;

                txt_ID.Text = form.M_Row["kelas_id"].ToString();
                txt_Remark.Text = form.M_Row["remarks"].ToString();
                txt_Location.Text = form.M_Row["location"].ToString();
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
                $"exec m_kelas_DML '{dmlcommand}', '" +
                $"{txt_ID.Text}', '" +
                $"{txt_Remark.Text}', '" +
                $"{txt_Location.Text}'";

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
