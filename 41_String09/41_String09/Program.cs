namespace _41_String09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Haga un programa que lea un numero de DNI el programa.
            -> luego debera eliminar los espacios en blanco, guiones, guiones bajos de dicho DNI.
            -> despues debera validar si este numero es de 13 caracteres.
            -> por ultimo debera imprimir del DNI la informacion siguiente:
            1) numero de departamento
            2) numero de municipio
            3) año de asentamiento
            4) correlativo

            ejemplo:
            Digite su DNI: 1401-1982-01055
            Departamento: 14
            Municipio: 01
            Año: 1982
            Correlativo: 01055*/
            string dni;
            Console.Write("Digite su DNI: ");
            dni = Console.ReadLine();

            //sanitizar el String
            dni = dni.Replace(" ", "").Replace("-", "").Replace("_", "");
            //validar si tiene 13 caracteres:
            if( dni.Length == 13)
            {
                Console.WriteLine($"Departamento: {dni.Substring(0,2)}");
                Console.WriteLine($"Municipio: {dni.Substring(2, 2)}");
                Console.WriteLine($"Año: {dni.Substring(4, 4)}");
                Console.WriteLine($"Correlativo: {dni.Substring(8)}");
            }
            else
                Console.WriteLine("DNI debe ser de 13 caracteres.");
        }
    }
}
