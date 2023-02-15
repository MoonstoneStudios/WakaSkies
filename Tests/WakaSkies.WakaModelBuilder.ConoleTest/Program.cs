using WakaSkies.WakaAPI;
using static System.Console;

namespace WakaSkies.WakaModelBuilder.ConoleTest
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
                WriteLine("Type directory for stl file download.");
                string directory = ReadLine();

                ModelBuilder builder = new ModelBuilder();
                if (Directory.Exists(directory))
                {
                    WakaModel model = builder.BuildModel(new ModelBuildSettings() 
                    { 
                        Response = response, 
                        Year = year
                    });
                    STLSerializer serializer = new STLSerializer();

                    File.WriteAllText(directory + "/file.stl", serializer.Serialize(model));

                    WriteLine($"Saved to {directory}\\file.stl");
                }
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