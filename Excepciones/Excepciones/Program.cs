using System;

namespace Excepciones{
    class Program{
        static void Main(string[] args){

            double precio, total;
            int cantidad;

            /* ... Try-Catch ... */
            try{
                Console.WriteLine("Cantidad: ");
                cantidad = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("Cantidad: ");
                precio = Convert.ToDouble(Console.ReadLine());

                total = cantidad * precio;
                Console.WriteLine("Total: " + total);

            }catch (FormatException error){
                Console.WriteLine("There was an exception.\n" + error);
            }

            Console.ReadKey();
        }
    }
}
