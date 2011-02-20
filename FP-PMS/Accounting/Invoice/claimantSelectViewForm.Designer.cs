namespace FP_PMS.Accounting.Invoice
{
    partial class claimantSelectViewForm
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
            this.claimantLookUp = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.claimantInstantFeedBack = new DevExpress.Data.Linq.LinqInstantFeedbackSource();
            this.claimantLookUpView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.firstNameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lastNameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.streetCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.claimantLookUp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.claimantLookUpView)).BeginInit();
            this.SuspendLayout();
            // 
            // quitBtn
            // 
            this.quitBtn.Location = new System.Drawing.Point(296, 76);
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(236, 76);
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click_1);
            // 
            // claimantLookUp
            // 
            this.claimantLookUp.Location = new System.Drawing.Point(82, 38);
            this.claimantLookUp.Name = "claimantLookUp";
            this.claimantLookUp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.claimantLookUp.Properties.DataSource = this.claimantInstantFeedBack;
            this.claimantLookUp.Properties.DisplayMember = "LastName";
            this.claimantLookUp.Properties.NullText = "";
            this.claimantLookUp.Properties.ValueMember = "ClaimantID";
            this.claimantLookUp.Properties.View = this.claimantLookUpView;
            this.claimantLookUp.Size = new System.Drawing.Size(270, 20);
            this.claimantLookUp.TabIndex = 6;
            this.claimantLookUp.EditValueChanged += new System.EventHandler(this.claimantLookUp_EditValueChanged);
            // 
            // claimantInstantFeedBack
            // 
            this.claimantInstantFeedBack.AreSourceRowsThreadSafe = true;
            this.claimantInstantFeedBack.KeyExpression = "ClaimantID";
            // 
            // claimantLookUpView
            // 
            this.claimantLookUpView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.firstNameCol,
            this.lastNameCol,
            this.streetCol});
            this.claimantLookUpView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.claimantLookUpView.Name = "claimantLookUpView";
            this.claimantLookUpView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.claimantLookUpView.OptionsView.ShowGroupPanel = false;
            this.claimantLookUpView.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.claimantLookUpView_RowCellClick);
            this.claimantLookUpView.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.claimantLookUpView_SelectionChanged);
            // 
            // firstNameCol
            // 
            this.firstNameCol.Caption = "First Names";
            this.firstNameCol.FieldName = "FirstNames";
            this.firstNameCol.Name = "firstNameCol";
            this.firstNameCol.Visible = true;
            this.firstNameCol.VisibleIndex = 0;
            // 
            // lastNameCol
            // 
            this.lastNameCol.Caption = "Last Name";
            this.lastNameCol.FieldName = "LastName";
            this.lastNameCol.Name = "lastNameCol";
            this.lastNameCol.Visible = true;
            this.lastNameCol.VisibleIndex = 1;
            // 
            // streetCol
            // 
            this.streetCol.Caption = "Street";
            this.streetCol.FieldName = "Address1";
            this.streetCol.Name = "streetCol";
            this.streetCol.Visible = true;
            this.streetCol.VisibleIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 41);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(41, 13);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "Claimant";
            // 
            // claimantSelectViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(362, 114);
            this.Controls.Add(this.claimantLookUp);
            this.Controls.Add(this.labelControl1);
            this.Name = "claimantSelectViewForm";
            this.Text = "Choose a claimant";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.claimantSelectViewForm_FormClosing);
            this.Load += new System.EventHandler(this.claimantSelectViewForm_Load);
            this.Controls.SetChildIndex(this.okBtn, 0);
            this.Controls.SetChildIndex(this.labelControl1, 0);
            this.Controls.SetChildIndex(this.quitBtn, 0);
            this.Controls.SetChildIndex(this.claimantLookUp, 0);
            ((System.ComponentModel.ISupportInitialize)(this.claimantLookUp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.claimantLookUpView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SearchLookUpEdit claimantLookUp;
        private DevExpress.XtraGrid.Views.Grid.GridView claimantLookUpView;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn firstNameCol;
        private DevExpress.XtraGrid.Columns.GridColumn lastNameCol;
        private DevExpress.XtraGrid.Columns.GridColumn streetCol;
        private DevExpress.Data.Linq.LinqInstantFeedbackSource claimantInstantFeedBack;
    }
}
