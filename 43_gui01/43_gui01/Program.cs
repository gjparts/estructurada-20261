namespace _43_gui01
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Principal());

            /*Interfaz Grafica de Usuario 
             Graphic User Interface (GUI)
            Es una forma gráfica de representar elementos en pantalla para facilitar
            la interaccion con los programas. Se trata de presentar elementos responsivos
            como botones, cajas de texto, imagenes, etiquetas y demas con la finalidad
            de hace rmas amigable la manipulacion de los programas.
            -> Importante: Interfaz grafica de usuario NO es lo mismo que programacion orientada a objetos.
            -> Una interfaz grafica es una VISTA en pantalla de ciertos elementos del programa
            -> Incluso puede exister interfaz grafica en lenguajes que no son orientados a objetos

            En C# no es posible tener interfaz grafica en un proyecto de tipo Consola
            para ello se necesita ciertas dependencias o librerias. Entonces debera crear un
            nuevo proyecto de Windows Forms.*/
        }
    }
}