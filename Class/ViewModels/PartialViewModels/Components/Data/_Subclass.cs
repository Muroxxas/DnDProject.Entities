using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDProject.Entities.Class.ViewModels.PartialViewModels.Components.Data
{
    public class _Subclass
    {
        public int Index { get; set; }

        [Required(ErrorMessage = "A Subclass is missing it's name")]
        [StringLength(120, ErrorMessage = "Subclass names may be no longer than 120 characters.")]
        public string SubclassName { get; set; }

        [Required(ErrorMessage = "A Subclass is missing it's description")]
        [StringLength(500, ErrorMessage = "Subclass descriptions may be no longer than 500 characters.")]
        public string Description { get; set; }

        public SubclassAbilityVM[] SubclassAbilities { get; set; }


        public _Subclass() { }
        public _Subclass(int Index)
        {
            this.Index = Index;
        }
    }
}
