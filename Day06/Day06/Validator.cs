using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06
{
    internal static class Validator
    {
        public static int ValidateInt(string text, int first, int last)
        {
            int Choose;
            bool IsParsed;
            do
            {
                Console.Write(text);
                IsParsed = int.TryParse(Console.ReadLine(), out Choose);
            } while (!IsParsed || (Choose < first || Choose>last));
            return Choose;
        }
        public static int ValidateInt(string text, int num)
        {
            int Choose;
            bool IsParsed;
            do
            {
                Console.Write(text);
                IsParsed = int.TryParse(Console.ReadLine(), out Choose);
            } while (!IsParsed || (Choose < num));
            return Choose;
        }
        public static int ValidateInt(int first, int last)
        {
            int Choose;
            bool IsParsed;
            do
            {
                IsParsed = int.TryParse(Console.ReadLine(), out Choose);
            } while (!IsParsed || (Choose < first && Choose > last));
            return Choose;
        }
        public static int ValidateInt(int num)
        {
            int Choose;
            bool IsParsed;
            do
            {
                IsParsed = int.TryParse(Console.ReadLine(), out Choose);
            } while (!IsParsed || (Choose < num ));
            return Choose;
        }
    }
}
