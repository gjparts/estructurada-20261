namespace _21_for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Haga un programa que pida 5 numeros al usuario,
            al finalizar muestre el promedio de esos numeros,
            cuantos fueron pares, cuantos fueron impares,
            cual es el menor y cual es el mayor.
            -> Debe funcionar con positivos y negativos.*/
            int numero;
            int suma = 0; //acumulador
            int pares = 0, impares = 0; //contadores
            int mayor = int.MinValue, menor = int.MaxValue; //banderas

            for( int i = 1; i <= 5; i++)
            {
                Console.Write("Digite un numero: ");
                numero = int.Parse(Console.ReadLine());

                suma += numero;

                //par o impar?
                if (numero % 2 == 0)
                    pares++; //pares = pares + 1
                else
                    impares++;

                if (numero >= mayor) mayor = numero;
                if (numero <= menor) menor = numero;
            }

            Console.WriteLine($"El promedio es: {suma/5.0}");
            Console.WriteLine($"El mayor es: {mayor}");
            Console.WriteLine($"El menor es: {menor}");
            Console.WriteLine($"Cantidad de pares: {pares}");
            Console.WriteLine($"Cantidad de impares: {impares}");
        }
    }
}
