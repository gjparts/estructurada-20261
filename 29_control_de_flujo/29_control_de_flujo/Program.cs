namespace _29_control_de_flujo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Haga un programa que tenga una estructura while infinita,
            esta estructura en cada iteracion va a preguntar
            al usuario un numero entero secreto.
            -> El numero secreto se va a cambiar en cada iteracion.
            -> El numero secreto sera un numero al azar entre 1 y 10.
            -> El programa debera felicitar al usuario si este logra
            adivinar el numero secreto.
            -> resolverlo utilizando break.*/

            Random r = new Random();
            int numero, azar;

            while (true)
            {
                azar = r.Next(1,11);

                try
                {
                    Console.Write("Adivine el numero entre 1 y 10: ");
                    numero = int.Parse(Console.ReadLine());
                    if (numero == azar) break; //adivino, termina
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Solo se admite enteros");
                }
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Felicidades, has adivinado!");
            Console.ResetColor();
        }
    }
}
