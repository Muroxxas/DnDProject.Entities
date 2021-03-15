using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDProject.Entities.Character.ViewModels.PartialViewModels.Components
{
    public class ProficiencyCM
    {
        public int ProficiencyBonus { get; set; }

        public IsProficientCM isProficient { get; set; }

        public SkillBonusCM TotalBonus { get; set; }
    }
}
