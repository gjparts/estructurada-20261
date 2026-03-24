namespace _40_String08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Metodo Substring
             Devuelve un String que esta dentro de otro String.
            en C# hay dos maneras de utilizarlo:
            1)  Substring(posicion_inicial)
                Devuelve un String desde la posicion inicial hasta llegar
                al final del String
            2)  Substring(posicion_inicial,cantidad_caracteres)
                Devuelve la cantidad de caracteres deseados a partir
                de la posicion inicial.*/
            string str = "El veloz murcielago hindu comia feliz kiwi y cardillo";
            Console.WriteLine(str);
            //Substring de 7 caracteres a partir de la posicion 0
            Console.WriteLine(str.Substring(0,7));
            //tambien este substring se puede guardar en una variable
            //tomar 10 caracteres a partir de la posicion 5:
            string fragmento = str.Substring(5, 10);
            Console.WriteLine(fragmento);

            //Substring de 15 caracyeres desde la posicion 8
            Console.WriteLine(str.Substring(8,15));

            //que pasa si Substring quiere tener acceso a una posicion inexistente
            //Substring de 1000 caracteres desde la posicion 8
            //Console.WriteLine(str.Substring(8,1000));
            //lo anterior daria excepcion OutOfRange

            //Substring usando solo posicion inicial:
            //obtener todos los caracteres de str a partir de la posicion 9:
            Console.WriteLine(str.Substring(9));
            //substring desde la posicion 14
            Console.WriteLine(str.Substring(14));
        }
    }
}
