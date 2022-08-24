using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Login;
namespace TestingLogin
{
    internal class Program
    {
        private static LoginContext _context { get; set; } = new LoginContext();
        static void Main(string[] args)
        {
            var tempList = _context.tblUsers.ToList().OrderBy(x => x.CreationDate);
            UpdateUser("test", "charlesAbuRabba");

        }
        public static bool UpdateUser(string UserId, string NewName)
        {
            try
            {
                var user = _context.tblUsers.FirstOrDefault(x => x.UserID == UserId);//lAMBDA EXPRESSION
                var userLinq = (from x in _context.tblUsers
                                where x.UserID == UserId
                                select x).FirstOrDefault(); //LINQ
                if (user != null)
                {
                    user.UserName = NewName;
                }
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }

        public static LoginResult AuthenticateUser(string userid, string pass)
        {
            LoginResult result = new LoginResult();
            try
            {
                var userAuthenticated = _context.tblUsers.FirstOrDefault(x => x.UserID == userid);
                if (userAuthenticated != null)
                {
                    if(userAuthenticated.Passwd == pass)
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
                throw new Exception("System is bajjj");
            }
        }


    }
    public class LoginResult
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
    }
}
