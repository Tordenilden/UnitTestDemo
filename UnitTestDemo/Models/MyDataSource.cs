
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnitTestDemo.Models
{
    public class MyDataSource
    {

        public DatabaseContext _context { get; set; }
        public MyDataSource(DatabaseContext context)
        {
            _context = context;
        }
        public MyDataSource()
        {

        }

    public User getUser(Guid id)
        {
            User user = _context.User.Where(u => u.userId == id).SingleOrDefault();
            if (user == null) return null;
            return user;
        }
    }
}
