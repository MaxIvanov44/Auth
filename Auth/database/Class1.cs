
using database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace database
{
    public class Class1
    {
       public static List<Users> refreshgridDB()
        {
            Model1 db = new Model1();
            var data = db.Users.ToList();
            return data;
           
        }
    }
}
