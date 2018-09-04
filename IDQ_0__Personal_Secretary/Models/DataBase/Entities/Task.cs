using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
    }
}
