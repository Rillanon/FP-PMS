using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Linq.Expressions;
using FP_PMS.Db;

namespace FP_PMS.Patient
{
    public partial class patientInvoiceViewForm : FP_PMS.Templates.level2TemplateForm
    {
        private tblPatient _myPatient;
        private tblInvoice _myInvoice;

        public tblInvoice myInvoice { get { return _myInvoice; } set { _myInvoice = value; } }
        public tblPatient myPatient { get { return _myPatient; } set { _myPatient = value; } }

        public patientInvoiceViewForm(tblPatient MyPatient)
        {
            InitializeComponent();
            myPatient = MyPatient;
        }

        private void patientInvoiceViewForm_Load(object sender, EventArgs e)
        {
            var newConnection = new dbContextDataContext();
            patientInvoiceGridControl.DataSource  = (from p in newConnection.tblTransactions
                                             join t in newConnection.tblPatients
                                             on p.PatientID equals t.PatientID
                                             where p.PatientID == 10834
                                             select p).Distinct();
        }

        private void patientInvoiceView_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            var newTransaction = (tblTransaction)this.patientInvoiceView.GetFocusedRow();
            var newConnection = new dbContextDataContext();
            var currentInvoice = newConnection.tblInvoices.SingleOrDefault(od => od.InvoiceNo == newTransaction.InvoiceNo);
            if (currentInvoice != null)
            {
                myInvoice = currentInvoice;
                this.DialogResult = DialogResult.OK;
            }

            else
            {
                MessageBox.Show("This invoice was not found.");
                this.DialogResult = DialogResult.Retry;
            }
        }
    }
}
