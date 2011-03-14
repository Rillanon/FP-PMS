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
            this.reportPrintingSystem.PrintDlg();
        }

        private void reportPrintableComponent_CreateReportHeaderArea(object sender, DevExpress.XtraPrinting.CreateAreaEventArgs e)
        {
            DevExpress.XtraPrinting.TextBrick brick;
            brick = e.Graph.DrawString("Aged Trail Balance Report " + startDate.ToShortDateString() + "-" + endDate.ToShortDateString()
            , Color.Navy, new RectangleF(0, 0, 500, 40), DevExpress.XtraPrinting.BorderSide.None);
            brick.Font = new Font("Tahoma", 10);
            brick.StringFormat = new DevExpress.XtraPrinting.BrickStringFormat(StringAlignment.Center);
        }

        public void printPreview()
        {
            this.reportPrintableComponentLink.ShowPreview();
        }

        public void fillData()
        {
            Cursor.Current = Cursors.WaitCursor;
            var newConnection = new dbContextDataContext();
            var cid = new object();
            var pid = new object();

            if ((myClaimant.ClaimantID == 0) && (myPhysio.UniqueID != 0))
                this.agedTrailGridControl.DataSource = newConnection.getAgedTrailBalance(null, myPhysio.PhysioID, startDate, endDate);

            else if ((myClaimant.ClaimantID != 0) && (myPhysio.UniqueID == 0))
                this.agedTrailGridControl.DataSource = newConnection.getAgedTrailBalance(myClaimant.ClaimantID, null, startDate, endDate);
            else if ((myClaimant.ClaimantID == 0) && (myPhysio.UniqueID == 0))
                this.agedTrailGridControl.DataSource = newConnection.getAgedTrailBalance(null, null, startDate, endDate);
            else
            this.agedTrailGridControl.DataSource = newConnection.getAgedTrailBalance(myClaimant.ClaimantID, myPhysio.PhysioID, startDate, endDate);
            
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

        private void agedTrailGridView_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if ((e.DisplayText == "Overdue") || (e.DisplayText == "Private Claimant"))
            {
                e.Appearance.ForeColor = System.Drawing.Color.Red;
                e.Appearance.Font = new Font("Tahoma", 10);
            }
        }
    }
}
