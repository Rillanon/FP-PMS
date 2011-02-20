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
    public partial class journalReportViewForm : FP_PMS.Templates.level2TemplateForm
    {
        public journalReportViewForm()
        {
            InitializeComponent();
        }

        private void journalReportViewForm_Load(object sender, EventArgs e)
        {
            var newDatePickerDialog = new dateIntervalDialog();
            var newConnection = new dbContextDataContext();

            newDatePickerDialog.ShowDialog();

            if (newDatePickerDialog.DialogResult == DialogResult.OK)
            {
                journalReportGridControl.DataSource = from p in newConnection.tblTransactions
                                                      join c in newConnection.tblClaimants
                                                      on p.ClaimantID equals c.ClaimantID
                                                      where p.TranDate >= newDatePickerDialog.startDate & p.TranDate <= newDatePickerDialog.endDate
                                                      select new
                                                      {
                                                          Date = p.TranDate,
                                                          Claimant = c.FirstNames + " " + c.LastName,
                                                          InvoiceNo = p.InvoiceNo,
                                                          Type = p.TranType,
                                                          Physio = p.PhysioID,
                                                          Narrative = p.Narrative,
                                                          Amount = p.TranAmount
                                                      };
                newDatePickerDialog.Dispose();
            }
            else
            {
                newDatePickerDialog.Dispose();
                this.Close();
            }
        }

        private void journalReportViewForm_Resize(object sender, EventArgs e)
        {
            
        }
    }
}
