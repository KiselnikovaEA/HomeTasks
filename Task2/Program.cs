using System; // Программа принимает на вход три числа и выдает наибольшее из них

namespace HomeTasks_KisEA
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine("Нужно ввести три целых числа");
            Console.Write("Введите первое число: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите третье число: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 >= num2 && num1 >=num3)
            {
                Console.WriteLine("Наибольшее число " + num1);
            }
            else if (num2 >= num1 && num2 >=num3)
            {
                Console.WriteLine("Наибольшее число " + num2);
            }
            else
            {
                Console.WriteLine("Наибольшее число " + num3);
            }

        }
    }
}

/*
using System;

namespace HomeTasks_KisEA
{
    class Program
    {
        static void Main (string[] args)
        {

            int[] nums = new int[3];
            int i = 1;

            Console.WriteLine("Нужно ввести три целых числа");
            while(i <= 3)
            {
                Console.Write("Введите " + i + " число: ");
                nums[i - 1] = Convert.ToInt32(Console.ReadLine());
                i++;
            }

            int max = nums[0];

            for(i = 1; i < nums.Length; i++)
            {
                if(nums[i] > max)
                {
                    max = nums[i];
                }
            }
            Console.WriteLine("Максимальное число: " + max);

        }
    }
} 
*/