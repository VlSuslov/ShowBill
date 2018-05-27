using System;
using System.Collections.Generic;

namespace ShowBill.Data
{
    public class Event
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Descriprion { get; set; }
        public Place Place { get; set; }
        public double? Cost { get; set; }
        public List<Photo> Photos { get; set; }
        public int Raiting { get; set; }
        public List<Date> Dates { get; set; }
        public TimePeriod Duration { get; set; }
        public List<TimePeriod> Seanses { get; set; }
    }
}
