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
            //1.Генерируются 10 случайных целых чисел чисел в интервале (-40, 40). Вывести эти числа
            //Random random = new Random();
            //for (int i=1;i<=10;i++)
            //{
            //    int element = random.Next(-40, 40);
            //    Console.WriteLine(element);
            //}
            //2. Генерируются 15 случайных вещественных чисел в интервале (-20, 30).
            //Вывести эти числа. Подсчитать количество положительных чисел
            Random random = new Random();
            int count = 0;
            for (int i=1;i<=15;i++)
            {
                double element = -20 + 50 * random.NextDouble();
                Console.WriteLine(element);
                if (element>0)
                {
                    count++;
                }
            }
            Console.WriteLine($"Количество положительных элементов = {count}");
            //3.Генерируется 8 случайных чисел в интервале (–30, 30). Выводятся эти
            //числа и сообщения: отрицательное – положительное, четное – нечетное(for, if)
            //Random random = new Random();
            //for (int i=1;i<=8;i++)
            //{
            //    int element = random.Next(-30, 30);
            //    if (element>0)
            //    {
            //        Console.WriteLine($"{element}\t-положительное");
            //    }
            //    else if (element<0)
            //    {
            //        Console.WriteLine($"{element}\t-отрицательное");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{element}\t=0");
            //    }
            //    if (element%2==0)
            //    {
            //        Console.WriteLine($"{element}\t-чётное");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{element}\t-нечётное");
            //    }
            //}
            //4. Генерируется 10 случайных чисел в интервале (– 20, 20). Выводятся толь-
            //ко положительные числа и сообщения: четное – нечетное(for, if)
            //Random random1 = new Random();
            //for (int j=1;j<=10;j++)
            //{
            //    int element1 = random1.Next(-20, 20);
            //    if (element1>0)
            //        if (element1%2==0)
            //    {
            //        Console.WriteLine($"{element1}\t-положительное, чётное");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{element1}\t-положительное, нечётное");
            //    }
            //}


            Console.Read();
        }
    }
}
