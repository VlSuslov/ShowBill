using System.Collections.Generic;

namespace ShowBill.Data
{
    public class Concert : Event
    {
        public List<Person> Artists { get; set; }
    }
}
