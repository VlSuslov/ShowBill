using ShowBill.Models;
using System;

namespace ShowBill.Web.Models
{
    public class Filter
    {
        public string Place { get; set; }
        public EventType? Type { get; set; }
        public DateTime? Date { get; set; }
    }
}
