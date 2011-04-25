using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Mail;
using System.Net.Mime;
using FP_PMS.Ex;
using FP_PMS.Db;
using DevExpress.XtraEditors;

namespace FP_PMS.Referral
{
    public partial class letterDialog : DevExpress.XtraEditors.XtraForm
    {
        tblPatient _myPatient;
        tblRefDoctor _myDoctor;

        tblPatient myPatient { get { return _myPatient; } set { _myPatient = value; } }
        tblRefDoctor myDoctor { get { return _myDoctor; } set { _myDoctor = value; } }

        string letterContents;

        void setLetterContents()
        {
            letterContents = @"Dear Sir/Madam," + Environment.NewLine + Environment.NewLine;
            letterContents = letterContents + @"I am writing to you about the following patient that you referred to me for treatment." + Environment.NewLine + Environment.NewLine;
            letterContents = letterContents + @"The patient is " + myPatient.FirstNames + @" " + myPatient.LastName;
            if (myPatient.BirthDate.HasValue == true)
                letterContents = letterContents + '\t' + @"Date of Birth : " + myPatient.BirthDate.Value.Date.ToShortDateString();
            letterContents = letterContents + Environment.NewLine + Environment.NewLine + Environment.NewLine;
            letterContents = letterContents + @"Regards,";
        }

        public letterDialog(tblPatient MyPatient, tblRefDoctor MyDoctor)
        {
            InitializeComponent();
            myPatient = MyPatient;
            myDoctor = MyDoctor;

            setLetterContents();

            thankyouLetterRichEdit.Text = letterContents;

        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            thankyouLetterRichEdit.Print();
        }

        private void emailBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:" + myDoctor.RefEmail + "?subject=" + "Thank you from Fairfield Physio" + @"&body=" + thankyouLetterRichEdit.Text);
        }
    }
}