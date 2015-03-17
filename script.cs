
        static void ExitProgram() {

            Console.WriteLine();
            Console.WriteLine("\n Press any key to exit.");
            Console.ReadKey();

        }//end ExitProgram


        static bool AnotherCalculation() {
            bool again = true;
            string reply = "";

            Console.Write("Another Calculation (Y or N):  ");
            reply = Console.ReadLine();
            reply = reply.ToUpper();
            if (reply != "Y") {
                again = false;
            }
            return again;

        }//end anotherCalculation


        static void OutputTaxPayable(double tax) {

            Console.WriteLine("\nYour income tax is  {0:C}\n\n", tax);

        }//end OutputTaxPayable


        static double CalculateTaxPayable(double income) {

            const double taxRate = 0.20;
            double tax = 0.0;

            if (income > 0) {
                tax = income * taxRate;
            }

            return tax;
        }//end CalculateTaxPayable


        static double CalculateTaxableIncome(double gross, int numDependants) {
            double income;
            income = gross - 10000 - (2000 * numDependants);
            return income;
        }//end CalculateTaxableIncome


        static double ReadGrossIncome() {
            double gross = 0.0; string value = "";

            bool validInput = false;
            do {
                Console.Write("\nEnter the gross income:$");
                value = Console.ReadLine();
                if (double.TryParse(value, out gross)) {
                    validInput = true;
                } else {
                    Console.WriteLine("\n\n Input {0} was not in correct format for income, please re-enter your income\n\n", value);
                }

            } while (!validInput);

            return gross;
        }// end ReadGrossIncome


        static int ReadDependants() {
            int howMany = 0; string value = ""; bool validInput = false;

            do { 
                do {
                    validInput = false;
                    Console.Write("\nEnter the number of  dependents(0 for none): ");
                    value = Console.ReadLine();
                    if (int.TryParse(value , out howMany)){
                        validInput = true;
                    } else {
                        Console.WriteLine("\n\n Input {0} was not in correct format for number of dependents.\n\n", value);
                    }
                } while (!validInput);

                if (howMany < 0) {
                   Console.WriteLine("\nNumber of dependents may not be negative \n\n");
                }//end if { 
            } while (howMany < 0);
            return howMany;
        }//end ReadDependants


        static void WelcomeMessage() {

            Console.WriteLine("\n\n\t Income Tax Calculator \n\n");
        }//end WelcomeMessage


        static void Main() {
            bool again = true;
            double grossIncome = 0.0, taxableIncome = 0.0, incomeTax = 0.0;
            int numDependents = 0;

            WelcomeMessage();

            while (again) {
                grossIncome = ReadGrossIncome();
                numDependents = ReadDependants();
                taxableIncome = CalculateTaxableIncome(grossIncome, numDependents);
                incomeTax = CalculateTaxPayable(taxableIncome);
                OutputTaxPayable(incomeTax);
                again = AnotherCalculation();
            } //end while

            ExitProgram();
        } //end Main






Main();
