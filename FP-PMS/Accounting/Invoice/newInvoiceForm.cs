using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FP_PMS.Db;
using FP_PMS.Ex;
using FP_PMS.Interfaces;

namespace FP_PMS.Accounting.Invoice
{
    public partial class newInvoiceForm : FP_PMS.Templates.level2TemplateForm, Interfaces.IPrinting
    {
        BindingList<AnonInvoiceLines> _myLines = new BindingList<AnonInvoiceLines>();
        tblClaimant _myClaimant = new tblClaimant();
        tblPhysio _myPhysio = new tblPhysio();
        tblInvoice _myInvoice = new tblInvoice();
        tblTransaction _myTransaction = new tblTransaction();
        dbContextDataContext myConnection = new dbContextDataContext();
        bool isOfficial = false;

        BindingList<tblReceipt> _myReceipts = new BindingList<tblReceipt> { };
        BindingList<tblInvoiceReceipt> _myReceiptAmounts = new BindingList<tblInvoiceReceipt> { };

        public BindingList<AnonInvoiceLines> myLines { get { return _myLines; } set { _myLines = value; } }
        public tblClaimant myClaimant { get { return _myClaimant; } set { _myClaimant = value; } }
        public tblPhysio myPhysio { get { return _myPhysio; } set { _myPhysio = value; } }
        public tblInvoice myInvoice { get { return _myInvoice; } set { _myInvoice = value; } }
        public tblTransaction myTransaction { get { return _myTransaction; } set { _myTransaction = value; } }
        public BindingList<tblReceipt> myReceipts { get { return _myReceipts; } set { _myReceipts = value; } }
        public BindingList<tblInvoiceReceipt> myReceiptAmounts { get { return _myReceiptAmounts; } set { _myReceiptAmounts = value; } }

        public void print()
        {
            myInvoice = myConnection.tblInvoices.Where(i => i.InvoiceNo == myInvoice.InvoiceNo).SingleOrDefault();
            if (myInvoice != null)
            {
                myInvoice.InvoicePrinted = true;
            }
            myConnection.SubmitChanges();


                var InvoiceReportForm = new Report.invoicePrintReport(myInvoice, myClaimant, myTransaction);
                InvoiceReportForm.ShowPreviewDialog();
                InvoiceReportForm.Dispose();
        }

        public void printPreview()
        {

        }

        void commitNewInvoice()
        {
            Cursor.Current = Cursors.WaitCursor;
            if (myLines.Any())
            {
                myInvoice.InvoicePaid = false;
                myInvoice.InvoiceCancelled = false;

                myTransaction.TranType = "I";
                myTransaction.UserID = Ex.staticProperties.userName;
                myTransaction.TranDate = System.DateTime.Today;
                myTransaction.ClaimantID = myClaimant.ClaimantID;
                myTransaction.InvoiceNo = myInvoice.InvoiceNo;
                myTransaction.Narrative = "Normal Invoice";
                myTransaction.PhysioID = myPhysio.PhysioID;
                myTransaction.TranAmount = decimal.Add(myLines.Sum(line => line.Fee).GetValueOrDefault(0.0M),
                    myLines.Sum(gst => gst.GST).GetValueOrDefault(0.0M));
                myTransaction.GST = myLines.Sum(line => line.GST).GetValueOrDefault(0.0M);

                
                myConnection.tblInvoices.InsertOnSubmit(myInvoice);

                myConnection.SubmitChanges();

                myConnection.tblTransactions.InsertOnSubmit(myTransaction);
                myTransaction.InvoiceNo = myInvoice.InvoiceNo;

                foreach (AnonInvoiceLines line in myLines)
                {
                    var newLine = new tblPatientStat();
                    newLine.InvoiceNo = myInvoice.InvoiceNo;
                    newLine.Fee = line.Fee;
                    newLine.GST = line.GST;
                    newLine.PatientID = line.PatientID;
                    newLine.PhysioID = myPhysio.PhysioID;
                    newLine.RateID = line.RateID;
                    newLine.SessionDate = line.SessionDate;
                    newLine.ItemNo = line.ItemNo;

                    myConnection.tblPatientStats.InsertOnSubmit(newLine);
                }
                myConnection.SubmitChanges();

                this.makeInvoiceOfficial();
                Cursor.Current = Cursors.Default;
            }
            else
            {
                MessageBox.Show("You can not official an empty invoice.");
                this.DialogResult = DialogResult.Retry;
                return;
            }
        }

        public void makeInvoiceOfficial()
        {
            this.invoiceStatusLabel.BackColor = System.Drawing.Color.AliceBlue;
            this.invoiceStatusLabel.Text = "Invoice #: " + myInvoice.InvoiceNo.ToString();
            physioLookUp.Properties.ReadOnly = true;
            this.clearBtn.Enabled = false;
            this.officialBtn.Enabled = false;
            isOfficial = true;
            this.removeLineBtn.Enabled = false;
        }

        void retrieveInvoiceDetails(tblInvoice MyInvoice)
        {
            Cursor.Current = Cursors.WaitCursor;

            try
            {
                myInvoice = MyInvoice;

                var Lines = myConnection.getInvoiceLines(myInvoice.InvoiceNo).ToList();
                foreach (var line in Lines)
                {
                    AnonInvoiceLines newLine = new AnonInvoiceLines();
                    newLine.Fee = line.Fee;
                    newLine.GST = line.GST;
                    newLine.RateID = line.RateID;
                    newLine.PatientName = line.Patient;
                    newLine.SessionDate = line.Date;
                    newLine.ItemNo = line.ItemNo;
                    newLine.PatientID = line.PatientID;

                    myLines.Add(newLine);
                }

                myTransaction = myConnection.tblTransactions.
                    Where(transaction => (transaction.InvoiceNo == MyInvoice.InvoiceNo) && (transaction.TranType == "I")).FirstOrDefault();
                myClaimant = myConnection.tblClaimants.Where(claimant => claimant.ClaimantID == myTransaction.ClaimantID).FirstOrDefault();
                myPhysio = myConnection.tblPhysios.Where(physio => physio.PhysioID == myTransaction.PhysioID).FirstOrDefault();
                var myReceiptLines = myConnection.getReceiptsOfSingleInvoice(myInvoice.InvoiceNo).ToList();

                foreach (var line in myReceiptLines)
                {
                    tblInvoiceReceipt myLine = new tblInvoiceReceipt();
                    myLine.InvoiceNo = line.InvoiceNo;
                    myLine.InvoiceReceiptID = line.InvoiceNo;
                    myLine.InvRecAmnt = line.InvRecAmnt;
                    myLine.ReceiptNo = line.ReceiptNo;
                    myReceiptAmounts.Add(myLine);
                }

                this.claimantBillingAddressMemoEdit.Text = myClaimant.FirstNames + Environment.NewLine + myClaimant.LastName + Environment.NewLine
                    + myClaimant.Address1 + Environment.NewLine + myClaimant.Address2 + Environment.NewLine + myClaimant.Address3 + Environment.NewLine;

                this.invoiceDateEdit.DateTime = myTransaction.TranDate.Value;
                this.commentsMemoExEdit.Text = myInvoice.InvoiceComments;

                if (myInvoice.InvoiceCancelled.GetValueOrDefault(false) != true)
                {
                    makeInvoiceOfficial();
                }
                else
                {
                    cancelInvoice();
                }

                this.physioLookUp.EditValue = myPhysio.PhysioID;

                Cursor.Current = Cursors.Default;
            }
            catch (Exception)
            {
                MessageBox.Show("Can not display invoice. Data is corrupt.");
                this.DialogResult = DialogResult.Cancel;
                this.Close();
                return;
            }
        }

        void updateSummaries(object sender, ListChangedEventArgs e)
        {
            decimal feeTotal = (decimal)myLines.Sum(od => od.Fee);
            decimal gstTotal = (decimal)myLines.Sum(od => od.GST);
            decimal _invoiceTotal = decimal.Add(feeTotal, gstTotal);
            decimal paidTotal = (decimal)myReceiptAmounts.Sum(p => p.InvRecAmnt);
            decimal dueTotal = decimal.Subtract(_invoiceTotal, paidTotal);

            this.feeSpinEdit.Value = feeTotal;
            this.gstSpinEdit.Value = gstTotal;
            this.paidSpinEdit.Value = paidTotal;
            this.dueSpinEdit.Value = dueTotal;
            this.invoiceTotalSpinEdit.Value = _invoiceTotal;
            if (dueTotal == 0)
            {
                var currentInvoice = myConnection.tblInvoices.Where(i => i.InvoiceNo == myInvoice.InvoiceNo).SingleOrDefault();
                if (currentInvoice != null)
                {
                    currentInvoice.InvoicePaid = true;
                    myConnection.SubmitChanges();
                }
            }
        }

        void newInvoice()
        {
            this.claimantBillingAddressMemoEdit.Text = myClaimant.FirstNames + Environment.NewLine + myClaimant.LastName + Environment.NewLine
               + myClaimant.Address1 + Environment.NewLine + myClaimant.Address2 + Environment.NewLine + myClaimant.Address3 + Environment.NewLine;
            invoiceDateEdit.DateTime = System.DateTime.Today;
            physioLookUp.EditValue = myPhysio.PhysioID;
        }

        public newInvoiceForm(tblClaimant MyClaimant, tblPhysio MyPhysio)
        {
            InitializeComponent();

            this.myLines.ListChanged += new ListChangedEventHandler(updateSummaries);
            this.myReceipts.ListChanged += new ListChangedEventHandler(updateSummaries);
            this.myReceiptAmounts.ListChanged += new ListChangedEventHandler(updateSummaries);

            myPhysio = MyPhysio;
            myClaimant = MyClaimant;
            

            newInvoice();
        }

        public newInvoiceForm(tblInvoice MyInvoice)
        {
            InitializeComponent();

            this.myLines.ListChanged += new ListChangedEventHandler(updateSummaries);
            this.myReceipts.ListChanged += new ListChangedEventHandler(updateSummaries);
            this.myReceiptAmounts.ListChanged += new ListChangedEventHandler(updateSummaries);
            retrieveInvoiceDetails(MyInvoice);
        }

        private void newInvoiceForm_Load(object sender, EventArgs e)
        {
            this.invoiceLinesGridControl.DataSource = myLines;
            this.physioLookUp.Properties.DataSource = myConnection.tblPhysios.Where(p => p.PhysioInActive.GetValueOrDefault(false) != true).ToList();
            this.rateGridControl.DataSource = myConnection.tblRates.ToList();
            this.receiptGridControl.DataSource = myReceiptAmounts;
        }

        private void removePaymentBtn_Click(object sender, EventArgs e)
        {
            var rowToDelete = (AnonInvoiceLines)this.invoiceLinesGridView.GetFocusedRow();
            if (rowToDelete != null)
            {
                myLines.Remove(rowToDelete);
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            this.myLines.Clear();
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            if (isOfficial == true)
            {
                this.print();
            }
            else
            {
                MessageBox.Show("Please make the invoice official.");
            }
        }

        private void rateGridView_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Clicks == 2)
            {
                if (isOfficial)
                {
                    MessageBox.Show("You can not amend an invoice that has being finalized. Please cancel the invoice and issue a new one.");
                }
                else
                {
                    var rateRow = (tblRate)rateGridView.GetFocusedRow();
                    
                    var addForm = new newAddItemForm(myPhysio, rateRow, myClaimant);
                    addForm.ShowDialog();

                    if (addForm.DialogResult == DialogResult.OK)
                    {
                        this.myLines.Add(addForm.myLine);
                    }
                }
            }
        }

        private void receiptBtn_Click(object sender, EventArgs e)
        {
            if (!myLines.Any())
            {
                MessageBox.Show("You can not create a receipt for an empty invoice.");
                this.DialogResult = DialogResult.Retry;
                return;
            }


            decimal feeTotal = (decimal)myLines.Sum(od => od.Fee);
            decimal gstTotal = (decimal)myLines.Sum(od => od.GST);
            decimal _invoiceTotal = decimal.Add(feeTotal, gstTotal);

            if (myReceiptAmounts.Sum(r => r.InvRecAmnt) >= _invoiceTotal)
            {
                MessageBox.Show("This invoice has already being paid in full.");
                return;
            }

            if (isOfficial != true)
            {
                MessageBox.Show("Please make the invoice official.");
                return;
            }

            var myReceiptForm = new Receipt.receiptViewForm(myInvoice, myClaimant);
            myReceiptForm.ShowDialog();
            if (myReceiptForm.DialogResult == DialogResult.OK)
            {
                this.myReceipts.Add(myReceiptForm.myReceipt);
                foreach (var x in myReceiptForm.myInvoiceReceipts)
                {
                    this.myReceiptAmounts.Add(x);
                }
            }
            myReceiptForm.Dispose();

        }

        private void officialBtn_Click(object sender, EventArgs e)
        {
            commitNewInvoice();
        }

        void cancelInvoice()
        {
            this.invoiceStatusLabel.BackColor = System.Drawing.Color.Black;
            this.invoiceStatusLabel.ForeColor = System.Drawing.Color.White;
            this.invoiceStatusLabel.Text = "Invoice Cancelled " + myInvoice.InvoiceNo.ToString();
        }


        private void cancelBtn_Click(object sender, EventArgs e)
        {

            Cursor.Current = Cursors.WaitCursor;
            if (isOfficial == true)
            {
                if (Ex.staticProperties.userLevel.GetValueOrDefault(1) == 1)
                {
                    myInvoice = myConnection.tblInvoices.Where(i => i.InvoiceNo == myInvoice.InvoiceNo).SingleOrDefault();
                    myInvoice.InvoiceCancelled = true;
                    if (myReceipts.Any())
                    {
                        foreach (var r in myReceipts)
                        {
                            myConnection.tblReceipts.Attach(r);
                            r.ReceiptCancelled = true;
                        }
                    }
                    myConnection.SubmitChanges();
                    cancelInvoice();
                }
                else
                {
                    
                    if (DateTime.Compare(System.DateTime.Today, myTransaction.TranDate.Value) == 0)
                    {
                        myInvoice = myConnection.tblInvoices.Where(i => i.InvoiceNo == myInvoice.InvoiceNo).SingleOrDefault();
                        myInvoice.InvoiceCancelled = true;
                        if (myReceipts.Any())
                        {
                            
                            foreach (var r in myReceipts)
                            {
                                myConnection.tblReceipts.Attach(r);
                                r.ReceiptCancelled = true;
                            }
                        }
                        myConnection.SubmitChanges();
                        cancelInvoice();
                    }
                    else
                    {
                        MessageBox.Show("General user can not cancel invoices issued earlier than Today.");
                        return;
                    }
                }
            }
            else
            {
                this.myLines.Clear();
            }
            Cursor.Current = Cursors.Default;
        }

        public override void okBtn_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            base.okBtn_Click(sender, e);
            if (isOfficial != true && myLines.Any())
            {
                var result = MessageBox.Show("Do you want official/save this invoice?", "",
                             MessageBoxButtons.YesNoCancel,
                             MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    commitNewInvoice();
                }
            }
            myInvoice = myConnection.tblInvoices.Where(i => i.InvoiceNo == myInvoice.InvoiceNo).SingleOrDefault();
            if (myInvoice != null)
            {
                myInvoice.InvoiceComments = commentsMemoExEdit.Text;
            }
            myConnection.SubmitChanges();


            
            myConnection.SubmitChanges();
            Cursor.Current = Cursors.Default;
        }

        private void physioLookUp_EditValueChanged(object sender, EventArgs e)
        {
            if (isOfficial != true)
            {
                myLines.Clear();
            }
        }

    }
}
