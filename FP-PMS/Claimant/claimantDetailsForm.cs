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
using DevExpress.XtraEditors;

namespace FP_PMS.Claimant
{
    public partial class claimantDetailsForm : DevExpress.XtraEditors.XtraForm
    {
        dbContextDataContext myConnection = new dbContextDataContext();

        tblClaimant _myClaimant = new tblClaimant();
        tblClaimant myClaimant { get { return _myClaimant; } set { _myClaimant = value; } }
        claimantController _myController;
        claimantController myController { get { return _myController; } set { _myController = value; } }

        void setToCompanyOrPrivate()
        {
            if (companyCheckEdit.Checked == true)
            {
                firstLabel.Text = "Company Name:";
                SecondLabel.Text = "Contact Person:";
            }
            else
            {
                firstLabel.Text = "Surname:";
                SecondLabel.Text = "First name:";
            }
        }

        public void updateForm()
        {
            this.surnameTextEdit.Text = this.myController.EditCopyClaimant.LastName;
            this.firstNameTextEdit.Text = this.myController.EditCopyClaimant.FirstNames;
            this.titleComboBox.Text = this.myController.EditCopyClaimant.Title;
            this.homePhoneTextEdit.Text = this.myController.EditCopyClaimant.HomePhone;
            this.workPhoneTextEdit.Text = this.myController.EditCopyClaimant.BusPhone;
            this.mobileTextEdit.Text = this.myController.EditCopyClaimant.MobileNo;
            this.emailTextEdit.Text = this.myController.EditCopyClaimant.EmailAddr;
            this.addressTextEdit.Text = this.myController.EditCopyClaimant.Address1;
            this.suburbTextEdit.Text = this.myController.EditCopyClaimant.Address2;
            this.stateTextEdit.Text = this.myController.EditCopyClaimant.Address3;
            this.postCodeTextEdit.Text = this.myController.EditCopyClaimant.Postcode;
            this.faxTextEdit.Text = this.myController.EditCopyClaimant.FaxNo;
            this.notesMemoEdit.Text = this.myController.EditCopyClaimant.Comments;
            this.termSpinEdit.Value = this.myController.EditCopyClaimant.Terms.GetValueOrDefault(0);
            this.rateGridLookUpEdit.EditValue = this.myController.EditCopyClaimant.RateID;
            this.companyCheckEdit.Checked = this.myController.EditCopyClaimant.Company;
            this.monthlyAccountCheckEdit.Checked = this.myController.EditCopyClaimant.MonthlyAcct;
        }

        public void saveFormData()
        {
            this.myController.EditCopyClaimant.LastName = this.surnameTextEdit.Text;
            this.myController.EditCopyClaimant.FirstNames = this.firstNameTextEdit.Text;
            this.myController.EditCopyClaimant.Title = this.titleComboBox.Text;
            this.myController.EditCopyClaimant.HomePhone = this.homePhoneTextEdit.Text;
            this.myController.EditCopyClaimant.BusPhone = this.workPhoneTextEdit.Text;
            this.myController.EditCopyClaimant.FaxNo = this.faxTextEdit.Text;
            this.myController.EditCopyClaimant.MobileNo = this.mobileTextEdit.Text;
            this.myController.EditCopyClaimant.EmailAddr = this.emailTextEdit.Text;
            this.myController.EditCopyClaimant.Address1 = this.addressTextEdit.Text;
            this.myController.EditCopyClaimant.Address2 = this.surnameTextEdit.Text;
            this.myController.EditCopyClaimant.Address3 = this.stateTextEdit.Text;
            this.myController.EditCopyClaimant.Postcode = this.postCodeTextEdit.Text;
            this.myController.EditCopyClaimant.Comments = this.notesMemoEdit.Text;

            if(this.rateGridLookUpEdit.EditValue != null)
            this.myController.EditCopyClaimant.RateID = this.rateGridLookUpEdit.EditValue.ToString();

            this.myController.EditCopyClaimant.Company = this.companyCheckEdit.Checked;
            this.myController.EditCopyClaimant.MonthlyAcct = this.monthlyAccountCheckEdit.Checked;
            this.myController.EditCopyClaimant.Terms = Convert.ToInt32(this.termSpinEdit.Value);
        }
        
        //New Claimant
        public claimantDetailsForm()
        {
            InitializeComponent();
            myController = new claimantController(this, myClaimant);
            myController.Initialize();
            updateForm();
            setToCompanyOrPrivate();
        }

        //View/Edit Existing Claimant
        public claimantDetailsForm(tblClaimant MyClaimant)
        {
            InitializeComponent();
            myClaimant = MyClaimant;
            myController = new claimantController(this, myClaimant);
            myController.Initialize();
            updateForm();
            setToCompanyOrPrivate();
        }

        private void postCodeLinqInstantFeedbackSource_DismissQueryable(object sender, DevExpress.Data.Linq.GetQueryableEventArgs e)
        {
            ((dbContextDataContext)e.Tag).Dispose();
        }

        private void postCodeLinqInstantFeedbackSource_GetQueryable(object sender, DevExpress.Data.Linq.GetQueryableEventArgs e)
        {
            var postCodeConnection = new dbContextDataContext();
            e.QueryableSource = postCodeConnection.tblPostcodes;
            e.Tag = postCodeConnection;
        }

        private void claimantDetailsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db.tblRate' table. You can move, or remove it, as needed.
            this.tblRateTableAdapter.Fill(this.db.tblRate);
            Cursor.Current = Cursors.WaitCursor;
            myConnection.ObjectTrackingEnabled = false;


            Cursor.Current = Cursors.Default;
        }

        private void companyCheckEdit_CheckedChanged(object sender, EventArgs e)
        {
            setToCompanyOrPrivate();
        }

        private void termSpinEdit_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
            if((decimal)e.Value > 1)
            e.DisplayText = e.DisplayText + @" " + "days";
            else
                e.DisplayText = e.DisplayText + @" " + "day";
        }

        private void claimantDetailsForm_KeyDown(object sender, KeyEventArgs e)
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

        private void okBtn_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            this.DialogResult = DialogResult.OK;
            this.saveFormData();
            this.myController.ApplyChanges();
            Cursor.Current = Cursors.Default;
        }

        private void quitBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void termSpinEdit_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (decimal.Parse(e.NewValue.ToString()) < 0)
            {
                e.Cancel = true;
            }
        }

        private void postCodeLookUp_EditValueChanged(object sender, EventArgs e)
        {
            var currentRow = (tblPostcode)postCodeLookUpView.GetFocusedRow();

            if (currentRow != null)
            {
                stateTextEdit.Text = currentRow.State;
                postCodeTextEdit.Text = currentRow.Postcode;
                suburbTextEdit.Text = currentRow.Location;
            }
        }

        private void sendEmailBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:" + emailTextEdit.Text + "?subject=" + "Fairfield Physio" + @"&body=Dear " +
            titleComboBox.Text + @" " + firstNameTextEdit.Text + " " +  surnameTextEdit.Text + Environment.NewLine);
        }

        private void remarkBtn_Click(object sender, EventArgs e)
        {
            var remarkForm = new remarkDialog();
            remarkForm.ShowDialog();

            if (remarkForm.DialogResult == DialogResult.OK)
            {
                this.notesMemoEdit.Text = remarkForm.myRemark + notesMemoEdit.Text;
            }
            remarkForm.Dispose();
        }
    }
}