namespace Subroutines12B24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( getANumber());
            int n = getANumber();
            outputSomething();
            outputSomething();
            outputSomething();
            outputSomething(); 
            outputSomething();
            Console.WriteLine(correctLength("myString"));

            string password = "letMeInNow123";
            Console.WriteLine(correctLength(password));
            multiParameter(password, n, true);
        }
        static bool correctLength(string input)
        {
            if (input.Length >= 12)
            {
                return true;
            }
            return false;
            Console.WriteLine("This will never run!");
        }
        static void multiParameter(string first, int second, bool third)
        {
            Console.WriteLine($"{first} {second} {third}");
        }
        static int getANumber()
        {
            return 42;
        }
        static void outputSomething()
        {
            Console.WriteLine("something else");
        }
       
    }
}
