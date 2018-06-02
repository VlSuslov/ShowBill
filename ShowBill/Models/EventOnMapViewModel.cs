using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShowBill.Models
{
    public class EventOnMapViewModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public Position Position { get; set; }
        public string Photo { get; set; }
        public string Date { get; set; }
        public string Duration { get; set; }
    }

    public class Position
    {
        [JsonProperty("lat")]
        public double Lat { get; set; }
        [JsonProperty("lng")]
        public double Lng { get; set; }
    }
}
