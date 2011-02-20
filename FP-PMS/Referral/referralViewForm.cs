using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FP_PMS.Db;
using FP_PMS.Referral;
using FP_PMS.Ex;

namespace FP_PMS.Referral
{
    public partial class referralViewForm : Form
    {
        private tblRefDoctor _myDoctor;
        private List<tblRefDoctor> _doctorList;
        private List<tblPostcode> _postCodeList;
        private referralController _controller;
        private string _suburbSearchText;
        private bool _searchComplete;
        private bool _newDoctor;



        public referralViewForm()
        {
            InitializeComponent();
            _myDoctor = new tblRefDoctor();
            _controller = new referralController(this, _myDoctor);
            _controller.Initialize();
        }

        public referralViewForm(tblRefDoctor myDoctor)
        {
            InitializeComponent();
            _myDoctor = myDoctor;
            _controller = new referralController(this, _myDoctor);
            _controller.Initialize();
            this.UpdateForm();
        }

        public void UpdateForm()
        {
            this.surnameTextBox.Text = this._controller.EditCopyDoctor.RefDName;
            this.givenNameTextBox.Text = this._controller.EditCopyDoctor.RefDFNames;
            this.titleComboBox.Text = this._controller.EditCopyDoctor.RefDTitle;
            this.homePhoneTextBox.Text = this._controller.EditCopyDoctor.RefHomePhone;
            this.workPhoneTextBox.Text = this._controller.EditCopyDoctor.RefBusPhone;
            this.mobileTextBox.Text = this._controller.EditCopyDoctor.RefMobile;
            this.emailTextBox.Text = this._controller.EditCopyDoctor.RefEmail;
            this.addressTextBox.Text = this._controller.EditCopyDoctor.RefDAddr1;
            this.suburbComboBox.Text = this._controller.EditCopyDoctor.RefDAddr2;
            this.stateTextBox.Text = this._controller.EditCopyDoctor.RefDState;
            this.postCodeTextBox.Text = this._controller.EditCopyDoctor.RefDPcode;
            this.provideTextBox.Text = this._controller.EditCopyDoctor.RefProviderNo;
            this.faxTextEdit.Text = this._controller.EditCopyDoctor.RefFaxNo;
            this.organizationTextBox.Text = this._controller.EditCopyDoctor.RefDType;
            this.postCodeTimer.Stop();
            this._newDoctor = false;
            this._controller.EditCopyDoctor.PropertyChanged += (o, t) =>
            {
                if (_newDoctor != true)
                {
                    this.applyBtn.Enabled = true;
                }

            };

        }

        private void UpdateDoctorDetails()
        {
            var foo = (tblRefDoctor)this.displayGridView.GetFocusedRow();
            if (foo != null)
            {
                _myDoctor = foo;
                _controller = new referralController(this, _myDoctor);
                _controller.Initialize();
                this.UpdateForm();
                this.doctorDetailsGroupBox.Text = this._controller.EditCopyDoctor.RefDFNames + @" " +
                                                      this._controller.EditCopyDoctor.RefDName;
            }
        }

        private void CancelBtnClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
            
        }

        private void OkBtnClick(object sender, EventArgs e)
        {
            this._controller.ApplyChanges();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        #region events
        private void SurnameTextBoxEditValueChanged(object sender, EventArgs e)
        {
            this._controller.EditCopyDoctor.RefDName = this.surnameTextBox.Text;
        }

        private void GivenNameTextBoxEditValueChanged(object sender, EventArgs e)
        {
            this._controller.EditCopyDoctor.RefDFNames = this.givenNameTextBox.Text;
        }

        private void HomePhoneTextBoxEditValueChanged(object sender, EventArgs e)
        {
            this._controller.EditCopyDoctor.RefHomePhone = this.homePhoneTextBox.Text;
        }

        private void WorkPhoneTextBoxEditValueChanged(object sender, EventArgs e)
        {
            this._controller.EditCopyDoctor.RefBusPhone = this.workPhoneTextBox.Text;
        }

        private void MobileTextBoxEditValueChanged(object sender, EventArgs e)
        {
            this._controller.EditCopyDoctor.RefMobile = this.mobileTextBox.Text;
        }

        private void EmailTextBoxEditValueChanged(object sender, EventArgs e)
        {
            this._controller.EditCopyDoctor.RefEmail = this.emailTextBox.Text;
        }

        private void FaxTextEditEditValueChanged(object sender, EventArgs e)
        {
            this._controller.EditCopyDoctor.RefFaxNo = this.faxTextEdit.Text;
        }

        private void AddressTextBoxEditValueChanged(object sender, EventArgs e)
        {
            this._controller.EditCopyDoctor.RefDAddr1 = this.addressTextBox.Text;
        }

        private void SuburbComboBoxTextUpdate(object sender, EventArgs e)
        {
            this._controller.EditCopyDoctor.RefDAddr2 = this.suburbComboBox.Text;
        }

        private void StateTextBoxEditValueChanged(object sender, EventArgs e)
        {
            this._controller.EditCopyDoctor.RefDState = this.stateTextBox.Text;
        }

        private void PostCodeTextBoxEditValueChanged(object sender, EventArgs e)
        {
            this._controller.EditCopyDoctor.RefDPcode = this.postCodeTextBox.Text;
        }

        private void ProvideTextBoxEditValueChanged(object sender, EventArgs e)
        {
            this._controller.EditCopyDoctor.RefProviderNo = this.provideTextBox.Text;
        }

        private void OrganizationTextBoxEditValueChanged(object sender, EventArgs e)
        {
            this._controller.EditCopyDoctor.RefDType = this.organizationTextBox.Text;
        }

        private void TitleComboBoxTextChanged(object sender, EventArgs e)
        {
            this._controller.EditCopyDoctor.RefDTitle = this.titleComboBox.Text;
        }

        #endregion

        private void SearchTimerTick(object sender, EventArgs e)
        {
            if (referralDocBgWorker.IsBusy != true)
            {
                referralDocBgWorker.RunWorkerAsync();
                this.loadBarTimer.Start();
            }
        }

        private void ReferralDocBgWorkerDoWork(object sender, DoWorkEventArgs e)
        {
            var newConnection = new dbContextDataContext();
            try
            {
                if (!string.IsNullOrEmpty(searchFieldTextBox.Text))
                {
                    _doctorList = (from p in newConnection.tblRefDoctors
                                   where (p.RefDFNames + @" " + p.RefDName + @" " + p.RefProviderNo).Contains(searchFieldTextBox.Text)
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

        private void ReferralDocBgWorkerRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.displayGridControl.DataSource = null;
            //this.displayGridControl.DataSource = _doctorList;
            //this.progressBar1.Value = 100;
            this._searchComplete = true;
        }

        private void SearchFieldTextBoxTextChanged(object sender, EventArgs e)
        {
            _doctorList = null;
                searchTimer.Stop();
                searchTimer.Start();
            this.searchResultProgressBar.Value = 0;
        }

        private void NewPatientBtnClick(object sender, EventArgs e)
        {
            this._newDoctor = true;
            this._myDoctor = new tblRefDoctor();
            this._controller = new referralController(this, _myDoctor);
            this._controller.Initialize();
            this.UpdateForm();
            this.doctorDetailsGroupBox.Text = @"Enter a new Doctor";
            this.provideTextBox.Focus();
            this.applyBtn.Enabled = false;
        }

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
            this._controller.EditCopyDoctor.RefDAddr2 = this.suburbComboBox.Text;
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

        /*Custome ComboBox Drawing*/
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

        private void GoBtnClick(object sender, EventArgs e)
        {
            this.SearchTimerTick(sender, e);
        }

        private void DisplayGridControlClick(object sender, EventArgs e)
        {
            this.UpdateDoctorDetails();
        }

        private void DisplayGridViewRowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            this.UpdateDoctorDetails();
        }

        private void DisplayGridViewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.UpdateDoctorDetails();
            }
        }

        private void SearchFieldTextBoxKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SearchTimerTick(sender, e);
        }

        private void ReferralLinkFormKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                this.OkBtnClick(sender, e);
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.CancelBtnClick(sender, e);
            }
            if (e.Control & e.KeyCode == Keys.N)
            {
                this.NewPatientBtnClick(sender, e);
            }
        }

        private void ReferralViewFormLoad(object sender, EventArgs e)
        {
            this.searchFieldTextBox.Focus();
            this.applyBtn.Enabled = false;
            this._newDoctor = true;

        }

        private void ReferralDocBgWorkerProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.searchResultProgressBar.Increment(10);
        }

        private void SearchFieldTextBoxLeave(object sender, EventArgs e)
        {
            this.searchTimer.Stop();
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
                this.displayGridControl.DataSource = _doctorList;
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
    }
}
