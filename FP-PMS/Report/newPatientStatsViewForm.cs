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
    public partial class newPatientStatsViewForm : FP_PMS.Templates.level2TemplateForm
    {
        public newPatientStatsViewForm()
        {
            InitializeComponent();
        }

        private void newPatientStatsViewForm_Load(object sender, EventArgs e)
        {
            var newDatePickerDialog = new dateIntervalDialog();
            var newConnection = new dbContextDataContext();

            newDatePickerDialog.ShowDialog();

            if (newDatePickerDialog.DialogResult == DialogResult.OK)
            {
                newPatientGridControl.DataSource = from p in newConnection.tblPatientStats
                                                   where p.SessionDate >= newDatePickerDialog.startDate & p.SessionDate <= newDatePickerDialog.endDate
                                                   select p;

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
