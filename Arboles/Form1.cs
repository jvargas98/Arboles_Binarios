using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arboles
{
    public partial class Form1 : Form
    {
        Arbol arbol = new Arbol();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txtNumero.Text);
            Nodo nuevo = new Nodo(numero);
            arbol.Agregar(nuevo);
            txtNumero.Clear();
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            arbol.Recorrido = "";
            arbol.RecorridoPreOrden(arbol.Inicio);
            txtRecorrido.Text = arbol.mostrar();
        }

        private void btnPos_Click(object sender, EventArgs e)
        {
            arbol.Recorrido = "";
            arbol.RecorridoPosOrden(arbol.Inicio);
            txtRecorrido.Text = arbol.mostrar();
        }

        private void btnEn_Click(object sender, EventArgs e)
        {
            arbol.Recorrido = "";
            arbol.RecorridoEnOrden(arbol.Inicio);
            txtRecorrido.Text = arbol.mostrar();
        }
    }
}
