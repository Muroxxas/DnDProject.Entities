using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDProject.Entities.Spells.DataModels
{
    public class Spell
    {
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.None)]
            public Guid Spell_id { get; set; }

            [Required]
            public string Name { get; set; }

            [Required]
            public string Description { get; set; }

            [Required]
            public int Level { get; set; }

            [Required]
            public Guid School_id { get; set; }

            [Required]
            [StringLength(45)]
            public string CastingTime { get; set; }

            [Required]
            [StringLength(45)]
            public string Range { get; set; }

            [Required]
            [StringLength(45)]
            public string Duration { get; set; }

            [Required]
            public bool RequiresVerbal { get; set; }

            [Required]
            public bool RequiresSomantic { get; set; }

            [Required]
            public bool RequiresMaterial { get; set; }

            [Required]
            public bool RequiresConcentration { get; set; }
    }
}
