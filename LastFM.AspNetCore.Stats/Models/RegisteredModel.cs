using LastFM.AspNetCore.Stats.Utils;
using Newtonsoft.Json;

namespace LastFM.AspNetCore.Stats.Models
{
public class RegisteredModel
{
    [JsonProperty("unixtime")]
    [JsonConverter(typeof(ParseStringConverter))]
    public long Unixtime { get; set; }

    [JsonProperty("#text")]
    public long Text { get; set; }
}



//public static class Serialize
//{
//    public static string ToJson(this GetInfosResponse self) => JsonConvert.SerializeObject(self, Converter.Settings);
//}
}