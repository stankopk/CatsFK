using CatsFK.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatsFK.Controller
{
    internal class CatsController
    {
        //Read
        public List<Cat> GetAllCatsById(int id)
        {
            using (CatsDBEntities db = new CatsDBEntities())
            {
                return db.Cat.Where(c => c.UserId == id).ToList();
            }
        }
    }
}
