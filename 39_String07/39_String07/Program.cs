using System.Text.RegularExpressions;

namespace _39_String07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Metodo IndexOf
             Devuelve un numero entero el cual indica la posicion de la
            primera coincidencia encontrada dentro de un String para otro String
            -> No ignora mayusculas/minusculas
            -> No altera el String (porque es de busqueda)
            -> Si no encuentra nada el entero retornado será -1
            -> Los caracteres se numeran de 0 a Length-1
            -> Opcionalmente tiene un segundo parametro para indicar desde
               que posicion iniciará la búsqueda.*/
            string str = "El carro es blanco con gris. El carro esta matriculado. El carro es Caro.";
            Console.WriteLine(str);
            Console.WriteLine("Posiciones de ciertas busquedas:");
            Console.WriteLine($"gris: {str.IndexOf("gris")}");
            Console.WriteLine($"matri: {str.IndexOf("matri")}");
            Console.WriteLine($"llanta: {str.IndexOf("llanta")}");
            Console.WriteLine($"GRIS: {str.IndexOf("GRIS")}");
            Console.WriteLine($"GRIS (ignorando casing): {str.ToUpper().IndexOf("GRIS")}");
            Console.WriteLine($"caro (ignorando casing): {str.ToUpper().IndexOf("CARO")}");

            //IndexOf devuelve un numero int, por lo tanto
            //este se puede guardar en una variable:
            int posicion = str.IndexOf("blan");
            Console.WriteLine($"blanco: {posicion}");

            Console.WriteLine($"carro: {str.IndexOf("carro")}");
            //note que devuelve la primer coincidencia

            //IndexOf se puede usar con dos parametros
            //1) el primer parametro es lo que desea buscar
            //2) el segundo parametro sera desde donde va a comenzar a buscar
            //por ejemplo carro esta tres veces, veamos que posiciones tienen:
            Console.WriteLine($"primer coincidencia de carro: {str.IndexOf("carro", 0)}");
            //carro fue encontrado en la posicion 3 por primera vez, la siguiente posicion
            //desde donde seguiremos buscando sera la 4:
            Console.WriteLine($"siguiente coincidencia de carro: {str.IndexOf("carro", 4)}");
            Console.WriteLine($"siguiente coincidencia de carro: {str.IndexOf("carro", 33)}");
            Console.WriteLine($"siguiente coincidencia de carro: {str.IndexOf("carro", 60)}");

            string frutas = "manzana uva pera MANZANA PERA UVA kiwi Toronja KIWI Manzana Pera";
            /*Haga un programa que le pregunte una fruta al usuario.
             El programa va a imprimir cuantas veces fue encontrada la fruta
            dentro del string llamado frutas. Debera ignorar mayusc/minusc. ejemplo:
            Fruta a buscar: pera
            Se encontro: 3 veces
            */
            Console.WriteLine("----------------------");
            string buscar;
            int veces = 0; //contador
            int pos = 0; //ultima posicion de busqueda
            Console.Write("Fruta a buscar: ");
            buscar = Console.ReadLine();

            while( pos >= 0)
            {
                pos = frutas.ToUpper().IndexOf(buscar.ToUpper(),pos);
                if( pos >= 0)
                {
                    veces++;
                    pos++; //pasar a buscar a la posicion siguiente
                }
            }
            Console.WriteLine($"Se encontro: {veces} veces");

            //forma facil desde C#
            //usando RegEx
            int coindidencias = Regex.Matches(frutas, buscar, RegexOptions.IgnoreCase).Count();
            Console.WriteLine($"Veces que se encontro usando RegEx: {coindidencias}");
        }
    }
}
