using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace GraphQLClient
{
    class Program
    {
        private static readonly string graphqlUrl = "https://localhost:7065/graphql/";

        static async Task Main(string[] args)
        {
            Console.WriteLine("GraphQL Client Running...\n");

            await TestQueryAsync();
            await FirstQueryAsync("John");
            await SecondaryQueryAsync();
        }

        static async Task TestQueryAsync()
        {
            string query = @"
                query GetPersonInfo {
                    personInfo
                }";

            Console.WriteLine("Executing: TestQuery");
            await SendQueryAsync(query);
        }

        static async Task FirstQueryAsync(string name)
        {
            string query = @"
            query FirstQuery($name: String!) {
                personInfoParams(name: $name)
                people {
                    id
                    name
                }
            }";

            var variables = new
            {
                name = name
            };

            Console.WriteLine("Executing: FirstQuery with variable name = " + name);
            await SendQueryAsync(query, variables);
        }

        static async Task SecondaryQueryAsync()
        {
            string query = @"
            query Secondary {
                people {
                    id
                    name
                }
            }";

            Console.WriteLine("Executing: SecondaryQuery");
            await SendQueryAsync(query);
        }

        static async Task SendQueryAsync(string query, object variables = null)
        {
            using var client = new HttpClient();

            var requestBody = new
            {
                query,
                variables
            };

            var content = new StringContent(JsonConvert.SerializeObject(requestBody), Encoding.UTF8, "application/json");

            try
            {
                var response = await client.PostAsync(graphqlUrl, content);
                var result = await response.Content.ReadAsStringAsync();

                Console.WriteLine("Response:");
                Console.WriteLine(JToken.Parse(result).ToString(Newtonsoft.Json.Formatting.Indented));
                Console.WriteLine(new string('-', 80));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
