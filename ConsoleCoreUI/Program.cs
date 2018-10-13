using Loader;

namespace ConsoleCoreUI
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            FileLoader loader = new FileLoader();

            var res = loader.GetDataFromFileAsync().Result;
        }
    }
}