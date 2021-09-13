using System.Collections.Generic;

namespace CDM.Models
{
    public class LocationViewModel
    {
        public string SearchText { get; set; }
        public IEnumerable<LocationModel> LocationList { get; set; }
        public PagingModel pagingModel { get; set; }
        public string SortBy { get; set; }
    }
}