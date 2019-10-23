using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Countries.prism.Services;
using Countries.Prism.Models;
using Newtonsoft.Json;
namespace MyLeasing.Common.Services
{
    public class ApiService : IApiService
    {
        public async Task<Response> ApiCountryAsync<T>(
            string urlBase)
        {
            try
            {
                var client = new HttpClient();
                client.BaseAddress = new Uri(urlBase);
                var apiLink = string.Format("{0}", urlBase);
                var response = await client.GetAsync(apiLink);
                var result = await response.Content.ReadAsStringAsync();


                if (!response.IsSuccessStatusCode)
                {
                    return new Response
                    {
                        IsSuccess = false,
                        Message = result,
                    };
                }

                var list = JsonConvert.DeserializeObject<List<T>>(result);
                return new Response
                {
                    IsSuccess = true,
                    Message = "Ok",
                    Result = list,
                };
            }

            catch (Exception ex)
            {
                return new Response
                {
                    IsSuccess = false,
                    Message = ex.Message,
                };
            }
        }


    }
}