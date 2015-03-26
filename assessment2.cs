

static void Main()
        {
            const int NUMBER_OF_ROWS =9;

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

            displayGames(NUMBER_OF_ROWS, lottoNumbers);
            displayNumbers(drawNumbers);
	    getWinningNumbers(drawNumbers, lottoNumbers);

            ExitProgram();
        }//end Main

        static void displayGames(int maxcolumns, int[][] lottoNumbers)
        {
            for (int row = 0; row < maxcolumns; row++)
            {
                System.Console.Write("Game {0}: \t", row + 1);
                for (int column = 0; column < lottoNumbers[row].Length; column++)
                {
                    System.Console.Write(lottoNumbers[row][column] + "\t");
                }
                Console.WriteLine();
            }
        }



        static void displayNumbers(int[] drawNumbers){
            Console.WriteLine("\n Numbers: ");
            foreach (int number in drawNumbers) {
                System.Console.Write(number + "\t");
            }
        }



        static void getWinningNumbers(int[] drawNumbers, int[][] lottoNumbers)
        {
		int no1 = drawNumbers[0];
		int no2 = drawNumbers[1];
		int no3 = drawNumbers[3];
		int no4	= drawNumbers[4];
		int no5 = drawNumbers[5];
		
		int match = 0;
		
		for (int row = 0; row < 9; row++)
            {
                for (int column = 0; column < lottoNumbers[row].Length; column++)
                {
			if (no1 == lottoNumbers[row][column])
			 System.Console.Write(no1 + "matches" + lottoNumbers[row][column]);
			match++;
                }
                Console.WriteLine("\n" + match);
		
            }


	}

        static void ExitProgram()
        {
            Console.Write("\n\nPress any key to exit program: ");
            Console.ReadKey();
        }//end ExitProgram



Main();
