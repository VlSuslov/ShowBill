using System;
using System.Collections.Generic;
using System.Linq;

namespace ShowBill.Models.EventModels
{
    public class PerformanceViewModel: EventViewModel
    {
        public List<string> Actors { get; set; }
        public string Director { get; set; }
        public List<string> Authors { get; set; }
    }
}
