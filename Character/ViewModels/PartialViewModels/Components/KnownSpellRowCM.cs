using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDProject.Entities.Character.ViewModels.PartialViewModels.Components
{
    public class KnownSpellRowCM
    {
        public Guid Spell_id { get; set; }

        public int Index { get; set; }

        public string Name { get; set; }

        public string School { get; set; }

        public int Level { get; set; }

        public bool isPrepared { get; set; }



    }
}
