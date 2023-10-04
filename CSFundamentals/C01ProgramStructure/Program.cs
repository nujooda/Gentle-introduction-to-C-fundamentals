namespace C01ProgramStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // read code at the X location

            string student = "Jessica";
            string studentID = "G1280";
            Console.WriteLine(studentID);

            if(student == "Jessica")
            {
                int age = 21;
                Console.WriteLine($"Hello {student}");
                Console.WriteLine (age);
            }
            else 
            {
                Console.WriteLine("Hi there...");
                Console.WriteLine(age);
            }

            Console.WriteLine(age);
        }
    }
}