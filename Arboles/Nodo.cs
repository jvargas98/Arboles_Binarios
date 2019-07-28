using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arboles
{
    class Nodo
    {
        private char _valor;
        private int _numero;
        private Nodo izquierdo;
        private Nodo derecho;

        public char Valor
        {
            get { return _valor; }
            set { _valor = value; }
        }

        public int Numero
        {
            get { return _numero; }
        }

        public Nodo Izquierdo
        {
            get { return izquierdo; }
            set { izquierdo = value; }
        }

        public Nodo Derecho
        {
            get { return derecho; }
            set { derecho = value; }
        }

        public Nodo(int numero)
        {
            _numero = numero;
        }
        public override string ToString()
        {
            string cadena = "";
            cadena = "Valor: " + _valor;
            return cadena;
        }
    }
}
