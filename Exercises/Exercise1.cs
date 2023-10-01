namespace FARSIMAN.Exercises
{
    public static class Exercise1
    {
        /*
        *
        * 1.1.Dadas 2 matrices de 3x3, indicar cuantos elementos mayores tiene cada arreglo y cuantos elementos son iguales, comparando las mismas posiciones entre cada arreglo.
        *
        * Salida esperada:
        * El arreglo 1 contiene 3 elementos mayores
        *
        * El arreglo 2 contiene 4 elementos mayores
        *
        * Existen 2 elementos iguales en ambos arreglos
        */

        public static void FindElements()
        {
            int[,] firstArray = {
                {17, 9, 36},
                {8, 7, 3},
                {15, 28, 87}
            };

            int[,] secondArray = {
                {9, 21, 36},
                {16, 65, 4},
                {12, 28, 31}
            };

            int largerElementsInArray1 = 0;
            int largerElementsInArray2 = 0;
            int equalElements = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (firstArray[i, j] > secondArray[i, j])
                    {
                        largerElementsInArray1++;
                    }
                    else if (secondArray[i, j] > firstArray[i, j])
                    {
                        largerElementsInArray2++;
                    }
                    else
                    {
                        equalElements++;
                    }
                }
            }

            Console.WriteLine("Exercise 1:");
            Console.WriteLine("Output:\n");
            Console.WriteLine($"El arreglo 1 contiene {largerElementsInArray1} elementos mayores\n");
            Console.WriteLine($"El arreglo 2 contiene {largerElementsInArray2} elementos mayores\n");
            Console.WriteLine($"Existen {equalElements} elementos iguales en ambos arreglos\n");
        }
    }
}