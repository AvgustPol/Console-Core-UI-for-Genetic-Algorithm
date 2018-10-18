using GeneticAlgorithm;

namespace ConsoleCoreUI
{
    public class Program
    {
        private static void Main(string[] args)
        {
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

            //individual1.CrossWithPMXoperator(individual2);

            #endregion PMX operator test
        }
    }
}