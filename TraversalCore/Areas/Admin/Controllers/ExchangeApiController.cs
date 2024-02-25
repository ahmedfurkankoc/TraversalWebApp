using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TraversalCore.Areas.Admin.Models;
using System.Net.Http.Headers;


namespace TraversalCore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ExchangeApiController : Controller
    {
        public async Task<IActionResult> Index()
        {
            List<ExchangeApiVM2> exchangeApis = new List<ExchangeApiVM2>();
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://booking-com15.p.rapidapi.com/api/v1/meta/getExchangeRates?base_currency=TRY"),
                Headers =
    {
        { "X-RapidAPI-Key", "3b46654e85mshe112904800c0f6ep12c8b8jsnfbddcb448657" },
        { "X-RapidAPI-Host", "booking-com15.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var values =  JsonConvert.DeserializeObject<ExchangeApiVM2>(body);
                return View(values.exchange_rates);
            }
        }
    }
}
