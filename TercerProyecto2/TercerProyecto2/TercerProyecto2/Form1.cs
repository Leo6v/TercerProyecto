using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TercerProyecto2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Crear una instancia de la clase LinkedList<int> (Una lista enlazada es una colección de elementos
            // llamados "nodos", donde cada nodo contiene un valor y una referencia al siguiente nodo en la lista.)
            LinkedList<int> lista = new LinkedList<int>();

            // Obtener el texto del TextBox y dividirlo por comas
            string[] numeros = txtNumeros.Text.Split(',');

            // Recorrer el arreglo de cadenas y convertir cada elemento a un entero
            // Agregar cada entero al final de la lista
            foreach (string numero in numeros)
            {
                int n = int.Parse(numero);
                lista.AddLast(n);
            }

            // Obtener el primer y el último elemento de la lista
            int min = lista.First.Value;
            int max = lista.Last.Value;

            // Crear una variable entera llamada actual e inicializarla con el valor del primer elemento
            int actual = min;

            // Crear un iterador para recorrer la lista
            LinkedListNode<int> nodo = lista.First;

            // Mientras que el valor actual sea menor o igual que el valor máximo
            while (actual <= max)
            {
                // Si el valor actual es igual al valor del elemento actual de la lista
                if (actual == nodo.Value)
                {
                    // Mover el iterador al siguiente elemento
                    nodo = nodo.Next;
                }
                else
                {
                    // Agregar el valor actual al final de la lista
                    lista.AddLast(actual);
                }

                // Incrementar el valor actual en uno
                actual++;
            }

            // Convertir la lista enlazada a un arreglo, ordenar el arreglo y recrear la lista enlazada
            int[] sortedArray = lista.ToArray();
            Array.Sort(sortedArray);
            lista = new LinkedList<int>(sortedArray);

            // Crear una variable de cadena llamada resultado e inicializarla con una cadena vacía
            string resultado = "";

            // Recorrer la lista y concatenar cada elemento a la variable resultado separado por comas
            foreach (int n in lista)
            {
                resultado += n + ",";
            }

            // Eliminar la última coma de la variable resultado
            resultado = resultado.TrimEnd(',');

            // Asignar el valor de la variable resultado al texto del Label
            lblResultado.Text = "Resultado: " + resultado;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //msj de pregunta para cerrar programa
            if (MessageBox.Show("Desea salir del sistema", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Environment.Exit(0);
        }
    }
}