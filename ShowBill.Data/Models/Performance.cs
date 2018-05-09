using System.Collections.Generic;

namespace ShowBill.Data
{
    public class Performance : Event
    {
        public List<Person> Actors { get; set; }
        public string Director { get; set; }
        public List<Person> Autors { get; set; }
    }
}
