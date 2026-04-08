namespace _46_gui04
{
    public partial class Form1 : Form
    {
        //funcion para sumar
        public void Calcular()
        {
            try
            {
                double a, b, c, d, suma;
                a = double.Parse(caja1.Text);
                b = double.Parse(caja2.Text);
                c = double.Parse(caja3.Text);
                d = double.Parse(caja4.Text);
                //operacion:
                suma = a + b + c + d;
                //redondear el resultado a dos decimales
                suma = Math.Round(suma, 2);
                //colocar la suma en la caja de total
                total.Text = suma.ToString();
            }
            catch (Exception ex)
            {
                //en caso de error
                total.Text = "Solo se admite numeros";
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void caja1_TextChanged(object sender, EventArgs e)
        {
            Calcular();
        }

        private void caja2_TextChanged(object sender, EventArgs e)
        {
            Calcular();
        }

        private void caja3_TextChanged(object sender, EventArgs e)
        {
            Calcular();
        }

        private void caja4_TextChanged(object sender, EventArgs e)
        {
            Calcular();
        }
    }
}
