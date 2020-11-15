using System;
namespace Colostate.Covid.Exceptions
{
    public class FailedToFetchCovidData : Exception
    {
        public FailedToFetchCovidData() : base()
        {

        }

        public FailedToFetchCovidData(string message) : base(message)
        {

        }

        public FailedToFetchCovidData(string message, Exception inner) : base(message, inner)
        {
            
        }
    }
}