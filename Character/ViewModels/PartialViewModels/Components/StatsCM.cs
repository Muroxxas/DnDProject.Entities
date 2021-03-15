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

        [Required(ErrorMessage = "{0} score cannot be null")]
        [Range(0, 30, ErrorMessage = "{0} score must be between {1} and {2}")]
        public int Dexterity { get; set; }


        [Required(ErrorMessage = "{0} score cannot be null")]
        [Range(0, 30, ErrorMessage = "{0} score must be between {1} and {2}")]
        public int Constitution { get; set; }

        [Required(ErrorMessage = "{0} score cannot be null")]
        [Range(0, 30, ErrorMessage = "{0} score must be between {1} and {2}")]
        public int Intelligence { get; set; }

        [Required(ErrorMessage = "{0} score cannot be null")]
        [Range(0, 30, ErrorMessage = "{0} score must be between {1} and {2}")]
        public int Wisdom { get; set; }


        [Required(ErrorMessage = "{0} score cannot be null")]
        [Range(0, 30, ErrorMessage = "{0} score must be between {1} and {2}")]
        public int Charisma { get; set; }


        public StatBonusCM Bonus { get; set; }
    }
}
