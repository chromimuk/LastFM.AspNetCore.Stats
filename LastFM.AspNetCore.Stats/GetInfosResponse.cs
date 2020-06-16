using LastFM.AspNetCore.Stats.Models;
using LastFM.AspNetCore.Stats.Utils;
using Newtonsoft.Json;

public partial class GetInfosResponse
{
    [JsonProperty("user")]
    public UserModel User { get; set; }

    public static GetInfosResponse FromJson(string json) => JsonConvert.DeserializeObject<GetInfosResponse>(json, Converter.Settings);
}



//public static class Serialize
//{
//    public static string ToJson(this GetInfosResponse self) => JsonConvert.SerializeObject(self, Converter.Settings);
//}



