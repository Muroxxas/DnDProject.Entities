﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDProject.Entities.Character.ViewModels.PartialViewModels.Components
{
    public class KnownClassCM
    {
        public Guid class_id { get; set; }
        public List<ClassesListModel> Classes { get; set; }
    }
}
