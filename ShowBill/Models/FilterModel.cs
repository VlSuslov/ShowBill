using ShowBill.Data;
using System;

namespace ShowBill.Models
{
    public class FilterModel
    {
        public string Place { get; set; }
        public EventType? Type { get; set; }
        public DateTime? Date { get; set; }
    }
}
