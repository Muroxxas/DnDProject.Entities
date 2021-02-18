using DnDProject.Entities.Class.ViewModels.PartialViewModels.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDProject.Entities.Class.ViewModels
{
    public class CreateClassVM
    {
        [Required(ErrorMessage = "Enter the class' name")]
        [StringLength(120, ErrorMessage = "Class Names may be no longer than 120 characters.")]
        public string ClassName { get; set; }

        [Required(ErrorMessage = "Enter the class' description")]
        [StringLength(2500, ErrorMessage = "Class Descriptions may be no longer than 2,500 characters.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Please enter a hit die size")]
        [Range(6, 20, ErrorMessage = "Enter either 6, 8, 10, 12, or 20 for the hit die size")]
        public int HitDiceSize { get; set; }

        public bool IsCaster { get; set; }

        public float casterCapability { get; set; }

        public ClassAbilityVM[] ClassAbilities { get; set; }

        public SubclassVM[] Subclasses { get; set; }
    }
}
