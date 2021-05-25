using GetTemperatureOverHTTP.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace GetTemperatureOverHTTP.Services
{
    public class TemperatureAPIService : IApiService
    {
        private readonly IConfiguration _config;
        private readonly HttpClient _client;
        private readonly JsonSerializerOptions _options;
        private readonly string temperatureAPI = "temp";
        public TemperatureAPIService(IConfiguration config)
        {
            _config = config;
            _client = new HttpClient() { BaseAddress = new Uri(_config.GetValue<string>("BaseAPI")) };
            _options = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true, WriteIndented = true };
        }

        public TemperatureModel Get()
        {
            var response = _client.GetStringAsync(temperatureAPI).GetAwaiter().GetResult();
            var responseAsModel = JsonSerializer.Deserialize<TemperatureModel>(response, _options);
            return responseAsModel;
        }
    }
}
