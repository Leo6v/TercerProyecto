using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TercerProyecto
{
    public partial class Form1 : Form
    {
        // Diccionario ordenado para almacenar nombres de postres y sus listas de ingredientes
        private SortedDictionary<string, List<string>> Postres = new SortedDictionary<string, List<string>>();

        public Form1()
        {
            InitializeComponent();

            // Inicializar los postres al cargar el formulario
            InicializarPostres();
        }

        // Inicializa ejemplos de postres con sus ingredientes
        private void InicializarPostres()
        {
            // Agregar ejemplos de postres con sus ingredientes al diccionario
            Postres.Add("Pastel de Chocolate", new List<string>
            {
                // Ingredientes para el pastel de chocolate
                "1 1/2 Barras de Mantequilla a temperatura ambiente (90 g c/u)",
                "1 Lata de Leche Condensada",
                "3 Huevos",
                "1 1/2 Tazas de Harina de trigo",
                "1 Cucharadita de Polvo para hornear",
                "1 1/2 Barras de Chocolate semiamargo fundido"
            });

            Postres.Add("Galletas", new List<string>
            {
                // Ingredientes para las galletas
                "Harina de trigo – principal componente de casi todas las formulaciones de galletas.",
                "Azúcar.",
                "Grasa – Puede ser de origen animal (mantequilla, manteca) o vegetal."
            });

            Postres.Add("Tarta de Manzana", new List<string>
            {
                // Ingredientes para la tarta de manzana
                "4 manzanas",
                "180 gr. de harina",
                "1/2 sobre de levadura química (8 gramos de polvos para hornear)",
                "2 huevos",
                "100 gr. de azúcar moreno",
                "175 ml. de leche"
            });

            Postres.Add("Flan", new List<string>
            {
                // Ingredientes para el flan
                "5 huevos",
                "1 lata (12oz) de leche evaporada",
                "1 lata (14oz) de leche condensada",
                "1 cucharada de vainilla"
            });

            // Configurar la fuente de datos para el ComboBox de selección de postres
            cmbPostres.DataSource = new BindingSource(Postres, null);
            cmbPostres.DisplayMember = "Key"; // Mostrar los nombres de los postres en el ComboBox
        }

        // Se llama cuando se cambia la selección en el ComboBox de postres
        private void cmbPostres_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPostres.SelectedItem != null)
            {
                // Obtener el postre seleccionado del ComboBox
                KeyValuePair<string, List<string>> selectedPostre = (KeyValuePair<string, List<string>>)cmbPostres.SelectedItem;

                // Configurar la fuente de datos para la lista de ingredientes con los ingredientes del postre seleccionado
                lstIngredientes.DataSource = selectedPostre.Value;
            }
        }

        // Se ejecuta cuando se hace clic en el botón "Agregar Ingrediente"
        private void btnAgregarIngrediente_Click(object sender, EventArgs e)
        {
            if (cmbPostres.SelectedItem != null)
            {
                // Obtener el postre seleccionado del ComboBox
                KeyValuePair<string, List<string>> selectedPostre = (KeyValuePair<string, List<string>>)cmbPostres.SelectedItem;

                // Agregar un nuevo ingrediente ingresado al final de la lista de ingredientes del postre seleccionado
                selectedPostre.Value.Add(txtNuevoIngrediente.Text.Trim());

                // Actualizar la fuente de datos de la lista de ingredientes para reflejar los cambios
                lstIngredientes.DataSource = null;
                lstIngredientes.DataSource = selectedPostre.Value;
            }
        }

        // Se ejecuta cuando se hace clic en el botón "Eliminar Ingrediente"
        private void btnEliminarIngrediente_Click(object sender, EventArgs e)
        {
            if (cmbPostres.SelectedItem != null && lstIngredientes.SelectedItem != null)
            {
                // Obtener el postre seleccionado del ComboBox
                KeyValuePair<string, List<string>> selectedPostre = (KeyValuePair<string, List<string>>)cmbPostres.SelectedItem;

                // Eliminar el ingrediente seleccionado de la lista de ingredientes del postre
                selectedPostre.Value.Remove(lstIngredientes.SelectedItem.ToString());

                // Actualizar la fuente de datos de la lista de ingredientes para reflejar los cambios
                lstIngredientes.DataSource = null;
                lstIngredientes.DataSource = selectedPostre.Value;
            }
        }

        // Se ejecuta cuando se hace clic en el botón "Agregar Postre"
        private void btnAgregarPostre_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNuevoPostre.Text))
            {
                // Obtener el nombre del nuevo postre desde el cuadro de texto
                string nuevoPostre = txtNuevoPostre.Text.Trim();

                // Verificar si el postre ya existe en el diccionario
                if (!Postres.ContainsKey(nuevoPostre))
                {
                    // Agregar el nuevo postre al diccionario con una lista de ingredientes vacía
                    Postres.Add(nuevoPostre, new List<string>());

                    // Actualizar la fuente de datos del ComboBox de postres para reflejar los cambios
                    cmbPostres.DataSource = null;
                    cmbPostres.DataSource = new BindingSource(Postres, null);
                    cmbPostres.DisplayMember = "Key";

                    // Limpiar el cuadro de texto para agregar postres
                    txtNuevoPostre.Clear();
                }
                else
                {
                    MessageBox.Show("El postre ya existe.");
                }
            }
        }

        // Se ejecuta cuando se hace clic en el botón "Eliminar Postre"
        private void btnEliminarPostre_Click(object sender, EventArgs e)
        {
            if (cmbPostres.SelectedItem != null)
            {
                // Obtener el postre seleccionado del ComboBox
                KeyValuePair<string, List<string>> selectedPostre = (KeyValuePair<string, List<string>>)cmbPostres.SelectedItem;

                // Eliminar el postre seleccionado del diccionario
                Postres.Remove(selectedPostre.Key);

                // Actualizar la fuente de datos del ComboBox de postres para reflejar los cambios
                cmbPostres.DataSource = null;
                cmbPostres.DataSource = new BindingSource(Postres, null);
                cmbPostres.DisplayMember = "Key";

                // Limpiar la fuente de datos de la lista de ingredientes
                lstIngredientes.DataSource = null;
            }
        }

        // Se llama cuando se cambia la selección en la lista de ingredientes
        private void lstIngredientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPostres.SelectedItem != null)
            {
                // Obtener el postre seleccionado del ComboBox
                KeyValuePair<string, List<string>> selectedPostre = (KeyValuePair<string, List<string>>)cmbPostres.SelectedItem;

                // Configurar la fuente de datos para la lista de ingredientes con los ingredientes del postre seleccionado
                lstIngredientes.DataSource = selectedPostre.Value;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //msj de pregunta para cerrar programa
            if (MessageBox.Show("Desea salir del sistema", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Environment.Exit(0);
        }
    } // Fin de la clase Form1
} // Fin del espacio de nombres TercerProyecto