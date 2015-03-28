using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Advanced_Gold_Lotto_Checker {
    class Program {
        static Random randomGen = new Random();
        static void Main() {
        
            const int NUMBER_OF_ROWS = 12;
            
            int[][] lottoNumbers ={ 
                             new int [6],
                             new int [6],
                             new int [6],
                             new int [6],
                             new int [6],
                             new int [6],
                             new int [6],
                             new int [6],
                             new int [6],
                             new int [6],
                             new int [6],
                             new int [6] 
                              };

            int[] drawNumbers = new int[8];

            Welcome();
            Random(NUMBER_OF_ROWS, lottoNumbers);
            //printRandom(Random);
            //printMyNumbers(NUMBER_OF_ROWS, lottoNumbers);
            //lottoDraw(drawNumbers);
            //printResults(NUMBER_OF_ROWS, lottoNumbers, drawNumbers);
            ExitProgram();
        }//end Main

         static void Welcome()
        {
            Console.WriteLine("\n\n\t\t\t Welcome to the Lotto Checker \n\n\n");
        }//end WelcomeMessage

         static int[][] Random(int gamelimit, int[][] lotto)
         {
             int[][] Random = new int[gamelimit][];
             int generate = 0;
             for (int game = 0; game < gamelimit; game++)
             {
                 for (int gameNumber = 0; gameNumber < 6; gameNumber++)
                 {
                     //Console.WriteLine(gameNumber);
                     generate = randomGen.Next(45);
                     Random[game][gameNumber] = generate;
                 }
                 Console.WriteLine(Random[game][0]);
             }
             return Random;
         }//end WelcomeMessage

         static void printRandom(int gamelimit, int[][] myNumbers)
         {
             Console.WriteLine("Your lotto numbers are:");
             for (int game = 0; game < gamelimit; game++)
             {
                 Console.Write("Game {0}: \t", game + 1);
                 for (int gameNumber = 0; gameNumber < myNumbers[game].Length; gameNumber++)
                 {
                     Console.Write(myNumbers[game][gameNumber] + "\t");
                 }
                 Console.WriteLine("\n");
             }
         }//end printmyNumbers

        /// <summary>
        ///  Printing Lotto summary for users 
        /// </summary>
        /// <param name="gamelimit">This displays the maximum amount of lottogames played, specified in Main</param>
        /// <param name="myNumbers">Numbers is the static lotto numbers array from main, renamed for method use to make it more readable and to clarify that this is the users personal lottonumbers</param>
        /// <returns> the users game numbers for the lotto </returns>
        static void printMyNumbers(int gamelimit, int[][] myNumbers)
        {
            Console.WriteLine("Your lotto numbers are:");
            for (int game = 0; game < gamelimit; game++)
            {
                Console.Write("Game {0}: \t", game + 1);
                for (int gameNumber = 0; gameNumber < myNumbers[game].Length; gameNumber++)
                {
                    Console.Write(myNumbers[game][gameNumber] + "\t");
                }
                Console.WriteLine("\n");
            }
        }//end printmyNumbers


        /// <summary>
        ///  lottoDraw
        /// </summary>
        /// <param name="drawNumbers">Displays the numbers drawn for this lotto match</param>
        /// <returns> Writes the numbers to console for user to view.</returns>
        static void lottoDraw(int[] drawNumbers)
        {
            Console.WriteLine("\n\nLotto Draw Numbers are: ");
            foreach (int number in drawNumbers)
            {
                Console.Write(number + "\t");
            }
        }//end lottoDraw


        /// <summary>
        ///  Prints the results of the lotto game and matches user's numbers vs numbers drawn
        /// </summary>
        /// <param name="gamelimit">This displays the maximum amount of lottogames played, specified in Main</param>
        /// <param name="myNumbers">Generates the array of lottonumbers, used to later compared and check for a match</param>
        /// <param name="drawNumbers">Generates the array of lottonumbers chosen for the lotto.</param>
        /// <returns> Separates Winningnumbers and Supplementary numbers. For each winning number the matchwinning and matchsupplementary count is incrimented by one, to correctly print the results / outcome of the lotto round complete.</returns>
        static void printResults(int gameLimit, int[][] myNumbers, int[] drawNumbers)
        {
            int ExcludeWinning = 6;
            int ExcludeSupp = drawNumbers.Length - 2;
            for (int game = 0; game < gameLimit; game++)
            {
                int matchWinning = 0;
                int matchSupplementary = 0;
                for (int gameNumber = 0; gameNumber < myNumbers[game].Length; gameNumber++)
                {
                    for (int number = 0; number < ExcludeSupp; number++)
                    {
                        if (myNumbers[game][gameNumber] == drawNumbers[number])
                        {
                            matchWinning++;
                        }
                    }
                    for (int number = ExcludeWinning; number < drawNumbers.Length; number++)
                    {
                        if (myNumbers[game][gameNumber] == drawNumbers[number])
                        {
                            matchSupplementary++;
                        }
                    }
                }
                Console.WriteLine("\n\n\tfound " + matchWinning + " winning numbers and " + matchSupplementary + " supplementary numbers in Game {0}", game + 1);
            }
        }//end printResults

        /// <summary>
        ///  Simple exit program to ensure program stays active for required duration
        /// </summary>
        /// <returns> Holds the program and lotto results until the user presses any key. </returns>  

        static void ExitProgram() {
            Console.Write("\n\nPress any key to exit program: ");
            Console.ReadKey();
        }//end ExitProgram

    } //end class Program
}
