namespace Countries.prism.Services
{
    public interface IApiService
    {
        System.Threading.Tasks.Task<Response> GetTokenAsync(string urlBase, string servicePrefix, string controller);
    }
}