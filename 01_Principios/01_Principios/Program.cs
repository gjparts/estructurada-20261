namespace _01_Principios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //comentario de una linea (pseudocodigo)
            /*comentario
             de varias
            lineas*/
            //imprimir en la termina o consola
            //Metodo WriteLine: imprime un String en la terminal y pasa a la linea siguiente
            Console.WriteLine("Hola UNAH");
            Console.WriteLine("20012002049");
            Console.WriteLine("Gerardo Portillo");
            Console.WriteLine("Ingeniería en Sistemas Computacionales");
            Console.WriteLine("Fin");
            //Metodo Write: imprime un String en la terminal; pero no hace linea siguiente
            Console.Write("Verde");
            Console.Write("Rojo");
            Console.Write("Azul");
            Console.Write("UNAH Cortes");
            Console.Write("Adios");
            //uso de caractes de escape en prints
            //nueva linea:
            Console.WriteLine("\nLinea 1\nLinea 2\nLinea 3");
            //tabulador:
            Console.WriteLine("Nombre\tEdad\tGenero");
            Console.WriteLine("Gerardo\t43\tMasculino");
            Console.WriteLine("Irene\t42\tFemenino");
            Console.WriteLine("Josue\t13\tMasculino");
            //varios saltos de linea:
            Console.WriteLine("Punto A\n\n\n\n\n\nPunto B");
            //varias tabulaciones
            Console.WriteLine("Punto A\t\t\t\t\t\tPunto B");
            //como imprimo un slash inverso?
            Console.WriteLine("Esto es un slash inverso: \\");
            //como imprimo una comilla doble?
            Console.WriteLine("Esto es una comilla doble: \"");
            Console.WriteLine("Ramon Valdez alias \"Don Ramon\"");

            //imprime varios saltos de linea:
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //ignorar caracteres de escape dentro de un String
            //se coloca una arroba antes del String
            Console.WriteLine(@"\n\n\n\n");
            Console.WriteLine(@"Esto es un slash inverso: \");
            Console.WriteLine(@"Esto es una comilla doble: """);

            //arroba permite hacer Raw String, por lo tanto
            //podemos hacer un String de varias lineas
            Console.WriteLine(@"Linea 1
Linea 2
Linea 3
Linea 4");

            Console.WriteLine(@"
░░░░░░░█▐▓▓░████▄▄▄█▀▄▓▓▓▌█
░░░░░▄█▌▀▄▓▓▄▄▄▄▀▀▀▄▓▓▓▓▓▌█
░░░▄█▀▀▄▓█▓▓▓▓▓▓▓▓▓▓▓▓▀░▓▌█
░░█▀▄▓▓▓███▓▓▓███▓▓▓▄░░▄▓▐█▌
░█▌▓▓▓▀▀▓▓▓▓███▓▓▓▓▓▓▓▄▀▓▓▐█
▐█▐██▐░▄▓▓▓▓▓▀▄░▀▓▓▓▓▓▓▓▓▓▌█▌
█▌███▓▓▓▓▓▓▓▓▐░░▄▓▓███▓▓▓▄▀▐█
█▐█▓▀░░▀▓▓▓▓▓▓▓▓▓██████▓▓▓▓▐█
▌▓▄▌▀░▀░▐▀█▄▓▓██████████▓▓▓▌█▌
▌▓▓▓▄▄▀▀▓▓▓▀▓▓▓▓▓▓▓▓█▓█▓█▓▓▌█▌
█▐▓▓▓▓▓▓▄▄▄▓▓▓▓▓▓█▓█▓█▓█▓▓▓▐█");

            //Pausar la ejecucion del programa
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey(true); //true impide que se imprima la tecla presionada

            //Limpiar la terminal
            Console.Clear();

            //colocar el cursor de impresion en determinada posicion
            //dentro de la terminal
            Console.SetCursorPosition(70,3);
            Console.WriteLine("Texto en la columna 70, linea 3");

            Console.SetCursorPosition(10,20);
            Console.WriteLine("Texto en la columna 10, linea 20");

            Console.SetCursorPosition(8, 0);
            Console.WriteLine("Texto en la columna 8, linea 0");

            //Importante: el programa continuara imprimiendo a partir
            //de la ultima linea donde posiciono el cursor.

            //me posiciono en la linea 21, columna 0
            Console.SetCursorPosition(0, 21);

            //Pausar la ejecucion del programa
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey(true); //true impide que se imprima la tecla presionada

            //Limpiar la terminal
            Console.Clear();

            //Utilizar colores en la terminal
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Texto Amarillo");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Texto Rojo");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Texto Azul");

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Texto Amarillo sobre fondo verde");

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Texto blanco sobre fondo azul oscuro");

            //Resetear los colores a valores de fabrica
            Console.ResetColor();

            //varios colores por linea
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Fresa");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Limon");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Mango");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("Sandia");

            Console.ResetColor();
            Console.WriteLine();

            //Hacer una pausa con tiempo.
            Console.WriteLine("Pausa por dos segundos...");
            Thread.Sleep(2000); //1000 milisegundos son 1 segundo
            Console.WriteLine("Listos para continuar.");

            //Pausar la ejecucion del programa
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey(true); //true impide que se imprima la tecla presionada

            //Limpiar la terminal
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 1; i <= 50; i++)
            {
                //imprimir peces
                Console.SetCursorPosition(i,5);
                Console.WriteLine("><>");
                Console.SetCursorPosition(i+5, 20);
                Console.WriteLine("><>");
                Console.SetCursorPosition(i+8, 15);
                Console.WriteLine("><>");

                //hacer una pausa
                Thread.Sleep(50); //pausa de 50 milisegundos

                //limpiar la pantalla
                Console.Clear();
            }
            Console.ResetColor();
            //una vez el programa termine pasar el cursor a la linea 21
            Console.SetCursorPosition(0, 21);
        }
    }
}
