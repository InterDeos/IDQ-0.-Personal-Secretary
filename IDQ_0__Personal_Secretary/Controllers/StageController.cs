using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IDQ_0__Personal_Secretary.Models.DataBase;
using IDQ_0__Personal_Secretary.Models.DataBase.Entities;
using Microsoft.AspNetCore.Mvc;

namespace IDQ_0__Personal_Secretary.Controllers
{
    public class StageController : Controller
    {
        private DBContext db;

        public StageController(DBContext context)
        {
            db = context;
        }

        public void Add(Stage stage)
        {
            db.Stages.Add(stage);
            db.SaveChanges();
        }
        public void Update(Stage stage)
        {
            db.Stages.Update(stage);
            db.SaveChanges();
        }
        public void Delete(Stage stage)
        {
            db.Stages.Remove(stage);
            db.SaveChanges();
        }
    }
}