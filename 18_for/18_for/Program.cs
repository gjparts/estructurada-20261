namespace _18_for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1) imprimir los numeros del 1 al 10 de uno en uno
            //si va a iterar solo una instruccion no necesita llaves:
            //10 iteraciones
            for(int i = 1; i <= 10; i++)
                Console.WriteLine(i);

            //si va a iterar varias instrucciones entonces necesita llaves:
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("En la siguiente linea va el numero i:");
                Console.WriteLine(i);
            }
            //otra forma: (menos entendible)
            //10 iteraciones
            for (int i = 0; i < 10; i++)
                Console.WriteLine(i+1);

            //2) imprimir los numeros del 0 al 50 de dos en dos
            //26 iteraciones
            Console.WriteLine("------------------------------");
            for(int i = 0; i <= 50; i+=2) //usando operador de incremento
                Console.WriteLine(i);

            //26 iteraciones
            //26 iteraciones
            Console.WriteLine("------------------------------");
            for (int i = 0; i <= 50; i = i + 2) //suma tradicional
                Console.WriteLine(i);

            //otra forma de hacerlo (menos eficiente)
            //51 iteraciones
            for (int i = 0; i <= 50; i++)
            {
                if(i%2 == 0) Console.WriteLine(i); //solo imprime los pares
            }


        }
    }
}
