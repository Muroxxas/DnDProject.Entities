using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDProject.Entities.Character.ViewModels.PartialViewModels.Components
{
    public class SpellDetailsCM
    {
        public Guid Spell_id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Level { get; set; }

        public string School { get; set; }
        public string CastingTime { get; set; }

        public string Range { get; set; }

        public string Duration { get; set; }

        public bool RequiresVerbal { get; set; }

        public bool RequiresSomantic { get; set; }

        public bool RequiresMaterial { get; set; }

        public string Material { get; set; }

        public bool RequiresConcentration { get; set; }




        
    }
}
