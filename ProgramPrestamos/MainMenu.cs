namespace ProgramPrestamos
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            var clientesForm = new Clientes();
            clientesForm.ShowDialog();
        }

        private void BtnEmpleados_Click(object sender, EventArgs e)
        {
            var empleadosForm = new Empleados();
            empleadosForm.ShowDialog();
        }

        private void BtnEstados_Click(object sender, EventArgs e)
        {
            var estadosForm = new EstadoPrestamos();
            estadosForm.ShowDialog();
        }

        private void BtnNuevoPrestamo_Click(object sender, EventArgs e)
        {
            var nuevoPrestamoForm = new NuevoPrestamo();
            nuevoPrestamoForm.ShowDialog();
        }

        private void BtnProductos_Click(object sender, EventArgs e)
        {
            var productosForm = new Productos();
            productosForm.ShowDialog();
        }

        private void BtnCaja_Click(object sender, EventArgs e)
        {
            var cajaForm = new Caja();
            cajaForm.ShowDialog();
        }

        private void BtnResumen_Click(object sender, EventArgs e)
        {
            var resumenForm = new Resumen();
            resumenForm.ShowDialog();
        }
    }
}