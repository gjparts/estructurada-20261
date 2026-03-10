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

            //Concatenar String
            string fruta = "Manzana";
            string color2 = "Verde";
            string cadena3 = fruta + " " + color2;
            Console.WriteLine($"{cadena3}");

            //Otra forma de concatenar: por medio del interpolador $
            string cadena4 = $"{fruta} {color2}";
            Console.WriteLine($"{cadena4}");

            //se puede almacenar numeros en un String?
            //string s1 = 7; //por conversion implicita no se puede
            //pero si aprovechamos la ley de precedencia de operadores
            //podemos saltarnos la conversion implicita y hacerla
            //una concatenacion
            string s1 = "" + 6; //por medio de la inyeccion de string vacio
            //otra forma es convertir el numero usando un metodo:
            string s2 = 6.ToString();
            //mas ejemplos:
            string s3 = ""+2.456;
            string s4 = 5.231.ToString();

            //conocer la longitud de un string
            string s5 = "UNAH Cortes";
            Console.WriteLine($"s5: {s5}");
            Console.WriteLine($"Longitud de s5: {s5.Length}");
            //la propiedad Length devuelve un valor int el cual
            //indica cuantos caracteres tiene un String

            //dentro de un String cada caracter se enumera
            //desde 0 hasta Length-1 (Zero indexing)
            //para obtener un caracter de una posicion determinada
            //se le da la posicion del char deseado la cual se pone
            //entre corchetes (similar a como lo hace con un arreglo)
            string s6 = "Honduras";
            Console.WriteLine($"s6: {s6}");
            Console.WriteLine($"Primer caracter de s6: {s6[0]}");
            Console.WriteLine($"Caracter en la posicion 4: {s6[4]}");
            Console.WriteLine($"Ultimo caracter de s6: {s6[7]}");
            Console.WriteLine($"Ultimo caracter de s6: {s6[s6.Length-1]}");
            Console.WriteLine($"Penultimo caracter de s6: {s6[s6.Length - 2]}");

            string comida = "Pollo frito";
            //haga un programa que imrima el string comida colocando
            //cada uno de sus caracteres en un renglon diferente.
            for(int i = 0; i < comida.Length; i++)
            {
                Console.WriteLine(comida[i]);
            }

            //en C# no es posible cambiar un elemento char que esta
            //dentro de un String por medio del uso de corchetes:
            //comida[1] = 'X';

            //Transformaciones de String
            //obtener una version en mayusculas o minusculas de un String
            //metodos a usar: ToUpper(), ToLower()
            //el usar estos metodos no altera al String original
            string ciudad = "San Pedro Sula";
            Console.WriteLine($"ciudad en mayusculas: {ciudad.ToUpper()}");
            Console.WriteLine($"ciudad en minusculas: {ciudad.ToLower()}");
            Console.WriteLine($"string original: {ciudad}");
            //si Usted quisiera alterar la variable original, simplemente
            //la debe sobreescribir con la copia:
            ciudad = ciudad.ToUpper();
            Console.WriteLine($"string original: {ciudad}");

            //Metodo Trim()
            //Devuelve una copia del String a la cual se le ha
            //eliminado los espacios en blanco iniciales y finales
            //tambien conocidos como espacios de relleno.
            //-> Este metodo no afecta al String original.
            string persona = "     Gerardo Portillo             ";
            Console.WriteLine($"persona: *{persona}*");
            Console.WriteLine($"Longitud de persona: {persona.Length}");
            //impresion usando Trim:
            Console.WriteLine($"Trim a persona: *{persona.Trim()}*");
            Console.WriteLine($"Longitud de persona con Trim: {persona.Trim().Length}");
            //imprimir la variable original:
            Console.WriteLine($"persona: *{persona}*");
            //deseo alterar la variable original y dejarla sin relleno:
            persona = persona.Trim();
            Console.WriteLine($"persona: *{persona}*");

            string bebida = "     Coca Cola 3L               ";
            /*Ejercicio: imprima la variable bebida; pero sin relleno de espacios
             y en mayusculas, sin alterar la variable original usando
            una sola instruccion.*/
            Console.WriteLine(bebida.Trim().ToUpper()); //forma 1
            Console.WriteLine(bebida.ToUpper().Trim()); //forma 2

            //Concatenar valores char a un String
            string vehiculo = "Honda Civic 2022";
            //concatenar un char sin afectar a la variable original
            Console.WriteLine(vehiculo+'X');
            Console.WriteLine($"vehiculo (original): {vehiculo}");

            //concantenar un char afectando a la variable original:
            vehiculo = vehiculo + 'S';
            Console.WriteLine($"vehiculo (original): {vehiculo}");

            //concatenar varios char a un String afectando la var. original
            string cliente = "Gerardo Portillo";
            cliente = cliente + 'X' + 'Y' + 'Z';
            Console.WriteLine($"cliente: {cliente}");

            //lo anterior no es practico, si va a concatenar
            //varios char juntos mejor concatene un String:
            string comprador = "Gerardo Portillo";
            comprador = comprador + "XYZ";
            Console.WriteLine($"comprador: {comprador}");

            //puede suceder tambien que tenga el char
            //almacenado en una variable:
            char equis = 'X';
            string proveedor = "Panaderia Popular";
            proveedor = proveedor + equis;
            Console.WriteLine($"proveedor: {proveedor}");

            //lo que no conviene hacer:
            //concatenar varios char usando un operador de incremento:
            string pet = "sabueso";
            pet += 'Z'; //esto si se puede
            Console.WriteLine($"pet: {pet}");

            //lo que no se puede
            pet += 'Q' + 'W' + 'E';
            Console.WriteLine($"pet: {pet}");
            //lo anterior suma los valores numericos de Q W E
            //mostrando un numero en lugar de QWE

            /*Operador Ternario
             Retorna el resultado de evaluar una o varias condiciones.
            Dicho resultado puede tener dos posibilidades:
            a) el resultado si se cumplen las condiciones
            b) el resultado si NO se cumplen las condiciones
            -> IMPORTANTE: cada uno de los resultados debe de ser
               del mismo tipo de dato.*/
            //ejemplos:
            float venta = 1000;
            bool pagaImpuesto = true;
            //si paga impuesto se imprime la venta mas el 15%
            //sino solo se imprime la venta.
            Console.WriteLine($"Valor a pagar:{(pagaImpuesto == true ? venta * 1.15f : venta)}");

            //asignar el mayor por medio de un ternario: (deben tener el mismo tipo de dato)
            int a = 5, b = 3;
            int mayor = ( a > b ? a : b );
            Console.WriteLine($"mayor: {mayor}");


        }
    }
}
