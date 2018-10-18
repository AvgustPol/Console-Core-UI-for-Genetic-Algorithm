using GeneticAlgorithm;

namespace ConsoleCoreUI
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //DataLoader loader = new DataLoader();

            //var res = loader.GetCreatedDataContainerFromFileAsync().Result;

            MyGeneticAlgorithm geneticAlgorithm = new MyGeneticAlgorithm();
            geneticAlgorithm.StartGeneticAlgorithm();

            #region PMX operator test

            //Individual individual1 = new Individual()
            //{
            //    PermutationPlaces = new int[] { 8, 4, 7, 3, 6, 2, 5, 1, 9, 0 }
            //};
            //Individual individual2 = new Individual()
            //{
            //    PermutationPlaces = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }
            //};

            //individual1.PMXoperator(individual2);

            #endregion PMX operator test
        }
    }
}