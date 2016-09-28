using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsUse
{
    class ParamsUse
    {
        static void Main(string[] args)
        {
            UseParams(1, 2, 3, 4,5,6);
            UseParams2(1, 'a', "test",5,"objects");

            int[] newNumbers = { 1, 2, 3, 4 };

            foreach (int Value in newNumbers)
                {
                Console.WriteLine(Value);
                }
            
            string word = "you are awsome";
            char[] reverseCharecter = word.ToCharArray();
            reverseString(reverseCharecter);
            Console.ReadKey();

        }

        public static void UseParams(params int[] num)
        {
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write(num[i] + " ");
            }
            Console.WriteLine();
        }

        public static void UseParams2(params object[] allKind)
        {
            for (int i = 0; i < allKind.Length; i++)
            {
                Console.Write(allKind[i] + " ");
            }
            Console.WriteLine();
        }
        public static void reverseString(params char[] givenLine)
        {
            for(int i = givenLine.Length-1; i >=0; i--)
            {
                Console.WriteLine(givenLine[i]);
            }
        }
    }
}
