using static System.Console;

namespace TestRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, num;
            Console.Write("How many integers will you provide?  ");
            num = Convert.ToInt16(Console.ReadLine());
            Console.Write("Enter a number: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another number: ");
            b = Convert.ToInt32(Console.ReadLine());
            if (num == 3)
            {
                Console.Write("Enter third number: ");
                c = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("The product is " + product(a, b, c) + ".");
            }
            else
            {
                Console.WriteLine("The product is " + product(a, b) + ".");
            }
        }
        static int product(int a, int b)
        {
            Console.WriteLine("Provided integers: " + a + " and " + b + ".");
            return a * b;
        }
        static int product(int a, int b, int c)
        {
            Console.WriteLine("Provided integers: " + a + ", " + b + " and " + c + ".");
            return a * b * c;
        }
    }
}
///Sky (Peter Mariolis)
///CPS*3330*01
///Lab #2
