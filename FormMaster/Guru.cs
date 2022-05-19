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
    public partial class Guru : Form
    {
        private FormMain.Mastergrid form = null;

        public Guru()
        {
            InitializeComponent();

            Fill_ComboBox();
        }

        private void Guru_Load(object sender, EventArgs e)
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
                cb_Matpel.Text = "";
                txt_Alamat.Text = "";
                dtp_TTL.Value = DateTime.Now;
                txt_Telp.Text = "";
                nud_Jamkerja.Value = 0;
                txt_Nama.Text = "";
            }
            else
            {
                btnDelete.Visible = true;

                txt_ID.Text = form.M_Row["guru_id"].ToString();
                cb_Matpel.Text = form.M_Row["matpel_id"].ToString();
                txt_Alamat.Text = form.M_Row["GURU_ALAMAT"].ToString();
                dtp_TTL.Value = DateTime.Parse(form.M_Row["GURU_TGLLAHIR"].ToString());
                txt_Telp.Text = form.M_Row["GURU_PHONE"].ToString();
                nud_Jamkerja.Value = Convert.ToInt32(form.M_Row["GURU_WORKINGTIME"]);
                txt_Nama.Text = form.M_Row["guru_nama"].ToString();
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
                $"exec m_Guru_DML '{dmlcommand}', '" +
                $"{txt_ID.Text}', '" +
                $"{cb_Matpel.SelectedValue}', '" +
                $"{txt_Alamat.Text}', '" +
                $"{dtp_TTL.Value:yyyyMMdd}', '" +
                $"{txt_Telp.Text}', " +
                $"{nud_Jamkerja.Value}, '" +
                $"{txt_Nama.Text}'";

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

        private void Fill_ComboBox()
        {
            string query = "exec m_pelajaran_DML 'SELECT'" + DB.MultiplyNULL(3);

            DataSet set = new DataSet();
            DB.MSSQLAdapter(query).Fill(set);

            cb_Matpel.ValueMember = "matpel_id";
            cb_Matpel.DisplayMember = "matpel_nama";
            cb_Matpel.DataSource = set.Tables[0];

            
        }




    }
}
