using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamaczHaselClient
{
    class PasswordTransformator
    {
        public static string addNumber(string password, int number)
        {
            return password + number;
        }

        public static string addSamePassword(string password)
        {
            return password + password;
        }

        public static string firstUpperCase(string password)
        {
            if (string.IsNullOrEmpty(password))
            {
                return string.Empty;
            }
            return char.ToUpper(password[0]) + password.Substring(1);
        }

        public static string makeUpper(string password, int option)
        {
            char[] letters = password.ToCharArray();
            switch (option)
            {
                case 1:
                    for (int i = 0; i < letters.Length; i++)
                    {
                        if (i % 2 == 0)
                        {
                            letters[i] = char.ToUpper(letters[i]);
                        }
                    }
                    return new String(letters);
                case 2:
                    for (int i = 0; i < letters.Length; i++)
                    {
                        if (i % 2 != 0)
                        {
                            letters[i] = char.ToUpper(letters[i]);
                        }
                    }
                    return new String(letters);
                default:
                    return password;
            }
        }

        public static string replaceLetter(string password, string oldValue, string newValue)
        {
            return password.Replace(oldValue, newValue);
        }

        public static string addSome(string s)
        {
            return s + "_";
        }

        public static string bracket(string s)
        {
            s = "(" + s + ")!";
            return s;
        }

        public static string addNumberA(string s)
        {
            Random r = new Random();
            int number = r.Next(10, 99);

            s = s + number;
            return s;
        }

        public static string addNumberB(string s)
        {
            Random r = new Random();
            int number = r.Next(10, 99);

            s = number + s;
            return s;
        }

        public static string addNumberAB(string s)
        {
            Random r = new Random();
            int number = r.Next(10, 99);
            int number1 = r.Next(10, 99);

            s = number1 + s + number;
            return s;
        }

        public static string replaceAtIndex(string s, char oldChar, char newChar)
        {
            char[] letters = s.ToCharArray();
            letters[s.IndexOf(oldChar)] = newChar;
            return string.Join("", letters);
        }

        public static string replaceAllTheSameLetter(string s)
        {

            char[] let = s.ToCharArray();

            for (int i = 0; i < let.Length; i++)
            {
                switch (let[i])
                {
                    case 'a':
                        let[i] = '@';
                        break;
                    case 'A':
                        let[i] = '4';
                        break;
                    case 'o':
                        let[i] = '0';
                        break;
                    case 'O':
                        let[i] = '0';
                        break;
                    case 's':
                        let[i] = '$';
                        break;
                    case 'S':
                        let[i] = '$';
                        break;

                }
            }


            return new string(let);

        }

        public static string addSign(string s, string[] sign)
        {

            Random r = new Random();
            int sChar = r.Next(0, sign.Length);

            s = s.Insert(sChar, sign[sChar]);

            return s;
        }

    }
}
