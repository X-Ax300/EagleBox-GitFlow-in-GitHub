using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Forms;

namespace CapaPresentacion
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
            Fondo_login_form.Paint += new PaintEventHandler(panel1_Paint);

            this.Size = new Size(441, 804);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        E_Empleados objEntidad = new E_Empleados();
        N_Empleados objNegocio = new N_Empleados();
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

            using (var brush = new LinearGradientBrush(Fondo_login_form.ClientRectangle, Color.FromArgb(69, 104, 220), Color.FromArgb(208, 78, 214), LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(brush, Fondo_login_form.ClientRectangle);
            }
        }

        private void Fondo_login_form_Paint(object sender, PaintEventArgs e)
        {

            using (var brush = new LinearGradientBrush(Fondo_login_form.ClientRectangle, Color.FromArgb(69, 104, 220), Color.FromArgb(208, 78, 214), LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(brush, Fondo_login_form.ClientRectangle);
            }
        }

        private void iconButton_register_Login_Click(object sender, EventArgs e)
        {
            FormRegisUsu formRegisUsu = new FormRegisUsu();
            formRegisUsu.Show();
            Login_Form loginForm = new Login_Form();
            loginForm.Close();
        }

        private void iconButton_Login_Click(object sender, EventArgs e)
        {
            string correo = text_box_user.Text;
            string contraseña = alphaBlendTextBox_Password.Text;

           
            bool esCliente = VerificarCredencialesCliente(correo, contraseña);

           
            bool esAdministrador = VerificarCredencialesAdministrador(correo, contraseña);

            if (esCliente)
            {
                string nombreCliente = ObtenerNombreCliente(correo); 
               
                FormInventarioMenuCliente clienteForm = new FormInventarioMenuCliente();
                clienteForm.ActualizarLabelBienvenida(nombreCliente);
                clienteForm.Show();
                this.Hide();
            }
            else if (esAdministrador)
            {
                string nombreAdmin = ObtenerNombreAdministrador(correo); 
                FormInventarioMenu adminForm = new FormInventarioMenu();
                adminForm.ActualizarLabelBienvenida(nombreAdmin);
                adminForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas. Por favor, verifica tu correo y contraseña.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool VerificarCredencialesCliente(string correo, string contraseña)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Connection"].ConnectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM Clientes WHERE MailClient = @Correo AND PasswordClient = @Contraseña";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Correo", correo);
                    command.Parameters.AddWithValue("@Contraseña", contraseña);
                    int count = Convert.ToInt32(command.ExecuteScalar());

                    return count > 0;
                }

            }

        }
        public bool VerificarCredencialesAdministrador(string correo, string contraseña)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Connection"].ConnectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM Admins WHERE MailAdmin = @Correo AND PasswordAdmin = @Contraseña";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Correo", correo);
                    command.Parameters.AddWithValue("@Contraseña", contraseña);
                    int count = Convert.ToInt32(command.ExecuteScalar());

                    return count > 0;
                }

            }
        }


        private string ObtenerNombreCliente(string correo)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Connection"].ConnectionString))
            {
                connection.Open();
                string query = "SELECT NameClient FROM Clientes WHERE MailClient = @Correo";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Correo", correo);
                    return command.ExecuteScalar()?.ToString();
                }
            }
        }


        private string ObtenerNombreAdministrador(string correo)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Connection"].ConnectionString))
            {
                connection.Open();
                string query = "SELECT NameAdmin FROM Admins WHERE MailAdmin = @Correo";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Correo", correo);
                    return command.ExecuteScalar()?.ToString();
                }
            }
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
