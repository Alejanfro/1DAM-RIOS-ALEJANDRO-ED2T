using System;
/*
* Autor: Alejandro Rios Diaz
* Curso: 1DAW-M
* Asignacion: Pintando consola
* Fecha de Asignacio: 4/3/2020
*/


namespace pintandoConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            int r;
            int r1; // Variable Random del lugar de la consola pintaremos
            int r2; // Variable Random para elegir aleatoriamente los caracteres
            int x;
            int y;
            int colorFrente;
            int colorFondo;
            char[] array = { '@', '$', 'o', '#', '/' };

            //Definimos la variable random
            Random rnd = new Random();

            //Mediante el Random elegimos en que lugar de la consola pintaremos aleatoriamente
            Random rn = new Random();
            r = rnd.Next(0, 24);
            r1 = rn.Next(0, 80);

            //Otro Random para elegimos aleatoriamente los caracteres
            Random ran = new Random();
            r2 = ran.Next(0, 4);

            //Cargamos los valores random en los respectivos ejes
            x = r1;
            y = r;

            //Con este Random le damos color al frente
            Random rand = new Random();
            colorFrente = rand.Next(16);

            //Le damos color al fondo
            Random rando = new Random();
            colorFondo = rando.Next(16);

            for (int i = 0; i < 3000; i++) // Este for asigna aleatoriamente un simbolo con un fondo de letra y fondo en un pixel 
                                           // se hara 3000 iteraciones
            {
                colorFrente = rand.Next(16); // Asigamos el valor los colores aleatoriamente en un rango de 16 colores
                colorFondo = rando.Next(16); 
                r = rnd.Next(0, 24);
                r1 = rn.Next(0, 80);
                r2 = ran.Next(0, 4);
                x = r1;
                y = r;

                Console.SetCursorPosition(x, y); // Esta funcion combinada con el Random permite cambiar el cursor aleatoriamente
                Console.ForegroundColor = (ConsoleColor)(colorFrente);  // Cambiamos el color de las letras en el que se encuentre el cursor
                Console.BackgroundColor = (ConsoleColor)(colorFondo);  // Cambiamos el color del fondo donde esta el cursor
                Console.Write(array[r2]); // Imprimimos un simbolo del array en el cursor aleatoriamente con los fondos
            }
            Console.SetCursorPosition(0,25); // Posicinamos el cursor
            Console.ReadKey();
        }
    }
}