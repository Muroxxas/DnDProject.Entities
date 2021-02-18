using DnDProject.Entities.Class.ViewModels.PartialViewModels.Components.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDProject.Entities.Class.ViewModels.PartialViewModels.Components
{
    public class SubclassVM : _Subclass
    {
        public Guid Subclass_id { get; set; }

        public SubclassVM() { }
        public SubclassVM(int Index)
        {
            this.Index = Index;
            this.SubclassAbilities = new SubclassAbilityVM[1];
            this.SubclassAbilities[0] = new SubclassAbilityVM(Index, 0);
        }
    }
}
