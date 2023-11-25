using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Forms
{
    public partial class FormRegisUsu : Form
    {
        public FormRegisUsu()
        {
            InitializeComponent();
            Fondo_Register_Panel.Paint += new PaintEventHandler(Fondo_Register_form_Paint);
            Mailclient_Register_TBox.TextChanged += TextBoxEmail_TextChanged;
            
            this.Size = new Size(441, 804);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["Connection"].ConnectionString);

        E_Empleados ObjEntidad = new E_Empleados();
        N_Empleados ObjNegocio = new N_Empleados();

        private void Fondo_Register_form_Paint(object sender, PaintEventArgs e)
        {
            using (var brush = new LinearGradientBrush(Fondo_Register_Panel.ClientRectangle, Color.FromArgb(69, 104, 220), Color.FromArgb(208, 78, 214), LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(brush, Fondo_Register_Panel.ClientRectangle);
            }
        }

        private void Register_button_acceptar_Click(object sender, EventArgs e)
        {

            string id = IDclient_Register_TBox.Text;
            string nombre = Nameclient_Register_TBox.Text;
            string apellido = Surnameclient_Register_TBox.Text;
            string correo = Mailclient_Register_TBox.Text;
            string contraseña = Passwordclient_Register_TBox.Text;

           
            if (ObjNegocio.N_ExisteCorreoClient(correo))
            {
                MessageBox.Show("El correo electrónico ya existe. Por favor, ingrese otro correo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (ObjNegocio.N_ExistIDClient(id))
            {
                MessageBox.Show("El ID ya existe. Por favor, ingrese otro ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (ObjNegocio.N_ExisteCorreo(correo))
            {
                MessageBox.Show("El correo electrónico ya existe. Por favor, ingrese otro correo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (ObjNegocio.N_ExistID(id))
            {
                MessageBox.Show("El ID ya existe. Por favor, ingrese otro ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
            else
            {

                DialogResult result = MessageBox.Show("¿Deseas guardar el usuario?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    ObjNegocio.N_AgregarEmpleado(id, nombre, apellido, correo, contraseña);

                    MessageBox.Show("Usuario agregado satisfactoriamente.");
                }
                else
                {
                    MessageBox.Show("Operacion cancelada.");
                }
            }
        }

        private void Fondo_Register_Panel_Paint(object sender, PaintEventArgs e)
        {
            using (var brush = new LinearGradientBrush(Fondo_Register_Panel.ClientRectangle, Color.FromArgb(69, 104, 220), Color.FromArgb(208, 78, 214), LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(brush, Fondo_Register_Panel.ClientRectangle);
            }
        }

        private void Back_button_register_Click(object sender, EventArgs e)
        {
            Login_Form login_Form = new Login_Form();
            login_Form.Show();
            FormRegisUsu formRegisUsu = new FormRegisUsu();
            formRegisUsu.Close();
        }

        private void TextBoxEmail_TextChanged(object sender, EventArgs e)
        {
            string email = Mailclient_Register_TBox.Text;

            if (email.EndsWith("@gmail.com") || email.EndsWith("@hotmail.com"))
            {
                labelverificarmail.Text = ""; 
            }
            else
            {
                labelverificarmail.Text = "El correo debe terminar en @gmail.com o @hotmail.com";
            }
        }

        private void IDclient_Register_TBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Nameclient_Register_TBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Surnameclient_Register_TBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Mailclient_Register_TBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Passwordclient_Register_TBox_TextChanged(object sender, EventArgs e)
        {

        }


    }
}