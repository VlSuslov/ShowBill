using System;
using System.Collections.Generic;

namespace ShowBill.Models
{
    public class Event
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Descriprion { get; set; }
        public Place Place { get; set; }
        public double? Cost { get; set; }
        public IList<Photo> Photos { get; set; }
        public int Raiting { get; set; }
        public IList<Date> Dates { get; set; }
        public TimePeriod Duration { get; set; }
        public IList<TimePeriod> Seanses { get; set; }
    }
}
