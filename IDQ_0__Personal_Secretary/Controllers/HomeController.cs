using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using IDQ_0__Personal_Secretary.Models;
using IDQ_0__Personal_Secretary.Models.DataBase;
using IDQ_0__Personal_Secretary.Models.DataBase.Entities;

namespace IDQ_0__Personal_Secretary.Controllers
{
    public class PR
    {
        public string Name { get; set; }
        public int Priority { get; set; }
        public string Description { get; set; }
    }
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Index";
        }
    }
}
