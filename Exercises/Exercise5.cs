using FARSIMAN.Utils;

namespace FARSIMAN.Exercises
{
    public static class Exercise5
    {
        /*
         * Solicita ingresar una cadena de texto y luego muéstrela invertida
         */
        public static void InvertedString()
        {

            Console.WriteLine($"\nExercise 5:\n");
            string input = GetInput();

            // Converts the text string to an array of characters.
            char[] caracteres = input.ToCharArray();

            // Inverts the character array
            Utilities.ReverseArray(caracteres);

            // Converts the inverted array of characters back to a string


            Console.WriteLine("Output:\n");
            Console.WriteLine($"La cadena invertida es: {string.Join("", caracteres)}\n");

        }

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


    }
}