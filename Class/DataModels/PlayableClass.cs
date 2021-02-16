using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDProject.Entities.Class.DataModels
{
    public class PlayableClass
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid Class_id { get; set; }

        [Required]
        [StringLength(45)]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public bool IsCaster { get; set; }

        [Required]
        public int HitDiceSize { get; set; }

        public double casterCapability { get; set; }
    }
}
