using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnitTestDemo.Models
{
    public class DataClassA
    {
        public DataClassA()
        {
           
        }
        public bool UserCanDrink(Guid id)
        {
            var user = getUser(id);
            return user.age >= 21;        
        }
        private User getUser(Guid id)
        {
            DbContextOptions<DatabaseContext> tmp = new DbContextOptions<DatabaseContext>();
            DatabaseContext _context = new DatabaseContext(tmp);
            User user = _context.User.Where(u => u.userId == id).SingleOrDefault();
            if (user == null) return null;
            return user;
        }
    }
}
