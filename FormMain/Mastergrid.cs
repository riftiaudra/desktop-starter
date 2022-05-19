using CrystalDecisions.CrystalReports.Engine;
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
    public partial class Mastergrid : Form
    {
        #region "Action Mode : New, Edit"

        public enum ActionMode { New, Edit };

        public ActionMode M_ActionMode
        {
            get { return m_actmode; }
            set { m_actmode = value; }
        }

        private ActionMode m_actmode;

        #endregion

        #region "Origin Dialog : Form from.."
        public Form OriginDialog
        {
            get { return m_frm; }
        }

        private Form m_frm;
        #endregion

        #region "Datarow : Selected row"
        public DataRow M_Row
        {
            get { return m_dr; }
            set { m_dr = value; }
        }

        private DataRow m_dr;
        #endregion

        private SqlDataAdapter m_sda;

        private DataTable m_dt;

        public Mastergrid(Form oriDialog, string query)
        {
            InitializeComponent();

            //Masterform input
            m_frm = oriDialog;

            //IMPORTANT
            OriginDialog.Tag = this;

            //Fill datagridview
            m_sda = DB.MSSQLAdapter(query);

            RefreshData();
        }


        public void RefreshData()
        {
            m_sda.Fill(m_dt = new DataTable());

            dgvMaster.ReadOnly = true;

            dgvMaster.DataSource = m_dt;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            M_ActionMode = ActionMode.New;

            OriginDialog.ShowDialog();

            RefreshData();
        }

        private void dgvMaster_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            M_Row = (dgvMaster.Rows[e.RowIndex].DataBoundItem as DataRowView).Row;



            M_ActionMode = ActionMode.Edit;

            OriginDialog.ShowDialog();

            RefreshData();
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            if (m_dt.Rows.Count <= 0) return;

            //ReportDocument crrd = new ReportDocument();
            //crrd.Load(Application.StartupPath + "\\Report\\" + this.Text + ".rpt");

            Report.Pelajaran crpt = new Report.Pelajaran();
            crpt.SetDataSource(m_dt);

            CRView frm = new CRView();
            frm.CRViewer.ReportSource = crpt;
            frm.ShowDialog();
        }
    }
}
