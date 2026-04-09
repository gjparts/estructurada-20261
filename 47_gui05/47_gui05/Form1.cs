namespace _47_gui05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void casilla1_CheckedChanged(object sender, EventArgs e)
        {
            if (casilla1.Checked == true)
                etiqueta1.Text = "casilla1 esta marcada";
            else
                etiqueta1.Text = "casilla1 esta desmarcada";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //disparar el evento de casilla1
            casilla1_CheckedChanged(sender, e);
        }

        private void boton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"El valor de casilla1 es {casilla1.Checked}");
        }
    }
}
