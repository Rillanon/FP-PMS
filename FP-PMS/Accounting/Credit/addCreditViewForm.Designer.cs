namespace FP_PMS.Accounting.Credit
{
    partial class addCreditViewForm
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.creditCommentMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.creditDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.creditAmountSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.claimantDetailMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.creditTypeLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.creditCommentMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.creditDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditAmountSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.claimantDetailMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditTypeLookUpEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // quitBtn
            // 
            this.quitBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitBtn.Appearance.Options.UseFont = true;
            this.quitBtn.Location = new System.Drawing.Point(382, 348);
            // 
            // okBtn
            // 
            this.okBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okBtn.Appearance.Options.UseFont = true;
            this.okBtn.Location = new System.Drawing.Point(322, 348);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.creditCommentMemoEdit);
            this.groupControl1.Location = new System.Drawing.Point(1, 187);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(218, 148);
            this.groupControl1.TabIndex = 7;
            this.groupControl1.Text = "Comments";
            // 
            // creditCommentMemoEdit
            // 
            this.creditCommentMemoEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.creditCommentMemoEdit.Location = new System.Drawing.Point(2, 22);
            this.creditCommentMemoEdit.Name = "creditCommentMemoEdit";
            this.creditCommentMemoEdit.Size = new System.Drawing.Size(214, 124);
            this.creditCommentMemoEdit.TabIndex = 3;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(this.creditDateEdit);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Controls.Add(this.creditAmountSpinEdit);
            this.groupControl2.Controls.Add(this.creditTypeLookUpEdit);
            this.groupControl2.Location = new System.Drawing.Point(1, 2);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(440, 179);
            this.groupControl2.TabIndex = 8;
            this.groupControl2.Text = "Details";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(75, 122);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(88, 19);
            this.labelControl3.TabIndex = 14;
            this.labelControl3.Text = "Credit Type:";
            // 
            // creditDateEdit
            // 
            this.creditDateEdit.EditValue = null;
            this.creditDateEdit.Location = new System.Drawing.Point(176, 82);
            this.creditDateEdit.Name = "creditDateEdit";
            this.creditDateEdit.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.creditDateEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditDateEdit.Properties.Appearance.Options.UseBackColor = true;
            this.creditDateEdit.Properties.Appearance.Options.UseFont = true;
            this.creditDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.creditDateEdit.Properties.ReadOnly = true;
            this.creditDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.creditDateEdit.Size = new System.Drawing.Size(219, 26);
            this.creditDateEdit.TabIndex = 9;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(125, 85);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(38, 19);
            this.labelControl2.TabIndex = 12;
            this.labelControl2.Text = "Date:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(53, 52);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(110, 19);
            this.labelControl1.TabIndex = 11;
            this.labelControl1.Text = "Credit Amount:";
            // 
            // creditAmountSpinEdit
            // 
            this.creditAmountSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.creditAmountSpinEdit.EnterMoveNextControl = true;
            this.creditAmountSpinEdit.Location = new System.Drawing.Point(176, 44);
            this.creditAmountSpinEdit.Name = "creditAmountSpinEdit";
            this.creditAmountSpinEdit.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.creditAmountSpinEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditAmountSpinEdit.Properties.Appearance.Options.UseBackColor = true;
            this.creditAmountSpinEdit.Properties.Appearance.Options.UseFont = true;
            this.creditAmountSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.creditAmountSpinEdit.Properties.DisplayFormat.FormatString = "c2";
            this.creditAmountSpinEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.creditAmountSpinEdit.Properties.Mask.EditMask = "c2";
            this.creditAmountSpinEdit.Properties.ReadOnly = true;
            this.creditAmountSpinEdit.Properties.ValidateOnEnterKey = true;
            this.creditAmountSpinEdit.Size = new System.Drawing.Size(219, 32);
            this.creditAmountSpinEdit.TabIndex = 1;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.claimantDetailMemoEdit);
            this.groupControl3.Location = new System.Drawing.Point(223, 187);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(218, 148);
            this.groupControl3.TabIndex = 8;
            this.groupControl3.Text = "Claimant Details";
            // 
            // claimantDetailMemoEdit
            // 
            this.claimantDetailMemoEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.claimantDetailMemoEdit.Location = new System.Drawing.Point(2, 22);
            this.claimantDetailMemoEdit.Name = "claimantDetailMemoEdit";
            this.claimantDetailMemoEdit.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.claimantDetailMemoEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.claimantDetailMemoEdit.Properties.Appearance.Options.UseBackColor = true;
            this.claimantDetailMemoEdit.Properties.Appearance.Options.UseFont = true;
            this.claimantDetailMemoEdit.Properties.ReadOnly = true;
            this.claimantDetailMemoEdit.Size = new System.Drawing.Size(214, 124);
            this.claimantDetailMemoEdit.TabIndex = 0;
            // 
            // creditTypeLookUpEdit
            // 
            this.creditTypeLookUpEdit.Location = new System.Drawing.Point(176, 119);
            this.creditTypeLookUpEdit.Name = "creditTypeLookUpEdit";
            this.creditTypeLookUpEdit.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.creditTypeLookUpEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditTypeLookUpEdit.Properties.Appearance.Options.UseBackColor = true;
            this.creditTypeLookUpEdit.Properties.Appearance.Options.UseFont = true;
            this.creditTypeLookUpEdit.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditTypeLookUpEdit.Properties.AppearanceDropDown.Options.UseFont = true;
            this.creditTypeLookUpEdit.Properties.AppearanceFocused.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditTypeLookUpEdit.Properties.AppearanceFocused.Options.UseFont = true;
            this.creditTypeLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.creditTypeLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CreditTypeDesc", "Type")});
            this.creditTypeLookUpEdit.Properties.DisplayMember = "CreditTypeDesc";
            this.creditTypeLookUpEdit.Properties.NullText = "Select a type ...";
            this.creditTypeLookUpEdit.Properties.ReadOnly = true;
            this.creditTypeLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.creditTypeLookUpEdit.Properties.ValueMember = "CreditTypeID";
            this.creditTypeLookUpEdit.Size = new System.Drawing.Size(219, 26);
            this.creditTypeLookUpEdit.TabIndex = 2;
            this.creditTypeLookUpEdit.EditValueChanged += new System.EventHandler(this.creditTypeLookUpEdit_EditValueChanged);
            // 
            // addCreditViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(442, 378);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "addCreditViewForm";
            this.Text = "Apply Credit";
            this.Load += new System.EventHandler(this.addCreditViewForm_Load);
            this.Controls.SetChildIndex(this.okBtn, 0);
            this.Controls.SetChildIndex(this.groupControl1, 0);
            this.Controls.SetChildIndex(this.quitBtn, 0);
            this.Controls.SetChildIndex(this.groupControl2, 0);
            this.Controls.SetChildIndex(this.groupControl3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.creditCommentMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.creditDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditAmountSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.claimantDetailMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditTypeLookUpEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.DateEdit creditDateEdit;
        private DevExpress.XtraEditors.SpinEdit creditAmountSpinEdit;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.MemoEdit creditCommentMemoEdit;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.MemoEdit claimantDetailMemoEdit;
        private DevExpress.XtraEditors.LookUpEdit creditTypeLookUpEdit;

    }
}
