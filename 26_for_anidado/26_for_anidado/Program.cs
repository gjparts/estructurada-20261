namespace _26_for_anidado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Estructura de repeticion anidada (nested)
             Es aquella donde hay una estructura dentro de otra y normalmente
            se usan donde se necesita ejecutar una serie de iteraciones
            secundarias por cada iteracion primaria.
            
             Ejemplo: haga un programa que solicite al usuario el ancho y
            el alto de un rectangulo. El programa va a imprimir dicha
            figura pero hecha de asteriscos segun el alto y ancho dados.*/
            int alto, ancho;
            Console.Write("Ancho:");
            ancho = int.Parse(Console.ReadLine());
            Console.Write("Alto:");
            alto = int.Parse(Console.ReadLine());

            for( int i = 1; i <= alto; i++) //estructura primaria
            {
                for( int j = 1; j <= ancho; j++) //estructura secundaria
                {
                    Console.Write("*");
                }
                Console.WriteLine(); //pasar a la linea siguiente
            }
        }
    }
}
