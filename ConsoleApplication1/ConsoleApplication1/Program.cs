using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] group1 = new int[] { 1, 1, 1 };
            int[] group2 = new int[] { 1, 1, 1, 1 };
            int[] group3 = new int[] { 1, 1, 1, 1, 1, 1 };
            PrintGame(group1, group2, group3);
            Console.WriteLine();



        }
        public static void PrintGame(int[] group1,int[] group2, int[]group3)
        {
            Console.Write("group num 1:");
            for (int i = 0; i < group1.Length; i++)
            {
                Console.Write('o'); 
            }
            Console.WriteLine();
            Console.Write("group num 2:");
            for (int i = 0; i < group2.Length; i++)
            {
                Console.Write('o');
            }
            Console.WriteLine();
            Console.Write("group num 3:");
            for (int i = 0; i < group3.Length; i++)
            {
                Console.Write('o');
            }
        }
        public static int sumGroup(int[] group1, int[] group2, int[] group3)
        {
            int sum1 = 0;
            int sum2 = 0;
            int sum3 = 0;
            for (int i = 0; i < group1.Length; i++)
            {
                sum1 += group1[i];
            }
            for (int i = 0; i < group2.Length; i++)
            {
                sum2 += group2[i];
            }
            for (int i = 0; i < group3.Length; i++)
            {
                sum3 += group3[i];
            }
            return 
        }
        public static bool Has1Group(int[] group1, int[] group2, int[] group3)
        {
            if (group1 )
        }

    }
}
