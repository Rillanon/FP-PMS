using System;
using System.Linq;
using System.Data.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FP_PMS.Db;

namespace FP_PMS.Accounting.Invoice
{
    public partial class addItemForm : FP_PMS.Templates.level2TemplateForm
    {
        private tblPatientStat _myLine = new tblPatientStat();
        private tblPhysio _myPhysio;
        private tblRate _myRate;
        private tblItem _myItem;
        private tblPatient _myPatient;
        private decimal _myFee;
        private decimal _myGST;
        List<tblItem> itemList = new List<tblItem> { };
        List<tblPhysioRate> physioRateList = new List<tblPhysioRate> { };
        BindingList<tblPatient> myPatientList = new BindingList<tblPatient> { };

        public tblPatientStat myLine { get { return _myLine; } }
        public tblClaimant myClaimant { get; set; }

        static Func<dbContextDataContext, int, IQueryable<tblPatient>> GetPatients =
    CompiledQuery.Compile((dbContextDataContext db, int cid) =>
        (from claimant in db.tblClaimants.Where(c => c.ClaimantID == cid).DefaultIfEmpty()
         from patientClaimant in db.tblPatientClaimants.Where(pc => pc.ClaimantID == cid).DefaultIfEmpty()
         from patient in db.tblPatients.Where(p => (p.ClaimantID == claimant.ClaimantID)
             || (p.ClaimantID == patientClaimant.ClaimantID)).DefaultIfEmpty()
         select patient).Distinct());

        void getFee()
        {
            tblPhysioRate x = new tblPhysioRate();
                x = (from p in physioRateList
                                        where (p.ItemNo == _myItem.ItemNo) &&
                                        (p.PhysioID == _myPhysio.PhysioID) &&
                                        (p.RateID == _myRate.RateID)
                                        select p).FirstOrDefault();
                if (x != null)
                {
                    if (x.RateAmount != null)
                    {
                        _myFee = (decimal)x.RateAmount;
                        feeSpinEdit.Value = _myFee;
                    }
                    else
                    {
                        _myFee = 0.00M;
                        feeSpinEdit.Value = _myFee;
                    }

                    if (x.GST != null)
                    {
                        _myGST = (decimal)x.GST;
                        gstSpinEdit.Value = _myGST;
                    }
                    else
                    {
                        _myGST = 0.00M;
                        gstSpinEdit.Value = _myGST;
                    }

                }
                else
                {
                    feeSpinEdit.ResetText();
                }
        }

        bool IsNullOrDefault<T>(T value)
        {
            return object.Equals(value, default(T));
        }

        bool validation()
        {
            if (_myFee == 0.0M)
                    {
                MessageBox.Show("Please enter fee amount.");
                return false;
            }
            if (IsNullOrDefault(_myPatient))
                    {
                MessageBox.Show("Please select a patient.");
                return false;
            }
            if (IsNullOrDefault(_myPhysio))
            {
                MessageBox.Show("Please select a physio.");
                return false;
            }
            if (IsNullOrDefault(_myItem))
                    {
                MessageBox.Show("Please select an item.");
                return false;
            }

            return true;
        }

        bool feeValidation()
        {
            if (IsNullOrDefault(_myPatient))
            {
                return false;
            }
            if (IsNullOrDefault(_myPhysio))
            {
                return false;
            }
            if (IsNullOrDefault(_myItem))
            {
                return false;
            }
            return true;
        }


        public addItemForm(tblClaimant MyClaimant)
        {
            InitializeComponent();
            myClaimant = MyClaimant;
        }

        private void okBtn_Click_1(object sender, EventArgs e)
        {
            if (validation())
            {
                _myLine.Fee = _myFee;
                _myLine.GST = _myGST;
                _myLine.ItemNo = _myItem.ItemNo;
                _myLine.PhysioID = _myPhysio.PhysioID;
                _myLine.SessionDate = System.DateTime.Today;
                _myLine.RateID = _myRate.RateID;
                if (_myGST != 0.0M)
                {
                    _myLine.GSTApplied = true;
                }

                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.Retry;
            }
        }

        private void quitBtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addItemForm_Load(object sender, EventArgs e)
        {
            var newConnection = new dbContextDataContext();
            physioLookUp.Properties.DisplayMember = "PhysioName";
            physioLookUp.Properties.ValueMember = "PhysioID";
            physioLookUp.Properties.DataSource = newConnection.tblPhysios;

            itemLookUp.Properties.DisplayMember = "ItemDesc";
            itemLookUp.Properties.ValueMember = "ItemNo";
            itemList = newConnection.tblItems.ToList();
            itemLookUp.Properties.DataSource = itemList;

            rateLookUp.Properties.DisplayMember = "RateDesc";
            rateLookUp.Properties.ValueMember = "RateID";
            rateLookUp.Properties.DataSource = newConnection.tblRates;

            patientLookUp.Properties.DisplayMember = "";
            patientLookUp.Properties.ValueMember = "PatientID";

            physioRateList = newConnection.tblPhysioRates.ToList();

            //patientLookUp.Properties.DataSource = (from claimant in newConnection.tblClaimants.Where(c => c.ClaimantID == myClaimant.ClaimantID).DefaultIfEmpty()
            //                                       from patientClaimant in newConnection.tblPatientClaimants.Where(pc => pc.ClaimantID == myClaimant.ClaimantID).DefaultIfEmpty()
            //                                       from patient in newConnection.tblPatients.Where(p => p.PatientID == patientClaimant.PatientID)
                                                       
            //                                       select patient).Distinct();

            var patientList = (from claimant in newConnection.tblClaimants.Where(c => c.ClaimantID == myClaimant.ClaimantID).DefaultIfEmpty()
                               from patientClaimant in newConnection.tblPatientClaimants.Where(pc => pc.ClaimantID == myClaimant.ClaimantID).DefaultIfEmpty()
                               from patient in newConnection.tblPatients.Where(p => p.PatientID == patientClaimant.PatientID)

                               select patient).Distinct().ToList();
            var patientList2 = (from patient in newConnection.tblPatients.Where(p => p.ClaimantID == myClaimant.ClaimantID)
                                select patient).Distinct().ToList();

            foreach (var x in patientList2)
            {
                patientList.Add(x);
            }


            patientLookUp.Properties.DataSource = patientList;
            //var patientList = (from claimant in newConnection.tblClaimants.Where(c => c.ClaimantID == myClaimant.ClaimantID).DefaultIfEmpty()
            //                   from patientClaimant in newConnection.tblPatientClaimants.Where(pc => pc.ClaimantID == myClaimant.ClaimantID).DefaultIfEmpty()
            //                   from patient in newConnection.tblPatients.Where(p => (p.ClaimantID == claimant.ClaimantID)
            //                       || (p.ClaimantID == patientClaimant.ClaimantID)).DefaultIfEmpty()
            //                   select patient).ToList();

            //myPatientList = new BindingList<tblPatient>(patientList);
            //myPatientList.AllowEdit = true;

            //patientLookUp.Properties.DataSource = myPatientList;
        }

        private void patientLookUp_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
            e.DisplayText = string.Format("{0} {1}",
                patientLookUpView.GetRowCellValue(patientLookUpView.FocusedRowHandle, "FirstNames"),
                patientLookUpView.GetRowCellValue(patientLookUpView.FocusedRowHandle, "LastName"));
        }

        private void rateLookUp_EditValueChanged(object sender, EventArgs e)
        {
            _myRate = new tblRate();
            _myRate = (tblRate)rateLookUpView.GetFocusedRow();

            if (_myRate != null)
            {
                if (_myPhysio == null)
                {
                    itemLookUp.Properties.DataSource = (from p in physioRateList.Where(p => p.RateID == _myRate.RateID).DefaultIfEmpty()
                                                        from i in itemList.Where(i => i.ItemNo == p.ItemNo).DefaultIfEmpty()
                                                        select i).Distinct().ToList();
                }
                else
                {
                    itemLookUp.Properties.DataSource = (from p in physioRateList.Where(p => (p.PhysioID == _myPhysio.PhysioID) && (p.RateID == _myRate.RateID)).DefaultIfEmpty()
                                                        from i in itemList.Where(i => i.ItemNo == p.ItemNo).DefaultIfEmpty()
                                                        select i).Distinct().ToList();
                }

                if (feeValidation())
                    getFee();
            }
        }

        private void patientLookUp_EditValueChanged(object sender, EventArgs e)
        {
            _myPatient = new tblPatient();
            _myPatient = (tblPatient)patientLookUpView.GetFocusedRow();
        }

        private void physioLookUp_EditValueChanged(object sender, EventArgs e)
        {
            _myPhysio = new tblPhysio();
            _myPhysio = (tblPhysio)physioLookUpView.GetFocusedRow();

            if (_myPhysio != null)
            {
                if (_myRate == null)
                {
                    itemLookUp.Properties.DataSource = (from p in physioRateList.Where(p => p.PhysioID == _myPhysio.PhysioID).DefaultIfEmpty()
                                                        from i in itemList.Where(i => i.ItemNo == p.ItemNo).DefaultIfEmpty()
                                                        select i).Distinct().ToList();
                }
                else
                {
                    itemLookUp.Properties.DataSource = (from p in physioRateList.Where(p => (p.PhysioID == _myPhysio.PhysioID) 
                        && (p.RateID == _myRate.RateID)).DefaultIfEmpty()
                                                        from i in itemList.Where(i => i.ItemNo == p.ItemNo).DefaultIfEmpty()
                                                        select i).Distinct().ToList();
                }

                if (feeValidation())
                    getFee();
            }
        }
        
        private void itemLookUp_EditValueChanged(object sender, EventArgs e)
        {
            _myItem = new tblItem();
            _myItem = (tblItem)itemLookUpView.GetFocusedRow();
            if (feeValidation())
                getFee();
        }

        private void feeSpinEdit_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
            e.DisplayText = "$" + e.DisplayText;
        }

        private void gstSpinEdit_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
            e.DisplayText = "$" + e.DisplayText;
        }

        private void addGSTBtn_Click(object sender, EventArgs e)
        {
            //uses the GeneralSetting Table in db to retrieve the GST percentage. only one row in the table.
            //uses decimal(3,2) to get 2 decimal places in SQL server.

            var newConnection = new dbContextDataContext();
            GeneralSetting myGeneralSetting = newConnection.GeneralSettings.FirstOrDefault();
           
            if(myGeneralSetting != null)
                {
                decimal gstPercentage = (decimal)myGeneralSetting.GSTPercentage.Value;
                
                if (gstPercentage != 0M)
                {
                    _myGST = decimal.Multiply(_myFee, gstPercentage);
                    
                    gstSpinEdit.Text = _myGST.ToString("#.##");
                }
                else
                    MessageBox.Show("GST percentage is not defined, please enter manually.");
            }
            else
            {

            }
        }

        private void feeSpinEdit_EditValueChanged(object sender, EventArgs e)
        {
            var parseString = feeSpinEdit.Text.TrimStart('$');
            _myFee = decimal.Parse(parseString);
        }

        private void gstSpinEdit_EditValueChanged(object sender, EventArgs e)
        {
            var parseString = gstSpinEdit.Text.TrimStart('$');
            _myGST = decimal.Parse(parseString);
        }

        private void addItemForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.Retry)
            {
                e.Cancel = true;
            }
        }
    }
}
