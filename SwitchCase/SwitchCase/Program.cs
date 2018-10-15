﻿using System;

/* ===== switch-case =====
    Esta estructura acepta también 
    las cadenas verificando lexicograficamente esta
*/


namespace SwitchCase{
    class Program{
        static void Main(string[] args){

            byte dia;

            Console.WriteLine("Day: ");
            dia = Convert.ToByte(Console.ReadLine());

            switch ( dia ){
                case 1:
                    Console.WriteLine("Sunday");    break;
                case 2:
                    Console.WriteLine("Monday");    break;
                case 3:
                    Console.WriteLine("Tuesday");   break;
                case 4:
                    Console.WriteLine("Wednesday"); break;
                case 5:
                    Console.WriteLine("Thursday");  break;
                case 6:
                    Console.WriteLine("Friday");    break;
                case 7:
                    Console.WriteLine("Saturday");  break;
                default:
                    Console.WriteLine("No es dia"); break;
            }

            Console.ReadKey();

        }
    }
}
