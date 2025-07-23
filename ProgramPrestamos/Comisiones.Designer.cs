namespace ProgramPrestamos
{
    partial class Comisiones
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
            lblSubtitle = new Label();
            lblTitle = new Label();
            btnVolver = new Button();
            panelMain = new Panel();
            panelComisionesContent = new Panel();
            panelSeleccionEmpleado = new Panel();
            cmbEmpleados = new ComboBox();
            lblSeleccionEmpleado = new Label();
            panelConfiguracionComision = new Panel();
            btnGuardarPorcentaje = new Button();
            numericUpDownPorcentajeProductos = new NumericUpDown();
            lblPorcentajeProductos = new Label();
            numericUpDownPorcentajeEfectivo = new NumericUpDown();
            lblPorcentajeEfectivo = new Label();
            lblConfiguracionComision = new Label();
            panelPrestamosPendientes = new Panel();
            dgvPrestamosPendientes = new DataGridView();
            lblPrestamosPendientes = new Label();
            panelResumen = new Panel();
            panelComisionProductos = new Panel();
            lblComisionProductos = new Label();
            lblTotalProductos = new Label();
            lblComisionProductosTitle = new Label();
            panelComisionEfectivo = new Panel();
            lblComisionEfectivo = new Label();
            lblTotalEfectivo = new Label();
            lblComisionEfectivoTitle = new Label();
            panelAcciones = new Panel();
            btnDescargarPDFSemanal = new Button();
            btnGenerarPDFDetallado = new Button();
            btnMarcarComoPagado = new Button();
            lblTotalPagar = new Label();
            panelHeader.SuspendLayout();
            panelMain.SuspendLayout();
            panelComisionesContent.SuspendLayout();
            panelSeleccionEmpleado.SuspendLayout();
            panelConfiguracionComision.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPorcentajeProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPorcentajeEfectivo).BeginInit();
            panelPrestamosPendientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPrestamosPendientes).BeginInit();
            panelResumen.SuspendLayout();
            panelComisionProductos.SuspendLayout();
            panelComisionEfectivo.SuspendLayout();
            panelAcciones.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(41, 53, 65);
            panelHeader.Controls.Add(lblSubtitle);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Controls.Add(btnVolver);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1200, 91);
            panelHeader.TabIndex = 0;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.FromArgb(189, 195, 199);
            lblSubtitle.Location = new Point(20, 57);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(306, 19);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Gestión de comisiones pendientes por empleado";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 17);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(186, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "💼 Comisiones";
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.FromArgb(52, 73, 94);
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Segoe UI", 10F);
            btnVolver.ForeColor = Color.White;
            btnVolver.Location = new Point(1059, 25);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(120, 40);
            btnVolver.TabIndex = 2;
            btnVolver.Text = "← Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(236, 240, 241);
            panelMain.Controls.Add(panelComisionesContent);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 91);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(20);
            panelMain.Size = new Size(1200, 609);
            panelMain.TabIndex = 1;
            // 
            // panelComisionesContent
            // 
            panelComisionesContent.BackColor = Color.White;
            panelComisionesContent.Controls.Add(panelSeleccionEmpleado);
            panelComisionesContent.Controls.Add(panelConfiguracionComision);
            panelComisionesContent.Controls.Add(panelPrestamosPendientes);
            panelComisionesContent.Controls.Add(panelResumen);
            panelComisionesContent.Controls.Add(panelAcciones);
            panelComisionesContent.Location = new Point(20, 1);
            panelComisionesContent.Name = "panelComisionesContent";
            panelComisionesContent.Padding = new Padding(20);
            panelComisionesContent.Size = new Size(1160, 569);
            panelComisionesContent.TabIndex = 0;
            // 
            // panelSeleccionEmpleado
            // 
            panelSeleccionEmpleado.BackColor = Color.FromArgb(236, 240, 241);
            panelSeleccionEmpleado.Controls.Add(cmbEmpleados);
            panelSeleccionEmpleado.Controls.Add(lblSeleccionEmpleado);
            panelSeleccionEmpleado.Location = new Point(20, 0);
            panelSeleccionEmpleado.Name = "panelSeleccionEmpleado";
            panelSeleccionEmpleado.Padding = new Padding(15);
            panelSeleccionEmpleado.Size = new Size(1120, 70);
            panelSeleccionEmpleado.TabIndex = 0;
            // 
            // cmbEmpleados
            // 
            cmbEmpleados.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEmpleados.Font = new Font("Segoe UI", 10F);
            cmbEmpleados.FormattingEnabled = true;
            cmbEmpleados.Location = new Point(15, 35);
            cmbEmpleados.Name = "cmbEmpleados";
            cmbEmpleados.Size = new Size(400, 25);
            cmbEmpleados.TabIndex = 1;
            cmbEmpleados.SelectedIndexChanged += cmbEmpleados_SelectedIndexChanged;
            // 
            // lblSeleccionEmpleado
            // 
            lblSeleccionEmpleado.AutoSize = true;
            lblSeleccionEmpleado.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblSeleccionEmpleado.ForeColor = Color.FromArgb(52, 73, 94);
            lblSeleccionEmpleado.Location = new Point(15, 15);
            lblSeleccionEmpleado.Name = "lblSeleccionEmpleado";
            lblSeleccionEmpleado.Size = new Size(203, 21);
            lblSeleccionEmpleado.TabIndex = 0;
            lblSeleccionEmpleado.Text = "👤 Seleccionar Empleado";
            // 
            // panelConfiguracionComision
            // 
            panelConfiguracionComision.BackColor = Color.FromArgb(236, 240, 241);
            panelConfiguracionComision.Controls.Add(btnGuardarPorcentaje);
            panelConfiguracionComision.Controls.Add(numericUpDownPorcentajeProductos);
            panelConfiguracionComision.Controls.Add(lblPorcentajeProductos);
            panelConfiguracionComision.Controls.Add(numericUpDownPorcentajeEfectivo);
            panelConfiguracionComision.Controls.Add(lblPorcentajeEfectivo);
            panelConfiguracionComision.Controls.Add(lblConfiguracionComision);
            panelConfiguracionComision.Location = new Point(20, 70);
            panelConfiguracionComision.Name = "panelConfiguracionComision";
            panelConfiguracionComision.Padding = new Padding(15);
            panelConfiguracionComision.Size = new Size(1120, 70);
            panelConfiguracionComision.TabIndex = 1;
            // 
            // btnGuardarPorcentaje
            // 
            btnGuardarPorcentaje.BackColor = Color.FromArgb(52, 152, 219);
            btnGuardarPorcentaje.FlatAppearance.BorderSize = 0;
            btnGuardarPorcentaje.FlatStyle = FlatStyle.Flat;
            btnGuardarPorcentaje.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGuardarPorcentaje.ForeColor = Color.White;
            btnGuardarPorcentaje.Location = new Point(650, 25);
            btnGuardarPorcentaje.Name = "btnGuardarPorcentaje";
            btnGuardarPorcentaje.Size = new Size(100, 30);
            btnGuardarPorcentaje.TabIndex = 5;
            btnGuardarPorcentaje.Text = "💾 Guardar";
            btnGuardarPorcentaje.UseVisualStyleBackColor = false;
            btnGuardarPorcentaje.Click += btnGuardarPorcentaje_Click;
            // 
            // numericUpDownPorcentajeProductos
            // 
            numericUpDownPorcentajeProductos.DecimalPlaces = 1;
            numericUpDownPorcentajeProductos.Font = new Font("Segoe UI", 10F);
            numericUpDownPorcentajeProductos.Location = new Point(550, 30);
            numericUpDownPorcentajeProductos.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            numericUpDownPorcentajeProductos.Name = "numericUpDownPorcentajeProductos";
            numericUpDownPorcentajeProductos.Size = new Size(70, 25);
            numericUpDownPorcentajeProductos.TabIndex = 4;
            numericUpDownPorcentajeProductos.Value = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownPorcentajeProductos.ValueChanged += numericUpDown_ValueChanged;
            // 
            // lblPorcentajeProductos
            // 
            lblPorcentajeProductos.AutoSize = true;
            lblPorcentajeProductos.Font = new Font("Segoe UI", 10F);
            lblPorcentajeProductos.ForeColor = Color.FromArgb(52, 73, 94);
            lblPorcentajeProductos.Location = new Point(430, 32);
            lblPorcentajeProductos.Name = "lblPorcentajeProductos";
            lblPorcentajeProductos.Size = new Size(109, 19);
            lblPorcentajeProductos.TabIndex = 3;
            lblPorcentajeProductos.Text = "% Productos (%)";
            // 
            // numericUpDownPorcentajeEfectivo
            // 
            numericUpDownPorcentajeEfectivo.DecimalPlaces = 1;
            numericUpDownPorcentajeEfectivo.Font = new Font("Segoe UI", 10F);
            numericUpDownPorcentajeEfectivo.Location = new Point(330, 30);
            numericUpDownPorcentajeEfectivo.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            numericUpDownPorcentajeEfectivo.Name = "numericUpDownPorcentajeEfectivo";
            numericUpDownPorcentajeEfectivo.Size = new Size(70, 25);
            numericUpDownPorcentajeEfectivo.TabIndex = 2;
            numericUpDownPorcentajeEfectivo.Value = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownPorcentajeEfectivo.ValueChanged += numericUpDown_ValueChanged;
            // 
            // lblPorcentajeEfectivo
            // 
            lblPorcentajeEfectivo.AutoSize = true;
            lblPorcentajeEfectivo.Font = new Font("Segoe UI", 10F);
            lblPorcentajeEfectivo.ForeColor = Color.FromArgb(52, 73, 94);
            lblPorcentajeEfectivo.Location = new Point(220, 32);
            lblPorcentajeEfectivo.Name = "lblPorcentajeEfectivo";
            lblPorcentajeEfectivo.Size = new Size(94, 19);
            lblPorcentajeEfectivo.TabIndex = 1;
            lblPorcentajeEfectivo.Text = "% Efectivo (%)";
            // 
            // lblConfiguracionComision
            // 
            lblConfiguracionComision.AutoSize = true;
            lblConfiguracionComision.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblConfiguracionComision.ForeColor = Color.FromArgb(52, 73, 94);
            lblConfiguracionComision.Location = new Point(15, 15);
            lblConfiguracionComision.Name = "lblConfiguracionComision";
            lblConfiguracionComision.Size = new Size(195, 21);
            lblConfiguracionComision.TabIndex = 0;
            lblConfiguracionComision.Text = "⚙️ Configurar Comisión";
            // 
            // panelPrestamosPendientes
            // 
            panelPrestamosPendientes.BackColor = Color.FromArgb(236, 240, 241);
            panelPrestamosPendientes.Controls.Add(dgvPrestamosPendientes);
            panelPrestamosPendientes.Controls.Add(lblPrestamosPendientes);
            panelPrestamosPendientes.Location = new Point(20, 140);
            panelPrestamosPendientes.Name = "panelPrestamosPendientes";
            panelPrestamosPendientes.Padding = new Padding(15);
            panelPrestamosPendientes.Size = new Size(1120, 220);
            panelPrestamosPendientes.TabIndex = 2;
            // 
            // dgvPrestamosPendientes
            // 
            dgvPrestamosPendientes.AllowUserToAddRows = false;
            dgvPrestamosPendientes.AllowUserToDeleteRows = false;
            dgvPrestamosPendientes.BackgroundColor = Color.White;
            dgvPrestamosPendientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrestamosPendientes.Location = new Point(15, 40);
            dgvPrestamosPendientes.Name = "dgvPrestamosPendientes";
            dgvPrestamosPendientes.ReadOnly = true;
            dgvPrestamosPendientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPrestamosPendientes.Size = new Size(1090, 165);
            dgvPrestamosPendientes.TabIndex = 1;
            // 
            // lblPrestamosPendientes
            // 
            lblPrestamosPendientes.AutoSize = true;
            lblPrestamosPendientes.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPrestamosPendientes.ForeColor = Color.FromArgb(52, 73, 94);
            lblPrestamosPendientes.Location = new Point(15, 15);
            lblPrestamosPendientes.Name = "lblPrestamosPendientes";
            lblPrestamosPendientes.Size = new Size(301, 21);
            lblPrestamosPendientes.TabIndex = 0;
            lblPrestamosPendientes.Text = "📋 Préstamos Pendientes de Comisión";
            // 
            // panelResumen
            // 
            panelResumen.Controls.Add(panelComisionProductos);
            panelResumen.Controls.Add(panelComisionEfectivo);
            panelResumen.Location = new Point(20, 357);
            panelResumen.Name = "panelResumen";
            panelResumen.Size = new Size(1120, 120);
            panelResumen.TabIndex = 3;
            // 
            // panelComisionProductos
            // 
            panelComisionProductos.BackColor = Color.White;
            panelComisionProductos.BorderStyle = BorderStyle.FixedSingle;
            panelComisionProductos.Controls.Add(lblComisionProductos);
            panelComisionProductos.Controls.Add(lblTotalProductos);
            panelComisionProductos.Controls.Add(lblComisionProductosTitle);
            panelComisionProductos.Location = new Point(570, 3);
            panelComisionProductos.Name = "panelComisionProductos";
            panelComisionProductos.Padding = new Padding(15);
            panelComisionProductos.Size = new Size(540, 100);
            panelComisionProductos.TabIndex = 1;
            // 
            // lblComisionProductos
            // 
            lblComisionProductos.AutoSize = true;
            lblComisionProductos.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblComisionProductos.ForeColor = Color.FromArgb(155, 89, 182);
            lblComisionProductos.Location = new Point(15, 70);
            lblComisionProductos.Name = "lblComisionProductos";
            lblComisionProductos.Size = new Size(211, 25);
            lblComisionProductos.TabIndex = 2;
            lblComisionProductos.Text = "Comisión (10%): $0.00";
            // 
            // lblTotalProductos
            // 
            lblTotalProductos.AutoSize = true;
            lblTotalProductos.Font = new Font("Segoe UI", 12F);
            lblTotalProductos.ForeColor = Color.FromArgb(52, 73, 94);
            lblTotalProductos.Location = new Point(15, 45);
            lblTotalProductos.Name = "lblTotalProductos";
            lblTotalProductos.Size = new Size(212, 21);
            lblTotalProductos.TabIndex = 1;
            lblTotalProductos.Text = "Total Pagos Pendientes: $0.00";
            // 
            // lblComisionProductosTitle
            // 
            lblComisionProductosTitle.AutoSize = true;
            lblComisionProductosTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblComisionProductosTitle.ForeColor = Color.FromArgb(52, 73, 94);
            lblComisionProductosTitle.Location = new Point(15, 15);
            lblComisionProductosTitle.Name = "lblComisionProductosTitle";
            lblComisionProductosTitle.Size = new Size(229, 21);
            lblComisionProductosTitle.TabIndex = 0;
            lblComisionProductosTitle.Text = "📦 Préstamos con Productos";
            // 
            // panelComisionEfectivo
            // 
            panelComisionEfectivo.BackColor = Color.White;
            panelComisionEfectivo.BorderStyle = BorderStyle.FixedSingle;
            panelComisionEfectivo.Controls.Add(lblComisionEfectivo);
            panelComisionEfectivo.Controls.Add(lblTotalEfectivo);
            panelComisionEfectivo.Controls.Add(lblComisionEfectivoTitle);
            panelComisionEfectivo.Location = new Point(10, 3);
            panelComisionEfectivo.Name = "panelComisionEfectivo";
            panelComisionEfectivo.Padding = new Padding(15);
            panelComisionEfectivo.Size = new Size(540, 100);
            panelComisionEfectivo.TabIndex = 0;
            // 
            // lblComisionEfectivo
            // 
            lblComisionEfectivo.AutoSize = true;
            lblComisionEfectivo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblComisionEfectivo.ForeColor = Color.FromArgb(39, 174, 96);
            lblComisionEfectivo.Location = new Point(15, 70);
            lblComisionEfectivo.Name = "lblComisionEfectivo";
            lblComisionEfectivo.Size = new Size(211, 25);
            lblComisionEfectivo.TabIndex = 2;
            lblComisionEfectivo.Text = "Comisión (10%): $0.00";
            // 
            // lblTotalEfectivo
            // 
            lblTotalEfectivo.AutoSize = true;
            lblTotalEfectivo.Font = new Font("Segoe UI", 12F);
            lblTotalEfectivo.ForeColor = Color.FromArgb(52, 73, 94);
            lblTotalEfectivo.Location = new Point(15, 45);
            lblTotalEfectivo.Name = "lblTotalEfectivo";
            lblTotalEfectivo.Size = new Size(212, 21);
            lblTotalEfectivo.TabIndex = 1;
            lblTotalEfectivo.Text = "Total Pagos Pendientes: $0.00";
            // 
            // lblComisionEfectivoTitle
            // 
            lblComisionEfectivoTitle.AutoSize = true;
            lblComisionEfectivoTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblComisionEfectivoTitle.ForeColor = Color.FromArgb(52, 73, 94);
            lblComisionEfectivoTitle.Location = new Point(15, 15);
            lblComisionEfectivoTitle.Name = "lblComisionEfectivoTitle";
            lblComisionEfectivoTitle.Size = new Size(189, 21);
            lblComisionEfectivoTitle.TabIndex = 0;
            lblComisionEfectivoTitle.Text = "💵 Créditos en Efectivo";
            // 
            // panelAcciones
            // 
            panelAcciones.BackColor = Color.FromArgb(236, 240, 241);
            panelAcciones.Controls.Add(btnDescargarPDFSemanal);
            panelAcciones.Controls.Add(btnGenerarPDFDetallado);
            panelAcciones.Controls.Add(btnMarcarComoPagado);
            panelAcciones.Controls.Add(lblTotalPagar);
            panelAcciones.Location = new Point(20, 462);
            panelAcciones.Name = "panelAcciones";
            panelAcciones.Padding = new Padding(15);
            panelAcciones.Size = new Size(1120, 109);
            panelAcciones.TabIndex = 4;
            // 
            // btnDescargarPDFSemanal
            // 
            btnDescargarPDFSemanal.BackColor = Color.FromArgb(142, 68, 173);
            btnDescargarPDFSemanal.FlatAppearance.BorderSize = 0;
            btnDescargarPDFSemanal.FlatStyle = FlatStyle.Flat;
            btnDescargarPDFSemanal.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDescargarPDFSemanal.ForeColor = Color.White;
            btnDescargarPDFSemanal.Location = new Point(722, 51);
            btnDescargarPDFSemanal.Name = "btnDescargarPDFSemanal";
            btnDescargarPDFSemanal.Size = new Size(180, 40);
            btnDescargarPDFSemanal.TabIndex = 4;
            btnDescargarPDFSemanal.Text = "📄 PDF Semanal";
            btnDescargarPDFSemanal.UseVisualStyleBackColor = false;
            btnDescargarPDFSemanal.Click += btnDescargarPDFSemanal_Click;
            // 
            // btnGenerarPDFDetallado
            // 
            btnGenerarPDFDetallado.BackColor = Color.FromArgb(231, 76, 60);
            btnGenerarPDFDetallado.FlatAppearance.BorderSize = 0;
            btnGenerarPDFDetallado.FlatStyle = FlatStyle.Flat;
            btnGenerarPDFDetallado.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGenerarPDFDetallado.ForeColor = Color.White;
            btnGenerarPDFDetallado.Location = new Point(415, 50);
            btnGenerarPDFDetallado.Name = "btnGenerarPDFDetallado";
            btnGenerarPDFDetallado.Size = new Size(180, 40);
            btnGenerarPDFDetallado.TabIndex = 3;
            btnGenerarPDFDetallado.Text = "📄 Generar PDF";
            btnGenerarPDFDetallado.UseVisualStyleBackColor = false;
            btnGenerarPDFDetallado.Click += btnGenerarPDFDetallado_Click;
            // 
            // btnMarcarComoPagado
            // 
            btnMarcarComoPagado.BackColor = Color.FromArgb(39, 174, 96);
            btnMarcarComoPagado.FlatAppearance.BorderSize = 0;
            btnMarcarComoPagado.FlatStyle = FlatStyle.Flat;
            btnMarcarComoPagado.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnMarcarComoPagado.ForeColor = Color.White;
            btnMarcarComoPagado.Location = new Point(215, 50);
            btnMarcarComoPagado.Name = "btnMarcarComoPagado";
            btnMarcarComoPagado.Size = new Size(180, 40);
            btnMarcarComoPagado.TabIndex = 2;
            btnMarcarComoPagado.Text = "✅ Marcar Pagado";
            btnMarcarComoPagado.UseVisualStyleBackColor = false;
            btnMarcarComoPagado.Click += btnMarcarComoPagado_Click;
            // 
            // lblTotalPagar
            // 
            lblTotalPagar.AutoSize = true;
            lblTotalPagar.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTotalPagar.ForeColor = Color.FromArgb(39, 174, 96);
            lblTotalPagar.Location = new Point(15, 15);
            lblTotalPagar.Name = "lblTotalPagar";
            lblTotalPagar.Size = new Size(351, 30);
            lblTotalPagar.TabIndex = 0;
            lblTotalPagar.Text = "Total a Pagar al Empleado: $0.00";
            // 
            // Comisiones
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 240, 241);
            ClientSize = new Size(1200, 700);
            Controls.Add(panelMain);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Comisiones";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Préstamos - Comisiones";
            WindowState = FormWindowState.Minimized;
            Load += Comisiones_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelMain.ResumeLayout(false);
            panelComisionesContent.ResumeLayout(false);
            panelSeleccionEmpleado.ResumeLayout(false);
            panelSeleccionEmpleado.PerformLayout();
            panelConfiguracionComision.ResumeLayout(false);
            panelConfiguracionComision.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPorcentajeProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPorcentajeEfectivo).EndInit();
            panelPrestamosPendientes.ResumeLayout(false);
            panelPrestamosPendientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPrestamosPendientes).EndInit();
            panelResumen.ResumeLayout(false);
            panelComisionProductos.ResumeLayout(false);
            panelComisionProductos.PerformLayout();
            panelComisionEfectivo.ResumeLayout(false);
            panelComisionEfectivo.PerformLayout();
            panelAcciones.ResumeLayout(false);
            panelAcciones.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblSubtitle;
        private Label lblTitle;
        private Button btnVolver;
        private Panel panelMain;
        private Panel panelComisionesContent;
        private Panel panelSeleccionEmpleado;
        private ComboBox cmbEmpleados;
        private Label lblSeleccionEmpleado;
        private Panel panelConfiguracionComision;
        private Button btnGuardarPorcentaje;
        private NumericUpDown numericUpDownPorcentajeProductos;
        private Label lblPorcentajeProductos;
        private NumericUpDown numericUpDownPorcentajeEfectivo;
        private Label lblPorcentajeEfectivo;
        private Label lblConfiguracionComision;
        private Panel panelPrestamosPendientes;
        private DataGridView dgvPrestamosPendientes;
        private Label lblPrestamosPendientes;
        private Panel panelResumen;
        private Panel panelComisionProductos;
        private Label lblComisionProductos;
        private Label lblTotalProductos;
        private Label lblComisionProductosTitle;
        private Panel panelComisionEfectivo;
        private Label lblComisionEfectivo;
        private Label lblTotalEfectivo;
        private Label lblComisionEfectivoTitle;
        private Panel panelAcciones;
        private Button btnDescargarPDFSemanal;
        private Button btnGenerarPDFDetallado;
        private Button btnMarcarComoPagado;
        private Label lblTotalPagar;
    }
}