﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDProject.Entities.Spells.DataModels
{
    public class Spell_Class
    {
        [Key, Column(Order = 0)]
        public Guid Spell_id { get; set; }

        [Key, Column(Order = 1)]
        public Guid Class_id { get; set; }
    }
}
