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
    public partial class Clientes : Form
    {
        private ConexionSQL conexionSQL;
        private bool modoEdicion = false;
        private int clienteIdEditando = 0;

        public Clientes()
        {
            InitializeComponent();
            conexionSQL = new ConexionSQL();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            ConfigurarDataGridView();
            CargarEmpleados();
            CargarClientes();
        }

        private void ConfigurarDataGridView()
        {
            dgvClientes.AutoGenerateColumns = false;
            dgvClientes.Columns.Clear();

            // Columna oculta para ID
            DataGridViewTextBoxColumn colId = new DataGridViewTextBoxColumn();
            colId.Name = "ClienteID";
            colId.HeaderText = "ID";
            colId.DataPropertyName = "ClienteID";
            colId.Visible = false;
            dgvClientes.Columns.Add(colId);

            // Columna Nombre Completo
            DataGridViewTextBoxColumn colNombre = new DataGridViewTextBoxColumn();
            colNombre.Name = "Nombre";
            colNombre.HeaderText = "Nombre Completo";
            colNombre.DataPropertyName = "Nombre";
            colNombre.Width = 150;
            dgvClientes.Columns.Add(colNombre);

            // Columna DNI
            DataGridViewTextBoxColumn colDNI = new DataGridViewTextBoxColumn();
            colDNI.Name = "DNI";
            colDNI.HeaderText = "DNI";
            colDNI.DataPropertyName = "DNI";
            colDNI.Width = 80;
            dgvClientes.Columns.Add(colDNI);

            // Columna Teléfono
            DataGridViewTextBoxColumn colTelefono = new DataGridViewTextBoxColumn();
            colTelefono.Name = "Telefono";
            colTelefono.HeaderText = "Teléfono";
            colTelefono.DataPropertyName = "Telefono";
            colTelefono.Width = 120;
            dgvClientes.Columns.Add(colTelefono);

            // Columna Empleado Asignado
            DataGridViewTextBoxColumn colEmpleado = new DataGridViewTextBoxColumn();
            colEmpleado.Name = "EmpleadoNombre";
            colEmpleado.HeaderText = "Empleado Asignado";
            colEmpleado.DataPropertyName = "EmpleadoNombre";
            colEmpleado.Width = 120;
            dgvClientes.Columns.Add(colEmpleado);

            // Botón Editar
            DataGridViewButtonColumn colEditar = new DataGridViewButtonColumn();
            colEditar.Name = "Editar";
            colEditar.HeaderText = "Editar";
            colEditar.Text = "✏️";
            colEditar.UseColumnTextForButtonValue = true;
            colEditar.Width = 50;
            dgvClientes.Columns.Add(colEditar);

            // Botón Eliminar
            DataGridViewButtonColumn colEliminar = new DataGridViewButtonColumn();
            colEliminar.Name = "Eliminar";
            colEliminar.HeaderText = "Eliminar";
            colEliminar.Text = "🗑️";
            colEliminar.UseColumnTextForButtonValue = true;
            colEliminar.Width = 50;
            dgvClientes.Columns.Add(colEliminar);
        }

        private void CargarEmpleados()
        {
            try
            {
                using (SqlConnection conexion = conexionSQL.ObtenerConexion())
                {
                    if (conexion != null)
                    {
                        string query = "SELECT EmpleadoID, Nombre FROM Empleados WHERE Activo = 1 ORDER BY Nombre";
                        using (SqlCommand cmd = new SqlCommand(query, conexion))
                        {
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                cmbEmpleadoAsignado.Items.Clear();
                                cmbEmpleadoAsignado.DisplayMember = "Text";
                                cmbEmpleadoAsignado.ValueMember = "Value";

                                while (reader.Read())
                                {
                                    cmbEmpleadoAsignado.Items.Add(new
                                    {
                                        Text = reader["Nombre"].ToString(),
                                        Value = Convert.ToInt32(reader["EmpleadoID"])
                                    });
                                }
                            }
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

        private void CargarClientes(string filtro = "")
        {
            try
            {
                using (SqlConnection conexion = conexionSQL.ObtenerConexion())
                {
                    if (conexion != null)
                    {
                        string query = @"
                            SELECT c.ClienteID, c.Nombre, c.DNI, c.Telefono, c.DomicilioCasa, 
                                   c.DomicilioComercial, c.EmpleadoAsignado, e.Nombre as EmpleadoNombre
                            FROM Clientes c
                            LEFT JOIN Empleados e ON c.EmpleadoAsignado = e.EmpleadoID
                            WHERE c.Activo = 1";

                        if (!string.IsNullOrEmpty(filtro))
                        {
                            query += " AND (c.Nombre LIKE @filtro OR c.DNI LIKE @filtro)";
                        }

                        query += " ORDER BY c.Nombre";

                        using (SqlCommand cmd = new SqlCommand(query, conexion))
                        {
                            if (!string.IsNullOrEmpty(filtro))
                            {
                                cmd.Parameters.AddWithValue("@filtro", "%" + filtro + "%");
                            }

                            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                            {
                                DataTable dt = new DataTable();
                                adapter.Fill(dt);
                                dgvClientes.DataSource = dt;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar clientes: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarClientes(txtBuscar.Text.Trim());
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string columnName = dgvClientes.Columns[e.ColumnIndex].Name;

                if (columnName == "Editar")
                {
                    EditarCliente(e.RowIndex);
                }
                else if (columnName == "Eliminar")
                {
                    EliminarCliente(e.RowIndex);
                }
            }
        }

        private void EditarCliente(int rowIndex)
        {
            try
            {
                DataGridViewRow row = dgvClientes.Rows[rowIndex];

                clienteIdEditando = Convert.ToInt32(row.Cells["ClienteID"].Value);
                txtNombreApellido.Text = row.Cells["Nombre"].Value?.ToString() ?? "";
                txtDNI.Text = row.Cells["DNI"].Value?.ToString() ?? "";
                txtTelefono.Text = row.Cells["Telefono"].Value?.ToString() ?? "";

                using (SqlConnection conexion = conexionSQL.ObtenerConexion())
                {
                    if (conexion != null)
                    {
                        string query = "SELECT DomicilioCasa, DomicilioComercial, EmpleadoAsignado FROM Clientes WHERE ClienteID = @id";
                        using (SqlCommand cmd = new SqlCommand(query, conexion))
                        {
                            cmd.Parameters.AddWithValue("@id", clienteIdEditando);
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    txtDomicilioParticular.Text = reader["DomicilioCasa"]?.ToString() ?? "";
                                    txtDomicilioComercial.Text = reader["DomicilioComercial"]?.ToString() ?? "";

                                    int empleadoId = reader["EmpleadoAsignado"] != DBNull.Value ?
                                                   Convert.ToInt32(reader["EmpleadoAsignado"]) : 0;

                                    // Seleccionar empleado en combobox
                                    for (int i = 0; i < cmbEmpleadoAsignado.Items.Count; i++)
                                    {
                                        dynamic item = cmbEmpleadoAsignado.Items[i];
                                        if (item.Value == empleadoId)
                                        {
                                            cmbEmpleadoAsignado.SelectedIndex = i;
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

                modoEdicion = true;
                btnGuardar.Text = "🔄 Actualizar";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar datos del cliente: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EliminarCliente(int rowIndex)
        {
            try
            {
                DataGridViewRow row = dgvClientes.Rows[rowIndex];
                int clienteId = Convert.ToInt32(row.Cells["ClienteID"].Value);
                string nombreCliente = row.Cells["Nombre"].Value?.ToString() ?? "";

                DialogResult resultado = MessageBox.Show(
                    $"¿Está seguro que desea eliminar al cliente '{nombreCliente}'?\n\nEsta acción no se puede deshacer.",
                    "Confirmar Eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    using (SqlConnection conexion = conexionSQL.ObtenerConexion())
                    {
                        if (conexion != null)
                        {
                            string query = "UPDATE Clientes SET Activo = 0 WHERE ClienteID = @id";
                            using (SqlCommand cmd = new SqlCommand(query, conexion))
                            {
                                cmd.Parameters.AddWithValue("@id", clienteId);
                                int filasAfectadas = cmd.ExecuteNonQuery();

                                if (filasAfectadas > 0)
                                {
                                    MessageBox.Show("Cliente eliminado correctamente.", "Éxito",
                                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    CargarClientes(txtBuscar.Text.Trim());
                                }
                                else
                                {
                                    MessageBox.Show("No se pudo eliminar el cliente.", "Error",
                                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar cliente: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (modoEdicion)
                {
                    ActualizarCliente();
                }
                else
                {
                    GuardarNuevoCliente();
                }
            }
        }

        private bool ValidarDatos()
        {
            if (string.IsNullOrWhiteSpace(txtNombreApellido.Text))
            {
                MessageBox.Show("El nombre y apellido es obligatorio.", "Validación",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombreApellido.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDNI.Text))
            {
                MessageBox.Show("El DNI es obligatorio.", "Validación",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDNI.Focus();
                return false;
            }

            if (txtDNI.Text.Length < 7 || txtDNI.Text.Length > 8)
            {
                MessageBox.Show("El DNI debe tener entre 7 y 8 dígitos.", "Validación",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDNI.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("El teléfono es obligatorio.", "Validación",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTelefono.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDomicilioParticular.Text))
            {
                MessageBox.Show("El domicilio particular es obligatorio.", "Validación",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDomicilioParticular.Focus();
                return false;
            }

            if (cmbEmpleadoAsignado.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un empleado asignado.", "Validación",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbEmpleadoAsignado.Focus();
                return false;
            }

            // Validar DNI único
            if (!ValidarDNIUnico())
            {
                MessageBox.Show("Ya existe un cliente con este DNI.", "Validación",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDNI.Focus();
                return false;
            }

            return true;
        }

        private bool ValidarDNIUnico()
        {
            try
            {
                using (SqlConnection conexion = conexionSQL.ObtenerConexion())
                {
                    if (conexion != null)
                    {
                        string query = "SELECT COUNT(*) FROM Clientes WHERE DNI = @dni AND Activo = 1";

                        if (modoEdicion)
                        {
                            query += " AND ClienteID != @clienteId";
                        }

                        using (SqlCommand cmd = new SqlCommand(query, conexion))
                        {
                            cmd.Parameters.AddWithValue("@dni", txtDNI.Text.Trim());

                            if (modoEdicion)
                            {
                                cmd.Parameters.AddWithValue("@clienteId", clienteIdEditando);
                            }

                            int count = Convert.ToInt32(cmd.ExecuteScalar());
                            return count == 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al validar DNI: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        private void GuardarNuevoCliente()
        {
            try
            {
                using (SqlConnection conexion = conexionSQL.ObtenerConexion())
                {
                    if (conexion != null)
                    {
                        string query = @"
                            INSERT INTO Clientes (Nombre, DNI, Telefono, DomicilioCasa, DomicilioComercial, 
                                                 EmpleadoAsignado, FechaRegistro, Activo)
                            VALUES (@nombre, @dni, @telefono, @domicilioCasa, @domicilioComercial, 
                                   @empleadoAsignado, @fechaRegistro, 1)";

                        using (SqlCommand cmd = new SqlCommand(query, conexion))
                        {
                            cmd.Parameters.AddWithValue("@nombre", txtNombreApellido.Text.Trim());
                            cmd.Parameters.AddWithValue("@dni", txtDNI.Text.Trim());
                            cmd.Parameters.AddWithValue("@telefono", txtTelefono.Text.Trim());
                            cmd.Parameters.AddWithValue("@domicilioCasa", txtDomicilioParticular.Text.Trim());
                            cmd.Parameters.AddWithValue("@domicilioComercial",
                                string.IsNullOrWhiteSpace(txtDomicilioComercial.Text) ?
                                (object)DBNull.Value : txtDomicilioComercial.Text.Trim());

                            dynamic empleadoSeleccionado = cmbEmpleadoAsignado.SelectedItem;
                            cmd.Parameters.AddWithValue("@empleadoAsignado", empleadoSeleccionado.Value);
                            cmd.Parameters.AddWithValue("@fechaRegistro", DateTime.Now);

                            int filasAfectadas = cmd.ExecuteNonQuery();

                            if (filasAfectadas > 0)
                            {
                                MessageBox.Show("Cliente guardado correctamente.", "Éxito",
                                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LimpiarFormulario();
                                CargarClientes(txtBuscar.Text.Trim());
                            }
                            else
                            {
                                MessageBox.Show("No se pudo guardar el cliente.", "Error",
                                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar cliente: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarCliente()
        {
            try
            {
                using (SqlConnection conexion = conexionSQL.ObtenerConexion())
                {
                    if (conexion != null)
                    {
                        string query = @"
                            UPDATE Clientes 
                            SET Nombre = @nombre, DNI = @dni, Telefono = @telefono, 
                                DomicilioCasa = @domicilioCasa, DomicilioComercial = @domicilioComercial, 
                                EmpleadoAsignado = @empleadoAsignado
                            WHERE ClienteID = @clienteId";

                        using (SqlCommand cmd = new SqlCommand(query, conexion))
                        {
                            cmd.Parameters.AddWithValue("@nombre", txtNombreApellido.Text.Trim());
                            cmd.Parameters.AddWithValue("@dni", txtDNI.Text.Trim());
                            cmd.Parameters.AddWithValue("@telefono", txtTelefono.Text.Trim());
                            cmd.Parameters.AddWithValue("@domicilioCasa", txtDomicilioParticular.Text.Trim());
                            cmd.Parameters.AddWithValue("@domicilioComercial",
                                string.IsNullOrWhiteSpace(txtDomicilioComercial.Text) ?
                                (object)DBNull.Value : txtDomicilioComercial.Text.Trim());

                            dynamic empleadoSeleccionado = cmbEmpleadoAsignado.SelectedItem;
                            cmd.Parameters.AddWithValue("@empleadoAsignado", empleadoSeleccionado.Value);
                            cmd.Parameters.AddWithValue("@clienteId", clienteIdEditando);

                            int filasAfectadas = cmd.ExecuteNonQuery();

                            if (filasAfectadas > 0)
                            {
                                MessageBox.Show("Cliente actualizado correctamente.", "Éxito",
                                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LimpiarFormulario();
                                CargarClientes(txtBuscar.Text.Trim());
                            }
                            else
                            {
                                MessageBox.Show("No se pudo actualizar el cliente.", "Error",
                                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar cliente: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            txtNombreApellido.Clear();
            txtDNI.Clear();
            txtTelefono.Clear();
            txtDomicilioParticular.Clear();
            txtDomicilioComercial.Clear();
            cmbEmpleadoAsignado.SelectedIndex = -1;

            modoEdicion = false;
            clienteIdEditando = 0;
            btnGuardar.Text = "💾 Guardar";

            txtNombreApellido.Focus();
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo permitir números y teclas de control
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
