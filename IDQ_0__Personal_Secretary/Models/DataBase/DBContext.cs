using IDQ_0__Personal_Secretary.Models.DataBase.Entities;
using IDQ_0__Personal_Secretary.Models.DataBase.Entities.Targets;
using Microsoft.EntityFrameworkCore;

namespace IDQ_0__Personal_Secretary.Models.DataBase
{
    public class DBContext: DbContext
    {
        public DbSet<Project> Projects { get; set; }
        public DbSet<Stage> Stages { get; set; }
        public DbSet<BuisnessProcess> BPs { get; set; }
        public DbSet<Task> Tasks { get; set; }

        public DbSet<ProjectTarget> ProjectTargets { get; set; }
        public DbSet<StageTarget> StageTargets { get; set; }
        public DbSet<BPTarget> BPTargets { get; set; }
        public DbSet<TaskTarget> TaskTargets { get; set; }

        public DBContext(DbContextOptions<DBContext> options)
            :base(options)
        {
            Database.EnsureCreated();
        }
    }
}
