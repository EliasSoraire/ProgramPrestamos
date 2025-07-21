using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramPrestamos
{
    public partial class Comisiones : Form
    {
        private ConexionSQL conexionSQL;
        private DataTable dtEmpleados;
        private DataTable dtPrestamosPendientes;

        public Comisiones()
        {
            InitializeComponent();
            conexionSQL = new ConexionSQL();
        }

        private void Comisiones_Load(object sender, EventArgs e)
        {
            CargarEmpleados();
            ConfigurarDataGridView();
        }

        private void ConfigurarDataGridView()
        {
            dgvPrestamosPendientes.AutoGenerateColumns = false;
            dgvPrestamosPendientes.Columns.Clear();

            // Configurar columnas del DataGridView
            dgvPrestamosPendientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "PrestamoID",
                HeaderText = "ID Préstamo",
                DataPropertyName = "PrestamoID",
                Width = 80
            });

            dgvPrestamosPendientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Cliente",
                HeaderText = "Cliente",
                DataPropertyName = "Cliente",
                Width = 200
            });

            dgvPrestamosPendientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TipoPrestamo",
                HeaderText = "Tipo",
                DataPropertyName = "TipoPrestamo",
                Width = 100
            });

            dgvPrestamosPendientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "FechaPrestamo",
                HeaderText = "Fecha Préstamo",
                DataPropertyName = "FechaPrestamo",
                Width = 120,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" }
            });

            dgvPrestamosPendientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "MontoTotal",
                HeaderText = "Monto Total",
                DataPropertyName = "MontoTotal",
                Width = 120,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" }
            });

            dgvPrestamosPendientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TotalPagado",
                HeaderText = "Total Pagado",
                DataPropertyName = "TotalPagado",
                Width = 120,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" }
            });

            dgvPrestamosPendientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ComisionCalculada",
                HeaderText = "Comisión",
                DataPropertyName = "ComisionCalculada",
                Width = 120,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" }
            });

            dgvPrestamosPendientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "EstadoPrestamo",
                HeaderText = "Estado Préstamo",
                DataPropertyName = "EstadoPrestamo",
                Width = 120
            });
        }

        private void CargarEmpleados()
        {
            try
            {
                using (SqlConnection conexion = conexionSQL.ObtenerConexion())
                {
                    if (conexion != null)
                    {
                        string query = @"SELECT EmpleadoID, Nombre, DNI, ISNULL(PorcentajeComision, 10.0) as PorcentajeComision
                                FROM Empleados
                                WHERE Activo = 1
                               ORDER BY Nombre";

                        SqlDataAdapter adapter = new SqlDataAdapter(query, conexion);
                        dtEmpleados = new DataTable();
                        adapter.Fill(dtEmpleados);

                        // Configurar ComboBox
                        cmbEmpleados.Items.Clear();
                        cmbEmpleados.DisplayMember = "Display";
                        cmbEmpleados.ValueMember = "EmpleadoID";

                        // Agregar opción por defecto
                        cmbEmpleados.Items.Add(new { EmpleadoID = 0, Display = "Seleccione un empleado..." });

                        // Cargar empleados
                        foreach (DataRow row in dtEmpleados.Rows)
                        {
                            cmbEmpleados.Items.Add(new
                            {
                                EmpleadoID = Convert.ToInt32(row["EmpleadoID"]),
                                Display = $"{row["Nombre"]} - DNI: {row["DNI"]}",
                                PorcentajeComision = Convert.ToDecimal(row["PorcentajeComision"])
                            });
                        }

                        cmbEmpleados.SelectedIndex = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar empleados: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEmpleados.SelectedIndex > 0)
            {
                dynamic selectedEmpleado = cmbEmpleados.SelectedItem;
                if (selectedEmpleado != null && selectedEmpleado.PorcentajeComision != null)
                {
                    decimal porcentaje = selectedEmpleado.PorcentajeComision;
                    numericUpDownPorcentajeEfectivo.Value = porcentaje;
                    numericUpDownPorcentajeProductos.Value = porcentaje;

                    // Cargar solo préstamos con comisiones pendientes
                    CargarPrestamosPendientes(selectedEmpleado.EmpleadoID);
                }
            }
            else
            {
                // Limpiar resultados si no hay empleado seleccionado
                LimpiarResultados();
            }
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            // Recalcular comisiones cuando cambie el porcentaje
            if (cmbEmpleados.SelectedIndex > 0)
            {
                dynamic selectedEmpleado = cmbEmpleados.SelectedItem;
                CargarPrestamosPendientes(selectedEmpleado.EmpleadoID);
            }
        }

        private void CargarPrestamosPendientes(int empleadoId)
        {
            try
            {
                using (SqlConnection conexion = conexionSQL.ObtenerConexion())
                {
                    if (conexion != null)
                    {
                        // Consulta que muestra SOLO préstamos con comisiones NO pagadas
                        string query = @"
                            SELECT 
                                p.PrestamoID,
                                c.Nombre as Cliente,
                                p.TipoPrestamo,
                                p.FechaPrestamo,
                                p.MontoTotal,
                                ISNULL(SUM(pg.MontoPago), 0) as TotalPagado,
                                CASE 
                                    WHEN p.TipoPrestamo = 'Efectivo' THEN 
                                        ISNULL(SUM(pg.MontoPago), 0) * (@PorcentajeEfectivo / 100.0)
                                    ELSE 
                                        ISNULL(SUM(pg.MontoPago), 0) * (@PorcentajeProductos / 100.0)
                                END as ComisionCalculada,
                                p.Estado as EstadoPrestamo
                            FROM Prestamos p
                            INNER JOIN Clientes c ON p.ClienteID = c.ClienteID
                            LEFT JOIN Pagos pg ON p.PrestamoID = pg.PrestamoID
                            WHERE p.EmpleadoID = @EmpleadoID 
                            AND NOT EXISTS (
                                SELECT 1 FROM Comisiones com 
                                WHERE com.EmpleadoID = p.EmpleadoID 
                                AND com.PrestamoID = p.PrestamoID 
                                AND com.EstadoPago = 'Pagado'
                            )
                            GROUP BY p.PrestamoID, c.Nombre, p.TipoPrestamo, p.FechaPrestamo, p.MontoTotal, p.Estado
                            ORDER BY p.FechaPrestamo DESC";

                        SqlCommand cmd = new SqlCommand(query, conexion);
                        cmd.Parameters.AddWithValue("@EmpleadoID", empleadoId);
                        cmd.Parameters.AddWithValue("@PorcentajeEfectivo", numericUpDownPorcentajeEfectivo.Value);
                        cmd.Parameters.AddWithValue("@PorcentajeProductos", numericUpDownPorcentajeProductos.Value);

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        dtPrestamosPendientes = new DataTable();
                        adapter.Fill(dtPrestamosPendientes);

                        dgvPrestamosPendientes.DataSource = dtPrestamosPendientes;

                        // Calcular totales
                        CalcularTotales();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar préstamos pendientes: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CalcularTotales()
        {
            if (dtPrestamosPendientes == null || dtPrestamosPendientes.Rows.Count == 0)
            {
                LimpiarResultados();
                return;
            }

            decimal totalEfectivo = 0;
            decimal comisionEfectivo = 0;
            decimal totalProductos = 0;
            decimal comisionProductos = 0;

            foreach (DataRow row in dtPrestamosPendientes.Rows)
            {
                string tipoPrestamo = row["TipoPrestamo"].ToString();
                decimal totalPagado = Convert.ToDecimal(row["TotalPagado"]);
                decimal comisionCalculada = Convert.ToDecimal(row["ComisionCalculada"]);

                if (tipoPrestamo == "Efectivo")
                {
                    totalEfectivo += totalPagado;
                    comisionEfectivo += comisionCalculada;
                }
                else
                {
                    totalProductos += totalPagado;
                    comisionProductos += comisionCalculada;
                }
            }

            // Actualizar interfaz
            lblTotalEfectivo.Text = $"Total Pagos Pendientes: {totalEfectivo:C}";
            lblComisionEfectivo.Text = $"Comisión ({numericUpDownPorcentajeEfectivo.Value}%): {comisionEfectivo:C}";

            lblTotalProductos.Text = $"Total Pagos Pendientes: {totalProductos:C}";
            lblComisionProductos.Text = $"Comisión ({numericUpDownPorcentajeProductos.Value}%): {comisionProductos:C}";

            decimal totalComision = comisionEfectivo + comisionProductos;
            lblTotalPagar.Text = $"Total a Pagar al Empleado: {totalComision:C}";
        }

        private void LimpiarResultados()
        {
            lblTotalEfectivo.Text = "Total Pagos Pendientes: $0.00";
            lblComisionEfectivo.Text = "Comisión (0%): $0.00";
            lblTotalProductos.Text = "Total Pagos Pendientes: $0.00";
            lblComisionProductos.Text = "Comisión (0%): $0.00";
            lblTotalPagar.Text = "Total a Pagar al Empleado: $0.00";

            dgvPrestamosPendientes.DataSource = null;
        }

        private void btnMarcarComoPagado_Click(object sender, EventArgs e)
        {
            if (cmbEmpleados.SelectedIndex <= 0)
            {
                MessageBox.Show("Seleccione un empleado primero.", "Advertencia",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgvPrestamosPendientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione al menos un préstamo para marcar como pagado.", "Advertencia",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dynamic selectedEmpleado = cmbEmpleados.SelectedItem;
            int empleadoId = selectedEmpleado.EmpleadoID;

            MarcarComisionesComoPagadas(empleadoId);
        }

        private void MarcarComisionesComoPagadas(int empleadoId)
        {
            try
            {
                using (SqlConnection conexion = conexionSQL.ObtenerConexion())
                {
                    if (conexion != null)
                    {
                        decimal totalComisionPagada = 0;

                        foreach (DataGridViewRow row in dgvPrestamosPendientes.SelectedRows)
                        {
                            int prestamoId = Convert.ToInt32(row.Cells["PrestamoID"].Value);
                            decimal comisionCalculada = Convert.ToDecimal(row.Cells["ComisionCalculada"].Value);
                            string tipoPrestamo = row.Cells["TipoPrestamo"].Value.ToString();

                            // Insertar nueva comisión
                            string queryInsert = @"
                                INSERT INTO Comisiones (EmpleadoID, PrestamoID, Periodo, 
                                                      ComisionEfectivo, ComisionProductos, TotalComision, 
                                                      EstadoPago, FechaPago, FechaCalculo)
                                VALUES (@EmpleadoID, @PrestamoID, @Periodo, 
                                        @ComisionEfectivo, @ComisionProductos, @TotalComision, 
                                        @EstadoPago, @FechaPago, @FechaCalculo)";

                            SqlCommand cmdInsert = new SqlCommand(queryInsert, conexion);
                            cmdInsert.Parameters.AddWithValue("@EmpleadoID", empleadoId);
                            cmdInsert.Parameters.AddWithValue("@PrestamoID", prestamoId);
                            cmdInsert.Parameters.AddWithValue("@Periodo", DateTime.Now.Date);

                            if (tipoPrestamo == "Efectivo")
                            {
                                cmdInsert.Parameters.AddWithValue("@ComisionEfectivo", comisionCalculada);
                                cmdInsert.Parameters.AddWithValue("@ComisionProductos", 0);
                            }
                            else
                            {
                                cmdInsert.Parameters.AddWithValue("@ComisionEfectivo", 0);
                                cmdInsert.Parameters.AddWithValue("@ComisionProductos", comisionCalculada);
                            }

                            cmdInsert.Parameters.AddWithValue("@TotalComision", comisionCalculada);
                            cmdInsert.Parameters.AddWithValue("@EstadoPago", "Pagado");
                            cmdInsert.Parameters.AddWithValue("@FechaPago", DateTime.Now);
                            cmdInsert.Parameters.AddWithValue("@FechaCalculo", DateTime.Now);

                            cmdInsert.ExecuteNonQuery();
                            totalComisionPagada += comisionCalculada;
                        }

                        // Registrar movimiento en caja del empleado
                        RegistrarMovimientoCaja(conexion, empleadoId, totalComisionPagada);

                        MessageBox.Show($"Comisiones marcadas como pagadas exitosamente.\nTotal pagado: {totalComisionPagada:C}",
                                       "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Recargar préstamos pendientes
                        CargarPrestamosPendientes(empleadoId);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al marcar comisiones como pagadas: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RegistrarMovimientoCaja(SqlConnection conexion, int empleadoId, decimal totalComision)
        {
            try
            {
                // Obtener saldo actual del empleado
                string querySaldo = "SELECT ISNULL(SaldoCaja, 0) FROM Empleados WHERE EmpleadoID = @EmpleadoID";
                SqlCommand cmdSaldo = new SqlCommand(querySaldo, conexion);
                cmdSaldo.Parameters.AddWithValue("@EmpleadoID", empleadoId);

                decimal saldoAnterior = Convert.ToDecimal(cmdSaldo.ExecuteScalar());
                decimal saldoNuevo = saldoAnterior + totalComision;

                // Insertar movimiento de caja
                string queryMovimiento = @"
                    INSERT INTO MovimientosCaja (EmpleadoID, TipoMovimiento, Monto, Descripcion, 
                                               FechaMovimiento, SaldoAnterior, SaldoNuevo)
                    VALUES (@EmpleadoID, @TipoMovimiento, @Monto, @Descripcion, 
                            @FechaMovimiento, @SaldoAnterior, @SaldoNuevo)";

                SqlCommand cmdMovimiento = new SqlCommand(queryMovimiento, conexion);
                cmdMovimiento.Parameters.AddWithValue("@EmpleadoID", empleadoId);
                cmdMovimiento.Parameters.AddWithValue("@TipoMovimiento", "Ingreso");
                cmdMovimiento.Parameters.AddWithValue("@Monto", totalComision);
                cmdMovimiento.Parameters.AddWithValue("@Descripcion", $"Pago de comisiones - {DateTime.Now:dd/MM/yyyy}");
                cmdMovimiento.Parameters.AddWithValue("@FechaMovimiento", DateTime.Now);
                cmdMovimiento.Parameters.AddWithValue("@SaldoAnterior", saldoAnterior);
                cmdMovimiento.Parameters.AddWithValue("@SaldoNuevo", saldoNuevo);

                cmdMovimiento.ExecuteNonQuery();

                // Actualizar saldo del empleado
                string queryUpdateSaldo = "UPDATE Empleados SET SaldoCaja = @SaldoNuevo WHERE EmpleadoID = @EmpleadoID";
                SqlCommand cmdUpdateSaldo = new SqlCommand(queryUpdateSaldo, conexion);
                cmdUpdateSaldo.Parameters.AddWithValue("@SaldoNuevo", saldoNuevo);
                cmdUpdateSaldo.Parameters.AddWithValue("@EmpleadoID", empleadoId);

                cmdUpdateSaldo.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar movimiento de caja: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardarPorcentaje_Click(object sender, EventArgs e)
        {
            if (cmbEmpleados.SelectedIndex <= 0)
            {
                MessageBox.Show("Seleccione un empleado primero.", "Advertencia",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dynamic selectedEmpleado = cmbEmpleados.SelectedItem;
            int empleadoId = selectedEmpleado.EmpleadoID;

            GuardarPorcentajeComision(empleadoId);
        }

        private void GuardarPorcentajeComision(int empleadoId)
        {
            try
            {
                decimal porcentajeEfectivo = numericUpDownPorcentajeEfectivo.Value;

                using (SqlConnection conexion = conexionSQL.ObtenerConexion())
                {
                    if (conexion != null)
                    {
                        string query = @"
                            UPDATE Empleados SET 
                            PorcentajeComision = @PorcentajeEfectivo
                            WHERE EmpleadoID = @EmpleadoID";

                        SqlCommand cmd = new SqlCommand(query, conexion);
                        cmd.Parameters.AddWithValue("@PorcentajeEfectivo", porcentajeEfectivo);
                        cmd.Parameters.AddWithValue("@EmpleadoID", empleadoId);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Porcentajes de comisión guardados exitosamente.", "Éxito",
                                       MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Recargar préstamos para actualizar comisiones
                        CargarPrestamosPendientes(empleadoId);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar porcentajes: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGenerarPDFDetallado_Click(object sender, EventArgs e)
        {
            if (cmbEmpleados.SelectedIndex <= 0)
            {
                MessageBox.Show("Seleccione un empleado primero.", "Advertencia",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Funcionalidad de PDF detallado será implementada próximamente.", "Información",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDescargarPDFSemanal_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidad de PDF semanal será implementada próximamente.", "Información",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}