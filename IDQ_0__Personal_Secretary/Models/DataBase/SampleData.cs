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
                    projects.Add(new Project { Priority = i, Name = $"Project #{i}", Description = $"Description for Project #{i}" });
                }
                db.Projects.AddRange(projects);
                db.SaveChanges();
                foreach (var project in db.Projects.ToList())
                {
                    project.Stages = new List<Stage>();
                    for (int i = 0; i < 10; i++)
                    {
                        project.Stages.Add(new Stage { Priority = i, Name = $"Stage #{i}" });
                    }
                    
                }
                db.SaveChanges();
                foreach (var stage in db.Stages.ToList())
                {
                    stage.BPs = new List<BuisnessProcess>();
                    for (int i = 0; i < 10; i++)
                    {
                        stage.BPs.Add(new BuisnessProcess { Priority = i, Name = $"BP #{i}", Description = $"Description for BP #{i}" });
                    }
                }
                db.SaveChanges();
                foreach (var bp in db.BPs.ToList())
                {
                    bp.Tasks = new List<Entities.Task>();
                    for (int i = 0; i < 10; i++)
                    {
                        bp.Tasks.Add(new Entities.Task { Priority = i, Name = $"Task #{i}", Description = $"Description for Task #{i}" });
                    }
                }
                db.SaveChanges();
            }
        }
    }
}
