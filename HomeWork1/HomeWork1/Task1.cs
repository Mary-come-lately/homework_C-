using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    public static class Task1
    {
        public static void Exs1()
        {


            Console.WriteLine("Enter the elements of array A: ");
            int[] A = new int[5];
            for (int i = 0; i < 5; i++)
            {
                A[i] = int.Parse(Console.ReadLine());
            }


            //Максимальный элемент
            Array.Sort(A);
            int maxValue = A[A.Length - 1];
            Console.WriteLine();
            Console.WriteLine("Max element of array A: ");
            Console.Write(maxValue);

            //Минимальный элемент
            int minValue = A.Min();

            for (int i = 0; i < 5; i++)
            {
                Console.Write(A[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Min element of array A: ");
            Console.Write(minValue);

            //Сумма всех элементов
            Console.WriteLine();
            Console.WriteLine("Sum of elements of array A: " + A.Sum());
            Console.WriteLine();

            //Сумма всех четных элементов
            Console.WriteLine();
            Console.WriteLine("Sum of even elements of array A: ");
            int summ = 0;
            for (int i = 0; i < 5; i++)
            {
                if (A[i] % 2 == 0)
                    summ += A[i];
            }
            Console.WriteLine(summ);

            //Произведение всех элементов
            Console.WriteLine("The result of element of array: ");
            int result = 1;
            for (int i = 1; i < 5; i++)
            {
                result *= A[i];
            }
            Console.WriteLine(result);
            Console.WriteLine();
            Console.ReadKey();

            //Массив B
            Console.WriteLine();
            Console.WriteLine("Array B: ");
            double[,] B = new double[3, 4];
            Random random = new Random();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    B[i, j] = random.Next(-50, 50) / 10.0;
                    Console.Write("{0} \t", B[i, j]);

                }
                Console.WriteLine();
            }

            Console.WriteLine();
            //Максимальный элемент
            Console.WriteLine("Max element of array B: ");
            int maxVal = B.Cast<int>().Max();
            Console.WriteLine(maxVal);

            Console.WriteLine();
            //Минимальный элемент
            Console.WriteLine("Min element of array B: ");
            double minVal = B.Cast<double>().Min();
            Console.WriteLine(minVal);

            //Сумма всех элементов
            Console.WriteLine();
            double sum = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    sum += B[i, j];
                }
            }
            Console.WriteLine("Sum of elements of array B: ");
            Console.WriteLine(sum);

            //Сумма элементов нечетных столбцов
            Console.WriteLine();
            double sumEven = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (j % 2 != 0)
                        sumEven += B[i, j];
                }
            }
            Console.WriteLine("Sum of  elements of all odd columns of array B: ");
            Console.WriteLine(sumEven);

            //Произведение всех элементов
            Console.WriteLine();
            double res = 1.0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    res *= B[i, j];
                }
            }
            Console.WriteLine("Result of elements of array B: ");
            Console.WriteLine(res);

            Console.ReadKey();

        }
    }
}