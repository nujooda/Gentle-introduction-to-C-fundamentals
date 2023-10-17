namespace C03Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Price = 80;
            double stdDisc = .14;

            bool isStudent = true;
            
            if (isStudent)
            {
                Console.WriteLine($"Special Student Price: {Price - (stdDisc * Price)}");
            }
        }
    }
}

 