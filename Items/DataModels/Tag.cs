using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDProject.Entities.Items.DataModels
{
    public class Tag
    {
        [Key]
        public Guid Tag_id { get; set; }

        public string TagName { get; set; }
    }
}
