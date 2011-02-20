using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Linq.Expressions;
using FP_PMS.Db;

namespace FP_PMS.Admin
{
    public partial class physioRateViewForm : FP_PMS.Templates.level2TemplateForm
    {
        tblPhysioRate _myPhysioRate = new tblPhysioRate();
        tblPhysio _myPhysio;
        tblRate _myRate;
        tblItem _myItem;

        void updateForm()
        {
            if(_myPhysioRate.RateAmount != 0.0M)
            {
                var rateAmount = (decimal)_myPhysioRate.RateAmount;
                rateAmountSpinEdit.Text = rateAmount.ToString("#.##");
            }
            physioLookUp.EditValue = _myPhysioRate.PhysioID;
            rateLookUp.EditValue = _myPhysioRate.RateID;
            itemLookUp.EditValue = _myPhysioRate.ItemNo;
        }

        public physioRateViewForm()
        {
            InitializeComponent();
        }

        private void rateAmountSpinEdit_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
            e.DisplayText = "$" + e.DisplayText;
        }

        bool IsNullOrDefault<T>(T value)
        {
            return object.Equals(value, default(T));
        }

        private bool validation()
        {
            if (IsNullOrDefault(_myItem) == true)
                return false;
            if (IsNullOrDefault(_myPhysio) == true)
                return false;
            if (IsNullOrDefault(_myRate) == true)
                return false;
            if (IsNullOrDefault(rateAmountSpinEdit.Value) == true)
                return false;

            return true;
        }

        private void physioRateViewForm_Load(object sender, EventArgs e)
        {
            var newConnection = new dbContextDataContext();
            physioRateLookUp.Properties.DataSource = newConnection.tblPhysioRates;
            physioRateLookUp.Properties.ValueMember = "PhysioRateID";
            physioLookUp.Properties.DataSource = newConnection.tblPhysios;
            physioLookUp.Properties.DisplayMember = "PhysioName";
            physioLookUp.Properties.ValueMember = "PhysioID";
            rateLookUp.Properties.DataSource = newConnection.tblRates;
            rateLookUp.Properties.DisplayMember = "RateDesc";
            rateLookUp.Properties.ValueMember = "RateID";
            itemLookUp.Properties.DataSource = newConnection.tblItems;
            itemLookUp.Properties.DisplayMember = "ItemDesc";
            itemLookUp.Properties.ValueMember = "ItemNo";
        }

        private void physioRateLookUp_EditValueChanged(object sender, EventArgs e)
        {
            _myPhysioRate = (tblPhysioRate)physioRateLookUpView.GetFocusedRow();
            updateForm();
        }

        private void physioRateLookUp_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
            e.DisplayText = string.Format("{0} {1} {2}",
                physioLookUpView.GetRowCellValue(physioLookUpView.FocusedRowHandle, "PhysioID"),
                physioLookUpView.GetRowCellValue(physioLookUpView.FocusedRowHandle, "RateID"),
                physioLookUpView.GetRowCellValue(physioLookUpView.FocusedRowHandle, "ItemNo"));
        }

        void saveToDb()
        {
            var newConnection = new dbContextDataContext();
            var currentPhysioRate = newConnection.tblPhysioRates.Where(od => od.PhysioRateID == _myPhysioRate.PhysioRateID).SingleOrDefault();
            if (currentPhysioRate == null)
            {
                if (validation() == true)
                {
                    _myPhysioRate.RateAmount = rateAmountSpinEdit.Value;
                    _myPhysioRate.ItemNo = itemLookUp.EditValue.ToString();
                    _myPhysioRate.PhysioID = physioLookUp.EditValue.ToString();
                    _myPhysioRate.RateID = rateLookUp.EditValue.ToString();
                    newConnection.tblPhysioRates.InsertOnSubmit(_myPhysioRate);
                }
                else
                {
                    MessageBox.Show("Please complete all fields!");
                    this.DialogResult = DialogResult.Retry;
                }
            }
            else
            {
                _myPhysioRate = newConnection.tblPhysioRates.Where(od => od.PhysioRateID == _myPhysioRate.PhysioRateID).SingleOrDefault();
                _myPhysioRate.RateAmount = rateAmountSpinEdit.Value;
                _myPhysioRate.ItemNo = itemLookUp.EditValue.ToString();
                _myPhysioRate.PhysioID = physioLookUp.EditValue.ToString();
                _myPhysioRate.RateID = rateLookUp.EditValue.ToString();
                newConnection.tblPhysioRates.InsertOnSubmit(_myPhysioRate);
            }
            newConnection.SubmitChanges();

        }

        public override void okBtn_Click(object sender, EventArgs e)
        {
            base.okBtn_Click(sender, e);
            saveToDb();
        }

        private void physioLookUp_EditValueChanged(object sender, EventArgs e)
        {
            _myPhysio = (tblPhysio)physioLookUpView.GetFocusedRow();
        }

        private void rateLookUp_EditValueChanged(object sender, EventArgs e)
        {
            _myRate = (tblRate)rateLookUp.GetSelectedDataRow();
        }

        private void itemLookUp_EditValueChanged(object sender, EventArgs e)
        {
            _myItem = (tblItem)itemLookUpView.GetFocusedRow();
        }
    }
}
