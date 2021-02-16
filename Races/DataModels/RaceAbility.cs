using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDProject.Entities.Races.DataModels
{
    public class RaceAbility
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid RaceAbility_id { get; set; }

        public Guid Race_id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}
