namespace FP_PMS
{
    partial class Main
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
            this.mainFormMenuStrip = new System.Windows.Forms.MenuStrip();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.directToPrinterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewPatientDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.viewClaimantDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invoicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blankInvoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invoiceByClaimantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.multipleReceiptsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applyCreditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelInvoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appointmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appointmentBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.waitingRoomLISTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adHocEventsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appointmentLookUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.journalReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receiptByPhysioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newPatientSessionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentAuditTrailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agedBalanceTrailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.postCodesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.physiosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.referralDoctorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ratesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainFormStatusStrip = new System.Windows.Forms.StatusStrip();
            this.mainFormMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainFormMenuStrip
            // 
            this.mainFormMenuStrip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainFormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuToolStripMenuItem,
            this.patientsToolStripMenuItem,
            this.invoicesToolStripMenuItem,
            this.appointmentsToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.adminToolStripMenuItem});
            this.mainFormMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainFormMenuStrip.Name = "mainFormMenuStrip";
            this.mainFormMenuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.mainFormMenuStrip.Size = new System.Drawing.Size(1044, 29);
            this.mainFormMenuStrip.TabIndex = 0;
            this.mainFormMenuStrip.Text = "menuStrip1";
            // 
            // mainMenuToolStripMenuItem
            // 
            this.mainMenuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.toolStripSeparator1,
            this.logOutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            this.mainMenuToolStripMenuItem.Size = new System.Drawing.Size(101, 25);
            this.mainMenuToolStripMenuItem.Text = "Main Menu";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.previewToolStripMenuItem,
            this.directToPrinterToolStripMenuItem});
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // previewToolStripMenuItem
            // 
            this.previewToolStripMenuItem.Name = "previewToolStripMenuItem";
            this.previewToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.previewToolStripMenuItem.Text = "Preview";
            this.previewToolStripMenuItem.Click += new System.EventHandler(this.previewToolStripMenuItem_Click);
            // 
            // directToPrinterToolStripMenuItem
            // 
            this.directToPrinterToolStripMenuItem.Name = "directToPrinterToolStripMenuItem";
            this.directToPrinterToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.directToPrinterToolStripMenuItem.Text = "Direct to Printer";
            this.directToPrinterToolStripMenuItem.Click += new System.EventHandler(this.directToPrinterToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(130, 6);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // patientsToolStripMenuItem
            // 
            this.patientsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewPatientDetailsToolStripMenuItem,
            this.toolStripSeparator3,
            this.viewClaimantDetailsToolStripMenuItem});
            this.patientsToolStripMenuItem.Name = "patientsToolStripMenuItem";
            this.patientsToolStripMenuItem.Size = new System.Drawing.Size(160, 25);
            this.patientsToolStripMenuItem.Text = "Patients / Claimants";
            this.patientsToolStripMenuItem.Click += new System.EventHandler(this.patientsToolStripMenuItem_Click);
            // 
            // viewPatientDetailsToolStripMenuItem
            // 
            this.viewPatientDetailsToolStripMenuItem.Name = "viewPatientDetailsToolStripMenuItem";
            this.viewPatientDetailsToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.viewPatientDetailsToolStripMenuItem.Text = "Patient Details";
            this.viewPatientDetailsToolStripMenuItem.Click += new System.EventHandler(this.viewPatientDetailsToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(190, 6);
            // 
            // viewClaimantDetailsToolStripMenuItem
            // 
            this.viewClaimantDetailsToolStripMenuItem.Name = "viewClaimantDetailsToolStripMenuItem";
            this.viewClaimantDetailsToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.viewClaimantDetailsToolStripMenuItem.Text = "Claimant Details";
            this.viewClaimantDetailsToolStripMenuItem.Click += new System.EventHandler(this.viewClaimantDetailsToolStripMenuItem_Click);
            // 
            // invoicesToolStripMenuItem
            // 
            this.invoicesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blankInvoiceToolStripMenuItem,
            this.invoiceByClaimantToolStripMenuItem,
            this.toolStripSeparator2,
            this.multipleReceiptsToolStripMenuItem,
            this.applyCreditToolStripMenuItem,
            this.cancelInvoiceToolStripMenuItem});
            this.invoicesToolStripMenuItem.Name = "invoicesToolStripMenuItem";
            this.invoicesToolStripMenuItem.Size = new System.Drawing.Size(78, 25);
            this.invoicesToolStripMenuItem.Text = "Invoices";
            // 
            // blankInvoiceToolStripMenuItem
            // 
            this.blankInvoiceToolStripMenuItem.Name = "blankInvoiceToolStripMenuItem";
            this.blankInvoiceToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.blankInvoiceToolStripMenuItem.Text = "Blank Invoice";
            this.blankInvoiceToolStripMenuItem.Click += new System.EventHandler(this.blankInvoiceToolStripMenuItem_Click);
            // 
            // invoiceByClaimantToolStripMenuItem
            // 
            this.invoiceByClaimantToolStripMenuItem.Name = "invoiceByClaimantToolStripMenuItem";
            this.invoiceByClaimantToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.invoiceByClaimantToolStripMenuItem.Text = "View Invoices";
            this.invoiceByClaimantToolStripMenuItem.Click += new System.EventHandler(this.invoiceByClaimantToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(196, 6);
            // 
            // multipleReceiptsToolStripMenuItem
            // 
            this.multipleReceiptsToolStripMenuItem.Name = "multipleReceiptsToolStripMenuItem";
            this.multipleReceiptsToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.multipleReceiptsToolStripMenuItem.Text = "Multiple Receipts";
            this.multipleReceiptsToolStripMenuItem.Click += new System.EventHandler(this.multipleReceiptsToolStripMenuItem_Click);
            // 
            // applyCreditToolStripMenuItem
            // 
            this.applyCreditToolStripMenuItem.Name = "applyCreditToolStripMenuItem";
            this.applyCreditToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.applyCreditToolStripMenuItem.Text = "Apply Credit";
            this.applyCreditToolStripMenuItem.Click += new System.EventHandler(this.applyCreditToolStripMenuItem_Click);
            // 
            // cancelInvoiceToolStripMenuItem
            // 
            this.cancelInvoiceToolStripMenuItem.Name = "cancelInvoiceToolStripMenuItem";
            this.cancelInvoiceToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.cancelInvoiceToolStripMenuItem.Text = "Cancel Invoice";
            this.cancelInvoiceToolStripMenuItem.Click += new System.EventHandler(this.cancelInvoiceToolStripMenuItem_Click);
            // 
            // appointmentsToolStripMenuItem
            // 
            this.appointmentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.appointmentBookToolStripMenuItem,
            this.waitingRoomLISTToolStripMenuItem,
            this.adHocEventsToolStripMenuItem,
            this.appointmentLookUpToolStripMenuItem});
            this.appointmentsToolStripMenuItem.Name = "appointmentsToolStripMenuItem";
            this.appointmentsToolStripMenuItem.Size = new System.Drawing.Size(120, 25);
            this.appointmentsToolStripMenuItem.Text = "Appointments";
            // 
            // appointmentBookToolStripMenuItem
            // 
            this.appointmentBookToolStripMenuItem.Name = "appointmentBookToolStripMenuItem";
            this.appointmentBookToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.appointmentBookToolStripMenuItem.Text = "Appointment Book";
            this.appointmentBookToolStripMenuItem.Click += new System.EventHandler(this.appointmentBookToolStripMenuItem_Click);
            // 
            // waitingRoomLISTToolStripMenuItem
            // 
            this.waitingRoomLISTToolStripMenuItem.Name = "waitingRoomLISTToolStripMenuItem";
            this.waitingRoomLISTToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.waitingRoomLISTToolStripMenuItem.Text = "Waiting Room";
            this.waitingRoomLISTToolStripMenuItem.Click += new System.EventHandler(this.waitingRoomLISTToolStripMenuItem_Click);
            // 
            // adHocEventsToolStripMenuItem
            // 
            this.adHocEventsToolStripMenuItem.Name = "adHocEventsToolStripMenuItem";
            this.adHocEventsToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.adHocEventsToolStripMenuItem.Text = "Events";
            this.adHocEventsToolStripMenuItem.Click += new System.EventHandler(this.adHocEventsToolStripMenuItem_Click);
            // 
            // appointmentLookUpToolStripMenuItem
            // 
            this.appointmentLookUpToolStripMenuItem.Name = "appointmentLookUpToolStripMenuItem";
            this.appointmentLookUpToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.appointmentLookUpToolStripMenuItem.Text = "Appointment Look Up";
            this.appointmentLookUpToolStripMenuItem.Click += new System.EventHandler(this.appointmentLookUpToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.journalReportToolStripMenuItem,
            this.receiptByPhysioToolStripMenuItem,
            this.newPatientSessionsToolStripMenuItem,
            this.paymentAuditTrailToolStripMenuItem,
            this.agedBalanceTrailToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(76, 25);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // journalReportToolStripMenuItem
            // 
            this.journalReportToolStripMenuItem.Name = "journalReportToolStripMenuItem";
            this.journalReportToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.journalReportToolStripMenuItem.Text = "Journal Report";
            this.journalReportToolStripMenuItem.Click += new System.EventHandler(this.journalReportToolStripMenuItem_Click);
            // 
            // receiptByPhysioToolStripMenuItem
            // 
            this.receiptByPhysioToolStripMenuItem.Name = "receiptByPhysioToolStripMenuItem";
            this.receiptByPhysioToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.receiptByPhysioToolStripMenuItem.Text = "Receipt by Physio";
            this.receiptByPhysioToolStripMenuItem.Click += new System.EventHandler(this.receiptByPhysioToolStripMenuItem_Click);
            // 
            // newPatientSessionsToolStripMenuItem
            // 
            this.newPatientSessionsToolStripMenuItem.Name = "newPatientSessionsToolStripMenuItem";
            this.newPatientSessionsToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.newPatientSessionsToolStripMenuItem.Text = "New Patient Sessions";
            this.newPatientSessionsToolStripMenuItem.Click += new System.EventHandler(this.newPatientSessionsToolStripMenuItem_Click);
            // 
            // paymentAuditTrailToolStripMenuItem
            // 
            this.paymentAuditTrailToolStripMenuItem.Name = "paymentAuditTrailToolStripMenuItem";
            this.paymentAuditTrailToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.paymentAuditTrailToolStripMenuItem.Text = "Payment Audit Trail";
            this.paymentAuditTrailToolStripMenuItem.Click += new System.EventHandler(this.paymentAuditTrailToolStripMenuItem_Click);
            // 
            // agedBalanceTrailToolStripMenuItem
            // 
            this.agedBalanceTrailToolStripMenuItem.Name = "agedBalanceTrailToolStripMenuItem";
            this.agedBalanceTrailToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.agedBalanceTrailToolStripMenuItem.Text = "Aged Balance Trail";
            this.agedBalanceTrailToolStripMenuItem.Click += new System.EventHandler(this.agedBalanceTrailToolStripMenuItem_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.postCodesToolStripMenuItem,
            this.physiosToolStripMenuItem,
            this.userToolStripMenuItem,
            this.referralDoctorToolStripMenuItem,
            this.itemsToolStripMenuItem,
            this.ratesToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(68, 25);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // postCodesToolStripMenuItem
            // 
            this.postCodesToolStripMenuItem.Name = "postCodesToolStripMenuItem";
            this.postCodesToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.postCodesToolStripMenuItem.Text = "Post Codes";
            this.postCodesToolStripMenuItem.Click += new System.EventHandler(this.postCodesToolStripMenuItem_Click);
            // 
            // physiosToolStripMenuItem
            // 
            this.physiosToolStripMenuItem.Name = "physiosToolStripMenuItem";
            this.physiosToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.physiosToolStripMenuItem.Text = "Physios";
            this.physiosToolStripMenuItem.Click += new System.EventHandler(this.physiosToolStripMenuItem_Click);
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.userToolStripMenuItem.Text = "Users";
            this.userToolStripMenuItem.Click += new System.EventHandler(this.userToolStripMenuItem_Click);
            // 
            // referralDoctorToolStripMenuItem
            // 
            this.referralDoctorToolStripMenuItem.Name = "referralDoctorToolStripMenuItem";
            this.referralDoctorToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.referralDoctorToolStripMenuItem.Text = "Referral Doctors";
            this.referralDoctorToolStripMenuItem.Click += new System.EventHandler(this.referralDoctorToolStripMenuItem_Click);
            // 
            // itemsToolStripMenuItem
            // 
            this.itemsToolStripMenuItem.Name = "itemsToolStripMenuItem";
            this.itemsToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.itemsToolStripMenuItem.Text = "Items";
            this.itemsToolStripMenuItem.Click += new System.EventHandler(this.itemsToolStripMenuItem_Click);
            // 
            // ratesToolStripMenuItem
            // 
            this.ratesToolStripMenuItem.Name = "ratesToolStripMenuItem";
            this.ratesToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.ratesToolStripMenuItem.Text = "Rates";
            this.ratesToolStripMenuItem.Click += new System.EventHandler(this.ratesToolStripMenuItem_Click);
            // 
            // mainFormStatusStrip
            // 
            this.mainFormStatusStrip.Location = new System.Drawing.Point(0, 686);
            this.mainFormStatusStrip.Name = "mainFormStatusStrip";
            this.mainFormStatusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.mainFormStatusStrip.Size = new System.Drawing.Size(1044, 22);
            this.mainFormStatusStrip.TabIndex = 2;
            this.mainFormStatusStrip.Text = "statusStrip1";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 708);
            this.Controls.Add(this.mainFormStatusStrip);
            this.Controls.Add(this.mainFormMenuStrip);
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.mainFormMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.mainLoad);
            this.mainFormMenuStrip.ResumeLayout(false);
            this.mainFormMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainFormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invoicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appointmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewPatientDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blankInvoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invoiceByClaimantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appointmentBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem waitingRoomLISTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adHocEventsToolStripMenuItem;
        private System.Windows.Forms.StatusStrip mainFormStatusStrip;
        private System.Windows.Forms.ToolStripMenuItem journalReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem receiptByPhysioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem postCodesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem physiosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem referralDoctorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ratesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newPatientSessionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentAuditTrailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multipleReceiptsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applyCreditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelInvoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem previewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem directToPrinterToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem agedBalanceTrailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewClaimantDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem appointmentLookUpToolStripMenuItem;

    }
}

