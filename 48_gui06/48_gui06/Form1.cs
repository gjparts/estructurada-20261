using Microsoft.VisualBasic;

namespace _48_gui06
{
    public partial class Form1 : Form
    {
        //funcion para contar (sumaria)
        public void Contar()
        {
            int perros = 0, gatos = 0; //variables contador

            //recorrer cada item de la lisyta e irlos analizando
            for(int i = 0; i < lista1.Items.Count; i++)
            {
                //recuperar el texto de i-esimo item
                string texto = lista1.Items[i].ToString();
                //clasificar la informacion
                if (texto.ToUpper().Contains("GATO") == true) gatos++;
                if (texto.ToUpper().Contains("PERRO") == true) perros++;
            }

            //mostrar los resultados en las cajas de texto
            caja2.Text = gatos.ToString();
            caja3.Text = perros.ToString();
        }

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

            Contar(); //ejecutar la funcion para contar
        }

        private void boton1_Click(object sender, EventArgs e)
        {
            //agregar a lista1 lo que esta en caja1
            //primero validemos que hallan escrito algo en la caja de texto
            if (caja1.Text.Trim().Length > 0)
            {
                lista1.Items.Add(caja1.Text);
                caja1.Text = ""; //vaciar la caja luego de agregar
                Contar(); //ejecutar la funcion para contar
            }
            else
                MessageBox.Show("Debe escribir algo en la caja de texto.");
        }

        private void boton2_Click(object sender, EventArgs e)
        {
            //agregar a lista1 lo que digite en un InputBox
            string texto = Interaction.InputBox("Digite un animal", "Agregar");
            if (texto.Trim().Length > 0)
            {
                lista1.Items.Add(texto);
                Contar(); //ejecutar la funcion para contar
            }
        }

        private void boton3_Click(object sender, EventArgs e)
        {
            //editar item de la lista
            //primero validamos que halla item seleccionado
            if (lista1.SelectedIndex == -1)
                MessageBox.Show("Debe seleccionar un item de la lista");
            else
            {
                //editar
                string texto = Interaction.InputBox("Digite el nuevo nombre", "Editar", lista1.Text);
                if (texto.Trim().Length > 0)
                {
                    //actualizar el texto del item seleccionado
                    lista1.Items[lista1.SelectedIndex] = texto;
                    Contar(); //ejecutar la funcion para contar
                }
            }
        }

        private void boton4_Click(object sender, EventArgs e)
        {
            //eliminar item seleccionado
            if (lista1.SelectedIndex == -1)
                MessageBox.Show("Debe seleccionar un item de la lista");
            else
            {
                //preguntar al usuario si desea eliminar
                DialogResult respuesta;
                respuesta = MessageBox.Show("Desea eliminar el item?", "Eliminar", MessageBoxButtons.YesNo);
                if (respuesta == DialogResult.Yes)
                {
                    //eliminar
                    lista1.Items.RemoveAt(lista1.SelectedIndex);
                    Contar(); //ejecutar la funcion para contar
                }
            }
        }

        private void boton5_Click(object sender, EventArgs e)
        {
            //borrar todos los items
            //preguntar primero
            DialogResult respuesta;
            respuesta = MessageBox.Show("Desea eliminar todos los items?","Limpiar",MessageBoxButtons.YesNo);
            if(respuesta == DialogResult.Yes)
            {
                lista1.Items.Clear();
                Contar(); //ejecutar la funcion para contar
            }
        }
    }
}
