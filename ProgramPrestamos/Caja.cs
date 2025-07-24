using System.Data;
using System.Data.SqlClient;

namespace ProgramPrestamos
{
    public partial class Caja : Form
    {
        private ConexionSQL conexionSQL;

        public Caja()
        {
            InitializeComponent();
            conexionSQL = new ConexionSQL();
            CargarEmpleados();
            btnAsignarDinero.Click += (s, e) => AsignarDinero(); // Suscribir el evento del botón
        }

        private void CargarEmpleados(bool mostrarDetalles = false)
        {
            try
            {
                using (var conexion = conexionSQL.ObtenerConexion())
                {
                    if (conexion == null) return;

                    string query = mostrarDetalles
                        ? @"
                            SELECT 
                                EmpleadoID AS ID,
                                Nombre AS Nombre,
                                DNI AS DNI,
                                SaldoCaja AS Saldo,
                                PorcentajeComision AS Comision,
                                Activo AS Estado,
                                FechaIngreso AS Ingreso
                            FROM Empleados
                            WHERE Activo = 1"
                        : @"
                            SELECT 
                                EmpleadoID AS ID,
                                Nombre AS Nombre,
                                SaldoCaja AS Saldo
                            FROM Empleados
                            WHERE Activo = 1";

                    SqlDataAdapter adaptador = new SqlDataAdapter(query, conexion);
                    DataTable tablaEmpleados = new DataTable();
                    adaptador.Fill(tablaEmpleados);

                    comboBoxEmpleados.DataSource = tablaEmpleados;
                    comboBoxEmpleados.DisplayMember = "Nombre";
                    comboBoxEmpleados.ValueMember = "ID";
                    // Asignar los datos al DataGridView
                    dataGridViewMovimientos.DataSource = tablaEmpleados;
                    dataGridViewMovimientos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar empleados: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AsignarDinero()
        {
            if (comboBoxEmpleados.SelectedItem != null && decimal.TryParse(txtDineroAsignado.Text, out decimal monto) && monto > 0)
            {
                int empleadoID = Convert.ToInt32(comboBoxEmpleados.SelectedValue);

                try
                {
                    using (var conexion = conexionSQL.ObtenerConexion())
                    {
                        if (conexion == null) return;

                        // Actualizar el saldo del empleado
                        string queryActualizarSaldo = @"
                            UPDATE Empleados
                            SET SaldoCaja = SaldoCaja + @Monto
                            WHERE EmpleadoID = @EmpleadoID";

                        SqlCommand comandoActualizarSaldo = new SqlCommand(queryActualizarSaldo, conexion);
                        comandoActualizarSaldo.Parameters.AddWithValue("@Monto", monto);
                        comandoActualizarSaldo.Parameters.AddWithValue("@EmpleadoID", empleadoID);
                        comandoActualizarSaldo.ExecuteNonQuery();

                        // Registrar el movimiento en MovimientosCaja
                        string queryRegistrarMovimiento = @"
                            INSERT INTO MovimientosCaja (EmpleadoID, TipoMovimiento, Monto, Descripcion, FechaMovimiento, SaldoAnterior, SaldoNuevo)
                            VALUES (@EmpleadoID, 'Entrada', @Monto, 'Ingreso manual', GETDATE(), 
                            (SELECT SaldoCaja FROM Empleados WHERE EmpleadoID = @EmpleadoID) - @Monto, 
                            (SELECT SaldoCaja FROM Empleados WHERE EmpleadoID = @EmpleadoID))";

                        SqlCommand comandoRegistrarMovimiento = new SqlCommand(queryRegistrarMovimiento, conexion);
                        comandoRegistrarMovimiento.Parameters.AddWithValue("@EmpleadoID", empleadoID);
                        comandoRegistrarMovimiento.Parameters.AddWithValue("@Monto", monto);
                        comandoRegistrarMovimiento.ExecuteNonQuery();

                        MessageBox.Show("Dinero asignado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Refrescar el DataGridView
                        CargarEmpleados();
                        txtDineroAsignado.Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al asignar dinero: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un empleado y un monto válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool mostrandoDetalles = false;

        private void btnVerDetalles_Click(object sender, EventArgs e)
        {
            if (mostrandoDetalles)
            {
                CargarEmpleados(mostrarDetalles: false); // Volver a la vista por defecto
                mostrandoDetalles = false;
            }
            else
            {
                CargarEmpleados(mostrarDetalles: true); // Mostrar los detalles
                mostrandoDetalles = true;
            }
        }

        private void CargarMovimientos()
        {
            try
            {
                using (var conexion = conexionSQL.ObtenerConexion())
                {
                    if (conexion == null) return;

                    // Consulta SQL para obtener los movimientos de caja con el nombre del empleado
                    string query = @"
                SELECT 
                    e.Nombre AS Empleado,
                    m.TipoMovimiento AS Tipo,
                    m.Monto,
                    m.Descripcion,
                    m.FechaMovimiento AS Fecha,
                    m.SaldoAnterior AS SaldoAnterior,
                    m.SaldoNuevo AS SaldoNuevo
                FROM MovimientosCaja m
                INNER JOIN Empleados e ON m.EmpleadoID = e.EmpleadoID
                ORDER BY m.FechaMovimiento DESC";

                    SqlDataAdapter adaptador = new SqlDataAdapter(query, conexion);
                    DataTable tablaMovimientos = new DataTable();
                    adaptador.Fill(tablaMovimientos);

                    // Asignar los datos al DataGridView
                    dataGridViewMovimientos.DataSource = tablaMovimientos;
                    dataGridViewMovimientos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar movimientos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool mostrandoMovimientos = false;

        private void btnVerMovimientos_Click(object sender, EventArgs e)
        {
            if (mostrandoMovimientos)
            {
                CargarEmpleados(); // Volver a la vista de empleados
                mostrandoMovimientos = false;
            }
            else
            {
                CargarMovimientos(); // Mostrar los movimientos
                mostrandoMovimientos = true;
            }
        }
    }
}