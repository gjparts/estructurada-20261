namespace _36_String04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Haga un programa que lea un String,
             * el programa va a imprimir cuantas veces
             * encontro en dicho String las letras: c, a, s y z.
            -> Ignorando mayusc/minusc.*/
            string str;
            int c = 0, a = 0, s = 0, z = 0; //contadores
            
            Console.Write("Digite un string: ");
            str = Console.ReadLine();

            for(int i = 0; i < str.Length; i++)
            {
                if (str.ToLower()[i] == 'c') c++;
                if (str.ToLower()[i] == 'a') a++;
                if (str.ToLower()[i] == 's') s++;
                if (str.ToLower()[i] == 'z') z++;
            }
            Console.WriteLine($"Letra c: {c}");
            Console.WriteLine($"Letra a: {a}");
            Console.WriteLine($"Letra s: {s}");
            Console.WriteLine($"Letra z: {z}");
        }
    }
}
