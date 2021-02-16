using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDProject.Entities.Character.ViewModels.PartialViewModels.Components
{
    public class StatsCM
    {
        [Required(ErrorMessage = "{0} score cannot be null")]
        [Range(0,30,ErrorMessage ="{0} score must be between {1} and {2}")]
        public int Strength { get; set; }

        public int StrengthBonus { get; set; }

        [Required(ErrorMessage = "{0} score cannot be null")]
        [Range(0, 30, ErrorMessage = "{0} score must be between {1} and {2}")]
        public int Dexterity { get; set; }

        public int DexterityBonus { get; set; }

        [Required(ErrorMessage = "{0} score cannot be null")]
        [Range(0, 30, ErrorMessage = "{0} score must be between {1} and {2}")]
        public int Constitution { get; set; }

        public int ConstitutionBonus { get; set; }

        [Required(ErrorMessage = "{0} score cannot be null")]
        [Range(0, 30, ErrorMessage = "{0} score must be between {1} and {2}")]
        public int Wisdom { get; set; }

        public int WisdomBonus { get; set; }

        [Required(ErrorMessage = "{0} score cannot be null")]
        [Range(0, 30, ErrorMessage = "{0} score must be between {1} and {2}")]
        public int Charisma { get; set; }

        public int CharismaBonus { get; set; }
    }
}
