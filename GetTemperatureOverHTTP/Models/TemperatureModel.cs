using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetTemperatureOverHTTP.Models
{
    public class TemperatureModel
    {
        public double Value { get; set; }
        public double Temperature { get; set; }
        public double Voltage { get; set; }
    }
}
