            const string exitMessage = "\n Key any key to exit program ... ";

            string[] words = {"the", "quick", "brown", "fox", 
                              "jumps", "over", "the", "lazy", "dog"};
            
            int location;

            DisplayArray(words);

            location = LinearSearch(words, "the");
            OutputSearchResult(location, "the");

            location = LinearSearch(words, "able");
            OutputSearchResult(location, "able");


            location = LinearSearch(words, "over");
            OutputSearchResult(location, "over");

            location = LinearSearch(words, "zebra");
            OutputSearchResult(location, "zebra");

            location = LinearSearch(words, "dog");
            OutputSearchResult(location, "dog");
           
            OutputMessage(exitMessage);


        /// <summary>
        ///  linear search of "words" for "word" 
        /// </summary>
        /// <param name="words">list of words to be searched</param>
        /// <param name="word">the word being searchedd for</param>
        /// <returns> position of "word" in "words" if it is there
        ///             otherwise returns -1    </returns>
        static int LinearSearch(string[] words, string word) {
            
            int position = 0;
          
            /*
             * while (position < length of list) & (element at position != key) 
             *     increment position
             * end while
             * if (position < length of list)
             *     return position  // found it
             * else 
             *     return -1 // key not in the list
             *     
             */

            // following return provided so that code compiles
            return position; // it can be deleted once algoritham is implemented

        } //end LinearSearch

        
        /// <summary>
        /// Displays the elements of the array "words"
        /// </summary>
        /// <param name="words">array to be displayed</param>
        static void DisplayArray(string[] words) {

            foreach (string element in words) {
                Console.WriteLine(element);
            }
            Console.WriteLine();

        }//end DisplayArray

        /// <summary>
        /// Displays the outcome of the linear search
        /// </summary>
        /// <param name="position">either the position of "word" if it was found
        ///                         or -1 if "word" was not found</param>
        /// <param name="word"></param>
        static void OutputSearchResult(int position, string word) {
            string continueMessage = "\nPress any key to continue:";

            if (position < 0) {
                Console.WriteLine("\tthe word \"{0}\" not found in the list\n ", word);
            } else {
                Console.WriteLine("\tthe word \"{0}\" found in postion {1} in the list\n",word, position);
            }

            OutputMessage(continueMessage);

        } //end OutputSearchResult

        /// <summary>
        /// Outputs the string "s"
        /// </summary>
        /// <param name="s">String to be output</param>
        static void OutputMessage(string s) {
          
            Console.Write(s);
            Console.ReadKey();

        }// end OutPutMessage

