using ShowBill.Models;
using System.Collections.Generic;

namespace ShowBill.Models
{
    public class MainModel
    {
        public IList<EventViewModel> Events { get; set; }
        public FilterModel Filter { get; set; }
    }
}
