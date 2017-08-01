using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo2
{
    class Program
    {
        static void Main(string[] args)
        {
            var importe = 133;
            var result = 0;
            var valid = Change(importe, out result);
            if (!valid)
            {
                throw new Exception("importe invalido");
            }
            Console.ReadLine();

        }

        static bool Change(int importe, out int change)
        {
            var result = true;
            switch (importe)
            {
                case 500:
                    {
                        change = 75;
                        return result;
                    }
                case 200:
                    {
                        change = 50;
                        return result;
                    }
                case 100:
                    {
                        change = 30;
                        return result;
                    }
                default:
                    {
                        change = 0;
                        return result;
                    }
            }
            change = 0;
            return result;
        }
    }
}
