using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    public static class Task4
    {
        public static void Exs4()
        {
            Console.WriteLine("Enter the sentence: ");
            string sentence = Console.ReadLine();
            int count = 0;
            if (sentence.Length > 0)
            {
                count = 1;
                for (int i = 0; i < sentence.Length; i++)
                {
                    if (sentence[i] == ' ' || (sentence[i] == ' ' && sentence[i + 1] == ' '))
                    {
                        count++;
                    }

                }
            }
            else
            { count = 0; }
            Console.WriteLine(count);
        }
    }
}
