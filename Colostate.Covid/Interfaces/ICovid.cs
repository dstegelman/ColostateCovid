using Colostate.Covid.ResourceModels;
using System.Threading.Tasks;

namespace Colostate.Covid.Interfaces
{
    public interface ICovid
    {
        Task<ColostateCovidResourceModel> GetCovidData();
    }
}