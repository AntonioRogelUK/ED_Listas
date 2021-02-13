using System;

namespace ListasSimplementeLigadas
{
    class Program
    {
        static void Main(string[] args)
        {
            Nodo nodo = new Nodo();

            Console.WriteLine(nodo.Valor); //Esto utiliza el get
            
            nodo.Valor = "Un valor"; //Esto utiliza el set

            //nodo.Valor = "ABC";

            Console.WriteLine(nodo.Valor);
        }
    }
}
