using IDQ_0__Personal_Secretary.Models.DataBase.Entities.Targets;
using System;
using System.Collections.Generic;

namespace IDQ_0__Personal_Secretary.Models.DataBase.Entities
{
    public class Project
    {
        public int Id { get; set; }
        public int Priority { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public List<ProjectTarget> Targets { get; set; }
        public List<Stage> Stages { get; set; }

        public Project Initialize()
        {
            Id = Id != 0 ? Id : Id;
            Priority = Priority != 0 ? Priority : 1;
            Name = Name ?? "Name project";
            Description = Description ?? "";
            Targets = Targets ?? new List<ProjectTarget>();
            Stages = Stages ?? new List<Stage>();

            return this;
        }
    }
}
