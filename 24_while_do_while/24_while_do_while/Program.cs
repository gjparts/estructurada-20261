namespace _24_while_do_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Haga un programa que capture N cantidad de edades de personas.
            ->  el programa termina cuando se digite una edad menor que cero.
            ->  una vez que termine el programa debe imprimir una tabla que
                resuman cuantas edades se leyeron por grupo de edad
                de acuerdo al ejemplo siguiente:


            Grupo de Edad	Cantidad	Descripcion
            Menores de edad	XXXX		de 0 a menos de 18 años
            Mayores de edad	XXXX		de 18 a menos de 21 años
            Adultos		    XXXX		de 21 a menos de 60 años
            Tercera edad	XXXX		de 60 años en adelante

            -> La columna de la descripcion no la vaya a imprimir*/
            try
            {
                int edad = 0; //variable de control
                int menores = 0, mayores = 0, adultos = 0, tercera = 0; //contadores

                while (edad >= 0)
                {
                    Console.Write("Digite una edad: ");
                    edad = int.Parse(Console.ReadLine());
                    //clasificar la informacion
                    if (edad >= 0 && edad < 18)  menores++;
                    if (edad >= 18 && edad < 21) mayores++;
                    if (edad >= 21 && edad < 60) adultos++;
                    if (edad >= 60) tercera++;
                }
                Console.WriteLine("Grupo de Edad\tCantidad");
                Console.WriteLine($"Menores de edad\t{menores}");
                Console.WriteLine($"Mayores de edad\t{mayores}");
                Console.WriteLine($"Adultos\t\t{adultos}");
                Console.WriteLine($"Tercera edad\t{tercera}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Solo se acepta numeros enteros.");
            }
        }
    }
}
