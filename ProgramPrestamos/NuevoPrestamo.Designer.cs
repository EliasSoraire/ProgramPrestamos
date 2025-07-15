namespace ProgramPrestamos
{
    partial class NuevoPrestamo
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
            panelMain = new Panel();
            panelButtons = new Panel();
            btnCalcular = new Button();
            btnCancelar = new Button();
            btnGuardar = new Button();
            panelCalculos = new Panel();
            lblEmpleadoAsignado = new Label();
            lblValorCuota = new Label();
            lblInteresGenerado = new Label();
            lblTotalPagar = new Label();
            lblCalculosTitle = new Label();
            panelPrestamoProducto = new Panel();
            lblStockDisponible = new Label();
            txtTotalProducto = new TextBox();
            lblTotalProducto = new Label();
            txtPrecioUnitario = new TextBox();
            lblPrecioUnitario = new Label();
            txtCantidadProducto = new TextBox();
            lblCantidadProducto = new Label();
            cmbProducto = new ComboBox();
            lblProducto = new Label();
            lblPrestamoProductoTitle = new Label();
            panelPrestamoEfectivo = new Panel();
            txtImporte = new TextBox();
            lblImporte = new Label();
            lblPrestamoEfectivoTitle = new Label();
            panelDatosComunes = new Panel();
            dtpFechaPrestamo = new DateTimePicker();
            lblFechaPrestamo = new Label();
            txtCantidadCuotas = new TextBox();
            lblCantidadCuotas = new Label();
            txtTasaInteres = new TextBox();
            lblTasaInteres = new Label();
            cmbModalidad = new ComboBox();
            lblModalidad = new Label();
            cmbCliente = new ComboBox();
            lblCliente = new Label();
            lblDatosComunesTitle = new Label();
            panelTipoPrestamo = new Panel();
            rbPrestamoProducto = new RadioButton();
            rbPrestamoEfectivo = new RadioButton();
            lblTipoPrestamo = new Label();
            panelHeader.SuspendLayout();
            panelMain.SuspendLayout();
            panelButtons.SuspendLayout();
            panelCalculos.SuspendLayout();
            panelPrestamoProducto.SuspendLayout();
            panelPrestamoEfectivo.SuspendLayout();
            panelDatosComunes.SuspendLayout();
            panelTipoPrestamo.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(41, 53, 65);
            panelHeader.Controls.Add(lblSubtitle);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1000, 91);
            panelHeader.TabIndex = 0;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.FromArgb(189, 195, 199);
            lblSubtitle.Location = new Point(20, 57);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(403, 19);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Formulario para registrar préstamos en efectivo o con productos";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 17);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(245, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "💳 Nuevo Préstamo";
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(236, 240, 241);
            panelMain.Controls.Add(panelButtons);
            panelMain.Controls.Add(panelCalculos);
            panelMain.Controls.Add(panelPrestamoProducto);
            panelMain.Controls.Add(panelPrestamoEfectivo);
            panelMain.Controls.Add(panelDatosComunes);
            panelMain.Controls.Add(panelTipoPrestamo);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 91);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(20, 23, 20, 23);
            panelMain.Size = new Size(1000, 658);
            panelMain.TabIndex = 1;
            // 
            // panelButtons
            // 
            panelButtons.Controls.Add(btnCalcular);
            panelButtons.Controls.Add(btnCancelar);
            panelButtons.Controls.Add(btnGuardar);
            panelButtons.Location = new Point(20, 612);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(960, 68);
            panelButtons.TabIndex = 5;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.FromArgb(52, 152, 219);
            btnCalcular.FlatAppearance.BorderSize = 0;
            btnCalcular.FlatStyle = FlatStyle.Flat;
            btnCalcular.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCalcular.ForeColor = Color.White;
            btnCalcular.Location = new Point(330, 11);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(120, 45);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "\U0001f9ee Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(231, 76, 60);
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(190, 11);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(120, 45);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "❌ Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(39, 174, 96);
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(20, 11);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(150, 45);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "💾 Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // panelCalculos
            // 
            panelCalculos.BackColor = Color.White;
            panelCalculos.Controls.Add(lblEmpleadoAsignado);
            panelCalculos.Controls.Add(lblValorCuota);
            panelCalculos.Controls.Add(lblInteresGenerado);
            panelCalculos.Controls.Add(lblTotalPagar);
            panelCalculos.Controls.Add(lblCalculosTitle);
            panelCalculos.Location = new Point(500, 340);
            panelCalculos.Name = "panelCalculos";
            panelCalculos.Padding = new Padding(20, 23, 20, 23);
            panelCalculos.Size = new Size(480, 249);
            panelCalculos.TabIndex = 4;
            // 
            // lblEmpleadoAsignado
            // 
            lblEmpleadoAsignado.AutoSize = true;
            lblEmpleadoAsignado.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEmpleadoAsignado.ForeColor = Color.FromArgb(52, 73, 94);
            lblEmpleadoAsignado.Location = new Point(20, 193);
            lblEmpleadoAsignado.Name = "lblEmpleadoAsignado";
            lblEmpleadoAsignado.Size = new Size(163, 19);
            lblEmpleadoAsignado.TabIndex = 4;
            lblEmpleadoAsignado.Text = "Empleado Asignado: --";
            // 
            // lblValorCuota
            // 
            lblValorCuota.AutoSize = true;
            lblValorCuota.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblValorCuota.ForeColor = Color.FromArgb(52, 152, 219);
            lblValorCuota.Location = new Point(20, 142);
            lblValorCuota.Name = "lblValorCuota";
            lblValorCuota.Size = new Size(177, 21);
            lblValorCuota.TabIndex = 3;
            lblValorCuota.Text = "Valor por Cuota: $0.00";
            // 
            // lblInteresGenerado
            // 
            lblInteresGenerado.AutoSize = true;
            lblInteresGenerado.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblInteresGenerado.ForeColor = Color.FromArgb(230, 126, 34);
            lblInteresGenerado.Location = new Point(20, 108);
            lblInteresGenerado.Name = "lblInteresGenerado";
            lblInteresGenerado.Size = new Size(188, 21);
            lblInteresGenerado.TabIndex = 2;
            lblInteresGenerado.Text = "Interés Generado: $0.00";
            // 
            // lblTotalPagar
            // 
            lblTotalPagar.AutoSize = true;
            lblTotalPagar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTotalPagar.ForeColor = Color.FromArgb(39, 174, 96);
            lblTotalPagar.Location = new Point(20, 74);
            lblTotalPagar.Name = "lblTotalPagar";
            lblTotalPagar.Size = new Size(158, 21);
            lblTotalPagar.TabIndex = 1;
            lblTotalPagar.Text = "Total a Pagar: $0.00";
            // 
            // lblCalculosTitle
            // 
            lblCalculosTitle.AutoSize = true;
            lblCalculosTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblCalculosTitle.ForeColor = Color.FromArgb(41, 53, 65);
            lblCalculosTitle.Location = new Point(20, 23);
            lblCalculosTitle.Name = "lblCalculosTitle";
            lblCalculosTitle.Size = new Size(202, 25);
            lblCalculosTitle.TabIndex = 0;
            lblCalculosTitle.Text = "Cálculos Automáticos";
            // 
            // panelPrestamoProducto
            // 
            panelPrestamoProducto.BackColor = Color.White;
            panelPrestamoProducto.Controls.Add(lblStockDisponible);
            panelPrestamoProducto.Controls.Add(txtTotalProducto);
            panelPrestamoProducto.Controls.Add(lblTotalProducto);
            panelPrestamoProducto.Controls.Add(txtPrecioUnitario);
            panelPrestamoProducto.Controls.Add(lblPrecioUnitario);
            panelPrestamoProducto.Controls.Add(txtCantidadProducto);
            panelPrestamoProducto.Controls.Add(lblCantidadProducto);
            panelPrestamoProducto.Controls.Add(cmbProducto);
            panelPrestamoProducto.Controls.Add(lblProducto);
            panelPrestamoProducto.Controls.Add(lblPrestamoProductoTitle);
            panelPrestamoProducto.Location = new Point(20, 340);
            panelPrestamoProducto.Name = "panelPrestamoProducto";
            panelPrestamoProducto.Padding = new Padding(20, 23, 20, 23);
            panelPrestamoProducto.Size = new Size(460, 249);
            panelPrestamoProducto.TabIndex = 3;
            panelPrestamoProducto.Visible = false;
            // 
            // lblStockDisponible
            // 
            lblStockDisponible.AutoSize = true;
            lblStockDisponible.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblStockDisponible.ForeColor = Color.FromArgb(127, 140, 141);
            lblStockDisponible.Location = new Point(20, 210);
            lblStockDisponible.Name = "lblStockDisponible";
            lblStockDisponible.Size = new Size(287, 15);
            lblStockDisponible.TabIndex = 9;
            lblStockDisponible.Text = "Stock disponible: -- (Se descontará automáticamente)";
            // 
            // txtTotalProducto
            // 
            txtTotalProducto.BackColor = Color.FromArgb(236, 240, 241);
            txtTotalProducto.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtTotalProducto.Location = new Point(190, 164);
            txtTotalProducto.Name = "txtTotalProducto";
            txtTotalProducto.ReadOnly = true;
            txtTotalProducto.Size = new Size(150, 25);
            txtTotalProducto.TabIndex = 8;
            txtTotalProducto.TextAlign = HorizontalAlignment.Right;
            // 
            // lblTotalProducto
            // 
            lblTotalProducto.AutoSize = true;
            lblTotalProducto.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTotalProducto.ForeColor = Color.FromArgb(52, 73, 94);
            lblTotalProducto.Location = new Point(190, 136);
            lblTotalProducto.Name = "lblTotalProducto";
            lblTotalProducto.Size = new Size(133, 19);
            lblTotalProducto.TabIndex = 7;
            lblTotalProducto.Text = "Total del Producto";
            // 
            // txtPrecioUnitario
            // 
            txtPrecioUnitario.Font = new Font("Segoe UI", 10F);
            txtPrecioUnitario.Location = new Point(20, 164);
            txtPrecioUnitario.Name = "txtPrecioUnitario";
            txtPrecioUnitario.Size = new Size(150, 25);
            txtPrecioUnitario.TabIndex = 6;
            txtPrecioUnitario.TextAlign = HorizontalAlignment.Right;
            // 
            // lblPrecioUnitario
            // 
            lblPrecioUnitario.AutoSize = true;
            lblPrecioUnitario.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPrecioUnitario.ForeColor = Color.FromArgb(52, 73, 94);
            lblPrecioUnitario.Location = new Point(20, 136);
            lblPrecioUnitario.Name = "lblPrecioUnitario";
            lblPrecioUnitario.Size = new Size(110, 19);
            lblPrecioUnitario.TabIndex = 5;
            lblPrecioUnitario.Text = "Precio Unitario";
            // 
            // txtCantidadProducto
            // 
            txtCantidadProducto.Font = new Font("Segoe UI", 10F);
            txtCantidadProducto.Location = new Point(320, 91);
            txtCantidadProducto.Name = "txtCantidadProducto";
            txtCantidadProducto.Size = new Size(100, 25);
            txtCantidadProducto.TabIndex = 4;
            txtCantidadProducto.TextAlign = HorizontalAlignment.Right;
            // 
            // lblCantidadProducto
            // 
            lblCantidadProducto.AutoSize = true;
            lblCantidadProducto.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCantidadProducto.ForeColor = Color.FromArgb(52, 73, 94);
            lblCantidadProducto.Location = new Point(320, 62);
            lblCantidadProducto.Name = "lblCantidadProducto";
            lblCantidadProducto.Size = new Size(69, 19);
            lblCantidadProducto.TabIndex = 3;
            lblCantidadProducto.Text = "Cantidad";
            // 
            // cmbProducto
            // 
            cmbProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProducto.Font = new Font("Segoe UI", 10F);
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(20, 91);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(280, 25);
            cmbProducto.TabIndex = 2;
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblProducto.ForeColor = Color.FromArgb(52, 73, 94);
            lblProducto.Location = new Point(20, 62);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(71, 19);
            lblProducto.TabIndex = 1;
            lblProducto.Text = "Producto";
            // 
            // lblPrestamoProductoTitle
            // 
            lblPrestamoProductoTitle.AutoSize = true;
            lblPrestamoProductoTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPrestamoProductoTitle.ForeColor = Color.FromArgb(155, 89, 182);
            lblPrestamoProductoTitle.Location = new Point(20, 23);
            lblPrestamoProductoTitle.Name = "lblPrestamoProductoTitle";
            lblPrestamoProductoTitle.Size = new Size(215, 21);
            lblPrestamoProductoTitle.TabIndex = 0;
            lblPrestamoProductoTitle.Text = "📦 Préstamo con Producto";
            // 
            // panelPrestamoEfectivo
            // 
            panelPrestamoEfectivo.BackColor = Color.White;
            panelPrestamoEfectivo.Controls.Add(txtImporte);
            panelPrestamoEfectivo.Controls.Add(lblImporte);
            panelPrestamoEfectivo.Controls.Add(lblPrestamoEfectivoTitle);
            panelPrestamoEfectivo.Location = new Point(20, 340);
            panelPrestamoEfectivo.Name = "panelPrestamoEfectivo";
            panelPrestamoEfectivo.Padding = new Padding(20, 23, 20, 23);
            panelPrestamoEfectivo.Size = new Size(460, 136);
            panelPrestamoEfectivo.TabIndex = 2;
            // 
            // txtImporte
            // 
            txtImporte.Font = new Font("Segoe UI", 10F);
            txtImporte.Location = new Point(20, 91);
            txtImporte.Name = "txtImporte";
            txtImporte.Size = new Size(200, 25);
            txtImporte.TabIndex = 2;
            txtImporte.TextAlign = HorizontalAlignment.Right;
            // 
            // lblImporte
            // 
            lblImporte.AutoSize = true;
            lblImporte.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblImporte.ForeColor = Color.FromArgb(52, 73, 94);
            lblImporte.Location = new Point(20, 62);
            lblImporte.Name = "lblImporte";
            lblImporte.Size = new Size(127, 19);
            lblImporte.TabIndex = 1;
            lblImporte.Text = "Importe Prestado";
            // 
            // lblPrestamoEfectivoTitle
            // 
            lblPrestamoEfectivoTitle.AutoSize = true;
            lblPrestamoEfectivoTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPrestamoEfectivoTitle.ForeColor = Color.FromArgb(39, 174, 96);
            lblPrestamoEfectivoTitle.Location = new Point(20, 23);
            lblPrestamoEfectivoTitle.Name = "lblPrestamoEfectivoTitle";
            lblPrestamoEfectivoTitle.Size = new Size(195, 21);
            lblPrestamoEfectivoTitle.TabIndex = 0;
            lblPrestamoEfectivoTitle.Text = "💰 Préstamo en Efectivo";
            // 
            // panelDatosComunes
            // 
            panelDatosComunes.BackColor = Color.White;
            panelDatosComunes.Controls.Add(dtpFechaPrestamo);
            panelDatosComunes.Controls.Add(lblFechaPrestamo);
            panelDatosComunes.Controls.Add(txtCantidadCuotas);
            panelDatosComunes.Controls.Add(lblCantidadCuotas);
            panelDatosComunes.Controls.Add(txtTasaInteres);
            panelDatosComunes.Controls.Add(lblTasaInteres);
            panelDatosComunes.Controls.Add(cmbModalidad);
            panelDatosComunes.Controls.Add(lblModalidad);
            panelDatosComunes.Controls.Add(cmbCliente);
            panelDatosComunes.Controls.Add(lblCliente);
            panelDatosComunes.Controls.Add(lblDatosComunesTitle);
            panelDatosComunes.Location = new Point(20, 99);
            panelDatosComunes.Name = "panelDatosComunes";
            panelDatosComunes.Padding = new Padding(20, 23, 20, 23);
            panelDatosComunes.Size = new Size(960, 194);
            panelDatosComunes.TabIndex = 1;
            // 
            // dtpFechaPrestamo
            // 
            dtpFechaPrestamo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            dtpFechaPrestamo.Font = new Font("Segoe UI", 10F);
            dtpFechaPrestamo.Format = DateTimePickerFormat.Short;
            dtpFechaPrestamo.Location = new Point(20, 158);
            dtpFechaPrestamo.Name = "dtpFechaPrestamo";
            dtpFechaPrestamo.Size = new Size(200, 25);
            dtpFechaPrestamo.TabIndex = 10;
            // 
            // lblFechaPrestamo
            // 
            lblFechaPrestamo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblFechaPrestamo.AutoSize = true;
            lblFechaPrestamo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFechaPrestamo.ForeColor = Color.FromArgb(52, 73, 94);
            lblFechaPrestamo.Location = new Point(20, 130);
            lblFechaPrestamo.Name = "lblFechaPrestamo";
            lblFechaPrestamo.Size = new Size(140, 19);
            lblFechaPrestamo.TabIndex = 9;
            lblFechaPrestamo.Text = "Fecha del Préstamo";
            // 
            // txtCantidadCuotas
            // 
            txtCantidadCuotas.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtCantidadCuotas.Font = new Font("Segoe UI", 10F);
            txtCantidadCuotas.Location = new Point(610, 83);
            txtCantidadCuotas.Name = "txtCantidadCuotas";
            txtCantidadCuotas.Size = new Size(100, 25);
            txtCantidadCuotas.TabIndex = 8;
            txtCantidadCuotas.TextAlign = HorizontalAlignment.Right;
            // 
            // lblCantidadCuotas
            // 
            lblCantidadCuotas.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblCantidadCuotas.AutoSize = true;
            lblCantidadCuotas.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCantidadCuotas.ForeColor = Color.FromArgb(52, 73, 94);
            lblCantidadCuotas.Location = new Point(610, 55);
            lblCantidadCuotas.Name = "lblCantidadCuotas";
            lblCantidadCuotas.Size = new Size(139, 19);
            lblCantidadCuotas.TabIndex = 7;
            lblCantidadCuotas.Text = "Cantidad de Cuotas";
            // 
            // txtTasaInteres
            // 
            txtTasaInteres.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtTasaInteres.Font = new Font("Segoe UI", 10F);
            txtTasaInteres.Location = new Point(490, 83);
            txtTasaInteres.Name = "txtTasaInteres";
            txtTasaInteres.Size = new Size(100, 25);
            txtTasaInteres.TabIndex = 6;
            txtTasaInteres.TextAlign = HorizontalAlignment.Right;
            // 
            // lblTasaInteres
            // 
            lblTasaInteres.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblTasaInteres.AutoSize = true;
            lblTasaInteres.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTasaInteres.ForeColor = Color.FromArgb(52, 73, 94);
            lblTasaInteres.Location = new Point(490, 55);
            lblTasaInteres.Name = "lblTasaInteres";
            lblTasaInteres.Size = new Size(108, 19);
            lblTasaInteres.TabIndex = 5;
            lblTasaInteres.Text = "Tasa de Interés";
            // 
            // cmbModalidad
            // 
            cmbModalidad.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cmbModalidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbModalidad.Font = new Font("Segoe UI", 10F);
            cmbModalidad.FormattingEnabled = true;
            cmbModalidad.Items.AddRange(new object[] { "Diario", "Semanal", "Mensual" });
            cmbModalidad.Location = new Point(320, 83);
            cmbModalidad.Name = "cmbModalidad";
            cmbModalidad.Size = new Size(150, 25);
            cmbModalidad.TabIndex = 4;
            // 
            // lblModalidad
            // 
            lblModalidad.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblModalidad.AutoSize = true;
            lblModalidad.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblModalidad.ForeColor = Color.FromArgb(52, 73, 94);
            lblModalidad.Location = new Point(320, 55);
            lblModalidad.Name = "lblModalidad";
            lblModalidad.Size = new Size(82, 19);
            lblModalidad.TabIndex = 3;
            lblModalidad.Text = "Modalidad";
            // 
            // cmbCliente
            // 
            cmbCliente.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cmbCliente.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbCliente.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbCliente.Font = new Font("Segoe UI", 10F);
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(20, 83);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(280, 25);
            cmbCliente.TabIndex = 2;
            // 
            // lblCliente
            // 
            lblCliente.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCliente.ForeColor = Color.FromArgb(52, 73, 94);
            lblCliente.Location = new Point(20, 55);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(55, 19);
            lblCliente.TabIndex = 1;
            lblCliente.Text = "Cliente";
            // 
            // lblDatosComunesTitle
            // 
            lblDatosComunesTitle.AutoSize = true;
            lblDatosComunesTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblDatosComunesTitle.ForeColor = Color.FromArgb(41, 53, 65);
            lblDatosComunesTitle.Location = new Point(20, 23);
            lblDatosComunesTitle.Name = "lblDatosComunesTitle";
            lblDatosComunesTitle.Size = new Size(129, 21);
            lblDatosComunesTitle.TabIndex = 0;
            lblDatosComunesTitle.Text = "Datos Comunes";
            // 
            // panelTipoPrestamo
            // 
            panelTipoPrestamo.BackColor = Color.White;
            panelTipoPrestamo.Controls.Add(rbPrestamoProducto);
            panelTipoPrestamo.Controls.Add(rbPrestamoEfectivo);
            panelTipoPrestamo.Controls.Add(lblTipoPrestamo);
            panelTipoPrestamo.Location = new Point(20, 23);
            panelTipoPrestamo.Name = "panelTipoPrestamo";
            panelTipoPrestamo.Padding = new Padding(20, 23, 20, 23);
            panelTipoPrestamo.Size = new Size(960, 70);
            panelTipoPrestamo.TabIndex = 0;
            //
            // rbPrestamoProducto
            //
            rbPrestamoProducto.AutoSize = true;
            rbPrestamoProducto.Font = new Font("Segoe UI", 10F);
            rbPrestamoProducto.ForeColor = Color.FromArgb(52, 73, 94);
            rbPrestamoProducto.Location = new Point(400, 25);
            rbPrestamoProducto.Name = "rbPrestamoProducto";
            rbPrestamoProducto.Size = new Size(194, 23);
            rbPrestamoProducto.TabIndex = 2;
            rbPrestamoProducto.Text = "📦 Préstamo con Producto";
            rbPrestamoProducto.UseVisualStyleBackColor = true;
            rbPrestamoProducto.CheckedChanged += rbPrestamoProducto_CheckedChanged;
            //
            // rbPrestamoEfectivo
            //
            rbPrestamoEfectivo.AutoSize = true;
            rbPrestamoEfectivo.Checked = true;
            rbPrestamoEfectivo.Font = new Font("Segoe UI", 10F);
            rbPrestamoEfectivo.ForeColor = Color.FromArgb(52, 73, 94);
            rbPrestamoEfectivo.Location = new Point(200, 25);
            rbPrestamoEfectivo.Name = "rbPrestamoEfectivo";
            rbPrestamoEfectivo.Size = new Size(175, 23);
            rbPrestamoEfectivo.TabIndex = 1;
            rbPrestamoEfectivo.TabStop = true;
            rbPrestamoEfectivo.Text = "💰 Préstamo en Efectivo";
            rbPrestamoEfectivo.UseVisualStyleBackColor = true;
            rbPrestamoEfectivo.CheckedChanged += rbPrestamoEfectivo_CheckedChanged;
            // 
            // lblTipoPrestamo
            // 
            lblTipoPrestamo.AutoSize = true;
            lblTipoPrestamo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTipoPrestamo.ForeColor = Color.FromArgb(41, 53, 65);
            lblTipoPrestamo.Location = new Point(20, 23);
            lblTipoPrestamo.Name = "lblTipoPrestamo";
            lblTipoPrestamo.Size = new Size(143, 21);
            lblTipoPrestamo.TabIndex = 0;
            lblTipoPrestamo.Text = "Tipo de Préstamo";
            // 
            // NuevoPrestamo
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 240, 241);
            ClientSize = new Size(1000, 749);
            Controls.Add(panelMain);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "NuevoPrestamo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Préstamos - Nuevo Préstamo";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelMain.ResumeLayout(false);
            panelButtons.ResumeLayout(false);
            panelCalculos.ResumeLayout(false);
            panelCalculos.PerformLayout();
            panelPrestamoProducto.ResumeLayout(false);
            panelPrestamoProducto.PerformLayout();
            panelPrestamoEfectivo.ResumeLayout(false);
            panelPrestamoEfectivo.PerformLayout();
            panelDatosComunes.ResumeLayout(false);
            panelDatosComunes.PerformLayout();
            panelTipoPrestamo.ResumeLayout(false);
            panelTipoPrestamo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelTipoPrestamo;
        private System.Windows.Forms.Label lblTipoPrestamo;
        private System.Windows.Forms.RadioButton rbPrestamoEfectivo;
        private System.Windows.Forms.RadioButton rbPrestamoProducto;
        private System.Windows.Forms.Panel panelDatosComunes;
        private System.Windows.Forms.Label lblDatosComunesTitle;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Label lblModalidad;
        private System.Windows.Forms.ComboBox cmbModalidad;
        private System.Windows.Forms.Label lblTasaInteres;
        private System.Windows.Forms.TextBox txtTasaInteres;
        private System.Windows.Forms.Label lblCantidadCuotas;
        private System.Windows.Forms.TextBox txtCantidadCuotas;
        private System.Windows.Forms.Label lblFechaPrestamo;
        private System.Windows.Forms.DateTimePicker dtpFechaPrestamo;
        private System.Windows.Forms.Panel panelPrestamoEfectivo;
        private System.Windows.Forms.Label lblPrestamoEfectivoTitle;
        private System.Windows.Forms.Label lblImporte;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.Panel panelPrestamoProducto;
        private System.Windows.Forms.Label lblPrestamoProductoTitle;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.Label lblCantidadProducto;
        private System.Windows.Forms.TextBox txtCantidadProducto;
        private System.Windows.Forms.Label lblPrecioUnitario;
        private System.Windows.Forms.TextBox txtPrecioUnitario;
        private System.Windows.Forms.Label lblTotalProducto;
        private System.Windows.Forms.TextBox txtTotalProducto;
        private System.Windows.Forms.Label lblStockDisponible;
        private System.Windows.Forms.Panel panelCalculos;
        private System.Windows.Forms.Label lblCalculosTitle;
        private System.Windows.Forms.Label lblTotalPagar;
        private System.Windows.Forms.Label lblInteresGenerado;
        private System.Windows.Forms.Label lblValorCuota;
        private System.Windows.Forms.Label lblEmpleadoAsignado;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCalcular;
    }
}