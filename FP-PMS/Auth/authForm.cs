using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FP_PMS.Auth
{
    public partial class authForm : Form
    {
        private readonly authController _controller; 

        public authForm()
        {
            InitializeComponent();
            _controller = new authController(this);
        }

        private void signInBtnClick(object sender, EventArgs e)
        {
            this.DialogResult = _controller.newAuth();
        }

        private void exitBtnClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void authFormFormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == System.Windows.Forms.DialogResult.Retry)
            {
                e.Cancel = true;
                userTextBox.Focus();
                userTextBox.SelectAll();
            }
        }

        private void userTextBoxTextChanged(object sender, EventArgs e)
        {
            _controller.userId = userTextBox.Text.Trim();
        }

        private void passwordTextBoxTextChanged(object sender, EventArgs e)
        {
            _controller.password = passwordTextBox.Text.Trim();
        }
    }
}
