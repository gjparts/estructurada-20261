namespace _35_String03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Comparar dos String en C#
            string a, b;
            Console.Write("Digite a: ");
            a = Console.ReadLine();
            Console.Write("Digite b: ");
            b = Console.ReadLine();

            //en C# se compara string con el operador de igualdad ==
            if( a == b )
                Console.WriteLine("a y b son iguales");
            else
                Console.WriteLine("a y b NO son iguales");

            //importante: comparar dos string no ignora mayusc/minusc.
            //como se puede comparar dos string ignorando mayusc/minusc.?
            //para lograrlo convierta ambos string al mismo character casing:
            if( a.ToUpper() == b.ToUpper() )
                Console.WriteLine("a y b son iguales ignorando mayusc/minusc.");
            else
                Console.WriteLine("a y b NO son iguales ignorando mayusc/minusc.");

            //character casing o simplemente casing: capitalizacion.
        }
    }
}
