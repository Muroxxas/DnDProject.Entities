using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDProject.Entities.Class.DataModels
{
    public class Character_Class_Subclass
    {
        [Key, Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid Character_id { get; set; }

        [Key, Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid Class_id { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid Subclass_id { get; set; }

        public int ClassLevel { get; set; }

        public int RemainingHitDice { get; set; }
    }
}
