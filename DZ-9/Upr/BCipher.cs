using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DZ_9
{
    internal class BCipher : ICipher
    {
        StringBuilder str { get; set; }
        Dictionary<int, char> let;

        public BCipher(string str, Dictionary<int, char> let)
        {
            this.let = let;
            this.str = new StringBuilder(str);
        }
        /// <summary>
        /// шифрует строку
        /// </summary>
        /// <returns></returns>
        public string Encode()
        {
            for (int i = 0; i < str.Length; i++)
            {
                int temp = 0;
                for (int j = 1; j < let.Count + 1; j++) 
                {
                    if (str[i] == let[j])
                    {
                        temp = j;
                        break;
                    }
                }
                temp = temp - 1;
                str[i] = let[26 - temp]; 
            }
            return str.ToString();
        }
        /// <summary>
        /// расшифровывает строку
        /// </summary>
        /// <returns></returns>
        public string Decode()
        {
            for (int i = 0; i < str.Length; i++)
            {
                int temp = 0;
                for (int j = 1; j < let.Count + 1; j++)
                {
                    if (str[i] == let[j])
                    {
                        temp = j;
                        break;
                    }
                }
                temp = temp - 1;
                str[i] = let[26 - temp];
            }
            return str.ToString();
        }
    }
}
