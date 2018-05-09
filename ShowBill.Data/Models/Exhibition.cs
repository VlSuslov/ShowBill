using System;

namespace ShowBill.Data
{
    public class Exhibition : Event
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
