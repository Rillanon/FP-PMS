namespace FP_PMS.Accounting.Receipt
{
    partial class addPaymentAmountViewForm
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.paymentAmountSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.paymentAmountSpinEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // quitBtn
            // 
            this.quitBtn.Location = new System.Drawing.Point(282, 58);
            this.quitBtn.Size = new System.Drawing.Size(105, 27);
            this.quitBtn.TabIndex = 2;
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(182, 58);
            this.okBtn.Size = new System.Drawing.Size(96, 27);
            this.okBtn.TabIndex = 1;
            // 
            // paymentAmountSpinEdit
            // 
            this.paymentAmountSpinEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.paymentAmountSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.paymentAmountSpinEdit.Location = new System.Drawing.Point(182, 11);
            this.paymentAmountSpinEdit.Margin = new System.Windows.Forms.Padding(2);
            this.paymentAmountSpinEdit.Name = "paymentAmountSpinEdit";
            this.paymentAmountSpinEdit.Properties.AllowFocused = false;
            this.paymentAmountSpinEdit.Properties.Appearance.Font = new System.Drawing.Font("Vrinda", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentAmountSpinEdit.Properties.Appearance.Options.UseFont = true;
            this.paymentAmountSpinEdit.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
            this.paymentAmountSpinEdit.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White;
            this.paymentAmountSpinEdit.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.Coral;
            this.paymentAmountSpinEdit.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.paymentAmountSpinEdit.Properties.AppearanceReadOnly.Options.UseBorderColor = true;
            this.paymentAmountSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "Blah", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.paymentAmountSpinEdit.Properties.DisplayFormat.FormatString = "c2";
            this.paymentAmountSpinEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.paymentAmountSpinEdit.Properties.Mask.EditMask = "c";
            this.paymentAmountSpinEdit.Size = new System.Drawing.Size(205, 32);
            this.paymentAmountSpinEdit.TabIndex = 0;
            this.paymentAmountSpinEdit.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.paymentAmountSpinEdit_EditValueChanging);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(23, 16);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(63, 19);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "Amount:";
            // 
            // addPaymentAmountViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(398, 96);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.paymentAmountSpinEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "addPaymentAmountViewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enter Amount";
            this.Load += new System.EventHandler(this.addPaymentAmountViewForm_Load);
            this.Controls.SetChildIndex(this.okBtn, 0);
            this.Controls.SetChildIndex(this.quitBtn, 0);
            this.Controls.SetChildIndex(this.paymentAmountSpinEdit, 0);
            this.Controls.SetChildIndex(this.labelControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.paymentAmountSpinEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal DevExpress.XtraEditors.SpinEdit paymentAmountSpinEdit;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}
