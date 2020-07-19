using System;

namespace LastFM.AspNetCore.Stats.Entities
{
    public class LastFMCredentials
    {
        public string APIKey { get; set; }
        public string SharedSecret { get; set; }

        public LastFMCredentials() {}

        public LastFMCredentials(string apiKey, string sharedSecret)
        {
            APIKey = apiKey ?? throw new ArgumentNullException(apiKey);
            SharedSecret = sharedSecret ?? throw new ArgumentNullException(sharedSecret);
        }
    }
}