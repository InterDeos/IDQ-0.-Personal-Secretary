using IDQ_0__Personal_Secretary.Models.DataBase.Entities.Targets;
using System.Collections.Generic;

namespace IDQ_0__Personal_Secretary.Models.DataBase.Entities
{
    public class Stage
    {
        public int Id { get; set; }
        public int Priority { get; set; }
        public string Name { get; set; }

        public int ProjectId { get; set; }
        public Project Project { get; set; }

        public List<StageTarget> Targets { get; set; }
        public List<BuisnessProcess> BPs { get; set; }
    }
}
