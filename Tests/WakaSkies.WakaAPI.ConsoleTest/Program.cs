using static System.Console;

namespace WakaSkies.WakaAPI.ConsoleTest
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            // using static Console.
            WriteLine("WakaAPI tests.");
            WriteLine("Please type in a username.");
            string userName = ReadLine();
            WriteLine("Please type in an API key.");
            string key = ReadLine();
            WriteLine("Please type in a year.");
            string year = ReadLine();
            WriteLine("Fetching...");

            var waka = new WakaClient(key);
            var response = await waka.GetUserInsights(userName, year);
            if (response.Successful)
            {
                WriteLine(response.Content);
            }
            else
            {
                WriteLine($"An error occured: {response.ErrorData.Reason}.");
            }
            WriteLine("Press any key to quit.");
            ReadKey();
        }
    }
}