using DnDProject.Entities.Spells.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDProject.Entities.Character.ViewModels.PartialViewModels.Components
{
    public class KnownSpellCM : Spell
    {
        public string Material { get; set; }

        public string[] castableBy { get; set; }

        public bool isPrepared { get; set; }

        public int Index { get; set; }
    }
}
