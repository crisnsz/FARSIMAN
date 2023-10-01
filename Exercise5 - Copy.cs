using System.Text;

namespace FARSIMAN
{
    public static class Exercise5
    {
        public static string GetInput()
        {
            bool isValid = false;
            string? input = "";

            while (!isValid)
            {
                Console.WriteLine("Por favor, ingresa una cadena de texto:");
                input = Console.ReadLine();
                if (!string.IsNullOrEmpty(input))
                {
                    isValid = true;
                }
            }

            return input!;
        }

        private static char[] StringToArray(string input)
        {
            int length = input.Length;
            char[] charArray = new char[length];

            for (int i = 0; i < length; i++)
            {
                charArray[i] = input[i];
            }

            return charArray;
        }

        private static string ArraytoString(char[] charInput)
        {
            int length = charInput.Length;
            StringBuilder bld = new();
           

            for (int i = 0; i < length; i++)
            {
                bld.Append(charInput[i]);
            }

            return bld.ToString();
        }

        private static void ReverseArray(char[] arr)
        {
            int length = arr.Length;
            int left = 0;
            int right = length - 1;

            while (left < right)
            {
                // Swap arr[left] and arr[right]
                (arr[right], arr[left]) = (arr[left], arr[right]);

                // Move the pointers towards each other
                left++;
                right--;
            }
        }

        public static void InvertedString()
        {
            string input = GetInput();

            // Convierte la cadena de texto en un arreglo de caracteres
            char[] caracteres = StringToArray(input);

            // Invierte el arreglo de caracteres
            ReverseArray(caracteres);
            string chain = ArraytoString(caracteres);
            Console.WriteLine("Output:\n");
            Console.WriteLine($"La cadena invertida es: {chain}\n");
        }
    }
}