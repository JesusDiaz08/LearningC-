using System;

/*
 ========== TIPOS DE DATOS ==========
    byte    : 0 to 255
    int     : -2147483648 to 2147483647
    double  : Datos flotantes.
    boolean : Solo true and false
    char    : Solo acepta un caracter.
    string  : Acepta una cadena de caracteres.
    dynamic : Se usa para "intentar" adivinar el tipo de dato
              que el usuario ingreso.
*/


namespace HolaMundo
{
    class Program{
        static void Main(string[] args){

            byte var_byte = 255;
            Console.WriteLine("Rango de byte de: 0 -" + var_byte);

            int var_int = 2147483647;
            Console.WriteLine("Rango de int de: -2147483648 -" + var_int);


            double var_double = 2147.483647;
            Console.WriteLine("Valor de un double es: " + var_double);
            
            bool var_bool = true;
            Console.WriteLine("Valor booleano: " + var_bool);


            char var_char = 'B';
            Console.WriteLine("Valor de un char: " + var_char);

            string var_string = "Esta es una frase";
            Console.WriteLine("Aqui hay un String: " + var_string);

            dynamic var_dynamic = "Esto es un String";
            dynamic var_dynamic2 = 1;

            Console.WriteLine("Dynamica 01: " + var_dynamic);
            Console.WriteLine("Dynamica 02: " + var_dynamic2 + "\n");

            Console.ReadKey();
            
        }
    }
}
