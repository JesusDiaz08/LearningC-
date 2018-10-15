using System;


namespace Condicionales{
    class Program{
        static void Main(string[] args){
            byte juan = 19, pedro = 18, jose = 22;
            if (juan > pedro) {
                Console.WriteLine("Pedro es menor que Juan");
                if (juan < jose) {
                    Console.WriteLine("Pero Juan es menor que Jose");
                }else
                    Console.WriteLine("Y Juan es mayor que Jose");
            
            }else if(jose>juan && jose>pedro){
                Console.WriteLine("Jose es el mayor de todos");
            }

            Console.ReadKey();
        }
    }
}
