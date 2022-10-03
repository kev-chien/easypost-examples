using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EasyPost;
using EasyPost.Models.API;
using Newtonsoft.Json;

namespace EasyPostExamples
{
    public class Examples
    {
        public static async Task Main()
        {
            string apiKey = Environment.GetEnvironmentVariable("EASYPOST_API_KEY")!;

            var client = EasyPost.Client(apiKey);

            EndShipper endShipper = await client.EndShipper.Create(
                new Dictionary<string, object>() {
                    { "name", "FOO BAR" },
                    { "company", "BAZ" },
                    { "street1", "164 TOWNSEND STREET UNIT 1" },
                    { "street2", "UNIT 1" },
                    { "city", "SAN FRANCISCO" },
                    { "state", "CA" },
                    { "zip", "94107" },
                    { "country", "US" },
                    { "phone", "555-555-5555" },
                    { "email", "FOO@EXAMPLE.COM" }
                }
            );

            Console.WriteLine(JsonConvert.SerializeObject(endShipper, Formatting.Indented));
        }
    }
}
