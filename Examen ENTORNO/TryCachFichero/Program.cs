using System;
/*
* Autor: Alejandro Rios Diaz
* Curso: 1DAW-M
* Asignacion: TryCach con fichero
* Fecha de Asignacio: 4/3/2020
*/


namespace TryCatchFichero
{
    class Program
    {
        static void Main(string[] args)
        {
            int cant = 3;
            int[] numeros = new int[cant];
            int counter = 0;
            string line;

            try
            {
                // Read the file and display it line by line.
                // Creamos un objeto de lectura para leer por consola mediante una ruta absoluta de un texto
                System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\Salvador\Desktop\Examen ENTORNO\TryCachFichero\Fichero.txt");
                while ((line = file.ReadLine()) != null) // Este while asegura que se le el texto mientras no sea nulo, es decir, hay texto
                {
                    System.Console.WriteLine(line); 
                    counter++; 
                }
                // Aqui cometemos un error a conciencia para que ante de ejecutar el File.Close, se ejecute el TryCach y 
                // compile correctamente, cerrandose el programa
                Console.WriteLine("Dime un numero pero equivocate escribe una letra");
                byte numero = Convert.ToByte(Console.ReadLine()); 

                file.Close();
                System.Console.WriteLine("There were {0} lines.", counter); // Cuenta las letra que contiene el texto
                // Suspend the screen.
            }
            catch (Exception e) // Es el catch con el cual hacemos que se cierre el texto. Este excepcion es general
            {
                Console.WriteLine("La consola se cierra");
                Console.WriteLine(e.Message);  // Muestra el mensaje del error para los programadores, no entendible para el usuario
            }
            System.Console.ReadLine();
        }
    }
}
