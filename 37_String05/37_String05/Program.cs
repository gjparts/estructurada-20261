namespace _37_String05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arreglo de String
            //forma 1: arreglo inicializado sin datos de inicio
            string[] arreglo1 = new string[4];
            //todos los elementos de arreglo1 son string vacios

            //forma 2: arreglo prellenado
            string[] colores = { "Rojo", "Verde", "Azul", "Negro", "Blanco" };

            //estos arreglos los puede imprimir con for, foreach o String.Join
            //como lo vimos en el tema de arreglos hace un par de semanas.
            Console.WriteLine( String.Join("\n", arreglo1 ) );
            Console.WriteLine("------------------");
            Console.WriteLine(String.Join("\n", colores));

            /*Haga un programa que pregunte un color, luego el programa
             va a buscar dicho color dentro del arreglo llamado colores.
            -> Si el color es encontrado entonces muestre la posicion
            del arreglo donde esta la primer coincidencia.
            -> Si el color no es encontrado entonces muestre un mensaje
            indicandolo.
            -> Debe ignorar mayusculas y minusculas durante la busqueda.
            */
            string buscar;
            bool encontrado = false; //variable bandera
            Console.Write("Digite el color a buscar: ");
            buscar = Console.ReadLine();

            for(int i = 0; i < colores.Length; i++)
            {
                if( buscar.ToUpper() == colores[i].ToUpper())
                {
                    Console.WriteLine($"Encontrado en la posicion {i}");
                    encontrado = true;
                    break; //no sigo buscando.
                }
            }
            if( encontrado == false ) Console.WriteLine("No encontrado");
            //en mi caso use una variable bandera

            //C# ofrece una forma mas facil de encontrar
            //un elemento en una coleccion
            int posicion = Array.FindIndex(colores,
                n => n.Equals(buscar, StringComparison.OrdinalIgnoreCase));
            if( posicion == -1 )
                Console.WriteLine("No encontrado");
            else
                Console.WriteLine($"Encontrado en la posicion: {posicion}");

            /*Imprimir cada color del arreglo llamado colores
             colocando un asterisco entre cada caracter de cada color.
            -> Imprima un color por renglon.
            -> Sin afectar el string original*/
        }
    }
}
