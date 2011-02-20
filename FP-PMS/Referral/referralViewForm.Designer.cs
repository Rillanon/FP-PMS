namespace FP_PMS.Referral
{
    partial class referralViewForm
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
            this.referralDocBgWorker = new System.ComponentModel.BackgroundWorker();
            this.searchTimer = new System.Windows.Forms.Timer(this.components);
            this.postCodeTimer = new System.Windows.Forms.Timer(this.components);
            this.postCodeBgWorker = new System.ComponentModel.BackgroundWorker();
            this.searchResultProgressBar = new System.Windows.Forms.ProgressBar();
            this.loadBarTimer = new System.Windows.Forms.Timer(this.components);
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cancelBtn = new DevExpress.XtraEditors.SimpleButton();
            this.applyBtn = new DevExpress.XtraEditors.SimpleButton();
            this.newPatientBtn = new DevExpress.XtraEditors.SimpleButton();
            this.okBtn = new DevExpress.XtraEditors.SimpleButton();
            this.doctorDetailsGroupBox = new DevExpress.XtraEditors.GroupControl();
            this.faxTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.givenNameTextBox = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl32 = new DevExpress.XtraEditors.LabelControl();
            this.organizationTextBox = new DevExpress.XtraEditors.TextEdit();
            this.surnameTextBox = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl31 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl22 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl30 = new DevExpress.XtraEditors.LabelControl();
            this.provideTextBox = new DevExpress.XtraEditors.TextEdit();
            this.labelControl28 = new DevExpress.XtraEditors.LabelControl();
            this.findPostCodeBtn = new DevExpress.XtraEditors.SimpleButton();
            this.homePhoneTextBox = new DevExpress.XtraEditors.TextEdit();
            this.labelControl23 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl27 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.mobileTextBox = new DevExpress.XtraEditors.TextEdit();
            this.emailTextBox = new DevExpress.XtraEditors.TextEdit();
            this.labelControl26 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl24 = new DevExpress.XtraEditors.LabelControl();
            this.workPhoneTextBox = new DevExpress.XtraEditors.TextEdit();
            this.titleComboBox = new System.Windows.Forms.ComboBox();
            this.labelControl20 = new DevExpress.XtraEditors.LabelControl();
            this.postCodeTextBox = new DevExpress.XtraEditors.TextEdit();
            this.addressTextBox = new DevExpress.XtraEditors.TextEdit();
            this.stateTextBox = new DevExpress.XtraEditors.TextEdit();
            this.suburbComboBox = new System.Windows.Forms.ComboBox();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.displayGridControl = new DevExpress.XtraGrid.GridControl();
            this.displayGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.goBtn = new DevExpress.XtraEditors.SimpleButton();
            this.searchFieldTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorDetailsGroupBox)).BeginInit();
            this.doctorDetailsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.faxTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.givenNameTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.organizationTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.surnameTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provideTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homePhoneTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobileTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workPhoneTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postCodeTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // referralDocBgWorker
            // 
            this.referralDocBgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.ReferralDocBgWorkerDoWork);
            this.referralDocBgWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.ReferralDocBgWorkerProgressChanged);
            this.referralDocBgWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.ReferralDocBgWorkerRunWorkerCompleted);
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
            // searchResultProgressBar
            // 
            this.searchResultProgressBar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.searchResultProgressBar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.searchResultProgressBar.Location = new System.Drawing.Point(525, 40);
            this.searchResultProgressBar.Margin = new System.Windows.Forms.Padding(2);
            this.searchResultProgressBar.Name = "searchResultProgressBar";
            this.searchResultProgressBar.Size = new System.Drawing.Size(173, 29);
            this.searchResultProgressBar.TabIndex = 69;
            // 
            // loadBarTimer
            // 
            this.loadBarTimer.Interval = 300;
            this.loadBarTimer.Tick += new System.EventHandler(this.LoadTimerTick);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cancelBtn);
            this.groupControl1.Controls.Add(this.searchResultProgressBar);
            this.groupControl1.Controls.Add(this.applyBtn);
            this.groupControl1.Controls.Add(this.newPatientBtn);
            this.groupControl1.Controls.Add(this.okBtn);
            this.groupControl1.Location = new System.Drawing.Point(-4, 565);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(963, 79);
            this.groupControl1.TabIndex = 71;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.Appearance.Options.UseFont = true;
            this.cancelBtn.Location = new System.Drawing.Point(838, 27);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(2);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(115, 42);
            this.cancelBtn.TabIndex = 72;
            this.cancelBtn.TabStop = false;
            this.cancelBtn.Text = "Cancel(ESC)";
            // 
            // applyBtn
            // 
            this.applyBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applyBtn.Appearance.Options.UseFont = true;
            this.applyBtn.Location = new System.Drawing.Point(15, 29);
            this.applyBtn.Margin = new System.Windows.Forms.Padding(2);
            this.applyBtn.Name = "applyBtn";
            this.applyBtn.Size = new System.Drawing.Size(165, 40);
            this.applyBtn.TabIndex = 74;
            this.applyBtn.Text = "Apply(F12)";
            // 
            // newPatientBtn
            // 
            this.newPatientBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPatientBtn.Appearance.Options.UseFont = true;
            this.newPatientBtn.Location = new System.Drawing.Point(195, 29);
            this.newPatientBtn.Margin = new System.Windows.Forms.Padding(2);
            this.newPatientBtn.Name = "newPatientBtn";
            this.newPatientBtn.Size = new System.Drawing.Size(143, 42);
            this.newPatientBtn.TabIndex = 73;
            this.newPatientBtn.TabStop = false;
            this.newPatientBtn.Text = "NEW(CTRL+N)";
            // 
            // okBtn
            // 
            this.okBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okBtn.Appearance.Options.UseFont = true;
            this.okBtn.Location = new System.Drawing.Point(714, 27);
            this.okBtn.Margin = new System.Windows.Forms.Padding(2);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(120, 42);
            this.okBtn.TabIndex = 71;
            this.okBtn.Text = "OK(F2)";
            // 
            // doctorDetailsGroupBox
            // 
            this.doctorDetailsGroupBox.Controls.Add(this.faxTextEdit);
            this.doctorDetailsGroupBox.Controls.Add(this.givenNameTextBox);
            this.doctorDetailsGroupBox.Controls.Add(this.labelControl2);
            this.doctorDetailsGroupBox.Controls.Add(this.labelControl32);
            this.doctorDetailsGroupBox.Controls.Add(this.organizationTextBox);
            this.doctorDetailsGroupBox.Controls.Add(this.surnameTextBox);
            this.doctorDetailsGroupBox.Controls.Add(this.labelControl1);
            this.doctorDetailsGroupBox.Controls.Add(this.labelControl31);
            this.doctorDetailsGroupBox.Controls.Add(this.labelControl22);
            this.doctorDetailsGroupBox.Controls.Add(this.labelControl30);
            this.doctorDetailsGroupBox.Controls.Add(this.provideTextBox);
            this.doctorDetailsGroupBox.Controls.Add(this.labelControl28);
            this.doctorDetailsGroupBox.Controls.Add(this.findPostCodeBtn);
            this.doctorDetailsGroupBox.Controls.Add(this.homePhoneTextBox);
            this.doctorDetailsGroupBox.Controls.Add(this.labelControl23);
            this.doctorDetailsGroupBox.Controls.Add(this.labelControl27);
            this.doctorDetailsGroupBox.Controls.Add(this.labelControl16);
            this.doctorDetailsGroupBox.Controls.Add(this.mobileTextBox);
            this.doctorDetailsGroupBox.Controls.Add(this.emailTextBox);
            this.doctorDetailsGroupBox.Controls.Add(this.labelControl26);
            this.doctorDetailsGroupBox.Controls.Add(this.labelControl24);
            this.doctorDetailsGroupBox.Controls.Add(this.workPhoneTextBox);
            this.doctorDetailsGroupBox.Controls.Add(this.titleComboBox);
            this.doctorDetailsGroupBox.Controls.Add(this.labelControl20);
            this.doctorDetailsGroupBox.Controls.Add(this.postCodeTextBox);
            this.doctorDetailsGroupBox.Controls.Add(this.addressTextBox);
            this.doctorDetailsGroupBox.Controls.Add(this.stateTextBox);
            this.doctorDetailsGroupBox.Controls.Add(this.suburbComboBox);
            this.doctorDetailsGroupBox.Location = new System.Drawing.Point(-4, 208);
            this.doctorDetailsGroupBox.Name = "doctorDetailsGroupBox";
            this.doctorDetailsGroupBox.Size = new System.Drawing.Size(963, 351);
            this.doctorDetailsGroupBox.TabIndex = 72;
            this.doctorDetailsGroupBox.Text = "New Patient";
            // 
            // faxTextEdit
            // 
            this.faxTextEdit.Location = new System.Drawing.Point(175, 306);
            this.faxTextEdit.Margin = new System.Windows.Forms.Padding(2);
            this.faxTextEdit.Name = "faxTextEdit";
            this.faxTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.faxTextEdit.Properties.Appearance.Options.UseFont = true;
            this.faxTextEdit.Properties.Mask.EditMask = "(0[2|3|4|7|8]-)?[1-9]\\d\\d\\d\\d\\d\\d\\d";
            this.faxTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.faxTextEdit.Properties.Mask.PlaceHolder = '*';
            this.faxTextEdit.Size = new System.Drawing.Size(264, 26);
            this.faxTextEdit.TabIndex = 79;
            // 
            // givenNameTextBox
            // 
            this.givenNameTextBox.Location = new System.Drawing.Point(175, 128);
            this.givenNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.givenNameTextBox.Name = "givenNameTextBox";
            this.givenNameTextBox.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.givenNameTextBox.Properties.Appearance.Options.UseFont = true;
            this.givenNameTextBox.Size = new System.Drawing.Size(264, 26);
            this.givenNameTextBox.TabIndex = 75;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(481, 290);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(90, 20);
            this.labelControl2.TabIndex = 100;
            this.labelControl2.Text = "Organization";
            // 
            // labelControl32
            // 
            this.labelControl32.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl32.Location = new System.Drawing.Point(85, 86);
            this.labelControl32.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl32.Name = "labelControl32";
            this.labelControl32.Size = new System.Drawing.Size(65, 20);
            this.labelControl32.TabIndex = 86;
            this.labelControl32.Text = "Surname";
            // 
            // organizationTextBox
            // 
            this.organizationTextBox.Location = new System.Drawing.Point(605, 287);
            this.organizationTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.organizationTextBox.Name = "organizationTextBox";
            this.organizationTextBox.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.organizationTextBox.Properties.Appearance.Options.UseFont = true;
            this.organizationTextBox.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.None;
            this.organizationTextBox.Properties.Mask.EditMask = "04\\d\\d\\d\\d\\d\\d\\d\\d";
            this.organizationTextBox.Properties.Mask.PlaceHolder = '*';
            this.organizationTextBox.Size = new System.Drawing.Size(339, 26);
            this.organizationTextBox.TabIndex = 85;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Location = new System.Drawing.Point(175, 83);
            this.surnameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surnameTextBox.Properties.Appearance.Options.UseFont = true;
            this.surnameTextBox.Size = new System.Drawing.Size(264, 26);
            this.surnameTextBox.TabIndex = 74;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(124, 309);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(26, 20);
            this.labelControl1.TabIndex = 99;
            this.labelControl1.Text = "Fax";
            // 
            // labelControl31
            // 
            this.labelControl31.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl31.Location = new System.Drawing.Point(55, 131);
            this.labelControl31.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl31.Name = "labelControl31";
            this.labelControl31.Size = new System.Drawing.Size(95, 20);
            this.labelControl31.TabIndex = 87;
            this.labelControl31.Text = "Given Names";
            // 
            // labelControl22
            // 
            this.labelControl22.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl22.Location = new System.Drawing.Point(80, 44);
            this.labelControl22.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl22.Name = "labelControl22";
            this.labelControl22.Size = new System.Drawing.Size(70, 20);
            this.labelControl22.TabIndex = 98;
            this.labelControl22.Text = "Provider #";
            // 
            // labelControl30
            // 
            this.labelControl30.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl30.Location = new System.Drawing.Point(557, 44);
            this.labelControl30.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl30.Name = "labelControl30";
            this.labelControl30.Size = new System.Drawing.Size(29, 20);
            this.labelControl30.TabIndex = 88;
            this.labelControl30.Text = "Title";
            // 
            // provideTextBox
            // 
            this.provideTextBox.Location = new System.Drawing.Point(175, 41);
            this.provideTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.provideTextBox.Name = "provideTextBox";
            this.provideTextBox.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.provideTextBox.Properties.Appearance.Options.UseFont = true;
            this.provideTextBox.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.None;
            this.provideTextBox.Properties.Mask.ShowPlaceHolders = false;
            this.provideTextBox.Size = new System.Drawing.Size(264, 26);
            this.provideTextBox.TabIndex = 73;
            // 
            // labelControl28
            // 
            this.labelControl28.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl28.Location = new System.Drawing.Point(57, 175);
            this.labelControl28.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl28.Name = "labelControl28";
            this.labelControl28.Size = new System.Drawing.Size(93, 20);
            this.labelControl28.TabIndex = 89;
            this.labelControl28.Text = "Home Phone";
            // 
            // findPostCodeBtn
            // 
            this.findPostCodeBtn.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findPostCodeBtn.Appearance.Options.UseFont = true;
            this.findPostCodeBtn.Location = new System.Drawing.Point(838, 128);
            this.findPostCodeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.findPostCodeBtn.Name = "findPostCodeBtn";
            this.findPostCodeBtn.Size = new System.Drawing.Size(97, 27);
            this.findPostCodeBtn.TabIndex = 83;
            this.findPostCodeBtn.Text = "FIND ";
            // 
            // homePhoneTextBox
            // 
            this.homePhoneTextBox.Location = new System.Drawing.Point(175, 172);
            this.homePhoneTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.homePhoneTextBox.Name = "homePhoneTextBox";
            this.homePhoneTextBox.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homePhoneTextBox.Properties.Appearance.Options.UseFont = true;
            this.homePhoneTextBox.Properties.Mask.EditMask = "(0[2|3|4|7|8]-)?[1-9]\\d\\d\\d\\d\\d\\d\\d";
            this.homePhoneTextBox.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.homePhoneTextBox.Properties.Mask.PlaceHolder = '*';
            this.homePhoneTextBox.Size = new System.Drawing.Size(264, 26);
            this.homePhoneTextBox.TabIndex = 76;
            // 
            // labelControl23
            // 
            this.labelControl23.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl23.Location = new System.Drawing.Point(530, 248);
            this.labelControl23.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl23.Name = "labelControl23";
            this.labelControl23.Size = new System.Drawing.Size(39, 20);
            this.labelControl23.TabIndex = 93;
            this.labelControl23.Text = "Email";
            // 
            // labelControl27
            // 
            this.labelControl27.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl27.Location = new System.Drawing.Point(104, 267);
            this.labelControl27.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl27.Name = "labelControl27";
            this.labelControl27.Size = new System.Drawing.Size(46, 20);
            this.labelControl27.TabIndex = 90;
            this.labelControl27.Text = "Mobile";
            // 
            // labelControl16
            // 
            this.labelControl16.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl16.Location = new System.Drawing.Point(474, 172);
            this.labelControl16.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(125, 20);
            this.labelControl16.TabIndex = 97;
            this.labelControl16.Text = "State / Post Code";
            // 
            // mobileTextBox
            // 
            this.mobileTextBox.Location = new System.Drawing.Point(175, 264);
            this.mobileTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.mobileTextBox.Name = "mobileTextBox";
            this.mobileTextBox.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobileTextBox.Properties.Appearance.Options.UseFont = true;
            this.mobileTextBox.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.None;
            this.mobileTextBox.Properties.Mask.EditMask = "04\\d\\d\\d\\d\\d\\d\\d\\d";
            this.mobileTextBox.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.mobileTextBox.Properties.Mask.PlaceHolder = '*';
            this.mobileTextBox.Size = new System.Drawing.Size(264, 26);
            this.mobileTextBox.TabIndex = 78;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(607, 242);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.Properties.Appearance.Options.UseFont = true;
            this.emailTextBox.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.None;
            this.emailTextBox.Properties.Mask.EditMask = "04\\d\\d\\d\\d\\d\\d\\d\\d";
            this.emailTextBox.Properties.Mask.PlaceHolder = '*';
            this.emailTextBox.Size = new System.Drawing.Size(337, 26);
            this.emailTextBox.TabIndex = 84;
            // 
            // labelControl26
            // 
            this.labelControl26.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl26.Location = new System.Drawing.Point(63, 220);
            this.labelControl26.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl26.Name = "labelControl26";
            this.labelControl26.Size = new System.Drawing.Size(87, 20);
            this.labelControl26.TabIndex = 91;
            this.labelControl26.Text = "Work Phone";
            // 
            // labelControl24
            // 
            this.labelControl24.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl24.Location = new System.Drawing.Point(533, 131);
            this.labelControl24.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl24.Name = "labelControl24";
            this.labelControl24.Size = new System.Drawing.Size(52, 20);
            this.labelControl24.TabIndex = 94;
            this.labelControl24.Text = "Suburb";
            // 
            // workPhoneTextBox
            // 
            this.workPhoneTextBox.Location = new System.Drawing.Point(175, 217);
            this.workPhoneTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.workPhoneTextBox.Name = "workPhoneTextBox";
            this.workPhoneTextBox.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workPhoneTextBox.Properties.Appearance.Options.UseFont = true;
            this.workPhoneTextBox.Properties.Mask.EditMask = "(0[2|3|4|7|8]-)?[1-9]\\d\\d\\d\\d\\d\\d\\d";
            this.workPhoneTextBox.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.workPhoneTextBox.Properties.Mask.PlaceHolder = '*';
            this.workPhoneTextBox.Size = new System.Drawing.Size(264, 26);
            this.workPhoneTextBox.TabIndex = 77;
            // 
            // titleComboBox
            // 
            this.titleComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleComboBox.FormattingEnabled = true;
            this.titleComboBox.Items.AddRange(new object[] {
            "Mr",
            "Ms",
            "Miss",
            "Mrs",
            "Doctor"});
            this.titleComboBox.Location = new System.Drawing.Point(607, 41);
            this.titleComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.titleComboBox.Name = "titleComboBox";
            this.titleComboBox.Size = new System.Drawing.Size(119, 28);
            this.titleComboBox.TabIndex = 80;
            // 
            // labelControl20
            // 
            this.labelControl20.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl20.Location = new System.Drawing.Point(525, 85);
            this.labelControl20.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl20.Name = "labelControl20";
            this.labelControl20.Size = new System.Drawing.Size(59, 20);
            this.labelControl20.TabIndex = 92;
            this.labelControl20.Text = "Address";
            // 
            // postCodeTextBox
            // 
            this.postCodeTextBox.Location = new System.Drawing.Point(729, 169);
            this.postCodeTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.postCodeTextBox.Name = "postCodeTextBox";
            this.postCodeTextBox.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postCodeTextBox.Properties.Appearance.Options.UseFont = true;
            this.postCodeTextBox.Size = new System.Drawing.Size(105, 26);
            this.postCodeTextBox.TabIndex = 96;
            this.postCodeTextBox.TabStop = false;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(606, 83);
            this.addressTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTextBox.Properties.Appearance.Options.UseFont = true;
            this.addressTextBox.Size = new System.Drawing.Size(228, 26);
            this.addressTextBox.TabIndex = 81;
            // 
            // stateTextBox
            // 
            this.stateTextBox.EditValue = "";
            this.stateTextBox.Location = new System.Drawing.Point(607, 169);
            this.stateTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateTextBox.Properties.Appearance.Options.UseFont = true;
            this.stateTextBox.Size = new System.Drawing.Size(118, 26);
            this.stateTextBox.TabIndex = 95;
            this.stateTextBox.TabStop = false;
            // 
            // suburbComboBox
            // 
            this.suburbComboBox.DisplayMember = "Location";
            this.suburbComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.suburbComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suburbComboBox.FormattingEnabled = true;
            this.suburbComboBox.Location = new System.Drawing.Point(605, 128);
            this.suburbComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.suburbComboBox.Name = "suburbComboBox";
            this.suburbComboBox.Size = new System.Drawing.Size(229, 27);
            this.suburbComboBox.TabIndex = 82;
            this.suburbComboBox.ValueMember = "PostCodeID";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.displayGridControl);
            this.groupControl3.Controls.Add(this.goBtn);
            this.groupControl3.Controls.Add(this.searchFieldTextBox);
            this.groupControl3.Controls.Add(this.label1);
            this.groupControl3.Location = new System.Drawing.Point(-4, 1);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(963, 206);
            this.groupControl3.TabIndex = 73;
            this.groupControl3.Text = "Select a Patient";
            // 
            // displayGridControl
            // 
            this.displayGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.displayGridControl.Location = new System.Drawing.Point(15, 40);
            this.displayGridControl.MainView = this.displayGridView;
            this.displayGridControl.Margin = new System.Windows.Forms.Padding(2);
            this.displayGridControl.Name = "displayGridControl";
            this.displayGridControl.Size = new System.Drawing.Size(658, 162);
            this.displayGridControl.TabIndex = 10;
            this.displayGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.displayGridView});
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
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "First Name";
            this.gridColumn1.FieldName = "RefDFNames";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Last Name";
            this.gridColumn2.FieldName = "RefDName";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Provider #";
            this.gridColumn3.FieldName = "RefProviderNo";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // goBtn
            // 
            this.goBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goBtn.Appearance.Options.UseFont = true;
            this.goBtn.Location = new System.Drawing.Point(862, 121);
            this.goBtn.Margin = new System.Windows.Forms.Padding(2);
            this.goBtn.Name = "goBtn";
            this.goBtn.Size = new System.Drawing.Size(54, 40);
            this.goBtn.TabIndex = 9;
            this.goBtn.TabStop = false;
            this.goBtn.Text = "go";
            // 
            // searchFieldTextBox
            // 
            this.searchFieldTextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchFieldTextBox.Location = new System.Drawing.Point(692, 74);
            this.searchFieldTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.searchFieldTextBox.Name = "searchFieldTextBox";
            this.searchFieldTextBox.Size = new System.Drawing.Size(224, 27);
            this.searchFieldTextBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(688, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Search";
            // 
            // referralViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(958, 645);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.doctorDetailsGroupBox);
            this.Controls.Add(this.groupControl1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "referralViewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ReferralForm";
            this.Load += new System.EventHandler(this.ReferralViewFormLoad);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ReferralLinkFormKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.doctorDetailsGroupBox)).EndInit();
            this.doctorDetailsGroupBox.ResumeLayout(false);
            this.doctorDetailsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.faxTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.givenNameTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.organizationTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.surnameTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provideTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homePhoneTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobileTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workPhoneTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postCodeTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker referralDocBgWorker;
        private System.Windows.Forms.Timer searchTimer;
        private System.Windows.Forms.Timer postCodeTimer;
        private System.ComponentModel.BackgroundWorker postCodeBgWorker;
        private System.Windows.Forms.ProgressBar searchResultProgressBar;
        private System.Windows.Forms.Timer loadBarTimer;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton cancelBtn;
        private DevExpress.XtraEditors.SimpleButton applyBtn;
        private DevExpress.XtraEditors.SimpleButton newPatientBtn;
        private DevExpress.XtraEditors.SimpleButton okBtn;
        private DevExpress.XtraEditors.GroupControl doctorDetailsGroupBox;
        private DevExpress.XtraEditors.TextEdit faxTextEdit;
        private DevExpress.XtraEditors.TextEdit givenNameTextBox;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl32;
        private DevExpress.XtraEditors.TextEdit organizationTextBox;
        private DevExpress.XtraEditors.TextEdit surnameTextBox;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl31;
        private DevExpress.XtraEditors.LabelControl labelControl22;
        private DevExpress.XtraEditors.LabelControl labelControl30;
        private DevExpress.XtraEditors.TextEdit provideTextBox;
        private DevExpress.XtraEditors.LabelControl labelControl28;
        private DevExpress.XtraEditors.SimpleButton findPostCodeBtn;
        private DevExpress.XtraEditors.TextEdit homePhoneTextBox;
        private DevExpress.XtraEditors.LabelControl labelControl23;
        private DevExpress.XtraEditors.LabelControl labelControl27;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraEditors.TextEdit mobileTextBox;
        private DevExpress.XtraEditors.TextEdit emailTextBox;
        private DevExpress.XtraEditors.LabelControl labelControl26;
        private DevExpress.XtraEditors.LabelControl labelControl24;
        private DevExpress.XtraEditors.TextEdit workPhoneTextBox;
        private System.Windows.Forms.ComboBox titleComboBox;
        private DevExpress.XtraEditors.LabelControl labelControl20;
        private DevExpress.XtraEditors.TextEdit postCodeTextBox;
        private DevExpress.XtraEditors.TextEdit addressTextBox;
        private DevExpress.XtraEditors.TextEdit stateTextBox;
        private System.Windows.Forms.ComboBox suburbComboBox;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraGrid.GridControl displayGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView displayGridView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.SimpleButton goBtn;
        private System.Windows.Forms.TextBox searchFieldTextBox;
        private System.Windows.Forms.Label label1;
    }
}