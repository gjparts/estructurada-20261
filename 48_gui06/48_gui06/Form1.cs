using Microsoft.VisualBasic;

namespace _48_gui06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lista1.Items.Clear(); //limpiar la lista
            lista1.Items.Add("Perro");
            lista1.Items.Add("Gato");
            lista1.Items.Add("Loro");
            lista1.Items.Add("Perro ovejero");
        }

        private void boton1_Click(object sender, EventArgs e)
        {
            //agregar a lista1 lo que esta en caja1
            //primero validemos que hallan escrito algo en la caja de texto
            if (caja1.Text.Trim().Length > 0)
            {
                lista1.Items.Add(caja1.Text);
                caja1.Text = ""; //vaciar la caja luego de agregar
            }
            else
                MessageBox.Show("Debe escribir algo en la caja de texto.");
        }

        private void boton2_Click(object sender, EventArgs e)
        {
            //agregar a lista1 lo que digite en un InputBox
            string texto = Interaction.InputBox("Digite un animal","Agregar");
            if( texto.Trim().Length > 0)
            {
                lista1.Items.Add(texto);
            }
        }
    }
}
