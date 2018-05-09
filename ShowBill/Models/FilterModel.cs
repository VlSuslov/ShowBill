using ShowBill.Data;

namespace ShowBill.Models
{
    public class FilterModel
    {
        public string Place { get; set; }
        public EventType? Type { get; set; }
        public string Date { get; set; }
    }
}
