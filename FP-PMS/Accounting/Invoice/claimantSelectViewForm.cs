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
using DevExpress.Data.Linq;
using FP_PMS.Ex;

namespace FP_PMS.Accounting.Invoice
{
    public partial class claimantSelectViewForm : FP_PMS.Templates.level2TemplateForm
    {
        tblClaimant _myClaimant;

        public tblClaimant myClaimant { get { return _myClaimant; } set { _myClaimant = value; } }
        public claimantSelectViewForm()
        {
            InitializeComponent();
            claimantLookUp.Properties.PopupFindMode = DevExpress.XtraEditors.FindMode.FindClick;
            claimantInstantFeedBack.GetQueryable += claimantInstantFeedBack_GetQueryable;
            claimantInstantFeedBack.DismissQueryable += claimantInstantFeedBack_DismissQueryable;
            claimantLookUp.Properties.DataSource = claimantInstantFeedBack;
        }

        public claimantSelectViewForm(int PatientID)
        {
            InitializeComponent();
            var newConnection = new dbContextDataContext();

            List<tblClaimant> claimantList = new List<tblClaimant> {};
            claimantList  = (from patient in newConnection.tblPatients.Where(p => p.PatientID == PatientID).DefaultIfEmpty()
                                                    
                                                    from patientClaimant in newConnection.tblPatientClaimants.Where(pc => pc.PatientID == PatientID).DefaultIfEmpty()
                                                    
                                                    from claimant in newConnection.tblClaimants.Where(c => (c.ClaimantID == patientClaimant.ClaimantID)
                                                        || (c.ClaimantID == patient.ClaimantID)).DefaultIfEmpty()
                                                    select claimant).Distinct().ToList();

            claimantLookUp.Properties.DataSource = claimantList;
            claimantLookUp.EditValue = claimantList.FirstOrDefault().ClaimantID;
            myClaimant = claimantList.FirstOrDefault();
        }



        private void claimantSelectViewForm_Load(object sender, EventArgs e)
        {
            //claimantInstantFeedBack.DesignTimeElementType = typeof(tblClaimant);
            claimantInstantFeedBack.KeyExpression = "ClaimantID";
            claimantLookUp.Properties.DisplayMember = "LastName";
            claimantLookUp.Properties.ValueMember = "ClaimantID";
            
        }

        void claimantInstantFeedBack_GetQueryable(object sender, GetQueryableEventArgs e)
        {
            var newConnection = new dbContextDataContext();
                e.QueryableSource = newConnection.tblClaimants;
                e.Tag = newConnection;
            
        }

        void claimantInstantFeedBack_DismissQueryable(object sender, GetQueryableEventArgs e)
        {
            ((dbContextDataContext)e.Tag).Dispose();  
        }

        private void okBtn_Click_1(object sender, EventArgs e)
        {
            if (myClaimant != null)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                DialogResult = DialogResult.Retry;
            }
            
        }

        private void claimantLookUpView_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            
        }

        private void claimantSelectViewForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.Retry)
            {
                MessageBox.Show("You must choose a claimant before proceeding.");
                e.Cancel = true;
            }
        }

        private void claimantLookUp_EditValueChanged(object sender, EventArgs e)
        {
            myClaimant = entityClone.Clone((tblClaimant)claimantLookUpView.GetFocusedRow());
        }

        private void claimantLookUpView_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            
        }
    }
}
