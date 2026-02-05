namespace _04_Captura2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.Write("a: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("b: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("c: ");
            c = double.Parse(Console.ReadLine());

            //hay muchas formas de resolverlo
            //forma 1:
            Console.WriteLine($"resultado es: {(a+b)/(a-c)}");
            //forma 2:
            double numerador = a+b, denominador = a-c;
            Console.WriteLine($"resultado es: {numerador/denominador}");
            //forma 3:
            double res = (a + b) / (a - c);
            Console.WriteLine($"resultado es: {res}");
            //forma 4:
            res = numerador / denominador;
            Console.WriteLine($"resultado es: {res}");
        }
    }
}
