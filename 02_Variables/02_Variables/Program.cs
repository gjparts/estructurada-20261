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
        }
    }
}
