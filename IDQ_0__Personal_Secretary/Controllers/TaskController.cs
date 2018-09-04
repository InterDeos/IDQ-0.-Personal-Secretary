using System;
using System.Collections.Generic;
using System.Linq;
using IDQ_0__Personal_Secretary.Models.DataBase;
using IDQ_0__Personal_Secretary.Models.DataBase.Entities;
using Microsoft.AspNetCore.Mvc;

namespace IDQ_0__Personal_Secretary.Controllers
{
    public class TaskController : Controller
    {
        private DBContext db;

        public TaskController(DBContext context)
        {
            db = context;
        }

        public void Add(Task task)
        {
            db.Tasks.Add(task);
            db.SaveChanges();
        }
        public void Update(Task task)
        {
            db.Tasks.Update(task);
            db.SaveChanges();
        }
        public void Delete(Task task)
        {
            db.Tasks.Remove(task);
            db.SaveChanges();
        }
    }
}