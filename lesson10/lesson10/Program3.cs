using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace lesson10
{
    internal class Program3
    {
        const string ApiUrl = "https://api.ipify.org/?format=json";
        public static async Task Main()
        {
            bool IsContinue = false;
            HttpClient client = new HttpClient();
            Console.WriteLine("Get your current IP address.");
            Console.WriteLine();
            do
            {
                var result= await client.GetStringAsync(ApiUrl);
                var ApiFact= JsonConvert.DeserializeObject<Api>(result);
                Console.WriteLine(ApiFact.Ip);
                Console.WriteLine();
                Console.WriteLine("Do you want continue?true/false");
                IsContinue = Convert.ToBoolean(Console.ReadLine());
            }
            while (IsContinue);
        }
    }
    public class Api
    {
        public string Ip {  get; set; }
    }
}
