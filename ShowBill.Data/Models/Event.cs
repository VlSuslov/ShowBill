using System;

namespace ShowBill.Data
{
    public class Event
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Descriprion { get; set; }
        public Place Place { get; set; }
        public double? Cost { get; set; }
        public Photo[] Photos { get; set; }
        public int Raiting { get; set; }
    }
}
