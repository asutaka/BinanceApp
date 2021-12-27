using Newtonsoft.Json;

namespace BinanceApp.Model.ENTITY
{
    public class TimeModel
    {
        [JsonProperty("timestamp")]
        public long TimeStamp { get; set; }
    }
}
