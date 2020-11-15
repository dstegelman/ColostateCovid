using System;
using System.Threading.Tasks;
using Colostate.Covid.Interfaces;
using Colostate.Covid.Clients;
using Colostate.Covid.ResourceModels;

namespace Colostate.Covid.Console
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            System.Console.WriteLine("Hello World!");
            IColostateCovidClient covid = new ColostateCovidClient();
            ColostateCovidResourceModel data = await covid.Covid.GetCovidData();
            System.Console.WriteLine(data.details.Count);
        }
    }
}
