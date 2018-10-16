using GeneticAlgorithm;
using Loader;

namespace ConsoleCoreUI
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            DataLoader loader = new DataLoader();

            var res = loader.GetCreatedDataContainerFromFileAsync().Result;

            MyGeneticAlgorithm geneticAlgorithm = new MyGeneticAlgorithm();
            geneticAlgorithm.StartGeneticAlgorithm();
        }
    }
}