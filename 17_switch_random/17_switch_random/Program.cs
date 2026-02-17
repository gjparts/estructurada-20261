namespace _17_switch_random
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Haga un programa que genere un numero
            al azar entre 4 y 9.
            Dependiendo del numero generado debera
            imprimir el nombre de una fruta estos pueden ser:
            4 = Naranja
            5 = Sandia
            6 = Manzana
            7 = Pera
            8 = Kiwi
            9 = Platano
            Evalue el numero al azar utilizando una
            estructura de seleccion switch.*/
            Random r = new Random();
            int n = r.Next(4,10);
            switch (n)
            {
                case 4: Console.WriteLine("Naranja"); break;
                case 5: Console.WriteLine("Sandia"); break;
                case 6: Console.WriteLine("Manzana"); break;
                case 7: Console.WriteLine("Pera"); break;
                case 8: Console.WriteLine("Kiwi"); break;
                case 9: Console.WriteLine("Platano"); break;
                default: Console.WriteLine("Numero no soportado"); break;
            }
        }
    }
}
