﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FP_PMS.Auth
{
    class authController
    {
        private authForm myForm { get; set; }
        public string userId { get; set; }
        public string password { get; set; }

        public DialogResult newAuth()
        {
            using (var newConnection = new Db.dbContextDataContext())
            {
                try
                {
                    
                    var userObj = (from p in newConnection.tblUsers
                                   where p.UserID == userId
                                         && p.Password == password
                                   select p).FirstOrDefault();

                    if (userObj != null)
                    {
                        Ex.staticProperties.userLevel = userObj.UserLevel;
                        Ex.staticProperties.userName = userObj.FirstNames + @" " + userObj.LastName;

                        return DialogResult.OK;
                    }
                    MessageBox.Show(Ex.exceptionMessages.authFailedException());
                    return DialogResult.Retry;
                }

                catch(Exception e)
                {
                    MessageBox.Show(e.Message);
                    MessageBox.Show(Ex.exceptionMessages.dbConnectionFailedException());
                    return DialogResult.Retry;
                }
            }
            
        }

        public authController(authForm myForm)
        {
            this.myForm = myForm;
        }
    }
}