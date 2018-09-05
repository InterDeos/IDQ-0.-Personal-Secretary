using IDQ_0__Personal_Secretary.Models.DataBase;
using IDQ_0__Personal_Secretary.Models.DataBase.Entities;
using IDQ_0__Personal_Secretary.Models.DataBase.Entities.Targets;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace IDQ_0__Personal_Secretary.Tests
{
    public class DataBaseTests
    {
        [Fact]
        public void ClearDataBaseProjectsEmpty()
        {
            //Arrange
            List<Project> projects;

            //Act
            using(DBContext context = GetContext())
            {
                var db = new DataBase(context);

                db.ClearDataBase();
                projects = db.GetAllProjects();
            }

            //Assert
            Assert.Empty(projects);
        }
        [Fact]
        public void ClearDataBaseStagesEmpty()
        {
            // Arrange
            List<Stage> stages;

            // Act
            using (DBContext context = GetContext())
            {
                var db = new DataBase(context);

                db.ClearDataBase();
                stages = db.GetAllStage();
            }

            //Assert
            Assert.Empty(stages);
        }
        [Fact]
        public void ClearDataBaseBPsEmpty()
        {
            // Arrange
            List<BuisnessProcess> bps;

            // Act
            using (DBContext context = GetContext())
            {
                var db = new DataBase(context);

                db.ClearDataBase();
                bps = db.GetAllBP();
            }

            //Assert
            Assert.Empty(bps);
        }
        [Fact]
        public void ClearDataBaseTasksEmpty()
        {
            // Arrange
            List<Task> tasks;

            // Act
            using (DBContext context = GetContext())
            {
                var db = new DataBase(context);

                db.ClearDataBase();
                tasks = db.GetAllTask();
            }

            //Assert
            Assert.Empty(tasks);
        }
        [Fact]
        public void ClearDataBaseProjectTargetsEmpty()
        {
            // Arrange
            List<ProjectTarget> targets;

            // Act
            using (DBContext context = GetContext())
            {
                var db = new DataBase(context);

                db.ClearDataBase();
                targets = db.GetAllProjectTargets();
            }

            //Assert
            Assert.Empty(targets);
        }
        [Fact]
        public void ClearDataBaseStageTargetsEmpty()
        {
            // Arrange
            List<StageTarget> targets;

            // Act
            using (DBContext context = GetContext())
            {
                var db = new DataBase(context);

                db.ClearDataBase();
                targets = db.GetAllStageTarget();
            }

            //Assert
            Assert.Empty(targets);
        }
        [Fact]
        public void ClearDataBaseBPTargetsEmpty()
        {
            // Arrange
            List<BPTarget> targets;

            // Act
            using (DBContext context = GetContext())
            {
                var db = new DataBase(context);

                db.ClearDataBase();
                targets = db.GetAllBPTargets();
            }

            //Assert
            Assert.Empty(targets);
        }
        [Fact]
        public void ClearDataBaseTaskTargetsEmpty()
        {
            // Arrange
            List<TaskTarget> targets;

            // Act
            using (DBContext context = GetContext())
            {
                var db = new DataBase(context);

                db.ClearDataBase();
                targets = db.GetAllTaskTargets();
            }

            //Assert
            Assert.Empty(targets);
        }

        [Fact]
        public void AddProject()
        {
            //Arrange
            Project project = new Project { Name = "Test Project" };
            List<Project> result;
            using(var context = GetContext())
            {
                var db = new DataBase(context);
                db.ClearDataBase();

                //Act
                db.AddProject(project);

                result = db.GetAllProjects();
            }

            //Assert
            Assert.True(result.First().Name == "Test Project");
        }
        [Fact]
        public void UpdateProject()
        {
            //Arrange
            Project project = new Project { Name = "Test Project" };
            Project result;
            using (var context = GetContext())
            {
                var db = new DataBase(context);
                db.ClearDataBase();
                db.AddProject(project);
                project = new Project { Id = db.GetAllProjects().Last().Id, Name = "Updated Test Project", Priority = 20 }.Initialize();

                //Act
                db.UpdateProject(project);

                result = db.GetAllProjects().Last().Initialize();
            }

            //Assert
            Assert.True(result.Id == project.Id && 
                result.Name == project.Name && 
                result.Priority == project.Priority &&
                result.Description == project.Description);
        }
        [Fact]
        public void GetProjectByIdNull()
        {
            //Arrange
            Project project = new Project { Name = "Test Project" };
            Project result;
            using (var context = GetContext())
            {
                var db = new DataBase(context);
                db.ClearDataBase();
                db.AddProject(project);

                //Act
                result = db.GetProjectById(0);
            }

            //Assert
            Assert.Null(result);
        }
        [Fact]
        public void GetProjectById()
        {
            //Arrange
            Project project = new Project { Name = "Test Project" };
            Project result;
            using (var context = GetContext())
            {
                var db = new DataBase(context);
                db.ClearDataBase();
                db.AddProject(project);
                var projects = db.GetAllProjects();
                //Act
                result = db.GetProjectById(projects.Last().Id);
            }

            //Assert
            Assert.Equal<Project>(result, project);
        }
        /*[Fact]
        public void AddTargetInProject()
        {
            //Arrange
            Project project = new Project { Name = "Test Project" };
            ProjectTarget target = new ProjectTarget { Name = "Test Target for Project", IsAchieved = false };
            Project result;
            using (var context = GetContext())
            {
                var db = new DataBase(context);
                db.ClearDataBase();
                db.AddProject(project);

                //Act
                db.AddTargetInProject(2, target);
                result = db.GetProjectById(2);
                target = new ProjectTarget { Id = 1, Name = "Test Target for Project", IsAchieved = false, ProjectId = 2 };
            }

            //Assert
            Assert.Equal<ProjectTarget>(result.Targets.First(), target);
        }*/

        private DBContext GetContext()
        {
            string connection = "Server=(localdb)\\mssqllocaldb;Database=TestDB;Trusted_Connection=True;MultipleActiveResultSets=true";
            return new DBContext(new DbContextOptionsBuilder<DBContext>().UseSqlServer(connection).Options);
        }
    }
}
