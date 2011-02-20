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
    public partial class postCodeViewForm : FP_PMS.Templates.level2TemplateForm
    {
        tblPostcode _myPostCode = new tblPostcode();


        bool IsNullOrDefault<T>(T value)
        {
            return object.Equals(value, default(T));
        }

        private bool validation()
        {
            if (IsNullOrDefault(postCodeTextEdit.Text) == false)
                return true;
            if (IsNullOrDefault(locationTextEdit.Text) == false)
                return true;
            if (IsNullOrDefault(stateComboBoxEdit.Text) == false)
                return true;

            return false;
        }

        void updateForm()
        {
            postCodeTextEdit.Text = _myPostCode.Postcode;
            locationTextEdit.Text = _myPostCode.Location;
            stateComboBoxEdit.Text = _myPostCode.State;
        }

        void saveToDb()
        {
            var newConnection = new dbContextDataContext();
            var currentPostCode = newConnection.tblPostcodes.Where(od => od.PostcodeID == _myPostCode.PostcodeID).SingleOrDefault();
            if (currentPostCode == null)
            {
                if (validation() == true)
                {
                    _myPostCode.Location = locationTextEdit.Text;
                    _myPostCode.State = stateComboBoxEdit.Text;
                    _myPostCode.Postcode = postCodeTextEdit.Text;
                    newConnection.tblPostcodes.InsertOnSubmit(_myPostCode);
                }
                else
                {
                    MessageBox.Show("Please complete all fields!");
                    this.DialogResult = DialogResult.Retry;
                }
            }
            else
            {
                _myPostCode = newConnection.tblPostcodes.Where(od => od.PostcodeID == _myPostCode.PostcodeID).SingleOrDefault();
                _myPostCode.Location = locationTextEdit.Text;
                _myPostCode.State = stateComboBoxEdit.Text;
                _myPostCode.Postcode = postCodeTextEdit.Text;
                newConnection.tblPostcodes.InsertOnSubmit(_myPostCode);
            }
            newConnection.SubmitChanges();
        }

        public postCodeViewForm()
        {
            InitializeComponent();
        }

        private void postCodeViewForm_Load(object sender, EventArgs e)
        {
            var newConnection = new dbContextDataContext();
            postCodeLookUp.Properties.DataSource = newConnection.tblPostcodes;
            postCodeLookUp.Properties.DisplayMember = "Location";
            postCodeLookUp.Properties.ValueMember = "PostcodeID";
        }

        private void postCodeLookUp_EditValueChanged(object sender, EventArgs e)
        {
            _myPostCode = (tblPostcode)postCodeLookUpView.GetFocusedRow();
            updateForm();
        }

        public override void okBtn_Click(object sender, EventArgs e)
        {
            base.okBtn_Click(sender, e);
            saveToDb();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            var newConnection = new dbContextDataContext();
            var currentPostCode = newConnection.tblPostcodes.Where(od => od.PostcodeID == _myPostCode.PostcodeID).SingleOrDefault();
            if (currentPostCode != null)
            {
                newConnection.tblPostcodes.DeleteOnSubmit(currentPostCode);
            }
            newConnection.SubmitChanges();
            postCodeLookUp.Properties.DataSource = newConnection.tblPostcodes;
            _myPostCode = new tblPostcode();
            updateForm();
        }
    }
}
