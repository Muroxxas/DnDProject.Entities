using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDProject.Entities.Character.DataModels
{
    public class Note
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid Note_id { get; set; }

        public Guid Character_id { get; set; }

        public string Name { get; set; }

        public string Contents { get; set; }

        public Note() { }
    }
}
