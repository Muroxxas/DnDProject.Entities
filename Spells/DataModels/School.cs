﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDProject.Entities.Spells.DataModels
{
    public class School
    {
        [Key]
        public Guid School_id { get; set; }

        public string Name { get; set; }
    }
}
