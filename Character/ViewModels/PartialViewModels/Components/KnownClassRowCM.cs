using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDProject.Entities.Character.ViewModels.PartialViewModels.Components
{
    public class KnownClassRowCM
    {
        public Guid Class_id { get; set; }
        public Guid Subclass_id { get; set; }
        public int Level { get; set; }
        public int HitDice { get; set; }

        public List<ClassesListModel> Classes { get; set; }
        public List<SubclassesListModel> Subclasses { get; set; }
    }
}
