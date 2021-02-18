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
    public class Currency
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid Character_id { get; set; }

        public int PlatinumPieces { get; set; }

        public int GoldPieces { get; set; }

        public int ElectrumPieces { get; set; }

        public int SilverPieces { get; set; }

        public int CopperPieces { get; set; }
    }
}
