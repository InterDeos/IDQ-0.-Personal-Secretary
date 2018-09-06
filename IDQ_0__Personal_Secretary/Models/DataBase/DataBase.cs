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
        public void DeleteProject(int id)
        {
            if (id > 0)
            {
                var projects = db.Projects.Where(p => p.Id == id);
                if (projects.Any())
                {
                    var project = db.Projects.Where(p => p.Id == id).First();
                    db.Projects.Remove(project);
                    db.SaveChanges();
                }
            }
        }

        public void AddTargetInProject(int id, ProjectTarget target)
        {
            Project project = GetProjectById(id);
            if (project != null)
            {
                project.Initialize();
                project.Targets.Add(target);
                db.SaveChanges();
            }
        }
        public void UpdateTargetInProject(int id, ProjectTarget target)
        {
            var targets = GetProjectById(id).Targets;
            if (targets.Any() && target.Id > 0)
            {
                var temp = targets.Where(t => t.Id == target.Id);
                if (temp.Any())
                {
                    var tempTarget = temp.First();
                    tempTarget.Name = target.Name;
                    tempTarget.IsAchieved = target.IsAchieved;
                    tempTarget.ProjectId = target.ProjectId;
                    db.SaveChanges();
                }
            }
        }
        public void DeleteTargetFromProject(int id)
        {
            var targets = db.ProjectTargets.Where(t => t.Id == id);
            if (targets.Any())
            {
                db.ProjectTargets.Remove(targets.First());
                db.SaveChanges();
            }
        }

        public void AddStage(int projectId, Stage stage)
        {
            var projects = db.Projects.Where(p => p.Id == projectId).ToList();
            if (projects.Any())
            {
                stage.ProjectId = projectId;
                db.Stages.Add(stage);
                db.SaveChanges();
            }
        }

        public Project GetProjectById(int id)
        {
            var projects = db.Projects.Where(p => p.Id == id);
            if (projects.Any())
            {
                var temp = projects.First();
                temp.Targets = db.Projects.Where(p => p.Id == id).First().Targets.ToList();
                return temp.Initialize();
            }
                
            else return null;
        }
    }
}
