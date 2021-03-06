﻿using System;

namespace ShowBill.Web.Models.EventModels
{
    public class EventOnMapViewModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public Position Position { get; set; }
        public string Photo { get; set; }
        public string Date { get; set; }
    }
}
