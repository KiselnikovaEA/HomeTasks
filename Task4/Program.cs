using System; // Программа принимает на ввод число N и выводит все четные числа от 1 до N

namespace HomeTasks_KisEA
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.Write("Введите неотрицательное целое число: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int i = 2;

            if(num >= i)
            {
            Console.Write("Все четные числа от 1 до " + num + ": ");

                while(i <= num)
                {
                    Console.Write(i + " ");
                    i = i + 2;
                }

            }
            else
            {
                Console.Write("Введите число побольше");
            }

        }
    }
}