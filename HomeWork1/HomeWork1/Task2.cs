using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{

    public static class Task2
    {
        public static void Exs2()
        {
            //Массив А
            Console.WriteLine("Array A: ");
            int[] A = new int[5];
            for (int i = 0; i < 5; i++)
            {
                A[i] = int.Parse(Console.ReadLine());
            }

            //Массив В
            Console.WriteLine();
            Console.WriteLine("Array B: ");
            int[] B = new int[10];
            for (int i = 0; i < 10; i++)
            {
                B[i] = int.Parse(Console.ReadLine());
            }

            // Отсортированный массив С
            Console.WriteLine();
            Console.WriteLine("Array C: ");
            IEnumerable<int> both = A.Intersect(B);
            foreach (int c in both)
                Console.Write(c + " ");

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
