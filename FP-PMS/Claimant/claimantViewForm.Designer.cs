namespace FP_PMS.Claimant
{
    partial class claimantViewForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.displayGridControl = new DevExpress.XtraGrid.GridControl();
            this.displayGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.goBtn = new DevExpress.XtraEditors.SimpleButton();
            this.searchFieldTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.applyBtn = new DevExpress.XtraEditors.SimpleButton();
            this.searchResultProgressBar = new System.Windows.Forms.ProgressBar();
            this.newPatientBtn = new DevExpress.XtraEditors.SimpleButton();
            this.cancelBtn = new DevExpress.XtraEditors.SimpleButton();
            this.okBtn = new DevExpress.XtraEditors.SimpleButton();
            this.claimantDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.commentTextBox = new System.Windows.Forms.TextBox();
            this.commentsLabel = new DevExpress.XtraEditors.LabelControl();
            this.monthlyCheckBox = new System.Windows.Forms.CheckBox();
            this.companyCheckBox = new System.Windows.Forms.CheckBox();
            this.rateComboBox = new System.Windows.Forms.ComboBox();
            this.faxTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.termsTextBox = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl22 = new DevExpress.XtraEditors.LabelControl();
            this.findPostCodeBtn = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl23 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.emailTextBox = new DevExpress.XtraEditors.TextEdit();
            this.labelControl24 = new DevExpress.XtraEditors.LabelControl();
            this.titleComboBox = new System.Windows.Forms.ComboBox();
            this.postCodeTextBox = new DevExpress.XtraEditors.TextEdit();
            this.stateTextBox = new DevExpress.XtraEditors.TextEdit();
            this.suburbComboBox = new System.Windows.Forms.ComboBox();
            this.addressTextBox = new DevExpress.XtraEditors.TextEdit();
            this.labelControl20 = new DevExpress.XtraEditors.LabelControl();
            this.workPhoneTextBox = new DevExpress.XtraEditors.TextEdit();
            this.labelControl26 = new DevExpress.XtraEditors.LabelControl();
            this.mobileTextBox = new DevExpress.XtraEditors.TextEdit();
            this.labelControl27 = new DevExpress.XtraEditors.LabelControl();
            this.homePhoneTextBox = new DevExpress.XtraEditors.TextEdit();
            this.labelControl28 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl30 = new DevExpress.XtraEditors.LabelControl();
            this.givenNameTextBox = new DevExpress.XtraEditors.TextEdit();
            this.labelControl31 = new DevExpress.XtraEditors.LabelControl();
            this.surnameTextBox = new DevExpress.XtraEditors.TextEdit();
            this.labelControl32 = new DevExpress.XtraEditors.LabelControl();
            this.searchTimer = new System.Windows.Forms.Timer(this.components);
            this.postCodeTimer = new System.Windows.Forms.Timer(this.components);
            this.postCodeBgWorker = new System.ComponentModel.BackgroundWorker();
            this.loadBarTimer = new System.Windows.Forms.Timer(this.components);
            this.claimantBgWorker = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayGridView)).BeginInit();
            this.claimantDetailsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.faxTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.termsTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postCodeTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workPhoneTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobileTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homePhoneTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.givenNameTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.surnameTextBox.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.displayGridControl);
            this.groupBox1.Controls.Add(this.goBtn);
            this.groupBox1.Controls.Add(this.searchFieldTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(798, 177);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select a Claimant";
            // 
            // displayGridControl
            // 
            this.displayGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.displayGridControl.Location = new System.Drawing.Point(9, 31);
            this.displayGridControl.MainView = this.displayGridView;
            this.displayGridControl.Margin = new System.Windows.Forms.Padding(2);
            this.displayGridControl.Name = "displayGridControl";
            this.displayGridControl.Size = new System.Drawing.Size(784, 142);
            this.displayGridControl.TabIndex = 1;
            this.displayGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.displayGridView});
            this.displayGridControl.Click += new System.EventHandler(this.DisplayGridControlClick);
            // 
            // displayGridView
            // 
            this.displayGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.displayGridView.GridControl = this.displayGridControl;
            this.displayGridView.Name = "displayGridView";
            this.displayGridView.OptionsBehavior.Editable = false;
            this.displayGridView.OptionsBehavior.FocusLeaveOnTab = true;
            this.displayGridView.OptionsBehavior.ReadOnly = true;
            this.displayGridView.OptionsNavigation.UseTabKey = false;
            this.displayGridView.OptionsView.ShowGroupPanel = false;
            this.displayGridView.ViewCaption = "Results:";
            this.displayGridView.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.DisplayGridViewRowCellClick);
            this.displayGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DisplayGridViewKeyDown);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ID";
            this.gridColumn1.FieldName = "ClaimantID";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "First Names";
            this.gridColumn2.FieldName = "FirstNames";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Last Name";
            this.gridColumn3.FieldName = "LastName";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // goBtn
            // 
            this.goBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 6F);
            this.goBtn.Appearance.Options.UseFont = true;
            this.goBtn.Location = new System.Drawing.Point(773, 10);
            this.goBtn.Margin = new System.Windows.Forms.Padding(2);
            this.goBtn.Name = "goBtn";
            this.goBtn.Size = new System.Drawing.Size(20, 19);
            this.goBtn.TabIndex = 1;
            this.goBtn.TabStop = false;
            this.goBtn.Text = "go";
            this.goBtn.Click += new System.EventHandler(this.GoBtnClick);
            // 
            // searchFieldTextBox
            // 
            this.searchFieldTextBox.Location = new System.Drawing.Point(230, 10);
            this.searchFieldTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.searchFieldTextBox.Name = "searchFieldTextBox";
            this.searchFieldTextBox.Size = new System.Drawing.Size(540, 20);
            this.searchFieldTextBox.TabIndex = 0;
            this.searchFieldTextBox.TextChanged += new System.EventHandler(this.SearchFieldTextBoxTextChanged);
            this.searchFieldTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchFieldTextBoxKeyDown);
            this.searchFieldTextBox.Leave += new System.EventHandler(this.SearchFieldTextBoxLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Search";
            // 
            // applyBtn
            // 
            this.applyBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 6F);
            this.applyBtn.Appearance.Options.UseFont = true;
            this.applyBtn.Location = new System.Drawing.Point(664, 402);
            this.applyBtn.Margin = new System.Windows.Forms.Padding(2);
            this.applyBtn.Name = "applyBtn";
            this.applyBtn.Size = new System.Drawing.Size(69, 19);
            this.applyBtn.TabIndex = 75;
            this.applyBtn.Text = "Apply(F12)";
            // 
            // searchResultProgressBar
            // 
            this.searchResultProgressBar.Location = new System.Drawing.Point(87, 402);
            this.searchResultProgressBar.Margin = new System.Windows.Forms.Padding(2);
            this.searchResultProgressBar.Name = "searchResultProgressBar";
            this.searchResultProgressBar.Size = new System.Drawing.Size(173, 19);
            this.searchResultProgressBar.TabIndex = 74;
            // 
            // newPatientBtn
            // 
            this.newPatientBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 6F);
            this.newPatientBtn.Appearance.Options.UseFont = true;
            this.newPatientBtn.Location = new System.Drawing.Point(9, 402);
            this.newPatientBtn.Margin = new System.Windows.Forms.Padding(2);
            this.newPatientBtn.Name = "newPatientBtn";
            this.newPatientBtn.Size = new System.Drawing.Size(70, 19);
            this.newPatientBtn.TabIndex = 73;
            this.newPatientBtn.TabStop = false;
            this.newPatientBtn.Text = "NEW(CTRL+N)";
            this.newPatientBtn.Click += new System.EventHandler(this.NewPatientBtnClick);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 6F);
            this.cancelBtn.Appearance.Options.UseFont = true;
            this.cancelBtn.Location = new System.Drawing.Point(738, 402);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(2);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(69, 19);
            this.cancelBtn.TabIndex = 72;
            this.cancelBtn.TabStop = false;
            this.cancelBtn.Text = "Cancel(ESC)";
            this.cancelBtn.Click += new System.EventHandler(this.CancelBtnClick);
            // 
            // okBtn
            // 
            this.okBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 6F);
            this.okBtn.Appearance.Options.UseFont = true;
            this.okBtn.Location = new System.Drawing.Point(591, 402);
            this.okBtn.Margin = new System.Windows.Forms.Padding(2);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(69, 19);
            this.okBtn.TabIndex = 71;
            this.okBtn.Text = "OK(F2)";
            this.okBtn.Click += new System.EventHandler(this.OkBtnClick);
            // 
            // claimantDetailsGroupBox
            // 
            this.claimantDetailsGroupBox.Controls.Add(this.commentTextBox);
            this.claimantDetailsGroupBox.Controls.Add(this.commentsLabel);
            this.claimantDetailsGroupBox.Controls.Add(this.monthlyCheckBox);
            this.claimantDetailsGroupBox.Controls.Add(this.companyCheckBox);
            this.claimantDetailsGroupBox.Controls.Add(this.rateComboBox);
            this.claimantDetailsGroupBox.Controls.Add(this.faxTextEdit);
            this.claimantDetailsGroupBox.Controls.Add(this.labelControl2);
            this.claimantDetailsGroupBox.Controls.Add(this.termsTextBox);
            this.claimantDetailsGroupBox.Controls.Add(this.labelControl1);
            this.claimantDetailsGroupBox.Controls.Add(this.labelControl22);
            this.claimantDetailsGroupBox.Controls.Add(this.findPostCodeBtn);
            this.claimantDetailsGroupBox.Controls.Add(this.labelControl23);
            this.claimantDetailsGroupBox.Controls.Add(this.labelControl16);
            this.claimantDetailsGroupBox.Controls.Add(this.emailTextBox);
            this.claimantDetailsGroupBox.Controls.Add(this.labelControl24);
            this.claimantDetailsGroupBox.Controls.Add(this.titleComboBox);
            this.claimantDetailsGroupBox.Controls.Add(this.postCodeTextBox);
            this.claimantDetailsGroupBox.Controls.Add(this.stateTextBox);
            this.claimantDetailsGroupBox.Controls.Add(this.suburbComboBox);
            this.claimantDetailsGroupBox.Controls.Add(this.addressTextBox);
            this.claimantDetailsGroupBox.Controls.Add(this.labelControl20);
            this.claimantDetailsGroupBox.Controls.Add(this.workPhoneTextBox);
            this.claimantDetailsGroupBox.Controls.Add(this.labelControl26);
            this.claimantDetailsGroupBox.Controls.Add(this.mobileTextBox);
            this.claimantDetailsGroupBox.Controls.Add(this.labelControl27);
            this.claimantDetailsGroupBox.Controls.Add(this.homePhoneTextBox);
            this.claimantDetailsGroupBox.Controls.Add(this.labelControl28);
            this.claimantDetailsGroupBox.Controls.Add(this.labelControl30);
            this.claimantDetailsGroupBox.Controls.Add(this.givenNameTextBox);
            this.claimantDetailsGroupBox.Controls.Add(this.labelControl31);
            this.claimantDetailsGroupBox.Controls.Add(this.surnameTextBox);
            this.claimantDetailsGroupBox.Controls.Add(this.labelControl32);
            this.claimantDetailsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.claimantDetailsGroupBox.Location = new System.Drawing.Point(9, 192);
            this.claimantDetailsGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.claimantDetailsGroupBox.Name = "claimantDetailsGroupBox";
            this.claimantDetailsGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.claimantDetailsGroupBox.Size = new System.Drawing.Size(798, 206);
            this.claimantDetailsGroupBox.TabIndex = 76;
            this.claimantDetailsGroupBox.TabStop = false;
            this.claimantDetailsGroupBox.Text = "Enter a new Claimant";
            // 
            // commentTextBox
            // 
            this.commentTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commentTextBox.Location = new System.Drawing.Point(521, 86);
            this.commentTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.commentTextBox.Multiline = true;
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.Size = new System.Drawing.Size(270, 112);
            this.commentTextBox.TabIndex = 73;
            this.commentTextBox.TextChanged += new System.EventHandler(this.CommentTextBoxTextChanged);
            // 
            // commentsLabel
            // 
            this.commentsLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commentsLabel.Location = new System.Drawing.Point(524, 64);
            this.commentsLabel.Margin = new System.Windows.Forms.Padding(2);
            this.commentsLabel.Name = "commentsLabel";
            this.commentsLabel.Size = new System.Drawing.Size(75, 17);
            this.commentsLabel.TabIndex = 72;
            this.commentsLabel.Text = "Comments";
            // 
            // monthlyCheckBox
            // 
            this.monthlyCheckBox.AutoSize = true;
            this.monthlyCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthlyCheckBox.Location = new System.Drawing.Point(524, 35);
            this.monthlyCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.monthlyCheckBox.Name = "monthlyCheckBox";
            this.monthlyCheckBox.Size = new System.Drawing.Size(115, 19);
            this.monthlyCheckBox.TabIndex = 71;
            this.monthlyCheckBox.Text = "Monthly Account";
            this.monthlyCheckBox.UseVisualStyleBackColor = true;
            this.monthlyCheckBox.CheckedChanged += new System.EventHandler(this.MonthlyCheckBoxCheckedChanged);
            // 
            // companyCheckBox
            // 
            this.companyCheckBox.AutoSize = true;
            this.companyCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyCheckBox.Location = new System.Drawing.Point(398, 35);
            this.companyCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.companyCheckBox.Name = "companyCheckBox";
            this.companyCheckBox.Size = new System.Drawing.Size(78, 19);
            this.companyCheckBox.TabIndex = 70;
            this.companyCheckBox.Text = "Company";
            this.companyCheckBox.UseVisualStyleBackColor = true;
            this.companyCheckBox.CheckedChanged += new System.EventHandler(this.CompanyCheckBoxCheckedChanged);
            // 
            // rateComboBox
            // 
            this.rateComboBox.FormattingEnabled = true;
            this.rateComboBox.Location = new System.Drawing.Point(78, 36);
            this.rateComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.rateComboBox.Name = "rateComboBox";
            this.rateComboBox.Size = new System.Drawing.Size(76, 24);
            this.rateComboBox.TabIndex = 69;
            this.rateComboBox.TextChanged += new System.EventHandler(this.RateComboBoxTextChanged);
            // 
            // faxTextEdit
            // 
            this.faxTextEdit.Location = new System.Drawing.Point(78, 180);
            this.faxTextEdit.Margin = new System.Windows.Forms.Padding(2);
            this.faxTextEdit.Name = "faxTextEdit";
            this.faxTextEdit.Properties.Mask.EditMask = "(0[2|3|4|7|8]-)?[1-9]\\d\\d\\d\\d\\d\\d\\d";
            this.faxTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.faxTextEdit.Properties.Mask.PlaceHolder = '*';
            this.faxTextEdit.Size = new System.Drawing.Size(75, 20);
            this.faxTextEdit.TabIndex = 9;
            this.faxTextEdit.EditValueChanged += new System.EventHandler(this.FaxTextEditEditValueChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(656, 39);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(43, 17);
            this.labelControl2.TabIndex = 68;
            this.labelControl2.Text = "Terms";
            // 
            // termsTextBox
            // 
            this.termsTextBox.Location = new System.Drawing.Point(705, 37);
            this.termsTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.termsTextBox.Name = "termsTextBox";
            this.termsTextBox.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.None;
            this.termsTextBox.Properties.Mask.EditMask = "[0-9]+";
            this.termsTextBox.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.termsTextBox.Properties.Mask.PlaceHolder = '*';
            this.termsTextBox.Size = new System.Drawing.Size(75, 20);
            this.termsTextBox.TabIndex = 15;
            this.termsTextBox.EditValueChanged += new System.EventHandler(this.TermsTextBoxEditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(49, 182);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(18, 13);
            this.labelControl1.TabIndex = 66;
            this.labelControl1.Text = "Fax";
            // 
            // labelControl22
            // 
            this.labelControl22.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.labelControl22.Location = new System.Drawing.Point(40, 41);
            this.labelControl22.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl22.Name = "labelControl22";
            this.labelControl22.Size = new System.Drawing.Size(23, 12);
            this.labelControl22.TabIndex = 64;
            this.labelControl22.Text = "Rate";
            // 
            // findPostCodeBtn
            // 
            this.findPostCodeBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 6F);
            this.findPostCodeBtn.Appearance.Options.UseFont = true;
            this.findPostCodeBtn.Location = new System.Drawing.Point(441, 118);
            this.findPostCodeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.findPostCodeBtn.Name = "findPostCodeBtn";
            this.findPostCodeBtn.Size = new System.Drawing.Size(69, 19);
            this.findPostCodeBtn.TabIndex = 13;
            this.findPostCodeBtn.Text = "FIND ";
            this.findPostCodeBtn.Click += new System.EventHandler(this.FindPostCodeBtnClick);
            // 
            // labelControl23
            // 
            this.labelControl23.Location = new System.Drawing.Point(244, 149);
            this.labelControl23.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl23.Name = "labelControl23";
            this.labelControl23.Size = new System.Drawing.Size(24, 13);
            this.labelControl23.TabIndex = 59;
            this.labelControl23.Text = "Email";
            // 
            // labelControl16
            // 
            this.labelControl16.Location = new System.Drawing.Point(194, 121);
            this.labelControl16.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(85, 13);
            this.labelControl16.TabIndex = 62;
            this.labelControl16.Text = "State / Post Code";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(281, 146);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.None;
            this.emailTextBox.Properties.Mask.EditMask = "04\\d\\d\\d\\d\\d\\d\\d\\d";
            this.emailTextBox.Properties.Mask.PlaceHolder = '*';
            this.emailTextBox.Size = new System.Drawing.Size(154, 20);
            this.emailTextBox.TabIndex = 14;
            this.emailTextBox.EditValueChanged += new System.EventHandler(this.EmailTextBoxEditValueChanged);
            // 
            // labelControl24
            // 
            this.labelControl24.Location = new System.Drawing.Point(238, 96);
            this.labelControl24.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl24.Name = "labelControl24";
            this.labelControl24.Size = new System.Drawing.Size(34, 13);
            this.labelControl24.TabIndex = 60;
            this.labelControl24.Text = "Suburb";
            // 
            // titleComboBox
            // 
            this.titleComboBox.FormattingEnabled = true;
            this.titleComboBox.Items.AddRange(new object[] {
            "Mr",
            "Ms",
            "Miss",
            "Mrs",
            "Doctor"});
            this.titleComboBox.Location = new System.Drawing.Point(281, 35);
            this.titleComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.titleComboBox.Name = "titleComboBox";
            this.titleComboBox.Size = new System.Drawing.Size(76, 24);
            this.titleComboBox.TabIndex = 10;
            this.titleComboBox.TextChanged += new System.EventHandler(this.TitleComboBoxTextChanged);
            // 
            // postCodeTextBox
            // 
            this.postCodeTextBox.Location = new System.Drawing.Point(361, 119);
            this.postCodeTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.postCodeTextBox.Name = "postCodeTextBox";
            this.postCodeTextBox.Size = new System.Drawing.Size(75, 20);
            this.postCodeTextBox.TabIndex = 61;
            this.postCodeTextBox.TabStop = false;
            this.postCodeTextBox.EditValueChanged += new System.EventHandler(this.PostCodeTextBoxEditValueChanged);
            // 
            // stateTextBox
            // 
            this.stateTextBox.EditValue = "";
            this.stateTextBox.Location = new System.Drawing.Point(281, 119);
            this.stateTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.Size = new System.Drawing.Size(75, 20);
            this.stateTextBox.TabIndex = 60;
            this.stateTextBox.TabStop = false;
            this.stateTextBox.EditValueChanged += new System.EventHandler(this.StateTextBoxEditValueChanged);
            // 
            // suburbComboBox
            // 
            this.suburbComboBox.DisplayMember = "Location";
            this.suburbComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.suburbComboBox.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suburbComboBox.FormattingEnabled = true;
            this.suburbComboBox.Location = new System.Drawing.Point(281, 90);
            this.suburbComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.suburbComboBox.Name = "suburbComboBox";
            this.suburbComboBox.Size = new System.Drawing.Size(229, 20);
            this.suburbComboBox.TabIndex = 12;
            this.suburbComboBox.ValueMember = "PostCodeID";
            this.suburbComboBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.SuburbComboBoxDrawItem);
            this.suburbComboBox.TextUpdate += new System.EventHandler(this.SuburbComboBoxTextUpdate);
            this.suburbComboBox.TextChanged += new System.EventHandler(this.SuburbComboBoxTextChanged);
            this.suburbComboBox.Leave += new System.EventHandler(this.SuburbComboBoxLeave);
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(281, 66);
            this.addressTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(228, 20);
            this.addressTextBox.TabIndex = 11;
            this.addressTextBox.EditValueChanged += new System.EventHandler(this.AddressTextBoxEditValueChanged);
            // 
            // labelControl20
            // 
            this.labelControl20.Location = new System.Drawing.Point(233, 68);
            this.labelControl20.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl20.Name = "labelControl20";
            this.labelControl20.Size = new System.Drawing.Size(39, 13);
            this.labelControl20.TabIndex = 48;
            this.labelControl20.Text = "Address";
            // 
            // workPhoneTextBox
            // 
            this.workPhoneTextBox.Location = new System.Drawing.Point(78, 134);
            this.workPhoneTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.workPhoneTextBox.Name = "workPhoneTextBox";
            this.workPhoneTextBox.Properties.Mask.EditMask = "(0[2|3|4|7|8]-)?[1-9]\\d\\d\\d\\d\\d\\d\\d";
            this.workPhoneTextBox.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.workPhoneTextBox.Properties.Mask.PlaceHolder = '*';
            this.workPhoneTextBox.Size = new System.Drawing.Size(75, 20);
            this.workPhoneTextBox.TabIndex = 7;
            this.workPhoneTextBox.EditValueChanged += new System.EventHandler(this.WorkPhoneTextBoxEditValueChanged);
            // 
            // labelControl26
            // 
            this.labelControl26.Location = new System.Drawing.Point(12, 136);
            this.labelControl26.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl26.Name = "labelControl26";
            this.labelControl26.Size = new System.Drawing.Size(58, 13);
            this.labelControl26.TabIndex = 46;
            this.labelControl26.Text = "Work Phone";
            // 
            // mobileTextBox
            // 
            this.mobileTextBox.Location = new System.Drawing.Point(78, 157);
            this.mobileTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.mobileTextBox.Name = "mobileTextBox";
            this.mobileTextBox.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.None;
            this.mobileTextBox.Properties.Mask.EditMask = "04\\d\\d\\d\\d\\d\\d\\d\\d";
            this.mobileTextBox.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.mobileTextBox.Properties.Mask.PlaceHolder = '*';
            this.mobileTextBox.Size = new System.Drawing.Size(75, 20);
            this.mobileTextBox.TabIndex = 8;
            this.mobileTextBox.EditValueChanged += new System.EventHandler(this.MobileTextBoxEditValueChanged);
            // 
            // labelControl27
            // 
            this.labelControl27.Location = new System.Drawing.Point(36, 159);
            this.labelControl27.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl27.Name = "labelControl27";
            this.labelControl27.Size = new System.Drawing.Size(30, 13);
            this.labelControl27.TabIndex = 44;
            this.labelControl27.Text = "Mobile";
            // 
            // homePhoneTextBox
            // 
            this.homePhoneTextBox.Location = new System.Drawing.Point(78, 111);
            this.homePhoneTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.homePhoneTextBox.Name = "homePhoneTextBox";
            this.homePhoneTextBox.Properties.Mask.EditMask = "(0[2|3|4|7|8]-)?[1-9]\\d\\d\\d\\d\\d\\d\\d";
            this.homePhoneTextBox.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.homePhoneTextBox.Properties.Mask.PlaceHolder = '*';
            this.homePhoneTextBox.Size = new System.Drawing.Size(75, 20);
            this.homePhoneTextBox.TabIndex = 6;
            this.homePhoneTextBox.EditValueChanged += new System.EventHandler(this.HomePhoneTextBoxEditValueChanged);
            // 
            // labelControl28
            // 
            this.labelControl28.Location = new System.Drawing.Point(10, 114);
            this.labelControl28.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl28.Name = "labelControl28";
            this.labelControl28.Size = new System.Drawing.Size(60, 13);
            this.labelControl28.TabIndex = 42;
            this.labelControl28.Text = "Home Phone";
            // 
            // labelControl30
            // 
            this.labelControl30.Location = new System.Drawing.Point(250, 42);
            this.labelControl30.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl30.Name = "labelControl30";
            this.labelControl30.Size = new System.Drawing.Size(20, 13);
            this.labelControl30.TabIndex = 39;
            this.labelControl30.Text = "Title";
            // 
            // givenNameTextBox
            // 
            this.givenNameTextBox.Location = new System.Drawing.Point(78, 89);
            this.givenNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.givenNameTextBox.Name = "givenNameTextBox";
            this.givenNameTextBox.Size = new System.Drawing.Size(147, 20);
            this.givenNameTextBox.TabIndex = 5;
            this.givenNameTextBox.EditValueChanged += new System.EventHandler(this.GivenNameTextBoxEditValueChanged);
            // 
            // labelControl31
            // 
            this.labelControl31.Location = new System.Drawing.Point(8, 91);
            this.labelControl31.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl31.Name = "labelControl31";
            this.labelControl31.Size = new System.Drawing.Size(62, 13);
            this.labelControl31.TabIndex = 37;
            this.labelControl31.Text = "Given Names";
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Location = new System.Drawing.Point(78, 66);
            this.surnameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(147, 20);
            this.surnameTextBox.TabIndex = 4;
            this.surnameTextBox.EditValueChanged += new System.EventHandler(this.SurnameTextBoxEditValueChanged);
            // 
            // labelControl32
            // 
            this.labelControl32.Location = new System.Drawing.Point(25, 68);
            this.labelControl32.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl32.Name = "labelControl32";
            this.labelControl32.Size = new System.Drawing.Size(42, 13);
            this.labelControl32.TabIndex = 35;
            this.labelControl32.Text = "Surname";
            // 
            // searchTimer
            // 
            this.searchTimer.Interval = 1500;
            this.searchTimer.Tick += new System.EventHandler(this.SearchTimerTick);
            // 
            // postCodeTimer
            // 
            this.postCodeTimer.Interval = 1500;
            this.postCodeTimer.Tick += new System.EventHandler(this.PostCodeTimerTick);
            // 
            // postCodeBgWorker
            // 
            this.postCodeBgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.PostCodeBgWorkerDoWork);
            this.postCodeBgWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.PostCodeBgWorkerRunWorkerCompleted);
            // 
            // loadBarTimer
            // 
            this.loadBarTimer.Interval = 300;
            this.loadBarTimer.Tick += new System.EventHandler(this.LoadTimerTick);
            // 
            // claimantBgWorker
            // 
            this.claimantBgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.ClaimantBgWorkerDoWork);
            this.claimantBgWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.ClaimantBgWorkerRunWorkerCompleted);
            // 
            // claimantViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(809, 425);
            this.Controls.Add(this.claimantDetailsGroupBox);
            this.Controls.Add(this.applyBtn);
            this.Controls.Add(this.searchResultProgressBar);
            this.Controls.Add(this.newPatientBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "claimantViewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "claimantViewForm";
            this.Load += new System.EventHandler(this.ClaimantViewFormLoad);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ClaimantViewFormKeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayGridView)).EndInit();
            this.claimantDetailsGroupBox.ResumeLayout(false);
            this.claimantDetailsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.faxTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.termsTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postCodeTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workPhoneTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobileTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homePhoneTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.givenNameTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.surnameTextBox.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraGrid.GridControl displayGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView displayGridView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.SimpleButton goBtn;
        private System.Windows.Forms.TextBox searchFieldTextBox;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton applyBtn;
        private System.Windows.Forms.ProgressBar searchResultProgressBar;
        private DevExpress.XtraEditors.SimpleButton newPatientBtn;
        private DevExpress.XtraEditors.SimpleButton cancelBtn;
        private DevExpress.XtraEditors.SimpleButton okBtn;
        private System.Windows.Forms.GroupBox claimantDetailsGroupBox;
        private DevExpress.XtraEditors.TextEdit faxTextEdit;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit termsTextBox;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl22;
        private DevExpress.XtraEditors.SimpleButton findPostCodeBtn;
        private DevExpress.XtraEditors.LabelControl labelControl23;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraEditors.TextEdit emailTextBox;
        private DevExpress.XtraEditors.LabelControl labelControl24;
        private System.Windows.Forms.ComboBox titleComboBox;
        private DevExpress.XtraEditors.TextEdit postCodeTextBox;
        private DevExpress.XtraEditors.TextEdit stateTextBox;
        private System.Windows.Forms.ComboBox suburbComboBox;
        private DevExpress.XtraEditors.TextEdit addressTextBox;
        private DevExpress.XtraEditors.LabelControl labelControl20;
        private DevExpress.XtraEditors.TextEdit workPhoneTextBox;
        private DevExpress.XtraEditors.LabelControl labelControl26;
        private DevExpress.XtraEditors.TextEdit mobileTextBox;
        private DevExpress.XtraEditors.LabelControl labelControl27;
        private DevExpress.XtraEditors.TextEdit homePhoneTextBox;
        private DevExpress.XtraEditors.LabelControl labelControl28;
        private DevExpress.XtraEditors.LabelControl labelControl30;
        private DevExpress.XtraEditors.TextEdit givenNameTextBox;
        private DevExpress.XtraEditors.LabelControl labelControl31;
        private DevExpress.XtraEditors.TextEdit surnameTextBox;
        private DevExpress.XtraEditors.LabelControl labelControl32;
        private System.Windows.Forms.Timer searchTimer;
        private System.Windows.Forms.Timer postCodeTimer;
        private System.ComponentModel.BackgroundWorker postCodeBgWorker;
        private System.Windows.Forms.Timer loadBarTimer;
        private System.ComponentModel.BackgroundWorker claimantBgWorker;
        private System.Windows.Forms.ComboBox rateComboBox;
        private System.Windows.Forms.CheckBox monthlyCheckBox;
        private System.Windows.Forms.CheckBox companyCheckBox;
        private DevExpress.XtraEditors.LabelControl commentsLabel;
        private System.Windows.Forms.TextBox commentTextBox;
    }
}