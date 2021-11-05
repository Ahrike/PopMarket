using Newtonsoft.Json;
using PopMarket.Web.Models.Request;
using PopMarket.Web.Models.Response;
using PopMarket.Web.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace PopMarket.Web.Services
{
    public class PayStackService : IPayStackService
    {
        private readonly IHttpClientFactory _httpClientFactory;

        private HttpClient _client;
        public PayStackService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;

            _client = _httpClientFactory?.CreateClient("PayStackService");
        }
        public async Task<PaystackResponse> GetPaymentUrl(PayStackRequest payStackRequest)
        {

            using var request = new HttpRequestMessage(HttpMethod.Post, "initialize/");

            payStackRequest.reference = "POPMarket"+(DateTime.Now).ToString("ddMMyyyyHHmmss");

            var contentToSend = JsonConvert.SerializeObject(payStackRequest);

            request.Content = new StringContent(contentToSend);

            var response = await _client.SendAsync(request);

            var responsContent = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<PaystackResponse>(responsContent);

           

        }
    }
}
