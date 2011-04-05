using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraScheduler;
using DevExpress.XtraScheduler.Drawing;
using DevExpress.XtraScheduler.Services;
using DevExpress.XtraScheduler.Commands;
using DevExpress.Utils.Menu;

namespace FP_PMS.Scheduling
{
    public partial class findForm : DevExpress.XtraEditors.XtraForm
    {
        public string mySearchTerm { get; set; }

        public findForm()
        {
            InitializeComponent();
            searchTermTextEdit.Focus();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            mySearchTerm = searchTermTextEdit.Text.Trim();
            this.DialogResult = DialogResult.OK;
        }

        private void findForm_Load(object sender, EventArgs e)
        {
            searchTermTextEdit.Focus();
        }

        private void quitBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void findForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                this.okBtn_Click(this, new EventArgs());
            }

            if (e.KeyCode == Keys.Escape)
            {
                this.quitBtn_Click(this, new EventArgs());
            }
        }

        private void findForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}