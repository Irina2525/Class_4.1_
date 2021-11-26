using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_4._1_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число N > 0");
            int N, sqr;
            N = Convert.ToInt32(Console.ReadLine());
            sqr = 0;
            for (int i = 1; i <= N; i++)
            {
                if
                 (i > N)
                    break;
                Console.WriteLine("Квадрат числа {0} = {1} ", i, sqr += i * 2 - 1);
            }
            Console.ReadKey();
        }
    }
}