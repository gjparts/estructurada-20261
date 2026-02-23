namespace _23_while_do_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Haga un programa que lea N cantidad de numeros positivos.
            La lectura de los numeros va a terminar cuando se digite un numero negativo.
            Una vez termine de leerse los numeros, imprima la suma de todos los numeros
            positivos leidos. Resuelvalo usando while o do-while al gusto.*/
            //usando while
            double numero = 0; //variable de control
            double suma = 0.00; //variable acumulador

            while(numero >= 0)
            {
                Console.Write("Digite un numero positivo: ");
                numero = double.Parse(Console.ReadLine());
                //solo sume numeros positivos
                if(numero >= 0 ) suma += numero; //suma = suma + numero;
            }
            Console.WriteLine($"Suma: {suma}");

            Console.WriteLine("-----------------------");
            //usando do-while
            double n;
            double s = 0.00;
            do
            {
                Console.Write("Digite un numero positivo: ");
                n = double.Parse(Console.ReadLine());
                if (n >= 0) s += n;
            } while (n >= 0);
            Console.WriteLine($"Suma: {s}");
        }
    }
}
