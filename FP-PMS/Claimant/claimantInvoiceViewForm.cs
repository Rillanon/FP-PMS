using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;
using FP_PMS.Db;
using FP_PMS.Ex;

namespace FP_PMS.Claimant
{
    public partial class claimantInvoiceViewForm : FP_PMS.Templates.level2TemplateForm
    {
        private tblClaimant _myClaimant;
        private DateTime StartDate;
        private DateTime EndDate;
        BindingList<getClaimantInvoicesResult> myInvoiceList = new BindingList<getClaimantInvoicesResult> { };
       

        public tblClaimant myClaimant { get { return _myClaimant; } set { _myClaimant = value; } }

        void updateForm()
        {
            Cursor.Current = Cursors.WaitCursor;
            var newConnection = new dbContextDataContext();
            myInvoiceList = new BindingList<getClaimantInvoicesResult>(newConnection.getClaimantInvoices(myClaimant.ClaimantID, StartDate, EndDate).ToList());
            this.claimantInvoiceGridControl.DataSource = myInvoiceList;

            decimal? invoiceTotal = 0;
            decimal? receiptTotal = 0;

            newConnection.getClaimantInvoiceTotal(myClaimant.ClaimantID, StartDate, EndDate, ref invoiceTotal);
            newConnection.getClaimantReceiptTotal(myClaimant.ClaimantID, StartDate, EndDate, ref receiptTotal);

            invoiceTotalSpinEdit.Value = invoiceTotal.GetValueOrDefault(0.0M);
            receiptTotalSpinEdit.Value = receiptTotal.GetValueOrDefault(0.0M);
            balanceSpinEdit.Value = decimal.Subtract(invoiceTotal.GetValueOrDefault(0.0M), receiptTotal.GetValueOrDefault(0.0M));
            Cursor.Current = Cursors.Default;
        }

        public claimantInvoiceViewForm(tblClaimant MyClaimant, DateTime Start, DateTime End)
        {
            InitializeComponent();
            myClaimant = MyClaimant;
           
            StartDate = Start;
            EndDate = End;
            updateForm();

            myInvoiceList.AllowEdit = true;
            
            claimantDetailMemoEdit.Text = "ID: " + myClaimant.ClaimantID + Environment.NewLine +
    myClaimant.FirstNames + Environment.NewLine + myClaimant.LastName + Environment.NewLine + 
            myClaimant.Address1 + Environment.NewLine
                + myClaimant.Address2 + Environment.NewLine + myClaimant.Address3 + " " + myClaimant.Postcode;
        }

        public override void okBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void paidSpinEdit_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
            
            e.DisplayText = "$" + string.Format("{0:c}", e.DisplayText);
        }

        private void claimantInvoiceGridControl_Click(object sender, EventArgs e)
        {

        }

        private void claimantInvoicesView_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {

        }

        private void claimantInvoicesView_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {

        }

        private void invoiceDetailsBtn_Click(object sender, EventArgs e)
        {
            if ((getClaimantInvoicesResult)claimantInvoicesView.GetFocusedRow() != null)
            {
                    var currentRow = (getClaimantInvoicesResult)claimantInvoicesView.GetFocusedRow();
                    var newConnection = new dbContextDataContext();
                    var currentInvoice = newConnection.tblInvoices.Where(i => i.InvoiceNo == currentRow.InvoiceNo).SingleOrDefault();
                    
                    if (currentInvoice != null)
                    {
                        var viewInvoice = new Accounting.Invoice.newInvoiceForm(currentInvoice);
                        viewInvoice.ShowDialog();
                        if (viewInvoice.DialogResult == DialogResult.OK)
                        {
                            updateForm();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Data corrupt, can not retrieve invoice.");
                    }

            }
            else
                this.DialogResult = DialogResult.Retry;
        }

        private void claimantInvoiceViewForm_Load(object sender, EventArgs e)
        {

        }

        private void linqInstantFeedbackSource1_DismissQueryable(object sender, DevExpress.Data.Linq.GetQueryableEventArgs e)
        {
            ((dbContextDataContext)e.Tag).Dispose();
        }

        private void linqInstantFeedbackSource1_GetQueryable(object sender, DevExpress.Data.Linq.GetQueryableEventArgs e)
        {
            var newConnection = new dbContextDataContext();

            e.QueryableSource = newConnection.getClaimantInvoices(myClaimant.ClaimantID, StartDate, EndDate).AsQueryable();
              
            e.Tag = newConnection;
        }

        private void newInvoiceBtn_Click(object sender, EventArgs e)
        {
            var physioChoose = new Scheduling.physioSelectDialog();
            physioChoose.ShowDialog();
            if (physioChoose.DialogResult == DialogResult.OK)
            {
                var viewInvoice = new Accounting.Invoice.newInvoiceForm(this.myClaimant, physioChoose.myPhysio);
                viewInvoice.ShowDialog();
                if (viewInvoice.DialogResult == DialogResult.OK)
                {
                    updateForm();
                }
            }
        }
    }
}
