using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;
using FP_PMS.Db;   
 
namespace FP_PMS.Referral
{
    public partial class referralSearchForm : Form
    {
        private List<tblRefDoctor> _formIQueryable;
        public referralSearchForm()
        {
            InitializeComponent();
        }

        private void referralDocBgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            var newConnection = new dbContextDataContext();
            try
            {
                
                    _formIQueryable = (from p in newConnection.tblRefDoctors
                                       where (p.RefDFNames + " " + p.RefDName).Contains(searchFieldTextBox.Text)
                                       select p).Take(10).ToList();
                    
                    searchTimer.Stop();
            }

            catch(Exception)
            {
                MessageBox.Show("Database not responding. Please check your connection.");
            }
        }

        private void searchTimer_Tick(object sender, EventArgs e)
        {
            if(referralDocBgWorker.IsBusy != true)
            {
                referralDocBgWorker.RunWorkerAsync();       
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            var foo =
              (CurrencyManager)displayDataGrid.BindingContext[displayDataGrid.DataSource, displayDataGrid.DataMember];
            var newForm = new referralViewForm((tblRefDoctor)foo.Current) {MdiParent = this.MdiParent};
            newForm.Show();
        }

        private void referralDocBgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.displayDataGrid.DataSource = _formIQueryable;
        }

        private void searchFieldTextBox_TextChanged(object sender, EventArgs e)
        {
            searchTimer.Stop();
            searchTimer.Start();
        }
    }
}
