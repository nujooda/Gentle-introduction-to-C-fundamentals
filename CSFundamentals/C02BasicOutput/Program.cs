using System.Diagnostics;
using System.Text.RegularExpressions;

namespace C03Variables
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            /*string nbrString = "27";

            int nbrInt = Convert.ToInt32(nbrString);
            long nbrLong = Convert.ToInt64(nbrString);
            double nbrDouble = Convert.ToDouble(nbrString);
            decimal nbrDecimal = Convert.ToDecimal(nbrString);

            string stringTrue = "true";
            string stringFalse = "false";

            Console.WriteLine($"String converted into Boolean (true): { Convert.ToBoolean(stringTrue)}");
            Console.WriteLine($"String converted into Boolean (false): {Convert.ToBoolean(stringFalse)}");

            Console.WriteLine();

            int intNumA = 3;
            int intNumB = -12;

            double doubleNumA = 8;
            double doubleNumB = -12;

            Console.WriteLine($"intNumA converted into Boolean (3): {Convert.ToBoolean(intNumA)}");
            Console.WriteLine($"intNumB converted into Boolean (-1): {Convert.ToBoolean(intNumB)}");

            Console.WriteLine($"doubleNumA converted into Boolean (8): {Convert.ToBoolean(doubleNumA)}");
            Console.WriteLine($"doubleNumB converted into Boolean (-12): {Convert.ToBoolean(doubleNumB)}");*/
            /* int age = 17;
             bool passedVissionTest = true;
             bool passedDrivingTest = false;

             if(age >= 17 && passedVissionTest == true && passedDrivingTest == true)
             {
                 Console.WriteLine("Congrats, your driver lisence!");

             }
             else
             {
                 Console.WriteLine("Sorry, no driving license for you");
             }*/

            /* string dayOfTheWeek = "Thursday";

             switch (dayOfTheWeek)
             {
                 case "Monday":
                     Console.WriteLine("Monday: Greek Cuisine");

                     break;
                 case "Tuesday":
                     Console.WriteLine("Tuesday: Southern France Cuisine");

                     break;
                 case "Wednesday":
                     Console.WriteLine("Wednesday: Portuguese Cusisine");

                     break;
                 case "Thursday":
                     Console.WriteLine("Thursday: Turkish Cuisine");

                     break;
                 case "Friday":
                     Console.WriteLine("Friday: Egyptian Cuisine");

                     break;
                 case "Saturday":
                     Console.WriteLine("Saturday: Moroccan Cusisine");

                     break;

                 case "Sunday":
                     Console.WriteLine("Sunday: Italian Cuisine");
                     break;

                 default:
                     Console.WriteLine("Sorry, (addpause 0.5) invalid input!");


                     break;
             }*/
            /*int age = 17;
            bool passedVissionTest = true;
            bool passedDrivingTest = true;
            switch(age,passedVissionTest,passedDrivingTest)
            {
                case ( >= 17, true, true):
                    Console.WriteLine("Congratulations, here's your driving license");
                    break;

                default:
                    Console.WriteLine("Sorry, no driving license for you");
                    break;*/
            //do while loop

            /*string doorPIN;
            do
            {
                Console.WriteLine("Please enter PIN to gain access: ");
                doorPIN = Console.ReadLine();
                Console.Clear();

            }
            while (doorPIN != "001");
            Console.WriteLine("You can enter");

            Console.WriteLine("Hello mansor");*/


            /*static void CalculateSalesTax()
            {
                const double salesTax = 0.1;
                double totalPurchase = 530;

                Console.WriteLine($"Purchase : ${totalPurchase}");
                Console.WriteLine($"Sales Tax: ${salesTax * totalPurchase}");
                Console.WriteLine();
                Console.WriteLine($"TOTAL: ${totalPurchase + (salesTax * totalPurchase)}");
            }*/

            /*Console.Write("Name: ");
            string? inputName = Console.ReadLine();

            bool isNameVaild = Regex.IsMatch(inputName, @"^[a-zA-Z-]+$");

            if (isNameVaild) 
            {
                Console.WriteLine($"How are you today {inputName}?");

            }
            else
            {
                Console.WriteLine("Sorry, invalid input!");

            }*/
            // validating number input
            //Console.Write("Name: ");
            //string? inputName = Console.ReadLine();

            /*Console.Write("Physics score: ");
            string? inputPhysics = Console.ReadLine();
            double scorePhysics = Convert.ToDouble(inputMath);

            Console.Write("Chemistry score: ");
            string? inputChemistry = Console.ReadLine();
            double scoreChemistry = Convert.ToDouble(inputChemistry);

            Console.WriteLine(); // emptyline*/

            Console.Write("Math score: ");
            string? inputMath = Console.ReadLine();
            bool isInputMathVaild = double.TryParse(inputMath, out double scoreMath);

            if (isInputMathVaild)
            {
                Console.WriteLine("Vaild score");
                Console.Read();

            }
            else 
            {
                Console.WriteLine("Invaild score!");
                Console.Read();
            }




            Console.ReadKey();

        }
    }
}

 