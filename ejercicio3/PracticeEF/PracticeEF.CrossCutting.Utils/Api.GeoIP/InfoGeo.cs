﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeEF.CrossCutting.Utils.Api.GeoIP
{
    public class InfoGeo
    {
        [JsonProperty("location")]
        public Location Location { get; set; }
    }
}
