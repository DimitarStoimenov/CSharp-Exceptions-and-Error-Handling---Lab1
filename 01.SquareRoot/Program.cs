using System;

namespace SquareRoot
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            try
            {

                TrySqrt(num);
                Console.WriteLine(Math.Sqrt(num));

            }
            catch (Exception ae)
            {

                Console.WriteLine(ae.Message); 
                
                
            }
            finally
            {
                Console.WriteLine("Goodbye.");
            }
        }

        public static int TrySqrt(int num)
        {
            
            if (num < 0)
            {
                throw new ArgumentException("Invalid number.");
            }

           
            return num;

        }
    }
}
