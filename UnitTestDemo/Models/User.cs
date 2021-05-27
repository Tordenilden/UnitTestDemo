using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnitTestDemo.Models
{
    public class User
    {
        public Guid userId { get; set; }
        public string username { get; set; }
        public string mail { get; set; }
        public int age { get; set; }
        public User(int _age)
        {
            age = _age;
        }
    }
}
