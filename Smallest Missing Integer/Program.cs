using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Finds smallest missing positive integer in an array of integers.  For example if the
   array contains values 1, 3, 4, 5, the value found would be 2
   Emer Campbell
   2018*/

namespace Smallest_Missing_Integer
{
    class Smallest
    {
        public static int solution(int[] A)
        {
            Array.Sort(A);//call sort method from library to sort values in ascending order - used for efficiency

            int length = A.Length - 1; //determine last index value of array
            int smallest = 1;//set to smallest possible positive integer

            for (int i = smallest; i < A[length]; i++)//loop sequentially from the smallest possible integer to the largest integer in the array
            {
                int test = Array.BinarySearch(A, i);//search in the array for the current value of i.  Use binary search from library for efficiency

                if (test < 0)//if current value of i not found in array then return it as it must be the smallest possible missing positive integer
                    return i;
            }

            //code only executed if i not found - means that smallest integer must be bigger than any value currently in the array 

            smallest = A[length] + 1; /*find largest value in array and add one to it 
                                     (for example if array contains values 1,2,3,4,5 then missing value is 6) */

            if (smallest < 1)/*if value found is still a negative number then smallest positive missing integer must be one
                            (for example if array contains values -5,-4,-3,-2)*/
                return 1;
            else
                return smallest;
        }

        static void Main(string[] args)
        {
            int [] A = new int[6] { 1,2,3,4,5,6};
            Console.WriteLine("The smallest missing positive integer is: {0} ", Smallest.solution(A));
            Console.Read();

        }
    }
}
