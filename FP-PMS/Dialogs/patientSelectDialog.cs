using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Mail;
using System.Net.Mime;
using FP_PMS.Ex;
using FP_PMS.Db;

namespace FP_PMS.Dialogs
{
    public partial class patientSelectDialog : DevExpress.XtraEditors.XtraForm
    {
        tblPatient _myPatient = new tblPatient();
        public tblPatient myPatient { get { return _myPatient; } set { _myPatient = value; } }

        public patientSelectDialog()
        {
            InitializeComponent();
        }

        private void patientLinqInstantFeedBackSource_DismissQueryable(object sender, DevExpress.Data.Linq.GetQueryableEventArgs e)
        {
            ((dbContextDataContext)e.Tag).Dispose();
        }

        private void patientLinqInstantFeedBackSource_GetQueryable(object sender, DevExpress.Data.Linq.GetQueryableEventArgs e)
        {
            var newConnection = new dbContextDataContext();
            e.QueryableSource = newConnection.tblPatients;

            e.Tag = newConnection;
        }

        private void patientLookUp_EditValueChanged(object sender, EventArgs e)
        {
            if(patientLookUpView.GetFocusedRow() != null)
            myPatient = (tblPatient)patientLookUpView.GetFocusedRow();
        }

        private void quitBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void patientSelectDialog_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                this.okBtn_Click(sender, e);
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.quitBtn_Click(sender, e);
            }
        }
    }
}