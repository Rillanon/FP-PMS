using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;
using FP_PMS.Ex;
using FP_PMS.Db;

namespace FP_PMS.Claimant
{
    public partial class claimantViewForm : Form
    {
        private tblClaimant _myClaimant;
        private List<tblClaimant> _claimantList;
        private List<tblPostcode> _postCodeList;
        private claimantController _controller;
        private string _suburbSearchText;
        private bool _searchComplete;
        

        public claimantViewForm()
        {
            InitializeComponent();
            _myClaimant = new tblClaimant();
            _controller = new claimantController(this, _myClaimant);
            _controller.Initialize();
        }

        public claimantViewForm(tblClaimant myClaimant)
        {
            InitializeComponent();
            _myClaimant = myClaimant;
            _controller = new claimantController(this, _myClaimant);
            _controller.Initialize();
            this.UpdateForm();
        }

        #region private form functions
        private void UpdateClaimantDetails()
        {
            var foo = (tblClaimant)this.displayGridView.GetFocusedRow();
            if (foo != null)
            {
                _myClaimant = foo;
                _controller = new claimantController(this, _myClaimant);
                _controller.Initialize();
                this.UpdateForm();
                this.claimantDetailsGroupBox.Text = this._controller.EditCopyClaimant.FirstNames + @" " +
                                                      this._controller.EditCopyClaimant.LastName;
            }
        }

        public void UpdateForm()
        {
            this.surnameTextBox.Text = this._controller.EditCopyClaimant.LastName;
            this.givenNameTextBox.Text = this._controller.EditCopyClaimant.FirstNames;
            this.titleComboBox.Text = this._controller.EditCopyClaimant.Title;
            this.homePhoneTextBox.Text = this._controller.EditCopyClaimant.HomePhone;
            this.workPhoneTextBox.Text = this._controller.EditCopyClaimant.BusPhone;
            this.mobileTextBox.Text = this._controller.EditCopyClaimant.MobileNo;
            this.emailTextBox.Text = this._controller.EditCopyClaimant.EmailAddr;
            this.addressTextBox.Text = this._controller.EditCopyClaimant.Address1;
            this.suburbComboBox.Text = this._controller.EditCopyClaimant.Address2;
            this.stateTextBox.Text = this._controller.EditCopyClaimant.Address3;
            this.postCodeTextBox.Text = this._controller.EditCopyClaimant.Postcode;
            this.faxTextEdit.Text = this._controller.EditCopyClaimant.FaxNo;
            this.commentTextBox.Text = this._controller.EditCopyClaimant.Comments;
            this.termsTextBox.Text = this._controller.EditCopyClaimant.Terms.ToString();
            this.rateComboBox.Text = this._controller.EditCopyClaimant.RateID;
            this.companyCheckBox.Checked = this._controller.EditCopyClaimant.Company;
            this.monthlyCheckBox.Checked = this._controller.EditCopyClaimant.MonthlyAcct;
            this.postCodeTimer.Stop();
        }

        #endregion

        #region events
        private void SurnameTextBoxEditValueChanged(object sender, EventArgs e)
        {
            this._controller.EditCopyClaimant.LastName = this.surnameTextBox.Text;
        }

        private void GivenNameTextBoxEditValueChanged(object sender, EventArgs e)
        {
            this._controller.EditCopyClaimant.FirstNames = this.givenNameTextBox.Text;
        }

        private void HomePhoneTextBoxEditValueChanged(object sender, EventArgs e)
        {
            this._controller.EditCopyClaimant.HomePhone = this.homePhoneTextBox.Text;
        }

        private void WorkPhoneTextBoxEditValueChanged(object sender, EventArgs e)
        {
            this._controller.EditCopyClaimant.BusPhone = this.workPhoneTextBox.Text;
        }

        private void MobileTextBoxEditValueChanged(object sender, EventArgs e)
        {
            this._controller.EditCopyClaimant.MobileNo = this.mobileTextBox.Text;
        }

        private void EmailTextBoxEditValueChanged(object sender, EventArgs e)
        {
            this._controller.EditCopyClaimant.EmailAddr = this.emailTextBox.Text;
        }

        private void FaxTextEditEditValueChanged(object sender, EventArgs e)
        {
            this._controller.EditCopyClaimant.FaxNo = this.faxTextEdit.Text;
        }

        private void AddressTextBoxEditValueChanged(object sender, EventArgs e)
        {
            this._controller.EditCopyClaimant.Address1 = this.addressTextBox.Text;
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
            this._controller.EditCopyClaimant.Address2 = this.suburbComboBox.Text;
        }

        private void StateTextBoxEditValueChanged(object sender, EventArgs e)
        {
            this._controller.EditCopyClaimant.Address3 = this.stateTextBox.Text;
        }

        private void PostCodeTextBoxEditValueChanged(object sender, EventArgs e)
        {
            this._controller.EditCopyClaimant.Postcode = this.postCodeTextBox.Text;
        }

        private void TitleComboBoxTextChanged(object sender, EventArgs e)
        {
            this._controller.EditCopyClaimant.Title = this.titleComboBox.Text;
        }

        private void RateComboBoxTextChanged(object sender, EventArgs e)
        {
            this._controller.EditCopyClaimant.RateID = this.rateComboBox.Text;
        }
        
        private void CommentTextBoxTextChanged(object sender, EventArgs e)
        {
            this._controller.EditCopyClaimant.Comments = this.commentTextBox.Text;
        }
       

        private void TermsTextBoxEditValueChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(termsTextBox.Text))
            this._controller.EditCopyClaimant.Terms = int.Parse(this.termsTextBox.Text);
        }

        private void MonthlyCheckBoxCheckedChanged(object sender, EventArgs e)
        {
            this._controller.EditCopyClaimant.MonthlyAcct = this.monthlyCheckBox.Checked;
        }

        private void CompanyCheckBoxCheckedChanged(object sender, EventArgs e)
        {
            this._controller.EditCopyClaimant.Company = this.companyCheckBox.Checked;
        }

        private void OkBtnClick(object sender, EventArgs e)
        {
            this._controller.ApplyChanges();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CancelBtnClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void SearchFieldTextBoxTextChanged(object sender, EventArgs e)
        {
            _myClaimant = null;
            searchTimer.Stop();
            searchTimer.Start();
            this.searchResultProgressBar.Value = 0;
        }

        private void NewPatientBtnClick(object sender, EventArgs e)
        {
            this._myClaimant = new tblClaimant();
            this._controller = new claimantController(this, _myClaimant);
            this._controller.Initialize();
            this.UpdateForm();
            this.claimantDetailsGroupBox.Text = @"Enter a new Claimant";
            this.rateComboBox.Text = @"P";
            this.rateComboBox.Focus();
        }

        private void GoBtnClick(object sender, EventArgs e)
        {
            this.SearchTimerTick(sender, e);
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
                this.displayGridControl.DataSource = _claimantList;
                this.loadBarTimer.Stop();
            }
        }

        private void SearchTimerTick(object sender, EventArgs e)
        {
            if (claimantBgWorker.IsBusy != true)
            {
                claimantBgWorker.RunWorkerAsync();
                this.loadBarTimer.Start();
            }
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

        #endregion

        private void ClaimantViewFormKeyDown(object sender, KeyEventArgs e)
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

        private void DisplayGridControlClick(object sender, EventArgs e)
        {
            this.UpdateClaimantDetails();
        }

        private void DisplayGridViewRowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            this.UpdateClaimantDetails();
        }

        private void DisplayGridViewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.UpdateClaimantDetails();
            }
        }

        private void SearchFieldTextBoxKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SearchTimerTick(sender, e);
        }

        private void ClaimantViewFormLoad(object sender, EventArgs e)
        {
            this.searchFieldTextBox.Focus();

            var newConnection = new dbContextDataContext();
            try
            {
                this.rateComboBox.DisplayMember = "RateID";
                this.rateComboBox.ValueMember = "RateDesc";
                this.rateComboBox.DataSource = newConnection.tblRates;
                this.rateComboBox.Text = @"P";
            }
            catch (Exception)
            {
                MessageBox.Show(@"Can not connect to database! Please check your connection.");
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

        private void SearchFieldTextBoxLeave(object sender, EventArgs e)
        {
            this.searchTimer.Stop();
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

        private void ClaimantBgWorkerRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.displayGridControl.DataSource = null;
            this._searchComplete = true;
        }

        private void ClaimantBgWorkerDoWork(object sender, DoWorkEventArgs e)
        {
            var newConnection = new dbContextDataContext();
            try
            {
                if (!string.IsNullOrEmpty(searchFieldTextBox.Text))
                {
                    _claimantList = (from p in newConnection.tblClaimants
                                   where (p.FirstNames + @" " + p.LastName).Contains(searchFieldTextBox.Text)
                                   || (p.HomePhone.Contains(searchFieldTextBox.Text))
                                   ||(p.BusPhone.Contains(searchFieldTextBox.Text))
                                   || (p.MobileNo.Contains(searchFieldTextBox.Text))
                                   || (p.EmailAddr.Contains(searchFieldTextBox.Text))

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

        private void SuburbComboBoxTextUpdate(object sender, EventArgs e)
        {
            this._controller.EditCopyClaimant.Address2 = this.suburbComboBox.Text;
        }

    }
}
