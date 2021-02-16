using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDProject.Entities.Character.ViewModels.PartialViewModels.Components
{
    public class CombatCM
    {
        public int MaxHP { get; set; }

        public int CurrentHP { get; set; }

        public int TempHP { get; set; }

        public int ArmorClass { get; set; }

        public int InitiativeBonus { get; set; }

        public int MovementSpeed { get; set; }

        public int DeathSaveSuccesses { get; set; }

        public int DeathSaveFails { get; set; }
    }
}
