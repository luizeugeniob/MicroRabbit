using MicroRabbit.MVC.Models.Dto;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.MVC.Services
{
    public class TransferService : ITransferService
    {
        private readonly HttpClient _client;

        public TransferService(HttpClient client)
        {
            _client = client;
        }

        public async Task Transfer(TransferDto transferDto)
        {
            var uri = "https://localhost:5001/api/banking";
            var transferContent = new StringContent(JsonConvert.SerializeObject(transferDto), 
                                                    Encoding.UTF8, 
                                                    "application/json");

            var response = await _client.PostAsync(uri, transferContent);
            response.EnsureSuccessStatusCode();
        }
    }
}
