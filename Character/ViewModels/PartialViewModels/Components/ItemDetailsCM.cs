using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDProject.Entities.Character.ViewModels.PartialViewModels.Components
{
    public class ItemDetailsCM
    {
        public Guid Item_id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string [] Tags { get; set; }

        public int Value { get; set; }

        public bool isEquippable { get; set; }

        public bool isConsumable { get; set; }

        public bool requiresAttunement { get; set; }

    }
}
