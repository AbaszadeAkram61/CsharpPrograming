using Newtonsoft.Json;
using System.Threading.Tasks;

internal class Program
{
    const string ApiUrl = "https://api.agify.io/?name=meelad";
    private static async Task Main1(string[] args)
    {
        Console.WriteLine("Predict the age of a person based on their name");
        HttpClient client = new HttpClient();
        bool IsCountinue = false;
        do
        {
            Console.WriteLine();
            var result = await client.GetStringAsync(ApiUrl);
            var meeladFact = JsonConvert.DeserializeObject<Person>(result);
            Console.WriteLine($"{meeladFact.name} {meeladFact.age}");
            Console.WriteLine();
            Console.WriteLine("Do you want countinue? /true/false");
            IsCountinue = Convert.ToBoolean(Console.ReadLine());
        
        }
        while (IsCountinue);
    }
}
public class Person
{
    public int count { get; set; }
    public string name { get; set; }
    public int age {  get; set; }
}