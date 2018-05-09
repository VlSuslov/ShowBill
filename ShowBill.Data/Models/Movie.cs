using System.Collections.Generic;

namespace ShowBill.Data
{
    public class Movie : Event
    {
        public List<Person> Actors { get; set; }
        public string Director { get; set; }
        public List<Person> Composers { get; set; }
        public List<Person> Screenwriters { get; set; }
        public List<Person> Producers { get; set; }
        public List<Date> Dates { get; set; }
    }
}
