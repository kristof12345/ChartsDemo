using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Webpage.Models;

namespace Webpage.Services
{
    public class StockService
    {
        private readonly HttpClient Http;

        public StockService(HttpClient http) { Http = http; }

        public async Task<Stock> GetStockDetails(string file)
        {
            return await Http.GetFromJsonAsync<Stock>(file);
        }
    }
}
