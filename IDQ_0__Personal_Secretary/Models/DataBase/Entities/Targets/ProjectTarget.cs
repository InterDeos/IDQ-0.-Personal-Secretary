namespace IDQ_0__Personal_Secretary.Models.DataBase.Entities.Targets
{
    public class ProjectTarget: Target
    {
        public int ProjectId { get; set; }
        public Project Project { get; set; }
    }
}
