using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arboles
{
    class Arbol
    {
        Nodo raizPrincipal;
        private string recorrido;

        public Nodo Inicio
        {
            get { return raizPrincipal; }
        }
        public string Recorrido
        {
            get { return recorrido; }
            set { recorrido = value; }
        }

        public void Agregar(Nodo nuevo)
        {
            if(raizPrincipal == null)
            {
                raizPrincipal = nuevo;
            }
            else
            {
                Agregar(nuevo, raizPrincipal);
            }
        }

        public void Agregar(Nodo nuevo, Nodo raiz)
        {
            if (nuevo.Numero < raiz.Numero)
            {
                if (raiz.Izquierdo == null)
                    raiz.Izquierdo = nuevo;
                else
                    Agregar(nuevo, raiz.Izquierdo);
            }
            else
            {
                if (raiz.Derecho == null)
                    raiz.Derecho = nuevo;
                else
                {
                    Agregar(nuevo, raiz.Derecho);
                }
            }

        }

        public void RecorridoPreOrden(Nodo inicio)
        {
            if (inicio != null)
            {
                recorrido += inicio.Numero;
                RecorridoPreOrden(inicio.Izquierdo);
                RecorridoPreOrden(inicio.Derecho);
            }
        }

        public void RecorridoPosOrden(Nodo inicio)
        {
            if (inicio != null)
            {
                RecorridoPosOrden(inicio.Izquierdo);
                RecorridoPosOrden(inicio.Derecho);
                recorrido += inicio.Numero;
            }
        }

        public void RecorridoEnOrden(Nodo inicio)
        {
            if (inicio != null)
            {
                RecorridoEnOrden(inicio.Izquierdo);
                recorrido += inicio.Numero;
                RecorridoEnOrden(inicio.Derecho);
            }
        }


        public string mostrar()
        {
            return recorrido;
            recorrido = "";
        }
    }
}
