using System;

namespace LastFM.AspNetCore.Stats.Exceptions
{
    public class ReadingJsonException : Exception
    {
        public ReadingJsonException(string message) : base(message)
        {
        }
    }
}
