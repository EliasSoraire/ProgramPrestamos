namespace ProgramPrestamos
{
    partial class EstadoPrestamos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelHeader = new Panel();
            btnVolver = new Button();
            lblSubtitle = new Label();
            lblTitle = new Label();
            panelSearch = new Panel();
            panelBotonesBusqueda = new Panel();
            btnExportarExcel = new Button();
            btnLimpiarFiltros = new Button();
            btnBuscar = new Button();
            panelFiltrosLinea1 = new Panel();
            cmbEstado = new ComboBox();
            lblEstado = new Label();
            cmbTipoPrestamo = new ComboBox();
            lblTipoPrestamo = new Label();
            cmbEmpleado = new ComboBox();
            lblEmpleado = new Label();
            lblBusquedaAvanzada = new Label();
            panelStats = new Panel();
            lblTotalAtrasados = new Label();
            lblTotalVencidos = new Label();
            lblTotalPagados = new Label();
            lblTotalActivos = new Label();
            lblTotalPrestamos = new Label();
            panelData = new Panel();
            dataGridViewPrestamos = new DataGridView();
            panelAcciones = new Panel();
            btnModificarPrestamo = new Button();
            btnRegistrarPago = new Button();
            btnVerDetalles = new Button();
            lblAcciones = new Label();
            panelHeader.SuspendLayout();
            panelSearch.SuspendLayout();
            panelBotonesBusqueda.SuspendLayout();
            panelFiltrosLinea1.SuspendLayout();
            panelStats.SuspendLayout();
            panelData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPrestamos).BeginInit();
            panelAcciones.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(41, 53, 65);
            panelHeader.Controls.Add(btnVolver);
            panelHeader.Controls.Add(lblSubtitle);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1364, 80);
            panelHeader.TabIndex = 0;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.FromArgb(52, 73, 94);
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Segoe UI", 10F);
            btnVolver.ForeColor = Color.White;
            btnVolver.Location = new Point(1240, 18);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(120, 35);
            btnVolver.TabIndex = 2;
            btnVolver.Text = "← Volver";
            btnVolver.UseVisualStyleBackColor = false;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.FromArgb(189, 195, 199);
            lblSubtitle.Location = new Point(20, 50);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(370, 19);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Vista global para controlar todos los préstamos del sistema";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(290, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "📊 Estado de Préstamos";
            // 
            // panelSearch
            // 
            panelSearch.BackColor = Color.FromArgb(236, 240, 241);
            panelSearch.Controls.Add(panelBotonesBusqueda);
            panelSearch.Controls.Add(panelFiltrosLinea1);
            panelSearch.Controls.Add(lblBusquedaAvanzada);
            panelSearch.Dock = DockStyle.Top;
            panelSearch.Location = new Point(0, 80);
            panelSearch.Name = "panelSearch";
            panelSearch.Padding = new Padding(20, 18, 20, 18);
            panelSearch.Size = new Size(1364, 159);
            panelSearch.TabIndex = 1;
            // 
            // panelBotonesBusqueda
            // 
            panelBotonesBusqueda.Controls.Add(btnExportarExcel);
            panelBotonesBusqueda.Controls.Add(btnLimpiarFiltros);
            panelBotonesBusqueda.Controls.Add(btnBuscar);
            panelBotonesBusqueda.Location = new Point(1000, 97);
            panelBotonesBusqueda.Name = "panelBotonesBusqueda";
            panelBotonesBusqueda.Size = new Size(380, 44);
            panelBotonesBusqueda.TabIndex = 3;
            // 
            // btnExportarExcel
            // 
            btnExportarExcel.BackColor = Color.FromArgb(39, 174, 96);
            btnExportarExcel.FlatAppearance.BorderSize = 0;
            btnExportarExcel.FlatStyle = FlatStyle.Flat;
            btnExportarExcel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnExportarExcel.ForeColor = Color.White;
            btnExportarExcel.Location = new Point(240, 9);
            btnExportarExcel.Name = "btnExportarExcel";
            btnExportarExcel.Size = new Size(120, 31);
            btnExportarExcel.TabIndex = 2;
            btnExportarExcel.Text = "📊 Exportar";
            btnExportarExcel.UseVisualStyleBackColor = false;
            // 
            // btnLimpiarFiltros
            // 
            btnLimpiarFiltros.BackColor = Color.FromArgb(149, 165, 166);
            btnLimpiarFiltros.FlatAppearance.BorderSize = 0;
            btnLimpiarFiltros.FlatStyle = FlatStyle.Flat;
            btnLimpiarFiltros.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLimpiarFiltros.ForeColor = Color.White;
            btnLimpiarFiltros.Location = new Point(110, 9);
            btnLimpiarFiltros.Name = "btnLimpiarFiltros";
            btnLimpiarFiltros.Size = new Size(120, 31);
            btnLimpiarFiltros.TabIndex = 1;
            btnLimpiarFiltros.Text = "🗑️ Limpiar";
            btnLimpiarFiltros.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(52, 152, 219);
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(-20, 9);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(120, 31);
            btnBuscar.TabIndex = 0;
            btnBuscar.Text = "🔍 Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // panelFiltrosLinea1
            // 
            panelFiltrosLinea1.Controls.Add(cmbEstado);
            panelFiltrosLinea1.Controls.Add(lblEstado);
            panelFiltrosLinea1.Controls.Add(cmbTipoPrestamo);
            panelFiltrosLinea1.Controls.Add(lblTipoPrestamo);
            panelFiltrosLinea1.Controls.Add(cmbEmpleado);
            panelFiltrosLinea1.Controls.Add(lblEmpleado);
            panelFiltrosLinea1.Location = new Point(20, 46);
            panelFiltrosLinea1.Name = "panelFiltrosLinea1";
            panelFiltrosLinea1.Size = new Size(1360, 54);
            panelFiltrosLinea1.TabIndex = 1;
            // 
            // cmbEstado
            // 
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstado.Font = new Font("Segoe UI", 10F);
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Items.AddRange(new object[] { "Todos", "Activo", "Pagado", "Vencido", "Atrasado" });
            cmbEstado.Location = new Point(389, 22);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(150, 25);
            cmbEstado.TabIndex = 7;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEstado.ForeColor = Color.FromArgb(52, 73, 94);
            lblEstado.Location = new Point(409, 0);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(57, 19);
            lblEstado.TabIndex = 6;
            lblEstado.Text = "Estado:";
            // 
            // cmbTipoPrestamo
            // 
            cmbTipoPrestamo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoPrestamo.Font = new Font("Segoe UI", 10F);
            cmbTipoPrestamo.FormattingEnabled = true;
            cmbTipoPrestamo.Items.AddRange(new object[] { "Todos", "Efectivo", "Producto" });
            cmbTipoPrestamo.Location = new Point(220, 22);
            cmbTipoPrestamo.Name = "cmbTipoPrestamo";
            cmbTipoPrestamo.Size = new Size(150, 25);
            cmbTipoPrestamo.TabIndex = 5;
            // 
            // lblTipoPrestamo
            // 
            lblTipoPrestamo.AutoSize = true;
            lblTipoPrestamo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTipoPrestamo.ForeColor = Color.FromArgb(52, 73, 94);
            lblTipoPrestamo.Location = new Point(230, 0);
            lblTipoPrestamo.Name = "lblTipoPrestamo";
            lblTipoPrestamo.Size = new Size(111, 19);
            lblTipoPrestamo.TabIndex = 4;
            lblTipoPrestamo.Text = "Tipo Préstamo:";
            // 
            // cmbEmpleado
            // 
            cmbEmpleado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEmpleado.Font = new Font("Segoe UI", 10F);
            cmbEmpleado.FormattingEnabled = true;
            cmbEmpleado.Location = new Point(3, 22);
            cmbEmpleado.Name = "cmbEmpleado";
            cmbEmpleado.Size = new Size(200, 25);
            cmbEmpleado.TabIndex = 3;
            // 
            // lblEmpleado
            // 
            lblEmpleado.AutoSize = true;
            lblEmpleado.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEmpleado.ForeColor = Color.FromArgb(52, 73, 94);
            lblEmpleado.Location = new Point(3, 0);
            lblEmpleado.Name = "lblEmpleado";
            lblEmpleado.Size = new Size(80, 19);
            lblEmpleado.TabIndex = 2;
            lblEmpleado.Text = "Empleado:";
            // 
            // lblBusquedaAvanzada
            // 
            lblBusquedaAvanzada.AutoSize = true;
            lblBusquedaAvanzada.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblBusquedaAvanzada.ForeColor = Color.FromArgb(52, 73, 94);
            lblBusquedaAvanzada.Location = new Point(20, 18);
            lblBusquedaAvanzada.Name = "lblBusquedaAvanzada";
            lblBusquedaAvanzada.Size = new Size(218, 25);
            lblBusquedaAvanzada.TabIndex = 0;
            lblBusquedaAvanzada.Text = "🔍 Búsqueda Avanzada";
            // 
            // panelStats
            // 
            panelStats.BackColor = Color.FromArgb(236, 240, 241);
            panelStats.Controls.Add(lblTotalAtrasados);
            panelStats.Controls.Add(lblTotalVencidos);
            panelStats.Controls.Add(lblTotalPagados);
            panelStats.Controls.Add(lblTotalActivos);
            panelStats.Controls.Add(lblTotalPrestamos);
            panelStats.Dock = DockStyle.Top;
            panelStats.Location = new Point(0, 239);
            panelStats.Name = "panelStats";
            panelStats.Padding = new Padding(20, 18, 20, 18);
            panelStats.Size = new Size(1364, 71);
            panelStats.TabIndex = 2;
            // 
            // lblTotalAtrasados
            // 
            lblTotalAtrasados.AutoSize = true;
            lblTotalAtrasados.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTotalAtrasados.ForeColor = Color.FromArgb(231, 76, 60);
            lblTotalAtrasados.Location = new Point(700, 26);
            lblTotalAtrasados.Name = "lblTotalAtrasados";
            lblTotalAtrasados.Size = new Size(127, 21);
            lblTotalAtrasados.TabIndex = 4;
            lblTotalAtrasados.Text = "Atrasados: 0 🚨";
            // 
            // lblTotalVencidos
            // 
            lblTotalVencidos.AutoSize = true;
            lblTotalVencidos.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTotalVencidos.ForeColor = Color.FromArgb(230, 126, 34);
            lblTotalVencidos.Location = new Point(550, 26);
            lblTotalVencidos.Name = "lblTotalVencidos";
            lblTotalVencidos.Size = new Size(123, 21);
            lblTotalVencidos.TabIndex = 3;
            lblTotalVencidos.Text = "Vencidos: 0 ⚠️";
            // 
            // lblTotalPagados
            // 
            lblTotalPagados.AutoSize = true;
            lblTotalPagados.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTotalPagados.ForeColor = Color.FromArgb(39, 174, 96);
            lblTotalPagados.Location = new Point(400, 26);
            lblTotalPagados.Name = "lblTotalPagados";
            lblTotalPagados.Size = new Size(119, 21);
            lblTotalPagados.TabIndex = 2;
            lblTotalPagados.Text = "Pagados: 0 ✅";
            // 
            // lblTotalActivos
            // 
            lblTotalActivos.AutoSize = true;
            lblTotalActivos.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTotalActivos.ForeColor = Color.FromArgb(52, 152, 219);
            lblTotalActivos.Location = new Point(250, 26);
            lblTotalActivos.Name = "lblTotalActivos";
            lblTotalActivos.Size = new Size(109, 21);
            lblTotalActivos.TabIndex = 1;
            lblTotalActivos.Text = "Activos: 0 ⚡";
            // 
            // lblTotalPrestamos
            // 
            lblTotalPrestamos.AutoSize = true;
            lblTotalPrestamos.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTotalPrestamos.ForeColor = Color.FromArgb(52, 73, 94);
            lblTotalPrestamos.Location = new Point(20, 26);
            lblTotalPrestamos.Name = "lblTotalPrestamos";
            lblTotalPrestamos.Size = new Size(172, 21);
            lblTotalPrestamos.TabIndex = 0;
            lblTotalPrestamos.Text = "Total Préstamos: 0 💰";
            // 
            // panelData
            // 
            panelData.BackColor = Color.White;
            panelData.Controls.Add(dataGridViewPrestamos);
            panelData.Dock = DockStyle.Fill;
            panelData.Location = new Point(0, 310);
            panelData.Name = "panelData";
            panelData.Padding = new Padding(20, 18, 20, 18);
            panelData.Size = new Size(1364, 289);
            panelData.TabIndex = 3;
            // 
            // dataGridViewPrestamos
            // 
            dataGridViewPrestamos.AllowUserToAddRows = false;
            dataGridViewPrestamos.AllowUserToDeleteRows = false;
            dataGridViewPrestamos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPrestamos.BackgroundColor = Color.White;
            dataGridViewPrestamos.BorderStyle = BorderStyle.None;
            dataGridViewPrestamos.ColumnHeadersHeight = 35;
            dataGridViewPrestamos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewPrestamos.Dock = DockStyle.Fill;
            dataGridViewPrestamos.Location = new Point(20, 18);
            dataGridViewPrestamos.MultiSelect = false;
            dataGridViewPrestamos.Name = "dataGridViewPrestamos";
            dataGridViewPrestamos.ReadOnly = true;
            dataGridViewPrestamos.RowHeadersVisible = false;
            dataGridViewPrestamos.RowTemplate.Height = 30;
            dataGridViewPrestamos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPrestamos.Size = new Size(1324, 253);
            dataGridViewPrestamos.TabIndex = 0;
            // 
            // panelAcciones
            // 
            panelAcciones.BackColor = Color.FromArgb(236, 240, 241);
            panelAcciones.Controls.Add(btnModificarPrestamo);
            panelAcciones.Controls.Add(btnRegistrarPago);
            panelAcciones.Controls.Add(btnVerDetalles);
            panelAcciones.Controls.Add(lblAcciones);
            panelAcciones.Dock = DockStyle.Bottom;
            panelAcciones.Location = new Point(0, 599);
            panelAcciones.Name = "panelAcciones";
            panelAcciones.Padding = new Padding(20, 18, 20, 18);
            panelAcciones.Size = new Size(1364, 62);
            panelAcciones.TabIndex = 4;
            // 
            // btnModificarPrestamo
            // 
            btnModificarPrestamo.BackColor = Color.FromArgb(230, 126, 34);
            btnModificarPrestamo.FlatAppearance.BorderSize = 0;
            btnModificarPrestamo.FlatStyle = FlatStyle.Flat;
            btnModificarPrestamo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnModificarPrestamo.ForeColor = Color.White;
            btnModificarPrestamo.Location = new Point(300, 31);
            btnModificarPrestamo.Name = "btnModificarPrestamo";
            btnModificarPrestamo.Size = new Size(130, 26);
            btnModificarPrestamo.TabIndex = 3;
            btnModificarPrestamo.Text = "✏️ Modificar";
            btnModificarPrestamo.UseVisualStyleBackColor = false;
            // 
            // btnRegistrarPago
            // 
            btnRegistrarPago.BackColor = Color.FromArgb(39, 174, 96);
            btnRegistrarPago.FlatAppearance.BorderSize = 0;
            btnRegistrarPago.FlatStyle = FlatStyle.Flat;
            btnRegistrarPago.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRegistrarPago.ForeColor = Color.White;
            btnRegistrarPago.Location = new Point(160, 31);
            btnRegistrarPago.Name = "btnRegistrarPago";
            btnRegistrarPago.Size = new Size(130, 26);
            btnRegistrarPago.TabIndex = 2;
            btnRegistrarPago.Text = "💰 Registrar Pago";
            btnRegistrarPago.UseVisualStyleBackColor = false;
            // 
            // btnVerDetalles
            // 
            btnVerDetalles.BackColor = Color.FromArgb(52, 152, 219);
            btnVerDetalles.FlatAppearance.BorderSize = 0;
            btnVerDetalles.FlatStyle = FlatStyle.Flat;
            btnVerDetalles.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnVerDetalles.ForeColor = Color.White;
            btnVerDetalles.Location = new Point(20, 31);
            btnVerDetalles.Name = "btnVerDetalles";
            btnVerDetalles.Size = new Size(130, 26);
            btnVerDetalles.TabIndex = 1;
            btnVerDetalles.Text = "👁️ Ver Detalles";
            btnVerDetalles.UseVisualStyleBackColor = false;
            // 
            // lblAcciones
            // 
            lblAcciones.AutoSize = true;
            lblAcciones.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblAcciones.ForeColor = Color.FromArgb(52, 73, 94);
            lblAcciones.Location = new Point(20, 9);
            lblAcciones.Name = "lblAcciones";
            lblAcciones.Size = new Size(308, 21);
            lblAcciones.TabIndex = 0;
            lblAcciones.Text = "Acciones sobre préstamo seleccionado:";
            // 
            // EstadoPrestamos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 240, 241);
            ClientSize = new Size(1364, 661);
            Controls.Add(panelData);
            Controls.Add(panelAcciones);
            Controls.Add(panelStats);
            Controls.Add(panelSearch);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "EstadoPrestamos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Estado de Préstamos";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelSearch.ResumeLayout(false);
            panelSearch.PerformLayout();
            panelBotonesBusqueda.ResumeLayout(false);
            panelFiltrosLinea1.ResumeLayout(false);
            panelFiltrosLinea1.PerformLayout();
            panelStats.ResumeLayout(false);
            panelStats.PerformLayout();
            panelData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewPrestamos).EndInit();
            panelAcciones.ResumeLayout(false);
            panelAcciones.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblSubtitle;
        private Label lblTitle;
        private Button btnVolver;
        private Panel panelSearch;
        private Label lblBusquedaAvanzada;
        private Panel panelFiltrosLinea1;
        private ComboBox cmbEmpleado;
        private Label lblEmpleado;
        private ComboBox cmbTipoPrestamo;
        private Label lblTipoPrestamo;
        private ComboBox cmbEstado;
        private Label lblEstado;
        private Panel panelBotonesBusqueda;
        private Button btnBuscar;
        private Button btnLimpiarFiltros;
        private Button btnExportarExcel;
        private Panel panelStats;
        private Label lblTotalPrestamos;
        private Label lblTotalActivos;
        private Label lblTotalPagados;
        private Label lblTotalVencidos;
        private Label lblTotalAtrasados;
        private Panel panelData;
        private DataGridView dataGridViewPrestamos;
        private Panel panelAcciones;
        private Label lblAcciones;
        private Button btnVerDetalles;
        private Button btnRegistrarPago;
        private Button btnModificarPrestamo;
    }
}