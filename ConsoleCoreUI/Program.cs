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

            #region GetMutatation test

            //int[] test = new int[GeneticAlgorithmParameters.Dimension];
            //for (int j = 0; j < GeneticAlgorithmParameters.Dimension; j++)
            //{
            //    test[j] = j;
            //}

            //Individual tmpIndividual = new Individual()
            //{
            //    PermutationPlaces = test
            //};

            //var res = tmpIndividual.GetMutatation();

            #endregion GetMutatation test

            GeneticAlgorithmCore geneticAlgorithmCore = new GeneticAlgorithmCore();
            geneticAlgorithmCore.Explore();
        }

        //private static void ShowArray(int[] array, string name)
        //{
        //    string arr = "";
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        arr += $"{array[i]} , ";
        //    }
        //    Console.WriteLine($"{name}: {arr} ");
        //}

        //private static bool IsBrocken(int[] array)
        //{
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        int counter = 0;
        //        for (int j = 0; j < array.Length; j++)
        //        {
        //            if (array[j] == array[i])
        //            {
        //                counter++;
        //                if (counter == 2)
        //                {
        //                    return true;
        //                }
        //            }
        //        }
        //    }

        //    return false;
        //}
    }
}