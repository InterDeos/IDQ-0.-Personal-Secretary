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
        DBContext db;
        public HomeController(DBContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View(db.Projects.ToList());
        }
        [HttpGet]
        public IActionResult Buy(int id)
        {
            ViewBag.ProjectId = 0;
            return View();
        }
        [HttpPost]
        public string Buy(PR project)
        {
            db.Projects.Add(new Project(project.Priority, project.Name, project.Description));
            db.SaveChanges();
            return $"Project added";
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
