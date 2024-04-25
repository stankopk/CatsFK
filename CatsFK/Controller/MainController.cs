using CatsFK.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatsFK.Controller
{
    internal class MainController
    {
        //Login
        public bool Login(string account, string password)
        {
            using (CatsDBEntities db = new CatsDBEntities())
            {
                var user = db.User.ToList().Where(u => u.Account == account && u.Password == password).FirstOrDefault();
                if(user == null)
                {
                    return false;
                }
                else
                {
                    GlobalInfo.Id = user.Id;
                    return true;
                }
            }
        }
    }
}
