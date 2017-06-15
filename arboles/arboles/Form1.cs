using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arboles
{
    public partial class Form1 : Form
    {
        busquedaBinaria arbol = new busquedaBinaria();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void agregar_Click(object sender, EventArgs e)
        {
            Nodo nuevo = new Nodo(Convert.ToInt32(Numero.Text));
            arbol.Add(nuevo);
            Numero.Text = string.Empty;
        }

        private void preOrder_Click(object sender, EventArgs e)
        {
            Resultado.Text = arbol.PreOrder();
        }

        private void inOrder_Click(object sender, EventArgs e)
        {
            Resultado.Text = arbol.InOrder();
        }

        private void post_Click(object sender, EventArgs e)
        {
            Resultado.Text = arbol.PostOrder();
        }

        private void Contains_Click(object sender, EventArgs e)
        {
            Nodo nodo = new Nodo(Convert.ToInt32(Buscar.Text));

            if (arbol.Contains(nodo))
            {
                Resultado.Text = "Ha sido encontrado";
            }
            else
                Resultado.Text = "No se encontro";
        }

        private void Count_Click(object sender, EventArgs e)
        {
            Resultado.Text = Convert.ToString(arbol.Count);
        }
    }
}
