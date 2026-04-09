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

            //llenar combo1 por programacion
            combo1.Items.Clear(); //limpiar lista
            combo1.Items.Add("Manzana");
            combo1.Items.Add("Sandia");
            combo1.Items.Add("Pera");
            combo1.Items.Add("Melon");
            combo1.Items.Add("Kiwi");
            combo1.Items.Add("Naranja");
            combo1.Items.Add("Banana");
            //colocar el primer item como valor predeterminado para combo1
            combo1.SelectedIndex = 0;
            //configurar combo1 para que no se pueda escribir en el
            combo1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void boton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"El valor de casilla1 es {casilla1.Checked}");
        }

        private void combo1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //colocar en las etiquetas el index y el value de combo1
            etiqueta2.Text = $"Indice: {combo1.SelectedIndex}";
            etiqueta3.Text = $"Valor: {combo1.Text}";

            //si selecciona Sandia que coloree el formulario de verde
            if (combo1.Text == "Sandia")
                this.BackColor = Color.GreenYellow;
            else
                this.BackColor = Control.DefaultBackColor; //sin color de fondo
        }

        private void boton2_Click(object sender, EventArgs e)
        {
            combo1.Text = "Sandia";
        }

        private void boton3_Click(object sender, EventArgs e)
        {
            combo1.SelectedIndex = 4;
        }
    }
}
