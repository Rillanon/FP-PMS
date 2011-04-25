using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Linq.Expressions;
using DevExpress.Data.Linq;
using DevExpress.Data;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using FP_PMS.Db;
using FP_PMS.Ex;

namespace FP_PMS.Claimant
{
    public partial class claimantListForm : DevExpress.XtraEditors.XtraForm
    {
        
        public claimantListForm()
        {
            InitializeComponent();
         
        }



        private void claimantLinqInstantFeedbackSource_GetQueryable(object sender, DevExpress.Data.Linq.GetQueryableEventArgs e)
        {
            try
            {
                var newConnection = new dbContextDataContext();
                newConnection.ObjectTrackingEnabled = false;
                e.QueryableSource = newConnection.tblClaimants;
                e.Tag = newConnection;
            }
            catch (Exception)
            {
                MessageBox.Show("here");
            }
        }

        private void claimantLinqInstantFeedbackSource_DismissQueryable(object sender, DevExpress.Data.Linq.GetQueryableEventArgs e)
        {
            try
            {
                ((dbContextDataContext)e.Tag).Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show("here");
            }
        }

        private void claimantDetailsForm_Load(object sender, EventArgs e)
        {
        }

        private void newClaimantBtn_Click(object sender, EventArgs e)
        {
            var newClaimantForm = new claimantDetailsForm();
            newClaimantForm.ShowDialog();
        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            if (claimantViewGridView.IsAsyncInProgress == false)
            {
                if (claimantViewGridView.GetFocusedRow() != null)
                {
                    var currentRow = (tblClaimant)claimantViewGridView.GetFocusedRow();
                    var newClaimantForm = new claimantDetailsForm(currentRow);
                    newClaimantForm.ShowDialog();
                    if (newClaimantForm.DialogResult == DialogResult.OK)
                    {
                        claimantLinqInstantFeedbackSource.Refresh();
                    }
                }
            }
            else
            {
                MessageBox.Show("Data update in progress. Please try again later.");
            }
        }

        private void quitBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void claimantListForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.quitBtn_Click(sender, e);
            }
        }
    }
}