using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;
using System.Data;
using static CapaDatos.D_Empleados;
using System.Data.SqlClient;

namespace CapaNegocio
{
    public class N_Empleados
    {
        D_Empleados objdato = new D_Empleados();



        public void N_AgregarEmpleado(string id, string nombre, string apellido, string correo, string contraseña)
        {
            objdato.D_AgregarEmpleado(id, nombre, apellido, correo, contraseña);
        }

        public void N_AgregarEmpleadoAdmin(string id, string nombre, string apellido, string correo, string contraseña)
        {
            objdato.D_AgregarEmpleadoAdmin(id, nombre, apellido, correo, contraseña);
        }

        public void N_AgregarInventario(string id, string nombre, string precio, string descripcionproducto, string Cantidad)
        {
            objdato.D_AgregarInventario(id, nombre, precio, descripcionproducto, Cantidad);
        }
        public bool N_ExisteCorreo(string correo)
        {
           return objdato.D_ExisteCorreo(correo);
        }

        public bool N_ExistID(string id)
        {
           return objdato.D_ExisteID(id);
        }

        public bool N_ExisteCorreoClient(string correo)
        {
            return objdato.D_ExisteCorreoclient(correo);
        }

        public bool N_ExistIDClient(string id)
        {
            return objdato.D_ExisteIDclient(id);
        }

        D_Inventario objDatos = new D_Inventario(); 

        public Producto N_BuscarProductoEnBD(string terminoBusqueda)
        {
            return objDatos.BuscarProductoEnBD(terminoBusqueda);
        }

        public void N_ActualizarStockProducto(string id, string cantidad)
        {
            objdato.D_ActualizarStockProducto(id, cantidad);
        }

        public bool N_VerificarExistenciaProducto(string id)
        {
            return objdato.VerificarExistenciaProducto(id);
        }

        public int N_ObtenerStockActualProducto(string idproduct)
        {
           return objdato.ObtenerStockActualProducto(idproduct);
        }

        public void N_ActualizarProductomodify(string idProducto, string nuevoPrecio, string nuevaDescripcion, string nuevaCantidad)
        {
            objdato.ActualizarProductomodify(idProducto, nuevoPrecio, nuevaDescripcion, nuevaCantidad);
        }

        public Producto N_ObtenerProductoPorID(string idProducto)
        {
            return objdato.ObtenerProductoPorID(idProducto);
        }


        public DataTable N_ObtenerDatosInventario()
        {
            return objdato.ObtenerDatosInventario();
        }
    }


    
}