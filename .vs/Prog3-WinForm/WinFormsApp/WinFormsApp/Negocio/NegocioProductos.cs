using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp.Entidades;
using Dao;
using System.Data;
using System.Data.SqlClient;
using WinFormsApp.DAO;

namespace WinFormsApp.Negocio
{
    internal class NegocioProductos
    {
        DaoProductos dao = new DaoProductos();
        public bool ActualizarProducto(Producto prod)
        {
            return dao.ActualizarProducto(prod);
        }

        public bool EliminarProducto(Producto prod)
        {
            return dao.EliminarProducto(prod);
        }

        public DataTable obtenerTablaProductosInicio(string nombreProducto = null)
        {
            return dao.obtenerTablaProductosInicio(nombreProducto);
        }

        public DataTable obtenerTablaProductos(string nombreProducto = null)
        {
            return dao.obtenerTablaProductos(nombreProducto);
        }

        public bool AgregarProducto(Producto prod)
        {
            return dao.AgregarProducto(prod);
        }

        public Producto obtenerProducto(int id)
        {
            return dao.obtenerProducto(id);
        }
    }
}
