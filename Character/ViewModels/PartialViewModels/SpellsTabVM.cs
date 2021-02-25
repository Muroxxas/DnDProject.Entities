using DnDProject.Entities.Character.ViewModels.PartialViewModels.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDProject.Entities.Character.ViewModels.PartialViewModels
{
    public class SpellsTabVM
    {
        public SpellSlotsCM SpellSlots { get; set; }
        public KnownSpellCM[] KnownSpells { get; set; }
    }
}
