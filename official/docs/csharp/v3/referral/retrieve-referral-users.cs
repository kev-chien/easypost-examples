using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using EasyPost;

namespace EasyPostExamples
{
    public class Examples
    {
        public static async Task Main()
        {
            EasyPost.ClientManager.SetCurrent("<YOUR_TEST/PRODUCTION_API_KEY>");

            ReferralCustomerCollection referralCustomerCollection = await Partner.All(
                new Dictionary<string, object>
                {
                    { "page_size", 5 }
                }
            );

            List<ReferralCustomer> referralCustomers = referralCustomerCollection.ReferralCustomers;

            Console.WriteLine(JsonConvert.SerializeObject(referralCustomers, Formatting.Indented));
        }
    }
}
