using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_9
{
    internal class ACipher : ICipher
    {
        StringBuilder str { get; set; }

        /// <summary>
        /// расшифровывает строку
        /// </summary>
        /// <param name="str"></param>
        public ACipher(string str) 
        {
            this.str = new StringBuilder(str);            
        }
        public string Decode()
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (Char.ToLower(str[i]) != 'a' && Char.ToLower(str[i]) != 'а')
                {
                    str[i] = (char)(str[i] - 1);
                }
            }
            return str.ToString();
        }
        /// <summary>
        /// шифрует строку
        /// </summary>
        /// <returns></returns>
        public string Encode()
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (Char.ToLower(str[i]) != 'z' && Char.ToLower(str[i]) != 'я')
                {
                    str[i] = (char)(str[i] + 1);
                }
            }
            return str.ToString();
        }
    }
}
