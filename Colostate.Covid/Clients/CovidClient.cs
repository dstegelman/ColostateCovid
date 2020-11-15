using Colostate.Covid.Interfaces;
using Colostate.Covid.ResourceModels;
using RestSharp;
using System.Threading.Tasks;


namespace Colostate.Covid.Clients
{
    public class CovidClient : ICovid
    {
        private RestClient _client { get; set; }

        public CovidClient(RestClient client)
        {
            _client = client;
        }

        public async Task<ColostateCovidResourceModel> GetCovidData()
        {
            var request = new RestRequest("https://wsnet2.colostate.edu/cwis0/WebComUtils/api/Health/GetCovidData");
            var response = await _client.ExecuteAsync<ColostateCovidResourceModel>(request);
            if(response.IsSuccessful)
            {
                return response.Data;
            }
            throw new System.Exception("Done Broked");
        }
    }
}