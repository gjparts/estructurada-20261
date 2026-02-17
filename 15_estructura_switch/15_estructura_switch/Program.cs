namespace _15_estructura_switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Estructura de seleccion switch
             Permite evaluar una variable y dependiendo de su valor
            determinara el bloque de codigo a ejecutar, cada bloque
            esta identificado por algo que se conoce como caso (case).
            
            Haga un programa que solicite digitar el mes y el año como
            numeros enteros. El programa imprimira cuantos dias tiene
            el mes/año digitado.
            Si digita un mes no valido mostrar el mensaje.
             */

            try
            {
                int m, a;
                Console.Write("Digite el numero del mes: ");
                m = int.Parse(Console.ReadLine());
                Console.Write("Digite el año: ");
                a = int.Parse(Console.ReadLine());

                switch (m)
                {
                    case 1: case 3: case 5: case 7: case 8: case 10: case 12:
                        Console.WriteLine("31 dias");
                        Console.WriteLine("Estos son meses largos");
                    break;
                    case 4: case 6: case 9: case 11:
                        Console.WriteLine("30 dias");
                    break;
                    case 2:
                        if (a % 4 == 0)
                            Console.WriteLine("29 dias");
                        else
                            Console.WriteLine("28 dias");
                    break;
                    default:
                        //default sucede cuando no se cumple ninguno de los
                        //casos planteados
                        //en C# el caso default debe llevar break.
                        Console.WriteLine("Mes no valido");
                    break;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Solo se admite numeros enteros");
            }

        }
    }
}
