using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FP_PMS.Report
{
    public partial class dateIntervalDialog : FP_PMS.Templates.level2TemplateForm
    {
        public DateTime startDate {get; set;}
        public DateTime endDate { get; set;}
        public dateIntervalDialog()
        {
            InitializeComponent();
            endDatePicker.DateTime = System.DateTime.Today;
        }

        public override void okBtn_Click(object sender, EventArgs e)
        {
            base.okBtn_Click(sender, e);
            int result = DateTime.Compare(startDate, endDate);

            if (result > 0)
            {
                MessageBox.Show("End date can not be earlier than start date.");
                this.DialogResult = DialogResult.Retry;
            }
            else
            {
                startDate = startDatePicker.DateTime;
                endDate = endDatePicker.DateTime;
                this.DialogResult = DialogResult.OK;
            }
        }

        private void startDatePicker_EditValueChanged(object sender, EventArgs e)
        {
            //if (startDatePicker.EditValue != null)
            //startDate = (DateTime)startDatePicker.EditValue;
        }

        private void endDatePicker_EditValueChanged(object sender, EventArgs e)
        {
            //if (endDatePicker.EditValue != null)
            //endDate = (DateTime)endDatePicker.EditValue;
        }
    }
}
