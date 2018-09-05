using IDQ_0__Personal_Secretary.Models.DataBase.Entities;
using IDQ_0__Personal_Secretary.Models.DataBase.Entities.Targets;
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
                for(int i = 0; i < 3; i++)
                {
                    projects.Add(new Project { Priority = i, Name = $"Project #{i}", Description = $"Description for Project #{i}",
                        Targets = new List<ProjectTarget>
                        {
                            new ProjectTarget { Name = $"Project {i} Target 1", IsAchieved = false },
                            new ProjectTarget { Name = $"Project {i} Target 2", IsAchieved = false },
                            new ProjectTarget { Name = $"Project {i} Target 3", IsAchieved = false }
                        }
                    });
                }
                db.Projects.AddRange(projects);
                db.SaveChanges();
                foreach (var project in db.Projects.ToList())
                {
                    project.Stages = new List<Stage>();
                    for (int i = 0; i < 5; i++)
                    {
                        project.Stages.Add(new Stage { Priority = i, Name = $"Stage #{i}",
                            Targets = new List<StageTarget>
                            {
                                new StageTarget { Name = $"Stage {i} Target 1", IsAchieved = false },
                                new StageTarget { Name = $"Stage {i} Target 2", IsAchieved = false },
                                new StageTarget { Name = $"Stage {i} Target 3", IsAchieved = false }
                            }
                        });
                    }
                    
                }
                db.SaveChanges();
                foreach (var stage in db.Stages.ToList())
                {
                    stage.BPs = new List<BuisnessProcess>();
                    for (int i = 0; i < 3; i++)
                    {
                        stage.BPs.Add(new BuisnessProcess { Priority = i, Name = $"BP #{i}", Description = $"Description for BP #{i}",
                            Target = new BPTarget { Name = $"BP {i} Target", IsAchieved = false }
                        });
                    }
                }
                db.SaveChanges();
                foreach (var bp in db.BPs.ToList())
                {
                    bp.Tasks = new List<Entities.Task>();
                    for (int i = 0; i < 10; i++)
                    {
                        bp.Tasks.Add(new Entities.Task { Priority = i, Name = $"Task #{i}", Description = $"Description for Task #{i}",
                            Targets = new List<TaskTarget>
                            {
                                new TaskTarget { Name = $"Task {i} Target 1", IsAchieved = false },
                                new TaskTarget { Name = $"Task {i} Target 2", IsAchieved = false },
                                new TaskTarget { Name = $"Task {i} Target 3", IsAchieved = false }
                            }
                        });
                    }
                }
                db.SaveChanges();
            }
        }
    }
}
