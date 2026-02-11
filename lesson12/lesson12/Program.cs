internal class Program
{
    const string LogsFile = @"D:\\Logs\logs.txt";

    static void Main2(string[] args)
    {
        //The given program is throwing OverflowException. Fix it.
        int num1, num2;
        byte result;

        num1 = 30;
        num2 = 60;
        try
        {
            result = Convert.ToByte(num1 * num2);
        }
        catch (OverflowException exc)
        {
            File.AppendAllText(LogsFile, DateTime.Now + "\n" + exc.ToString() + "\n\n");
            throw;

        }
        catch(Exception exc)
        {
            File.AppendAllText(LogsFile, DateTime.Now + "\n" + exc.ToString() + "\n\n");
            throw;
        }

        Console.WriteLine("{0} x {1} = {2}", num1, num2, result);
        Console.ReadLine();


    }



    private static void Main1(string[] args)
    {

        //This program is throwing exception IndexOutOfRangeException.Using your skills fix this problem using try catch block.
       
        string[] list = new string[5];
        list[0] = "Sunday";
        list[1] = "Monday";
        list[2] = "Tuesday";
        list[3] = "Wednesday";
        list[4] = "Thursday";

        try
        {
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine(list[i].ToString());
            }
            Console.ReadLine();
        }
        catch (IndexOutOfRangeException exc)
        {
            File.AppendAllText(LogsFile,DateTime.Now+"\n"+ exc.ToString()+"\n\n");
            throw;
            
        }
        catch(Exception exc)
        {
            File.AppendAllText(LogsFile, DateTime.Now + "\n" + exc.ToString() + "\n\n");
            throw;
        }
       

        
    }
}