using System;

namespace Colostate.Covid.ResourceModels
{
    public class DailyCovidData
    {
        public DateTime ResultDate { get; set; }
        public int PositiveStudents { get; set; }
        public int PositiveStaff { get; set; }
    }
}