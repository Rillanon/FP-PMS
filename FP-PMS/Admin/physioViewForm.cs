using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;
using FP_PMS.Db;
using DevExpress.XtraScheduler.UI;

namespace FP_PMS.Admin
{
    public partial class physioViewForm : FP_PMS.Templates.level2TemplateForm
    {
        tblPhysio _myPhysio = new tblPhysio();
        public tblPhysio myPhysio { get { return _myPhysio; } set { _myPhysio = value; } }

        bool IsNullOrDefault<T>(T value)
        {
            return object.Equals(value, default(T));
        }

        private bool validation()
        {
            if (IsNullOrDefault(physioIDTextEdit.Text) == false)
                return true;
            if (IsNullOrDefault(physioNameTextEdit.Text) == false) 
                return true;

            return false;
        }
        public void updateForm()
        {
            var defaultStartTime = TimeSpan.Parse("13:00:00");
            var defaultEndTime = TimeSpan.Parse("14:00:00");

            physioIDTextEdit.Text = _myPhysio.PhysioID;
            physioNameTextEdit.Text = _myPhysio.PhysioName;
            providerNoTextEdit.Text = _myPhysio.ProviderNo;
            addressTextEdit.Text = _myPhysio.Address1;
            mobileTextEdit.Text = _myPhysio.MobileNo;
            homeTextEdit.Text = _myPhysio.HomePhone;
            businessTextEdit.Text = _myPhysio.BusPhone;
            emailTextEdit.Text = _myPhysio.EmailAddr;
            faxTextEdit.Text = _myPhysio.FaxNo;
            inactiveCheckEdit.Checked = _myPhysio.PhysioInActive.GetValueOrDefault(false);
            defaultNewPatientDuration.Duration = TimeSpan.FromTicks(_myPhysio.NewPatientAppDefaultDuration.GetValueOrDefault(9000000000L));
            defaultExistingPatientDuration.Duration = TimeSpan.FromTicks(_myPhysio.ExistingPatientAppDefaultDuration.GetValueOrDefault(9000000000L));
            lunchStartTimeEdit.Time = DateTime.MinValue + ((_myPhysio.LunchStartTime.GetValueOrDefault(defaultStartTime)));
            lunchEndTimeEdit.Time = DateTime.MinValue + (_myPhysio.LunchEndTime.GetValueOrDefault(defaultEndTime));
        }

        private void SaveToDb()
        {
            var newConnection = new dbContextDataContext();
            var currentPhysio = newConnection.tblPhysios.Where(od => od.UniqueID == myPhysio.UniqueID).SingleOrDefault();
            if (currentPhysio == null)
            {
                if (validation() == false)
                {
                    MessageBox.Show("Please complete the Physio ID and Physio Name fields");
                    this.DialogResult = DialogResult.Retry;
                }
                else
                {
                    myPhysio.PhysioID = physioIDTextEdit.Text;
                    myPhysio.PhysioName = physioNameTextEdit.Text;
                    myPhysio.ProviderNo = providerNoTextEdit.Text;
                    myPhysio.Address1 = addressTextEdit.Text;
                    myPhysio.MobileNo = mobileTextEdit.Text;
                    myPhysio.HomePhone = mobileTextEdit.Text;
                    myPhysio.BusPhone = businessTextEdit.Text;
                    myPhysio.EmailAddr = emailTextEdit.Text;
                    myPhysio.FaxNo = faxTextEdit.Text;
                    myPhysio.PhysioInActive = inactiveCheckEdit.Checked;
                    myPhysio.NewPatientAppDefaultDuration = defaultNewPatientDuration.Duration.Ticks;
                    myPhysio.ExistingPatientAppDefaultDuration = defaultExistingPatientDuration.Duration.Ticks;
                    myPhysio.LunchEndTime = lunchEndTimeEdit.Time.TimeOfDay;
                    myPhysio.LunchStartTime = lunchStartTimeEdit.Time.TimeOfDay;
                    newConnection.tblPhysios.InsertOnSubmit(myPhysio);
                }
            }
            else
            {
                currentPhysio = newConnection.tblPhysios.Where(od => od.UniqueID == myPhysio.UniqueID).SingleOrDefault();
                currentPhysio.PhysioID = physioIDTextEdit.Text;
                currentPhysio.PhysioName = physioNameTextEdit.Text;
                currentPhysio.ProviderNo = providerNoTextEdit.Text;
                currentPhysio.Address1 = addressTextEdit.Text;  
                currentPhysio.MobileNo = mobileTextEdit.Text;
                currentPhysio.HomePhone = mobileTextEdit.Text;
                currentPhysio.BusPhone = businessTextEdit.Text;
                currentPhysio.EmailAddr = emailTextEdit.Text;
                currentPhysio.FaxNo = faxTextEdit.Text;
                currentPhysio.PhysioInActive = inactiveCheckEdit.Checked;
                currentPhysio.NewPatientAppDefaultDuration = defaultNewPatientDuration.Duration.Ticks;
                currentPhysio.ExistingPatientAppDefaultDuration = defaultExistingPatientDuration.Duration.Ticks;
                currentPhysio.LunchEndTime = lunchEndTimeEdit.Time.TimeOfDay;
                currentPhysio.LunchStartTime = lunchStartTimeEdit.Time.TimeOfDay;
            }
            newConnection.SubmitChanges();

        }

        public physioViewForm()
        {
            InitializeComponent();
        }

        private void physioViewForm_Load(object sender, EventArgs e)
        {
            var newConnection = new dbContextDataContext();
            physioLookUp.Properties.DisplayMember = "PhysioName";
            physioLookUp.Properties.ValueMember = "PhysioID";
            physioLookUp.Properties.DataSource = newConnection.tblPhysios;
            
            updateForm();
        }

        private void physioLookUp_EditValueChanged(object sender, EventArgs e)
        {
            if (physioLookUp.EditValue != null)
            {
                if ((tblPhysio)physioLookUpView.GetFocusedRow() != null)
                {
                    _myPhysio = (tblPhysio)physioLookUpView.GetFocusedRow();
                    updateForm();
                }
            }
        }

        private void physioLookUpView_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            
        }

        public override void okBtn_Click(object sender, EventArgs e)
        {
            base.okBtn_Click(sender, e);
            Cursor.Current = Cursors.WaitCursor;
            SaveToDb();
            Cursor.Current = Cursors.Default;
        }

        private void newPhysioBtn_Click(object sender, EventArgs e)
        {
            _myPhysio = new tblPhysio();
            updateForm();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            var newConnection = new dbContextDataContext();
            var currentPhysio = newConnection.tblPhysios.Where(od => od.UniqueID == myPhysio.UniqueID).SingleOrDefault();
            if (currentPhysio != null)
            {
                currentPhysio = newConnection.tblPhysios.Where(od => od.UniqueID == myPhysio.UniqueID).SingleOrDefault();
                newConnection.tblPhysios.DeleteOnSubmit(currentPhysio);
                newConnection.SubmitChanges();

                physioLookUp.Properties.DataSource = newConnection.tblPhysios;
                myPhysio = new tblPhysio();
                updateForm();
                physioLookUp.EditValue = null;
            }

            else
            {
                myPhysio = new tblPhysio();
                updateForm();
                physioLookUp.EditValue = null;
            }
        }

        private void defaultAppDurationEdit_EditValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
