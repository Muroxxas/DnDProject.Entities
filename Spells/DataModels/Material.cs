using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDProject.Entities.Spells.DataModels
{
    public class Material
    {
        [Key]
        public Guid Spell_id { get; set; }

        public string materials { get; set; }
    }
}
