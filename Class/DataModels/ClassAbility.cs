using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDProject.Entities.Class.DataModels
{
    public class ClassAbility
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid ClassAbility_id { get; set; }


        public Guid Class_id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int LevelLearned { get; set; }
    }
}
