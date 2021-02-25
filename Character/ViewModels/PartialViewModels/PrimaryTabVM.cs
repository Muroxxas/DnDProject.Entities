using DnDProject.Entities.Character.ViewModels.PartialViewModels.Components;
using DnDProject.Entities.Races.ViewModels.PartialViewModels.ComponentModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDProject.Entities.Character.ViewModels.PartialViewModels
{
    public class PrimaryTabVM
    {
        [Required]
        public string Name { get; set; }

        public string Background { get; set; }

        public string Alignment { get; set; }

        public bool isInspired { get; set; }

        public int Exp { get; set; }

        [Required]
        public Guid Race { get; set; }
        public List<RaceListModel> Races { get; set; }

        public List<Guid> SelectedClasses { get; set; }
        public List<ClassesListModel> Classes { get; set; }

        [Required]
        public StatsCM Stats { get; set; }
        [Required]
        public CombatCM Combat { get; set; }
        [Required]
        public IsProficientCM IsProficient { get; set; }

    }
}
