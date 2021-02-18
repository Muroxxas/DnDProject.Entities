using DnDProject.Entities.CustomAttributes.Mapping;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDProject.Entities.Character.ViewModels.PartialViewModels.Components
{
    public class NoteCM
    {
        [Key]
        [NotMappedFrom]
        public Guid Note_id { get; set; }

        public string Name { get; set; }

        public string Contents { get; set; }
    }
}
