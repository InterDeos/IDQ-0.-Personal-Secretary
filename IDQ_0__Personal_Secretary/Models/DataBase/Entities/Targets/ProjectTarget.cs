namespace IDQ_0__Personal_Secretary.Models.DataBase.Entities.Targets
{
    public class ProjectTarget: Target
    {
        public int ProjectId { get; set; }
        public Project Project { get; set; }

        public ProjectTarget Initialize()
        {
            Id = Id != 0 ? Id : Id;
            IsAchieved = IsAchieved ? IsAchieved: IsAchieved;
            Name = Name ?? "Name Target";

            return this;
        }
    }
}
