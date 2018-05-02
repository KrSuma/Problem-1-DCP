using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1_DCP
{
    class Program
    {
        /// <summary>
        /// Given a list of numbers, return whether any two sums to k.
        /// For example, given[10, 15, 3, 7] and k of 17, return true since 10 + 7 is 17.
        /// Bonus: Can you do this in one pass?
        /// </summary>
        ///
        /// let the given numbers be elements in an array of size of array.Length.
        /// we go through these elements like a selection sort.
        /// let the element of the first index of array = i
        /// let j be i+1.
        /// take the value of the element at index i, and add it with the element at index j.
        /// if the sum of these two elements exquals the value we want to check, return true.
        /// else, return false.


        public static bool Checktwosums(int[] arr, int toCheck)
        {
            bool check = false;

            for (int i = 0; i < arr.Length-1; i++)
            {
                var value1 = arr[i];

                for (int j = i + 1; j < arr.Length; j++)
                {
                    var value2 = arr[j];

                    if (value1 + value2 == toCheck)
                    {
                        check = true;
                        break;
                    }
                }

                if (check)
                    break;
                
            }

            return check;
        }
    
        static void Main()
        { 
            int[] arr = {10, 15, 3, 7, 6 , 4 , 9, 22, 5};

            Console.WriteLine(Checktwosums(arr, 8) ? "true" : "False");
        }
    }
}
