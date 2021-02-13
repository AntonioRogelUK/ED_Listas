using System;
using System.Collections.Generic;
using System.Text;

namespace ListasSimplementeLigadas
{
    public class Lista
    {
        Nodo nodoInicial;
        Nodo nodoActual;

        public Lista()
        {
            nodoInicial = new Nodo();
        }

        public bool ValidaVacio() 
        {
            if (nodoInicial.Enlace == null) 
            {
                return true;
            }
            return false;
        }

        public void VaciarLista() 
        {
            nodoInicial.Enlace = null;
        }

        public string RecorrerLista() 
        {
            string valores = string.Empty;

            nodoActual = nodoInicial;

            while (nodoActual.Enlace != null) 
            {
                nodoActual = nodoActual.Enlace;
                valores += $"{nodoActual.Valor}\n";
            }

            return valores;
        }

        public void AgregarNodo(string valor)
        {
            nodoActual = nodoInicial;

            while(nodoActual.Enlace != null) 
            {
                nodoActual = nodoActual.Enlace;
            }

            Nodo nuevoNodo = new Nodo(valor);

            nodoActual.Enlace = nuevoNodo;
        }

        public void AgregarNodoInicio(string valor) 
        {
            nodoActual = nodoInicial;
            Nodo nuevoNodo = new Nodo(valor, nodoActual.Enlace);
            nodoActual.Enlace = nuevoNodo;
        }

        public Nodo Buscar(string valor) 
        {
            if (ValidaVacio() == false) 
            {
                Nodo nodoBusqueda = nodoInicial;
                
                while(nodoBusqueda.Enlace != null) 
                {
                    nodoBusqueda = nodoBusqueda.Enlace;
                    
                    if (nodoBusqueda.Valor == valor) 
                    {
                        return nodoBusqueda;
                    }
                }
            }

            return null;
        }

        public Nodo BuscarPorIndice(int indice) 
        {
            int Indice = -1;

            if (ValidaVacio() == false) 
            {
                Nodo nodoBusqueda = nodoInicial;

                while (nodoBusqueda.Enlace != null) 
                {
                    nodoBusqueda = nodoBusqueda.Enlace;
                    Indice++;

                    if(Indice == indice) 
                    {
                        return nodoBusqueda;
                    }
                }
            }

            return null;
        }

        public Nodo BuscarAnterior(string valor) 
        {
            if (ValidaVacio() == false) 
            {
                Nodo nodoBusqueda = nodoInicial;

                while (nodoBusqueda.Enlace != null 
                            && nodoBusqueda.Enlace.Valor != valor)
                {
                    nodoBusqueda = nodoBusqueda.Enlace;
                    if(nodoBusqueda.Enlace.Valor == valor) 
                    {
                        return nodoBusqueda;
                    }
                }
            }
            return null;
        }

        public void BorrarNodo(string valor) 
        {
            if (ValidaVacio() == false) 
            {
                nodoActual = Buscar(valor);
                
                if (nodoActual != null) 
                {
                    Nodo nodoAnterior = BuscarAnterior(valor);
                    nodoAnterior.Enlace = nodoActual.Enlace;
                    nodoActual.Enlace = null;
                }
            }
        }
    }
}
