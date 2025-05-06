using RestSharp;
using Newtonsoft.Json;
using System.Diagnostics;

namespace Chuck_Jokes
{
    internal class ApiHandler
    {
        public async Task<Fact?> GetFact()
        {
            try
            {
                RestClient client = new RestClient("https://api.chucknorris.io/jokes/random");
                RestRequest request = new RestRequest();

                var response = await client.ExecuteAsync(request);

                if (response.IsSuccessful && !string.IsNullOrEmpty(response.Content))
                {
                    Console.WriteLine(response.Content);

                    Fact fact = JsonConvert.DeserializeObject<Fact>(response.Content);

                    return fact;
                }
                else
                {
                    Console.WriteLine("Failed.");
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return null;
            }
        }
    }
}

