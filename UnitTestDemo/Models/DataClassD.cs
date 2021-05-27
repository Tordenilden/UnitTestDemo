using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnitTestDemo.Models
{
    public class DataClassD
    {
        private IDataSource _dataSource;
        public DataClassD(IDataSource dataSource)
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
