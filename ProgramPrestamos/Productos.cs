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
    public partial class Productos : Form
    {
        private ConexionSQL conexionSQL;
        private bool esEdicion = false;
        private int productoIdEdicion = 0;

        public Productos()
        {
            InitializeComponent();
            conexionSQL = new ConexionSQL();
            CargarProductos();
        }

        private void CargarProductos()
        {
            try
            {
                using (SqlConnection conexion = conexionSQL.ObtenerConexion())
                {
                    if (conexion != null)
                    {
                        string query = @"SELECT ProductoID, Nombre, PrecioBase, Stock 
                                       FROM Productos 
                                       WHERE Activo = 1 
                                       ORDER BY Nombre";

                        SqlDataAdapter adapter = new SqlDataAdapter(query, conexion);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        // Limpiar columnas existentes
                        dgvProductos.Columns.Clear();

                        // Agregar columnas manualmente
                        dgvProductos.Columns.Add("ProductoID", "ID");
                        dgvProductos.Columns.Add("Nombre", "Nombre");
                        dgvProductos.Columns.Add("PrecioBase", "Precio");
                        dgvProductos.Columns.Add("Stock", "Stock");

                        // Configurar columnas
                        dgvProductos.Columns["ProductoID"].Width = 60;
                        dgvProductos.Columns["Nombre"].Width = 200;
                        dgvProductos.Columns["PrecioBase"].Width = 100;
                        dgvProductos.Columns["Stock"].Width = 80;

                        // Agregar columna de botones Editar
                        DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn();
                        btnEditar.Name = "btnEditar";
                        btnEditar.HeaderText = "Editar";
                        btnEditar.Text = "Editar";
                        btnEditar.UseColumnTextForButtonValue = true;
                        btnEditar.Width = 80;
                        dgvProductos.Columns.Add(btnEditar);

                        // Agregar columna de botones Eliminar
                        DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn();
                        btnEliminar.Name = "btnEliminar";
                        btnEliminar.HeaderText = "Eliminar";
                        btnEliminar.Text = "Eliminar";
                        btnEliminar.UseColumnTextForButtonValue = true;
                        btnEliminar.Width = 80;
                        dgvProductos.Columns.Add(btnEliminar);

                        // Llenar datos
                        dgvProductos.Rows.Clear();
                        foreach (DataRow row in dt.Rows)
                        {
                            dgvProductos.Rows.Add(
                                row["ProductoID"],
                                row["Nombre"],
                                Convert.ToDecimal(row["PrecioBase"]).ToString("C"),
                                row["Stock"]
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar productos: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                if (esEdicion)
                {
                    ActualizarProducto();
                }
                else
                {
                    GuardarProducto();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            CambiarModoEdicion(false);
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre del producto es obligatorio.", "Validación",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPrecio.Text) || !decimal.TryParse(txtPrecio.Text, out decimal precio) || precio <= 0)
            {
                MessageBox.Show("Ingrese un precio válido mayor a 0.", "Validación",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecio.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtStock.Text) || !int.TryParse(txtStock.Text, out int stock) || stock < 0)
            {
                MessageBox.Show("Ingrese un stock válido (0 o mayor).", "Validación",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStock.Focus();
                return false;
            }

            return true;
        }

        private void GuardarProducto()
        {
            try
            {
                using (SqlConnection conexion = conexionSQL.ObtenerConexion())
                {
                    if (conexion != null)
                    {
                        string query = @"INSERT INTO Productos (Nombre, Descripcion, PrecioBase, Stock, Activo) 
                                       VALUES (@Nombre, @Descripcion, @PrecioBase, @Stock, 1)";

                        using (SqlCommand cmd = new SqlCommand(query, conexion))
                        {
                            cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text.Trim());
                            cmd.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text.Trim());
                            cmd.Parameters.AddWithValue("@PrecioBase", Convert.ToDecimal(txtPrecio.Text));
                            cmd.Parameters.AddWithValue("@Stock", Convert.ToInt32(txtStock.Text));

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Producto guardado exitosamente.", "Éxito",
                                           MessageBoxButtons.OK, MessageBoxIcon.Information);

                            LimpiarCampos();
                            CargarProductos();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar producto: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarProducto()
        {
            try
            {
                using (SqlConnection conexion = conexionSQL.ObtenerConexion())
                {
                    if (conexion != null)
                    {
                        string query = @"UPDATE Productos 
                                       SET Nombre = @Nombre, Descripcion = @Descripcion, 
                                           PrecioBase = @PrecioBase, Stock = @Stock 
                                       WHERE ProductoID = @ProductoID";

                        using (SqlCommand cmd = new SqlCommand(query, conexion))
                        {
                            cmd.Parameters.AddWithValue("@ProductoID", productoIdEdicion);
                            cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text.Trim());
                            cmd.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text.Trim());
                            cmd.Parameters.AddWithValue("@PrecioBase", Convert.ToDecimal(txtPrecio.Text));
                            cmd.Parameters.AddWithValue("@Stock", Convert.ToInt32(txtStock.Text));

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Producto actualizado exitosamente.", "Éxito",
                                           MessageBoxButtons.OK, MessageBoxIcon.Information);

                            LimpiarCampos();
                            CambiarModoEdicion(false);
                            CargarProductos();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar producto: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EliminarProducto(int productoId)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea eliminar este producto?",
                                                    "Confirmar eliminación",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conexion = conexionSQL.ObtenerConexion())
                    {
                        if (conexion != null)
                        {
                            string query = "UPDATE Productos SET Activo = 0 WHERE ProductoID = @ProductoID";

                            using (SqlCommand cmd = new SqlCommand(query, conexion))
                            {
                                cmd.Parameters.AddWithValue("@ProductoID", productoId);
                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Producto eliminado exitosamente.", "Éxito",
                                               MessageBoxButtons.OK, MessageBoxIcon.Information);

                                CargarProductos();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar producto: {ex.Message}", "Error",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CargarProductoParaEdicion(int productoId)
        {
            try
            {
                using (SqlConnection conexion = conexionSQL.ObtenerConexion())
                {
                    if (conexion != null)
                    {
                        string query = @"SELECT Nombre, Descripcion, PrecioBase, Stock 
                                       FROM Productos 
                                       WHERE ProductoID = @ProductoID AND Activo = 1";

                        using (SqlCommand cmd = new SqlCommand(query, conexion))
                        {
                            cmd.Parameters.AddWithValue("@ProductoID", productoId);

                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    txtNombre.Text = reader["Nombre"].ToString();
                                    txtDescripcion.Text = reader["Descripcion"].ToString();
                                    txtPrecio.Text = reader["PrecioBase"].ToString();
                                    txtStock.Text = reader["Stock"].ToString();

                                    productoIdEdicion = productoId;
                                    CambiarModoEdicion(true);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar producto para edición: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CambiarModoEdicion(bool edicion)
        {
            esEdicion = edicion;
            if (edicion)
            {
                btnGuardarProducto.Text = "🔄 Actualizar";
                btnGuardarProducto.BackColor = Color.FromArgb(230, 126, 34);
            }
            else
            {
                btnGuardarProducto.Text = "💾 Guardar Producto";
                btnGuardarProducto.BackColor = Color.FromArgb(41, 128, 185);
                productoIdEdicion = 0;
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
            txtNombre.Focus();
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int productoId = Convert.ToInt32(dgvProductos.Rows[e.RowIndex].Cells["ProductoID"].Value);

                if (e.ColumnIndex == dgvProductos.Columns["btnEditar"].Index)
                {
                    CargarProductoParaEdicion(productoId);
                }
                else if (e.ColumnIndex == dgvProductos.Columns["btnEliminar"].Index)
                {
                    EliminarProducto(productoId);
                }
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}