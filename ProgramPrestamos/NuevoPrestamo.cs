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
    public partial class NuevoPrestamo : Form
    {
        private ConexionSQL conexion;
        private int clienteSeleccionadoId = 0;
        private int productoSeleccionadoId = 0;
        private int precioProductoSeleccionado = 0;
        private int stockProductoSeleccionado = 0;
        private string empleadoAsignado = "";
        private int totalAPagar = 0;
        private int interesGenerado = 0;
        private int valorCuota = 0;

        public NuevoPrestamo()
        {
            InitializeComponent();
            conexion = new ConexionSQL();
        }

        private void NuevoPrestamo_Load(object sender, EventArgs e)
        {
            CargarClientes();
            CargarProductos();
            dtpFechaPrestamo.Value = DateTime.Now;
        }

        private void CargarClientes()
        {
            try
            {
                using (SqlConnection conn = conexion.ObtenerConexion())
                {
                    if (conn != null)
                    {
                        string query = @"SELECT c.ClienteID, c.Nombre, e.Nombre as EmpleadoNombre 
                                       FROM Clientes c 
                                       INNER JOIN Empleados e ON c.EmpleadoAsignado = e.EmpleadoID 
                                       WHERE c.Activo = 1";

                        SqlCommand cmd = new SqlCommand(query, conn);
                        SqlDataReader reader = cmd.ExecuteReader();

                        cmbCliente.Items.Clear();
                        while (reader.Read())
                        {
                            var item = new
                            {
                                ClienteID = Convert.ToInt32(reader["ClienteID"]),
                                Nombre = reader["Nombre"].ToString(),
                                EmpleadoNombre = reader["EmpleadoNombre"].ToString()
                            };
                            cmbCliente.Items.Add(item);
                        }

                        cmbCliente.DisplayMember = "Nombre";
                        cmbCliente.ValueMember = "ClienteID";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar clientes: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarProductos()
        {
            try
            {
                using (SqlConnection conn = conexion.ObtenerConexion())
                {
                    if (conn != null)
                    {
                        string query = "SELECT ProductoID, Nombre, PrecioBase, Stock FROM Productos WHERE Activo = 1 AND Stock > 0";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        SqlDataReader reader = cmd.ExecuteReader();

                        cmbProducto.Items.Clear();
                        while (reader.Read())
                        {
                            var item = new
                            {
                                ProductoID = Convert.ToInt32(reader["ProductoID"]),
                                Nombre = reader["Nombre"].ToString(),
                                PrecioBase = Convert.ToInt32(reader["PrecioBase"]),
                                Stock = Convert.ToInt32(reader["Stock"])
                            };
                            cmbProducto.Items.Add(item);
                        }

                        cmbProducto.DisplayMember = "Nombre";
                        cmbProducto.ValueMember = "ProductoID";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar productos: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCliente.SelectedItem != null)
            {
                dynamic cliente = cmbCliente.SelectedItem;
                clienteSeleccionadoId = cliente.ClienteID;
                empleadoAsignado = cliente.EmpleadoNombre;
                lblEmpleadoAsignado.Text = $"Empleado Asignado: {empleadoAsignado}";
            }
        }

        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProducto.SelectedItem != null)
            {
                dynamic producto = cmbProducto.SelectedItem;
                productoSeleccionadoId = producto.ProductoID;
                precioProductoSeleccionado = producto.PrecioBase;
                stockProductoSeleccionado = producto.Stock;

                lblPrecioProducto.Text = $"Precio: ${precioProductoSeleccionado}";

                cmbCantidadProducto.Items.Clear();
                for (int i = 1; i <= stockProductoSeleccionado; i++)
                {
                    cmbCantidadProducto.Items.Add(i);
                }
            }
        }

        private void rbPrestamoEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPrestamoEfectivo.Checked)
            {
                panelPrestamoEfectivo.Visible = true;
                panelPrestamoProducto.Visible = false;
                LimpiarCalculos();
            }
        }

        private void rbPrestamoProducto_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPrestamoProducto.Checked)
            {
                panelPrestamoEfectivo.Visible = false;
                panelPrestamoProducto.Visible = true;
                LimpiarCalculos();
            }
        }

        private void btnCalcularEfectivo_Click(object sender, EventArgs e)
        {
            if (ValidarDatosComunes() && ValidarEfectivo())
            {
                CalcularPrestamoEfectivo();
            }
        }

        private void btnConfirmarProducto_Click(object sender, EventArgs e)
        {
            if (ValidarDatosComunes() && ValidarProducto())
            {
                CalcularPrestamoProducto();
            }
        }

        private bool ValidarDatosComunes()
        {
            if (clienteSeleccionadoId == 0)
            {
                MessageBox.Show("Debe seleccionar un cliente.", "Validación",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cmbModalidad.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una modalidad.", "Validación",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTasaInteres.Text) || !int.TryParse(txtTasaInteres.Text, out _))
            {
                MessageBox.Show("Debe ingresar una tasa de interés válida (número entero).", "Validación",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCantidadCuotas.Text) || !int.TryParse(txtCantidadCuotas.Text, out _))
            {
                MessageBox.Show("Debe ingresar una cantidad de cuotas válida (número entero).", "Validación",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private bool ValidarEfectivo()
        {
            if (string.IsNullOrWhiteSpace(txtImporte.Text) || !int.TryParse(txtImporte.Text, out _))
            {
                MessageBox.Show("Debe ingresar un importe válido (número entero).", "Validación",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private bool ValidarProducto()
        {
            if (productoSeleccionadoId == 0)
            {
                MessageBox.Show("Debe seleccionar un producto.", "Validación",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cmbCantidadProducto.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una cantidad.", "Validación",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPrecioCuota.Text) || !int.TryParse(txtPrecioCuota.Text, out _))
            {
                MessageBox.Show("Debe ingresar un precio por cuota válido (número entero).", "Validación",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void CalcularPrestamoEfectivo()
        {
            int montoBase = int.Parse(txtImporte.Text);
            int tasaInteres = int.Parse(txtTasaInteres.Text);
            int cantidadCuotas = int.Parse(txtCantidadCuotas.Text);

            // Calcular interés
            interesGenerado = (montoBase * tasaInteres) / 100;
            totalAPagar = montoBase + interesGenerado;
            valorCuota = totalAPagar / cantidadCuotas;

            // Mostrar resultados
            lblTotalPagar.Text = $"Total a Pagar: ${totalAPagar}";
            lblInteresGenerado.Text = $"Interés Generado: ${interesGenerado}";
            lblValorCuota.Text = $"Valor por Cuota: ${valorCuota}";
        }

        private void CalcularPrestamoProducto()
        {
            int cantidad = int.Parse(cmbCantidadProducto.SelectedItem.ToString());
            int precioCuota = int.Parse(txtPrecioCuota.Text);
            int cantidadCuotas = int.Parse(txtCantidadCuotas.Text);

            int valorProducto = precioProductoSeleccionado * cantidad;
            totalAPagar = cantidadCuotas * precioCuota;
            interesGenerado = totalAPagar - valorProducto;
            valorCuota = precioCuota;

            // Mostrar resultados
            lblTotalPagar.Text = $"Total a Pagar: ${totalAPagar}";
            lblInteresGenerado.Text = $"Interés Generado: ${interesGenerado}";
            lblValorCuota.Text = $"Valor por Cuota: ${valorCuota}";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (totalAPagar == 0)
            {
                MessageBox.Show("Debe calcular el préstamo antes de guardar.", "Validación",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = conexion.ObtenerConexion())
                {
                    if (conn != null)
                    {
                        SqlTransaction transaction = conn.BeginTransaction();

                        try
                        {
                            // Calcular la fecha de vencimiento final del préstamo
                            int cantidadCuotas = int.Parse(txtCantidadCuotas.Text);
                            string modalidad = cmbModalidad.SelectedItem.ToString();
                            DateTime fechaBase = dtpFechaPrestamo.Value;
                            DateTime fechaVencimientoFinal = CalcularFechaVencimiento(fechaBase, cantidadCuotas, modalidad);

                            // Insertar préstamo
                            string queryPrestamo = @"INSERT INTO Prestamos 
                                (ClienteID, EmpleadoID, TipoPrestamo, MontoTotal, TasaInteres, CantidadCuotas, 
                                 Modalidad, FechaPrestamo, FechaVencimiento, TotalAPagar, ValorCuota, SaldoPendiente, Estado, FechaCreacion)
                                VALUES (@ClienteID, @EmpleadoID, @TipoPrestamo, @MontoTotal, @TasaInteres, @CantidadCuotas,
                                        @Modalidad, @FechaPrestamo, @FechaVencimiento, @TotalAPagar, @ValorCuota, @SaldoPendiente, @Estado, @FechaCreacion);
                                SELECT SCOPE_IDENTITY();";

                            SqlCommand cmdPrestamo = new SqlCommand(queryPrestamo, conn, transaction);
                            cmdPrestamo.Parameters.AddWithValue("@ClienteID", clienteSeleccionadoId);
                            cmdPrestamo.Parameters.AddWithValue("@EmpleadoID", ObtenerEmpleadoID());
                            cmdPrestamo.Parameters.AddWithValue("@TipoPrestamo", rbPrestamoEfectivo.Checked ? "Efectivo" : "Producto");
                            cmdPrestamo.Parameters.AddWithValue("@MontoTotal", rbPrestamoEfectivo.Checked ? int.Parse(txtImporte.Text) : precioProductoSeleccionado * int.Parse(cmbCantidadProducto.SelectedItem.ToString()));
                            cmdPrestamo.Parameters.AddWithValue("@TasaInteres", int.Parse(txtTasaInteres.Text));
                            cmdPrestamo.Parameters.AddWithValue("@CantidadCuotas", cantidadCuotas);
                            cmdPrestamo.Parameters.AddWithValue("@Modalidad", modalidad);
                            cmdPrestamo.Parameters.AddWithValue("@FechaPrestamo", fechaBase);
                            cmdPrestamo.Parameters.AddWithValue("@FechaVencimiento", fechaVencimientoFinal); // Parámetro añadido
                            cmdPrestamo.Parameters.AddWithValue("@TotalAPagar", totalAPagar);
                            cmdPrestamo.Parameters.AddWithValue("@ValorCuota", valorCuota);
                            cmdPrestamo.Parameters.AddWithValue("@SaldoPendiente", totalAPagar);
                            cmdPrestamo.Parameters.AddWithValue("@Estado", "Activo");
                            cmdPrestamo.Parameters.AddWithValue("@FechaCreacion", DateTime.Now);

                            int prestamoID = Convert.ToInt32(cmdPrestamo.ExecuteScalar());

                            // Si es préstamo de producto, insertar detalle y actualizar stock
                            if (rbPrestamoProducto.Checked)
                            {
                                string queryDetalle = @"INSERT INTO DetallePrestamosProductos 
                                    (PrestamoID, ProductoID, Cantidad, PrecioUnitario, PrecioCuota, Subtotal)
                                    VALUES (@PrestamoID, @ProductoID, @Cantidad, @PrecioUnitario, @PrecioCuota, @Subtotal)";

                                SqlCommand cmdDetalle = new SqlCommand(queryDetalle, conn, transaction);
                                cmdDetalle.Parameters.AddWithValue("@PrestamoID", prestamoID);
                                cmdDetalle.Parameters.AddWithValue("@ProductoID", productoSeleccionadoId);
                                cmdDetalle.Parameters.AddWithValue("@Cantidad", int.Parse(cmbCantidadProducto.SelectedItem.ToString()));
                                cmdDetalle.Parameters.AddWithValue("@PrecioUnitario", precioProductoSeleccionado);
                                cmdDetalle.Parameters.AddWithValue("@PrecioCuota", int.Parse(txtPrecioCuota.Text));
                                cmdDetalle.Parameters.AddWithValue("@Subtotal", precioProductoSeleccionado * int.Parse(cmbCantidadProducto.SelectedItem.ToString()));
                                cmdDetalle.ExecuteNonQuery();

                                // Actualizar stock
                                string queryStock = "UPDATE Productos SET Stock = Stock - @Cantidad WHERE ProductoID = @ProductoID";
                                SqlCommand cmdStock = new SqlCommand(queryStock, conn, transaction);
                                cmdStock.Parameters.AddWithValue("@Cantidad", int.Parse(cmbCantidadProducto.SelectedItem.ToString()));
                                cmdStock.Parameters.AddWithValue("@ProductoID", productoSeleccionadoId);
                                cmdStock.ExecuteNonQuery();
                            }

                            // Generar cuotas
                            GenerarCuotas(prestamoID, conn, transaction);

                            transaction.Commit();
                            MessageBox.Show("Préstamo guardado exitosamente.", "Éxito",
                                           MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpiarFormulario();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            throw ex;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el préstamo: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int ObtenerEmpleadoID()
        {
            try
            {
                using (SqlConnection conn = conexion.ObtenerConexion())
                {
                    if (conn != null)
                    {
                        string query = "SELECT EmpleadoAsignado FROM Clientes WHERE ClienteID = @ClienteID";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@ClienteID", clienteSeleccionadoId);
                        return Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener empleado: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return 1; // Valor por defecto
        }

        // Método GenerarCuotas que inserta una sola fila resumen en la tabla Cuotas
        private void GenerarCuotas(int prestamoID, SqlConnection conn, SqlTransaction transaction)
        {
            int cantidadCuotas = int.Parse(txtCantidadCuotas.Text);
            string modalidad = cmbModalidad.SelectedItem.ToString();
            DateTime fechaBase = dtpFechaPrestamo.Value;

            // Calcular la fecha final de vencimiento (vencimiento de la última cuota)
            DateTime fechaVencimientoFinal = CalcularFechaVencimiento(fechaBase, cantidadCuotas, modalidad);

            // Se inserta una sola fila en Cuotas:
            // - PrestamoID: ID del préstamo recién insertado.
            // - NumeroCuota: se guarda la cantidad total de cuotas.
            // - FechaVencimiento: fecha final de vencimiento del préstamo.
            // - ValorCuota: valor de cada cuota.
            string queryCuota = @"INSERT INTO Cuotas 
                          (PrestamoID, NumeroCuota, FechaVencimiento, ValorCuota)
                          VALUES (@PrestamoID, @CantidadCuotas, @FechaVencimiento, @ValorCuota)";
            SqlCommand cmdCuota = new SqlCommand(queryCuota, conn, transaction);
            cmdCuota.Parameters.AddWithValue("@PrestamoID", prestamoID);
            cmdCuota.Parameters.AddWithValue("@CantidadCuotas", cantidadCuotas);
            cmdCuota.Parameters.AddWithValue("@FechaVencimiento", fechaVencimientoFinal);
            cmdCuota.Parameters.AddWithValue("@ValorCuota", valorCuota);
            cmdCuota.ExecuteNonQuery();
        }

        private DateTime CalcularFechaVencimiento(DateTime fechaBase, int numeroCuota, string modalidad)
        {
            switch (modalidad)
            {
                case "Diario":
                    return fechaBase.AddDays(numeroCuota);
                case "Semanal":
                    return fechaBase.AddDays(numeroCuota * 7);
                case "Mensual":
                    return fechaBase.AddMonths(numeroCuota);
                default:
                    return fechaBase.AddDays(numeroCuota);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            cmbCliente.SelectedIndex = -1;
            cmbModalidad.SelectedIndex = -1;
            txtTasaInteres.Clear();
            txtCantidadCuotas.Clear();
            txtImporte.Clear();
            cmbProducto.SelectedIndex = -1;
            cmbCantidadProducto.Items.Clear();
            txtPrecioCuota.Clear();
            dtpFechaPrestamo.Value = DateTime.Now;
            rbPrestamoEfectivo.Checked = true;
            LimpiarCalculos();
        }

        private void LimpiarCalculos()
        {
            lblTotalPagar.Text = "Total a Pagar: $0";
            lblInteresGenerado.Text = "Interés Generado: $0";
            lblValorCuota.Text = "Valor por Cuota: $0";
            lblEmpleadoAsignado.Text = "Empleado Asignado: --";

            clienteSeleccionadoId = 0;
            productoSeleccionadoId = 0;
            precioProductoSeleccionado = 0;
            stockProductoSeleccionado = 0;
            empleadoAsignado = "";
            totalAPagar = 0;
            interesGenerado = 0;
            valorCuota = 0;
        }
    }
}