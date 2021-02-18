using DnDProject.Entities.Class.ViewModels.PartialViewModels.Components.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDProject.Entities.Class.ViewModels.PartialViewModels.Components
{
    public class SubclassAbilityVM : _SubclassAbility
    {
        public Guid SubclassAbility_id { get; set; }

        public SubclassAbilityVM() { }
        public SubclassAbilityVM(int SubclassIndex, int AbilityIndex)
        {
            this.SubclassIndex = SubclassIndex;
            this.AbilityIndex = AbilityIndex;
        }
    }
}
