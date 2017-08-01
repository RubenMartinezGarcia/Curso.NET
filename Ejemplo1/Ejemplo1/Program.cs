using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            var cadena = "Hello";
            for (int i = 0; i < 1000000; i++)
            {
                cadena = cadena + i.ToString();
            }
            Console.WriteLine(cadena);
            Console.ReadLine();

            var sb = new StringBuilder();
            sb.Append("Hello");
            for (int i = 0; i < 1000000; i++)
            {
                sb.Append(i);
            }
        }
    }
}
