using System;

namespace LastFM.AspNetCore.Stats.Entities
{
    public class LastFMCredentials
    {
        public string APIKey { get; set; }
        public string SharedSecret { get; set; }

        public LastFMCredentials(string apiKey, string sharedSecret)
        {
            if (apiKey == null)
                throw new ArgumentNullException(apiKey);
            if (sharedSecret == null)
                throw new ArgumentNullException(sharedSecret);

            APIKey = apiKey;
            SharedSecret = sharedSecret;
        }
    }
}