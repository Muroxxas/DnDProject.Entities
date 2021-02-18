using DnDProject.Entities.Character.ViewModels.PartialViewModels.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDProject.Entities.Character.ViewModels.PartialViewModels
{
    public class InventoryTabVM
    {
        public virtual MoneyCM Money { get; set; }

        public HeldItemCM[] Items { get; set; }
    }
}
