using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiceAPI.Security
{
    public class ApiSecurity
    {
        public static bool ValidateUser(string username, string password)
        {
            if(username== "nitiwat.t" && password == "123456")
            {
                return true;
            }else
            {
                return false;
            }            
        }
    }
}