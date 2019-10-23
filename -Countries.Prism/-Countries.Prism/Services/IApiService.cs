
using Countries.Prism.Models;
using System.Threading.Tasks;

namespace Countries.prism.Services
{
    public interface IApiService
    {
        Task<Response> ApiCountryAsync<T>(
            string urlBase);
    }
}