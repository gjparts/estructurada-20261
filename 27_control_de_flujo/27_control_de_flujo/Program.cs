namespace _27_control_de_flujo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Instrucciones de control de flujo
             Permiten alterar el flujo de las iteraciones
            dentro de una estructura de repeticion.
            1) continue: termina la iteracion actual y pasa a la siguiente
            2) break: termina con la estructura de repeticion
            
            Ejemplo de uso de continue:
            Haga un programa que recorra los numeros
            del 1 al 100. Debera imprimir todos numeros
            excepto aquellos que sean multiplos de 9
            Resuelvalo usando la instruccion continue.*/
            for(int i = 1; i <= 100; i++)
            {
                if (i % 9 == 0) continue; //se salta la iteracion actual
                Console.WriteLine(i); //imprime
            }

            /*Ejemplo de uso de continue:
             Haga un programa que lea N cantidad de numeros enteros.
            Solo va a sumar aquellos que sean positivos. Si digita
            un numero negativo debera saltarse esa iteracion. El
            programa termina cuando digite CERO. Al finalizar muestre
            la suma de los enteros leidos.
            -> Debera usar continue al menos una vez.*/
            try
            {
                int numero = 777;
                int suma = 0;

                while (numero != 0)
                {
                    Console.Write("Digite un numero entero: ");
                    numero = int.Parse(Console.ReadLine());
                    if (numero < 0) continue; //si numero es negativo saltar iteracion
                    suma += numero;
                }
                Console.WriteLine($"suma de los positivos: {suma}");
            }
            catch (Exception)
            {
                Console.WriteLine("Solo se acepta numeros enteros");
            }            
        }
    }
}
