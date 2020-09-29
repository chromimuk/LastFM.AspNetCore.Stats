using System;

namespace LastFM.AspNetCore.Stats.Exceptions
{
    public class DataAccessException : Exception
    {
        public DataAccessException(string message) : base(message)
        {

        }
    }
}
