using GeneticAlgorithm;

namespace ConsoleCoreUI
{
    public class Program
    {
        private static void Main(string[] args)
        {
            #region PMX fixing test

            //int[] res = null;
            //bool isBroken = false;
            //for (int i = 0; i < 100; i++)
            //{
            //    Console.WriteLine($"Loop nr. {i} isBroken : ");
            //    int[] parent1 = Permutator.GetRandomPermutation(new[] { 8, 4, 7, 3, 6, 2, 5, 1, 9, 0 });
            //    Console.Write($"tmp1: { IsBrocken(parent1)} | ");
            //    int[] parent2 = Permutator.GetRandomPermutation(new[] { 8, 4, 7, 3, 6, 2, 5, 1, 9, 0 });
            //    Console.Write($"tmp2: { IsBrocken(parent2)} | ");

            //    //int[] parent1 = new[] { 6, 0, 2, 7, 5, 4, 8, 9, 1, 3 };
            //    //int[] parent2 = new[] { 2, 9, 3, 4, 0, 7, 1, 8, 5, 6 };

            //    res = Permutator.CrossPermutations(
            //        parent1,
            //        parent2
            //    );
            //    Console.WriteLine($"res: { IsBrocken(res)} ");
            //    ShowArray(parent1, "parent1");
            //    ShowArray(parent2, "parent2");
            //    ShowArray(res, "result ");
            //}

            #endregion PMX fixing test

            #region GetMutation test

            //int[] test = new int[GeneticAlgorithmParameters.Dimension];
            //for (int j = 0; j < GeneticAlgorithmParameters.Dimension; j++)
            //{
            //    test[j] = j;
            //}

            //Individual tmpIndividual = new Individual()
            //{
            //    Places = test
            //};

            //var res = tmpIndividual.GetMutation();

            #endregion GetMutation test

            GeneticAlgorithmCore geneticAlgorithmCore = new GeneticAlgorithmCore();

            //geneticAlgorithmCore.RunAllAlgorithms();
            geneticAlgorithmCore.RunOnlySA();

            // напоминаю - просмотри TODO !!!
        }
    }
}