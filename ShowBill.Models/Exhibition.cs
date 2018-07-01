using System.Collections.Generic;

namespace ShowBill.Models
{
    public class Exhibition : Event
    {
        public IList<Person> Artists { get; set; }
    }
}
