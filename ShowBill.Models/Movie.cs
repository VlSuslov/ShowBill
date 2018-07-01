using System.Collections.Generic;

namespace ShowBill.Models
{
    public class Movie : Event
    {
        public IList<Person> Actors { get; set; }
        public Person Director { get; set; }
        public IList<Person> Composers { get; set; }
        public IList<Person> Screenwriters { get; set; }
        public IList<Person> Producers { get; set; }
    }
}
