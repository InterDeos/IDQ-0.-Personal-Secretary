using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IDQ_0__Personal_Secretary.Models.DataBase.Entities
{
    public class Project
    {
        public int Id { get; set; }
        public int Priority { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Project(string name, string description)
            :this(1, name, description) { }
        public Project(int priority, string name, string descripiton)
            :this(0, priority, name, descripiton) { }
        public Project(int id, int priority, string name, string description)
        {
            Id = id;
            Priority = priority;
            Name = name;
            Description = description;
        }
    }
}
