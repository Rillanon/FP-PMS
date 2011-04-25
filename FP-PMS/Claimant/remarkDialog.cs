using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using FP_PMS.Ex;

namespace FP_PMS.Claimant
{
    public partial class remarkDialog : DevExpress.XtraEditors.XtraForm
    {
        string _myRemark;
        public string myRemark { get { return _myRemark; } set { _myRemark = value; } }

        public remarkDialog()
        {
            InitializeComponent();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            this.myRemark = System.DateTime.Now.ToString() + @" " + staticProperties.userName + @": " + remarkMemoEdit.Text + Environment.NewLine + Environment.NewLine;
            this.DialogResult = DialogResult.OK;
        }


        private void quitBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void remarkDialog_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                this.okBtn_Click(sender, e);
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.quitBtn_Click(sender, e);
            }
        }
    }
}