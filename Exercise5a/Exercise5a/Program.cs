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
    }
}
