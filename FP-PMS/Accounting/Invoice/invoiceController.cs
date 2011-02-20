using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.ComponentModel;
using System.Windows.Forms;
using System.Reflection;
using FP_PMS.Report;
using FP_PMS.Db;
using FP_PMS.Ex;


namespace FP_PMS.Accounting.Invoice
{
    public class invoiceController
    {
        public invoiceViewForm myForm { get; set; }
        public claimantSelectViewForm myClaimantSelectForm { get; set; }
        public addItemForm myAddItemForm { get; set; }
        public tblClaimant myClaimant { get; set; }
        public Receipt.receiptViewForm myReceiptForm { get; set; }
        
        private decimal _invoiceTotal;
        private bool _invoiceChanged = false;
        public bool invoiceChanged { get { return _invoiceChanged; } set { _invoiceChanged = value; } }
        
        private tblInvoice _myInvoice = new tblInvoice();
        private tblTransaction _myTransaction = new tblTransaction();

        public tblTransaction myTransaction { get { return _myTransaction; } set { _myTransaction = value; } }
        public tblInvoice myInvoice { get { return _myInvoice; } set { _myInvoice = value; } }

        public BindingList<tblPatientStat> myInvoiceLines = new BindingList<tblPatientStat> { };
        public BindingList<tblReceipt> myReceipts = new BindingList<tblReceipt> { };
        public BindingList<tblInvoiceReceipt> myReceiptAmounts = new BindingList<tblInvoiceReceipt> { };

        private void updateInvoiceForm()
        {
            myForm.invoiceStatusLabel.Text = @"Invoice #: " + myInvoice.InvoiceNo.ToString();
        }

        public void makeInvoiceOfficial()
        {
            myForm.invoiceStatusLabel.BackColor = System.Drawing.Color.AliceBlue;
            myForm.clearBtn.Enabled = false;
            myForm.addLineBtn.Enabled = false;
            myForm.removeLineBtn.Enabled = false;
            myForm.applyBtn.Enabled = false;
        }

        private void registeFormEvents()
        {
            myForm.invoiceCommentsMemoEdit.Text = myInvoice.InvoiceComments;

            myForm.claimantMemoEdit.Text = "ID: " + myClaimant.ClaimantID + Environment.NewLine +
                myClaimant.FirstNames + Environment.NewLine + myClaimant.LastName;
            myForm.claimantBillingAddressMemoEdit.Text = myClaimant.Address1 + Environment.NewLine
                + myClaimant.Address2 + Environment.NewLine + myClaimant.Address3 + " " + myClaimant.Postcode;

            myForm.applyBtn.Click += new EventHandler(applyBtn_Click);
            myForm.removeLineBtn.Click += removeLineBtn_Click;
            myForm.clearBtn.Click += new EventHandler(clearBtn_Click);
            myForm.addLineBtn.Click += new EventHandler(addLineBtn_Click);
            myForm.receiptBtn.Click += new EventHandler(receiptBtn_Click);
            myForm.printBtn.Click += new EventHandler(printBtn_Click);
          
            myForm.invoiceLineGridControl.DataSource = myInvoiceLines;
            myForm.formSearchLookUpEdit.Properties.DataSource = myReceipts;
        }

        public void commitInvoice()
        {
            var newConnection = new dbContextDataContext();
            myInvoice.InvoiceComments = myForm.invoiceCommentsMemoEdit.Text;
            
            
            myInvoice.InvoicePaid = false;
            myInvoice.InvoiceCancelled = false;
            myTransaction.TranType = "I";
            myTransaction.TranDate = System.DateTime.Today;
            myTransaction.ClaimantID = myClaimant.ClaimantID;
            myTransaction.InvoiceNo = myInvoice.InvoiceNo;
            myTransaction.Narrative = "Normal Invoice";
            myTransaction.TranAmount = decimal.Add(myInvoiceLines.Sum(line => line.Fee).GetValueOrDefault(0.0M), 
                myInvoiceLines.Sum(gst => gst.GST).GetValueOrDefault(0.0M));
            myTransaction.GST = myInvoiceLines.Sum(line => line.GST).GetValueOrDefault(0.0M);

            newConnection.tblTransactions.InsertOnSubmit(myTransaction);
            newConnection.tblInvoices.InsertOnSubmit(myInvoice);

            newConnection.SubmitChanges();
            myTransaction.InvoiceNo = myInvoice.InvoiceNo;
            newConnection.SubmitChanges();

            foreach (tblPatientStat line in myInvoiceLines)
            {
                line.InvoiceNo = myInvoice.InvoiceNo;
                newConnection.tblPatientStats.InsertOnSubmit(line);
            }
            newConnection.SubmitChanges();

            this.updateInvoiceForm();
            this.makeInvoiceOfficial();
        }

        //When making a blank invoice.
        public void chooseClaimant()
        {
            myClaimantSelectForm = new claimantSelectViewForm();
            myClaimantSelectForm.ShowDialog();

            if (myClaimantSelectForm.DialogResult == DialogResult.OK)
            {
                myClaimant = myClaimantSelectForm.myClaimant;
                this.newInvoice();
                myClaimantSelectForm.Dispose();
            }
        }

        //When Called by another form or function
        public void chooseClaimant(int PatientID)
        {
            myClaimantSelectForm = new claimantSelectViewForm(PatientID);
            myClaimantSelectForm.ShowDialog();

            if (myClaimantSelectForm.DialogResult == DialogResult.OK)
            {
                myClaimant = myClaimantSelectForm.myClaimant;
                this.newInvoice();
                myClaimantSelectForm.Dispose();
            }
        }

        public void viewInvoice(tblInvoice thisInvoice)
        {
            myForm = new invoiceViewForm();
            myInvoice = thisInvoice;

            var newConnection = new dbContextDataContext();

            var Lines = newConnection.tblPatientStats.Where(lines => lines.InvoiceNo == thisInvoice.InvoiceNo);
            foreach (var line in Lines)
            {
                myInvoiceLines.Add(line);
            }

            myTransaction = newConnection.tblTransactions.
                Where(transaction => (transaction.InvoiceNo == thisInvoice.InvoiceNo) && (transaction.TranType == "I")).FirstOrDefault();
            myClaimant = newConnection.tblClaimants.Where(claimant => claimant.ClaimantID == myTransaction.ClaimantID).FirstOrDefault();

            if (myTransaction == null)
            {
                myTransaction = new tblTransaction();
            }

            if (myInvoice == null)
            {
                myInvoice = new tblInvoice();
            }

            if (myClaimant == null)
            {
                myClaimant = new tblClaimant();
            }

            var receiptAmounts = newConnection.tblInvoiceReceipts.Where(rm => rm.InvoiceNo == myInvoice.InvoiceNo);
            var receipts = from rm in receiptAmounts
                           from r in newConnection.tblReceipts.Where(r => r.ReceiptNo == rm.ReceiptNo)
                           select r;

            // Second query to get receipts from another table. I might combine the two tables come deployment.

            var receiptAmounts2 = from rm in newConnection.tblReceiptInvoices
                            where rm.InvoiceNo == myInvoice.InvoiceNo
                            select new 
                            {
                                InvoiceNo = rm.InvoiceNo,
                                ReceiptNo = rm.ReceiptNo,
                                InvRecAmnt = rm.Received
                            };

            foreach (var receipt in receiptAmounts2)
            {
                var receiptAmount = new tblInvoiceReceipt();
                receiptAmount.InvoiceNo = receipt.InvoiceNo;
                receiptAmount.InvRecAmnt = receipt.InvRecAmnt;
                receiptAmount.ReceiptNo = receipt.ReceiptNo;
                myReceiptAmounts.Add(receiptAmount);
            }

            foreach (var receipt in receipts)
            {
                myReceipts.Add(receipt);
            }

            foreach (var receiptAmount in receiptAmounts)
            {
                myReceiptAmounts.Add(receiptAmount);
            }

            myForm.invoiceDateEdit.DateTime = myTransaction.TranDate.Value;
            registeFormEvents();
            updateInvoiceForm();
            makeInvoiceOfficial();
            myForm.ShowDialog();
            Cursor.Current = Cursors.Default;
            applyPaid();
        }

        void applyPaid()
        {
            if (this.myReceiptAmounts.Sum(r => r.InvRecAmnt).GetValueOrDefault(0.0M) >= (this.myInvoiceLines.Sum(f => f.Fee) + this.myInvoiceLines.Sum(g => g.GST)))
            {
                var newConnection = new dbContextDataContext();
                var thisInvoice = newConnection.tblInvoices.Where(inv => inv.InvoiceNo == myInvoice.InvoiceNo).SingleOrDefault();
                if (thisInvoice != null)
                {
                    thisInvoice.InvoicePaid = true;
                    newConnection.SubmitChanges();
                    this.invoiceChanged = true;
                }
            }
        }

        public void newInvoice()
        {
            myForm = new invoiceViewForm();

            registeFormEvents();

            myForm.invoiceDateEdit.DateTime = System.DateTime.Today;
            myForm.ShowDialog();
            applyPaid();

            if ((myForm.DialogResult == DialogResult.OK) && (myInvoice.InvoiceNo == 0))
            {
                if (myInvoiceLines.Any())
                {
                    commitInvoice();
                }
            }
            myForm.Dispose();
        }

        public void newReceipt()
        {
            myReceiptForm = new Receipt.receiptViewForm(myInvoice, myClaimant);
            myReceiptForm.ShowDialog();
            if (myReceiptForm.DialogResult == DialogResult.OK)
            {
                invoiceChanged = true;
                this.myReceipts.Add(myReceiptForm.myReceipt);
                foreach (var x in myReceiptForm.myInvoiceReceipts)
                {
                    this.myReceiptAmounts.Add(x);
                }
            }
            myReceiptForm.Dispose();
        }

        public void newAddItem()
        {
            myAddItemForm = new addItemForm(myClaimant);
            
            myAddItemForm.ShowDialog();
            if (myAddItemForm.DialogResult == DialogResult.OK)
            {
                this.myInvoiceLines.Add(myAddItemForm.myLine);
            }
            myAddItemForm.Dispose();
        }



        public invoiceController()
        {
            this.myInvoiceLines.ListChanged += new ListChangedEventHandler(myInvoiceLines_ListChanged);
            this.myReceipts.ListChanged += new ListChangedEventHandler(myReceipts_ListChanged);
            this.myReceiptAmounts.ListChanged += new ListChangedEventHandler(myReceiptAmounts_ListChanged);
        }

        void myReceiptAmounts_ListChanged(object sender, ListChangedEventArgs e)
        {
            //decimal paidTotal = (decimal)myReceipts.Sum(od => od.ReceiptAmnt);
            decimal paidTotal = (decimal)myReceiptAmounts.Sum(p => p.InvRecAmnt);
            decimal dueTotal = decimal.Subtract(_invoiceTotal, paidTotal);

            myForm.paidSpinEdit.Value = paidTotal;
            myForm.dueSpinEdit.Value = dueTotal;
        }

        void myReceipts_ListChanged(object sender, ListChangedEventArgs e)
        {
            var newConnection = new dbContextDataContext();

            //decimal paidTotal = (decimal)myReceipts.Sum(od => od.ReceiptAmnt);
            decimal paidTotal = (decimal)myReceiptAmounts.Sum(p => p.InvRecAmnt);

            decimal dueTotal = decimal.Subtract(_invoiceTotal, paidTotal);



            myForm.paidSpinEdit.Value = paidTotal;
            myForm.dueSpinEdit.Value = dueTotal;
        }

        void myInvoiceLines_ListChanged(object sender, ListChangedEventArgs e)
        {
            decimal feeTotal = (decimal)myInvoiceLines.Sum(od => od.Fee);
            decimal gstTotal = (decimal)myInvoiceLines.Sum(od => od.GST);
            
            _invoiceTotal = decimal.Add(feeTotal, gstTotal);

            myForm.feeSpinEdit.Value = feeTotal;
            myForm.gstSpinEdit.Value = gstTotal;
            myForm.invoiceTotalSpinEdit.Value = _invoiceTotal;

            decimal paidTotal = (decimal)myReceipts.Sum(od => od.ReceiptAmnt);
            decimal dueTotal = decimal.Subtract(_invoiceTotal, paidTotal);

            myForm.paidSpinEdit.Value = paidTotal;
            myForm.dueSpinEdit.Value = dueTotal;
        }

        void addLineBtn_Click(object sender, EventArgs e)
        {
            newAddItem();
        }

        void clearBtn_Click(object sender, EventArgs e)
        {
            myInvoiceLines.Clear();
        }

        void receiptBtn_Click(object sender, EventArgs e)
        {
            if (this.myInvoiceLines.Any())
            {
                if (myInvoice.InvoicePaid != true)
                {
                    var newConnection = new dbContextDataContext();
                    if (newConnection.tblInvoices.SingleOrDefault(od => od.InvoiceNo == myInvoice.InvoiceNo) == null)
                    { this.commitInvoice(); }
                        
                    this.newReceipt();
                }
                else
                {
                    MessageBox.Show("This invoice has being paid in full.");
                }
            }
            else
            {
                MessageBox.Show("Can not create receipt for an empty invoice.");
                myForm.DialogResult = DialogResult.Retry;
            }
        }

        void printBtn_Click(object sender, EventArgs e)
        {
            this.printInvoice();
        }

        void printInvoice()
        {
            if (this.myInvoiceLines.Any())
            {
                if (myInvoice.InvoicePrinted != true)
                {
                    myInvoice.InvoicePrinted = true;
                    commitInvoice();
                }

                var InvoiceReportForm = new Report.invoicePrintReport(myInvoice, myClaimant, myInvoiceLines);
                InvoiceReportForm.ShowPreviewDialog();
                InvoiceReportForm.Dispose();
            }
            else
            {
                MessageBox.Show("Can not print an empty invoice.");
                myForm.DialogResult = DialogResult.Retry;
            }
        }

        void applyBtn_Click(object sender, EventArgs e)
        {
            if (this.myInvoiceLines.Any())
                this.commitInvoice();
            else
            {
                MessageBox.Show("Can not official an empty invoice.");
                myForm.DialogResult = DialogResult.Retry;
            }
        }

        void  removeLineBtn_Click(object sender, EventArgs e)
        {
           var rowToDelete = (tblPatientStat)myForm.invoiceLineView.GetFocusedRow();
           if (rowToDelete != null)
           {
               myInvoiceLines.Remove(rowToDelete);
           }
        }

    }

}
