using System.Security.Cryptography.X509Certificates;

namespace ConsoleInputSample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            InputNumbers();

        }
        public static void InputNumbers()
        {
            var nums = Console.ReadLine().Split().Select(int.Parse);

            Console.WriteLine("The sum is: ");
            Console.WriteLine(nums.Sum());
        }
    }
    }
