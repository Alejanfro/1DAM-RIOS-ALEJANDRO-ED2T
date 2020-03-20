using System;
/*
* Autor: Alejandro Rios Diaz
* Curso: 1DAW-M
* Asignacion: Matematicas con CSharp
* Fecha de Asignacio: 19/2/2020
*/


namespace MatematicasConCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Varialbles
            double numero1;
            double numero2;
            String operador;
            double suma;
            double resta;
            double multiplicacion;
            double division;
            Boolean comprobacion;

            do // Este do While asegura que se ingrese un numero
            {
                Console.WriteLine("Igrese numero1");

                if (double.TryParse(Console.ReadLine(), out numero1)) // Try control de erroes, sirve para que el programa no deje
                                                                     // de compilar si se coomete un error
                {
                    comprobacion = true; // Utilizamos esta variable para que la condicion del while se cumpla 
                }
                else
                {
                    Console.WriteLine("No has escrito un numero");
                    comprobacion = false;
                }

            } while (comprobacion != true);


            Console.WriteLine("Ingrese operador");
            operador = Convert.ToString(Console.ReadLine());

            do
            {

                Console.WriteLine("Igrese numero2");

                if (double.TryParse(Console.ReadLine(), out numero2))
                {
                    comprobacion = true;
                    Console.WriteLine();
                }
                else
                {
                    comprobacion = false;
                    Console.WriteLine("No has escrito un numero");
                }

            } while (comprobacion != true);

            suma = numero1 + numero2;
            resta = numero1 - numero2;
            multiplicacion = numero1 * numero2;
            division = numero1 / numero2;

            switch (operador)  // Con el switch elegimos el operando y mostramos por consola el resultado
            {
                case "+":
                    Console.WriteLine("La suma es: " + suma);
                    break;
                case "-":
                    Console.WriteLine("La resta es: " + resta);
                    break;
                case "*":
                    Console.WriteLine("La multiplicacion es: " + multiplicacion);
                    break;
                case "x":
                    Console.WriteLine("La multiplicacion es: " + multiplicacion);
                    break;
                case "/":
                    Console.WriteLine("La division es: " + division);
                    break;

                default:
                    Console.WriteLine("Operando no contemplado");
                    break;

            }
            Console.WriteLine("");
            Console.WriteLine("Presione cualquier tecla para salir");
            Console.ReadKey();
        }
    }
}
