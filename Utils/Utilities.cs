using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FARSIMAN.Utils
{
    public class Utilities
    {
        public static int[] TwoDArrayToOneD(int[,] array)
        {
            int index = 0;

            int Rows = array.GetLength(0);
            int Columns = array.GetLength(1);

            int[] OneDArray = new int[Rows * Columns];

            for (int i = 0; i < Columns; i++)
            {
                for (int j = 0; j < Rows; j++)
                {
                    OneDArray[index] = array[j, i];
                    index++;
                }
            }

            return OneDArray;
        }

        public static int[] SortArray(int[] array)
        {
            int arrayLength = array.Length;
            bool swapped = true;
            while (swapped)
            {
                swapped = false;
                for (int i = 1; i < arrayLength; i++)
                {
                    if (array[i - 1] > array[i])
                    {
                        (array[i], array[i - 1]) = (array[i - 1], array[i]);
                        swapped = true;
                    }
                }
            }

            return array;
        }

        public static void ReverseArray(char[] arr)
        {
            int length = arr.Length;
            int left = 0;
            int right = length - 1;

            while (left < right)
            {
                (arr[right], arr[left]) = (arr[left], arr[right]);

                left++;
                right--;
            }
        }
    }
}
