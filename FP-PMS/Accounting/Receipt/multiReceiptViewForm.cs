using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.Linq;
using System.Linq;
using System.Linq.Expressions;
using FP_PMS.Ex;
using FP_PMS.Db;    

namespace FP_PMS.Accounting.Receipt
{
    public partial class multiReceiptViewForm : FP_PMS.Templates.level2TemplateForm
    {
        tblClaimant _myClaimant = new tblClaimant();
        public tblClaimant myClaimant { get { return _myClaimant; } set { _myClaimant = value; } }
        tblReceipt _myReceipt = new tblReceipt();
        public tblReceipt myReceipt { get { return _myReceipt; } set { _myReceipt = value; } }

        private BindingList<AnonUnPaidInvoice> myUnPaidInvoices = new BindingList<AnonUnPaidInvoice> { };
        private BindingList<tblPayin> myPayments = new BindingList<tblPayin> { };
        private DateTime startDate;
        private DateTime endDate;

        void updateForm()
        {
            var newConnection = new dbContextDataContext();

            var unpaidlist =
                (from u in newConnection.getUnPaidInvoices(myClaimant.ClaimantID)
                 select new AnonUnPaidInvoice
                 {
                     Balance = u.Balance.GetValueOrDefault(u.InvoiceTotal.Value),
                     InvoiceDate = u.InvoiceDate.Value,
                     InvoiceTotal = u.InvoiceTotal.GetValueOrDefault(0.0M),
                     ReceiptTotal = u.ReceiptTotal.GetValueOrDefault(0.0M),
                     InvoiceNo = u.InvoiceNo,
                     ReceiptAmount = 0.0M
                 }).ToList();

            myUnPaidInvoices = new BindingList<AnonUnPaidInvoice>(unpaidlist);
        }

        void myPayments_ListChanged(object sender, ListChangedEventArgs e)
        {
            receiptTotalSpinEdit.Value = myPayments.Sum(p => p.PayinAmnt).GetValueOrDefault(0.0M);
        }

        void updateClaimantDetails()
        {
            claimantDetailMemoEdit.Text = "ID: " + myClaimant.ClaimantID + Environment.NewLine +
            myClaimant.FirstNames + Environment.NewLine + myClaimant.LastName + Environment.NewLine +
            myClaimant.Address1 + Environment.NewLine
            + myClaimant.Address2 + Environment.NewLine + myClaimant.Address3 + " " + myClaimant.Postcode;
        }

        public multiReceiptViewForm(tblClaimant MyClaimant, DateTime Start, DateTime End, tblReceipt MyReceipt, BindingList<tblPayin> MyPayments)
        {
            InitializeComponent();
            this.myClaimant = MyClaimant;
            startDate = Start;
            endDate = End;
            myUnPaidInvoices.AllowEdit = true;
            myUnPaidInvoices.AllowNew = true;
            myUnPaidInvoices.AllowRemove = true;
            myPayments.ListChanged += new ListChangedEventHandler(myPayments_ListChanged);

            myReceipt = MyReceipt;
            foreach (var p in MyPayments)
            {
                myPayments.Add(p);
            }

            updateForm();
            multipleReceiptGridControl.DataSource = myUnPaidInvoices;
            updateClaimantDetails();
        }

        void applyReceipt()
        {
            var newConnection = new dbContextDataContext();
            
            myReceipt.ReceiptDate = System.DateTime.Today;
            myReceipt.ReceiptAmnt = myPayments.Sum(p => p.PayinAmnt);
            myReceipt.UserID = staticProperties.userName;
            myReceipt.IsMulti = true;
            
            newConnection.tblReceipts.InsertOnSubmit(myReceipt);
            newConnection.SubmitChanges();

            foreach (var p in myPayments)
            {
                p.ReceiptNo = myReceipt.ReceiptNo;
                if (p.PayinType == "7")
                {
                    var c = new tblReceiptCreditPatient();
                    c.ClaimantID = myClaimant.ClaimantID;
                    c.CreditAmnt = p.PayinAmnt;
                    c.ReceiptNo = myReceipt.ReceiptNo;
                    c.ReceiptDate = myReceipt.ReceiptDate;

                    newConnection.tblReceiptCreditPatients.InsertOnSubmit(c);
                }

                newConnection.tblPayins.InsertOnSubmit(p);
            }
            newConnection.SubmitChanges();
        }

        public override void okBtn_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            base.okBtn_Click(sender, e);

            if (this.myUnPaidInvoices.Any() != true)
            {
                MessageBox.Show("Can not process receipt. This claimant have no unpaid invoices.");
                this.DialogResult = DialogResult.Retry;
                return;
            }

            if (this.DialogResult == DialogResult.OK)
            {
                applyReceipt();

                var paidlist = new List<int> { };
                var newConnection = new dbContextDataContext();
                foreach (var i in myUnPaidInvoices)
                {
                    if(!object.Equals(i.ReceiptAmount, default(decimal)))
                    {
                        var ir = new tblInvoiceReceipt();
                        ir.InvRecAmnt = i.ReceiptAmount;
                        ir.InvoiceNo = i.InvoiceNo;
                        ir.ReceiptNo = myReceipt.ReceiptNo;
                        newConnection.tblInvoiceReceipts.InsertOnSubmit(ir);
                    }
                    if ((i.ReceiptAmount + i.ReceiptTotal) == i.InvoiceTotal)
                    {
                        paidlist.Add(i.InvoiceNo);
                    }
                }

                foreach (var p in paidlist)
                {
                    var inv = newConnection.tblInvoices.Where(i => i.InvoiceNo == p).SingleOrDefault();
                    if(inv !=null)
                    inv.InvoicePaid = true;
                }

                if (myPayments.Sum(p => p.PayinAmnt).Value > myUnPaidInvoices.Sum(u => u.ReceiptAmount))
                {
                    var result = MessageBox.Show("Fund remaining, do you want to save this as a credit?", "OVERPAYMENT",
                             MessageBoxButtons.YesNoCancel,
                             MessageBoxIcon.Question);

                    
                    if (result == DialogResult.Yes)
                    {
                        var newCredit = new Db.Credit();
                        newCredit.CreditComment = "Overpayment on Receipt #: " + myReceipt.ReceiptNo.ToString();
                        newCredit.CreditDate = System.DateTime.Today;
                        newCredit.CreditType = 3;
                        newCredit.ClaimantID = myClaimant.ClaimantID;
                        newCredit.CreditCancelled = false;
                        newCredit.CreditAmount = decimal.Subtract(myPayments.Sum(p => p.PayinAmnt).Value, myUnPaidInvoices.Sum(u => u.ReceiptAmount));
                        newConnection.Credits.InsertOnSubmit(newCredit);
                    }

                    if (result == DialogResult.No)
                    {
                        //proceed as normal.
                    }

                    if (result == DialogResult.Cancel)
                    {
                        this.DialogResult = DialogResult.Retry;
                        return;
                    }
                }

                newConnection.SubmitChanges();
            }
            Cursor.Current = Cursors.Default;
        }

        private void multipleReceiptView_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo HI = multipleReceiptView.CalcHitInfo((e as MouseEventArgs).Location);

            if ((HI.InRow == true) && (HI.Column.FieldName == "ReceiptAmount"))
            {
                decimal receiptTotal = myPayments.Sum(p => p.PayinAmnt).GetValueOrDefault(0.0M);
                decimal appliedTotal = myUnPaidInvoices.Sum(u => u.ReceiptAmount);

                var currentRow = (AnonUnPaidInvoice)multipleReceiptView.GetRow(e.RowHandle);
                if (currentRow != null)
                { 
                if (appliedTotal < receiptTotal)
                {
                    if (currentRow.ReceiptAmount != currentRow.Balance)
                    {
                            var remaining = decimal.Subtract(receiptTotal, appliedTotal);
                            if (remaining >= currentRow.Balance)
                            {
                                multipleReceiptView.SetRowCellValue(e.RowHandle, "ReceiptAmount", currentRow.Balance);
                            }
                            else
                            {
                            multipleReceiptView.SetRowCellValue(e.RowHandle, "ReceiptAmount", remaining);
                            }

                            appliedAmountSpinEdit.Value = myUnPaidInvoices.Sum(u => u.ReceiptAmount);
                            remainingSpinEdit.Value = decimal.Subtract(receiptTotal, appliedAmountSpinEdit.Value);
                        }
                    }

                    if (appliedTotal >= receiptTotal)
                    {
                        MessageBox.Show("No more funds to allocate.");
                    }
                }
            }
        }

        private void invoiceDetailsBtn_Click(object sender, EventArgs e)
        {
            if ((AnonUnPaidInvoice)multipleReceiptView.GetFocusedRow() != null)
            {
                var currentRow = (AnonUnPaidInvoice)multipleReceiptView.GetFocusedRow();
                
                Cursor.Current = Cursors.WaitCursor;
                var newConnection = new dbContextDataContext();


                var currentInvoice = newConnection.tblInvoices.Where(i => i.InvoiceNo == currentRow.InvoiceNo).SingleOrDefault();
                if (currentInvoice != null)
                {
                    var newInvoice = new Accounting.Invoice.newInvoiceForm(currentInvoice);
                    newInvoice.ShowDialog();

                    if (newInvoice.DialogResult == DialogResult.OK)
                        updateForm();
                    newInvoice.Dispose();
                }
                else
                {
                    MessageBox.Show("Data corrupt, can not retrieve invoice.");
                }

            }
            else
                this.DialogResult = DialogResult.Retry;
        }
    }
}
