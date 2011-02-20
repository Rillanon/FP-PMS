namespace FP_PMS.Auth
{
    partial class authForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.passwordTextBox = new System.Windows.Forms.MaskedTextBox();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.signInBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.authProgressBar = new System.Windows.Forms.ProgressBar();
            this.authTimer = new System.Windows.Forms.Timer(this.components);
            this.authBGW = new System.ComponentModel.BackgroundWorker();
            this.labelTitle = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(137, 79);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(177, 22);
            this.passwordTextBox.TabIndex = 1;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBoxTextChanged);
            // 
            // userTextBox
            // 
            this.userTextBox.Location = new System.Drawing.Point(137, 51);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(177, 22);
            this.userTextBox.TabIndex = 0;
            this.userTextBox.TextChanged += new System.EventHandler(this.userTextBoxTextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // signInBtn
            // 
            this.signInBtn.Location = new System.Drawing.Point(158, 107);
            this.signInBtn.Name = "signInBtn";
            this.signInBtn.Size = new System.Drawing.Size(75, 35);
            this.signInBtn.TabIndex = 3;
            this.signInBtn.Text = "Sign-in";
            this.signInBtn.UseVisualStyleBackColor = true;
            this.signInBtn.Click += new System.EventHandler(this.signInBtnClick);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(239, 107);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 35);
            this.exitBtn.TabIndex = 5;
            this.exitBtn.TabStop = false;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtnClick);
            // 
            // authProgressBar
            // 
            this.authProgressBar.Location = new System.Drawing.Point(25, 119);
            this.authProgressBar.Name = "authProgressBar";
            this.authProgressBar.Size = new System.Drawing.Size(100, 23);
            this.authProgressBar.TabIndex = 7;
            // 
            // labelTitle
            // 
            this.labelTitle.Location = new System.Drawing.Point(137, 12);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(86, 16);
            this.labelTitle.TabIndex = 8;
            this.labelTitle.Text = "Fairfield Physio";
            // 
            // authForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 157);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.authProgressBar);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.signInBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "authForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Portal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.authFormFormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox passwordTextBox;
        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button signInBtn;
        private System.Windows.Forms.Button exitBtn;
        
        private System.Windows.Forms.ProgressBar authProgressBar;
        private System.Windows.Forms.Timer authTimer;
        private System.ComponentModel.BackgroundWorker authBGW;
        private DevExpress.XtraEditors.LabelControl labelTitle;
        
    }
}