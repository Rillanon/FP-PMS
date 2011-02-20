using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FP_PMS.Db;
using System.Linq;
using System.Linq.Expressions;

namespace FP_PMS.Admin
{
    public partial class userViewForm : FP_PMS.Templates.level2TemplateForm
    {
        tblUser myUser = new tblUser();

        public userViewForm()
        {
            InitializeComponent();
        }

        void saveToDb()
        {
            var newConnection = new dbContextDataContext();
            var currentUser = newConnection.tblUsers.Where(od => od.UniqueID == myUser.UniqueID).SingleOrDefault();
            if (currentUser == null)
            {
                myUser.UserID = userIDTextEdit.Text;
                myUser.Password = passwordTextEdit.Text;
                myUser.FirstNames = firstNameTextEdit.Text;
                myUser.LastName = lastNameTextEdit.Text;
                if (accessLevelComboBoxEdit.Text == "Adminstrator")
                {
                    myUser.UserLevel = 1;
                }
                if (accessLevelComboBoxEdit.Text == "General User")
                {
                    myUser.UserLevel = 3;
                }
                newConnection.tblUsers.InsertOnSubmit(myUser);
            }
            else
            {
                myUser = newConnection.tblUsers.Where(od => od.UniqueID == myUser.UniqueID).SingleOrDefault();
                myUser.UserID = userIDTextEdit.Text;
                myUser.Password = passwordTextEdit.Text;
                myUser.FirstNames = firstNameTextEdit.Text;
                myUser.LastName = lastNameTextEdit.Text;
                if (accessLevelComboBoxEdit.Text == "Adminstrator")
                {
                    myUser.UserLevel = 1;
                }
                if (accessLevelComboBoxEdit.Text == "General User")
                {
                    myUser.UserLevel = 3;
                }
            }
            newConnection.SubmitChanges();
        }

        void updateForm()
        {
            userIDTextEdit.Text = myUser.UserID;
            passwordTextEdit.Text = myUser.Password;
            if (myUser.UserLevel == 1)
            {
                accessLevelComboBoxEdit.Text = "Adminstrator";
            }
            if (myUser.UserLevel == 3)
            {
                accessLevelComboBoxEdit.Text = "General User";
            }

            if (myUser.UserLevel == 0)
            {
                accessLevelComboBoxEdit.Text = "";
            }

            firstNameTextEdit.Text = myUser.FirstNames;
            lastNameTextEdit.Text = myUser.LastName;
        }

        private void userViewForm_Load(object sender, EventArgs e)
        {
            var newConnection = new dbContextDataContext();
            userLookUp.Properties.DataSource = newConnection.tblUsers;
            userLookUp.Properties.DisplayMember = "UserID";
        }

        private void userLookUp_EditValueChanged(object sender, EventArgs e)
        {
            if (userLookUp.EditValue != null)
            {
                myUser = (tblUser)userLookUpView.GetFocusedRow();
                updateForm();
            }
        }
        public override void okBtn_Click(object sender, EventArgs e)
        {
            base.okBtn_Click(sender, e);
            saveToDb();
        }

        private void newUserBtn_Click(object sender, EventArgs e)
        {
            myUser = new tblUser();
            updateForm();
            userLookUp.EditValue = null;
        }

        private void deleteUserBtn_Click(object sender, EventArgs e)
        {
            var newConnection = new dbContextDataContext();
            var currentUser = newConnection.tblUsers.Where(od => od.UniqueID == myUser.UniqueID).SingleOrDefault();
            if (currentUser != null)
            {
                newConnection.tblUsers.DeleteOnSubmit(currentUser);
                newConnection.SubmitChanges();
                userLookUp.Properties.DataSource = newConnection.tblUsers;
                myUser = new tblUser();
                updateForm();
                userLookUp.EditValue = null;
            }
            else
            {
                myUser = new tblUser();
                updateForm();
                userLookUp.EditValue = null;
            }
        }
    }
}
