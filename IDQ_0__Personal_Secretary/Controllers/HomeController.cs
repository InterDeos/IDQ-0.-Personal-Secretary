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
    public class HomeController : Controller
    {
        private DataBase data;

        public HomeController(DBContext context)
        {
            data = new DataBase(context);
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string login, string password)
        {
            return LocalRedirect("~/Project/all");
        }
    }
}
