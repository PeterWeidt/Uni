using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gold_Lotto_Checker
{

    class TestRef
    {
        static void FillArray(ref int[][] arr)
        {
            // Create the array on demand: 
            if (arr == null)
            {
                arr = new int[10];
            }
            // Fill the array:
            arr[0][1] = 1111;
            arr[4] = 5555;
        }

        static void Main()
        {
            const int NUMBER_OF_ROWS = 9;

            int[][] lottoNumbers ={ 
                             new int [] { 4, 7, 19, 23, 28, 36},
                             new int [] { 14, 18, 26, 34, 38, 45},
                             new int [] { 8, 10,11, 19, 28, 30},
                             new int [] {15, 17, 19, 24, 43, 44},
                             new int [] { 10, 27, 29, 30, 32, 41},
                             new int [] {9, 13, 26, 32, 37,  43},
                             new int [] {1, 3, 25, 27, 35, 41},
                             new int [] {7, 9, 17, 26, 28, 44},
                             new int [] {17, 18, 20, 28, 33, 38}
                              };

            int[] drawNumbers = new int[] { 44, 9, 17, 43, 26, 7, 28, 19 };

            FillArray(lottoNumbers);
        }//end Main
    }
}
