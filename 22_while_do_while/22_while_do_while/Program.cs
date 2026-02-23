namespace _22_while_do_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Estructura de repeticion while y do-while
             Se utilizan cuando vamos a realizar iteraciones
            y no sabemos en que momento va a dejarse de iterar.
            -> se basan en el cumplimiento de una o varias condiciones
            -> para enterdelas mejor, imaginenlas como un if
               que si se cumple se repite de lo contrario termina
            -> while: pregunta primero, hace despues
            -> do-while: hace primero, pregunta despues*/

            //ejemplo: programa que imprime los numeros
            //del 1 al 10 usando while
            //pregunta primero, hace despues
            int i = 1; //variable de control
            while(i <= 10)
            {
                Console.WriteLine(i);
                i++; //debe cambiar la variable de control para
                     //que algun dia termine de iterar
            }

            //imprime los numeros del 1 al 10 usando do-while
            //hace primero, pregunta despues
            int x = 1;
            do
            {
                Console.WriteLine(x);
                x++;
            } while (x <= 10);

            Console.WriteLine("----------------------");
            /*Haga un programa que pregunte al usuario N cantidad
             de numeros positivos. El programa va a terminar cuando
            se digite un numero negativo.*/
            //usando while
            double numero = 0;
            while(numero >= 0)
            {
                Console.Write("Digite un numero positivo: ");
                numero = double.Parse(Console.ReadLine());
                //en este caso el usuario es quien esta
                //definiendo el valor de la variable de control
            }

            //usando do-while
            double cifra;
            do
            {
                Console.Write("Digite un numero positivo: ");
                cifra = double.Parse(Console.ReadLine());
            } while (cifra >= 0);
            /*Observe que en while era necesario inicializar
             la variable de control, en cambio en do-while no
            es necesario porque esta estructura hace al menos
            la primera iteracion que es donde se inicializa
            la variable de control.*/
        }
    }
}
