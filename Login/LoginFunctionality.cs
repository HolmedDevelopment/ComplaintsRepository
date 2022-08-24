using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Login;

namespace Login
{
    public class LoginFunctionality
    {
        private static LoginContext _context { get; set; } = new LoginContext();
        public class LoginResult
        {
            public bool IsSuccess { get; set; }
            public string Message { get; set; }
        }

        public LoginResult AuthenticateUser(string userid, string pass)
        {
            LoginResult result = new LoginResult();
            try
            {
                var userAuthenticated = _context.tblUsers.FirstOrDefault(x => x.UserID == userid);
                if (userAuthenticated != null)
                {
                    if (userAuthenticated.Passwd == pass)
                    {
                        result.IsSuccess = true;
                        result.Message = "Welcome";
                    }
                    else
                    {
                        result.IsSuccess = false;
                        result.Message = "Password incorrect";
                    }
                }
                else
                {
                    result.IsSuccess = false;
                    result.Message = "User not found";

                }

                return result;
            }
            catch
            {
                throw new Exception("System is down");
            }
        }
    }
}
