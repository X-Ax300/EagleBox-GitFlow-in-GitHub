using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace CapaPresentacion.Forms
{
    public partial class FormReportInventario : Form
    {
        N_Empleados objdato = new N_Empleados();
        public FormReportInventario()
        {
            InitializeComponent();
        }



        private void FormReportInventario_Load(object sender, EventArgs e)
        {
            CargarDatosInventario();
        }
        private void CargarDatosInventario()
        {
            DataTable dtInventario = objdato.N_ObtenerDatosInventario();

            
            dataGridView1.DataSource = dtInventario;


            
            chart1.DataSource = dtInventario;
            chart1.Series["Inventario"].XValueMember = "ProductName";
            chart1.Series["Inventario"].YValueMembers = "QuantityAvailable";

           
            chart2.DataSource = dtInventario;
            chart2.Series["Precio"].XValueMember = "ProductName";
            chart2.Series["Precio"].YValueMembers = "Price";

            
            chart3.DataSource = dtInventario;
            chart3.Series["Inventario"].XValueMember = "ProductName";
            chart3.Series["Inventario"].YValueMembers = "QuantityAvailable";

            
            chart4.DataSource = dtInventario;
            chart4.Series["Series1"].XValueMember = "ProductName";
            chart4.Series["Series1"].YValueMembers = "QuantityAvailable";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }

        private void chart3_Click(object sender, EventArgs e)
        {

        }

        private void chart4_Click(object sender, EventArgs e)
        {

        }

        private void Stock_count_label_Click(object sender, EventArgs e)
        {
            int totalStock = 0;

            DataTable dtInventario = objdato.N_ObtenerDatosInventario();

            foreach (DataRow row in dtInventario.Rows)
            {
                int quantityAvailable = Convert.ToInt32(row["QuantityAvailable"]);
                totalStock += quantityAvailable;
            }

            Stock_count_label.Text = "Total de Stock: " + totalStock.ToString();
        }

        private void Label_Count_low_Click(object sender, EventArgs e)
        {
            int minQuantity = int.MaxValue;
            string productName = "";

            DataTable dtInventario = objdato.N_ObtenerDatosInventario();

            foreach (DataRow row in dtInventario.Rows)
            {
                int quantityAvailable = Convert.ToInt32(row["QuantityAvailable"]);
                if (quantityAvailable < minQuantity)
                {
                    minQuantity = quantityAvailable;
                    productName = row["ProductName"].ToString();
                }
            }

            Label_Count_low.Text = "Producto con menos: " + productName + " (" + minQuantity + " unidades)";
        }

        private void Label_count_high_Click(object sender, EventArgs e)
        {
            int maxQuantity = int.MinValue;
            string productName = "";

            DataTable dtInventario = objdato.N_ObtenerDatosInventario();

            foreach (DataRow row in dtInventario.Rows)
            {
                int quantityAvailable = Convert.ToInt32(row["QuantityAvailable"]);
                if (quantityAvailable > maxQuantity)
                {
                    maxQuantity = quantityAvailable;
                    productName = row["ProductName"].ToString();
                }
            }

            Label_count_high.Text = "Producto con más: " + productName + " (" + maxQuantity + " unidades)";

        }

        private void label5_Click(object sender, EventArgs e)
        {
            decimal totalSum = 0;

            DataTable dtInventario = objdato.N_ObtenerDatosInventario();

            foreach (DataRow row in dtInventario.Rows)
            {
                decimal price = Convert.ToDecimal(row["Price"]);
                int quantity = Convert.ToInt32(row["QuantityAvailable"]);
                decimal totalValue = price * quantity;
                totalSum += totalValue;
            }

            label5.Text = "Suma total de valores: " + totalSum.ToString("C");
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
