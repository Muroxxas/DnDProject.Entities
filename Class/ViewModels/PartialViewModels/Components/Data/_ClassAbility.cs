using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDProject.Entities.Class.ViewModels.PartialViewModels.Components.Data
{
    public class _ClassAbility
    {
        public int Index { get; set; }

        [Required(ErrorMessage = "A primary class ability is missing it's name")]
        [StringLength(120, ErrorMessage = "Ability names may be no longer than 120 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "A primary class ability is missing it's description")]
        [StringLength(500, ErrorMessage = "Class ability descriptions may be no longer than 500 characters.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "A primary class ability is missing it's level requirement")]
        [Range(1, 20, ErrorMessage = "Primary class abilities are all learned between level 1 through twenty.")]
        public int LevelLearned { get; set; }


        public _ClassAbility() { }
        public _ClassAbility(int Index)
        {
            this.Index = Index;
        }
    }
}
