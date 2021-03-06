using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gold_Lotto_Checker
{

    class Program
    {

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

            printLotto(NUMBER_OF_ROWS, lottoNumbers, drawNumbers);
            getWinningNumbers(NUMBER_OF_ROWS, lottoNumbers, drawNumbers);
            ExitProgram();
        }//end Main

        static void printLotto(int gamelimit, int[][] lottoNumbers, int[] drawNumbers)
        {
            Console.WriteLine("Your lotto numbers are\n");
            for (int rows = 0; rows < gamelimit; rows++)
            {
                System.Console.Write("Game {0}: \t", rows + 1);
                for (int columns = 0; columns < lottoNumbers[rows].Length; columns++)
                {
                    System.Console.Write(lottoNumbers[rows][columns] + "\t");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("\nLotto Draw Numbers are: ");
            foreach (int number in drawNumbers)
            {
                System.Console.Write(number + "\t");
            }
        }// This method displays all numbers of the array in each game along with
        //all the numbers in the drawnumbers array.


        static void getWinningNumbers(int gameLimit, int[][] lottoNumbers, int[] myNumbers)
        {
            for (int game = 0; game < gameLimit; game++)
            {
                int match = 0;
                System.Console.Write("\n\tGame {0}: ", game + 1);
                for (int gameNumber = 0; gameNumber < lottoNumbers[game].Length; gameNumber++)
                {
                    for (int number = 0; number < myNumbers.Length - 2; number++)
                    {
                        if (lottoNumbers[game][gameNumber] == myNumbers[number])
                        {
                            match++;
                        }
                    }
                }
                Console.WriteLine(match);
            }
        }



        static void ExitProgram()
        {
            Console.Write("\n\nPress any key to exit program: ");
            Console.ReadKey();
        }//end ExitProgram


    } //end class Program
}
