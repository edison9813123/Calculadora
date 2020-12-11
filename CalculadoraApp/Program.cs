using System;

namespace CalculadoraApp
{
    class Program
    {
        static void Main(string[] args)
        {
            

            // Declaramos las variables e iniciamos desde cero.
            int num1 = 0; int num2 = 0;

             //se coloca el primer numero.
             Console.WriteLine("Ingrese Su Primer Número ");
             num1 = int.Parse(Console.ReadLine());

             // se coloca el segundo numero.
             Console.WriteLine("Ingrese Su Segundo Número");
             num2 = int.Parse(Console.ReadLine());

            // Pregunta la opcion a elegir.
            Console.WriteLine("Escoja la operacion a realizar :");
            Console.WriteLine("\ts - Suma");
            Console.WriteLine("\tr - Resta");
            Console.WriteLine("\tm - Multiplicacion");
            Console.WriteLine("\td - Division");
            Console.WriteLine("\tp - Potencia");
            Console.WriteLine("\tc - Cuadrado");
            Console.Write("Esta es la opcion que elejiste? ");

            // se usa un switch para poder realizar las operaciones.
            switch (Console.ReadLine())
             {
                 case "s":
                     Console.WriteLine($"Tu respuesta es : {num1} + {num2} = " + (num1 + num2));
                     break;
                 case "r":
                     Console.WriteLine($"Tu respuesta es: {num1} - {num2} = " + (num1 - num2));
                     break;
                 case "m":
                     Console.WriteLine($"Tu respuesta es: {num1} * {num2} = " + (num1 * num2));
                     break;
                 case "d":
                     Console.WriteLine($"Tu respuesta es: {num1} / {num2} = " + (num1 / num2));
                     break;
                case "p":
                    double num, post, resultado;
                    Console.WriteLine("Ingrese su  número");
                    num = Convert.ToDouble(Console.ReadLine());
                     
                    Console.WriteLine("Digite la potencia a la que desea elevar");
                    post = Convert.ToDouble(Console.ReadLine());

                    resultado = Math.Pow(num, post);

                    Console.WriteLine("el resultado es :" + resultado);
                    Console.ReadKey();
                    break;
                case "c":
                    Console.WriteLine("Ingrese el numero que desee sacar la raiz cuadrada" );
                    Console.ReadLine();
                  var total = Math.Sqrt(num1);
                    Console.WriteLine("Su resultado de raiz cuadrada es :" +total);
                    break;
            }
            // Espererar a que termine y despues cerrar.
            
            {
              
            }
             Console.Write("Presione cualquier tecla para cerra la calculadora...");
             Console.ReadKey();
        }
    }
}

        
    

