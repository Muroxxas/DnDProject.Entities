using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDProject.Entities.Character.ViewModels.PartialViewModels.Components
{
    public class ItemSearchResultCM
    {
        public IPagedList<foundItemCM> foundItems { get; set; }

        public string currentFilter { get; set; }

        public string currentGetItemsBy { get; set; }

        public int currentPage { get; set; }
    }
}
