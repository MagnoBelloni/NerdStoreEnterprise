using Microsoft.Extensions.Options;
using NSE.Bff.Compras.Extensions;
using System.Net.Http;

namespace NSE.Bff.Compras.Services
{
    public interface IPedidoService
    {
    }

    public class PedidoService : IPedidoService
    {
        private readonly HttpClient _httpClient;

        public PedidoService(HttpClient httpClient, IOptions<AppServicesSettings> settings)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new System.Uri(settings.Value.PedidoUrl);
        }
    }
}
