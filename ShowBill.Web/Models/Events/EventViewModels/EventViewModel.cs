using ShowBill.Models;
using System;
using System.Collections.Generic;

namespace ShowBill.Web.Models.EventModels
{
    public class EventViewModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Descriprion { get; set; }
        public Place Place { get; set; }
        public double? Cost { get; set; }
        public EventType Type { get; set; }
        public int Raiting { get; set; }
        public List<string> Photos { get; set; }
        public string Date { get; set; }
        public List<string> Seanses { get; set; }
    }
}
