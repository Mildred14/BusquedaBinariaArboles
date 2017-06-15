using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arboles
{
    class busquedaBinaria
    {
        private Nodo _raiz;

        private int _count;
        public int Count { get { return _count; } }

        public busquedaBinaria()
        {
            this._raiz = null;
            this._count = 0;
        }
        public void Add(Nodo nuevo)
        {
            if (_raiz == null)
                _raiz = nuevo;
            else
                Add(nuevo, _raiz);

            _count++;
        }
        private void Add(Nodo nuevo, Nodo raiz)
        {
            if (nuevo.Valor < raiz.Valor)
            {
                if (raiz.H_left == null)
                    raiz.H_left = nuevo;
                else
                    Add(nuevo, raiz.H_left);
            }
            else 
            {
                if (raiz.H_right == null)
                    raiz.H_right = nuevo;
                else
                    Add(nuevo, raiz.H_right);
            }
        }
        public bool Contains(Nodo nodo)
        {
            if (_raiz == null)
                return false;
            else
            {
                return Contains(nodo, _raiz) == true;
            }
        }
        private bool Contains(Nodo nodo, Nodo raiz)
        {
            bool res = false;

            if (raiz != null)
            {
                if (nodo.Valor != raiz.Valor)
                {
                    if (nodo.Valor < raiz.Valor)
                        res = Contains(nodo, raiz.H_left);
                    else
                        res = Contains(nodo, raiz.H_right);
                }
                else
                    res = true;
            }
            return res;
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //METODO PRE-ORDER
        public string PreOrder()
        {
            if (_raiz != null)
                return PreOrder(_raiz);

            return string.Empty;
        }
        private string PreOrder(Nodo raiz)
        {
            string res = string.Empty;

            if (raiz != null)
            {
                res += raiz.ToString();

                res += PreOrder(raiz.H_left);

                res += PreOrder(raiz.H_right);
            }
            return res;
        }
        public string InOrder()
        {
            if (_raiz != null)
                return InOrder(_raiz);

            return string.Empty;
        }
        private string InOrder(Nodo raiz)
        {
            string res = string.Empty;

            if (raiz != null)
            {
                res += InOrder(raiz.H_left);

                res += raiz.ToString();

                res += InOrder(raiz.H_right);
            }
            return res;
        }
        public string PostOrder()
        {
            if (_raiz != null)
                return PostOrder(_raiz);

            return string.Empty;
        }
        private string PostOrder(Nodo raiz)
        {
            string res = string.Empty;

            if (raiz != null)
            {
                res += PostOrder(raiz.H_left);

                res += PostOrder(raiz.H_right);

                res += raiz.ToString();
            }
            return res;
        }
        public void Clear()
        {
            _raiz = null;
            _count = 0;
        }
    }
}

