using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDProject.Entities.Class.ViewModels
{
    class UpdateClassVM : CreateClassVM
    {
        [Key]
        [Required(ErrorMessage = "Select a class to alter")]
        public Guid Class_id { get; set; }
    }
}
