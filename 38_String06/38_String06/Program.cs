using System.Text.RegularExpressions;

namespace _38_String06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Metodo Replace
             Devuelve una copia del string a la cual se le ha reemplazado todas
            las coincidencias encontradas de un string x por un string y.
            -> este metodo no ignora mayusc./minusc.*/
            string str = "Verde es la Manzana, la manzana en verde. Que verde es la manzana!";
            Console.WriteLine(str);
            //reemplazar verde por roja sin alterar el string original
            Console.WriteLine(str.Replace("verde","roja"));
            //veamos si altero el string original:
            Console.WriteLine(str);
            //note que el string original permanece intacto.
            //si desea alterar el string original:
            str = str.Replace("verde", "roja");
            Console.WriteLine(str);

            //es posible desecadenar varios replace en una sola instruccion:
            string str2 = "La naranja es una gran fruta, el jugo de naranja es mejor que el de noni.";
            //reemplazar naranja por sandia y noni por coyol afectando al string original
            str2 = str2.Replace("naranja", "sandia").Replace("noni", "coyol"); //reemplazo en cascada
            Console.WriteLine(str2);

            //reemplazar en un string ignorando mayusculas y minusculas
            //para ellos usaremos un metodo llamado Replace pero de la clase Regex
            string str3 = "Rojo ROJO ROjo RoJo VERDE verde Verde VeRDE AZUL azul AzuL AZul";
            //reemplazar verde por rosa ignorando mayusculas y minusculas y alterando el String original
            str3 = Regex.Replace(str3,"verde","rosa",RegexOptions.IgnoreCase);
            //Regular Expressions (expresiones regulares)
            Console.WriteLine(str3);

            /*Pregunte un string al usuario. Luego reemplace en dicho string los espacios en blanco
             por guiones bajos, las letras a por 4, las letras e por 3.
            -> Ignorando mayusculas y minusculas.*/
            Console.Write("Digite un string: ");
            string str4 = Console.ReadLine();
            str4 = Regex.Replace(str4, " ", "_", RegexOptions.IgnoreCase);
            str4 = Regex.Replace(str4, "a", "4", RegexOptions.IgnoreCase);
            str4 = Regex.Replace(str4, "e", "3", RegexOptions.IgnoreCase);
            Console.WriteLine(str4);
        }
    }
}
