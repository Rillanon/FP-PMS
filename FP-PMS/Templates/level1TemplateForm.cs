using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FP_PMS.Templates
{
     public partial class level1TemplateForm : Form
    {
        public level1TemplateForm()
        {
            InitializeComponent();
        }

        private void level1TemplateForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                this.okBtn_Click(this, new EventArgs());
            }
            if (e.KeyCode == Keys.F12)
            {
                this.applyBtn_Click(this, new EventArgs());
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.quitBtn_Click(this,new EventArgs());
            }
        }

        virtual public void okBtn_Click(object sender, EventArgs e)
     {
         this.DialogResult = DialogResult.OK;
     }



        virtual public void applyBtn_Click(object sender, EventArgs e)
        {
            
        }



        virtual public void quitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void level1TemplateForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.Retry)
                e.Cancel = true;
        }


    }
}
