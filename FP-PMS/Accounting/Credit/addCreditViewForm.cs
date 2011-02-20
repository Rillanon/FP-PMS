using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Linq;
using System.Linq.Expressions;
using System.Drawing;
using System.Text;
using System.Reflection;
using System.Windows.Forms;
using FP_PMS.Db;
using FP_PMS.Ex;    

namespace FP_PMS.Accounting.Credit
{
    public partial class addCreditViewForm : FP_PMS.Templates.level2TemplateForm
    {
        tblClaimant _myClaimant = new tblClaimant();
        tblClaimant myClaimant { get { return _myClaimant; } set { _myClaimant = value; } }
        Db.Credit _myCredit = new Db.Credit();
        Db.Credit myCredit { get { return _myCredit; } set { _myCredit = value; } }
        CreditType _myCreditType = new CreditType();
        CreditType myCreditType { get { return _myCreditType; } set { _myCreditType = value; } }

        void updateClaimantDetails()
        {
            claimantDetailMemoEdit.Text = "ID: " + myClaimant.ClaimantID + Environment.NewLine +
            myClaimant.FirstNames + Environment.NewLine + myClaimant.LastName + Environment.NewLine +
            myClaimant.Address1 + Environment.NewLine
            + myClaimant.Address2 + Environment.NewLine + myClaimant.Address3 + " " + myClaimant.Postcode;
        }

        void updateDetails()
        {
            creditAmountSpinEdit.Value = myCredit.CreditAmount.GetValueOrDefault(0.0M);
            creditDateEdit.DateTime = myCredit.CreditDate.GetValueOrDefault(System.DateTime.Today);
            creditTypeLookUpEdit.EditValue = myCredit.CreditType;
            creditCommentMemoEdit.Text = myCredit.CreditComment;
            updateClaimantDetails();
        }

        void saveDetails()
        {
            myCredit.CreditDate = creditDateEdit.DateTime;
            myCredit.CreditAmount = creditAmountSpinEdit.Value;
            myCredit.CreditComment = creditCommentMemoEdit.Text;
            myCredit.ClaimantID = myClaimant.ClaimantID;
            if (myCreditType.CreditTypeID.IsNullOrDefault() == false)
            {
                myCredit.CreditType = myCreditType.CreditTypeID;
            }
        }

        void applyCredit()
        {
            var newConnection = new dbContextDataContext();
            var currentCredit = newConnection.Credits.Where(c => c.CreditID == myCredit.CreditID).FirstOrDefault();
            if (currentCredit.IsNullOrDefault())
            {
                if (myCredit.CreditAmount <= 0)
                {
                    MessageBox.Show("Please enter the Credit Amount.");
                    this.DialogResult = DialogResult.Retry;
                    return;
                }
                if (myCredit.CreditType <= 0)
                {
                    MessageBox.Show("Please select the Credit Type.");
                    this.DialogResult = DialogResult.Retry;
                    return;
                }

                newConnection.Credits.InsertOnSubmit(myCredit);
            }
            else
            {
                currentCredit.setProperty(myCredit);
            }

            newConnection.SubmitChanges();
            
        }

        public addCreditViewForm(Db.Credit MyCredit)
        {
            InitializeComponent();
            myCredit = MyCredit;
            var claimant = new dbContextDataContext().tblClaimants.Where(c => c.ClaimantID == myCredit.ClaimantID).FirstOrDefault();
            if (claimant != null)
            {
                myClaimant = claimant;
            }
            updateDetails();
        }

        public addCreditViewForm(tblClaimant MyClaimant)
        {
            InitializeComponent();
            creditAmountSpinEdit.Properties.ReadOnly = false;
            creditTypeLookUpEdit.Properties.ReadOnly = false;
            creditDateEdit.DateTime = System.DateTime.Today;
            myClaimant = MyClaimant;
            updateDetails();
        }

        private void addCreditViewForm_Load(object sender, EventArgs e)
        {
            var newConnection = new dbContextDataContext();
            creditTypeLookUpEdit.Properties.DataSource = newConnection.CreditTypes;
        }

        public override void okBtn_Click(object sender, EventArgs e)
        {
            base.okBtn_Click(sender, e);
            saveDetails();
            applyCredit();
        }

        private void creditTypeLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (creditTypeLookUpEdit.GetSelectedDataRow().IsNullOrDefault() == false)
            myCreditType.setProperty((CreditType)creditTypeLookUpEdit.GetSelectedDataRow());
        }
    }
}
