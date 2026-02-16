namespace _14_estructura_if_or_and
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*En un negocio se va a dar un descuento del 10% para lo vendido a personas
            con edades entre 18 y 24 ó con edades entre 40 y 60.
            Capture el monto de la venta y la edad, luego imprima el
            monto del descuento y el total a pagar.*/
            try
            {
                float venta, descuento = 0;
                int edad;
                Console.Write("Digite la edad del cliente: ");
                edad = int.Parse(Console.ReadLine());
                Console.Write("Digite el monto de la venta: ");
                venta = float.Parse(Console.ReadLine());

                if (edad >= 18 && edad <= 24 || edad >= 40 && edad <= 60)
                    descuento = venta * 0.10f;

                Console.WriteLine($"El descuento es: {descuento}");
                Console.WriteLine($"El total a pagar es: {venta-descuento}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Solo se acepta numeros.");
            }
        }
    }
}
