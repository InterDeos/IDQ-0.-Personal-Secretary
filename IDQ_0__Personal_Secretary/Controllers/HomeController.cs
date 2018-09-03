using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using IDQ_0__Personal_Secretary.Models;
using IDQ_0__Personal_Secretary.Models.DataBase;

namespace IDQ_0__Personal_Secretary.Controllers
{
    public class HomeController : Controller
    {
        DBContext db;
        public HomeController(DBContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View(db.Projects.ToList());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
