using System.Collections.Generic;

namespace ShowBill.Data
{
    public class Movie : Event
    {
        public List<Person> Actors { get; set; }
        public Person Director { get; set; }
        public List<Person> Composers { get; set; }
        public List<Person> Screenwriters { get; set; }
        public List<Person> Producers { get; set; }
    }
}
