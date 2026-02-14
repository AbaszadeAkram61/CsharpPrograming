using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace lesson16
{
    public class Program2
    {
        const string ApiUrl = "https://catfact.ninja/fact";
        public static async Task Main()
        {
         
            bool Iscontinue = false;
            Console.WriteLine("CatFact ninja");
            Console.WriteLine();
            do
            {
                HttpClient client = new HttpClient();
                var StringResult = await client.GetStringAsync(ApiUrl);
                var Result= JsonConvert.DeserializeObject<Catfact>(StringResult);
                Console.WriteLine(Result.Fact);
                Console.WriteLine();
                Console.WriteLine("Do you continue?/nTrue/nFalse");
                Iscontinue = Convert.ToBoolean(Console.ReadLine());
                Console.WriteLine();
            }
            while (Iscontinue);
        }
    }
    public class Catfact
    {
        public string Fact {  get; set; }

        public int Length {  get; set; }
    }

}
