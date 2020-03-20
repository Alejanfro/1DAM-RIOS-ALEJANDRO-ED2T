using System;
/*
* Autor: Alejandro Rios Diaz
* Curso: 1DAW-M
* Asignacion: Estructuras de control
* Fecha de Asignacio: 12/2/2020
*/

namespace EjercicioConEstructurasDeControl
{
    class Program

    {
        static void Main(string[] args)
        {
            int n = 0; // Hay que inicializarla para que funcione la condicion del while
            int p = 1; // Hay que inicializarla a 1 porque si lo hicieramos a 0 no seria viable
            String pares = ""; // Hay que inicializarla para poder operar


            while (n <= 0) // Para que se cumpla la condicion de que sea un numero positivo
            {
                Console.WriteLine("Introduce un numero");
                n = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 1; i < n; i++) // Con este for recoremos hasta n, empezamos iteracion por 1 para que no coja el 0 
                                        // en el factoria, ya que al multiplicar por 0 no saldria
            {
                if (i % 2 == 0) // Con esta condicion se consigue los numero pares, 
                                //el resto de la division entre 2 de la iteracion tiene que ser 0
                {
                 pares += Convert.ToString(i) + " "; // Guarda en la variable los numeros pares consegidos
                 p = p * i; // Asi se multiplica los pares por la iteracion, es decir, el factorial de pares
                }
            }
            Console.WriteLine("Los pares del numero " + n + " son: " + pares);
            Console.WriteLine("El factorial del numero " + n + " es: " + p);

            Console.ReadKey();

        }
    }
}
    

