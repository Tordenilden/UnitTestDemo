using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnitTestDemo.Models
{
    public interface IDataSource
    {
        User getUser(Guid id);
    }
}
