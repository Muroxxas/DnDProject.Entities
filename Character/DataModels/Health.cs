using DnDProject.Entities.CustomAttributes.Mapping;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDProject.Entities.Character.DataModels
{
    public class Health
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid Character_id { get; set; }

        [Required]
        public int MaxHP { get; set; }

        public int CurrentHP { get; set; }

        public int TempHP { get; set; }

        public int DeathSaveSuccesses { get; set; }

        public int DeathSaveFails { get; set; }

        public Health() { }
    }
}
