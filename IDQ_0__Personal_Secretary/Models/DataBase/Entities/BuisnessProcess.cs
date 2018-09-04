﻿using System;
using System.Collections.Generic;
using System.Linq;

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

        public List<Task> Tasks { get; set; }
    }
}