using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDProject.Entities.Class.ViewModels.PartialViewModels.Components.Data
{
    public class _SubclassAbility
    {
        public int SubclassIndex { get; set; }

        public int AbilityIndex { get; set; }

        [Required(ErrorMessage = "A subclass ability is missing a name")]
        [StringLength(120, ErrorMessage = "Subclass ability names may be no longer than 120 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "A subclass ability is missing it's description")]
        [StringLength(500, ErrorMessage = "Subclass ability descriptions may be no longer than 500 characters.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "A subclass ability is missing it's level requirement")]
        [Range(1, 20, ErrorMessage = "Subclass abilities must have a learned level ranging from 1 through 20")]
        public int LevelLearned { get; set; }

        public _SubclassAbility() { }
        public _SubclassAbility(int SubclassIndex, int AbilityIndex)
        {
            this.SubclassIndex = SubclassIndex;
            this.AbilityIndex = AbilityIndex;
        }
    }
}
