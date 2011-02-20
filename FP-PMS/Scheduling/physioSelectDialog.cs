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

namespace FP_PMS.Scheduling
{
    public partial class physioSelectDialog : FP_PMS.Templates.level3TemplateForm
    {
        tblPhysio _myPhysio = new tblPhysio();
        public tblPhysio myPhysio { get { return _myPhysio; } set { _myPhysio = value; } }
        
        public physioSelectDialog()
        {
            InitializeComponent();
        }

        private void physioLinqInstantFeedBackSource_DismissQueryable(object sender, DevExpress.Data.Linq.GetQueryableEventArgs e)
        {
            ((dbContextDataContext)e.Tag).Dispose();
        }

        private void physioLinqInstantFeedBackSource_GetQueryable(object sender, DevExpress.Data.Linq.GetQueryableEventArgs e)
        {
            var newConnection = new dbContextDataContext();
            e.QueryableSource = newConnection.tblPhysios;
            e.Tag = newConnection;
        }

        public override void okBtn_Click(object sender, EventArgs e)
        {
            base.okBtn_Click(sender, e);
            var currentRow = (tblPhysio)physioLookUpView.GetFocusedRow();
            if (currentRow != null)
            {
                myPhysio = currentRow;
            }
            else
            {
                MessageBox.Show("Please select a physio.");
                this.DialogResult = DialogResult.Retry;
            }
        }
    }
}
