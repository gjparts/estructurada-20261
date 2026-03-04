namespace _33_String01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*tipo de dato String
            Es una coleccion de elementos char.
            -> Su tamaño depende de cuantos caracteres tiene almacenados
            -> Cada caracter mide 1 byte dependiendo del alfabeto
            -> En C# el tipo de dato String se basa en una clase de la
               que se crean objetos.
            -> En general String al español lo traducen como Cadena de Texto
            -> en C# puede usar String (son S mayuscula) o string (en minuscula)
               ambas palabras son aceptadas y hacen lo mimo.*/

            //declarar un objeto string:
            String str1;
            string cadena1;
            //string es un alias de String

            //String es auto-instanciable o sea que no necesita de la
            //palabra new para crear un nuevo objeto.
            //instanciar = dar memoria a un objeto (asignarlo a la memoria RAM)
            string mascota = "Firulais";
            string campus;
            campus = "UNAH Cortes";
            string color = "rojo", carro = "Toyota", pais = "Honduras";

            //en C# no se puede leer un string sin haberle asignado un valor
            /*string algo;
            Console.WriteLine($"valor de algo: {algo}");*/

            //solucion: asignele un string en blanco
            string algo = "";
            Console.WriteLine($"valor de algo: {algo}");
        }
    }
}
