using System;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using System.Diagnostics;


namespace CatFactsNinja
{
    public class BreedsService
    {
        HttpClient _client;

        public BreedsService()
        {
            _client = new HttpClient();
        }

        public async Task<Breeds> GetBreedsAsync(string uri)
        {
            Breeds breeds = null;
            string content = null;
            try
            {
                HttpResponseMessage response = await _client.GetAsync(uri);
                Debug.WriteLine("\t response.StatusCode. {0}", response.StatusCode);

                if (response.IsSuccessStatusCode)
                {
                    content = await response.Content.ReadAsStringAsync();
                    breeds = JsonConvert.DeserializeObject<Breeds>(content);
                    Debug.WriteLine("\t Breeds {0}", breeds);

                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("\tERROR {0}", ex.Message);
            }

            return breeds;
        }
    }
}
