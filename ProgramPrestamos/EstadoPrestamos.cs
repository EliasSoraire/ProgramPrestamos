using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProgramPrestamos
{
    public partial class EstadoPrestamos : Form
    {
        public EstadoPrestamos()
        {
            InitializeComponent();
            ConfigurarFiltros();
            
            // Se actualiza al inicio
            ActualizarYRecargarDatos(); 
            
            dataGridViewPrestamos.CellFormatting += DataGridViewPrestamos_CellFormatting;
            
            // Agregamos un evento para detectar cuando el formulario vuelve a tener el foco
            this.Activated += (s, e) => ActualizarYRecargarDatos();
        }

        // Nuevo método centralizado para actualizar y recargar
        private void ActualizarYRecargarDatos()
        {
            ActualizarRecargosEnBD();
            CargarPrestamos();
        }

        private void ConfigurarFiltros()
        {
            CargarEmpleadosFiltro();

            if (cmbTipoPrestamo.Items.Count > 0) cmbTipoPrestamo.SelectedIndex = 0;
            if (cmbEstado.Items.Count > 0) cmbEstado.SelectedIndex = 0;

            // Los filtros ahora llaman directamente a CargarPrestamos, lo cual es correcto
            cmbEmpleado.SelectedIndexChanged += (s, e) => CargarPrestamos();
            cmbTipoPrestamo.SelectedIndexChanged += (s, e) => CargarPrestamos();
            cmbEstado.SelectedIndexChanged += (s, e) => CargarPrestamos();
            btnLimpiarFiltros.Click += (s, e) => LimpiarFiltros();
        }

        private void CargarEmpleadosFiltro()
        {
            try
            {
                using (var conexion = new ConexionSQL().ObtenerConexion())
                {
                    if (conexion == null) return;
                    string query = "SELECT EmpleadoID, Nombre FROM Empleados WHERE Activo = 1 ORDER BY Nombre";
                    SqlDataAdapter adaptador = new SqlDataAdapter(query, conexion);
                    DataTable dtEmpleados = new DataTable();
                    adaptador.Fill(dtEmpleados);

                    DataRow dr = dtEmpleados.NewRow();
                    dr["Nombre"] = "Todos";
                    dr["EmpleadoID"] = 0;
                    dtEmpleados.Rows.InsertAt(dr, 0);

                    cmbEmpleado.DataSource = dtEmpleados;
                    cmbEmpleado.DisplayMember = "Nombre";
                    cmbEmpleado.ValueMember = "EmpleadoID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar filtro de empleados: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void LimpiarFiltros()
        {
            cmbEmpleado.SelectedIndex = 0;
            cmbTipoPrestamo.SelectedIndex = 0;
            cmbEstado.SelectedIndex = 0;
            // Al limpiar filtros, también actualizamos todo
            ActualizarYRecargarDatos();
        }

        private void ActualizarRecargosEnBD()
        {
            try
            {
                using (var conexion = new ConexionSQL().ObtenerConexion())
                {
                    if (conexion == null) return;
                    using (var comando = new SqlCommand("ActualizarRecargos", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al actualizar recargos: {ex.Message}");
            }
        }

        private void CargarPrestamos()
        {
            try
            {
                using (var conexion = new ConexionSQL().ObtenerConexion())
                {
                    if (conexion == null) return;

                    var sbQuery = new StringBuilder(@"
                        SELECT 
                            p.PrestamoID AS Codigo,
                            p.TipoPrestamo AS Tipo,
                            c.Nombre AS Cliente,
                            e.Nombre AS Empleado,
                            p.MontoTotal,
                            p.SaldoPendiente,
                            CASE 
                                WHEN p.SaldoPendiente <= 0 THEN 'Pagado'
                                WHEN GETDATE() > p.FechaVencimiento THEN 'Vencido'
                                ELSE 'Activo'
                            END AS Estado,
                            ISNULL((SELECT SUM(Recargo) FROM Cuotas WHERE PrestamoID = p.PrestamoID), 0) AS Recargo
                        FROM Prestamos p
                        INNER JOIN Clientes c ON p.ClienteID = c.ClienteID
                        INNER JOIN Empleados e ON p.EmpleadoID = e.EmpleadoID
                        WHERE 1=1");

                    var comando = new SqlCommand();

                    // Aplicar filtros
                    if (cmbEmpleado.SelectedIndex > 0)
                    {
                        sbQuery.Append(" AND p.EmpleadoID = @EmpleadoID");
                        comando.Parameters.AddWithValue("@EmpleadoID", cmbEmpleado.SelectedValue);
                    }
                    if (cmbTipoPrestamo.SelectedIndex > 0)
                    {
                        sbQuery.Append(" AND p.TipoPrestamo = @TipoPrestamo");
                        comando.Parameters.AddWithValue("@TipoPrestamo", cmbTipoPrestamo.SelectedItem.ToString());
                    }
                    if (cmbEstado.SelectedIndex > 0)
                    {
                        string estadoSeleccionado = cmbEstado.SelectedItem.ToString();
                        string condicionEstado = "";
                        if (estadoSeleccionado == "Pagado") condicionEstado = "p.SaldoPendiente <= 0";
                        else if (estadoSeleccionado == "Vencido") condicionEstado = "GETDATE() > p.FechaVencimiento AND p.SaldoPendiente > 0";
                        else if (estadoSeleccionado == "Activo") condicionEstado = "GETDATE() <= p.FechaVencimiento AND p.SaldoPendiente > 0";
                        
                        if (!string.IsNullOrEmpty(condicionEstado))
                        {
                            sbQuery.Append($" AND ({condicionEstado})");
                        }
                    }

                    comando.CommandText = sbQuery.ToString();
                    comando.Connection = conexion;

                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    DataTable tablaPrestamos = new DataTable();
                    adaptador.Fill(tablaPrestamos);

                    dataGridViewPrestamos.DataSource = tablaPrestamos;
                    dataGridViewPrestamos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar préstamos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void DataGridViewPrestamos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            if (dataGridViewPrestamos.Columns[e.ColumnIndex].Name.Equals("Estado", StringComparison.OrdinalIgnoreCase))
            {
                if (e.Value != null)
                {
                    string estado = e.Value.ToString();
                    Color colorFondo = Color.White; // Color por defecto

                    if (estado.Equals("Pagado", StringComparison.OrdinalIgnoreCase))
                        colorFondo = Color.FromArgb(223, 240, 216); // Verde suave
                    else if (estado.Equals("Vencido", StringComparison.OrdinalIgnoreCase))
                        colorFondo = Color.FromArgb(252, 228, 228); // Rojo suave
                    else if (estado.Equals("Activo", StringComparison.OrdinalIgnoreCase))
                        colorFondo = Color.FromArgb(217, 237, 247); // Azul suave
                    
                    e.CellStyle.BackColor = colorFondo;
                    e.CellStyle.ForeColor = Color.Black;
                }
            }
        }
    }
}