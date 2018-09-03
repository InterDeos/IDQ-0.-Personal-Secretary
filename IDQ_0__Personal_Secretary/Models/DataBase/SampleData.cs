using IDQ_0__Personal_Secretary.Models.DataBase.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IDQ_0__Personal_Secretary.Models.DataBase
{
    public static class SampleData
    {
        public static void Initialize(DBContext db)
        {
            if (!db.Projects.Any())
            {
                List<Project> projects = new List<Project>();
                for(int i = 0; i < 10; i++)
                {
                    projects.Add(new Project(i, $"Project #{i}", $"description {i}"));
                }
                db.Projects.AddRange(projects);
                db.SaveChanges();
            }
        }
    }
}
