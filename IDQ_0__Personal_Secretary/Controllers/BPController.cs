using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IDQ_0__Personal_Secretary.Models.DataBase;
using IDQ_0__Personal_Secretary.Models.DataBase.Entities;
using Microsoft.AspNetCore.Mvc;

namespace IDQ_0__Personal_Secretary.Controllers
{
    public class BPController : Controller
    {
        private DBContext db;

        public BPController(DBContext context)
        {
            db = context;
        }

        public void Add(BuisnessProcess bp)
        {
            db.BPs.Add(bp);
            db.SaveChanges();
        }
        public void Update(BuisnessProcess bp)
        {
            db.BPs.Update(bp);
            db.SaveChanges();
        }
        public void Delete(BuisnessProcess bp)
        {
            db.BPs.Remove(bp);
            db.SaveChanges();
        }
    }
}