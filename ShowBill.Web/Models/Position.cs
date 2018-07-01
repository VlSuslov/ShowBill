using Newtonsoft.Json;

namespace ShowBill.Web.Models
{
    public class Position
    {
        [JsonProperty("lat")]
        public double Lat { get; set; }
        [JsonProperty("lng")]
        public double Lng { get; set; }
    }
}
