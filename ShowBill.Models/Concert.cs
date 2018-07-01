using System.Collections.Generic;

namespace ShowBill.Models
{
    public class Concert : Event
    {
        public IList<Person> Artists { get; set; }
    }
}
