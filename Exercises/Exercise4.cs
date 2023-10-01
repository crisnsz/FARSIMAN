using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FARSIMAN.Exercises
{
    public static class Exercise4
    {
        public static void SumElements()
        {
            /*
             * Suma los elementos de la diagonal de una matriz cuadrada de 4x4
             */
            int[,] array1 ={
                {17, 9, 36, 21},
                {8, 28, 3, 1},
                {15, 7, 5, 30},
                {10, 17, 4, 12}
            };
            int sumaDiagonal = 0;

            int arrayLength = array1.GetLength(0);


            for (int i = 0; i < arrayLength; i++)
            {
                sumaDiagonal += array1[i, i];
            }


            Console.WriteLine("Exercise 4:");
            Console.WriteLine($"La suma es: {sumaDiagonal}");

        }
    }
}
