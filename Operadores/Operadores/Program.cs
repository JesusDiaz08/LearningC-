using System;

/*
    ===== OPERADORES =====
    '='     : Operador de Asignación.
    '+='    : Estos operadores evitan que se hagan las conversiones del tipo de 
    '-='      que se desea, cada vez que quieres realizar una operacion aritmética
    '*='      Se aplica para cada uno de los operadores aritméticos.
    '/='

    ===== OPERADORES ARIMTMÉTICOS =====
    '+'     : Este operador esta sobre cargado, ya que se puede usar para:
                    - Sumar dos valores
                    - Concatenar cadenas
    '-'     : Operador de resta
    '*'     : Operador de Multiplicación
    '/'     : Operador de división
    '%'     : Operador de módulo

    ===== MATH =====
    Las operaciones como potenciación y raíz cuadrada, están dentro de la libreria System incluidas.
    En C# no hay potenciación directa. 
*/


namespace Operadores
{
    class Program{
        static void Main(string[] args){

            int asgn = 1002;
            Console.WriteLine("Asignacion : " + asgn);

            asgn += 201;
            Console.WriteLine("Usando '+=' : " + asgn);

            asgn -= 21;
            Console.WriteLine("Usando '-=' : " + asgn);

            asgn *= 18;
            Console.WriteLine("Usando '*=' : " + asgn);

            asgn /= 8;
            Console.WriteLine("Usando '/=' : " + asgn);

            int suma = 29 + 21;
            Console.WriteLine("La suma es: " + suma);

            int resta = 58 - 36;
            Console.WriteLine("La resta es: " + resta);

            int mult  = 20 * 10;
            Console.WriteLine("La multiplicación es: " + mult);

            int div = 18 / 3;
            Console.WriteLine("La división es: " + div);

            int mod = 62 % 24;
            Console.WriteLine("El modulo es: " + mod);

            /*Entrada estándar para la potencia*/
            double pot, num, result;
            Console.WriteLine("Numero: ");
            num = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Potencia: ");
            pot = Convert.ToDouble(Console.ReadLine());

            result = Math.Pow(num, pot);
            Console.WriteLine(num + "^" + pot + " = " + result);

            //Raiz cuadrada
            double raiz = Math.Sqrt(result);
            Console.WriteLine("Raiz cuadrada: " + raiz);

            Console.ReadLine();
        }
    }
}
