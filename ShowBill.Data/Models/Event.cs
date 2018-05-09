using System.Text;

namespace ShowBill.Data
{
    public class Event
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Descriprion { get; set; }
        public Place Place { get; set; }
        public double? Cost { get; set; }
        public string Photo { get; set; }
    }
}
