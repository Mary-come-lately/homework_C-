using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    public static class Task5
    {
        public static void Exs5()
        {
            Console.WriteLine("Array: ");
            int[,] B = new int[5, 5];
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    B[i, j] = random.Next(-100, 100);
                    Console.Write("{0} \t", B[i, j]);

                }
                Console.WriteLine();
            }

            Console.WriteLine();
            //Минимальный элемент
            Console.WriteLine("Min element of array B: ");
            int minVal = B.Cast<int>().Min();
            Console.WriteLine(minVal);

            Console.WriteLine();
            //Индекс минимального элемента
            Console.WriteLine("Index of min element: ");
            IEnumerable<int> elMin = B.Cast<int>();
            int indMin = elMin.Min();
            int min_i = 0;
            int min_j = 0;//2. Находим индекс минимального элемента
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    if (B[i, j].Equals(indMin))
                    {
                        min_i = i;
                        min_j = j;
                        Console.Write(i + "\n" + j);
                        //выход из цикла
                        i = B.GetLength(0);
                        break;
                    }
                }
            }


            Console.WriteLine();
            //Максимальный элемент
            Console.WriteLine("Max element of array B: ");
            int maxVal = B.Cast<int>().Max();
            Console.WriteLine(maxVal);

            Console.WriteLine();
            //Индекс максимального элемента
            Console.WriteLine("Index of max element: ");
            IEnumerable<int> elMax = B.Cast<int>();
            int indMax = elMax.Max();
            int max_i = 0;
            int max_j = 0;

            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    if (B[i, j].Equals(indMax))
                    {
                        max_i = i;
                        max_j = j;
                        Console.Write(max_i + "\n" + max_j);
                        //выход из цикла
                        i = B.GetLength(0);
                        break;
                    }
                }
            }

            //Сумма элементов между минимальным и максимальным значениями
            Console.WriteLine();
            Console.WriteLine("Sum of elements of array B: ");

            int sum = 0;
            if (min_j < max_j)
            {
                for (int i = min_i; i <= max_i; i++)
                {
                    for (int j = min_j; j <= max_j; j++)
                    {
                        sum += B[j, i];
                    }
                }
            }
            else if (min_j == max_j || min_i > max_i)
            {
                for (int i = max_i; i <= min_i; i++)
                {
                    for (int j = max_j; j <= min_j; j++)
                    {
                        sum += B[i, j];
                    }
                }
            }

            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
