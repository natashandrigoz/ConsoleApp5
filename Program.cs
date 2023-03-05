using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Генерируется 8 случайных чисел в интервале (–30, 30). Выводятся эти
            // числа и сообщения: отрицательное – положительное, четное – нечетное(for, if)
            Random random = new Random();
            for (int i=1;i<=8;i++)
            {
                int element = random.Next(-30, 30);
                if (element>0)
                {
                    Console.WriteLine($"{element}\t-положительное");
                }
                else if (element<0)
                {
                    Console.WriteLine($"{element}\t-отрицательное");
                }
                else
                {
                    Console.WriteLine($"{element}\t=0");
                }
                if (element%2==0)
                {
                    Console.WriteLine($"{element}\t-чётное");
                }
                else
                {
                    Console.WriteLine($"{element}\t-нечётное");
                }
            }
            Console.Read();
        }
    }
}
