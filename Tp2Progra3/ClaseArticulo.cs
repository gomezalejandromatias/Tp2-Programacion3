using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp2Progra3
{
    internal class ClaseArticulo
    {

        private string _CodArticulo = "";
        private string _Nombre = "";
        private string _Descripcion = "";
        private decimal _Precio = 0;
        private int _IDArticulo = 0;
        private int _Stock;
        List<string>Imagen = new List<string>();
        /////////falta 3 mas
        ///
        public ClaseArticulo() { }

        public ClaseArticulo (string CodArticulo,string nombre,string descripcion,decimal precio,int idarticulo,int stock, List<string> imagen)
        {
             _CodArticulo = CodArticulo;
            _Nombre = nombre;
            _Descripcion= descripcion;
            _Precio = precio;
            _IDArticulo= idarticulo;
            _Stock = stock;
            Imagen = imagen;

        }


        public string CodArticulo
        {
            get { return _CodArticulo; }
            set { _CodArticulo = value; }
        }

        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        public string Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }

        public decimal Precio
        {
            get { return _Precio; }
            set { _Precio = value; }
        }

        public int IDArticulo
        {
            get { return _IDArticulo; }
            set { _IDArticulo = value; }
        }

        public int Stock
        {
            get { return _Stock; }
            set { _Stock = value; }
        }

        public List<string> imagen
        {
            get { return Imagen; }
            set { Imagen = value; }

        }

    }
}
