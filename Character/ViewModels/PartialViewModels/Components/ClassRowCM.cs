using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDProject.Entities.Character.ViewModels.PartialViewModels.Components
{
    public class ClassRowCM
    {

        public int Index { get; set; }

        [Required(ErrorMessage ="A class row does not have a selected class!")]
        public Guid SelectedClass_id { get; set; }
        public ClassesListModel[] playableClasses { get; set; }

        [Required(ErrorMessage ="A class row does not have a level set!")]
        [Range(1,29,ErrorMessage ="Class levels can range from 1 to 29.")]
        public int Level { get; set; }

        public int RemainingHitDice { get; set; }
        public SubclassesListModel[] subclasses { get; set; }

        public Guid SelectedSubclass_id { get; set; }

    }
}
