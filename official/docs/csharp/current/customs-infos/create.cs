using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using EasyPost;
using EasyPost.Models.API;

namespace EasyPostExamples
{
    public class Examples
    {
        public static async Task Main()
        {
            string apiKey = Environment.GetEnvironmentVariable("EASYPOST_API_KEY")!;

            var client = new EasyPost.Client(apiKey);

            CustomsInfo customsInfo = await client.CustomsInfo.Create(new Dictionary<string, object>()
            {
                { "customs_certify", true },
                { "customs_signer", "Steve Brule" },
                { "contents_type", "merchandise" },
                { "contents_explanation", "" },
                { "restriction_type", "none" },
                { "eel_pfc", "NOEEI 30.37(a)" },
                {
                    "customs_items", new List<Dictionary<string, object>>()
                    {
                        new Dictionary<string, object>()
                        {
                            { "description", "T-shirt" },
                            { "quantity", 1 },
                            { "weight", 5 },
                            { "value", 10 },
                            { "hs_tariff_number", "123456" },
                            { "origin_country", "US" }
                        }
                    }
                }
            });

            Console.WriteLine(JsonConvert.SerializeObject(customsInfo, Formatting.Indented));
        }
    }
}
