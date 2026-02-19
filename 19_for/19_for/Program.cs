namespace _19_for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Hacer un programa que pida al usuario 10 numeros,
            al finalizar el programa imprimira la suma de
            esos 10 numeros, asi como cual es el mayor de los 10 numeros.
            -> el programa debe funcionar tambien con negativos*/

            //forma 1: determinar el mayor a partir de la inicializacion
            //de la variable usando el numero mas pequeño soportado
            //por el tipo de dato.

            try
            {
                double numero;
                double suma = 0; //variable acumulador (siempre se inicializan)
                double mayor = double.MinValue; //variable bandera (flag)
                //inicializamos mayor con el numero mas pequeño soportado por double (MinValue)

                for( int i = 1; i <= 10; i++)
                {
                    Console.Write("Digite un numero: ");
                    numero = double.Parse(Console.ReadLine());
                    //sumar el ultimo numero leido
                    suma += numero; //suma = suma + numero;

                    //si el numero leido es mayor al numero mayor
                    //entonces dicho numero es el nuevo mayor
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
