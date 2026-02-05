namespace _05_Captura3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d;
            Console.Write("a: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("b: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("c: ");
            c = double.Parse(Console.ReadLine());
            Console.Write("d: ");
            d = double.Parse(Console.ReadLine());

            //forma 1: todo de un solo
            Console.WriteLine($"resultado: {Math.Sqrt((a+b)/Math.Pow(c,3))*d/8.0}");

            //forma 2: separar el problema en partes
            //Ustedes deciden como van a seccionar las partes del problema
            double raiz, numerador, denomidador, res;
            numerador = a + b;
            denomidador = Math.Pow(c, 3);
            raiz = Math.Sqrt(numerador/denomidador);
            res = raiz * d / 8.0;
            Console.WriteLine($"resultado: {res}");
        }
    }
}
