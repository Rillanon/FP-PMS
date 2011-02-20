namespace FP_PMS.Referral
{
    partial class referralSearchForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.searchFieldTextBox = new System.Windows.Forms.TextBox();
            this.closeBtn = new DevExpress.XtraEditors.SimpleButton();
            this.okBtn = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.referralDocBgWorker = new System.ComponentModel.BackgroundWorker();
            this.searchTimer = new System.Windows.Forms.Timer(this.components);
            this.displayDataGrid = new System.Windows.Forms.DataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.displayDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search";
            // 
            // searchFieldTextBox
            // 
            this.searchFieldTextBox.Location = new System.Drawing.Point(71, 6);
            this.searchFieldTextBox.Name = "searchFieldTextBox";
            this.searchFieldTextBox.Size = new System.Drawing.Size(298, 22);
            this.searchFieldTextBox.TabIndex = 0;
            this.searchFieldTextBox.TextChanged += new System.EventHandler(this.searchFieldTextBox_TextChanged);
            // 
            // closeBtn
            // 
            this.closeBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 6F);
            this.closeBtn.Appearance.Options.UseFont = true;
            this.closeBtn.Location = new System.Drawing.Point(206, 237);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(92, 23);
            this.closeBtn.TabIndex = 4;
            this.closeBtn.Text = "Close";
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // okBtn
            // 
            this.okBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 6F);
            this.okBtn.Appearance.Options.UseFont = true;
            this.okBtn.Location = new System.Drawing.Point(108, 237);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(92, 23);
            this.okBtn.TabIndex = 3;
            this.okBtn.Text = "OK";
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 6F);
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Location = new System.Drawing.Point(375, 5);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(27, 23);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "go";
            // 
            // referralDocBgWorker
            // 
            this.referralDocBgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.referralDocBgWorker_DoWork);
            this.referralDocBgWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.referralDocBgWorker_RunWorkerCompleted);
            // 
            // searchTimer
            // 
            this.searchTimer.Interval = 1500;
            this.searchTimer.Tick += new System.EventHandler(this.searchTimer_Tick);
            // 
            // displayDataGrid
            // 
            this.displayDataGrid.AlternatingBackColor = System.Drawing.Color.Lavender;
            this.displayDataGrid.BackColor = System.Drawing.Color.WhiteSmoke;
            this.displayDataGrid.BackgroundColor = System.Drawing.Color.LightGray;
            this.displayDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.displayDataGrid.CaptionBackColor = System.Drawing.Color.LightSteelBlue;
            this.displayDataGrid.CaptionForeColor = System.Drawing.Color.MidnightBlue;
            this.displayDataGrid.DataMember = "";
            this.displayDataGrid.FlatMode = true;
            this.displayDataGrid.Font = new System.Drawing.Font("Tahoma", 8F);
            this.displayDataGrid.ForeColor = System.Drawing.Color.MidnightBlue;
            this.displayDataGrid.GridLineColor = System.Drawing.Color.Gainsboro;
            this.displayDataGrid.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None;
            this.displayDataGrid.HeaderBackColor = System.Drawing.Color.MidnightBlue;
            this.displayDataGrid.HeaderFont = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.displayDataGrid.HeaderForeColor = System.Drawing.Color.WhiteSmoke;
            this.displayDataGrid.LinkColor = System.Drawing.Color.Teal;
            this.displayDataGrid.Location = new System.Drawing.Point(15, 34);
            this.displayDataGrid.Name = "displayDataGrid";
            this.displayDataGrid.ParentRowsBackColor = System.Drawing.Color.Gainsboro;
            this.displayDataGrid.ParentRowsForeColor = System.Drawing.Color.MidnightBlue;
            this.displayDataGrid.SelectionBackColor = System.Drawing.Color.CadetBlue;
            this.displayDataGrid.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.displayDataGrid.Size = new System.Drawing.Size(387, 197);
            this.displayDataGrid.TabIndex = 5;
            // 
            // referralSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 272);
            this.Controls.Add(this.displayDataGrid);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.searchFieldTextBox);
            this.Controls.Add(this.label1);
            this.Name = "referralSearchForm";
            this.Text = "referralSearchForm";
            ((System.ComponentModel.ISupportInitialize)(this.displayDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchFieldTextBox;
        private DevExpress.XtraEditors.SimpleButton closeBtn;
        private DevExpress.XtraEditors.SimpleButton okBtn;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.ComponentModel.BackgroundWorker referralDocBgWorker;
        private System.Windows.Forms.Timer searchTimer;
        private System.Windows.Forms.DataGrid displayDataGrid;
    }
}