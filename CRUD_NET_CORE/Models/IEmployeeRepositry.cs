using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_NET_CORE.Models
{
   public interface IEmployeeRepositry
    {
        Employee GetEmployee(int Id);
    }
}
