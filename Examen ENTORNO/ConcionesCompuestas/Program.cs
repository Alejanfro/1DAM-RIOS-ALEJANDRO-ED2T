using System;
/*
* Autor: Alejandro Rios Diaz
* Curso: 1DAW-M
* Asignacion: Condiciones Compuestas
* Fecha de Asignacio: 5/2/2020
*/
namespace ConcionesCompuestas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("INICIO PROGRAMA");
            //Este programa mostrara por pantalla el trimestre del curso al que corresponde el mes introducido
            //Esto lo vamos a conseguir mendiante el uso de if  else, el usuario introduce las 3 primeras letras 
            //del mes que desea comprobar, el programa al compilar el codigo ira discriminando los meses hasta 
            //llegar al mes adecuado y despues mostrara por pantalla el trimestre al corresponde. En caso de no
            //coincidida mostrara por pantalla un mensaje.
            string mes;
            Console.WriteLine("Ingrese las tres pirmeras letras del mes que desea comprobar");
            mes = Console.ReadLine().ToLower();
            if (mes == "sep" || mes == "oct" || mes == "nov")
            {
                Console.WriteLine("Pertenece al primer trimeste de curso");
            }else
            if (mes == "ene" || mes == "feb" || mes == "mar")
            {
                Console.WriteLine("Pertenece al segundo trimeste");
            }else

            if (mes == "abr" || mes == "may" || mes == "jun")
            {
                Console.WriteLine("Pertenece al tercer trimeste");
            }
            else { Console.WriteLine("El mes escrito, no pertenece a ningún trimestre"); }
        }
    }
}
