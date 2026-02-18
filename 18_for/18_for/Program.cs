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

            //3) imprimir los numeros del 0 al 50 de cinco en cinco
            //11 iteraciones
            Console.WriteLine("------------------------------");
            for(int i = 0;i <= 50;i+=5)
                Console.WriteLine(i);

            //51 iteraciones
            for(int i = 0; i <= 50; i++)
            {
                if( i%5 == 0 )
                    Console.WriteLine(i);
            }

            //4) recorrer los numeros del 1 al 50 pero solo imprima lo pares
            Console.WriteLine("------------------------------");
            for(int i = 1; i <= 50; i++)
            {
                if(i%2 == 0)
                    Console.WriteLine(i);
            }

            //5) imprima los numeros del 1 al 100; coloque un asterisco a la derecha
            //de aquellos numeros que son multiplo de 10
            Console.WriteLine("------------------------------");
            //forma 1:
            for(int i = 1; i <= 100; i++)
            {
                if(i%10 == 0)
                    Console.WriteLine(i+"*");
                else
                    Console.WriteLine(i);
            }

            Console.WriteLine("------------------------------");
            //forma 2:
            for (int i = 1; i <= 100; i++)
            {
                Console.Write(i);
                if( i%10 == 0 ) Console.Write("*");
                Console.WriteLine();
            }

            Console.WriteLine("------------------------------");
            //forma 3:
            for (int i = 1; i <= 100; i++)
            {
                //usando operador ternario
                Console.WriteLine(i+( i%10 == 0 ? "*" : "" ));
            }

            //6) Imprima los numeros del 10 al 1, de forma descendente de 1 en 1
            Console.WriteLine("------------------------------");
            for(int i = 10; i >= 1; i--)
                Console.WriteLine(i);

            //7) Imprima los numeros del 10 al 0 de forma descendente de 2 en 2
            Console.WriteLine("------------------------------");
            for(int i = 10; i >= 0; i -= 2)
                Console.WriteLine(i);

            //8) Imprima los numeros del 100 al 0 de forma descendente de 10 en 10
            Console.WriteLine("------------------------------");
            for(int i = 100; i >= 0; i -= 10)
                Console.WriteLine(i);

            /*La estructura for no funciona exclusivamente con enteros
             tambien se puede usar con valores decimales, ejemplo:
            Imprima los numeros de 0 a 5 de 0.25 en 0.25*/
            Console.WriteLine("------------------------------");
            for(double i = 0; i <= 5; i+=0.25)
                Console.WriteLine(i);
        }
    }
}
