using database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace database
{
    public class authchk
    {
        public static bool CHK(string username, string password)
        {
            Model1 db = new Model1();
            var Uu = db.Users.Where(us => us.username == username
                      && us.password == password);
            if (Uu.Count() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }




        }
    }
}
