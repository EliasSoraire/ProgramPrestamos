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
    public partial class Empleados : Form
    {
        private ConexionSQL conexionSQL;
        private DataTable dtEmpleados;

        public Empleados()
        {
            InitializeComponent();
            conexionSQL = new ConexionSQL();
            ConfigurarListView();
            CargarEmpleados();
        }

        private void ConfigurarListView()
        {
            dgvEmpleados.View = View.Details;
            dgvEmpleados.FullRowSelect = true;
            dgvEmpleados.GridLines = true;
            dgvEmpleados.MultiSelect = false;

            // Configurar columnas - solo ID, Nombre y DNI
            dgvEmpleados.Columns.Add("Nombre", 200);
            dgvEmpleados.Columns.Add("DNI", 100);
            dgvEmpleados.Columns.Add("Editar", 80);

            // Evento para seleccionar empleado
            dgvEmpleados.SelectedIndexChanged += ListViewEmpleados_SelectedIndexChanged;
            dgvEmpleados.MouseClick += DgvEmpleados_MouseClick;
        }

        private void CargarEmpleados()
        {
            try
            {
                using (SqlConnection conexion = conexionSQL.ObtenerConexion())
                {
                    if (conexion != null)
                    {
                        string query = @"SELECT EmpleadoID, Nombre, DNI, Telefono, Direccion, Activo
                                FROM Empleados
                                WHERE Activo = 1
                               ORDER BY Nombre";

                        SqlDataAdapter adapter = new SqlDataAdapter(query, conexion);
                        dtEmpleados = new DataTable();
                        adapter.Fill(dtEmpleados);

                        // Limpiar ListView
                        dgvEmpleados.Items.Clear();

                        // Cargar datos en ListView - solo ID, Nombre y DNI
                        foreach (DataRow row in dtEmpleados.Rows)
                        {
                            ListViewItem item = new ListViewItem(row["Nombre"].ToString());
                            item.SubItems.Add(row["DNI"].ToString());
                            item.SubItems.Add("Editar");
                            item.Tag = row;

                            dgvEmpleados.Items.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar empleados: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListViewEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dgvEmpleados.SelectedItems.Count > 0)
            {
                DataRow empleado = (DataRow)dgvEmpleados.SelectedItems[0].Tag;
                MostrarDetalleEmpleado(empleado);
            }
        }

        private void DgvEmpleados_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvEmpleados.SelectedItems.Count > 0)
            {
                ListViewItem item = dgvEmpleados.SelectedItems[0];

                ListViewHitTestInfo hitTest = dgvEmpleados.HitTest(e.X, e.Y);
                if (hitTest.SubItem != null && hitTest.SubItem == item.SubItems[2])
                {
                    DataRow empleado = (DataRow)item.Tag;
                    EditarEmpleado(empleado);
                }
            }
        }

        private void EditarEmpleado(DataRow empleado)
        {
            FormEditarEmpleado formEditar = new FormEditarEmpleado(empleado);
            if (formEditar.ShowDialog() == DialogResult.OK)
            {
                CargarEmpleados(); // Recargar lista después de editar

                // Si hay un empleado seleccionado, actualizar sus detalles
                if (dgvEmpleados.SelectedItems.Count > 0)
                {
                    DataRow empleadoActualizado = (DataRow)dgvEmpleados.SelectedItems[0].Tag;
                    MostrarDetalleEmpleado(empleadoActualizado);
                }
            }
        }

        private void MostrarDetalleEmpleado(DataRow empleado)
        {
            // Mostrar información básica
            lblEmpleadoNombre.Text = empleado["Nombre"].ToString();
            lblEmpleadoInfo.Text = $"DNI: {empleado["DNI"]} - Tel: {empleado["Telefono"]}";

            // Llenar datos en la pestaña de información personal
            lblNombreCompletoValor.Text = empleado["Nombre"].ToString();
            lblDNIValor.Text = empleado["DNI"].ToString();
            lblTelefonoValor.Text = empleado["Telefono"].ToString();
            lblDireccionValor.Text = empleado["Direccion"].ToString();

            // Mostrar panel de detalles
            panelEmpleadoDetails.Visible = true;

            int empleadoId = Convert.ToInt32(empleado["EmpleadoID"]);

            // Cargar préstamos activos del empleado
            CargarPrestamosActivos(empleadoId);

            // Cargar combobox con préstamos para registro de pagos
            CargarPrestamosComboBox(empleadoId);
        }

        private void CargarPrestamosActivos(int empleadoId)
        {
            try
            {
                using (SqlConnection conexion = conexionSQL.ObtenerConexion())
                {
                    if (conexion != null)
                    {
                        string query = @"SELECT p.PrestamoID, c.Nombre as Cliente, p.MontoTotal,
                                        p.SaldoPendiente, p.FechaPrestamo, p.Estado, p.CantidadCuotas,
                                       (SELECT COUNT(*) FROM Cuotas cu WHERE cu.PrestamoID = p.PrestamoID AND cu.FechaPago IS NULL) as CuotasPendientes
                                       FROM Prestamos p
                                       INNER JOIN Clientes c ON p.ClienteID = c.ClienteID
                                       WHERE p.EmpleadoID = @EmpleadoID AND p.Estado = 'Activo'
                                       ORDER BY p.FechaPrestamo DESC";

                        SqlCommand cmd = new SqlCommand(query, conexion);
                        cmd.Parameters.AddWithValue("@EmpleadoID", empleadoId);

                        listViewPrestamosActivos.Items.Clear();
                        listViewPrestamosActivos.View = View.Details;
                        listViewPrestamosActivos.Columns.Clear();
                        listViewPrestamosActivos.Columns.Add("ID", 50);
                        listViewPrestamosActivos.Columns.Add("Cliente", 150);
                        listViewPrestamosActivos.Columns.Add("Monto Total", 100);
                        listViewPrestamosActivos.Columns.Add("Saldo Pendiente", 120);
                        listViewPrestamosActivos.Columns.Add("Cuotas Pend.", 100);
                        listViewPrestamosActivos.Columns.Add("Fecha", 100);

                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader["PrestamoID"].ToString());
                            item.SubItems.Add(reader["Cliente"].ToString());
                            item.SubItems.Add(Convert.ToDecimal(reader["MontoTotal"]).ToString("C"));
                            item.SubItems.Add(Convert.ToDecimal(reader["SaldoPendiente"]).ToString("C"));
                            item.SubItems.Add(reader["CuotasPendientes"].ToString());
                            item.SubItems.Add(Convert.ToDateTime(reader["FechaPrestamo"]).ToString("dd/MM/yyyy"));

                            listViewPrestamosActivos.Items.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar préstamos: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarPrestamosComboBox(int empleadoId)
        {
            try
            {
                using (SqlConnection conexion = conexionSQL.ObtenerConexion())
                {
                    if (conexion != null)
                    {
                        string query = @"SELECT p.PrestamoID, c.Nombre + ' - Préstamo #' + CAST(p.PrestamoID AS VARCHAR) as Display
                                       FROM Prestamos p
                                       INNER JOIN Clientes c ON p.ClienteID = c.ClienteID
                                       WHERE p.EmpleadoID = @EmpleadoID AND p.Estado = 'Activo'
                                       ORDER BY p.FechaPrestamo DESC";

                        SqlCommand cmd = new SqlCommand(query, conexion);
                        cmd.Parameters.AddWithValue("@EmpleadoID", empleadoId);

                        cmbPrestamoSeleccion.Items.Clear();
                        cmbPrestamoSeleccion.DisplayMember = "Display";
                        cmbPrestamoSeleccion.ValueMember = "PrestamoID";

                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            cmbPrestamoSeleccion.Items.Add(new
                            {
                                PrestamoID = reader["PrestamoID"],
                                Display = reader["Display"]
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar préstamos para combo: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RegistrarPago()
        {
            try
            {
                // Validar que se hayan completado todos los campos
                if (cmbPrestamoSeleccion.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione un préstamo.", "Advertencia",
                                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtMontoPagoInfo.Text))
                {
                    MessageBox.Show("Ingrese el monto del pago.", "Advertencia",
                                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtNumeroCuota.Text))
                {
                    MessageBox.Show("Ingrese el número de cuota.", "Advertencia",
                                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (SqlConnection conexion = conexionSQL.ObtenerConexion())
                {
                    if (conexion != null)
                    {
                        using (SqlTransaction transaction = conexion.BeginTransaction())
                        {
                            try
                            {
                                dynamic selectedPrestamo = cmbPrestamoSeleccion.SelectedItem;
                                int prestamoId = selectedPrestamo.PrestamoID;
                                decimal montoPago = Convert.ToDecimal(txtMontoPagoInfo.Text);
                                int numeroCuota = Convert.ToInt32(txtNumeroCuota.Text);
                                DateTime fechaPago = dateTimePickerFechaPago.Value;

                                // Obtener EmpleadoID del empleado seleccionado
                                DataRow empleadoSeleccionado = (DataRow)dgvEmpleados.SelectedItems[0].Tag;
                                int empleadoId = Convert.ToInt32(empleadoSeleccionado["EmpleadoID"]);

                                // Insertar pago
                                string queryPago = @"INSERT INTO Pagos (PrestamoID, NumeroCuota, MontoPago, FechaPago,
                                                    FechaRegistro, EmpleadoID, TipoPago)
                                                   VALUES (@PrestamoID, @NumeroCuota, @MontoPago, @FechaPago,
                                                    @FechaRegistro, @EmpleadoID, @TipoPago)";

                                SqlCommand cmdPago = new SqlCommand(queryPago, conexion, transaction);
                                cmdPago.Parameters.AddWithValue("@PrestamoID", prestamoId);
                                cmdPago.Parameters.AddWithValue("@NumeroCuota", numeroCuota);
                                cmdPago.Parameters.AddWithValue("@MontoPago", montoPago);
                                cmdPago.Parameters.AddWithValue("@FechaPago", fechaPago);
                                cmdPago.Parameters.AddWithValue("@FechaRegistro", DateTime.Now);
                                cmdPago.Parameters.AddWithValue("@EmpleadoID", empleadoId);
                                cmdPago.Parameters.AddWithValue("@TipoPago", "Efectivo");

                                cmdPago.ExecuteNonQuery();

                                // Actualizar cuota
                                string queryCuota = @"UPDATE Cuotas SET FechaPago = @FechaPago, MontoPagado = @MontoPagado
                                                    WHERE PrestamoID = @PrestamoID AND NumeroCuota = @NumeroCuota";

                                SqlCommand cmdCuota = new SqlCommand(queryCuota, conexion, transaction);
                                cmdCuota.Parameters.AddWithValue("@FechaPago", fechaPago);
                                cmdCuota.Parameters.AddWithValue("@MontoPagado", montoPago);
                                cmdCuota.Parameters.AddWithValue("@PrestamoID", prestamoId);
                                cmdCuota.Parameters.AddWithValue("@NumeroCuota", numeroCuota);

                                cmdCuota.ExecuteNonQuery();

                                // Actualizar saldo pendiente del préstamo
                                string queryUpdatePrestamo = @"UPDATE Prestamos SET SaldoPendiente = SaldoPendiente - @MontoPago,
                                                             UltimaFechaPago = @FechaPago
                                                             WHERE PrestamoID = @PrestamoID";

                                SqlCommand cmdUpdatePrestamo = new SqlCommand(queryUpdatePrestamo, conexion, transaction);
                                cmdUpdatePrestamo.Parameters.AddWithValue("@MontoPago", montoPago);
                                cmdUpdatePrestamo.Parameters.AddWithValue("@FechaPago", fechaPago);
                                cmdUpdatePrestamo.Parameters.AddWithValue("@PrestamoID", prestamoId);

                                cmdUpdatePrestamo.ExecuteNonQuery();

                                transaction.Commit();

                                MessageBox.Show("Pago registrado exitosamente.", "Éxito",
                                               MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Limpiar campos
                                txtMontoPagoInfo.Clear();
                                txtNumeroCuota.Clear();
                                cmbPrestamoSeleccion.SelectedIndex = -1;

                                // Recargar datos
                                CargarPrestamosActivos(empleadoId);
                            }
                            catch (Exception)
                            {
                                transaction.Rollback();
                                throw;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar pago: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // EVENTOS DE BOTONES Y CONTROLES

        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            FormNuevoEmpleado formNuevo = new FormNuevoEmpleado();
            if (formNuevo.ShowDialog() == DialogResult.OK)
            {
                CargarEmpleados(); // Recargar lista después de agregar
            }
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            FiltrarEmpleados(txtBusqueda.Text);
        }

        private void FiltrarEmpleados(string filtro)
        {
            if (dtEmpleados == null) return;

            dgvEmpleados.Items.Clear();

            foreach (DataRow row in dtEmpleados.Rows)
            {
                bool coincide = string.IsNullOrEmpty(filtro) ||
                               row["Nombre"].ToString().ToLower().Contains(filtro.ToLower()) ||
                               row["DNI"].ToString().Contains(filtro);

                if (coincide)
                {
                    ListViewItem item = new ListViewItem(row["Nombre"].ToString());
                    item.SubItems.Add(row["DNI"].ToString());
                    item.SubItems.Add("Editar");
                    item.Tag = row;

                    dgvEmpleados.Items.Add(item);
                }
            }
        }

        // Conectar el evento del botón registrar pago
        private void btnRegistrarPagoInfo_Click(object sender, EventArgs e)
        {
            RegistrarPago();
        }
    }

    #region Formularios
    public partial class FormNuevoEmpleado : Form
    {
        private ConexionSQL conexionSQL;

        // Controles del formulario
        private Label lblTitulo;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblDNI;
        private TextBox txtDNI;
        private Label lblTelefono;
        private TextBox txtTelefono;
        private Label lblDireccion;
        private TextBox txtDireccion;
        private Button btnGuardar;
        private Button btnCancelar;

        public FormNuevoEmpleado()
        {
            InitializeComponent();
            conexionSQL = new ConexionSQL();
        }

        private void InitializeComponent()
        {
            this.Text = "Nuevo Empleado";
            this.Size = new Size(400, 300);
            this.StartPosition = FormStartPosition.CenterParent;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;

            // Título
            lblTitulo = new Label();
            lblTitulo.Text = "Registrar Nuevo Empleado";
            lblTitulo.Font = new Font("Arial", 14, FontStyle.Bold);
            lblTitulo.Location = new Point(20, 20);
            lblTitulo.Size = new Size(300, 25);
            this.Controls.Add(lblTitulo);

            // Nombre
            lblNombre = new Label();
            lblNombre.Text = "Nombre Completo:";
            lblNombre.Location = new Point(20, 60);
            lblNombre.Size = new Size(120, 20);
            this.Controls.Add(lblNombre);

            txtNombre = new TextBox();
            txtNombre.Location = new Point(150, 58);
            txtNombre.Size = new Size(200, 20);
            this.Controls.Add(txtNombre);

            // DNI
            lblDNI = new Label();
            lblDNI.Text = "DNI:";
            lblDNI.Location = new Point(20, 90);
            lblDNI.Size = new Size(120, 20);
            this.Controls.Add(lblDNI);

            txtDNI = new TextBox();
            txtDNI.Location = new Point(150, 88);
            txtDNI.Size = new Size(200, 20);
            this.Controls.Add(txtDNI);

            // Teléfono
            lblTelefono = new Label();
            lblTelefono.Text = "Teléfono:";
            lblTelefono.Location = new Point(20, 120);
            lblTelefono.Size = new Size(120, 20);
            this.Controls.Add(lblTelefono);

            txtTelefono = new TextBox();
            txtTelefono.Location = new Point(150, 118);
            txtTelefono.Size = new Size(200, 20);
            this.Controls.Add(txtTelefono);

            // Dirección
            lblDireccion = new Label();
            lblDireccion.Text = "Dirección:";
            lblDireccion.Location = new Point(20, 150);
            lblDireccion.Size = new Size(120, 20);
            this.Controls.Add(lblDireccion);

            txtDireccion = new TextBox();
            txtDireccion.Location = new Point(150, 148);
            txtDireccion.Size = new Size(200, 20);
            txtDireccion.Multiline = true;
            txtDireccion.Height = 40;
            this.Controls.Add(txtDireccion);

            // Botones
            btnGuardar = new Button();
            btnGuardar.Text = "Guardar";
            btnGuardar.Location = new Point(150, 210);
            btnGuardar.Size = new Size(80, 30);
            btnGuardar.Click += btnGuardar_Click;
            this.Controls.Add(btnGuardar);

            btnCancelar = new Button();
            btnCancelar.Text = "Cancelar";
            btnCancelar.Location = new Point(250, 210);
            btnCancelar.Size = new Size(80, 30);
            btnCancelar.Click += btnCancelar_Click;
            this.Controls.Add(btnCancelar);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                GuardarEmpleado();
            }
        }

        private bool ValidarDatos()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDNI.Text))
            {
                MessageBox.Show("El DNI es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDNI.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("El teléfono es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTelefono.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                MessageBox.Show("La dirección es obligatoria.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDireccion.Focus();
                return false;
            }

            return true;
        }

        private void GuardarEmpleado()
        {
            try
            {
                using (SqlConnection conexion = conexionSQL.ObtenerConexion())
                {
                    if (conexion != null)
                    {
                        string query = @"INSERT INTO Empleados (Nombre, DNI, Telefono, Direccion, Activo)
                                VALUES (@Nombre, @DNI, @Telefono, @Direccion, @Activo)";

                        SqlCommand cmd = new SqlCommand(query, conexion);
                        cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text.Trim());
                        cmd.Parameters.AddWithValue("@DNI", txtDNI.Text.Trim());
                        cmd.Parameters.AddWithValue("@Telefono", txtTelefono.Text.Trim());
                        cmd.Parameters.AddWithValue("@Direccion", txtDireccion.Text.Trim());
                        cmd.Parameters.AddWithValue("@Activo", true);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Empleado guardado exitosamente.", "Éxito",
                                       MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar empleado: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }

    public partial class FormEditarEmpleado : Form
    {
        private ConexionSQL conexionSQL;
        private DataRow empleadoOriginal;
        private int empleadoId;

        // Controles del formulario (mismos que FormNuevoEmpleado)
        private Label lblTitulo;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblDNI;
        private TextBox txtDNI;
        private Label lblTelefono;
        private TextBox txtTelefono;
        private Label lblDireccion;
        private TextBox txtDireccion;
        private Button btnGuardar;
        private Button btnCancelar;

        public FormEditarEmpleado(DataRow empleado)
        {
            empleadoOriginal = empleado;
            empleadoId = Convert.ToInt32(empleado["EmpleadoID"]);
            InitializeComponent();
            conexionSQL = new ConexionSQL();
            CargarDatos();
        }

        private void InitializeComponent()
        {
            this.Text = "Editar Empleado";
            this.Size = new Size(400, 300);
            this.StartPosition = FormStartPosition.CenterParent;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;

            // Título
            lblTitulo = new Label();
            lblTitulo.Text = "Editar Empleado";
            lblTitulo.Font = new Font("Arial", 14, FontStyle.Bold);
            lblTitulo.Location = new Point(20, 20);
            lblTitulo.Size = new Size(300, 25);
            this.Controls.Add(lblTitulo);

            // Nombre
            lblNombre = new Label();
            lblNombre.Text = "Nombre Completo:";
            lblNombre.Location = new Point(20, 60);
            lblNombre.Size = new Size(120, 20);
            this.Controls.Add(lblNombre);

            txtNombre = new TextBox();
            txtNombre.Location = new Point(150, 58);
            txtNombre.Size = new Size(200, 20);
            this.Controls.Add(txtNombre);

            // DNI
            lblDNI = new Label();
            lblDNI.Text = "DNI:";
            lblDNI.Location = new Point(20, 90);
            lblDNI.Size = new Size(120, 20);
            this.Controls.Add(lblDNI);

            txtDNI = new TextBox();
            txtDNI.Location = new Point(150, 88);
            txtDNI.Size = new Size(200, 20);
            this.Controls.Add(txtDNI);

            // Teléfono
            lblTelefono = new Label();
            lblTelefono.Text = "Teléfono:";
            lblTelefono.Location = new Point(20, 120);
            lblTelefono.Size = new Size(120, 20);
            this.Controls.Add(lblTelefono);

            txtTelefono = new TextBox();
            txtTelefono.Location = new Point(150, 118);
            txtTelefono.Size = new Size(200, 20);
            this.Controls.Add(txtTelefono);

            // Dirección
            lblDireccion = new Label();
            lblDireccion.Text = "Dirección:";
            lblDireccion.Location = new Point(20, 150);
            lblDireccion.Size = new Size(120, 20);
            this.Controls.Add(lblDireccion);

            txtDireccion = new TextBox();
            txtDireccion.Location = new Point(150, 148);
            txtDireccion.Size = new Size(200, 20);
            txtDireccion.Multiline = true;
            txtDireccion.Height = 40;
            this.Controls.Add(txtDireccion);

            // Botones
            btnGuardar = new Button();
            btnGuardar.Text = "Guardar";
            btnGuardar.Location = new Point(150, 210);
            btnGuardar.Size = new Size(80, 30);
            btnGuardar.Click += btnGuardar_Click;
            this.Controls.Add(btnGuardar);

            btnCancelar = new Button();
            btnCancelar.Text = "Cancelar";
            btnCancelar.Location = new Point(250, 210);
            btnCancelar.Size = new Size(80, 30);
            btnCancelar.Click += btnCancelar_Click;
            this.Controls.Add(btnCancelar);
        }

        private void CargarDatos()
        {
            txtNombre.Text = empleadoOriginal["Nombre"].ToString();
            txtDNI.Text = empleadoOriginal["DNI"].ToString();
            txtTelefono.Text = empleadoOriginal["Telefono"].ToString();
            txtDireccion.Text = empleadoOriginal["Direccion"].ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                ActualizarEmpleado();
            }
        }

        private bool ValidarDatos()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDNI.Text))
            {
                MessageBox.Show("El DNI es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDNI.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("El teléfono es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTelefono.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                MessageBox.Show("La dirección es obligatoria.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDireccion.Focus();
                return false;
            }

            return true;
        }

        private void ActualizarEmpleado()
        {
            try
            {
                using (SqlConnection conexion = conexionSQL.ObtenerConexion())
                {
                    if (conexion != null)
                    {
                        string query = @"UPDATE Empleados SET
                                    Nombre = @Nombre,
                                    DNI = @DNI,
                                    Telefono = @Telefono,
                                    Direccion = @Direccion
                                   WHERE EmpleadoID = @EmpleadoID";

                        SqlCommand cmd = new SqlCommand(query, conexion);
                        cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text.Trim());
                        cmd.Parameters.AddWithValue("@DNI", txtDNI.Text.Trim());
                        cmd.Parameters.AddWithValue("@Telefono", txtTelefono.Text.Trim());
                        cmd.Parameters.AddWithValue("@Direccion", txtDireccion.Text.Trim());
                        cmd.Parameters.AddWithValue("@EmpleadoID", empleadoId);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Empleado actualizado exitosamente.", "Éxito",
                                       MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar empleado: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
    #endregion
}