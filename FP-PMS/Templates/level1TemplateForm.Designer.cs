namespace FP_PMS.Templates
{
    partial class level1TemplateForm
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
            this.okBtn = new DevExpress.XtraEditors.SimpleButton();
            this.applyBtn = new DevExpress.XtraEditors.SimpleButton();
            this.quitBtn = new DevExpress.XtraEditors.SimpleButton();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.formSearchLookUpEdit = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchTitleLabel = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formSearchLookUpEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(558, 599);
            this.okBtn.Margin = new System.Windows.Forms.Padding(2);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(56, 19);
            this.okBtn.TabIndex = 1;
            this.okBtn.Text = "OK";
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // applyBtn
            // 
            this.applyBtn.Location = new System.Drawing.Point(618, 599);
            this.applyBtn.Margin = new System.Windows.Forms.Padding(2);
            this.applyBtn.Name = "applyBtn";
            this.applyBtn.Size = new System.Drawing.Size(56, 19);
            this.applyBtn.TabIndex = 2;
            this.applyBtn.Text = "Apply";
            this.applyBtn.Click += new System.EventHandler(this.applyBtn_Click);
            // 
            // quitBtn
            // 
            this.quitBtn.Location = new System.Drawing.Point(679, 599);
            this.quitBtn.Margin = new System.Windows.Forms.Padding(2);
            this.quitBtn.Name = "quitBtn";
            this.quitBtn.Size = new System.Drawing.Size(56, 19);
            this.quitBtn.TabIndex = 3;
            this.quitBtn.Text = "Quit";
            this.quitBtn.Click += new System.EventHandler(this.quitBtn_Click);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // formSearchLookUpEdit
            // 
            this.formSearchLookUpEdit.Location = new System.Drawing.Point(158, 12);
            this.formSearchLookUpEdit.Name = "formSearchLookUpEdit";
            this.formSearchLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.formSearchLookUpEdit.Properties.View = this.searchLookUpEdit1View;
            this.formSearchLookUpEdit.Size = new System.Drawing.Size(100, 20);
            this.formSearchLookUpEdit.TabIndex = 4;
            // 
            // searchTitleLabel
            // 
            this.searchTitleLabel.Location = new System.Drawing.Point(89, 15);
            this.searchTitleLabel.Name = "searchTitleLabel";
            this.searchTitleLabel.Size = new System.Drawing.Size(63, 13);
            this.searchTitleLabel.TabIndex = 5;
            this.searchTitleLabel.Text = "labelControl1";
            // 
            // level1TemplateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 627);
            this.Controls.Add(this.searchTitleLabel);
            this.Controls.Add(this.formSearchLookUpEdit);
            this.Controls.Add(this.quitBtn);
            this.Controls.Add(this.applyBtn);
            this.Controls.Add(this.okBtn);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "level1TemplateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.level1TemplateForm_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.level1TemplateForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formSearchLookUpEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DevExpress.XtraEditors.SimpleButton okBtn;
        public DevExpress.XtraEditors.SimpleButton applyBtn;
        public DevExpress.XtraEditors.SimpleButton quitBtn;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        public DevExpress.XtraEditors.SearchLookUpEdit formSearchLookUpEdit;
        public DevExpress.XtraEditors.LabelControl searchTitleLabel;

    }
}