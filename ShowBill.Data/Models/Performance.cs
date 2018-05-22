using System.Collections.Generic;

namespace ShowBill.Data
{
    public class Performance : Event
    {
        public List<Person> Actors { get; set; }
        public Person Director { get; set; }
        public List<Person> Authors { get; set; }
    }
}
