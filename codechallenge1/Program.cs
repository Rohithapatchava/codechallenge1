using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codechallenge1
{
    class Program
    {
        static void Main(string[] args)
        {
            Numbertoword();
            Console.ReadKey();
        }

        private static void Numbertoword()
        {
            Props p = new Props();
            int[] a = new int[4];
            string[] word_digits =
                {
                    "Zero",
                    "One",
                    "Two",
                    "Three",
                    "Four",
                    "Five",
                    "Six",
                    "Seven",
                    "Eight",
                    "Nine"
                };
            // p.next = 0;
            //p.num_digits = 0;
            Console.WriteLine("Enter an Integer to convert");
            p.val = int.Parse(Console.ReadLine());
            Console.WriteLine("Number: {0}", p.val);
            Console.WriteLine("Number (Words) : ");

            while (p.val > 0)
            {
                p.next = p.val % 10;
                a[p.num_digits] = p.next;
                p.num_digits++;
                p.val /= 10;
            }


            //p.num_digits--;
            for (int i = a.Length - 1; i >= 0; i--)
                // for(int i=0;i<=0;i--)
                Console.WriteLine(word_digits[a[i]]);
            Console.ReadLine();
        }
    }
}


