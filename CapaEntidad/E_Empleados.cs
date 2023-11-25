using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class E_Empleados
    {
        public int IDAdmin { get; set; }
        public int NameAdmin { get; set; }
        public int SurName { get; set; }
        public int MailAdmin { get; set; }
        public int PasswordAdmin { get; set; }
        public int RegisterDateAdmin { get; set; }
    }

    public class DatosClients
    {
        public int IDClient { get; set; }
        public int NameClient { get; set; }
        public int SurNameClient { get; set; }
        public int MailNameClient { get; set; }
        public int PasswordClient { get; set; }
        public DateTime RegisterDateClient { get; set; }
    }
    public class DatosVentas
    {
        public int SaleID { get; set; }
        public string ProductName { get; set; }
        public int quantitySold { get; set; }
        public DateTime SaleDate { get; set; }
        public string PricePerUnit { get; set; }
    }
    public class DatosInventarios
    {
        public int SaleID { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
        public string ProductDescription { get; set; }
        public int QuantityAvaible { get; set; }
    }

    public class Producto
    {
        public int SaleID { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public string ProductDescription { get; set; }
        public int QuantityAvaible { get; set; }
    }
}