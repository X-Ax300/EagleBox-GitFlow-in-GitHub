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
    public partial class FormInventarioMenuCliente : Form
    {
        public FormInventarioMenuCliente()
        {
            InitializeComponent();
            customizaDesing();
            this.MinimumSize = new Size(1386, 1017);
            this.MaximumSize = new Size(1386, 1017);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void customizaDesing()
        {
            paneladd_admin.Visible = false;
            panel_consulta_admin.Visible = false;
            panel_informe_admin.Visible = false;
            Panelopcionesavanzada.Visible = false;


        }

        private void hideSubMenu()
        {
            if (paneladd_admin.Visible == true)
                paneladd_admin.Visible = false;
            if (panel_consulta_admin.Visible == true)
                panel_consulta_admin.Visible = false;
            if (panel_informe_admin.Visible == true)
                panel_informe_admin.Visible = false;
            if (Panelopcionesavanzada.Visible == true)
                Panelopcionesavanzada.Visible = false;

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

        private Form activeForm = null;
        private void openchildform(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelchildForm.Controls.Add(childForm);
            panelchildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        public void ActualizarLabelBienvenida(string nombre)
        {
            Label_bienvenida.Text = $"Bienvenido/a, {nombre}";
        }
        private void FormInventarioMenuCliente_Load(object sender, EventArgs e)
        {

        }

        private void EditionRegister_btn_Click(object sender, EventArgs e)
        {
            showsubmenu(paneladd_admin);
        }

        private void iconButtonConsultar_admin_Click(object sender, EventArgs e)
        {
            showsubmenu(panel_consulta_admin);
        }

        private void iconButtonInforme_de_Datos_admin_Click(object sender, EventArgs e)
        {
            showsubmenu(panel_informe_admin);
        }

        private void iconButtonaddinventary_Click(object sender, EventArgs e)
        {
            openchildform(new Formaddinventario());
        }

        private void iconButtonsearch_admin_Click(object sender, EventArgs e)
        {
            openchildform(new FormSearchInventario());
        }

        private void Label_bienvenida_Click(object sender, EventArgs e)
        {

        }

        private void Opciones_avanzada_btn_Click(object sender, EventArgs e)
        {
            showsubmenu(Panelopcionesavanzada);
        }

        private void Panelopcionesavanzada_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButtonestadistica_admin_Click(object sender, EventArgs e)
        {
            openchildform(new FormReportInventario());
        }

        private void Logout_btn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de que deseas salir de sesión? ", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                this.Close();


                Login_Form login_Form = new Login_Form();
                login_Form.Show();

                MessageBox.Show("Cargando...", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Operación cancelada.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void panelchildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButtonLogo_Click(object sender, EventArgs e)
        {
            openchildform(new FormClock());
        }

        private void iconButtondeleteinventary_Click(object sender, EventArgs e)
        {
            openchildform(new FormDeleteInventario());
        }
    }
}
