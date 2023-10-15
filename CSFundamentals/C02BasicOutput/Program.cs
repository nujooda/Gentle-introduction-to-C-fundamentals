namespace C03Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nbrString = "27";

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
            Console.WriteLine($"doubleNumB converted into Boolean (-12): {Convert.ToBoolean(doubleNumB)}");


            Console.ReadKey();

        }
    }
}

 