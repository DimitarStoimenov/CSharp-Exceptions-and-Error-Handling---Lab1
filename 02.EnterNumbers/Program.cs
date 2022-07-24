using System;
using System.Collections.Generic;
using System.Linq;

namespace EnterNumbers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int start = 1;
            int end = 100;
            List<string> numbs = new List<string>();

            while (numbs.Count != 10)
            {
                try
                {
                    string num = Console.ReadLine();
                    ReadNumber(start, end, num);
                    numbs.Add(num);
                    start = int.Parse(num);
                }
                catch (ArgumentException re)
                {

                    Console.WriteLine(re.Message);
                }
                catch(Exception ae)
                {
                    Console.WriteLine(ae.Message);
                }
            }

            Console.WriteLine(string.Join(", ", numbs));
        }

        private static void ReadNumber(int start,  int end, string num)
        {
            int number;
            bool success = int.TryParse(num, out number);

            if (!success)
            {
                throw new Exception("Invalid Number!");
            }
            
            else if (number <= start || number > end)
            {
                
                    throw new ArgumentException($"Your number is not in range {start} - 100!");
            }
            
        }
    }
}
