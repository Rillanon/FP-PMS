using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Data.Linq;
using FP_PMS.Db;

namespace FP_PMS.Claimant
{
    public partial class claimantDetailsForm : DevExpress.XtraEditors.XtraForm
    {
        
        public claimantDetailsForm()
        {
            InitializeComponent();

        }

        private void claimantLinqInstantFeedbackSource_DismissQueryable(object sender, DevExpress.Data.Linq.GetQueryableEventArgs e)
        {
            ((dbContextDataContext)e.Tag).Dispose();
        }

        private void claimantLinqInstantFeedbackSource_GetQueryable(object sender, DevExpress.Data.Linq.GetQueryableEventArgs e)
        {
            var myConnection = new dbContextDataContext();
            e.QueryableSource = myConnection.tblClaimants;
            e.Tag = myConnection;
        }

        private void claimantDetailsForm_Load(object sender, EventArgs e)
        {
            claimantViewGridControl.DataSource = claimantLinqInstantFeedbackSource;
        }
    }
}