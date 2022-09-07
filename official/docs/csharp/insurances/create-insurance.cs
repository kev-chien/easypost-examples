using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;
using Xunit.Sdk;
using Newtonsoft.Json;
using EasyPost;

namespace EasyPostExamples;

public class Examples
{
    [Fact]
    public async Task CreateInsurance()
    {
        string apiKey = Environment.GetEnvironmentVariable("EASYPOST_API_KEY")!;

        EasyPost.ClientManager.SetCurrent(apiKey);

        Insurance insurance = await Insurance.Create(new Dictionary<string, object>()
        {
            {
                "to_address", new Dictionary<string, object>()
                {
                    {
                        "id", "adr_..."
                    }
                }
            },
            {
                "from_address", new Dictionary<string, object>()
                {
                    {
                        "id", "adr_..."
                    }
                }
            },
            {
                "tracking_code", "9400110898825022579493"
            },
            {
                "carrier", "USPS"
            },
            {
                "reference", "InsuranceRef1"
            },
            {
                "amount", "100.00"
            }
        });

        new TestOutputHelper().WriteLine(JsonConvert.SerializeObject(insurance, Formatting.Indented));
    }
}
