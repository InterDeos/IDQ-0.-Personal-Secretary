using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IDQ_0__Personal_Secretary.Models.DataBase.Entities
{
    public class Stage
    {
        public int Id { get; set; }
        public int Priority { get; set; }
        public string Name { get; set; }

        public int ProjectId { get; set; }
        public Project Project { get; set; }
    }
}
