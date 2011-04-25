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

namespace FP_PMS.Referral
{
    public partial class referralListForm : DevExpress.XtraEditors.XtraForm
    {
        public referralListForm()
        {
            InitializeComponent();
        }

        private void referralInstantFeedBack_DismissQueryable(object sender, DevExpress.Data.Linq.GetQueryableEventArgs e)
        {
            ((dbContextDataContext)e.Tag).Dispose();
        }

        private void referralInstantFeedBack_GetQueryable(object sender, DevExpress.Data.Linq.GetQueryableEventArgs e)
        {
            var newConnection = new dbContextDataContext();
            e.QueryableSource = newConnection.tblRefDoctors;
            e.Tag = newConnection;
        }

        private void quitBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void newReferralBtn_Click(object sender, EventArgs e)
        {
            var newReferralDoctorForm = new referralDetailsForm();
            newReferralDoctorForm.ShowDialog();
            if (newReferralDoctorForm.DialogResult == DialogResult.OK)
            {
                referralInstantFeedBack.Refresh();
            }
        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            if (referralGridView.IsAsyncInProgress != true)
            {
                if (referralGridView.GetFocusedRow() != null)
                {
                    var newReferralDoctorForm = new referralDetailsForm((tblRefDoctor)referralGridView.GetFocusedRow());

                    newReferralDoctorForm.ShowDialog();

                    if (newReferralDoctorForm.DialogResult == DialogResult.OK)
                    {
                        referralInstantFeedBack.Refresh();
                    }
                }
            }
            else
            {
                MessageBox.Show("Data update in progress. Please try again later.");
            }
        }

        private void referralListForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.quitBtn_Click(sender, e);
            }
        }
    }
}