using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Linq;
using System.Linq.Expressions;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FP_PMS.Db;
using FP_PMS.Ex;

namespace FP_PMS.Accounting.Invoice
{
    public partial class cancellInvoiceViewForm : FP_PMS.Templates.level2TemplateForm
    {
        tblClaimant _myClaimant = new tblClaimant();
        DateTime _startDate = new DateTime();
        DateTime _endDate = new DateTime();
        BindingList<AnonUnCancelledInvoices> myInvoiceList = new BindingList<AnonUnCancelledInvoices> { };
        dbContextDataContext newConnection = new dbContextDataContext();

        public tblClaimant myClaimant { get { return _myClaimant; } set { _myClaimant = value; } }
        public DateTime startDate { get { return _startDate; } set { _startDate = value; } }
        public DateTime endDate { get { return _endDate; } set { _endDate = value; } }

        public cancellInvoiceViewForm(tblClaimant MyClaimant, DateTime Start, DateTime End)
        {
            InitializeComponent();
            myClaimant = MyClaimant;
            startDate = Start;
            endDate = End;
            myInvoiceList.AllowEdit = true;
        }

        void saveData()
        {
            
            foreach (var i in myInvoiceList)
            {
                if (i.InvoiceCancelled == true)
                {
                    var invoice = newConnection.tblInvoices.Where(inv => inv.InvoiceNo == i.InvoiceNo).FirstOrDefault();
                    
                    if (invoice != null)
                    {
                        invoice.InvoiceCancelled = true;
                        var receipts = (from r in newConnection.tblInvoiceReceipts
                                        from rc in newConnection.tblReceipts
                                        where (rc.ReceiptNo == r.ReceiptNo) && (r.InvoiceNo == i.InvoiceNo)
                                        select rc);
                        if (receipts.Any())
                        {
                            foreach (var rb in receipts)
                            {
                                rb.ReceiptCancelled = true;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invoice file corrupt, can not update.");
                    }
                    
                }
            }

            newConnection.SubmitChanges();
        }

        public override void okBtn_Click(object sender, EventArgs e)
        {
            
            base.okBtn_Click(sender, e);
            Cursor.Current = Cursors.WaitCursor;
            saveData();
            Cursor.Current = Cursors.Default;
            
        }

        private void cancellInvoiceViewForm_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            
            var invoicelist = (from i in newConnection.getUnCancelledInvoices(myClaimant.ClaimantID, startDate, endDate)
                               select new AnonUnCancelledInvoices
                               {
                                   InvoiceAmount  = i.InvoiceAmount.GetValueOrDefault(0.0M),
                                   InvoiceCancelled = i.InvoiceCancelled.GetValueOrDefault(false),
                                   InvoiceDate = i.InvoiceDate.GetValueOrDefault(System.DateTime.MinValue),
                                   InvoiceNo = i.InvoiceNo.GetValueOrDefault(0)
                               }).ToList();

            myInvoiceList = new BindingList<AnonUnCancelledInvoices>(invoicelist);
            cancellInvoiceGridControl.DataSource = myInvoiceList;
            Cursor.Current = Cursors.Default;
        }
    }
}
