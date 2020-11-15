using Colostate.Covid.Interfaces;
using Colostate.Covid.Clients;

using RestSharp;

namespace Colostate.Covid
{
    public class ColostateCovidClient : IColostateCovidClient
    {
        public ColostateCovidClient()
        {
            RestClient client = new RestClient();
            Covid = new CovidClient(client);
        }
        
        public ICovid Covid { get; set; }
    }
}