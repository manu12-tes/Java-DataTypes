using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Java_DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("dame un numero de solicitudes : ");
            int repeticiones = Convert.ToInt32(Console.ReadLine());
            for (int x = 0; x < repeticiones; x++)
            {
                long y = long.Parse(Console.ReadLine());
                Console.WriteLine("puede concvertirse en  : ");
                if (y >= -128 && y <= 127) { Console.WriteLine("* sbyte"); }
                else if (y >= 0 && y <= 255) { Console.WriteLine("* byte"); }
                else if (y >= -32768 && y <= 32767) { Console.WriteLine("* short"); }
                else if (y >= -2147483648 && y <= 2147483647) { Console.WriteLine("* int"); }
                else if (y >= -9223372036854775808 && y <= 9223372036854775807) { Console.WriteLine("* Long"); }
                else { Console.WriteLine("* No se puede converitr"); }
            }
        }
    }
}
