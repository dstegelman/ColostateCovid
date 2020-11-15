using System.Collections.Generic;

namespace Colostate.Covid.ResourceModels
{
    public class ColostateCovidResourceModel
    {
        public List<DailyCovidData> details { get; set; }
        public LarimerDataModel larimerData { get; set; }
        public ColoradoDataModel coloradoData { get; set; }
        public CsuDataModel csuData { get; set; }
    }
}