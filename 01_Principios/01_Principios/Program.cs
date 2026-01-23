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

        }
    }
}
