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

namespace FP_PMS.Accounting.Receipt
{
    public partial class receiptViewForm : FP_PMS.Templates.level2TemplateForm
    {
        tblClaimant _myClaimant = new tblClaimant();
        tblClaimant myClaimant { get { return _myClaimant; } set { _myClaimant = value; } }

        //When used in single invoice mode. 
        tblInvoice _myInvoice = new tblInvoice();
        tblInvoice myInvoice { get { return _myInvoice; } set { _myInvoice = value; } }
        
        //When used in multiple invoices mode.
        private BindingList<tblInvoice> _myInvoiceList = new BindingList<tblInvoice> { };

        private BindingList<tblInvoiceReceipt> _myInvoiceReceipts = new BindingList<tblInvoiceReceipt> { };
        private BindingList<tblPayin> _myPaymentLines = new BindingList<tblPayin> { };

        private tblPayin _myCurrentPayment;
        private tblReceipt _myReceipt;
        private BindingList<tblPayinType> myPaymentTypeList = new BindingList<tblPayinType> { };
        public tblReceipt myReceipt { get { return _myReceipt; } }

        public BindingList<tblInvoiceReceipt> myInvoiceReceipts { get { return _myInvoiceReceipts; } }
        public BindingList<tblPayin> myPaymentLines { get { return _myPaymentLines; } }

        bool _multi = false;
        public bool IsMulti { get { return _multi; } set { _multi = value; } }

        decimal? unusedCredit = new decimal();
        decimal? invoiceTotal = new decimal();

        void commitPayments()
        {
            if (myPaymentLines.Any())
            {
                var newConnection = new dbContextDataContext();

                foreach (var p in myPaymentLines)
                {
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
        }
        private void commitReceipt()
        {
            _myReceipt = new tblReceipt();
            _myReceipt.ReceiptAmnt = _myPaymentLines.Sum(od => od.PayinAmnt);
            _myReceipt.ReceiptDate = System.DateTime.Today;
            _myReceipt.UserID = staticProperties.userName;

            if (_myInvoiceList.Any())
            {
                var newConnection = new dbContextDataContext();
                newConnection.tblReceipts.InsertOnSubmit(_myReceipt);
                newConnection.SubmitChanges();

                if (_myInvoiceList.Any())
                {
                    foreach (tblInvoice x in _myInvoiceList)
                    {
                        tblInvoiceReceipt y = new tblInvoiceReceipt();
                        y.InvoiceNo = x.InvoiceNo;
                        y.ReceiptNo = _myReceipt.ReceiptNo;
                        y.InvRecAmnt = _myPaymentLines.Sum(od => od.PayinAmnt);
                        _myInvoiceReceipts.Add(y);
                    }
                    newConnection.tblInvoiceReceipts.InsertAllOnSubmit(_myInvoiceReceipts);
                }
                newConnection.SubmitChanges();
            }
            else
            {
                //save as unallocated receipt.
            }
        }

        bool IsNullOrDefault<T>(T value)
        {
            return object.Equals(value, default(T));
        }

        void myPaymentLines_ListChanged(object sender, ListChangedEventArgs e)
        {
            receiptTotalSpinEdit.Value = myPaymentLines.Sum(p => p.PayinAmnt).GetValueOrDefault(0.0M);
        }

        void updateViewTotals()
        {
            var newConnection = new dbContextDataContext();
       
            newConnection.getClaimantUnusedCreditTotal(myClaimant.ClaimantID, ref unusedCredit);
            newConnection.getInvoiceTotal(myInvoice.InvoiceNo, ref invoiceTotal);
            existingCreditSpinEdit.Value = unusedCredit.GetValueOrDefault(0.0M);
            invoiceTotalSpinEdit.Value = invoiceTotal.GetValueOrDefault(0.0M);
        }

        public receiptViewForm(tblClaimant MyClaimant)
        {
            InitializeComponent();
            myPaymentLines.ListChanged += new ListChangedEventHandler(myPaymentLines_ListChanged);
            myClaimant = MyClaimant;
            updateViewTotals();

        }

        public override void okBtn_Click(object sender, EventArgs e)
        {
            
            if (_myPaymentLines.Any())
            {
                this.commitReceipt();
                this.commitPayments();
                base.okBtn_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Can not create empty receipt.");
                this.DialogResult = DialogResult.Retry;
            }
                
        }

        public receiptViewForm(tblInvoice MyInvoice, tblClaimant MyClaimant)
        {
            InitializeComponent();
            myPaymentLines.ListChanged += new ListChangedEventHandler(myPaymentLines_ListChanged);
            _myInvoiceList.Add(MyInvoice);
            myInvoice = MyInvoice;
            myClaimant = MyClaimant;
            updateViewTotals();
        }

        //public receiptViewForm(BindingList<tblInvoice> MyInvoiceList)
        //{
        //    InitializeComponent();
        //    myPaymentLines.ListChanged += new ListChangedEventHandler(myPaymentLines_ListChanged);
        //    _myInvoiceList = MyInvoiceList;
        //}

        private void receiptViewForm_Load(object sender, EventArgs e)
        {
            this.paymentListGridControl.DataSource = this._myPaymentLines;
            myPaymentTypeList = new BindingList<tblPayinType>(new dbContextDataContext().tblPayinTypes.ToList());
            this.paymentTypeGridControl.DataSource = myPaymentTypeList;
            this._myPaymentLines.AllowEdit = true;
            this._myPaymentLines.AllowNew = true;
            this._myPaymentLines.AllowRemove = true;
        }

        private void removePaymentBtn_Click(object sender, EventArgs e)
        {
            var rowToDelete = (tblPayin)this.paymentListGridView.GetFocusedRow();
            if (rowToDelete != null)
            {
                _myPaymentLines.Remove(rowToDelete);
                if(rowToDelete.PayinType == "7")
                existingCreditSpinEdit.Value += rowToDelete.PayinAmnt.GetValueOrDefault(0.0M);
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            _myPaymentLines.Clear();
            existingCreditSpinEdit.Value = unusedCredit.GetValueOrDefault(0.0M);
        }

        public void removeBtnEvent()
        {
            this.okBtn.Click -= new EventHandler(okBtn_Click);
        }


        private void paymentTypeGridView_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Clicks == 2)
            {
                decimal remaining = new decimal();
                var receiptTotal = myPaymentLines.Sum(a => a.PayinAmnt).GetValueOrDefault(0.0M);
                var paymentType = ((tblPayinType)paymentTypeGridView.GetFocusedRow()).PayinType;

                if (paymentType == "7")
                {
                    if (unusedCredit.GetValueOrDefault(0.0M) <= 0)
                    {
                        MessageBox.Show("No credit for this claimant.");
                        return;
                    }

                    if (invoiceTotal.GetValueOrDefault(0.0M) > 0)
                    {
                        remaining = decimal.Subtract(invoiceTotal.Value, receiptTotal);

                        if (invoiceTotal.GetValueOrDefault(0.0M) > 0)
                        {
                            remaining = decimal.Subtract(invoiceTotal.Value, receiptTotal);
                            if (remaining > unusedCredit.GetValueOrDefault(0.0M))
                            {
                                remaining = unusedCredit.GetValueOrDefault(0.0M);
                                

                                var newAmountForm = new addPaymentAmountViewForm(remaining);

                                if (IsMulti == true)
                                {
                                    newAmountForm.IsMulti = true;
                                }

                                newAmountForm.ShowDialog();
                                if ((newAmountForm.DialogResult == DialogResult.OK) && (newAmountForm.amount > default(decimal)))
                                {
                                    
                                        _myCurrentPayment = new tblPayin();
                                        _myCurrentPayment.PayinAmnt = newAmountForm.amount;
                                        _myCurrentPayment.PayinType = paymentType;
                                        this._myPaymentLines.Add(_myCurrentPayment);
                                        existingCreditSpinEdit.Value = existingCreditSpinEdit.Value - newAmountForm.amount;
                                }
                                
                            }
                            else
                            {
                                var newAmountForm = new addPaymentAmountViewForm(remaining);
                                if (IsMulti == true)
                                {
                                    newAmountForm.IsMulti = true;
                                }
                                newAmountForm.ShowDialog();
                                if ((newAmountForm.DialogResult == DialogResult.OK) && (newAmountForm.amount > default(decimal)))
                                {
                                    _myCurrentPayment = new tblPayin();
                                    _myCurrentPayment.PayinAmnt = newAmountForm.amount;
                                    _myCurrentPayment.PayinType = paymentType;
                                    this._myPaymentLines.Add(_myCurrentPayment);
                                    existingCreditSpinEdit.Value = existingCreditSpinEdit.Value - newAmountForm.amount;
                                }
                                
                            }
                        }
                    }
                    else
                    {
                        remaining = unusedCredit.GetValueOrDefault(0.0M);
                        var newAmountForm = new addPaymentAmountViewForm(remaining);
                        if (IsMulti == true)
                        {
                            newAmountForm.IsMulti = true;
                        }
                        newAmountForm.ShowDialog();
                        if ((newAmountForm.DialogResult == DialogResult.OK) && (newAmountForm.amount > default(decimal)))
                        {
                            _myCurrentPayment = new tblPayin();
                            _myCurrentPayment.PayinAmnt = newAmountForm.amount;
                            _myCurrentPayment.PayinType = paymentType;
                            this._myPaymentLines.Add(_myCurrentPayment);
                            existingCreditSpinEdit.Value = existingCreditSpinEdit.Value - newAmountForm.amount;
                        }
                        
                    }
                }
                else
                {
                    if (invoiceTotal.Value <= 0 && receiptTotal > 0)
                    {
                        remaining = 0.0M;
                        var newAmountForm = new addPaymentAmountViewForm(remaining);
                        if (IsMulti == true)
                        {
                            newAmountForm.IsMulti = true;
                        }
                        newAmountForm.ShowDialog();
                        if ((newAmountForm.DialogResult == DialogResult.OK) && (newAmountForm.amount > default(decimal)))
                        {
                            _myCurrentPayment = new tblPayin();
                            _myCurrentPayment.PayinAmnt = newAmountForm.amount;
                            _myCurrentPayment.PayinType = paymentType;
                            this._myPaymentLines.Add(_myCurrentPayment);
                        }
                    }

                    else
                    {
                        remaining = decimal.Subtract(invoiceTotal.Value, receiptTotal);
                        var newAmountForm = new addPaymentAmountViewForm(remaining);
                        if (IsMulti == true)
                        {
                            newAmountForm.IsMulti = true;
                        }
                        newAmountForm.ShowDialog();
                        if ((newAmountForm.DialogResult == DialogResult.OK) && (newAmountForm.amount > default(decimal)))
                        {
                            _myCurrentPayment = new tblPayin();
                            _myCurrentPayment.PayinAmnt = newAmountForm.amount;
                            _myCurrentPayment.PayinType = paymentType;
                            this._myPaymentLines.Add(_myCurrentPayment);
                        }
                    }
                }

            }
        }

        private void paymentListGridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "PayinType")
            {
                foreach (var type in myPaymentTypeList)
                {
                    if (e.Value.ToString() == type.PayinType)
                    {
                        e.DisplayText = type.PayinDesc;
                    }
                }

            }
        }
    }
}
