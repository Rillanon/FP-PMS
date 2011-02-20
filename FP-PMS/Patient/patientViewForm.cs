using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.Linq.Expressions;
using FP_PMS.Ex;
using FP_PMS.Db;
using FP_PMS.Accounting.Invoice;

namespace FP_PMS.Patient
{
    public partial class patientViewForm : DevExpress.XtraEditors.XtraForm
    {
        private tblPatient _myPatient;
        private List<tblPostcode> _postCodeList;
        private List<tblPatient> _patientList;
        private patientController _controller;
        private string _suburbSearchText;
        private bool _searchComplete;
        private bool _newPatient;



        #region comparison functions

  

        #endregion


        public patientViewForm()
        {
            InitializeComponent();
            _myPatient = new tblPatient();
            _controller = new patientController(this, _myPatient);
            _controller.Initialize();
        }

        public patientViewForm(tblPatient myPatient)
        {
            InitializeComponent();
            _myPatient = myPatient;
            _controller.Initialize();
            this.UpdateForm();
        }

        public void UpdateForm()
        {
            //Updates the forms buttons, attributes, fields etc etc... 

            #region updating patient details

            surnameTextEdit.Text = this._controller.EditCopyPatient.LastName;
            givenNameTextEdit.Text = this._controller.EditCopyPatient.FirstNames;
            doBDateEdit.EditValue = this._controller.EditCopyPatient.BirthDate;
            commentTextBox.Text = this._controller.EditCopyPatient.Comments;
            TitleComboBox.Text = this._controller.EditCopyPatient.Title;
            physioComboBox.Text = this._controller.EditCopyPatient.PhysioID;

            if (this._controller.EditCopyPatient.Sex == "M")
            {
                genderMaleTickBox.CheckState = CheckState.Checked;
                genderFemaleTickBox.CheckState = CheckState.Unchecked;
            }
          
            if (this._controller.EditCopyPatient.Sex == "F")
            {
                genderFemaleTickBox.CheckState = CheckState.Checked;
                genderMaleTickBox.CheckState = CheckState.Unchecked;
            }
            
        

        dvaTextBox.Text = this._controller.EditCopyPatient.DVANumber;

            #endregion 

            #region updating address
            
                workPhoneTextEdit.Text = this._controller.EditCopyAddress.BusPhone;
                homePhoneTextEdit.Text = this._controller.EditCopyAddress.HomePhone;
                mobileTextEdit.Text = this._controller.EditCopyAddress.MobileNo;
                emailTextEdit.Text = this._controller.EditCopyAddress.EmailAddr;
                addressTextEdit.Text = this._controller.EditCopyAddress.Address1;
                suburbComboBox.Text = this._controller.EditCopyAddress.Address2;
                postCodeTextBox.Text = this._controller.EditCopyAddress.Postcode;
                stateTextBox.Text = this._controller.EditCopyAddress.Address3;
                claimNoTextEdit.Text = this._controller.EditCopyAccident.ClaimNo;

            #endregion

                #region updating medicals

                //if (this._controller.EditCopyMedical.CardiacPacemaker == true)
                //{
                //    MedicalConditionsComboBoxEdit.Properties.Items[0].CheckState = CheckState.Checked;
                //}
                //if (this._controller.EditCopyMedical.LossOfWeight == true)
                //{
                //    MedicalConditionsComboBoxEdit.Properties.Items[1].CheckState = CheckState.Checked;
                //}
                //if (this._controller.EditCopyMedical.HeartCondition == true)
                //{
                //    MedicalConditionsComboBoxEdit.Properties.Items[2].CheckState = CheckState.Checked;
                //}
                //if (this._controller.EditCopyMedical.Dizziness == true)
                //{
                //    MedicalConditionsComboBoxEdit.Properties.Items[3].CheckState = CheckState.Checked;
                //}
                //if (this._controller.EditCopyMedical.ArtificialJoint == true)
                //{
                //    MedicalConditionsComboBoxEdit.Properties.Items[4].CheckState = CheckState.Checked;
                //}
                //if (this._controller.EditCopyMedical.Epilepsy == true)
                //{
                //    MedicalConditionsComboBoxEdit.Properties.Items[5].CheckState = CheckState.Checked;
                //}
                //if (this._controller.EditCopyMedical.SurgeryInThePast3Months == true)
                //{
                //    MedicalConditionsComboBoxEdit.Properties.Items[6].CheckState = CheckState.Checked;
                //}

                #endregion 

                #region updating referrals

                //if (this._controller.EditCopyRef.Family == true)
                //{
                //    ReferralComboBoxEdit.Properties.Items[0].CheckState = CheckState.Checked;
                //}
                //if (this._controller.EditCopyRef.Friend == true)
                //{
                //    ReferralComboBoxEdit.Properties.Items[1].CheckState = CheckState.Checked;
                //}
                //if (this._controller.EditCopyRef.RefDoctor != null)
                //{
                //    ReferralComboBoxEdit.Properties.Items[2].CheckState = CheckState.Checked;
                //}
                //if (this._controller.EditCopyRef.HealthFund == true)
                //{
                //    ReferralComboBoxEdit.Properties.Items[3].CheckState = CheckState.Checked;
                //}
                //if (this._controller.EditCopyRef.FrontSign == true)
                //{
                //    ReferralComboBoxEdit.Properties.Items[4].CheckState = CheckState.Checked;
                //}
                //if (this._controller.EditCopyRef.HealthProfessional == true)
                //{
                //    ReferralComboBoxEdit.Properties.Items[5].CheckState = CheckState.Checked;
                //}
                //if (this._controller.EditCopyRef.YellowPages == true)
                //{
                //    ReferralComboBoxEdit.Properties.Items[6].CheckState = CheckState.Checked;
                //}
                //if (this._controller.EditCopyRef.Internet == true)
                //{
                //    ReferralComboBoxEdit.Properties.Items[7].CheckState = CheckState.Checked;
                //}
                //if (this._controller.EditCopyRef.Other != null)
                //{
                //    ReferralComboBoxEdit.Properties.Items[8].CheckState = CheckState.Checked;
                //}

                #endregion
    
                #region updating claimants list

                this.claimantListBox.DataSource = null;
                this.claimantListBox.DataSource = this._controller.EditCopyClaimantList;
                claimantListBox.Refresh();
            
            #endregion 

                this._controller.EditCopyPatient.PropertyChanged += (o, t) =>
                {
                    if (_newPatient != true)
                    {
                        this.applyBtn.Enabled = true;
                    }

                };
        }

        //#region Validation Methods
        //private bool PhoneValueOkay()
        //{
        //    //only used when a phone field becomes empty.
        //    if ((homePhoneTextEdit.Text != "") || (workPhoneTextEdit.Text != "") || (mobileTextEdit.Text != ""))
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        //private bool AddressValueOkay()
        //{
        //    if (((addressTextEdit.Text == "") && (suburbComboBox.Text == "") && (postCodeTextBox.Text == "")) ||
        //    ((addressTextEdit.Text != "") && (suburbComboBox.Text != "") && (postCodeTextBox.Text != "")))
        //        return true;
        //    else
        //        return false;
        //     return true;
        //}

        //private bool GeneralValueOkay()
        //{
        //    if ((surnameTextEdit.Text != "") && (givenNameTextEdit.Text != ""))
        //        return true;
        //    else
        //        return false;
        //}
        //#endregion


        private void PatientViewFormLoad(object sender, EventArgs e)
        {
            this.searchFieldTextBox.Focus();
            this.applyBtn.Enabled = false;
            this._newPatient = true;

            try
            {
                var newConnection = new dbContextDataContext();
                this.physioComboBox.DataSource = from p in newConnection.tblPhysios
                                                 select p;
            }
            catch (Exception)
            {
                MessageBox.Show(@"Database not responding. Please check your connection.");
            }
            
            this.UpdateForm();
        }

        private void BtnCancelClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void BtnOkClick(object sender, EventArgs e)
        {
            this._controller.ApplyChanges();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void GoBtnClick(object sender, EventArgs e)
        {
            this.SearchTimerTick(sender, e);
        }

        //#region unused yet 

        //private void SmokerYesCheckEdit_CheckStateChanged(object sender, EventArgs e)
        //{
        //    if (this.SmokerYesCheckEdit.CheckState == CheckState.Checked)
        //    {
        //        this.SmokerNoCheckEdit.CheckState = CheckState.Unchecked;
        //    }
        //}

        //private void SmokerNoCheckEdit_CheckStateChanged(object sender, EventArgs e)
        //{
        //    if (this.SmokerNoCheckEdit.CheckState == CheckState.Checked)
        //    {
        //        this.SmokerYesCheckEdit.CheckState = CheckState.Unchecked;
        //    }
        //}
        //private void SurnameTextEdit_Validating(object sender, CancelEventArgs e)
        //{
        //    if (surnameTextEdit.Text == "")
        //    {
        //        surnameTextEdit.ErrorText = "Required.";
        //    }
        //    else
        //    {
        //        this._controller.EditCopyPatient.LastName = surnameTextEdit.Text;
        //                 }
        //}

        //private void GivenNameTextEdit_Validating(object sender, CancelEventArgs e)
        //{
        //    if (givenNameTextEdit.Text == "")
        //    {
        //        givenNameTextEdit.ErrorText = "Required.";
        //     }
        //    else
        //    {
        //        this._controller.EditCopyPatient.FirstNames = this.givenNameTextEdit.Text;
        //     }
        //}

        //private void HomePhoneTextEdit_Validating(object sender, CancelEventArgs e)
        //{
        //    if (homePhoneTextEdit.Text == "")
        //    {
        //        homePhoneTextEdit.ErrorText = "Warning.";
        //    }
        //    else
        //    {
        //        this._controller.EditCopyAddress.HomePhone = homePhoneTextEdit.Text;
        //    }
        //}

        //private void WorkPhoneTextEdit_Validating(object sender, CancelEventArgs e)
        //{
        //    if (workPhoneTextEdit.Text == "")
        //    {
        //        workPhoneTextEdit.ErrorText = "Warning.";
        //    }
        //    else
        //    {
        //        this._controller.EditCopyAddress.BusPhone = workPhoneTextEdit.Text;
        //    }
        //}

        //private void MobileTextEdit_Validating(object sender, CancelEventArgs e)
        //{
        //    if (mobileTextEdit.Text == "")
        //    {
        //        mobileTextEdit.ErrorText = "Warning.";
        //    }
        //    else
        //    {
        //        this._controller.EditCopyAddress.MobileNo = mobileTextEdit.Text;
        //    }
        //}

        //private void DoBDateEdit_Validating(object sender, CancelEventArgs e)
        //{
        //    this._controller.EditCopyPatient.BirthDate = doBDateEdit.DateTime;
        //}

        //private void AddressTextEdit_Validating(object sender, CancelEventArgs e)
        //{
        //        this._controller.EditCopyAddress.Address1 = addressTextEdit.Text;
        //}

       
        //private void SmokerYesCheckEdit_Validating(object sender, CancelEventArgs e)
        //{
        //    this._controller.EditCopyMedical.Smoker = this.SmokerYesCheckEdit.Checked;
        //}

        //private void SmokerNoCheckEdit_Validating(object sender, CancelEventArgs e)
        //{
        //    this._controller.EditCopyMedical.Smoker = this.SmokerNoCheckEdit.Checked;
        //}

        //private void MedicalConditionsComboBoxEdit_Validating(object sender, CancelEventArgs e)
        //{
        //    if (MedicalConditionsComboBoxEdit.Properties.Items[0].CheckState == CheckState.Checked)
        //    {
        //        this._controller.EditCopyMedical.CardiacPacemaker = true;
        //    }
        //    if (MedicalConditionsComboBoxEdit.Properties.Items[1].CheckState == CheckState.Checked)
        //    {
        //        this._controller.EditCopyMedical.LossOfWeight = true;
        //    }
        //    if (MedicalConditionsComboBoxEdit.Properties.Items[2].CheckState == CheckState.Checked)
        //    {
        //        this._controller.EditCopyMedical.HeartCondition = true;
        //    }
        //    if (MedicalConditionsComboBoxEdit.Properties.Items[3].CheckState == CheckState.Checked)
        //    {
        //        this._controller.EditCopyMedical.Dizziness = true;
        //    }
        //    if (MedicalConditionsComboBoxEdit.Properties.Items[4].CheckState == CheckState.Checked)
        //    {
        //        this._controller.EditCopyMedical.ArtificialJoint = true;
        //    }
        //    if (MedicalConditionsComboBoxEdit.Properties.Items[5].CheckState == CheckState.Checked)
        //    {
        //        this._controller.EditCopyMedical.Epilepsy = true;
        //    }
        //    if (MedicalConditionsComboBoxEdit.Properties.Items[6].CheckState == CheckState.Checked)
        //    {
        //        this._controller.EditCopyMedical.SurgeryInThePast3Months = true;
        //    }
        //}

        //private void ReferralComboBoxEdit_Validating(object sender, CancelEventArgs e)
        //{
        //    //if (ReferralComboBoxEdit.Properties.Items[0].CheckState == CheckState.Checked)
        //    //{
        //    //    this._controller.EditCopyRef.Family = true;
        //    //}
        //    //if (ReferralComboBoxEdit.Properties.Items[1].CheckState == CheckState.Checked)
        //    //{
        //    //    this._controller.EditCopyRef.Friend = true;
        //    //}
        //    //if (ReferralComboBoxEdit.Properties.Items[2].CheckState == CheckState.Checked)
        //    //{
        //    //    //more code for referring doctor.
        //    //}
        //    //if (ReferralComboBoxEdit.Properties.Items[3].CheckState == CheckState.Checked)
        //    //{
        //    //    this._controller.EditCopyRef.HealthFund = true;
        //    //}
        //    //if (ReferralComboBoxEdit.Properties.Items[4].CheckState == CheckState.Checked)
        //    //{
        //    //    this._controller.EditCopyRef.FrontSign = true;
        //    //}
        //    //if (ReferralComboBoxEdit.Properties.Items[5].CheckState == CheckState.Checked)
        //    //{
        //    //    this._controller.EditCopyRef.HealthProfessional = true;
        //    //}
        //    //if (ReferralComboBoxEdit.Properties.Items[6].CheckState == CheckState.Checked)
        //    //{
        //    //    this._controller.EditCopyRef.YellowPages = true;
        //    //}
        //    //if (ReferralComboBoxEdit.Properties.Items[7].CheckState == CheckState.Checked)
        //    //{
        //    //    this._controller.EditCopyRef.Internet = true;
        //    //}
        //    //if (ReferralComboBoxEdit.Properties.Items[8].CheckState == CheckState.Checked)
        //    //{
        //    //    //more code for other.
        //    //}
        //}

        //private void TitleComboBox_Validating(object sender, CancelEventArgs e)
        //{
        //    if (TitleComboBox.SelectedIndex != -1)
        //        this._controller.EditCopyPatient.Title = TitleComboBox.SelectedItem.ToString();
        //}

        //private void GenderMaleTickBox_CheckStateChanged(object sender, EventArgs e)
        //{
        //    if (this.genderMaleTickBox.CheckState == CheckState.Checked)
        //    {
        //        this.genderFemaleTickBox.CheckState = CheckState.Unchecked;
        //    }
        //}

        //private void GenderFemaleTickBox_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (this.genderFemaleTickBox.CheckState == CheckState.Checked)
        //    {
        //        this.genderMaleTickBox.CheckState = CheckState.Unchecked;
        //    }
        //}

        //private void GenderMaleTickBox_Validating(object sender, CancelEventArgs e)
        //{
        //    if (genderMaleTickBox.CheckState == CheckState.Checked)
        //        this._controller.EditCopyPatient.Sex = "M";
        //}

        //private void GenderFemaleTickBox_Validating(object sender, CancelEventArgs e)
        //{
        //    if (genderFemaleTickBox.CheckState == CheckState.Checked)
        //        this._controller.EditCopyPatient.Sex = "F";
        //}

        //private void ClaimantDeleteButton_Click(object sender, EventArgs e)
        //{
           
        //}

        //#endregion

        private void PostCodeBgWorkerDoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                var newConnection = new dbContextDataContext();
                _postCodeList = (from p in newConnection.tblPostcodes
                                 where p.Location.Contains(_suburbSearchText)
                                 select p
                                ).Take(10).ToList();
            }
            catch (Exception)
            {
                MessageBox.Show(@"Something is wrong with your server, Can not retrieve post code / Suburb Data!");
            }
            this.postCodeTimer.Stop();
        }

        private void SuburbComboBoxTextChanged(object sender, EventArgs e)
        {
            this.postCodeTimer.Stop();

            if ((this.suburbComboBox.Text != "") && (!this.suburbComboBox.DroppedDown))
            {
                this.suburbComboBox.DroppedDown = false;
                this._suburbSearchText = this.suburbComboBox.Text;
                this.postCodeTimer.Start();
            }
            this._controller.EditCopyAddress.Address2 = this.suburbComboBox.Text;
        }

        private void PostCodeTimerTick(object sender, EventArgs e)
        {
            if (postCodeBgWorker.IsBusy != true)
            {
                postCodeBgWorker.RunWorkerAsync();
            }
        }

        private void PostCodeBgWorkerRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            string oldText = this.suburbComboBox.Text;
            this.suburbComboBox.DataSource = this._postCodeList;
            suburbComboBox.Text = oldText;
            this.suburbComboBox.DroppedDown = true;
            this.postCodeTimer.Stop();
        }

        private void SuburbComboBoxDrawItem(object sender, DrawItemEventArgs e)
        {
            var foo = (tblPostcode)suburbComboBox.Items[e.Index];
            Brush bgBrush = Brushes.White;
            Brush textBrush = Brushes.Black;
            Brush hoverBgBrush = Brushes.SkyBlue;
            Brush hoverTextBrush = Brushes.White;

            if (e.State == (DrawItemState.NoAccelerator | DrawItemState.NoFocusRect))
            {
                e.Graphics.FillRectangle(bgBrush, e.Bounds);
                e.Graphics.DrawString(foo.State, e.Font, textBrush, new Point(e.Bounds.X, e.Bounds.Y));
                e.Graphics.DrawString(foo.Location, e.Font,
                textBrush, new Point(suburbComboBox.Width / 5, e.Bounds.Y));
                e.DrawFocusRectangle();
            }
            else if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                e.Graphics.FillRectangle(hoverBgBrush, e.Bounds);
                e.Graphics.DrawString(foo.State, e.Font, hoverTextBrush, new Point(e.Bounds.X, e.Bounds.Y));
                e.Graphics.DrawString(foo.Location, e.Font,
                hoverTextBrush, new Point(suburbComboBox.Width / 5, e.Bounds.Y));
                e.DrawFocusRectangle();
            }
            else
            {
                e.Graphics.FillRectangle(bgBrush, e.Bounds);
                e.Graphics.DrawString(foo.State, e.Font, textBrush, new Point(e.Bounds.X, e.Bounds.Y));
                e.Graphics.DrawString(foo.Location, e.Font,
                textBrush, new Point(suburbComboBox.Width / 5, e.Bounds.Y));
                e.DrawFocusRectangle();
            }
        }

        private void FindPostCodeBtnClick(object sender, EventArgs e)
        {
            if (suburbComboBox.SelectedIndex > -1)
            {
                var postCodeObj = (tblPostcode)suburbComboBox.SelectedItem;
                stateTextBox.Text = postCodeObj.State;
                postCodeTextBox.Text = postCodeObj.Postcode;
            }
        }

        private void SuburbComboBoxLeave(object sender, EventArgs e)
        {
            this.postCodeTimer.Stop();
        }

        private void DisplayGridControlClick(object sender, EventArgs e)
        {
            this.UpdatePatientDetails();
        }

        private void DisplayGridViewRowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            this.UpdatePatientDetails();
        }

        private void UpdatePatientDetails()
        {
            var foo = (tblPatient)this.displayGridView.GetFocusedRow();
            if (foo != null)
            {
                _myPatient = foo;
                _controller = new patientController(this, _myPatient);
                _controller.Initialize();
                this.UpdateForm();
                this.patientDetailsGroupBox.Text = this._controller.EditCopyPatient.FirstNames + @" " +
                                                      this._controller.EditCopyPatient.LastName;
                _newPatient = false;    
            }
        }

        private void NewPatientBtnClick(object sender, EventArgs e)
        {
            this._newPatient = true;
            this._myPatient = new tblPatient();
            this._controller = new patientController(this, _myPatient);
            this._controller.Initialize();
            this.UpdateForm();
            this.patientDetailsGroupBox.Text = @"Enter a new Patient";
            this.surnameTextEdit.Focus();
            this.applyBtn.Enabled = false;
        }

        private void SearchFieldTextBoxTextChanged(object sender, EventArgs e)
        {
            _patientList = null;
            searchTimer.Stop();
            searchTimer.Start();
            this.searchResultProgressBar.Value = 0;
        }


        private void CommentTextBoxTextChanged(object sender, EventArgs e)
        {
            this._controller.EditCopyPatient.Comments = this.commentTextBox.Text;
        }

        private void AddClaimantBtnClick(object sender, EventArgs e)
        {
            var foo = new Accounting.Invoice.claimantSelectViewForm();
            foo.ShowDialog();
            if (foo.DialogResult == DialogResult.OK)
            {
                this._controller.EditCopyClaimantList.Add(foo.myClaimant);
                this.claimantListBox.DataSource = this._controller.EditCopyClaimantList;
                this.claimantListBox.DataSource = null;
                this.claimantListBox.DataSource = this._controller.EditCopyClaimantList;
                claimantListBox.Refresh();
            }
        }

        private void RemoveClaimantBtnClick(object sender, EventArgs e)
        {
            var foo = (tblClaimant)this.claimantListBox.SelectedItem;
            this._controller.EditCopyClaimantList.Remove(foo);
            this.claimantListBox.DataSource = null;
            this.claimantListBox.DataSource = this._controller.EditCopyClaimantList;
            this.claimantListBox.DisplayMember = "LastName";
            this.claimantListBox.ValueMember = "ClaimantID";
            this.claimantListBox.Refresh();
        }

        private void SearchTimerTick(object sender, EventArgs e)
        {
            if (patientDocBgWorker.IsBusy != true)
            {
                patientDocBgWorker.RunWorkerAsync();
                this.loadBarTimer.Start();
            }
        }

        private void PatientBgWorkerDoWork(object sender, DoWorkEventArgs e)
        {
            var newConnection = new dbContextDataContext();
            try
            {
                if (!string.IsNullOrEmpty(searchFieldTextBox.Text))
                {
                    _patientList = (from p in newConnection.tblPatients
                                   where (p.FirstNames + @" " + p.LastName + @" ").Contains(searchFieldTextBox.Text)
                                   || (p.DVANumber.Contains(searchFieldTextBox.Text))
                                   select p).Take(30).ToList();
                }
                else
                {
                    searchResultProgressBar.Value = 0;
                    loadBarTimer.Stop();
                }
                searchTimer.Stop();
            }

            catch (Exception)
            {
                MessageBox.Show(@"Database not responding. Please check your connection.");
            }
        }

        private void PatientBgWorkerRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.displayGridControl.DataSource = null;
            //this.displayGridControl.DataSource = _doctorList;
            //this.progressBar1.Value = 100;
            this._searchComplete = true;
        }

        private void LoadTimerTick(object sender, EventArgs e)
        {
            this.searchResultProgressBar.Increment(25);
            if ((this.searchResultProgressBar.Value == 100) && (this._searchComplete != true))
            {
                this.searchResultProgressBar.Value = 0;
            }

            if ((this.searchResultProgressBar.Value == 100) && (this._searchComplete == true))
            {
                this.displayGridControl.DataSource = _patientList;
                this.loadBarTimer.Stop();
            }
        }

        private void ApplyBtnClick(object sender, EventArgs e)
        {
            this._controller.ApplyChanges();
            this.searchResultProgressBar.Value = 0;
            this.SearchTimerTick(sender, e);
            this.LoadTimerTick(sender, e);
            this.displayGridControl.RefreshDataSource();

            this.applyBtn.Enabled = false;

        }

        private void DvaTextBoxEditValueChanged(object sender, EventArgs e)
        {
            this._controller.EditCopyPatient.DVANumber = this.dvaTextBox.Text;
        }

        private void TitleComboBoxTextChanged(object sender, EventArgs e)
        {
            this._controller.EditCopyPatient.Title = this.TitleComboBox.Text;
        }

        private void ClaimantListBoxDrawItem(object sender, DrawItemEventArgs e)
        {
            var foo = (tblClaimant)claimantListBox.Items[e.Index];

            Brush bgBrush = Brushes.White;
            Brush textBrush = Brushes.Black;
            Brush hoverBgBrush = Brushes.LightSkyBlue;
            Brush hoverTextBrush = Brushes.White;



            e.Graphics.FillRectangle(bgBrush, e.Bounds);


            e.Graphics.DrawString(foo.FirstNames, e.Font, textBrush, new Point(e.Bounds.X, e.Bounds.Y));

            e.Graphics.DrawString(foo.LastName, e.Font,
            textBrush, new Point(this.suburbComboBox.Width / 2, e.Bounds.Y));



            e.DrawFocusRectangle();
        }

        private void SearchFieldTextBoxKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SearchTimerTick(sender, e);
        }

        private void GivenNameTextEditEditValueChanged(object sender, EventArgs e)
        {
            this._controller.EditCopyPatient.FirstNames = this.givenNameTextEdit.Text;
        }

        private void SurnameTextEditEditValueChanged(object sender, EventArgs e)
        {
            this._controller.EditCopyPatient.LastName = this.surnameTextEdit.Text;
        }

        private void HomePhoneTextEditEditValueChanged(object sender, EventArgs e)
        {
            this._controller.EditCopyAddress.HomePhone = this.homePhoneTextEdit.Text;
        }

        private void WorkPhoneTextEditEditValueChanged(object sender, EventArgs e)
        {
            this._controller.EditCopyAddress.BusPhone = this.workPhoneTextEdit.Text;
        }

        private void MobileTextEditEditValueChanged(object sender, EventArgs e)
        {
            this._controller.EditCopyAddress.MobileNo = this.mobileTextEdit.Text;
        }

        private void EmailTextEditEditValueChanged(object sender, EventArgs e)
        {
            this._controller.EditCopyAddress.EmailAddr = this.emailTextEdit.Text;
        }

        private void GenderMaleTickBoxCheckedChanged(object sender, EventArgs e)
        {
            if(genderMaleTickBox.Checked)
            {
                this._controller.EditCopyPatient.Sex = "M";
                genderFemaleTickBox.CheckState = CheckState.Unchecked;
            }
            
        }

        private void GenderFemaleTickBoxCheckedChanged(object sender, EventArgs e)
        {
            if (genderFemaleTickBox.Checked)
            {
                this._controller.EditCopyPatient.Sex = "F";
                genderMaleTickBox.CheckState = CheckState.Unchecked;
            }
        }

        private void DoBDateEditEditValueChanged(object sender, EventArgs e)
        {
            this._controller.EditCopyPatient.BirthDate = this.doBDateEdit.DateTime;
        }

        private void PhysioComboBoxTextChanged(object sender, EventArgs e)
        {
            this._controller.EditCopyPatient.PhysioID = this.physioComboBox.Text;
        }

        private void AddressTextEditEditValueChanged(object sender, EventArgs e)
        {
            this._controller.EditCopyAddress.Address1 = this.addressTextEdit.Text;
        }

        private void StateTextBoxEditValueChanged(object sender, EventArgs e)
        {
            this._controller.EditCopyAddress.Address3 = this.stateTextBox.Text;
        }

        private void PostCodeTextBoxEditValueChanged(object sender, EventArgs e)
        {
            this._controller.EditCopyAddress.Postcode = this.postCodeTextBox.Text;
        }

        private void DisplayGridViewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.UpdatePatientDetails();
            }
        }

        private void PatientViewFormKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                this.BtnOkClick(sender, e);
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.BtnCancelClick(sender, e);
            }
            if (e.Control & e.KeyCode == Keys.N)
            {
                this.NewPatientBtnClick(sender, e);
            }
        }
    }
}