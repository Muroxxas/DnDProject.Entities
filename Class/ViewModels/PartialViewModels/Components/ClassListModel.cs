using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDProject.Entities.Class.ViewModels.PartialViewModels.Components
{
    public class ClassListModel
    {
        public Guid Class_id { get; set; }

        public string ClassName { get; set; }

        public int ClassLevel { get; set; }
    }
}
