using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FP_PMS.Db;
using FP_PMS.Ex;
using FP_PMS.Interfaces;

namespace FP_PMS.Accounting.Invoice
{
    public partial class newAddItemForm : FP_PMS.Templates.level2TemplateForm
    {
        tblPhysio _myPhysio = new tblPhysio();
        tblRate _myRate = new tblRate();
        tblClaimant _myClaimant = new tblClaimant();
        AnonInvoiceLines _myLine = new AnonInvoiceLines();

        tblPhysio myPhysio { get { return _myPhysio; } set { _myPhysio = value; } }
        tblRate myRate { get { return _myRate; } set { _myRate = value; } }
        tblClaimant myClaimant { get { return _myClaimant; } set { _myClaimant = value; } }
        public AnonInvoiceLines myLine { get { return _myLine; } set { _myLine = value; } }

        public newAddItemForm(tblPhysio MyPhysio, tblRate MyRate, tblClaimant MyClaimant)
        {
            InitializeComponent();
            myRate = MyRate;
            myPhysio = MyPhysio;
            myClaimant = MyClaimant;
        }

        private void newAddItemForm_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            var newConnection = new dbContextDataContext();
            sessionDateEdit.DateTime = System.DateTime.Today;
            patientLookUp.Properties.DataSource = newConnection.getPatientsOfClaimant(myClaimant.ClaimantID).ToList();
            if (myRate.RateID != "N")
            {
                itemLookUp.Properties.DataSource = newConnection.getPhysioRateItems(myPhysio.PhysioID, myRate.RateID).ToList();
            }
            else
            {
                itemLookUp.Properties.DataSource = newConnection.getPhysioNoChargeItems(myPhysio.PhysioID).ToList();
            }

            Cursor.Current = Cursors.Default;
        }

        public override void okBtn_Click(object sender, EventArgs e)
        {
            if (itemLookUpGridView.GetFocusedRow() != null)
            {
                if(myRate.RateID != "N")
                myLine.ItemNo = ((getPhysioRateItemsResult)itemLookUpGridView.GetFocusedRow()).ItemNo;
                else
                    myLine.ItemNo = ((getPhysioNoChargeItemsResult)itemLookUpGridView.GetFocusedRow()).ItemNo;
            }
            else
            {
                MessageBox.Show("Please select an item!");
                this.DialogResult = DialogResult.Retry;
                return;
            }
            if (patientLookUpGridView.GetFocusedRow() != null)
            {
                    myLine.PatientName = ((getPatientsOfClaimantResult)patientLookUpGridView.GetFocusedRow()).Name;
                    myLine.PatientID = ((getPatientsOfClaimantResult)patientLookUpGridView.GetFocusedRow()).PatientID;
            }
            else
            {
                MessageBox.Show("Please select a patient!");
                this.DialogResult = DialogResult.Retry;
                return;
            }

            if (feeSpinEdit.Value >= 0)
            {
                myLine.Fee = feeSpinEdit.Value;
            }
            else
            {
                MessageBox.Show("Fee value can not be negative!");
                this.DialogResult = DialogResult.Retry;
                return;
            }

            if (gstSpinEdit.Value >= 0)
            {
                myLine.GST = gstSpinEdit.Value;
            }
            else
            {
                MessageBox.Show("GST value can not be negative!");
                this.DialogResult = DialogResult.Retry;
                return;
            }
            myLine.SessionDate = sessionDateEdit.DateTime;
            myLine.RateID = myRate.RateID;
            base.okBtn_Click(sender, e);
        }

        private void itemLookUp_EditValueChanged(object sender, EventArgs e)
        {
            if (myRate.RateID != "N")
            {
                feeSpinEdit.Value = ((getPhysioRateItemsResult)itemLookUpGridView.GetFocusedRow()).Fee;
                gstSpinEdit.Value = ((getPhysioRateItemsResult)itemLookUpGridView.GetFocusedRow()).GST;
            }
        }

        private void addGSTBtn_Click(object sender, EventArgs e)
        {
            //uses the GeneralSetting Table in db to retrieve the GST percentage. only one row in the table.
            //uses decimal(3,2) to get 2 decimal places in SQL server.

            Cursor.Current = Cursors.WaitCursor;
            var newConnection = new dbContextDataContext();
            GeneralSetting myGeneralSetting = newConnection.GeneralSettings.FirstOrDefault();

            if (myGeneralSetting != null)
            {
                decimal gstPercentage = (decimal)myGeneralSetting.GSTPercentage.Value;

                if (gstPercentage != 0M)
                {
                    var _myGST = decimal.Multiply(feeSpinEdit.Value, gstPercentage);

                    gstSpinEdit.Value = _myGST;
                }
                else
                    MessageBox.Show("GST percentage is not defined, please enter GST amount manually.");
            }
                
            Cursor.Current = Cursors.Default;
        }
    }
}
