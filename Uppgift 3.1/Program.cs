﻿using System;

namespace Uppgift_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur gammal är du?");
            int ålder = int.Parse(Console.ReadLine());

            if (ålder >= 16 &&  ålder <= 19)
            {
                Console.WriteLine("Du får delta i tävlingen.");
            }
            else if (ålder < 16)
            {
                Console.WriteLine("Du är för ung för att få delta i tävlingen.");
            }
            else
            {
                Console.WriteLine("Du är för gammal för att få delta i tävlingen.");
            }
            Console.ReadKey();

                    

                    

            
            
        }
    }
}

