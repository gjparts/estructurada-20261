namespace _42_String10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Metodo Split
             Devuelve un arreglo de elementos String el cual es resultado
            de dividir en partes otro String a traves de un delimitador (token).*/
            string str = "rojo,verde,azul,blanco,negro,gris,amarillo";
            string[] arreglo; //arreglo sin inicializar (arreglo de destino)

            //inicializar el arreglo de destino con el resultado de Split:
            arreglo = str.Split(","); //la coma va ser el delimitador

            //recorrer e imprimir el arreglo:
            for(int i = 0;  i < arreglo.Length; i++)
                Console.WriteLine(arreglo[i]);

            Console.WriteLine("-----------------------------------------");

            //el token puede ser cualquier String:
            str = "HondaSEPARADORCivicSEPARADOR2004SEPARADORNegroSEPARADORImportado";
            arreglo = str.Split("SEPARADOR");
            //recorrer e imprimir el arreglo:
            for (int i = 0; i < arreglo.Length; i++)
                Console.WriteLine(arreglo[i]);
            Console.WriteLine("--------------------------------------");

            //que pasaria si en el String vienen caracteres como \
            str = "sandia\\naranja\\fresa\\coco\\kiwi";
            arreglo = str.Split("\\");
            //recorrer e imprimir el arreglo:
            for (int i = 0; i < arreglo.Length; i++)
                Console.WriteLine(arreglo[i]);
            Console.WriteLine("--------------------------------------");

            //contar palabras usando Split:
            /*Haga un programa que pregunte un String, luego este va a
             imprimir cuantas palabras tiene.*/
            string frase;
            Console.Write("Digite un String: ");
            frase = Console.ReadLine();

            arreglo = frase.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            //se agrega el segundo parametro para ignorar aquellas elementos vacios

            Console.WriteLine($"Numero de palabras: {arreglo.Length}");
            //el numero de palabras en la frase es la cantidad de elementos
            //en el arreglo.
        }
    }
}
