using IDQ_0__Personal_Secretary.Models.DataBase.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IDQ_0__Personal_Secretary.Models.DataBase
{
    public class DBContext: DbContext
    {
        public DbSet<Project> Projects { get; set; }

        public DBContext(DbContextOptions<DBContext> options)
            :base(options)
        {
            Database.EnsureCreated();
        }
    }
}
