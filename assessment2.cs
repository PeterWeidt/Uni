 int NUMBER_OF_ROWS = 9;

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

          winningNumbers(NUMBER_OF_ROWS, lottoNumbers, drawNumbers);

            ExitProgram();

        static int winningNumbers(int rows, int[][] lottoNumbers, int[] drawNumbers)
        {
            Console.WriteLine(rows);
            int test = 0;
            Console.WriteLine(lottoNumbers[1][1]);

            while (rows >= -1)
            {
                rows--;
            }
            return test;
        }

        static int suppNumbers(int[] drawNumbers)
        {
            SupplementaryOne = drawNumbers[6];
	    SupplementaryTwo = drawNumbers[7];
           Console.WriteLine(SupplementaryOne);
	    return SupplementaryOne;
	    return SupplementaryTwo;    
	}

Console.WriteLine(SupplementaryOne);

        static void ExitProgram() {
            Console.Write("\n\nPress any key to exit program: ");
            Console.ReadKey();
        }//end ExitProgram
