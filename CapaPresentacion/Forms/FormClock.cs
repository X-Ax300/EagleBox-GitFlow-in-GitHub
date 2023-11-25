using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Forms
{
    public partial class FormClock : Form
    {
        public FormClock()
        {
            InitializeComponent();
            panelBackground.Paint += new PaintEventHandler(panelfondodeleteInventary_Paint);
        }

        private void panelfondodeleteInventary_Paint(object sender, PaintEventArgs e)
        {
            using (var brush = new LinearGradientBrush(panelBackground.ClientRectangle, Color.FromArgb(24, 63, 111), Color.FromArgb(0, 0, 0), LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(brush, panelBackground.ClientRectangle);
            }
        }

        private void Clock_Load(object sender, EventArgs e)
        {

        }

        private void panelBackground_Paint(object sender, PaintEventArgs e)
        {

        }

        private void hourdate_Tick(object sender, EventArgs e)
        {
            Lbl_Hour.Text= DateTime.Now.ToLongTimeString();
            LBL_fecha.Text= DateTime.Now.ToLongDateString();
        }

        private void Lbl_Hour_Click(object sender, EventArgs e)
        {

        }


        private void LBL_fecha_Click(object sender, EventArgs e)
        {

        }
    }
}
