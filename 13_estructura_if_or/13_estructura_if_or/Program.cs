namespace _13_estructura_if_or
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Operador Logico OR
             Devuelve true se se cumple al menos una de las expresiones
            de comparacion cuando hay dos o mas de estas expresiones.
            En C# y C++ se usan dos barras || para referirse a OR
            El caracter barra se puede obtener con la combinacion Alt+124 en Windows
            
            ejemplo:
            Haga un programa que pregunte el mes y el año como numeros enteros.
            el programa va a imprimir la cantidad de dias que tiene el mes/año
            digitados.
            Valide que el mes sea un numero entre 1 y 12 de lo contrario imprimir
            que el mes no es valido.*/
            try
            {
                int m, a;
                Console.Write("Digite el mes: ");
                m = int.Parse(Console.ReadLine());
                Console.Write("Digite el año: ");
                a = int.Parse(Console.ReadLine());

                if (m >= 1 && m <= 12)
                {
                    if (m == 1 || m == 3 || m == 5 || m == 7 || m == 8 || m == 10 || m == 12)
                        Console.WriteLine("31 dias");

                    if (m == 4 || m == 6 || m == 9 || m == 11)
                        Console.WriteLine("30 dias");

                    if (m == 2)
                    {
                        if (a % 4 == 0)
                            Console.WriteLine("29 dias");
                        else
                            Console.WriteLine("28 dias");
                    }
                }
                else
                    Console.WriteLine("Mes no es valido");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Debe digitar numeros");
            }
        }
    }
}
