using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using CapaEntidad;
using System.Diagnostics;
using System.Data.Common;

namespace CapaDatos
{
    public class D_Empleados
    {
        SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["Connection"].ConnectionString);

     

        private readonly SqlConnection _connection;

        public D_Empleados()
        {
            _connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Connection"].ConnectionString);
        }


        public void D_AgregarEmpleado(string id, string nombre, string apellido, string correo, string contraseña)
        {
            using (SqlCommand cmd = new SqlCommand("sp_agregar_empleado", connect))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Apellido", apellido);
                cmd.Parameters.AddWithValue("@Correo", correo);
                cmd.Parameters.AddWithValue("@Contraseña", contraseña);
                cmd.Parameters.AddWithValue("@FechaRegistro", DateTime.Now);

                connect.Open();
                cmd.ExecuteNonQuery();
            }
            connect.Close();
        }
        public void D_AgregarInventario(string id, string nombre, decimal precio, string descripcionproducto, int cantidad)
        {
            using (SqlCommand cmd = new SqlCommand("sp_agregar_inventario", _connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SaleID", id);
                cmd.Parameters.AddWithValue("@ProductName", nombre);
                cmd.Parameters.AddWithValue("@Price", precio);
                cmd.Parameters.AddWithValue("@ProductDescropcion", descripcionproducto);
                cmd.Parameters.AddWithValue("@QuantityAvaible", cantidad);

                _connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void D_AgregarEmpleadoAdmin(string id, string nombre, string apellido, string correo, string contraseña)
        {
            using (SqlCommand cmd = new SqlCommand("sp_agregar_empleadoAdmin", connect))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Apellido", apellido);
                cmd.Parameters.AddWithValue("@Correo", correo);
                cmd.Parameters.AddWithValue("@Contraseña", contraseña);
                cmd.Parameters.AddWithValue("@FechaRegistro", DateTime.Now);

                connect.Open();
                cmd.ExecuteNonQuery();
            }
            connect.Close();
        }

        public void D_AgregarInventario(string id, string nombre, string precio, string descripcionproducto, string Cantidad)
        {
            connect.Open();
            using (SqlCommand cmd = new SqlCommand("sp_agregar_inventario", connect))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SaleID", id);
                cmd.Parameters.AddWithValue("@ProductName", nombre);
                cmd.Parameters.AddWithValue("@Price", precio);
                cmd.Parameters.AddWithValue("@ProductDescropcion", descripcionproducto);
                cmd.Parameters.AddWithValue("@QuantityAvaible", Cantidad);
               

                
                cmd.ExecuteNonQuery();
            }
            connect.Close();
        }

        public bool D_ExisteCorreo(string correo)
        {
            SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["Connection"].ConnectionString);
            {
                connect.Open();

                string query = "SELECT COUNT(*) FROM Admins WHERE MailAdmin = @Correo";

                using (SqlCommand command = new SqlCommand(query, connect))
                {
                    command.Parameters.AddWithValue("@Correo", correo);
                    int count = (int)command.ExecuteScalar();

                    return count > 0;
                }
                connect.Close();
            }
        }

        //si existe un producto

        public bool D_ExisteID(string id)
        {
            SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["Connection"].ConnectionString);
            {
                connect.Open();

                string query = "SELECT COUNT(*) FROM Admins WHERE IDAdmin = @ID";

                using (SqlCommand command = new SqlCommand(query, connect))
                {
                    command.Parameters.AddWithValue("@ID", id);
                    int count = (int)command.ExecuteScalar();

                    return count > 0;
                }
                connect.Close() ;
            }
        }

        public bool D_ExisteCorreoclient(string correo)
        {
            SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["Connection"].ConnectionString);
            {
                connect.Open();

                string query = "SELECT COUNT(*) FROM Clientes WHERE MailClient = @Correo";

                using (SqlCommand command = new SqlCommand(query, connect))
                {
                    command.Parameters.AddWithValue("@Correo", correo);
                    int count = (int)command.ExecuteScalar();

                    return count > 0;
                }
                connect.Close();
            }
        }

        public bool D_ExisteIDclient(string id)
        {
            SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["Connection"].ConnectionString);
            {
                connect.Open();

                string query = "SELECT COUNT(*) FROM Clientes WHERE IDClient = @ID";

                using (SqlCommand command = new SqlCommand(query, connect))
                {
                    command.Parameters.AddWithValue("@ID", id);
                    int count = (int)command.ExecuteScalar();

                    return count > 0;
                }
                connect.Close();
            }
        }

        public class D_Inventario
        {
            public Producto BuscarProductoEnBD(string terminoBusqueda)
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Connection"].ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Inventario WHERE ProductName LIKE @TerminoBusqueda";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TerminoBusqueda", "%" + terminoBusqueda + "%");
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            Producto producto = new Producto
                            {
                                ProductName = reader["ProductName"].ToString(),
                                Price = Convert.ToDecimal(reader["Price"]),
                                QuantityAvaible = Convert.ToInt32(reader["QuantityAvailable"]),
                                ProductDescription = reader["ProductDescription"].ToString(),
                            };

                            return producto;
                        }
                    }
                }

                return null; // Producto no encontrado
            }
        }

        public void D_ActualizarStockProducto(string id, string cantidad)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Connection"].ConnectionString))
            {
                connection.Open();
                string query = "UPDATE Inventario SET QuantityAvailable = QuantityAvailable - @Cantidad WHERE SaleID = @ID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", id);
                    command.Parameters.AddWithValue("@Cantidad", cantidad);
                    command.ExecuteNonQuery();
                }
            }
        }


        public bool VerificarExistenciaProducto(string id)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Connection"].ConnectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM Inventario WHERE SaleID = @ID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", id);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        public int ObtenerStockActualProducto(string idProducto)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Connection"].ConnectionString))
            {
                connection.Open();
                string query = "SELECT QuantityAvailable FROM Inventario WHERE SaleID = @ID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", idProducto);
                    int stockActual = Convert.ToInt32(command.ExecuteScalar());
                    return stockActual;
                }
            }
        }

 

        public void ActualizarProductomodify(string idProducto, string nuevoPrecio, string nuevaDescripcion, string nuevaCantidad)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Connection"].ConnectionString))
            {
                connection.Open();
                string query = "UPDATE Inventario SET Price = @Price, ProductDescription = @Description, QuantityAvailable = @Cantidad WHERE SaleID = @ID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Price", decimal.Parse(nuevoPrecio));
                    command.Parameters.AddWithValue("@Description", nuevaDescripcion);
                    command.Parameters.AddWithValue("@Cantidad", int.Parse(nuevaCantidad));
                    command.Parameters.AddWithValue("@ID", idProducto);
                    command.ExecuteNonQuery();
                }
            }
        }

        public Producto ObtenerProductoPorID(string idProducto)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Connection"].ConnectionString))
            {
                connection.Open();
                string query = "SELECT SaleID, ProductName, Price, ProductDescription FROM Inventario WHERE SaleID = @ID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", idProducto);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Producto producto = new Producto
                            {
                                SaleID = Convert.ToInt32(reader["SaleID"]),
                                ProductName = reader["ProductName"].ToString(),
                                Price = Convert.ToDecimal(reader["Price"]),
                                ProductDescription = reader["ProductDescription"].ToString()
                            };
                            return producto;
                        }
                        else
                        {
                            return null; 
                        }
                    }
                }
            }
        }

        public DataTable ObtenerDatosInventario()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Connection"].ConnectionString))
            {
                connection.Open();
                string query = "SELECT SaleID, ProductName, QuantityAvailable, Price, ProductDescription FROM Inventario";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }

            return dataTable;
        }



    }
}