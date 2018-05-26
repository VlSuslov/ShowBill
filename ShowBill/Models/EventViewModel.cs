using Microsoft.AspNetCore.Mvc.Rendering;
using ShowBill.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShowBill.Models
{
    public class EventViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Descriprion { get; set; }
        public string Place { get; set; }
        public double? Cost { get; set; }
        public EventType Type { get; set; }
        public List<string> Photos { get; set; }
        public string Date { get; set; }
        public List<string> Seanses { get; set; }
    }
}
