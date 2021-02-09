using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDProject.Entities.Items.DataModels
{
    public class Character_Item
    {
        public Guid Character_id { get; set; }
        public Guid Item_id { get; set; }
        public bool isEquipped { get; set; }
        public bool IsAttuned { get; set; }
        public int count { get; set; }
    }
}
