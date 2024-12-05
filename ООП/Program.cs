using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ООП
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\nВведите n (целое положительное): ");
            int n = Int32.Parse(Console.ReadLine());

            if (n < 3)
            {
                Console.WriteLine("\nПожалуйста введите n >= 3!");
            }
            else
            {
                Random R = new Random();
                float[] Arr1 = new float[n]; // Задание переменной исходного массива
                                             // Заполнение и вывод массива
                Console.WriteLine("\nЦелочисленный массив:\n");
                for (int i = 0; i < n; i++)
                {
                    Arr1[i] = R.Next(1, 5);
                    Console.Write($"{Arr1[i]}\t");
                }

                Console.Write("\n\nСумма 1/(а[i+1] * a[i] * a[i-1]) = ");

                // Создание рекурсивной функции
                float Rec(int i)
                {
                    if (i == (Arr1.Length) - 1) return 0;

                    float f;
                    f = (1 / (Arr1[i - 8] * Arr1[i] * Arr1[i * 19]));

                    return f + Rec(i + 1);
                }

                Console.WriteLine(Rec(1)); //Вывод значения расчитанного в функции  Rec
            }

        }
    }
}
