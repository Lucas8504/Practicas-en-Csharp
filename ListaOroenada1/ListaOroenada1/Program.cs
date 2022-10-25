using System;

namespace ListaOrdenada1
{
    class ListaOrdenada
    {
        class Nodo
        {
            public int info;
            public Nodo sig;
        }

        private Nodo raiz;

        public ListaOrdenada()
        {
            raiz = null;
        }

        void Insertar(int x)
        {
            Nodo nuevo = new Nodo();
            nuevo.info = x;
            if (raiz == null)
            {
                raiz = nuevo;
            }
            else
            {
                if (x < raiz.info)
                {
                    nuevo.sig = raiz;   // El siguiente al nuevo se enlaza a la raiz
                    raiz = nuevo;       // Y la raiz aloja a nuevo
                }
                else
                {
                    Nodo reco = raiz;   
                    Nodo atras = raiz;
                    while (x >= reco.info && reco.sig != null)
                    {
                        atras = reco;       // Atras pasa a la posicion de reco.
                        reco = reco.sig;    // Y reco a la posicion de reco.sig (el siguente de reco).
                    }
                    if (x >= reco.info)    // Si x es mayor o igual que reco.info
                    {
                        reco.sig = nuevo;       // La informacion de nuevo se insertara al final de la lista (siguiente de reco)
                    }
                    else
                    {
                        nuevo.sig = reco;       // El siguiente de nuevo pasa a la posicion de reco
                        atras.sig = nuevo;      // La imforacion de nuevo de insertara en la posicion siguiente de atras
                    }
                }
            }
        }


        public void Imprimir()
        {
            Nodo reco = raiz;
            while (reco != null)
            {
                Console.Write(reco.info + "-");
                reco = reco.sig;
            }
            Console.WriteLine();
        }


        static void Main(string[] args)
        {
            ListaOrdenada lo = new ListaOrdenada();
            lo.Insertar(10);
            lo.Insertar(5);
            lo.Insertar(7);
            lo.Insertar(50);
            lo.Imprimir();
            Console.ReadKey();
        }
    }
}
