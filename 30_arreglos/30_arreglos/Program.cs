namespace _30_arreglos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Arreglo (Array)
             Es una estructura de datos secuencial, estatica
            y homogenea que permite agrupar datos en una coleccion.
            -> Secuencial: todos sus elementos se almacenan uno
                           despues del otro en la memoria.
                           Su opuesto es aleatorio.
            -> Estatica:   no puede cambiar su tamaño/
                           Su opuesto es dinamico.
            -> Homogenea:  Todos sus elementos son del mismo tipo
                           de dato. Su opuesto es heterogeneo.
            -> Todos los elementos de un rreglo se numeran de
               0 a N-1 a esto se le conoce como Zero Indexing.
            
             Maneras de declarar arreglos:
            1) declarar el arreglo sin datos
            2) declarar e inicializar el arreglo con datos predeterminados
            3) declarar e inicializar el arreglo prellenado con datos*/

            //1) declarar el arreglo sin datos
            int[] arreglo;
            /*este arreglo asi como esta definido no es utilizable porque no
             le hemos asignado memoria.
            Mas adelante vamos a ver en que nos puede servir un arreglo
            sin datos.*/

            //2) declarar e inicializar el arreglo con datos predeterminados
            int[] arreglo1 = new int[6];
            //lo anterior crear un arreglo unidimensional de 6 numeros enteros
            //en este caso C# inicializa cada elemento de dicho arreglo
            //con el valor CERO.

            //saber la longitud de un arreglo:
            Console.WriteLine($"Tamaño de arreglo1: {arreglo1.Length}");

            //Leer cada uno de los elementos de un arreglo
            Console.WriteLine(arreglo1[0]); //el primer elemento esta en la posicion 0
            Console.WriteLine(arreglo1[1]);
            Console.WriteLine(arreglo1[2]);
            Console.WriteLine(arreglo1[3]);
            Console.WriteLine(arreglo1[4]);
            Console.WriteLine(arreglo1[5]); //el ultimo elemento es la posicion N-1

            //asignar manualmente valores a diversas posiciones del arreglo:
            arreglo1[1] = 777;
            arreglo1[3] = -8;
            arreglo1[5] = 90;

            //recorrer e imprimir los valores de un arreglo usando for
            for(int i = 0; i < arreglo1.Length; i++)
            {
                Console.Write($"Posicion: {i}");
                Console.WriteLine($"\tValor: {arreglo1[i]}");
            }

            //que pasa si quiere imprimir un elemento de una posicion
            //que no existe en el arreglo?
            //Console.WriteLine(arreglo1[6]);

            //tambien puede imprimir un arreglo en C# usando
            //una estructura conocida como foreach
            //en la cual no es necesario indicar la longitud del arreglo
            //su unica desventaja es que no nos dice en que posicion
            //esta cada elemento, porque solo se enfoca en los valores
            foreach(int valor in arreglo1)
            {
                Console.WriteLine(valor);
            }
            //usamos int para valor porque arreglo1 es de tipo int

            //arreglo unidimensional de numeros double de 4 elementos
            double[] arreglo2 = new double[4];
            //asignar valores a todos sus elementos:
            arreglo2[0] = 4.5;
            arreglo2[1] = 2.25;
            arreglo2[2] = Math.PI;
            arreglo2[3] = -9;

            //imprimir el arreglo usando foreach
            foreach (double valor in arreglo2)
            {
                Console.WriteLine(valor);
            }

            //imprimir el arreglo usando for tradicional
            for(int i = 0; i < arreglo2.Length; i++)
                Console.WriteLine($"Posicion: {i}\tValor: {arreglo2[i]}");

            Console.WriteLine("Para arreglo2: ");
            Console.WriteLine($"El primer elemento es: {arreglo2[0]}");
            Console.WriteLine($"El ultimo elemento es: {arreglo2[3]}");
            Console.WriteLine($"El ultimo elemento es: {arreglo2[arreglo2.Length-1]}");
            //los arreglos en C# cuentan funciones para obtener el valor
            //maximo y minimo sin necesidad de calcularlo nosotros
            Console.WriteLine($"El valor mayor es: {arreglo2.Max()}");
            Console.WriteLine($"El valor menor es: {arreglo2.Min()}");

            //3) declarar e inicializar el arreglo prellenado con datos
            int[] arreglo3 = { 6, -8, 100, 24, 90, 2, -1, 0, 111 };
            //imprimir:
            Console.WriteLine("-------------------------------");
            for(int i = 0; i < arreglo3.Length; i++)
            {
                Console.Write($"Posicion: {i}");
                Console.WriteLine($"\tValor: {arreglo3[i]}");
            }

            //Aplicar ordenamiento ascendente a un arreglo
            //Importante, este metodo afecta al arreglo de forma permanente
            Array.Sort(arreglo3);
            //imprimamos el arreglo:
            Console.WriteLine("-------------------------------");
            for (int i = 0; i < arreglo3.Length; i++)
            {
                Console.Write($"Posicion: {i}");
                Console.WriteLine($"\tValor: {arreglo3[i]}");
            }

            //Aplicar ordenamiento descendente a un arreglo
            float[] arreglo4 = { 5.2f, 4.8f, 100, 3.456f, -1.2f, -0.456f, 200, 7 };
            //Importante: para poder hacer order descendente primero debe
            //aplicar order ascendente:
            Array.Sort(arreglo4);
            Array.Reverse(arreglo4);
            //imprimir:
            Console.WriteLine("-------------------------------");
            for (int i = 0; i < arreglo4.Length; i++)
            {
                Console.Write($"Posicion: {i}");
                Console.WriteLine($"\tValor: {arreglo4[i]}");
            }
        }
    }
}
