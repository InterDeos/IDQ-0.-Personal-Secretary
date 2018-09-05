using IDQ_0__Personal_Secretary.Models.DataBase.Entities.Targets;
using System.Collections.Generic;

namespace IDQ_0__Personal_Secretary.Models.DataBase.Entities
{
    public class Task
    {
        public int Id { get; set; }
        public int Priority { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int BuisnessProcessId { get; set; }
        public BuisnessProcess BuisnessProcess { get; set; }

        public List<TaskTarget> Targets { get; set; }

        public Task Initialize()
        {
            Id = Id != 0 ? Id : Id;
            Priority = Priority != 0 ? Priority : 1;
            Name = Name ?? "Name Task";
            Description = Description ?? "";
            Targets = Targets ?? new List<TaskTarget>();

            return this;
        }
    }
}
