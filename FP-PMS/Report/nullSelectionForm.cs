using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Linq;
using FP_PMS.Db;
using FP_PMS.Ex;

namespace FP_PMS.Report
{
    public partial class nullSelectionForm : FP_PMS.Templates.level2TemplateForm
    {
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }

        tblPhysio _myPhysio = new tblPhysio();
        tblClaimant _myClaimant = new tblClaimant();

        public tblPhysio myPhysio { get { return _myPhysio; } set { _myPhysio = value; } }
        public tblClaimant myClaimant { get { return _myClaimant; } set { _myClaimant = value; } }

        

        public nullSelectionForm()
        {
            InitializeComponent();
            endDatePicker.DateTime = System.DateTime.Today;
        }

        public override void okBtn_Click(object sender, EventArgs e)
        {
            if (startDatePicker.DateTime == DateTime.MinValue)
            {
                MessageBox.Show("Please select a start date.");
                this.DialogResult = DialogResult.Retry;
                return;
            }
            
            base.okBtn_Click(sender, e);
            int result = DateTime.Compare(startDate, endDate);

            if (result > 0)
            {
                MessageBox.Show("End date can not be earlier than start date.");
                this.DialogResult = DialogResult.Retry;
                return;
            }
            else
            {
                startDate = startDatePicker.DateTime;
                endDate = endDatePicker.DateTime;
                if (allCheckEdit.Checked == true)
                {
                    myClaimant.ClaimantID = 0;
                    myPhysio.UniqueID = 0;
                }

                this.DialogResult = DialogResult.OK;
            }
        }

        private void nullSelectionForm_Load(object sender, EventArgs e)
        {
            physioLookUp.Properties.DataSource = new dbContextDataContext().tblPhysios;
            claimantlinqInstantFeedbackSource.KeyExpression = "ClaimantID";
            claimantlinqInstantFeedbackSource.DesignTimeElementType = typeof(tblClaimant);
            claimantLookUp.Properties.DisplayMember = "LastName";
            claimantLookUp.Properties.ValueMember = "ClaimantID";
        }

        private void claimantlinqInstantFeedbackSource_DismissQueryable(object sender, DevExpress.Data.Linq.GetQueryableEventArgs e)
        {
            ((dbContextDataContext)e.Tag).Dispose();
        }

        private void claimantlinqInstantFeedbackSource_GetQueryable(object sender, DevExpress.Data.Linq.GetQueryableEventArgs e)
        {
            var newConnection = new dbContextDataContext();
            e.QueryableSource = newConnection.tblClaimants;
            e.Tag = newConnection;
        }

        private void claimantLookUp_EditValueChanged(object sender, EventArgs e)
        {
            if (claimantLookUpView.GetFocusedRow() != null)
                myClaimant = (tblClaimant)claimantLookUpView.GetFocusedRow();
        }

        private void physioLookUp_EditValueChanged(object sender, EventArgs e)
        {
            if (physioLookUpView.GetFocusedRow() != null)
                myPhysio = (tblPhysio)physioLookUpView.GetFocusedRow();
        }
    }
}
