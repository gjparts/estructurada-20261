namespace _07_estructura_if
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
            float venta, descuento = 0, pagar;

            Console.Write("Digite el valor de la venta: ");
            venta = float.Parse(Console.ReadLine());

            //usare if sin else
            //como descuento esta condicionado y no tenemos else
            //entonces estamos obligados a inicializarla en la declaracion
            if (venta > 10000)
                descuento = venta * 0.20f;
            
            pagar = venta - descuento;

            Console.WriteLine($"Descuento: {descuento}");
            Console.WriteLine($"Total a pagar: {pagar}");
        }
    }
}
