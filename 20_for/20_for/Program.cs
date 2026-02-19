namespace _20_for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Hacer un programa que pida al usuario 10 numeros,
            al finalizar el programa imprimira la suma de
            esos 10 numeros, asi como cual es el mayor de los 10 numeros.
            -> el programa debe funcionar tambien con negativos*/

            //forma 2: el numero leido en la primera iteracion va a inicializar
            //a la variable mayor

            try
            {
                double numero;
                double suma = 0; //variable acumulador (siempre se inicializan)
                double mayor = 12345; //variable bandera (flag)
                //inicializamos mayor con cualquier numero porque en la primera
                //iteracion de for vamos a reescribirlo.

                for (int i = 1; i <= 10; i++)
                {
                    Console.Write("Digite un numero: ");
                    numero = double.Parse(Console.ReadLine());
                    //sumar el ultimo numero leido
                    suma += numero; //suma = suma + numero;

                    //en la primera iteracion el numero leido siempre sera el mayor
                    //en las siguientes iteraciones comparamos el numero leido
                    //con el numero mayor
                    if (i == 1)
                        mayor = numero;
                    else
                        if (numero > mayor) mayor = numero;
                }
                Console.WriteLine($"La suma es: {suma}");
                Console.WriteLine($"El numero mayor es: {mayor}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Solo se acepta numeros.");
            }
        }
    }
}
