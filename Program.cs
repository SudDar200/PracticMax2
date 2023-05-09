using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticMax2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку:");
            string str = Console.ReadLine();
            char[] arr;
            arr = str.ToCharArray();

            bool isValid = true;
            List<char> invalidChars = new List<char>();

            foreach (char c in arr)
            {
                if (!Char.IsLower(c) || !Char.IsLetter(c))
                {
                    isValid = false;
                    invalidChars.Add(c);
                }
            }

            if (!isValid)
            {
                Console.Write("Ошибка! Введены неподходящие символы: ");
                foreach (char c in invalidChars)
                {
                    Console.Write(c + " ");
                }
                Console.WriteLine();
            }

            else if (arr.Length % 2 == 0)
            {
                string firstHalf = str.Substring(0, str.Length / 2);
                string secondHalf = str.Substring(str.Length / 2, str.Length / 2);

                Console.Write(firstHalf.Reverse().ToArray());
                Console.WriteLine(secondHalf.Reverse().ToArray());
            }

            else
            {

                Console.Write(str.Reverse().ToArray());
                Console.WriteLine(str);
            }



        }
    }
}
