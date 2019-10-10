using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5a
{
    class Program
    {
        static void Main(string[] args)
        {
            Print_a_2_z_v1();
            Print_a_2_z_v2();
            Print_a_2_z_v3();
            Print_a_2_z_v4();
        }

        public static void Print_a_2_z_v1()
        {
            char[] az = Enumerable.Range('a', 'z' - 'a' + 1).Select(i => (Char)i).ToArray();
            foreach (var c in az)
            {
                Console.WriteLine(c);

            }
        }
        public static void Print_a_2_z_v2()
        {
            char c = 'a';
                for (int i = 0; i < 26; i++)
                {
                    Console.WriteLine(c);
                        c++;
                }
        }
        public static void Print_a_2_z_v3()
        {
            for (char c = 'a'; c <= 'z' ; c++)
            {
                Console.WriteLine(c);
            }
        }
        public static void Print_a_2_z_v4()
        {
           string s =  "abcdefghijklmnopqrstuwyz";
            for (int i = 0; i < s.Length; i ++)
            {
                Console.WriteLine(s[i]);
            }
        }
        public static bool IsUpper(char c)
        {
            for (int i = 65; i < 90; i++)
            {
                Console.Write(i);
                if (c.Equals(i))
                    return true;
            }
            return false;
        }
        public static bool IsLower(char c)
        {
            for (int i = 97; i < 122; i++)
            {
                Console.Write(i);
                if (c.Equals(i))
                    return true;
            }
            return false;
        }
        public static bool IsUpper1(char c)
        {
            for (int i = 97; i < 122; i++)
            {
                Console.Write((char)i);
                if (c.Equals((char)i))
                    return false;
            }
            return true;
        }
        public static bool IsLower1(char c)
        {
            for (int i = 65; i < 90; i++)
            {
                Console.Write((char)i);
                if (c.Equals((char)i))
                    return false;

            }
            return true;
        }
        public static char ToUpeper(char c)
        {
           // int b = Char2Code(c);
            //b = b - 32;
            //c = (char)b;

            return c;
        }
        public static char ToLower(char c)
        {
            //int b = Char2Code(c);
            //b = b + 32;
            //c = (char)b;
            return c;
        }
    }
}
