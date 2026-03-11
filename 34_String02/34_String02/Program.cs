namespace _34_String02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Capturar un string por medio de la consola/terminal
            Console.Write("Digite un string: ");
            string str = Console.ReadLine();

            Console.WriteLine($"String leido: {str}");
            Console.WriteLine($"Longitud: {str.Length}");
            Console.WriteLine($"En mayusculas: {str.ToUpper()}");
            Console.WriteLine($"En mayusculas: {str.ToLower()}");
            Console.WriteLine($"Sin relleno: {str.Trim()}");
            Console.WriteLine($"Longitud sin relleno: {str.Trim().Length}");

            /*Ejercicio: haga una copia del string recien leido en
             una nueva variable. A la copia le van a reemplazar las
            letras E por un 3, las letras A por un 4; pero va a ignorar
            mayusculas/minusculas para las A y la E.
            -> se le prohibe usar replace o expresiones regulares.
            Imprima el contenido de la copia.
            Ejemplo:
            Digite un string: Pera VERDE
            Resultado: P3r4 V3RD3
            */
        }
    }
}
