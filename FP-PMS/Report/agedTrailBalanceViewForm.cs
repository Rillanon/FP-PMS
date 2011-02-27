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
    public partial class agedTrailBalanceViewForm : FP_PMS.Templates.level2TemplateForm, Interfaces.IReport
    {
        tblClaimant _myClaimant = new tblClaimant();
        tblPhysio _myPhysio = new tblPhysio();
        DateTime _startDate = new DateTime();
        DateTime _endDate = new DateTime();
        BindingList<getAgedTrailBalanceResult> reportDataList = new BindingList<getAgedTrailBalanceResult> { };
        public DateTime endDate { get { return _endDate; } set { _endDate = value; } }
        public DateTime startDate { get { return _startDate; } set { _startDate = value; } }
        public tblClaimant myClaimant { get { return _myClaimant; } set { _myClaimant = value; } }
        public tblPhysio myPhysio { get { return _myPhysio; } set { _myPhysio = value; } }

        public void print()
        {
            this.agedTrailBalancePivotGrid.Print();
        }

        public void printPreview()
        {
            this.agedTrailBalancePivotGrid.ShowPrintPreview();
        }

        public void fillData()
        {
            Cursor.Current = Cursors.WaitCursor;
            var newConnection = new dbContextDataContext();

            this.agedTrailBalancePivotGrid.DataSource = newConnection.getAgedTrailBalance(null, myPhysio.PhysioID, startDate, endDate);
            
            Cursor.Current = Cursors.Default;
        }

        public void updateView()
        {
            
        }

        public void calculateSummaries()
        {

        }

        public agedTrailBalanceViewForm(tblClaimant MyClaimant, tblPhysio MyPhysio, DateTime StartDate, DateTime EndDate)
        {
            InitializeComponent();
            myClaimant = MyClaimant;
            myPhysio = MyPhysio;
            startDate = StartDate;
            endDate = EndDate;
        }

        private void agedTrailBalanceViewForm_Load(object sender, EventArgs e)
        {
            fillData();
        }

        public override void okBtn_Click(object sender, EventArgs e)
        {
            base.okBtn_Click(sender, e);
            
        }
    }
}
