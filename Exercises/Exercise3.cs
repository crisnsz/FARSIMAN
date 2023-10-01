using System;
using FARSIMAN.Utils;

namespace FARSIMAN.Exercises
{
    public static class Exercise3
    {
        /*
         * Dada la siguiente matriz se requiere ordenar los elementos de forma ascendente y obtener la mediana.
         */
        public static void OrderBidimensioanlArray()
        {
            int[,] array1 = {
                {17, 9, 36},
                {8, 7, 3},
                {15, 28, 57}
            };

            // Coverting the Bidimensioanl array to undimensional.
            int[] oneDArray = Utilities.TwoDArrayToOneD(array1);

            // Sort the list in ascending order.
            int[] orderedArray = Utilities.SortArray(oneDArray);

            // Calculate la mediana, only works for bidimensional Arrays.
            int mediana = orderedArray[oneDArray.Length / 2];


            Console.WriteLine("Exercise 3:");
            Console.WriteLine("Output:\n");
            Console.WriteLine($"Elementos ordenados: {string.Join(", ", orderedArray)}\n");
            Console.WriteLine($"La mediana es: {mediana}\n");
        }



    }
}