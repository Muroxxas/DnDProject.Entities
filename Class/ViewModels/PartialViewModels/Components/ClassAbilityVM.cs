using DnDProject.Entities.Class.ViewModels.PartialViewModels.Components.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDProject.Entities.Class.ViewModels.PartialViewModels.Components
{
    public class ClassAbilityVM : _ClassAbility
    {
        public Guid ClassAbility_id { get; set; }

        public ClassAbilityVM() { }

        public ClassAbilityVM(int Index)
        {
            this.Index = Index;
        }
    }
}
