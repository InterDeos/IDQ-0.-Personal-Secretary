namespace IDQ_0__Personal_Secretary.Models.DataBase.Entities.Targets
{
    public class TaskTarget:Target
    {
        public int TaskId { get; set; }
        public Task Task { get; set; }

        public TaskTarget Initialize()
        {
            Id = Id != 0 ? Id : Id;
            IsAchieved = IsAchieved ? IsAchieved : IsAchieved;
            Name = Name ?? "Name Target";

            return this;
        }
    }
}
