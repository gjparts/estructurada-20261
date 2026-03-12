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
        }
    }
}
