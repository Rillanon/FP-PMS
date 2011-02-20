namespace FP_PMS.Admin
{
    partial class userViewForm
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
            this.userLookUp = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.userLookUpView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.userIDCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lastNameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.lastNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.firstNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.accessLevelComboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.passwordTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.userIDTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.newUserBtn = new DevExpress.XtraEditors.SimpleButton();
            this.deleteUserBtn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.userLookUp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userLookUpView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lastNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessLevelComboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userIDTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // userLookUp
            // 
            this.userLookUp.Location = new System.Drawing.Point(86, 21);
            this.userLookUp.Name = "userLookUp";
            this.userLookUp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.userLookUp.Properties.NullText = "";
            this.userLookUp.Properties.View = this.userLookUpView;
            this.userLookUp.Size = new System.Drawing.Size(266, 20);
            this.userLookUp.TabIndex = 6;
            this.userLookUp.EditValueChanged += new System.EventHandler(this.userLookUp_EditValueChanged);
            // 
            // userLookUpView
            // 
            this.userLookUpView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.userIDCol,
            this.gridColumn2,
            this.lastNameCol});
            this.userLookUpView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.userLookUpView.Name = "userLookUpView";
            this.userLookUpView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.userLookUpView.OptionsView.ShowGroupPanel = false;
            // 
            // userIDCol
            // 
            this.userIDCol.Caption = "User ID";
            this.userIDCol.FieldName = "UserID";
            this.userIDCol.Name = "userIDCol";
            this.userIDCol.Visible = true;
            this.userIDCol.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "First Name";
            this.gridColumn2.FieldName = "FirstNames";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // lastNameCol
            // 
            this.lastNameCol.Caption = "Last Name";
            this.lastNameCol.FieldName = "LastName";
            this.lastNameCol.Name = "lastNameCol";
            this.lastNameCol.Visible = true;
            this.lastNameCol.VisibleIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 24);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(68, 13);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "Select an user";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.groupControl2);
            this.groupControl1.Controls.Add(this.accessLevelComboBoxEdit);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.passwordTextEdit);
            this.groupControl1.Controls.Add(this.userIDTextEdit);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Location = new System.Drawing.Point(12, 47);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(338, 297);
            this.groupControl1.TabIndex = 8;
            this.groupControl1.Text = "User";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.lastNameTextEdit);
            this.groupControl2.Controls.Add(this.firstNameTextEdit);
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Controls.Add(this.labelControl6);
            this.groupControl2.Location = new System.Drawing.Point(19, 178);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(302, 100);
            this.groupControl2.TabIndex = 15;
            this.groupControl2.Text = "User Details";
            // 
            // lastNameTextEdit
            // 
            this.lastNameTextEdit.Location = new System.Drawing.Point(100, 67);
            this.lastNameTextEdit.Name = "lastNameTextEdit";
            this.lastNameTextEdit.Size = new System.Drawing.Size(175, 20);
            this.lastNameTextEdit.TabIndex = 14;
            // 
            // firstNameTextEdit
            // 
            this.firstNameTextEdit.Location = new System.Drawing.Point(100, 31);
            this.firstNameTextEdit.Name = "firstNameTextEdit";
            this.firstNameTextEdit.Size = new System.Drawing.Size(175, 20);
            this.firstNameTextEdit.TabIndex = 13;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(33, 70);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(50, 13);
            this.labelControl5.TabIndex = 12;
            this.labelControl5.Text = "Last Name";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(34, 32);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(51, 13);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "First Name";
            // 
            // accessLevelComboBoxEdit
            // 
            this.accessLevelComboBoxEdit.Location = new System.Drawing.Point(119, 134);
            this.accessLevelComboBoxEdit.Name = "accessLevelComboBoxEdit";
            this.accessLevelComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.accessLevelComboBoxEdit.Properties.Items.AddRange(new object[] {
            "General User",
            "Adminstrator"});
            this.accessLevelComboBoxEdit.Size = new System.Drawing.Size(100, 20);
            this.accessLevelComboBoxEdit.TabIndex = 14;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(31, 135);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(61, 13);
            this.labelControl4.TabIndex = 13;
            this.labelControl4.Text = "Access Level";
            // 
            // passwordTextEdit
            // 
            this.passwordTextEdit.Location = new System.Drawing.Point(119, 94);
            this.passwordTextEdit.Name = "passwordTextEdit";
            this.passwordTextEdit.Properties.PasswordChar = '*';
            this.passwordTextEdit.Size = new System.Drawing.Size(202, 20);
            this.passwordTextEdit.TabIndex = 12;
            // 
            // userIDTextEdit
            // 
            this.userIDTextEdit.Location = new System.Drawing.Point(119, 58);
            this.userIDTextEdit.Name = "userIDTextEdit";
            this.userIDTextEdit.Size = new System.Drawing.Size(202, 20);
            this.userIDTextEdit.TabIndex = 11;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(46, 95);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(46, 13);
            this.labelControl3.TabIndex = 10;
            this.labelControl3.Text = "Password";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(53, 59);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(39, 13);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "Login ID";
            // 
            // newUserBtn
            // 
            this.newUserBtn.Location = new System.Drawing.Point(12, 350);
            this.newUserBtn.Name = "newUserBtn";
            this.newUserBtn.Size = new System.Drawing.Size(75, 23);
            this.newUserBtn.TabIndex = 9;
            this.newUserBtn.Text = "New User";
            this.newUserBtn.Click += new System.EventHandler(this.newUserBtn_Click);
            // 
            // deleteUserBtn
            // 
            this.deleteUserBtn.Location = new System.Drawing.Point(93, 350);
            this.deleteUserBtn.Name = "deleteUserBtn";
            this.deleteUserBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteUserBtn.TabIndex = 10;
            this.deleteUserBtn.Text = "Delete User";
            this.deleteUserBtn.Click += new System.EventHandler(this.deleteUserBtn_Click);
            // 
            // userViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(362, 378);
            this.Controls.Add(this.deleteUserBtn);
            this.Controls.Add(this.userLookUp);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.newUserBtn);
            this.Controls.Add(this.groupControl1);
            this.Name = "userViewForm";
            this.Text = "Users";
            this.Load += new System.EventHandler(this.userViewForm_Load);
            this.Controls.SetChildIndex(this.groupControl1, 0);
            this.Controls.SetChildIndex(this.newUserBtn, 0);
            this.Controls.SetChildIndex(this.labelControl1, 0);
            this.Controls.SetChildIndex(this.userLookUp, 0);
            this.Controls.SetChildIndex(this.okBtn, 0);
            this.Controls.SetChildIndex(this.quitBtn, 0);
            this.Controls.SetChildIndex(this.deleteUserBtn, 0);
            ((System.ComponentModel.ISupportInitialize)(this.userLookUp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userLookUpView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lastNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessLevelComboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userIDTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SearchLookUpEdit userLookUp;
        private DevExpress.XtraGrid.Views.Grid.GridView userLookUpView;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit passwordTextEdit;
        private DevExpress.XtraEditors.TextEdit userIDTextEdit;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.ComboBoxEdit accessLevelComboBoxEdit;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit lastNameTextEdit;
        private DevExpress.XtraEditors.TextEdit firstNameTextEdit;
        private DevExpress.XtraGrid.Columns.GridColumn userIDCol;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn lastNameCol;
        private DevExpress.XtraEditors.SimpleButton newUserBtn;
        private DevExpress.XtraEditors.SimpleButton deleteUserBtn;
    }
}
