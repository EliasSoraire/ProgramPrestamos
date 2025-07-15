using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramPrestamos
{
    public partial class NuevoPrestamo : Form
    {
        public NuevoPrestamo()
        {
            InitializeComponent();
        }

        private void rbPrestamoEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPrestamoEfectivo.Checked)
            {
                panelPrestamoEfectivo.Visible = true;
                panelPrestamoProducto.Visible = false;
            }
        }

        private void rbPrestamoProducto_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPrestamoProducto.Checked)
            {
                panelPrestamoEfectivo.Visible = false;
                panelPrestamoProducto.Visible = true;
            }
        }
    }
}