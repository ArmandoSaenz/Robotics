using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mathematics.Vectors;

namespace Tester
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Probador para producto punto");
            float[] x, y;
            string data;
            string[] elements;
            float result;
            while (true)
            {
                try
                {
                    Console.WriteLine("Ingresa el primer vector separando los elementos con una coma");
                    data = Console.ReadLine();
                    elements = data.Split(',');
                    x = Array.ConvertAll(elements, new Converter<string, float>(float.Parse));
                    Console.WriteLine("Ingresa el segundo vector separando los elementos con una coma");
                    data = Console.ReadLine();
                    elements = data.Split(',');
                    y = Array.ConvertAll(elements, new Converter<string, float>(float.Parse));
                    result = Operations.PointProduct(x, y);
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Console.WriteLine($"El producto punto es {result}" );
            Console.ReadKey();
        }
    }
}
