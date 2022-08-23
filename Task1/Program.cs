using System;

namespace HomeTasks_KisEA
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.Write("Введите первое целое число: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе целое число: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("Наибольшее число " + num1);
            }
            else
            {
                Console.WriteLine("Наибольшее число " + num2);
            }

        }
    }
}