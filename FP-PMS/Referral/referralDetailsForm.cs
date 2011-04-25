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

namespace FP_PMS.Referral
{
    public partial class referralDetailsForm : DevExpress.XtraEditors.XtraForm
    {
        tblRefDoctor _myDoctor = new tblRefDoctor();
        public tblRefDoctor myDoctor { get { return _myDoctor; } set { _myDoctor = value; } }

        tblPatient currentPatient { get { return (tblPatient)referredPatientGridView.GetFocusedRow(); } }
        BindingList<tblPatient> myPatientList = new BindingList<tblPatient> { };
        dbContextDataContext myConnection = new dbContextDataContext();

        referralController myController;

        bool isPatientSelected()
        {
            if (referredPatientGridView.GetFocusedRow() != null)
                return true;
            else
                return false;
        }

        public referralDetailsForm()
        {
            InitializeComponent();
            myController = new referralController(this, myDoctor);
            myController.Initialize();
        }

        public referralDetailsForm(tblRefDoctor MyDoctor)
        {
            InitializeComponent();
            myDoctor = MyDoctor;
            myController = new referralController(this, myDoctor);
            myController.Initialize();
            updateForm();
        }

        private void saveToDb()
        {
                this.myController.EditCopyDoctor.RefDName= this.surnameTextEdit.Text ;
                this.myController.EditCopyDoctor.RefDFNames=            this.firstNameTextEdit.Text ;
                this.myController.EditCopyDoctor.RefDTitle=            this.titleComboBox.Text ;
                this.myController.EditCopyDoctor.RefHomePhone=            this.homePhoneTextEdit.Text ;
                this.myController.EditCopyDoctor.RefBusPhone=            this.workPhoneTextEdit.Text ;
                this.myController.EditCopyDoctor.RefMobile=            this.mobileTextEdit.Text ;
                this.myController.EditCopyDoctor.RefEmail=            this.emailTextEdit.Text ;
                this.myController.EditCopyDoctor.RefDAddr1=            this.addressTextEdit.Text ;
                this.myController.EditCopyDoctor.RefDAddr2=            this.suburbTextEdit.Text ;
                this.myController.EditCopyDoctor.RefDState=            this.stateTextEdit.Text ;
                this.myController.EditCopyDoctor.RefDPcode=            this.postCodeTextEdit.Text ;
                this.myController.EditCopyDoctor.RefProviderNo=            this.providerNumTextEdit.Text ;
                this.myController.EditCopyDoctor.RefFaxNo=            this.faxTextEdit.Text ;
                this.myController.EditCopyDoctor.RefDType=            this.organizationTextEdit.Text ;
        }

        private void updateForm()
        {
            this.surnameTextEdit.Text      = this.myController.EditCopyDoctor.RefDName;
            this.firstNameTextEdit.Text    = this.myController.EditCopyDoctor.RefDFNames;
            this.titleComboBox.Text        = this.myController.EditCopyDoctor.RefDTitle;
            this.homePhoneTextEdit.Text    = this.myController.EditCopyDoctor.RefHomePhone;
            this.workPhoneTextEdit.Text    = this.myController.EditCopyDoctor.RefBusPhone;
            this.mobileTextEdit.Text       = this.myController.EditCopyDoctor.RefMobile;
            this.emailTextEdit.Text        = this.myController.EditCopyDoctor.RefEmail;
            this.addressTextEdit.Text      = this.myController.EditCopyDoctor.RefDAddr1;
            this.suburbTextEdit.Text       = this.myController.EditCopyDoctor.RefDAddr2;
            this.stateTextEdit.Text        = this.myController.EditCopyDoctor.RefDState;
            this.postCodeTextEdit.Text     = this.myController.EditCopyDoctor.RefDPcode;
            this.providerNumTextEdit.Text  = this.myController.EditCopyDoctor.RefProviderNo;
            this.faxTextEdit.Text          = this.myController.EditCopyDoctor.RefFaxNo;
            this.organizationTextEdit.Text = this.myController.EditCopyDoctor.RefDType;
        }

        private void sendEmailBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:" + emailTextEdit.Text + "?subject=" + "Fairfield Physio" + @"&body=Dear " +
            titleComboBox.Text + @" " + firstNameTextEdit.Text + " " + surnameTextEdit.Text + Environment.NewLine);
        }

        private void addPatientBtn_Click(object sender, EventArgs e)
        {
            var newPatientDialog = new Dialogs.patientSelectDialog();
            newPatientDialog.ShowDialog();
            if (newPatientDialog.DialogResult == DialogResult.OK)
            {
                myPatientList.Add(newPatientDialog.myPatient);
            }
            newPatientDialog.Dispose();
        }

        private void removePatientBtn_Click(object sender, EventArgs e)
        {
            if (isPatientSelected() == false)
            {
                MessageBox.Show("Please select a patient first.");
                return;
            }

            myPatientList.Remove(currentPatient);
        }

        private void thankyouLetterBtn_Click(object sender, EventArgs e)
        {
            if (isPatientSelected() == false)
            {
                MessageBox.Show("Please select a patient first.");
                return;
            }

            generateTyLetter();
        }

        private void generateTyLetter()
        {
            var newLetterForm = new letterDialog(currentPatient, myDoctor);
            newLetterForm.ShowDialog();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            saveToDb();
            myController.ApplyChanges();
        }

        private void quitBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void referralDetailsForm_KeyDown(object sender, KeyEventArgs e)
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

        private void referralTabControl_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (referralTabControl.SelectedTabPage.Name == "patientListPage")
            {
                if (myConnection.getPatientsOfReferral(myDoctor.RefDoctor).Any())
                {
                    Cursor.Current = Cursors.WaitCursor;
                    var results = (from r in myConnection.getPatientsOfReferral(myDoctor.RefDoctor)
                                   select new tblPatient
                                   {
                                       FirstNames = r.FirstNames,
                                       LastName = r.LastName,
                                       BirthDate = r.BirthDate.Value,
                                       PatientID = r.PatientID.Value,
                                   }).ToList();

                    foreach (var r in results)
                    {
                        myPatientList.Add(r);
                    }

                    Cursor.Current = Cursors.Default;
                }
            }
        }

        private void referralDetailsForm_Load(object sender, EventArgs e)
        {
            patientListGridControl.DataSource = myPatientList;
        }

    }
}