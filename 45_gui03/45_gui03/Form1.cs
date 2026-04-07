namespace _45_gui03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void boton1_Click(object sender, EventArgs e)
        {
            //caza de errores
            try
            {
                //sumar el contenido de caja1 y caja2
                //extraer el contenido de cada caja de texto
                //y colocarlo en variables numericas para poder operarlos
                double a, b, c;
                a = double.Parse(caja1.Text);
                b = double.Parse(caja2.Text);
                //hacer la operacion
                c = a + b;
                //colocar el valor de c en el total:
                total.Text = c.ToString();
            }
            catch (Exception ex)
            {
                //en caso de error:
                MessageBox.Show("Solo se acepta numeros.");
                total.Text = "0.00";
            }
        }
    }
}
