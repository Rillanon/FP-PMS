using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FP_PMS.Accounting.Receipt
{
    public partial class addPaymentAmountViewForm : FP_PMS.Templates.level3TemplateForm
    {
        decimal _amount;
        public decimal amount { get { return _amount; } set { _amount = value; } }

        bool _multi = false;
        public bool IsMulti { get { return _multi; } set { _multi = value; } }

        public addPaymentAmountViewForm(decimal amount)
        {
            InitializeComponent();
            this.paymentAmountSpinEdit.Properties.MaxValue = amount;
            paymentAmountSpinEdit.Value = amount;
        }

        public override void okBtn_Click(object sender, EventArgs e)
        {
            base.okBtn_Click(sender, e);
            if (this.paymentAmountSpinEdit.Value > 0 && this.paymentAmountSpinEdit.Value <= this.paymentAmountSpinEdit.Properties.MaxValue)
            {
                amount = this.paymentAmountSpinEdit.Value;
            }
            else
            {
                if (this.amount != 0)
                {
                    if (this.paymentAmountSpinEdit.Value <= this.paymentAmountSpinEdit.Properties.MaxValue)
                    {
                        MessageBox.Show("Amount can not be 0 or Negative!");
                        this.DialogResult = DialogResult.Retry;
                    }
                    else
                    {
                        var result = MessageBox.Show("Fund remaining, do you want to save this as a credit?", "OVERPAYMENT",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {

                        }
                        if (result == DialogResult.No)
                        {

                        }

                        if (result == DialogResult.Cancel)
                            this.DialogResult = DialogResult.Retry;
                    }
                }
                else
                {
                    amount = this.paymentAmountSpinEdit.Value;
                }
            }
        }

        private void addPaymentAmountViewForm_Load(object sender, EventArgs e)
        {
            paymentAmountSpinEdit.EnterMoveNextControl = true;
            paymentAmountSpinEdit.Focus();
        }

        private void paymentAmountSpinEdit_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if ((Convert.ToDecimal(e.NewValue) > paymentAmountSpinEdit.Properties.MaxValue) && (IsMulti == false))
            {
                MessageBox.Show("Credit amount entered exceeds available Credits.");
                e.Cancel = true;
            }
            if (Convert.ToDecimal(e.NewValue) < 0)
            {
                MessageBox.Show("Can not receipt negative amount!");
                e.Cancel = true;
            }

        }


    }
}
