using System;

/*
===== Operadores Relacionales =====
    >   : Mayor que
    <   : Menor que
    >=  : Mayor o igual que
    <=  : Menor o igual que
    !=  : Distinto que
    ==  : Igual a/que
    
===== Operadores Lógicos =====
    ||  : OR
    &&  : AND
       
*/

namespace OperadoresLogicos{
    class Program{
        static void Main(string[] args){
            double peso;
            byte edad;

            Console.WriteLine("Peso: ");
            peso = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Edad: ");
            edad = Convert.ToByte(Console.ReadLine());

            Console.Clear();

            if (peso > 100 && edad >= 15) 
                Console.WriteLine("Peso mayor a 100 y Edad mayor a 15");
            if (peso < 100 || edad < 100)
                Console.WriteLine("Peso o edad menor a 100");
            if (peso >= 100)
                Console.WriteLine("Peso mayor o igual a 100.");
            if (peso <= 100)
                Console.WriteLine("Peso menor o igual a 100.");
            if (peso != 100)
                Console.WriteLine("Peso distinto a 100.");
            if (peso == 100)
                Console.WriteLine("Peso igual a 100.");

            Console.ReadKey();

        }
    }
}
