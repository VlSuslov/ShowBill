using System;
using System.Collections.Generic;

namespace ShowBill.Data
{
    public class Exhibition : Event
    {
        public List<Person> Artists { get; set; }
    }
}
