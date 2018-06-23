using System.Collections.Generic;

namespace ShowBill.Models
{
    public class Performance : Event
    {
        public IList<Person> Actors { get; set; }
        public Person Director { get; set; }
        public IList<Person> Authors { get; set; }
    }
}
