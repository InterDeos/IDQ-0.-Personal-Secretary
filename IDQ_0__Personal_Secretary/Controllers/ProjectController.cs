using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IDQ_0__Personal_Secretary.Models.DataBase;
using IDQ_0__Personal_Secretary.Models.DataBase.Entities;
using Microsoft.AspNetCore.Mvc;

namespace IDQ_0__Personal_Secretary.Controllers
{
    public class ProjectController : Controller
    {
        private DataBase db;

        public ProjectController(DBContext context)
        {
            db = new DataBase(context);
        }

        [ActionName("all")]
        public IActionResult Index()
        {
            return View("All", db.GetAllProjects());
        }

        /*[HttpGet]
        [ActionName("addProject")]
        public IActionResult Add()
        {
            return View("AddProject");
        }
        [HttpPost]
        [ActionName("addProject")]
        public IActionResult Add(Project project)
        {
            db.Projects.Add(project);
            db.SaveChanges();
            return LocalRedirect("~/Project/all");
        }

        [HttpGet]
        [ActionName("updateProject")]
        public IActionResult Update(int id)
        {
            return View("updateProject", db.Projects.Where(p=>p.Id==id).First());
        }
        [HttpPost]
        [ActionName("updateProject")]
        public IActionResult Update(Project project)
        {
            db.Projects.Update(project);
            db.SaveChanges();
            return LocalRedirect("~/Project/all");
        }

        [ActionName("deleteProject")]
        public IActionResult Delete(int id)
        {
            db.Projects.Remove(db.Projects.Where(p => p.Id == id).First());
            db.SaveChanges();
            return LocalRedirect("~/Project/all");
        }

        public IActionResult View(int id)
        {
            Project project = db.Projects.Where(p => p.Id == id).First();
            ViewBag.Id = project.Id;
            ViewBag.Priority = project.Priority;
            ViewBag.Name = project.Name;
            return View("ViewProject", db.Stages.Where(s=> s.ProjectId == id)
                .OrderByDescending(s=> s.Priority).ToList());
        }*/
    }
}