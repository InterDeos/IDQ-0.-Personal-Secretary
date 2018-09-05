using IDQ_0__Personal_Secretary.Models.DataBase.Entities.Targets;
using System.Collections.Generic;

namespace IDQ_0__Personal_Secretary.Models.DataBase.Entities
{
    public class BuisnessProcess
    {
        public int Id { get; set; }
        public int Priority { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int StageId { get; set; }
        public Stage Stage { get; set; }
        public BPTarget Target { get; set; }

        public List<Task> Tasks { get; set; }

        public BuisnessProcess Initialize()
        {
            Id = Id != 0 ? Id : Id;
            Priority = Priority != 0 ? Priority : 1;
            Name = Name ?? "Name BP";
            Description = Description ?? "";
            Tasks = Tasks ?? new List<Task>();

            return this;
        }
    }
}
