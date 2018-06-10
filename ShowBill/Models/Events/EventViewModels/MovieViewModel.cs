using System.Collections.Generic;

namespace ShowBill.Models.EventModels
{
    public class MovieViewModel: EventViewModel
    {
        public List<string> Actors { get; set; }
        public string Director { get; set; }
        public List<string> Composers { get; set; }
        public List<string> Screenwriters { get; set; }
        public List<string> Producers { get; set; }
    }
}
