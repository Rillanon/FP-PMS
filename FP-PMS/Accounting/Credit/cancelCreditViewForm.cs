using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Linq;
using System.Linq.Expressions;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FP_PMS.Ex;
using FP_PMS.Db;

namespace FP_PMS.Accounting.Credit
{
    public partial class cancelCreditViewForm : FP_PMS.Templates.level2TemplateForm
    {
        BindingList<Db.Credit> myCreditList = new BindingList<Db.Credit> { };
        BindingList<CreditType> myCreditTypeList = new BindingList<CreditType> {};
        tblClaimant _myClaimant = new tblClaimant();
        public tblClaimant myClaimant { get { return _myClaimant; } set { _myClaimant = value; } }
        
        DateTime _startDate = new DateTime();
        DateTime _endDate = new DateTime();
        public DateTime startDate { get { return _startDate; } set { _startDate = value; } }
        public DateTime endDate { get { return _endDate; } set { _endDate = value; } }

        
        public cancelCreditViewForm(tblClaimant MyClaimant, DateTime Start, DateTime End)
        {
            InitializeComponent();
            myClaimant = MyClaimant;
            startDate = Start;
            endDate = End;
        }

        private void cancelCreditViewForm_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            var newConnection = new dbContextDataContext();
            var creditType = newConnection.CreditTypes.ToList();
            var creditList = (from c in newConnection.getClaimantUncancelledCredit(myClaimant.ClaimantID, startDate, endDate)
                              select new Db.Credit
                              {
                                  CreditID = c.CreditID,
                                  ClaimantID = c.ClaimantID,
                                  CreditAmount = c.CreditAmount,
                                  CreditCancelled = c.CreditCancelled,
                                  CreditDate = c.CreditDate,
                                  CreditComment = c.CreditComment,
                                  CreditType = c.CreditType
                              }).ToList();

            foreach(var t in creditType)
            {
                myCreditTypeList.Add(t);
            }
            foreach(var c in creditList)
            {
                myCreditList.Add(c);
            }
            myCreditList.AllowEdit = true;
            cancellCreditGridControl.DataSource = myCreditList;
            Cursor.Current = Cursors.Default;
        }

        public override void okBtn_Click(object sender, EventArgs e)
        {
            base.okBtn_Click(sender, e);
            var newConnection = new dbContextDataContext();

            foreach(var c in myCreditList)
            {
                if(c.CreditCancelled == true)
                {
                    var currentCredit = newConnection.Credits.Where(cr => cr.CreditID == c.CreditID).FirstOrDefault();
                    if (currentCredit != null)
                    {
                        currentCredit.setProperty(c);
                    }
                }
            }

            newConnection.SubmitChanges();
            
        }

        private void cancelCreditGridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "CreditType")
            {
                foreach (var type in myCreditTypeList)
                {
                    if ((int)e.Value == type.CreditTypeID)
                    {
                        e.DisplayText = type.CreditTypeDesc;
                    }
                }

            }
        }
    }
}
