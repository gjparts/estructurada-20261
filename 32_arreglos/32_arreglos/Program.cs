namespace _32_arreglos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //consideraciones en C#
            //Conversion explicita: consiste en decirle al compilador
            //que el siguiente valor lo considere como determinado tipo.
            //no funciona en la mayoria de los casos; pero con tipos
            //primitivos es muy efectivo.
            //ejemplos:
            double a = 5.6;
            int b = (int)a;
            Console.WriteLine($"valor de a: {a}");
            Console.WriteLine($"valor de b: {b}");

            double x = 2.5354345354345354222222222223;
            float y = (float)x;

            //siempre recuerde que toda conversion explicita
            //representa perdida de precision.

            //consideraciones respecto al foreach:
            double[] arreglo = { 2.3, 4.456, 777, -3.2, 78, 123.432 };
            //foreach no permite modificar el valor del elemento de un arreglo
            
            //ejemplo: para el arreglo anterior reemplace cada
            //uno de sus valores multiplicandolo por 10
            
            //primer intento: usando foreach (no se puede modificar item)
            /*foreach(double item in arreglo)
            {
                item = item * 10;
            }*/

            //segundo intento: usando for tradicional
            for( int i = 0; i < arreglo.Length; i++)
            {
                arreglo[i] = arreglo[i] * 10;
            }

            //C# tiene un metodo para imprimir colecciones
            //sin necesidad de recorrerlas con for
            Console.WriteLine( String.Join("\n",arreglo ) );
            Console.WriteLine(String.Join(",", arreglo));
            Console.WriteLine(String.Join(" ::: ", arreglo));
        }
    }
}
