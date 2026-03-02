namespace _28_control_de_flujo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Ejemplo de uso de break
             Haga una estructura de repeticion for que lea 50
            numeros long positivos.
            -> Si durante la digitacion se ingresa un numero negativo
               debera terminar con la lecutra de  numeros.
            -> al finalizar muestre la suma de los numeros positivos leidos.*/
            try
            {
                long numero;
                long suma = 0;
                for (int i = 1; i <= 50; i++)
                {
                    Console.Write("Digite un numero entero positivo: ");
                    numero = long.Parse(Console.ReadLine());
                    if (numero < 0) break; //se rompe la estructura for
                    suma += numero;
                }
                Console.WriteLine($"Suma de positivos: {suma}");
            }
            catch (Exception)
            {
                Console.WriteLine("Solo se acepta numeros enteros.");
            }
        }
    }
}
