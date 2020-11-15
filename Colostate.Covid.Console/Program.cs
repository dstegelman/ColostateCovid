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
            DailyCovidData dailyData = await covid.Covid.GetMostRecentCovidReport();
            System.Console.WriteLine(data.details.Count);
            System.Console.WriteLine(dailyData.ResultDate);
            System.Console.WriteLine(dailyData.PositiveStudents);
            System.Console.WriteLine(dailyData.PositiveStaff);
        }
    }
}
