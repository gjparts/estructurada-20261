namespace _08_estructura_if
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Para una tienda, se da un descuento de acuerdo al monto vendido.
             Si el monto es mayor que 10000; entonces daremos un descuento
            del 20% sobre el valor de la venta de lo contrario no hay descuento.
            Capture el monto vendido e imprima el valor del descuento
            y el valor final a pagar.*/
            float venta;
            Console.Write("Digite el valor de la venta: ");
            venta = float.Parse(Console.ReadLine());

            if( venta > 10000)
            {
                //multiples instrucciones van en llaves
                Console.WriteLine($"El descuento es: {venta*0.20f}");
                Console.WriteLine($"El total a pagar es: {venta-venta*0.20f}");
            }
            else
            {
                //multiples instrucciones van en llaves incluso para else
                Console.WriteLine($"No hay descuento");
                Console.WriteLine($"El total a pagar es: {venta}");
            }
                
        }
    }
}
