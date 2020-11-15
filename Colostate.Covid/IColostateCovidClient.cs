using Colostate.Covid.Interfaces;

namespace Colostate.Covid
{
    public interface IColostateCovidClient
    {
        ICovid Covid { get; }
    }
}