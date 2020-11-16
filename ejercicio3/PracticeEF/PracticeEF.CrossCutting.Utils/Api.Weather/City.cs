using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeEF.CrossCutting.Utils.Api.Weather
{
    public class City
    {
        public string _id { get; set; }
        public double dist { get; set; }
        public int lid { get; set; }
        public int fid { get; set; }
        public string name { get; set; }
        public string province { get; set; }
        public string lat { get; set; }
        public string lon { get; set; }
        public string zoom { get; set; }
        public int updated { get; set; }
        public Weather weather { get; set; }
    }
}
