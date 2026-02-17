namespace _16_azar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //generar un numero al azar entre 1 y 6

            //instanciar un nuevo objeto de clase Random
            Random r = new Random();
            int azar = r.Next(1,7);
            Console.WriteLine(azar);
            /*porque colocamos 7 en lugar de 6?
             Next dentro de Random es un metodo excluyente
             donde al maximo valor esperado debemos sumarle
             uno para que sea considerado.*/

            //genere un numero al azar entre 13 y 47
            azar = r.Next(13,48);
            Console.WriteLine(azar);
        }
    }
}
