using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeEF.CrossCutting.Utils.Api.Weather
{
    public class Weather
    {
        public int day { get; set; }
        public int morning_temp { get; set; }
        public int morning_id { get; set; }
        public string morning_desc { get; set; }
        public int afternoon_temp { get; set; }
        public int afternoon_id { get; set; }
        public string afternoon_desc { get; set; }
    }
}
