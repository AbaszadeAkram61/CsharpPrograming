internal class Program
{
    private static void Main(string[] args)
    {
        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Program.miniMaxSum(arr);
    }

    public static void miniMaxSum(List<int> arr)
    {
        long sum = 0;
        int arrmin = arr.Min();
        int arrmax = arr.Max();
        for (int i = 0; i < arr.Count; i++)
        {
            sum += arr[i];

        }
        Console.WriteLine($"{sum - arrmax} {sum - arrmin}");

    }
}