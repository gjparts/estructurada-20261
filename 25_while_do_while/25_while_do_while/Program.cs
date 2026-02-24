namespace _25_while_do_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Haga un menú en pantalla que muestre las opciones siguientes:
            ------ MENU ------
            1) Saludame
            2) Dime la fecha y hora
            3) Cuentame un chiste
            4) Reproduce un sonido
            5) Quiero que me ayudes a sumar dos numeros
            6) Salir
            -> Programe algo relacionado para cada acción, el programa no debe
                terminar hasta que elija la opcion 6.
            -> Debe limpiar la pantalla antes de mostrar el menu y antes
               de ejecutar cada acción.
            -> Debe hacer una pausa despues de mostrar cada acción*/
            int opcion;
            //para menu ser recomienda do-while porque hay que dibujar
            //al menos una vez el menu
            do
            {
                Console.Clear(); //limpiar la pantalla
                Console.WriteLine("------ MENU ------");
                Console.WriteLine("1) Saludame");
                Console.WriteLine("2) Dime la fecha y hora");
                Console.WriteLine("3) Cuentame un chiste");
                Console.WriteLine("4) Reproduce un sonido");
                Console.WriteLine("5) Quiero que me ayudes a sumar dos numeros");
                Console.WriteLine("6) Salir");
                Console.Write("Digite el numero de opcion deseada: ");
                //se coloca la captura de la opcion en try-catch
                try
                {
                    opcion = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Solo se admite numeros enteros");
                    opcion = 0; //en caso de falla la opcion pasa a cero
                                //para poder seguir dentro del do-while
                }

                //acciones
                if( opcion == 1 ) Console.WriteLine("Hola futuro ingeniero.");
                if( opcion == 2 ) Console.WriteLine($"Fecha y hora: {DateTime.Now}");
                if( opcion == 3 ) Console.WriteLine("Soy un programa no se chistes.");
                if( opcion == 4)
                {
                    Console.Beep(1000,2000); //2 segundos a 1000 hertz
                    Console.Beep(500, 1000); //1 segundo a 500 hertz
                }
                if( opcion == 5)
                {
                    double a, b;
                    Console.Write("Digita el primer numero: ");
                    a = double.Parse(Console.ReadLine());
                    Console.Write("Digita el segundo numero: ");
                    b = double.Parse(Console.ReadLine());
                    Console.WriteLine($"La suma de ambos numeros es: {a+b}");
                }
                if( opcion == 6 ) Console.WriteLine("Hasta pronto.");

                //hacer una pausa despues de cada opcion:
                Console.WriteLine("Presione cualquier tecla para continuar");
                Console.ReadKey(false);
            } while (opcion != 6);
        }
    }
}
