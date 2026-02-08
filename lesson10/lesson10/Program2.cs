using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Text;
using System.Threading.Tasks;

namespace lesson10
{
    internal class Program2
    {
        const string ApiUrl = "https://api.nationalize.io/?name=nathaniel";
        public static async Task Main2()
        {
            bool IsContinue = false;
            HttpClient client = new HttpClient();
            Console.WriteLine("Predict the nationality of a person based on their name.");
            do
            {
                Console.WriteLine();
                var result= await client.GetStringAsync(ApiUrl);
                var UserFact=JsonConvert.DeserializeObject<User>(result);
                foreach (var country in UserFact.Country)
                {
                    Console.WriteLine($"Country: {country.CountryId}, Probability: {country.Probability}");
                }
                Console.WriteLine("Do you want continue?/true/false");
                IsContinue = Convert.ToBoolean(Console.ReadLine());
            }
            while (IsContinue);
        }
    }
    public class User
    {
        public int Count { get; set; }
        public string Name { get; set; }
        public Country[] Country { get; set; }
    }

    public class Country
    {
        public string CountryId { get; set; }   
        public double Probability { get; set; }  
    }
}
