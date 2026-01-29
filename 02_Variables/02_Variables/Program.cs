namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Variables:
             Es un espacio de almacenamiento temporal que esta
             dentro de la memoria principal (RAM) se utiliza para
             almacenar valores que pueden cambiar durante la vida del programa.
            Una variable debe tener un tipo de dato el cual dicta
            la naturaleza de la informacion que almacena.
            Por ejemplo numeros, texto, fecha, objetos, etc.
            Los tipos de datos se agrupan en:
            1) tipos de datos primitivos: son los que vienen definidos
               dentro del compilador del lenguaje de programacion.
               Ejemplos:
               En C++ son int, double, float, char, long, bool
               En C# son int, double, float, char, long, decimal, bool

            2) tipos de datos compuestos: son aquellos que estan formados
               por varios elementos primitivos.
               Ejemplos:
               En C++: string (es una coleccion de char)
               En C#: String, Object, Array, Class, Struct, Enum
            
            Consideraciones a la hora de nombrar variables:
            1) No use tíldes, eñes o simbolos
            2) Dos variables no pueden tener el mismo nombre dentro del
               mismo ambito (scope)
            3) Sea especifico con el nombre de su variable
            4) El nombre de la variable no puede iniciar con numeros
            5) No puede usar palabras reservadas para nombrar variables
               por ejemplo: for, if, while
            6) cuando haga referencia a una variable debe considerar
               la combinacion exacta de mayusculas y minusculas que
               uso al nombrarla
            7) cuando nombre dos variables que se llamen parecido
               pero tengan diferente combinacion de mayusculas y minusculas
               se cuidadoso de no cae en la ambigüedad:*/
            int Edad;
            int edad;
            int EDAD;
            int EdAd;
            int EDad;
            //lo anterior es confuso.
            //8) no utilice espacios en blanco el nombres de variables
            //   en su lugar se permite utilizar guion bajo:
            int edad_de_la_persona;

            /*Al nombrar variables existen diferentes notaciones
             que son aceptadas internacionalmente. Se recomienda adoptar
             una o dos de ellas.*/
            
            //notacion Pascal Case (Upper Camel Case)
            //Cada palabra en la variable inicia en mayuscula
            //ejemplos:
            int EdadPersona;
            double SalarioMensualEmpleado;

            //notacion Hungara o Camel Case
            //el nombre de la variable inicia en minuscula y cada palabra
            //siguiente inicia en mayuscula, ejemplos:
            int edadPersona;
            double salarioMensualEmpleado;

            //notacion Snake Case
            //se usa guiones bajos entre cada palabra y va en minusculas
            int edad_persona;
            double salario_mensual_empleado;

            //parte práctica:
            //declarar una variable sin valor de inicio o sin inicializar:
            int a;
            //lo anterior declara una variable de tipo entero de 4 bytes llamada: a
            //OJO! en C# no se puede leer una variable sin inicializar:
            //Console.WriteLine(a);
            //para poder leer una variable esta debe tener asignado un valor:
            a = 7;
            Console.WriteLine(a);
            //declarar e inicializar una variable:
            int b = 100;
            Console.WriteLine(b);

            //declarar multiples variables del mismo tipo en una sola instruccion:
            //sin valor de inicio:
            int num1, num2, num3;
            //con valor de inicio:
            int cifra1 = 5, cifra2 = 100, cifra3 = -45;

            //el tipo de dato int se utiliza para almacenar numeros
            //enteros de 4 bytes (32 bit)

            //tipos de dato para almacenar numeros decimales
            //double: guarda numeros con decimales de 8 bytes (64 bit), decimal de alta precision
            //float: guarda numeros con decimales de 4 byte (32 bit), decimal de baja precision
            double valorGrande = 3.1415926;
            float salario = 20000.46f;
            //note que al valor float en C# se le debe colocar una
            //letra f al final. Puede ser mayuscula o minuscula.

            /*tipo de dato Long
             Almacena un numero entero de alta precision (8 bytes, 64 bit)*/
            long enteroGrande = 1234123412345L;
            //se recomienda colocar una L mayuscula al final de
            //algun valor long.

            /*tipo de dato char: almacena un caracter.
             Mide 1 byte (8 bit)*/
            char c1 = 'z';
            char c2 = '4';
            char c3 = ' ';
            char c4 = '\\';
            char c5 = '"';
            //observe que el valor para char va encerrado en comillas simples
            //para obtener la comilla simple puede usar la combinacion ALT+39

            //dentro de char no se puede almacenar mas de un caracter

            //tipo de dato boolean: guarda true ó false (1 bit)
            //se llama asi en honor de George Boole
            //1 representa true
            //0 representa false
            bool respuesta = true;
            bool opcion = false;

            //Imprimir el valor de una variable en la consola o terminal
            //en C# existe dos formas de imprimir variables.
            //forma 1: concatenar la variable
            Console.WriteLine("El valor de salario es: "+salario);
            Console.WriteLine("El valor de respuesta es: "+respuesta);
            Console.WriteLine("El valor de c4 es: "+c4);
            Console.WriteLine("El valor de enteroGrande es: "+enteroGrande);
            
            //forma 2: usando interpolacion de string
            Console.WriteLine($"El valor de salario es: {salario}");
            Console.WriteLine($"El valor de respuesta es: {respuesta}");
            Console.WriteLine($"El valor de c4 es: {c4}");
            Console.WriteLine($"El valor de enteroGrande es: {enteroGrande}");

            //otros ejemplos:
            int x = 6, y = 7;
            //concatenando:
            Console.WriteLine("El valor de x es "+x+" el valor de y es "+y);
            //interpolando:
            Console.WriteLine($"El valor de x es {x} el valor de y es {y}");

            /*Ley de precedencia de operadores
            Las expresiones se evaluan de izquierda a derecha dando prioridad
            a los operadores de acuerdo a la tabla siguiente:
            1) Parentesis
            2) Exponentes Math.Pow
            3) Multiplicaciones y Divisiones
            4) Sumas y Restas
            5) Operadores logicos NOT !
            6) Operadores logicos AND &&
            7) Operadores logicos OR ||     (Alt+124)
            */
            double d1 = 5, d2 = 9, d3 = 2, d4 = 10;
            Console.WriteLine(d1+d2/d3);
            Console.WriteLine(d2/d3+d1);
            Console.WriteLine(d1/d4-d3);
            Console.WriteLine( (d1+d3)/d4+8 );
            //al 8 en la operacion anterior se conoce como valor constante

            //Concatenacion: unir dos elementos y transformarlos
            //en un solo string
            //el caracter para concatenar es el operador +
            string str1 = "La suma de dos mas dos es "+2+2;
            Console.WriteLine(str1);
            //Lo anterior imprimira un resultado incorrecto
            //debido a que el operador + es un operador
            //sobrecargado.
            //si a la izquierda o la derecha del operador +
            //hay un string entonces este operador va a unir ambos valores
            //sin operarlos.

            //si a la izquierda y derecha del operador + hay valores
            //numericos; entonces este operador va a sumarlos. ejm:
            string str2 = "La suma de dos mas dos es " + (2 + 2);
            Console.WriteLine(str2);

            /*string+numero = string
             numero+string = string
             numero+numero = numero*/

            //uso de elementos char en la concatenacion
            char char1 = 'A', char2 = 'B';
            Console.WriteLine(char1);
            Console.WriteLine(char2);
            //si concatena dos chars entonces se suma sus valores numericos
            Console.WriteLine(char1+char2); //131 porque A vale 65, B vale 66 como char en la tabla ASCII
            //si concatena un string entre los dos chars se imprime cada caracter concatenado
            Console.WriteLine(char1+""+char2);
            Console.WriteLine(0+char1); //valor numerico de A
            Console.WriteLine(0+char2); //valor numerico de B
            //recuerden que cada char dentro de la tabla de caracteres del sistema operativo
            //donde se encuentren tiene asignado un valor numerico. En el caso de Windows
            //del caracter 0 al 255 obedecen a la tabla ASCII (American Standard Code for
            //Information Interchange) despues del caracter 255 se le conoce como alfabeto
            //extendido y usualmente en Windows a partir de ahi se usa las tablas ANSI (American
            //National Standards Institute)
            
        }
    }
}
