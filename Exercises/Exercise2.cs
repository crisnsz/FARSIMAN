using FARSIMAN.Utils;

namespace FARSIMAN.Exercises
{
    public static class Exercise2
    {
        /*
         *1.2. Mostrar la suma los elementos de un arreglo bidimensional, exceptuando los valores que estén alejados más del 60% del average de los elementos.
         *Además, debe mostrar el average de todos los elementos, los valores que aplican y los que no aplican a la suma solicitada.
         *
         *Salida esperada:
         *
         *La suma es: 77
         *
         *average: 20
         *
         *No aplican para sumar: 3, 7, 36, 57
         *
         *Sí aplican para sumar: 8, 9, 15, 17, 28
         */

        public static void SumElements()
        {
            int[,] array1 ={
                {17, 9, 36},
                {8, 7, 3},
                {15, 28, 57}
            };

            // Coverting the Bidimensioanl array to undimensional
            int[] oneDArray = Utilities.TwoDArrayToOneD(array1);

            // Get the average of all elements
            int average = oneDArray.Sum() / oneDArray.Length;

            // Sort the list in ascending order
            int[] orderedArray = Utilities.SortArray(oneDArray);


            // Get the upper and lower limit for the values that are within the 60%
            double lowerLimit = average - average * 0.6;
            double upperLimit = average + average * 0.6;

            List<int> elementsWithInRange = new();
            List<int> elementsOutOfRange = new();

            // Get the values
            foreach (int elementValue in orderedArray)
            {
                if (elementValue >= lowerLimit && elementValue <= upperLimit)
                {
                    elementsWithInRange.Add(elementValue);
                }
                else
                {
                    elementsOutOfRange.Add(elementValue);
                }
            }

            Console.WriteLine("Exercise 2:");
            Console.WriteLine("Output:\n");
            Console.WriteLine($"La suma es: {elementsWithInRange.Sum()}\n");
            Console.WriteLine($"Promedio: {average}\n");
            Console.WriteLine($"No aplican para sumar: {string.Join(", ", elementsOutOfRange)}\n");
            Console.WriteLine($"Sí aplican para sumar: {string.Join(", ", elementsWithInRange)}\n");
        }
    }
}