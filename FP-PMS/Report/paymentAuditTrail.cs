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

namespace FP_PMS.Report
{
    public partial class paymentAuditTrail : FP_PMS.Templates.level2TemplateForm, Interfaces.IPrinting
    {
        DateTime Start { get; set; }
        DateTime End { get; set; }

        public paymentAuditTrail()
        {
            InitializeComponent();
        }

        public void printPreview()
        {
            this.reportPrintableComponentLink.ShowPreview();
        }

        public void print()
        {
            this.reportPrintingSystem.PrintDlg();
        }

        private void paymentAuditTrail_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            var newDatePickerDialog = new dateIntervalDialog();
            var newConnection = new dbContextDataContext();

            newDatePickerDialog.ShowDialog();

            if (newDatePickerDialog.DialogResult == DialogResult.OK)
            {
                Start = newDatePickerDialog.startDate;
                End = newDatePickerDialog.endDate;

                paymentAuditTrialPivotGridControl.DataSource = newConnection.getPaymentAuditTrial(newDatePickerDialog.startDate, newDatePickerDialog.endDate);
                newDatePickerDialog.Dispose();
            }
            else
            {
                newDatePickerDialog.Dispose();
                this.Close();
            }
            Cursor.Current = Cursors.Default;
        }

        private void reportPrintableComponentLink_CreateReportHeaderArea(object sender, DevExpress.XtraPrinting.CreateAreaEventArgs e)
        {
            DevExpress.XtraPrinting.TextBrick brick;
            brick = e.Graph.DrawString("Payment Audit Report " + Start.ToShortDateString() + "-" + End.ToShortDateString()
            , Color.Navy, new RectangleF(0, 0, 500, 40), DevExpress.XtraPrinting.BorderSide.None);
            brick.Font = new Font("Tahoma", 10);
            brick.StringFormat = new DevExpress.XtraPrinting.BrickStringFormat(StringAlignment.Center);
        }
    }
}
