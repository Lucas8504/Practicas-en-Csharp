using System;

namespace Recursividad7
{
    public class Recursividad
    {
        class Nodo
        {
            public int info;
            public Nodo sig;
        }

        private Nodo raiz;

        void InsertarPrimero(int x)
        {
            Nodo nuevo = new Nodo();
            nuevo.info = x;
            nuevo.sig = raiz;
            raiz = nuevo;
        }

        private void ImprimirInversa(Nodo reco)
        {
            if (reco != null)
            {
                ImprimirInversa(reco.sig);
                Console.Write(reco.info + "-");
            }
        }

        public void ImprimirInversa()
        {
            ImprimirInversa(raiz);
        }

        static void Main(string[] args)
        {
            Recursividad r = new Recursividad();
            r.InsertarPrimero(10);
            r.InsertarPrimero(4);
            r.InsertarPrimero(5);
            r.ImprimirInversa();
            Console.ReadKey();
        }
    }
}