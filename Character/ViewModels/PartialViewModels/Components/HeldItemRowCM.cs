using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDProject.Entities.Character.ViewModels.PartialViewModels.Components
{
    public class HeldItemRowCM
    {
        public Guid Item_id { get; set; }
        public int Index { get; set; }

        public string Name { get; set; }

        public int Value { get; set; }
        public bool isEquipped { get; set; }
        public bool isEquippable { get; set; }

        public bool isAttuned { get; set; }
        public bool requiresAttunement { get; set; }

        public int Count { get; set; }

    }
}
