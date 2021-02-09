using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDProject.Entities.Items.DataModels
{
    public class Item_Tag
    {
        [Key, Column(Order = 0)]
        public Guid Item_id { get; set; }

        [Key, Column(Order = 1)]
        public Guid Tag_id { get; set; }
    }
}
