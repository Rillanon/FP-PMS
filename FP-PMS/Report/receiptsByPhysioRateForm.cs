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
    public partial class receiptsByPhysioRateForm : FP_PMS.Templates.level2TemplateForm
    {
        public receiptsByPhysioRateForm()
        {
            InitializeComponent();
        }

        private void receiptsByPhysioRateForm_Load(object sender, EventArgs e)
        {
            var newDatePickerDialog = new dateIntervalDialog();
            var newConnection = new dbContextDataContext();

            newDatePickerDialog.ShowDialog();

            if (newDatePickerDialog.DialogResult == DialogResult.OK)
            {
                receiptsPhysioPivotGrid.DataSource = newConnection.RatesAndItemsSummaryReportFunction(newDatePickerDialog.startDate, newDatePickerDialog.endDate);
                newDatePickerDialog.Dispose();
            }
            else
            {
                newDatePickerDialog.Dispose();
                this.Close();
            }
        }
    }
}
