using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo7
{
    class Program
    {
        static void Main(string[] args)
        {
            var result1 = iterar();
            var numbers = new List<int>()
            {
                1, 2, 3
            };
            var result = numbers.Where(n=>n>1).ToList();
            foreach (var value in result)
            {

            }
            Console.WriteLine(result.GetType().Name);
            Console.ReadLine();
        }
        static bool iterar()
        {
            foreach (var i in Iterator())
            {
                Console.WriteLine(i);
                if (i == 0) return false;
            }
            return true;
        }
        static bool Predicate(int value)
        {
            Console.WriteLine("He entrado");
            return value > 1;
        }
        static IEnumerable<int> Iterator()
        {
            for (int i = 0; i < 100; i++)
            {
                yield return i;
            }
        }
    }
    public static class ExtensionInt
    {
        public static bool Between(this int value, int from, int to)
        {
            return value >= from && value <= to;
        }
    }
}
