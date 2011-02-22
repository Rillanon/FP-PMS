namespace FP_PMS.Scheduling
{
    partial class appointmentsByPhysioViewForm
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
            this.appointmentsByPhysioGridControl = new DevExpress.XtraGrid.GridControl();
            this.appointmentsByPhysioGridLookUpView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.nameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rateCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.startCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dateTimeRepositoryItem = new DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit();
            this.endCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.checkOutCountSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.checkInCountSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.appointmentsCountSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.nextAppointmentDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.physioAppointmentDateNavigator = new DevExpress.XtraScheduler.DateNavigator();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsByPhysioGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsByPhysioGridLookUpView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeRepositoryItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkOutCountSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkInCountSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsCountSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextAppointmentDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextAppointmentDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.physioAppointmentDateNavigator)).BeginInit();
            this.SuspendLayout();
            // 
            // quitBtn
            // 
            this.quitBtn.Location = new System.Drawing.Point(860, 615);
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(800, 615);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.appointmentsByPhysioGridControl);
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(918, 385);
            this.groupControl1.TabIndex = 6;
            this.groupControl1.Text = "Appointments ";
            // 
            // appointmentsByPhysioGridControl
            // 
            this.appointmentsByPhysioGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.appointmentsByPhysioGridControl.Location = new System.Drawing.Point(2, 22);
            this.appointmentsByPhysioGridControl.MainView = this.appointmentsByPhysioGridLookUpView;
            this.appointmentsByPhysioGridControl.Name = "appointmentsByPhysioGridControl";
            this.appointmentsByPhysioGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.dateTimeRepositoryItem});
            this.appointmentsByPhysioGridControl.Size = new System.Drawing.Size(914, 361);
            this.appointmentsByPhysioGridControl.TabIndex = 7;
            this.appointmentsByPhysioGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.appointmentsByPhysioGridLookUpView});
            // 
            // appointmentsByPhysioGridLookUpView
            // 
            this.appointmentsByPhysioGridLookUpView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.nameCol,
            this.rateCol,
            this.startCol,
            this.endCol});
            this.appointmentsByPhysioGridLookUpView.GridControl = this.appointmentsByPhysioGridControl;
            this.appointmentsByPhysioGridLookUpView.Name = "appointmentsByPhysioGridLookUpView";
            // 
            // nameCol
            // 
            this.nameCol.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameCol.AppearanceCell.Options.UseFont = true;
            this.nameCol.Caption = "Patient Name";
            this.nameCol.FieldName = "Name";
            this.nameCol.Name = "nameCol";
            this.nameCol.Visible = true;
            this.nameCol.VisibleIndex = 0;
            // 
            // rateCol
            // 
            this.rateCol.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rateCol.AppearanceCell.Options.UseFont = true;
            this.rateCol.Caption = "Rate";
            this.rateCol.FieldName = "Rate";
            this.rateCol.Name = "rateCol";
            this.rateCol.Visible = true;
            this.rateCol.VisibleIndex = 1;
            // 
            // startCol
            // 
            this.startCol.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startCol.AppearanceCell.Options.UseFont = true;
            this.startCol.Caption = "Start Date/Time";
            this.startCol.ColumnEdit = this.dateTimeRepositoryItem;
            this.startCol.DisplayFormat.FormatString = "d/MMM/yyyy hh:mm tt";
            this.startCol.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.startCol.FieldName = "startDate";
            this.startCol.Name = "startCol";
            this.startCol.Visible = true;
            this.startCol.VisibleIndex = 2;
            // 
            // dateTimeRepositoryItem
            // 
            this.dateTimeRepositoryItem.AutoHeight = false;
            this.dateTimeRepositoryItem.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateTimeRepositoryItem.DisplayFormat.FormatString = "d";
            this.dateTimeRepositoryItem.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateTimeRepositoryItem.Mask.EditMask = "g";
            this.dateTimeRepositoryItem.Name = "dateTimeRepositoryItem";
            // 
            // endCol
            // 
            this.endCol.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endCol.AppearanceCell.Options.UseFont = true;
            this.endCol.Caption = "End Date/Time";
            this.endCol.ColumnEdit = this.dateTimeRepositoryItem;
            this.endCol.DisplayFormat.FormatString = "d/MMM/yyyy hh:mm tt";
            this.endCol.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.endCol.FieldName = "endDate";
            this.endCol.Name = "endCol";
            this.endCol.Visible = true;
            this.endCol.VisibleIndex = 3;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.checkOutCountSpinEdit);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Controls.Add(this.checkInCountSpinEdit);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Controls.Add(this.appointmentsCountSpinEdit);
            this.groupControl2.Controls.Add(this.nextAppointmentDateEdit);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Location = new System.Drawing.Point(2, 389);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(380, 248);
            this.groupControl2.TabIndex = 7;
            this.groupControl2.Text = "Summary";
            // 
            // checkOutCountSpinEdit
            // 
            this.checkOutCountSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.checkOutCountSpinEdit.Location = new System.Drawing.Point(220, 154);
            this.checkOutCountSpinEdit.Name = "checkOutCountSpinEdit";
            this.checkOutCountSpinEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkOutCountSpinEdit.Properties.Appearance.Options.UseFont = true;
            this.checkOutCountSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.checkOutCountSpinEdit.Properties.Mask.EditMask = "n0";
            this.checkOutCountSpinEdit.Size = new System.Drawing.Size(133, 26);
            this.checkOutCountSpinEdit.TabIndex = 12;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(90, 157);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(109, 19);
            this.labelControl4.TabIndex = 13;
            this.labelControl4.Text = "# of Check Out";
            // 
            // checkInCountSpinEdit
            // 
            this.checkInCountSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.checkInCountSpinEdit.Location = new System.Drawing.Point(220, 117);
            this.checkInCountSpinEdit.Name = "checkInCountSpinEdit";
            this.checkInCountSpinEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkInCountSpinEdit.Properties.Appearance.Options.UseFont = true;
            this.checkInCountSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.checkInCountSpinEdit.Properties.Mask.EditMask = "n0";
            this.checkInCountSpinEdit.Size = new System.Drawing.Size(133, 26);
            this.checkInCountSpinEdit.TabIndex = 10;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(101, 120);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(98, 19);
            this.labelControl3.TabIndex = 11;
            this.labelControl3.Text = "# of Check In";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(70, 81);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(129, 19);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "Next Appointment";
            // 
            // appointmentsCountSpinEdit
            // 
            this.appointmentsCountSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.appointmentsCountSpinEdit.Location = new System.Drawing.Point(220, 41);
            this.appointmentsCountSpinEdit.Name = "appointmentsCountSpinEdit";
            this.appointmentsCountSpinEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentsCountSpinEdit.Properties.Appearance.Options.UseFont = true;
            this.appointmentsCountSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.appointmentsCountSpinEdit.Properties.Mask.EditMask = "n0";
            this.appointmentsCountSpinEdit.Size = new System.Drawing.Size(133, 26);
            this.appointmentsCountSpinEdit.TabIndex = 0;
            // 
            // nextAppointmentDateEdit
            // 
            this.nextAppointmentDateEdit.EditValue = null;
            this.nextAppointmentDateEdit.Location = new System.Drawing.Point(220, 78);
            this.nextAppointmentDateEdit.Name = "nextAppointmentDateEdit";
            this.nextAppointmentDateEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextAppointmentDateEdit.Properties.Appearance.Options.UseFont = true;
            this.nextAppointmentDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.nextAppointmentDateEdit.Properties.Mask.EditMask = "f";
            this.nextAppointmentDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.nextAppointmentDateEdit.Size = new System.Drawing.Size(133, 26);
            this.nextAppointmentDateEdit.TabIndex = 8;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(64, 44);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(135, 19);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "# of Appointments";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.physioAppointmentDateNavigator);
            this.groupControl3.Location = new System.Drawing.Point(388, 389);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(249, 247);
            this.groupControl3.TabIndex = 10;
            this.groupControl3.Text = "Dates";
            // 
            // physioAppointmentDateNavigator
            // 
            this.physioAppointmentDateNavigator.AppearanceCalendar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.physioAppointmentDateNavigator.AppearanceCalendar.Options.UseFont = true;
            this.physioAppointmentDateNavigator.DateTime = new System.DateTime(2011, 2, 20, 0, 0, 0, 0);
            this.physioAppointmentDateNavigator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.physioAppointmentDateNavigator.HotDate = null;
            this.physioAppointmentDateNavigator.Location = new System.Drawing.Point(2, 22);
            this.physioAppointmentDateNavigator.Name = "physioAppointmentDateNavigator";
            this.physioAppointmentDateNavigator.ReadOnly = true;
            this.physioAppointmentDateNavigator.Size = new System.Drawing.Size(245, 223);
            this.physioAppointmentDateNavigator.TabIndex = 11;
            // 
            // appointmentsByPhysioViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(920, 640);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl3);
            this.Name = "appointmentsByPhysioViewForm";
            this.Text = "Appointments By Physio";
            this.Load += new System.EventHandler(this.appointmentsByPhysioViewForm_Load);
            this.Controls.SetChildIndex(this.groupControl3, 0);
            this.Controls.SetChildIndex(this.groupControl2, 0);
            this.Controls.SetChildIndex(this.groupControl1, 0);
            this.Controls.SetChildIndex(this.okBtn, 0);
            this.Controls.SetChildIndex(this.quitBtn, 0);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsByPhysioGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsByPhysioGridLookUpView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeRepositoryItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkOutCountSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkInCountSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsCountSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextAppointmentDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextAppointmentDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.physioAppointmentDateNavigator)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView appointmentsByPhysioGridLookUpView;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SpinEdit appointmentsCountSpinEdit;
        private DevExpress.XtraEditors.DateEdit nextAppointmentDateEdit;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.SpinEdit checkOutCountSpinEdit;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SpinEdit checkInCountSpinEdit;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraGrid.Columns.GridColumn nameCol;
        private DevExpress.XtraGrid.Columns.GridColumn rateCol;
        private DevExpress.XtraGrid.Columns.GridColumn startCol;
        private DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit dateTimeRepositoryItem;
        private DevExpress.XtraGrid.Columns.GridColumn endCol;
        private DevExpress.XtraScheduler.DateNavigator physioAppointmentDateNavigator;
        public DevExpress.XtraGrid.GridControl appointmentsByPhysioGridControl;
    }
}
