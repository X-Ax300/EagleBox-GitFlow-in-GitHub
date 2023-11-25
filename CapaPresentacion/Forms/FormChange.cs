using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Forms
{
    public partial class FormChange : Form
    {
        N_Empleados objdato = new N_Empleados();
        public FormChange()
        {
            InitializeComponent();
            customizaDesing();
        }
        
        private void customizaDesing()
        {
            PanelTornillo.Visible = false;
            panel_tubos.Visible = false;
            panelotros_suministros.Visible = false;
        }

        private void hideSubMenu()
        {
            if (PanelTornillo.Visible == true)
                PanelTornillo.Visible = false;
            if (panel_tubos.Visible == true)
                panel_tubos.Visible = false;
            if (panelotros_suministros.Visible == true)
                panelotros_suministros.Visible = false;

        }
        private void showsubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubMenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }

        private void TextBox_precio_modify_TextChanged(object sender, EventArgs e)
        {

        }
        private void TextBox_precio_modify_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void iconButtontornillo_Click(object sender, EventArgs e)
        {
            showsubmenu(PanelTornillo);
        }

        private void Tubos_btn_Click(object sender, EventArgs e)
        {
            showsubmenu(panel_tubos);
        }

        private void iconButtonOtherSuministros_Click(object sender, EventArgs e)
        {
            showsubmenu(panelotros_suministros);
        }

        private void tornillos_phillips_btn_Click(object sender, EventArgs e)
        {
            string idProducto = "90872";
            Producto producto = objdato.N_ObtenerProductoPorID(idProducto);

            if (producto != null)
            {
                label_id_producto.Text = producto.SaleID.ToString();
                label_nombre_producto.Text = producto.ProductName;
                TextBox_precio_modify.Text = producto.Price.ToString("0.00");
                TextBox_Modify_Change.Text = producto.ProductDescription;

                int stockActual = objdato.N_ObtenerStockActualProducto(idProducto);
                TextBox_cantidad.Text = stockActual.ToString();
            }
            else
            {
                MessageBox.Show("No tenemos este producto registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Tornillos_plano_btn_Click(object sender, EventArgs e)
        {
            string idProducto = "10763";
            Producto producto = objdato.N_ObtenerProductoPorID(idProducto);

            if (producto != null)
            {
                label_id_producto.Text = producto.SaleID.ToString();
                label_nombre_producto.Text = producto.ProductName;
                TextBox_precio_modify.Text = producto.Price.ToString("0.00");
                TextBox_Modify_Change.Text = producto.ProductDescription;

                int stockActual = objdato.N_ObtenerStockActualProducto(idProducto);
                TextBox_cantidad.Text = stockActual.ToString();
            }
            else
            {
                MessageBox.Show("No tenemos este producto registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tornillo_hexagonal_btn_Click(object sender, EventArgs e)
        {
            string idProducto = "890123";
            Producto producto = objdato.N_ObtenerProductoPorID(idProducto);

            if (producto != null)
            {
                label_id_producto.Text = producto.SaleID.ToString();
                label_nombre_producto.Text = producto.ProductName;
                TextBox_precio_modify.Text = producto.Price.ToString("0.00");
                TextBox_Modify_Change.Text = producto.ProductDescription;

                int stockActual = objdato.N_ObtenerStockActualProducto(idProducto);
                TextBox_cantidad.Text = stockActual.ToString();
            }
            else
            {
                MessageBox.Show("No tenemos este producto registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tornillo_estrella_btn_Click(object sender, EventArgs e)
        {
            string idProducto = "98130";
            Producto producto = objdato.N_ObtenerProductoPorID(idProducto);

            if (producto != null)
            {
                label_id_producto.Text = producto.SaleID.ToString();
                label_nombre_producto.Text = producto.ProductName;
                TextBox_precio_modify.Text = producto.Price.ToString("0.00");
                TextBox_Modify_Change.Text = producto.ProductDescription;

                int stockActual = objdato.N_ObtenerStockActualProducto(idProducto);
                TextBox_cantidad.Text = stockActual.ToString();
            }
            else
            {
                MessageBox.Show("No tenemos este producto registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tornillo_Pozidriv_btn_Click(object sender, EventArgs e)
        {
            string idProducto = "81293";
            Producto producto = objdato.N_ObtenerProductoPorID(idProducto);

            if (producto != null)
            {
                label_id_producto.Text = producto.SaleID.ToString();
                label_nombre_producto.Text = producto.ProductName;
                TextBox_precio_modify.Text = producto.Price.ToString("0.00");
                TextBox_Modify_Change.Text = producto.ProductDescription;

                int stockActual = objdato.N_ObtenerStockActualProducto(idProducto);
                TextBox_cantidad.Text = stockActual.ToString();
            }
            else
            {
                MessageBox.Show("No tenemos este producto registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tornillo_bristol_btn_Click(object sender, EventArgs e)
        {
            string idProducto = "928132";
            Producto producto = objdato.N_ObtenerProductoPorID(idProducto);

            if (producto != null)
            {
                label_id_producto.Text = producto.SaleID.ToString();
                label_nombre_producto.Text = producto.ProductName;
                TextBox_precio_modify.Text = producto.Price.ToString("0.00");
                TextBox_Modify_Change.Text = producto.ProductDescription;

                int stockActual = objdato.N_ObtenerStockActualProducto(idProducto);
                TextBox_cantidad.Text = stockActual.ToString();
            }
            else
            {
                MessageBox.Show("No tenemos este producto registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tubos_drenaje_btn_Click(object sender, EventArgs e)
        {
            string idProducto = "193230";
            Producto producto = objdato.N_ObtenerProductoPorID(idProducto);

            if (producto != null)
            {
                label_id_producto.Text = producto.SaleID.ToString();
                label_nombre_producto.Text = producto.ProductName;
                TextBox_precio_modify.Text = producto.Price.ToString("0.00");
                TextBox_Modify_Change.Text = producto.ProductDescription;

                int stockActual = objdato.N_ObtenerStockActualProducto(idProducto);
                TextBox_cantidad.Text = stockActual.ToString();
            }
            else
            {
                MessageBox.Show("No tenemos este producto registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tubo_presion_btn_Click(object sender, EventArgs e)
        {
            string idProducto = "152721";
            Producto producto = objdato.N_ObtenerProductoPorID(idProducto);

            if (producto != null)
            {
                label_id_producto.Text = producto.SaleID.ToString();
                label_nombre_producto.Text = producto.ProductName;
                TextBox_precio_modify.Text = producto.Price.ToString("0.00");
                TextBox_Modify_Change.Text = producto.ProductDescription;

                int stockActual = objdato.N_ObtenerStockActualProducto(idProducto);
                TextBox_cantidad.Text = stockActual.ToString();
            }
            else
            {
                MessageBox.Show("No tenemos este producto registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tubosemi_presion_btn_Click(object sender, EventArgs e)
        {
            string idProducto = "193766";
            Producto producto = objdato.N_ObtenerProductoPorID(idProducto);

            if (producto != null)
            {
                label_id_producto.Text = producto.SaleID.ToString();
                label_nombre_producto.Text = producto.ProductName;
                TextBox_precio_modify.Text = producto.Price.ToString("0.00");
                TextBox_Modify_Change.Text = producto.ProductDescription;

                int stockActual = objdato.N_ObtenerStockActualProducto(idProducto);
                TextBox_cantidad.Text = stockActual.ToString();
            }
            else
            {
                MessageBox.Show("No tenemos este producto registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Pvc_sdr_26_btn_Click(object sender, EventArgs e)
        {
            string idProducto = "1937612";
            Producto producto = objdato.N_ObtenerProductoPorID(idProducto);

            if (producto != null)
            {
                label_id_producto.Text = producto.SaleID.ToString();
                label_nombre_producto.Text = producto.ProductName;
                TextBox_precio_modify.Text = producto.Price.ToString("0.00");
                TextBox_Modify_Change.Text = producto.ProductDescription;

                int stockActual = objdato.N_ObtenerStockActualProducto(idProducto);
                TextBox_cantidad.Text = stockActual.ToString();
            }
            else
            {
                MessageBox.Show("No tenemos este producto registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tubo_ppr_btn_Click(object sender, EventArgs e)
        {
            string idProducto = "1937613";
            Producto producto = objdato.N_ObtenerProductoPorID(idProducto);

            if (producto != null)
            {
                label_id_producto.Text = producto.SaleID.ToString();
                label_nombre_producto.Text = producto.ProductName;
                TextBox_precio_modify.Text = producto.Price.ToString();
                TextBox_Modify_Change.Text = producto.ProductDescription;

                int stockActual = objdato.N_ObtenerStockActualProducto(idProducto);
                TextBox_cantidad.Text = stockActual.ToString();
            }
            else
            {
                MessageBox.Show("No tenemos este producto registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tubo_flexible_acero_Click(object sender, EventArgs e)
        {
            string idProducto = "15727";

            Producto producto = objdato.N_ObtenerProductoPorID(idProducto);

            if (producto != null)
            {
                label_id_producto.Text = producto.SaleID.ToString();
                label_nombre_producto.Text = producto.ProductName;
                TextBox_precio_modify.Text = producto.Price.ToString("0.00");
                TextBox_Modify_Change.Text = producto.ProductDescription;

                int stockActual = objdato.N_ObtenerStockActualProducto(idProducto);
                TextBox_cantidad.Text = stockActual.ToString();
            }
            else
            {
                MessageBox.Show("No tenemos este producto registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Toma_corriente_btn_Click(object sender, EventArgs e)
        {
            string idProducto = "679312";

            Producto producto = objdato.N_ObtenerProductoPorID(idProducto);

            if (producto != null)
            {
                label_id_producto.Text = producto.SaleID.ToString();
                label_nombre_producto.Text = producto.ProductName;
                TextBox_precio_modify.Text = producto.Price.ToString("0.00");
                TextBox_Modify_Change.Text = producto.ProductDescription;

                int stockActual = objdato.N_ObtenerStockActualProducto(idProducto);
                TextBox_cantidad.Text = stockActual.ToString();
            }
            else
            {
                MessageBox.Show("No tenemos este producto registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Probador_corriente_6_12_v_btn_Click(object sender, EventArgs e)
        {
            string idProducto = "9842";

            Producto producto = objdato.N_ObtenerProductoPorID(idProducto);

            if (producto != null)
            {
                label_id_producto.Text = producto.SaleID.ToString();
                label_nombre_producto.Text = producto.ProductName;
                TextBox_precio_modify.Text = producto.Price.ToString("0.00");
                TextBox_Modify_Change.Text = producto.ProductDescription;

                int stockActual = objdato.N_ObtenerStockActualProducto(idProducto);
                TextBox_cantidad.Text = stockActual.ToString();
            }
            else
            {
                MessageBox.Show("No tenemos este producto registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cajaoctagonal_electrica_btn_Click(object sender, EventArgs e)
        {
            string idProducto = "680319";

            Producto producto = objdato.N_ObtenerProductoPorID(idProducto);

            if (producto != null)
            {
                label_id_producto.Text = producto.SaleID.ToString();
                label_nombre_producto.Text = producto.ProductName;
                TextBox_precio_modify.Text = producto.Price.ToString();
                TextBox_Modify_Change.Text = producto.ProductDescription;

                int stockActual = objdato.N_ObtenerStockActualProducto(idProducto);
                TextBox_cantidad.Text = stockActual.ToString();
            }
            else
            {
                MessageBox.Show("No tenemos este producto registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Alambre_dulce_btn_Click(object sender, EventArgs e)
        {
            string idProducto = "679183"; 

            Producto producto = objdato.N_ObtenerProductoPorID(idProducto);

            if (producto != null)
            {
                label_id_producto.Text = producto.SaleID.ToString();
                label_nombre_producto.Text = producto.ProductName;
                TextBox_precio_modify.Text = producto.Price.ToString("0.00");
                TextBox_Modify_Change.Text = producto.ProductDescription;

                int stockActual = objdato.N_ObtenerStockActualProducto(idProducto);
                TextBox_cantidad.Text = stockActual.ToString();
            }
            else
            {
                MessageBox.Show("No tenemos este producto registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Alambre_duplex_300v_btn_Click(object sender, EventArgs e)
        {
            string idProducto = "53182";


            Producto producto = objdato.N_ObtenerProductoPorID(idProducto);

            if (producto != null)
            {
                label_id_producto.Text = producto.SaleID.ToString();
                label_nombre_producto.Text = producto.ProductName;
                TextBox_precio_modify.Text = producto.Price.ToString("0.00");
                TextBox_Modify_Change.Text = producto.ProductDescription;

                int stockActual = objdato.N_ObtenerStockActualProducto(idProducto);
                TextBox_cantidad.Text = stockActual.ToString();
            }
            else
            {
                MessageBox.Show("No tenemos este producto registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Alambre_puas_250mts_Click(object sender, EventArgs e)
        {
            string idProducto = "91723";

            Producto producto = objdato.N_ObtenerProductoPorID(idProducto);

            if (producto != null)
            {
                label_id_producto.Text = producto.SaleID.ToString();
                label_nombre_producto.Text = producto.ProductName;
                TextBox_precio_modify.Text = producto.Price.ToString("0.00");
                TextBox_Modify_Change.Text = producto.ProductDescription;

                int stockActual = objdato.N_ObtenerStockActualProducto(idProducto);
                TextBox_cantidad.Text = stockActual.ToString();
            }
            else
            {
                MessageBox.Show("No tenemos este producto registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void Modify_BTN_inventario_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(label_id_producto.Text))
            {
                string nuevoPrecio = TextBox_precio_modify.Text;
                string nuevaDescripcion = TextBox_Modify_Change.Text.Trim();
                string nuevacantidad = TextBox_cantidad.Text;

                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas realizar los cambios?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    
                    objdato.N_ActualizarProductomodify(label_id_producto.Text, nuevoPrecio, nuevaDescripcion, nuevacantidad);

                    MessageBox.Show("Producto actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningún producto para modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormChange_Load(object sender, EventArgs e)
        {

        }

        private void TextBox_cantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelfondodeleteInventary_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}