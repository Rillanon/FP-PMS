using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FP_PMS.Ex
{
    public static class exceptionMessages
    {
        public static string dbConnectionFailedException()
        {
            return @"Database not responding, Please check your connection.";
        }

        public static string authFailedException()
        {
            return @"User/Password failed, Please try again.";
        }

        public static string userLevelFailedException()
        {
            return @"Sorry, you do not have permission to access this feature.";
        }
    }
}