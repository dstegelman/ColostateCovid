using Colostate.Covid.Interfaces;
using Colostate.Covid.ResourceModels;
using Colostate.Covid.Exceptions;
using RestSharp;
using System.Linq;
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
            throw new FailedToFetchCovidData("Failed to fetch all covid data");
        }

        public async Task<DailyCovidData> GetMostRecentCovidReport()
        {
            var request = new RestRequest("https://wsnet2.colostate.edu/cwis0/WebComUtils/api/Health/GetCovidData");
            var response = await _client.ExecuteAsync<ColostateCovidResourceModel>(request);
            if(response.IsSuccessful)
            {
                return response.Data.details.OrderByDescending(s => s.ResultDate).FirstOrDefault();
            }
            throw new FailedToFetchCovidData("Failed to fetch most recent covid data");
        }
    }
}