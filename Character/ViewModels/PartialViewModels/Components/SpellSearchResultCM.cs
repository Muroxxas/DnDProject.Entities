using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDProject.Entities.Character.ViewModels.PartialViewModels.Components
{
    public class SpellSearchResultCM
    {
        public IPagedList<foundSpellCM> foundSpells { get; set; }

        public string currentFilter { get; set; }

        public string currentGetSpellsBy { get; set; }

        public int currentPage { get; set; }
    }
}
