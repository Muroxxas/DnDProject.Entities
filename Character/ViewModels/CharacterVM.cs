﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDProject.Entities.Character.ViewModels
{
    public class CharacterVM
    {
        [Key, Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid Character_id { get; set; }

        [Required]
        [StringLength(45)]
        public string Name { get; set; }

        [StringLength(45)]
        public string Alignment { get; set; }

        public Guid Race_id { get; set; }

        public int Exp { get; set; }

        public string Background { get; set; }

        public bool Inspiration { get; set; }

        public CharacterVM() { }

    }
}
