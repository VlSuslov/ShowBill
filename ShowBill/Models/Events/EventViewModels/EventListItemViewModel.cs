using System;

namespace ShowBill.Models.EventModels
{
    public class EventListItemViewModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Descriprion { get; set; }
        public string Place { get; set; }
        public string Photo { get; set; }
        public string Date { get; set; }
    }
}
