using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnitTestDemo.Models
{
    public class DataClassC
    {
        private MyDataSource _dataSource;
        public DataClassC(MyDataSource dataSource)
        {
            _dataSource = dataSource;
        }
        public bool UserCanDrink(Guid id)
        {
            var user = _dataSource.getUser(id);
            return user.age >= 21;
        }
    }
}
