namespace _31_arreglos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Haga un programa donde este declarado un arreglo unidimensional
            de numeros enteros de tamaño 10, debera llenar cada uno de
            los elementos de ese arreglo con un numero al azar entre 8 y 76 no
            importa que se repitan.
            Debera tambien imprimir dicho arreglo una vez lo halla llenado.*/
            int[] arreglo = new int[10];
            Random r = new Random();

            for(int i = 0; i < arreglo.Length; i++)
            {
                arreglo[i] = r.Next(8,77); //asignar num. al azar generado
                Console.WriteLine(arreglo[i]); //imprimir lo asignado al arreglo
            }
            /*Ahora necesito que creen un nuevo arreglo que copie
             todos los elementos del arreglo anterior; pero cada valor
            copiado lo van a elevar al cuadrado y lo van a almacenar
            en el arreglo copia.
            Imprima el contenido del arreglo copia.*/
            //forma 1:
            int[] copia = new int[10];
            //copiar los valores de arreglo hacia copia pero al cuadrado
            Console.WriteLine("---------------------------");
            for (int i = 0; i < arreglo.Length; i++)
            {
                copia[i] = arreglo[i]*arreglo[i];
                Console.WriteLine(copia[i]);
            }

            //forma 2: aplicando conversion explicita
            int[] clon = new int[10];
            Console.WriteLine("---------------------------");
            for (int i = 0; i < arreglo.Length; i++)
            {
                copia[i] = (int)Math.Pow(arreglo[i], 2);
                //(int) indica que considere como int al
                //resultado de Math.Pow el cual viene como double
                Console.WriteLine(copia[i]);
            }
        }
    }
}
