using DnDProject.Entities.Items.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDProject.Entities.Character.ViewModels.PartialViewModels.Components
{
    public class HeldItemCM : Item
    {

        public int Index { get; set; }

        public string[] Tags { get; set; }

        public bool isEquipped { get; set; }

        public bool isAttuned { get; set; }

        public int Count { get; set; }

    }
}
