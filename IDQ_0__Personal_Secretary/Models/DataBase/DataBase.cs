using IDQ_0__Personal_Secretary.Models.DataBase.Entities;
using IDQ_0__Personal_Secretary.Models.DataBase.Entities.Targets;
using System;
using System.Collections.Generic;
using System.Linq;

namespace IDQ_0__Personal_Secretary.Models.DataBase
{
    public class DataBase
    {
        private DBContext db;
        public DataBase(DBContext context)
        {
            db = context;
        }

        public void ClearDataBase()
        {
            db.Projects.RemoveRange(db.Projects.ToList());
            db.SaveChanges();
        }

        public List<Project> GetAllProjects()
        {
            return db.Projects.ToList();
        }
        public List<Stage> GetAllStage()
        {
            return db.Stages.ToList();
        }
        public List<BuisnessProcess> GetAllBP()
        {
            return db.BPs.ToList();
        }
        public List<Task> GetAllTask()
        {
            return db.Tasks.ToList();
        }

        public List<ProjectTarget> GetAllProjectTargets()
        {
            return db.ProjectTargets.ToList();
        }
        public List<StageTarget> GetAllStageTarget()
        {
            return db.StageTargets.ToList();
        }
        public List<BPTarget> GetAllBPTargets()
        {
            return db.BPTargets.ToList();
        }
        public List<TaskTarget> GetAllTaskTargets()
        {
            return db.TaskTargets.ToList();
        }

        public void AddProject(Project project)
        {
            db.Projects.Add(project.Initialize());
            db.SaveChanges();
        }
        public void UpdateProject(Project project)
        {
            if (project.Id > 0)
            {
                var temp = db.Projects.Where(p => p.Id == project.Id).First();
                temp.Name = project.Name;
                temp.Priority = project.Priority;
                temp.Stages = project.Stages;
                temp.Targets = project.Targets;
                temp.Description = project.Description;
                db.SaveChanges();
            }
        }

        public Project GetProjectById(int id)
        {
            var projects = db.Projects.Where(p => p.Id == id);
            if (projects.Any())
            {
                var temp = projects.First();
                return temp.Initialize();
            }
                
            else return null;
        }

        public void AddTargetInProject(int v, ProjectTarget target)
        {
            throw new NotImplementedException();
        }
    }
}
