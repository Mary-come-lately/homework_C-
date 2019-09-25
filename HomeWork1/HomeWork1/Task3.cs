using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    public static class Task3
    {
        public static void Exs3()
        {
            Console.WriteLine("Enter the string: ");
            string str = Console.ReadLine();
            string s = str.Replace(" ", "");
            string rts = new string(s.ToCharArray().Reverse().ToArray());

            if (s == rts)
                Console.WriteLine("String is palindrom");
            else
                Console.WriteLine("String isn't palindrom");

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
