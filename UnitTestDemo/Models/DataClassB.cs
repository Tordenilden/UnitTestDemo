using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnitTestDemo.Models
{
    public class DataClassB
    {
        private MyDataSource _dataSource;
        public DataClassB()
        {
            _dataSource = new MyDataSource();
        }
        public bool UserCanDrink(Guid id)
        {
            var user = _dataSource.getUser(id);
            return user.age >= 21;
        }
    }
}
