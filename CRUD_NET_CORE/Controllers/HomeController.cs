using CRUD_NET_CORE.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_NET_CORE.Controllers
{
    public class HomeController : Controller
    {
        private IEmployeeRepositry _employeeRepositry;

        public HomeController(IEmployeeRepositry employeeRepositry)
        {
            _employeeRepositry = employeeRepositry;
        }
        public string Index()
        {
            return _employeeRepositry.GetEmployee(1).Name;
        }

    }
}
