using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manual_20_11
{
    class BCipher : ICipher
    {
        static string[] alphabets = {
            "abcdefghijklmnopqrstuvwxuz",
            "ABCDEFGHIJKLMNOPQRSTUVWXYZ",
            "абвгдеёжзийклмнопрстуфхцчшщъыьэюя",
            "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ"
        };

        public string code;
        public int i;

        public BCipher(string code, int i)
        {
            this.code = code;
            this.i = i;
        }

        public string Decode()
        {
            string str = "";
            foreach (char letter in code)
            {
                if (alphabets[0].Contains(letter))
                {
                    str += alphabets[0][(alphabets[0].IndexOf(letter) + (26 - i % 26)) % 26]; ;// нашли  индекс,
                                                                               // получили новую букву, добавили ее в строку
                }
                else if (alphabets[1].Contains(letter))
                {
                    str += alphabets[1][(alphabets[1].IndexOf(letter) + (26 - i % 26)) % 26];
                }
                else if (alphabets[2].Contains(letter))
                {
                    str += alphabets[2][(alphabets[2].IndexOf(letter) + (33 - i % 33)) % 33];
                }
                else if (alphabets[3].Contains(letter))
                {
                    str += alphabets[3][(alphabets[3].IndexOf(letter) + (33 - i % 33)) % 33];
                }
                else
                {
                    str += letter;
                }
            }

            return str;
        }

        public string Encode()
        {
            string str = "";

            foreach (char letter in code)
            {
                if (alphabets[0].Contains(letter))
                {
                    str += alphabets[0][alphabets[0].IndexOf(letter) + i % 26];// нашли  индекс,
                                                                               // получили новую букву, добавили ее в строку
                }
                else if (alphabets[1].Contains(letter))
                {
                    str += alphabets[1][alphabets[1].IndexOf(letter) + i % 26];
                }
                else if (alphabets[2].Contains(letter))
                {
                    str += alphabets[2][alphabets[2].IndexOf(letter) + i % 33];
                }
                else if (alphabets[3].Contains(letter))
                {
                    str += alphabets[3][alphabets[3].IndexOf(letter) + i % 33];
                }
                else
                {
                    str += letter;
                }
            }

            return str;
        }
    }
}
