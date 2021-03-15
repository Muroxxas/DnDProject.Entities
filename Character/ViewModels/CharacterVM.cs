using DnDProject.Entities.Character.ViewModels.PartialViewModels;
using System;
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


        public PrimaryTabVM PrimaryTab { get; set; }

        public NoteTabVM NotesTab { get; set; }

        public InventoryTabVM InventoryTab { get; set; }

        public SpellsTabVM SpellsTab { get; set; }

        public CharacterVM() { }

    }
}
