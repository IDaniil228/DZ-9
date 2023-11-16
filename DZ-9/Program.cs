using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] c = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            int key = 1;
            Dictionary<int, char> dictionary = new Dictionary<int, char>();
            foreach (char value in c)
            {
                dictionary.Add(key, value);
                key++;
            }
            Console.WriteLine("Введите строку");
            ACipher str = new ACipher(Console.ReadLine());
            Console.WriteLine(str.Encode());
            Console.WriteLine(str.Decode());
            Console.WriteLine("Введите строку");

            BCipher str_1 = new BCipher(Console.ReadLine(), dictionary);
            Console.WriteLine(str_1.Encode());
            Console.WriteLine(str_1.Decode());
            Console.ReadKey();


        }
    }
}
