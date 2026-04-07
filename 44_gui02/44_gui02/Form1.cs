namespace _44_gui02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void boton1_Click(object sender, EventArgs e)
        {
            //Mostrar mensaje
            MessageBox.Show("Hola");
            //cambiar el texto del label llamado etiqueta1
            etiqueta1.Text = "UNAH Cortés";
        }

        private void boton2_Click(object sender, EventArgs e)
        {
            //cambiar el titulo al Form actual
            this.Text = "San Pedro Sula";
        }

        private void temporizador1_Tick(object sender, EventArgs e)
        {
            //colocar la fecha y la hora en etiqueta2
            etiqueta2.Text = DateTime.Now.ToString();
        }

        private void etiqueta1_Click(object sender, EventArgs e)
        {

        }
    }
}
