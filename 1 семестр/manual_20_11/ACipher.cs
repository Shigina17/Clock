using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manual_20_11
{
    class ACipher : ICipher
    {
        static string all =  "abcdefghijklmnopqrstuvwxuzABCDEFGHIJKLMNOPQRSTUVWXYZабвгдеёжзийклмнопрстуфхцчшщъыьэюяАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";

        public string code;

        public ACipher(string code)
        {
            this.code = code;
        }

        public string Decode()
        {
            string str = "";

            foreach (char letter in code)
            {
                if (all.Contains(letter))
                {
                    if (letter == 'a')
                    {
                        str += 'z';
                    }
                    else if (letter == 'A')
                    {
                        str += 'Z';
                    }
                    else if (letter == 'а')
                    {
                        str += 'я';
                    }
                    else if (letter == 'А')
                    {
                        str += 'Я';
                    }
                    else
                    {
                        str += Convert.ToChar(letter - 1);
                    }
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
                if (all.Contains(letter))
                {
                    if (letter == 'z')
                    {
                        str += 'a';
                    }
                    else if (letter == 'Z')
                    {
                        str += 'A';
                    }
                    else if (letter == 'я')
                    {
                        str += 'а';
                    }
                    else if (letter == 'Я')
                    {
                        str += 'А';
                    }
                    else
                    {
                        str += Convert.ToChar(letter + 1);
                    }
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
