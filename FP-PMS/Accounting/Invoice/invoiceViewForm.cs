using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FP_PMS.Accounting.Invoice
{
    public partial class invoiceViewForm : FP_PMS.Templates.level1TemplateForm
    {
        public invoiceViewForm()
        {
            InitializeComponent();
        }


       override public void  okBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
            
       override public void applyBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Retry;
        }

       private void summaryDisplayCustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
       {
           e.DisplayText = "$" + e.DisplayText;
       }

       override public void quitBtn_Click(object sender, EventArgs e)
       {
           this.DialogResult = DialogResult.Cancel;
           this.Close();
       }

       private void addLineBtn_Click(object sender, EventArgs e)
       {
           
       }

       private void invoiceViewForm_Load(object sender, EventArgs e)
       {
           
       }



    }
}
