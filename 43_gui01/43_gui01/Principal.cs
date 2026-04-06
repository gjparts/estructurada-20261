namespace _43_gui01
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ha hecho click en el boton");
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            //el evento Load se ejecuta antes de dibujar el Form en pantalla
            MessageBox.Show("Bienvenido");
        }

        private void Principal_Shown(object sender, EventArgs e)
        {
            //el evento Shown sucede luego de dibujar el Form en pantalla
            MessageBox.Show("Un gusto saludarlo");
        }

        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            //el evento FormClosed sucede luego de cerrar el Form
            MessageBox.Show("Adios");
        }

        private void botonPrueba_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Contenido de la caja1: {caja1.Text}");
        }
    }
}
