using GetTemperatureOverHTTP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetTemperatureOverHTTP.Services
{
    public interface IApiService
    {
        
        TemperatureModel Get();
        
    }
}

