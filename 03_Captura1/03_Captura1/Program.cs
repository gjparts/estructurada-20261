namespace _03_Captura1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Captura de valores usando la consola del sistema:
            //para capturar valores se usa ReadLine()
            //el cual captura un valor desde la consola
            //y lo devuelve como cadena de texto (string)

            //bloque de caza de errores en tiempo de ejecucion (runtime)
            try
            {
                //codigo propenso a fallar
                int a, b;
                Console.Write("Digite un numero entero: ");
                a = int.Parse( Console.ReadLine() );
                Console.Write("Digite otro numero entero: ");
                b = int.Parse(Console.ReadLine());

                Console.WriteLine($"La suma de ambos numeros es {a+b}");
            }catch(Exception ex)
            {
                //codigo a ejecutar en caso de falla
                Console.WriteLine("Debe digitar solo numeros enteros");
                //Console.WriteLine(ex.Message);
            }

            try
            {
                Console.WriteLine("************************");
                double x, y;
                Console.Write("Digite un numero con decimales: ");
                x = double.Parse( Console.ReadLine() );
                Console.Write("Digite otro numero con decimales: ");
                y = double.Parse(Console.ReadLine());
                Console.WriteLine($"La resta de ambos numeros es {x-y}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Solo se acepta numeros");
            }
        }
    }
}
