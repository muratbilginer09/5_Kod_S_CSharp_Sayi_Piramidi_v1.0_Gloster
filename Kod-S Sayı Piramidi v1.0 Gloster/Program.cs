﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kod_S_Sayı_Piramidi_v1._0_Gloster
{
    class Program
    {
        static void Main(string[] args)
        {

            int i, j, n;

            Console.Write("Piramit Basamak Değerini Giriniz:");
            n = int.Parse(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
