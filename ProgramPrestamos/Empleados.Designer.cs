namespace ProgramPrestamos
{
    partial class Empleados
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
            panelEmpleadosList = new Panel();
            panelBusqueda = new Panel();
            txtBusqueda = new TextBox();
            lblBusqueda = new Label();
            btnAgregarEmpleado = new Button();
            lblEmpleadosTitle = new Label();
            listViewEmpleados = new ListView();
            panelEmpleadoDetails = new Panel();
            panelDetailsHeader = new Panel();
            lblEmpleadoNombre = new Label();
            lblEmpleadoInfo = new Label();
            tabControlDetails = new TabControl();
            tabPageInfoPersonal = new TabPage();
            panelInfoPersonal = new Panel();
            panelDatosBasicos = new Panel();
            lblDireccionValor = new Label();
            lblDireccion = new Label();
            lblTelefonoValor = new Label();
            lblTelefono = new Label();
            lblDNIValor = new Label();
            lblDNI = new Label();
            lblNombreCompletoValor = new Label();
            lblNombreCompleto = new Label();
            lblDatosBasicos = new Label();
            panelPrestamosActivos = new Panel();
            listViewPrestamosActivos = new ListView();
            lblPrestamosActivosInfo = new Label();
            panelRegistrarPago = new Panel();
            btnRegistrarPagoInfo = new Button();
            txtNumeroCuota = new TextBox();
            lblNumeroCuota = new Label();
            dateTimePickerFechaPago = new DateTimePicker();
            lblFechaPago = new Label();
            txtMontoPagoInfo = new TextBox();
            lblMontoPagoInfo = new Label();
            cmbPrestamoSeleccion = new ComboBox();
            lblPrestamoSeleccion = new Label();
            lblRegistrarPagoInfo = new Label();
            tabPageComisiones = new TabPage();
            panelComisiones = new Panel();
            panelCalculoComisiones = new Panel();
            btnGenerarPDFDetallado = new Button();
            btnMarcarComoPagado = new Button();
            btnCalcularPago = new Button();
            lblTotalPagar = new Label();
            panelComisionProductos = new Panel();
            lblComisionProductos = new Label();
            lblTotalProductos = new Label();
            lblComisionProductosTitle = new Label();
            panelComisionEfectivo = new Panel();
            lblComisionEfectivo = new Label();
            lblTotalEfectivo = new Label();
            lblComisionEfectivoTitle = new Label();
            panelPeriodo = new Panel();
            dateTimePickerHasta = new DateTimePicker();
            lblHasta = new Label();
            dateTimePickerDesde = new DateTimePicker();
            lblDesde = new Label();
            lblPeriodo = new Label();
            lblCalculoComisiones = new Label();
            tabPageCajaPersonal = new TabPage();
            panelCajaPersonal = new Panel();
            listViewMovimientosCaja = new ListView();
            panelSaldoActual = new Panel();
            lblSaldoActual = new Label();
            lblCajaPersonalTitle = new Label();
            tabPageSemanal = new TabPage();
            panelSemanal = new Panel();
            panelResumenSemanal = new Panel();
            lblDeberiaRecaudar = new Label();
            lblTotalRecaudar = new Label();
            btnDescargarPDFSemanal = new Button();
            listViewCobrosSemana = new ListView();
            lblCobrosSemanaTitle = new Label();
            panelHeader.SuspendLayout();
            panelMain.SuspendLayout();
            panelEmpleadosList.SuspendLayout();
            panelBusqueda.SuspendLayout();
            panelEmpleadoDetails.SuspendLayout();
            panelDetailsHeader.SuspendLayout();
            tabControlDetails.SuspendLayout();
            tabPageInfoPersonal.SuspendLayout();
            panelInfoPersonal.SuspendLayout();
            panelDatosBasicos.SuspendLayout();
            panelPrestamosActivos.SuspendLayout();
            panelRegistrarPago.SuspendLayout();
            tabPageComisiones.SuspendLayout();
            panelComisiones.SuspendLayout();
            panelCalculoComisiones.SuspendLayout();
            panelComisionProductos.SuspendLayout();
            panelComisionEfectivo.SuspendLayout();
            panelPeriodo.SuspendLayout();
            tabPageCajaPersonal.SuspendLayout();
            panelCajaPersonal.SuspendLayout();
            panelSaldoActual.SuspendLayout();
            tabPageSemanal.SuspendLayout();
            panelSemanal.SuspendLayout();
            panelResumenSemanal.SuspendLayout();
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
            panelHeader.Size = new Size(1364, 91);
            panelHeader.TabIndex = 0;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.FromArgb(189, 195, 199);
            lblSubtitle.Location = new Point(20, 57);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(303, 19);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Gestión del personal que trabaja con los clientes";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 17);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(174, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "👨‍💼 Empleados";
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.FromArgb(52, 73, 94);
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Segoe UI", 10F);
            btnVolver.ForeColor = Color.White;
            btnVolver.Location = new Point(1250, 25);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(120, 40);
            btnVolver.TabIndex = 2;
            btnVolver.Text = "← Volver";
            btnVolver.UseVisualStyleBackColor = false;
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(236, 240, 241);
            panelMain.Controls.Add(panelEmpleadosList);
            panelMain.Controls.Add(panelEmpleadoDetails);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 91);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(20);
            panelMain.Size = new Size(1364, 658);
            panelMain.TabIndex = 1;
            // 
            // panelEmpleadosList
            // 
            panelEmpleadosList.BackColor = Color.White;
            panelEmpleadosList.Controls.Add(panelBusqueda);
            panelEmpleadosList.Controls.Add(btnAgregarEmpleado);
            panelEmpleadosList.Controls.Add(lblEmpleadosTitle);
            panelEmpleadosList.Controls.Add(listViewEmpleados);
            panelEmpleadosList.Location = new Point(20, 20);
            panelEmpleadosList.Name = "panelEmpleadosList";
            panelEmpleadosList.Padding = new Padding(15);
            panelEmpleadosList.Size = new Size(400, 649);
            panelEmpleadosList.TabIndex = 0;
            // 
            // panelBusqueda
            // 
            panelBusqueda.BackColor = Color.FromArgb(236, 240, 241);
            panelBusqueda.Controls.Add(txtBusqueda);
            panelBusqueda.Controls.Add(lblBusqueda);
            panelBusqueda.Location = new Point(15, 95);
            panelBusqueda.Name = "panelBusqueda";
            panelBusqueda.Padding = new Padding(10);
            panelBusqueda.Size = new Size(370, 60);
            panelBusqueda.TabIndex = 3;
            // 
            // txtBusqueda
            // 
            txtBusqueda.BorderStyle = BorderStyle.FixedSingle;
            txtBusqueda.Font = new Font("Segoe UI", 10F);
            txtBusqueda.Location = new Point(10, 30);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.PlaceholderText = "Ingrese nombre o DNI...";
            txtBusqueda.Size = new Size(350, 25);
            txtBusqueda.TabIndex = 1;
            // 
            // lblBusqueda
            // 
            lblBusqueda.AutoSize = true;
            lblBusqueda.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblBusqueda.ForeColor = Color.FromArgb(52, 73, 94);
            lblBusqueda.Location = new Point(10, 10);
            lblBusqueda.Name = "lblBusqueda";
            lblBusqueda.Size = new Size(207, 19);
            lblBusqueda.TabIndex = 0;
            lblBusqueda.Text = "🔍 Buscar por Nombre o DNI";
            // 
            // btnAgregarEmpleado
            // 
            btnAgregarEmpleado.BackColor = Color.FromArgb(39, 174, 96);
            btnAgregarEmpleado.FlatAppearance.BorderSize = 0;
            btnAgregarEmpleado.FlatStyle = FlatStyle.Flat;
            btnAgregarEmpleado.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAgregarEmpleado.ForeColor = Color.White;
            btnAgregarEmpleado.Location = new Point(15, 50);
            btnAgregarEmpleado.Name = "btnAgregarEmpleado";
            btnAgregarEmpleado.Size = new Size(180, 35);
            btnAgregarEmpleado.TabIndex = 2;
            btnAgregarEmpleado.Text = "➕ Agregar Nuevo Empleado";
            btnAgregarEmpleado.UseVisualStyleBackColor = false;
            // 
            // lblEmpleadosTitle
            // 
            lblEmpleadosTitle.AutoSize = true;
            lblEmpleadosTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblEmpleadosTitle.ForeColor = Color.FromArgb(41, 53, 65);
            lblEmpleadosTitle.Location = new Point(15, 15);
            lblEmpleadosTitle.Name = "lblEmpleadosTitle";
            lblEmpleadosTitle.Size = new Size(180, 25);
            lblEmpleadosTitle.TabIndex = 0;
            lblEmpleadosTitle.Text = "Lista de Empleados";
            // 
            // listViewEmpleados
            // 
            listViewEmpleados.BackColor = Color.White;
            listViewEmpleados.BorderStyle = BorderStyle.None;
            listViewEmpleados.Font = new Font("Segoe UI", 10F);
            listViewEmpleados.FullRowSelect = true;
            listViewEmpleados.GridLines = true;
            listViewEmpleados.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listViewEmpleados.Location = new Point(15, 170);
            listViewEmpleados.MultiSelect = false;
            listViewEmpleados.Name = "listViewEmpleados";
            listViewEmpleados.Size = new Size(370, 464);
            listViewEmpleados.TabIndex = 1;
            listViewEmpleados.UseCompatibleStateImageBehavior = false;
            listViewEmpleados.View = View.Details;
            // 
            // panelEmpleadoDetails
            // 
            panelEmpleadoDetails.BackColor = Color.White;
            panelEmpleadoDetails.Controls.Add(panelDetailsHeader);
            panelEmpleadoDetails.Controls.Add(tabControlDetails);
            panelEmpleadoDetails.Location = new Point(440, 20);
            panelEmpleadoDetails.Name = "panelEmpleadoDetails";
            panelEmpleadoDetails.Padding = new Padding(15);
            panelEmpleadoDetails.Size = new Size(940, 649);
            panelEmpleadoDetails.TabIndex = 1;
            // 
            // panelDetailsHeader
            // 
            panelDetailsHeader.BackColor = Color.FromArgb(52, 73, 94);
            panelDetailsHeader.Controls.Add(lblEmpleadoNombre);
            panelDetailsHeader.Controls.Add(lblEmpleadoInfo);
            panelDetailsHeader.Dock = DockStyle.Top;
            panelDetailsHeader.Location = new Point(15, 15);
            panelDetailsHeader.Name = "panelDetailsHeader";
            panelDetailsHeader.Padding = new Padding(15);
            panelDetailsHeader.Size = new Size(910, 80);
            panelDetailsHeader.TabIndex = 0;
            // 
            // lblEmpleadoNombre
            // 
            lblEmpleadoNombre.AutoSize = true;
            lblEmpleadoNombre.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblEmpleadoNombre.ForeColor = Color.White;
            lblEmpleadoNombre.Location = new Point(15, 15);
            lblEmpleadoNombre.Name = "lblEmpleadoNombre";
            lblEmpleadoNombre.Size = new Size(262, 30);
            lblEmpleadoNombre.TabIndex = 0;
            lblEmpleadoNombre.Text = "Seleccione un empleado";
            // 
            // lblEmpleadoInfo
            // 
            lblEmpleadoInfo.AutoSize = true;
            lblEmpleadoInfo.Font = new Font("Segoe UI", 10F);
            lblEmpleadoInfo.ForeColor = Color.FromArgb(189, 195, 199);
            lblEmpleadoInfo.Location = new Point(15, 50);
            lblEmpleadoInfo.Name = "lblEmpleadoInfo";
            lblEmpleadoInfo.Size = new Size(197, 19);
            lblEmpleadoInfo.TabIndex = 1;
            lblEmpleadoInfo.Text = "Para ver los detalles completos";
            // 
            // tabControlDetails
            // 
            tabControlDetails.Controls.Add(tabPageInfoPersonal);
            tabControlDetails.Controls.Add(tabPageComisiones);
            tabControlDetails.Controls.Add(tabPageCajaPersonal);
            tabControlDetails.Controls.Add(tabPageSemanal);
            tabControlDetails.Font = new Font("Segoe UI", 10F);
            tabControlDetails.Location = new Point(15, 105);
            tabControlDetails.Name = "tabControlDetails";
            tabControlDetails.SelectedIndex = 0;
            tabControlDetails.Size = new Size(910, 529);
            tabControlDetails.TabIndex = 1;
            // 
            // tabPageInfoPersonal
            // 
            tabPageInfoPersonal.BackColor = Color.White;
            tabPageInfoPersonal.Controls.Add(panelInfoPersonal);
            tabPageInfoPersonal.Location = new Point(4, 26);
            tabPageInfoPersonal.Name = "tabPageInfoPersonal";
            tabPageInfoPersonal.Padding = new Padding(10);
            tabPageInfoPersonal.Size = new Size(902, 499);
            tabPageInfoPersonal.TabIndex = 0;
            tabPageInfoPersonal.Text = "👤 Información Personal";
            // 
            // panelInfoPersonal
            // 
            panelInfoPersonal.Controls.Add(panelDatosBasicos);
            panelInfoPersonal.Controls.Add(panelPrestamosActivos);
            panelInfoPersonal.Controls.Add(panelRegistrarPago);
            panelInfoPersonal.Dock = DockStyle.Fill;
            panelInfoPersonal.Location = new Point(10, 10);
            panelInfoPersonal.Name = "panelInfoPersonal";
            panelInfoPersonal.Size = new Size(882, 479);
            panelInfoPersonal.TabIndex = 0;
            // 
            // panelDatosBasicos
            // 
            panelDatosBasicos.BackColor = Color.FromArgb(236, 240, 241);
            panelDatosBasicos.Controls.Add(lblDireccionValor);
            panelDatosBasicos.Controls.Add(lblDireccion);
            panelDatosBasicos.Controls.Add(lblTelefonoValor);
            panelDatosBasicos.Controls.Add(lblTelefono);
            panelDatosBasicos.Controls.Add(lblDNIValor);
            panelDatosBasicos.Controls.Add(lblDNI);
            panelDatosBasicos.Controls.Add(lblNombreCompletoValor);
            panelDatosBasicos.Controls.Add(lblNombreCompleto);
            panelDatosBasicos.Controls.Add(lblDatosBasicos);
            panelDatosBasicos.Location = new Point(0, 0);
            panelDatosBasicos.Name = "panelDatosBasicos";
            panelDatosBasicos.Padding = new Padding(15);
            panelDatosBasicos.Size = new Size(882, 142);
            panelDatosBasicos.TabIndex = 0;
            // 
            // lblDireccionValor
            // 
            lblDireccionValor.AutoSize = true;
            lblDireccionValor.Font = new Font("Segoe UI", 10F);
            lblDireccionValor.ForeColor = Color.FromArgb(44, 62, 80);
            lblDireccionValor.Location = new Point(15, 110);
            lblDireccionValor.Name = "lblDireccionValor";
            lblDireccionValor.Size = new Size(15, 19);
            lblDireccionValor.TabIndex = 8;
            lblDireccionValor.Text = "-";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Font = new Font("Segoe UI", 10F);
            lblDireccion.ForeColor = Color.FromArgb(52, 73, 94);
            lblDireccion.Location = new Point(15, 90);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(68, 19);
            lblDireccion.TabIndex = 7;
            lblDireccion.Text = "Dirección:";
            // 
            // lblTelefonoValor
            // 
            lblTelefonoValor.AutoSize = true;
            lblTelefonoValor.Font = new Font("Segoe UI", 10F);
            lblTelefonoValor.ForeColor = Color.FromArgb(44, 62, 80);
            lblTelefonoValor.Location = new Point(600, 70);
            lblTelefonoValor.Name = "lblTelefonoValor";
            lblTelefonoValor.Size = new Size(15, 19);
            lblTelefonoValor.TabIndex = 6;
            lblTelefonoValor.Text = "-";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 10F);
            lblTelefono.ForeColor = Color.FromArgb(52, 73, 94);
            lblTelefono.Location = new Point(600, 50);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(63, 19);
            lblTelefono.TabIndex = 5;
            lblTelefono.Text = "Teléfono:";
            // 
            // lblDNIValor
            // 
            lblDNIValor.AutoSize = true;
            lblDNIValor.Font = new Font("Segoe UI", 10F);
            lblDNIValor.ForeColor = Color.FromArgb(44, 62, 80);
            lblDNIValor.Location = new Point(400, 70);
            lblDNIValor.Name = "lblDNIValor";
            lblDNIValor.Size = new Size(15, 19);
            lblDNIValor.TabIndex = 4;
            lblDNIValor.Text = "-";
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Font = new Font("Segoe UI", 10F);
            lblDNI.ForeColor = Color.FromArgb(52, 73, 94);
            lblDNI.Location = new Point(400, 50);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(36, 19);
            lblDNI.TabIndex = 3;
            lblDNI.Text = "DNI:";
            // 
            // lblNombreCompletoValor
            // 
            lblNombreCompletoValor.AutoSize = true;
            lblNombreCompletoValor.Font = new Font("Segoe UI", 10F);
            lblNombreCompletoValor.ForeColor = Color.FromArgb(44, 62, 80);
            lblNombreCompletoValor.Location = new Point(15, 70);
            lblNombreCompletoValor.Name = "lblNombreCompletoValor";
            lblNombreCompletoValor.Size = new Size(15, 19);
            lblNombreCompletoValor.TabIndex = 2;
            lblNombreCompletoValor.Text = "-";
            // 
            // lblNombreCompleto
            // 
            lblNombreCompleto.AutoSize = true;
            lblNombreCompleto.Font = new Font("Segoe UI", 10F);
            lblNombreCompleto.ForeColor = Color.FromArgb(52, 73, 94);
            lblNombreCompleto.Location = new Point(15, 50);
            lblNombreCompleto.Name = "lblNombreCompleto";
            lblNombreCompleto.Size = new Size(126, 19);
            lblNombreCompleto.TabIndex = 1;
            lblNombreCompleto.Text = "Nombre Completo:";
            // 
            // lblDatosBasicos
            // 
            lblDatosBasicos.AutoSize = true;
            lblDatosBasicos.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblDatosBasicos.ForeColor = Color.FromArgb(52, 73, 94);
            lblDatosBasicos.Location = new Point(15, 15);
            lblDatosBasicos.Name = "lblDatosBasicos";
            lblDatosBasicos.Size = new Size(114, 21);
            lblDatosBasicos.TabIndex = 0;
            lblDatosBasicos.Text = "Datos Básicos";
            // 
            // panelPrestamosActivos
            // 
            panelPrestamosActivos.BackColor = Color.FromArgb(236, 240, 241);
            panelPrestamosActivos.Controls.Add(listViewPrestamosActivos);
            panelPrestamosActivos.Controls.Add(lblPrestamosActivosInfo);
            panelPrestamosActivos.Location = new Point(0, 148);
            panelPrestamosActivos.Name = "panelPrestamosActivos";
            panelPrestamosActivos.Padding = new Padding(15);
            panelPrestamosActivos.Size = new Size(882, 162);
            panelPrestamosActivos.TabIndex = 1;
            // 
            // listViewPrestamosActivos
            // 
            listViewPrestamosActivos.BackColor = Color.White;
            listViewPrestamosActivos.BorderStyle = BorderStyle.FixedSingle;
            listViewPrestamosActivos.Font = new Font("Segoe UI", 9F);
            listViewPrestamosActivos.FullRowSelect = true;
            listViewPrestamosActivos.GridLines = true;
            listViewPrestamosActivos.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listViewPrestamosActivos.Location = new Point(15, 45);
            listViewPrestamosActivos.Name = "listViewPrestamosActivos";
            listViewPrestamosActivos.Size = new Size(852, 120);
            listViewPrestamosActivos.TabIndex = 1;
            listViewPrestamosActivos.UseCompatibleStateImageBehavior = false;
            listViewPrestamosActivos.View = View.Details;
            // 
            // lblPrestamosActivosInfo
            // 
            lblPrestamosActivosInfo.AutoSize = true;
            lblPrestamosActivosInfo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPrestamosActivosInfo.ForeColor = Color.FromArgb(52, 73, 94);
            lblPrestamosActivosInfo.Location = new Point(15, 15);
            lblPrestamosActivosInfo.Name = "lblPrestamosActivosInfo";
            lblPrestamosActivosInfo.Size = new Size(149, 21);
            lblPrestamosActivosInfo.TabIndex = 0;
            lblPrestamosActivosInfo.Text = "Préstamos Activos";
            // 
            // panelRegistrarPago
            // 
            panelRegistrarPago.BackColor = Color.FromArgb(236, 240, 241);
            panelRegistrarPago.Controls.Add(btnRegistrarPagoInfo);
            panelRegistrarPago.Controls.Add(txtNumeroCuota);
            panelRegistrarPago.Controls.Add(lblNumeroCuota);
            panelRegistrarPago.Controls.Add(dateTimePickerFechaPago);
            panelRegistrarPago.Controls.Add(lblFechaPago);
            panelRegistrarPago.Controls.Add(txtMontoPagoInfo);
            panelRegistrarPago.Controls.Add(lblMontoPagoInfo);
            panelRegistrarPago.Controls.Add(cmbPrestamoSeleccion);
            panelRegistrarPago.Controls.Add(lblPrestamoSeleccion);
            panelRegistrarPago.Controls.Add(lblRegistrarPagoInfo);
            panelRegistrarPago.Location = new Point(0, 320);
            panelRegistrarPago.Name = "panelRegistrarPago";
            panelRegistrarPago.Padding = new Padding(15);
            panelRegistrarPago.Size = new Size(882, 157);
            panelRegistrarPago.TabIndex = 2;
            // 
            // btnRegistrarPagoInfo
            // 
            btnRegistrarPagoInfo.BackColor = Color.FromArgb(39, 174, 96);
            btnRegistrarPagoInfo.FlatAppearance.BorderSize = 0;
            btnRegistrarPagoInfo.FlatStyle = FlatStyle.Flat;
            btnRegistrarPagoInfo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRegistrarPagoInfo.ForeColor = Color.White;
            btnRegistrarPagoInfo.Location = new Point(15, 110);
            btnRegistrarPagoInfo.Name = "btnRegistrarPagoInfo";
            btnRegistrarPagoInfo.Size = new Size(150, 35);
            btnRegistrarPagoInfo.TabIndex = 9;
            btnRegistrarPagoInfo.Text = "💰 Registrar Pago";
            btnRegistrarPagoInfo.UseVisualStyleBackColor = false;
            // 
            // txtNumeroCuota
            // 
            txtNumeroCuota.BorderStyle = BorderStyle.FixedSingle;
            txtNumeroCuota.Font = new Font("Segoe UI", 10F);
            txtNumeroCuota.Location = new Point(700, 70);
            txtNumeroCuota.Name = "txtNumeroCuota";
            txtNumeroCuota.Size = new Size(100, 25);
            txtNumeroCuota.TabIndex = 8;
            // 
            // lblNumeroCuota
            // 
            lblNumeroCuota.AutoSize = true;
            lblNumeroCuota.Font = new Font("Segoe UI", 10F);
            lblNumeroCuota.ForeColor = Color.FromArgb(52, 73, 94);
            lblNumeroCuota.Location = new Point(700, 50);
            lblNumeroCuota.Name = "lblNumeroCuota";
            lblNumeroCuota.Size = new Size(79, 19);
            lblNumeroCuota.TabIndex = 7;
            lblNumeroCuota.Text = "Nro. Cuota:";
            // 
            // dateTimePickerFechaPago
            // 
            dateTimePickerFechaPago.Font = new Font("Segoe UI", 10F);
            dateTimePickerFechaPago.Format = DateTimePickerFormat.Short;
            dateTimePickerFechaPago.Location = new Point(550, 70);
            dateTimePickerFechaPago.Name = "dateTimePickerFechaPago";
            dateTimePickerFechaPago.Size = new Size(120, 25);
            dateTimePickerFechaPago.TabIndex = 6;
            // 
            // lblFechaPago
            // 
            lblFechaPago.AutoSize = true;
            lblFechaPago.Font = new Font("Segoe UI", 10F);
            lblFechaPago.ForeColor = Color.FromArgb(52, 73, 94);
            lblFechaPago.Location = new Point(550, 50);
            lblFechaPago.Name = "lblFechaPago";
            lblFechaPago.Size = new Size(47, 19);
            lblFechaPago.TabIndex = 5;
            lblFechaPago.Text = "Fecha:";
            // 
            // txtMontoPagoInfo
            // 
            txtMontoPagoInfo.BorderStyle = BorderStyle.FixedSingle;
            txtMontoPagoInfo.Font = new Font("Segoe UI", 10F);
            txtMontoPagoInfo.Location = new Point(420, 70);
            txtMontoPagoInfo.Name = "txtMontoPagoInfo";
            txtMontoPagoInfo.Size = new Size(100, 25);
            txtMontoPagoInfo.TabIndex = 4;
            // 
            // lblMontoPagoInfo
            // 
            lblMontoPagoInfo.AutoSize = true;
            lblMontoPagoInfo.Font = new Font("Segoe UI", 10F);
            lblMontoPagoInfo.ForeColor = Color.FromArgb(52, 73, 94);
            lblMontoPagoInfo.Location = new Point(420, 50);
            lblMontoPagoInfo.Name = "lblMontoPagoInfo";
            lblMontoPagoInfo.Size = new Size(54, 19);
            lblMontoPagoInfo.TabIndex = 3;
            lblMontoPagoInfo.Text = "Monto:";
            // 
            // cmbPrestamoSeleccion
            // 
            cmbPrestamoSeleccion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPrestamoSeleccion.Font = new Font("Segoe UI", 10F);
            cmbPrestamoSeleccion.FormattingEnabled = true;
            cmbPrestamoSeleccion.Location = new Point(15, 70);
            cmbPrestamoSeleccion.Name = "cmbPrestamoSeleccion";
            cmbPrestamoSeleccion.Size = new Size(380, 25);
            cmbPrestamoSeleccion.TabIndex = 2;
            // 
            // lblPrestamoSeleccion
            // 
            lblPrestamoSeleccion.AutoSize = true;
            lblPrestamoSeleccion.Font = new Font("Segoe UI", 10F);
            lblPrestamoSeleccion.ForeColor = Color.FromArgb(52, 73, 94);
            lblPrestamoSeleccion.Location = new Point(15, 50);
            lblPrestamoSeleccion.Name = "lblPrestamoSeleccion";
            lblPrestamoSeleccion.Size = new Size(141, 19);
            lblPrestamoSeleccion.TabIndex = 1;
            lblPrestamoSeleccion.Text = "Seleccionar Préstamo:";
            // 
            // lblRegistrarPagoInfo
            // 
            lblRegistrarPagoInfo.AutoSize = true;
            lblRegistrarPagoInfo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblRegistrarPagoInfo.ForeColor = Color.FromArgb(52, 73, 94);
            lblRegistrarPagoInfo.Location = new Point(15, 15);
            lblRegistrarPagoInfo.Name = "lblRegistrarPagoInfo";
            lblRegistrarPagoInfo.Size = new Size(128, 21);
            lblRegistrarPagoInfo.TabIndex = 0;
            lblRegistrarPagoInfo.Text = "Registrar Pagos";
            // 
            // tabPageComisiones
            // 
            tabPageComisiones.BackColor = Color.White;
            tabPageComisiones.Controls.Add(panelComisiones);
            tabPageComisiones.Location = new Point(4, 26);
            tabPageComisiones.Name = "tabPageComisiones";
            tabPageComisiones.Padding = new Padding(10);
            tabPageComisiones.Size = new Size(902, 499);
            tabPageComisiones.TabIndex = 1;
            tabPageComisiones.Text = "💼 Comisiones y Pagos";
            // 
            // panelComisiones
            // 
            panelComisiones.Controls.Add(panelCalculoComisiones);
            panelComisiones.Dock = DockStyle.Fill;
            panelComisiones.Location = new Point(10, 10);
            panelComisiones.Name = "panelComisiones";
            panelComisiones.Size = new Size(882, 479);
            panelComisiones.TabIndex = 0;
            // 
            // panelCalculoComisiones
            // 
            panelCalculoComisiones.BackColor = Color.FromArgb(236, 240, 241);
            panelCalculoComisiones.Controls.Add(btnGenerarPDFDetallado);
            panelCalculoComisiones.Controls.Add(btnMarcarComoPagado);
            panelCalculoComisiones.Controls.Add(btnCalcularPago);
            panelCalculoComisiones.Controls.Add(lblTotalPagar);
            panelCalculoComisiones.Controls.Add(panelComisionProductos);
            panelCalculoComisiones.Controls.Add(panelComisionEfectivo);
            panelCalculoComisiones.Controls.Add(panelPeriodo);
            panelCalculoComisiones.Controls.Add(lblCalculoComisiones);
            panelCalculoComisiones.Dock = DockStyle.Fill;
            panelCalculoComisiones.Location = new Point(0, 0);
            panelCalculoComisiones.Name = "panelCalculoComisiones";
            panelCalculoComisiones.Padding = new Padding(15);
            panelCalculoComisiones.Size = new Size(882, 479);
            panelCalculoComisiones.TabIndex = 0;
            // 
            // btnGenerarPDFDetallado
            // 
            btnGenerarPDFDetallado.BackColor = Color.FromArgb(231, 76, 60);
            btnGenerarPDFDetallado.FlatAppearance.BorderSize = 0;
            btnGenerarPDFDetallado.FlatStyle = FlatStyle.Flat;
            btnGenerarPDFDetallado.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGenerarPDFDetallado.ForeColor = Color.White;
            btnGenerarPDFDetallado.Location = new Point(400, 420);
            btnGenerarPDFDetallado.Name = "btnGenerarPDFDetallado";
            btnGenerarPDFDetallado.Size = new Size(180, 40);
            btnGenerarPDFDetallado.TabIndex = 7;
            btnGenerarPDFDetallado.Text = "📄 Generar PDF Detallado";
            btnGenerarPDFDetallado.UseVisualStyleBackColor = false;
            // 
            // btnMarcarComoPagado
            // 
            btnMarcarComoPagado.BackColor = Color.FromArgb(39, 174, 96);
            btnMarcarComoPagado.FlatAppearance.BorderSize = 0;
            btnMarcarComoPagado.FlatStyle = FlatStyle.Flat;
            btnMarcarComoPagado.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnMarcarComoPagado.ForeColor = Color.White;
            btnMarcarComoPagado.Location = new Point(200, 420);
            btnMarcarComoPagado.Name = "btnMarcarComoPagado";
            btnMarcarComoPagado.Size = new Size(180, 40);
            btnMarcarComoPagado.TabIndex = 6;
            btnMarcarComoPagado.Text = "✅ Marcar como Pagado";
            btnMarcarComoPagado.UseVisualStyleBackColor = false;
            // 
            // btnCalcularPago
            // 
            btnCalcularPago.BackColor = Color.FromArgb(52, 152, 219);
            btnCalcularPago.FlatAppearance.BorderSize = 0;
            btnCalcularPago.FlatStyle = FlatStyle.Flat;
            btnCalcularPago.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCalcularPago.ForeColor = Color.White;
            btnCalcularPago.Location = new Point(15, 420);
            btnCalcularPago.Name = "btnCalcularPago";
            btnCalcularPago.Size = new Size(150, 40);
            btnCalcularPago.TabIndex = 5;
            btnCalcularPago.Text = "\U0001f9ee Calcular Pago";
            btnCalcularPago.UseVisualStyleBackColor = false;
            // 
            // lblTotalPagar
            // 
            lblTotalPagar.AutoSize = true;
            lblTotalPagar.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTotalPagar.ForeColor = Color.FromArgb(39, 174, 96);
            lblTotalPagar.Location = new Point(15, 370);
            lblTotalPagar.Name = "lblTotalPagar";
            lblTotalPagar.Size = new Size(351, 30);
            lblTotalPagar.TabIndex = 4;
            lblTotalPagar.Text = "Total a Pagar al Empleado: $0.00";
            // 
            // panelComisionProductos
            // 
            panelComisionProductos.BackColor = Color.White;
            panelComisionProductos.Controls.Add(lblComisionProductos);
            panelComisionProductos.Controls.Add(lblTotalProductos);
            panelComisionProductos.Controls.Add(lblComisionProductosTitle);
            panelComisionProductos.Location = new Point(450, 180);
            panelComisionProductos.Name = "panelComisionProductos";
            panelComisionProductos.Padding = new Padding(15);
            panelComisionProductos.Size = new Size(417, 120);
            panelComisionProductos.TabIndex = 3;
            // 
            // lblComisionProductos
            // 
            lblComisionProductos.AutoSize = true;
            lblComisionProductos.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblComisionProductos.ForeColor = Color.FromArgb(155, 89, 182);
            lblComisionProductos.Location = new Point(15, 80);
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
            lblTotalProductos.Location = new Point(15, 50);
            lblTotalProductos.Name = "lblTotalProductos";
            lblTotalProductos.Size = new Size(145, 21);
            lblTotalProductos.TabIndex = 1;
            lblTotalProductos.Text = "Total Período: $0.00";
            // 
            // lblComisionProductosTitle
            // 
            lblComisionProductosTitle.AutoSize = true;
            lblComisionProductosTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblComisionProductosTitle.ForeColor = Color.FromArgb(52, 73, 94);
            lblComisionProductosTitle.Location = new Point(15, 15);
            lblComisionProductosTitle.Name = "lblComisionProductosTitle";
            lblComisionProductosTitle.Size = new Size(202, 21);
            lblComisionProductosTitle.TabIndex = 0;
            lblComisionProductosTitle.Text = "Préstamos con Productos";
            // 
            // panelComisionEfectivo
            // 
            panelComisionEfectivo.BackColor = Color.White;
            panelComisionEfectivo.Controls.Add(lblComisionEfectivo);
            panelComisionEfectivo.Controls.Add(lblTotalEfectivo);
            panelComisionEfectivo.Controls.Add(lblComisionEfectivoTitle);
            panelComisionEfectivo.Location = new Point(15, 180);
            panelComisionEfectivo.Name = "panelComisionEfectivo";
            panelComisionEfectivo.Padding = new Padding(15);
            panelComisionEfectivo.Size = new Size(417, 120);
            panelComisionEfectivo.TabIndex = 2;
            // 
            // lblComisionEfectivo
            // 
            lblComisionEfectivo.AutoSize = true;
            lblComisionEfectivo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblComisionEfectivo.ForeColor = Color.FromArgb(39, 174, 96);
            lblComisionEfectivo.Location = new Point(15, 80);
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
            lblTotalEfectivo.Location = new Point(15, 50);
            lblTotalEfectivo.Name = "lblTotalEfectivo";
            lblTotalEfectivo.Size = new Size(145, 21);
            lblTotalEfectivo.TabIndex = 1;
            lblTotalEfectivo.Text = "Total Período: $0.00";
            // 
            // lblComisionEfectivoTitle
            // 
            lblComisionEfectivoTitle.AutoSize = true;
            lblComisionEfectivoTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblComisionEfectivoTitle.ForeColor = Color.FromArgb(52, 73, 94);
            lblComisionEfectivoTitle.Location = new Point(15, 15);
            lblComisionEfectivoTitle.Name = "lblComisionEfectivoTitle";
            lblComisionEfectivoTitle.Size = new Size(162, 21);
            lblComisionEfectivoTitle.TabIndex = 0;
            lblComisionEfectivoTitle.Text = "Créditos en Efectivo";
            // 
            // panelPeriodo
            // 
            panelPeriodo.BackColor = Color.White;
            panelPeriodo.Controls.Add(dateTimePickerHasta);
            panelPeriodo.Controls.Add(lblHasta);
            panelPeriodo.Controls.Add(dateTimePickerDesde);
            panelPeriodo.Controls.Add(lblDesde);
            panelPeriodo.Controls.Add(lblPeriodo);
            panelPeriodo.Location = new Point(15, 80);
            panelPeriodo.Name = "panelPeriodo";
            panelPeriodo.Padding = new Padding(15);
            panelPeriodo.Size = new Size(852, 80);
            panelPeriodo.TabIndex = 1;
            // 
            // dateTimePickerHasta
            // 
            dateTimePickerHasta.Font = new Font("Segoe UI", 10F);
            dateTimePickerHasta.Format = DateTimePickerFormat.Short;
            dateTimePickerHasta.Location = new Point(350, 40);
            dateTimePickerHasta.Name = "dateTimePickerHasta";
            dateTimePickerHasta.Size = new Size(120, 25);
            dateTimePickerHasta.TabIndex = 4;
            // 
            // lblHasta
            // 
            lblHasta.AutoSize = true;
            lblHasta.Font = new Font("Segoe UI", 10F);
            lblHasta.ForeColor = Color.FromArgb(52, 73, 94);
            lblHasta.Location = new Point(300, 43);
            lblHasta.Name = "lblHasta";
            lblHasta.Size = new Size(47, 19);
            lblHasta.TabIndex = 3;
            lblHasta.Text = "Hasta:";
            // 
            // dateTimePickerDesde
            // 
            dateTimePickerDesde.Font = new Font("Segoe UI", 10F);
            dateTimePickerDesde.Format = DateTimePickerFormat.Short;
            dateTimePickerDesde.Location = new Point(170, 40);
            dateTimePickerDesde.Name = "dateTimePickerDesde";
            dateTimePickerDesde.Size = new Size(120, 25);
            dateTimePickerDesde.TabIndex = 2;
            // 
            // lblDesde
            // 
            lblDesde.AutoSize = true;
            lblDesde.Font = new Font("Segoe UI", 10F);
            lblDesde.ForeColor = Color.FromArgb(52, 73, 94);
            lblDesde.Location = new Point(120, 43);
            lblDesde.Name = "lblDesde";
            lblDesde.Size = new Size(50, 19);
            lblDesde.TabIndex = 1;
            lblDesde.Text = "Desde:";
            // 
            // lblPeriodo
            // 
            lblPeriodo.AutoSize = true;
            lblPeriodo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPeriodo.ForeColor = Color.FromArgb(52, 73, 94);
            lblPeriodo.Location = new Point(15, 15);
            lblPeriodo.Name = "lblPeriodo";
            lblPeriodo.Size = new Size(159, 21);
            lblPeriodo.TabIndex = 0;
            lblPeriodo.Text = "Selector de Período";
            // 
            // lblCalculoComisiones
            // 
            lblCalculoComisiones.AutoSize = true;
            lblCalculoComisiones.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblCalculoComisiones.ForeColor = Color.FromArgb(41, 53, 65);
            lblCalculoComisiones.Location = new Point(15, 15);
            lblCalculoComisiones.Name = "lblCalculoComisiones";
            lblCalculoComisiones.Size = new Size(210, 25);
            lblCalculoComisiones.TabIndex = 0;
            lblCalculoComisiones.Text = "Cálculo de Comisiones";
            // 
            // tabPageCajaPersonal
            // 
            tabPageCajaPersonal.BackColor = Color.White;
            tabPageCajaPersonal.Controls.Add(panelCajaPersonal);
            tabPageCajaPersonal.Location = new Point(4, 26);
            tabPageCajaPersonal.Name = "tabPageCajaPersonal";
            tabPageCajaPersonal.Padding = new Padding(10);
            tabPageCajaPersonal.Size = new Size(902, 499);
            tabPageCajaPersonal.TabIndex = 2;
            tabPageCajaPersonal.Text = "💰 Caja Personal";
            // 
            // panelCajaPersonal
            // 
            panelCajaPersonal.Controls.Add(listViewMovimientosCaja);
            panelCajaPersonal.Controls.Add(panelSaldoActual);
            panelCajaPersonal.Controls.Add(lblCajaPersonalTitle);
            panelCajaPersonal.Dock = DockStyle.Fill;
            panelCajaPersonal.Location = new Point(10, 10);
            panelCajaPersonal.Name = "panelCajaPersonal";
            panelCajaPersonal.Size = new Size(882, 479);
            panelCajaPersonal.TabIndex = 0;
            // 
            // listViewMovimientosCaja
            // 
            listViewMovimientosCaja.BackColor = Color.White;
            listViewMovimientosCaja.BorderStyle = BorderStyle.FixedSingle;
            listViewMovimientosCaja.Font = new Font("Segoe UI", 9F);
            listViewMovimientosCaja.FullRowSelect = true;
            listViewMovimientosCaja.GridLines = true;
            listViewMovimientosCaja.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listViewMovimientosCaja.Location = new Point(0, 120);
            listViewMovimientosCaja.Name = "listViewMovimientosCaja";
            listViewMovimientosCaja.Size = new Size(882, 357);
            listViewMovimientosCaja.TabIndex = 2;
            listViewMovimientosCaja.UseCompatibleStateImageBehavior = false;
            listViewMovimientosCaja.View = View.Details;
            // 
            // panelSaldoActual
            // 
            panelSaldoActual.BackColor = Color.FromArgb(39, 174, 96);
            panelSaldoActual.Controls.Add(lblSaldoActual);
            panelSaldoActual.Location = new Point(0, 50);
            panelSaldoActual.Name = "panelSaldoActual";
            panelSaldoActual.Padding = new Padding(20);
            panelSaldoActual.Size = new Size(882, 60);
            panelSaldoActual.TabIndex = 1;
            // 
            // lblSaldoActual
            // 
            lblSaldoActual.AutoSize = true;
            lblSaldoActual.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblSaldoActual.ForeColor = Color.White;
            lblSaldoActual.Location = new Point(20, 15);
            lblSaldoActual.Name = "lblSaldoActual";
            lblSaldoActual.Size = new Size(234, 32);
            lblSaldoActual.TabIndex = 0;
            lblSaldoActual.Text = "Saldo Actual: $0.00";
            // 
            // lblCajaPersonalTitle
            // 
            lblCajaPersonalTitle.AutoSize = true;
            lblCajaPersonalTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblCajaPersonalTitle.ForeColor = Color.FromArgb(41, 53, 65);
            lblCajaPersonalTitle.Location = new Point(0, 15);
            lblCajaPersonalTitle.Name = "lblCajaPersonalTitle";
            lblCajaPersonalTitle.Size = new Size(197, 25);
            lblCajaPersonalTitle.TabIndex = 0;
            lblCajaPersonalTitle.Text = "Movimientos de Caja";
            // 
            // tabPageSemanal
            // 
            tabPageSemanal.BackColor = Color.White;
            tabPageSemanal.Controls.Add(panelSemanal);
            tabPageSemanal.Location = new Point(4, 26);
            tabPageSemanal.Name = "tabPageSemanal";
            tabPageSemanal.Padding = new Padding(10);
            tabPageSemanal.Size = new Size(902, 499);
            tabPageSemanal.TabIndex = 3;
            tabPageSemanal.Text = "📅 Semanal";
            // 
            // panelSemanal
            // 
            panelSemanal.Controls.Add(panelResumenSemanal);
            panelSemanal.Controls.Add(btnDescargarPDFSemanal);
            panelSemanal.Controls.Add(listViewCobrosSemana);
            panelSemanal.Controls.Add(lblCobrosSemanaTitle);
            panelSemanal.Dock = DockStyle.Fill;
            panelSemanal.Location = new Point(10, 10);
            panelSemanal.Name = "panelSemanal";
            panelSemanal.Size = new Size(882, 479);
            panelSemanal.TabIndex = 0;
            // 
            // panelResumenSemanal
            // 
            panelResumenSemanal.BackColor = Color.FromArgb(52, 152, 219);
            panelResumenSemanal.Controls.Add(lblDeberiaRecaudar);
            panelResumenSemanal.Controls.Add(lblTotalRecaudar);
            panelResumenSemanal.Location = new Point(0, 50);
            panelResumenSemanal.Name = "panelResumenSemanal";
            panelResumenSemanal.Padding = new Padding(20);
            panelResumenSemanal.Size = new Size(882, 80);
            panelResumenSemanal.TabIndex = 3;
            // 
            // lblDeberiaRecaudar
            // 
            lblDeberiaRecaudar.AutoSize = true;
            lblDeberiaRecaudar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblDeberiaRecaudar.ForeColor = Color.White;
            lblDeberiaRecaudar.Location = new Point(20, 45);
            lblDeberiaRecaudar.Name = "lblDeberiaRecaudar";
            lblDeberiaRecaudar.Size = new Size(332, 21);
            lblDeberiaRecaudar.TabIndex = 1;
            lblDeberiaRecaudar.Text = "Debería tener después de los cobros: $0.00";
            // 
            // lblTotalRecaudar
            // 
            lblTotalRecaudar.AutoSize = true;
            lblTotalRecaudar.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTotalRecaudar.ForeColor = Color.White;
            lblTotalRecaudar.Location = new Point(20, 15);
            lblTotalRecaudar.Name = "lblTotalRecaudar";
            lblTotalRecaudar.Size = new Size(214, 25);
            lblTotalRecaudar.TabIndex = 0;
            lblTotalRecaudar.Text = "Total a recaudar: $0.00";
            // 
            // btnDescargarPDFSemanal
            // 
            btnDescargarPDFSemanal.BackColor = Color.FromArgb(231, 76, 60);
            btnDescargarPDFSemanal.FlatAppearance.BorderSize = 0;
            btnDescargarPDFSemanal.FlatStyle = FlatStyle.Flat;
            btnDescargarPDFSemanal.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDescargarPDFSemanal.ForeColor = Color.White;
            btnDescargarPDFSemanal.Location = new Point(680, 15);
            btnDescargarPDFSemanal.Name = "btnDescargarPDFSemanal";
            btnDescargarPDFSemanal.Size = new Size(200, 35);
            btnDescargarPDFSemanal.TabIndex = 2;
            btnDescargarPDFSemanal.Text = "📄 Descargar PDF Semanal";
            btnDescargarPDFSemanal.UseVisualStyleBackColor = false;
            // 
            // listViewCobrosSemana
            // 
            listViewCobrosSemana.BackColor = Color.White;
            listViewCobrosSemana.BorderStyle = BorderStyle.FixedSingle;
            listViewCobrosSemana.Font = new Font("Segoe UI", 9F);
            listViewCobrosSemana.FullRowSelect = true;
            listViewCobrosSemana.GridLines = true;
            listViewCobrosSemana.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listViewCobrosSemana.Location = new Point(0, 140);
            listViewCobrosSemana.Name = "listViewCobrosSemana";
            listViewCobrosSemana.Size = new Size(882, 337);
            listViewCobrosSemana.TabIndex = 1;
            listViewCobrosSemana.UseCompatibleStateImageBehavior = false;
            listViewCobrosSemana.View = View.Details;
            // 
            // lblCobrosSemanaTitle
            // 
            lblCobrosSemanaTitle.AutoSize = true;
            lblCobrosSemanaTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblCobrosSemanaTitle.ForeColor = Color.FromArgb(41, 53, 65);
            lblCobrosSemanaTitle.Location = new Point(0, 15);
            lblCobrosSemanaTitle.Name = "lblCobrosSemanaTitle";
            lblCobrosSemanaTitle.Size = new Size(367, 25);
            lblCobrosSemanaTitle.TabIndex = 0;
            lblCobrosSemanaTitle.Text = "Personas que deben cobrar esta semana";
            // 
            // Empleados
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 240, 241);
            ClientSize = new Size(1364, 749);
            Controls.Add(panelMain);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Empleados";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Préstamos - Empleados";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelMain.ResumeLayout(false);
            panelEmpleadosList.ResumeLayout(false);
            panelEmpleadosList.PerformLayout();
            panelBusqueda.ResumeLayout(false);
            panelBusqueda.PerformLayout();
            panelEmpleadoDetails.ResumeLayout(false);
            panelDetailsHeader.ResumeLayout(false);
            panelDetailsHeader.PerformLayout();
            tabControlDetails.ResumeLayout(false);
            tabPageInfoPersonal.ResumeLayout(false);
            panelInfoPersonal.ResumeLayout(false);
            panelDatosBasicos.ResumeLayout(false);
            panelDatosBasicos.PerformLayout();
            panelPrestamosActivos.ResumeLayout(false);
            panelPrestamosActivos.PerformLayout();
            panelRegistrarPago.ResumeLayout(false);
            panelRegistrarPago.PerformLayout();
            tabPageComisiones.ResumeLayout(false);
            panelComisiones.ResumeLayout(false);
            panelCalculoComisiones.ResumeLayout(false);
            panelCalculoComisiones.PerformLayout();
            panelComisionProductos.ResumeLayout(false);
            panelComisionProductos.PerformLayout();
            panelComisionEfectivo.ResumeLayout(false);
            panelComisionEfectivo.PerformLayout();
            panelPeriodo.ResumeLayout(false);
            panelPeriodo.PerformLayout();
            tabPageCajaPersonal.ResumeLayout(false);
            panelCajaPersonal.ResumeLayout(false);
            panelCajaPersonal.PerformLayout();
            panelSaldoActual.ResumeLayout(false);
            panelSaldoActual.PerformLayout();
            tabPageSemanal.ResumeLayout(false);
            panelSemanal.ResumeLayout(false);
            panelSemanal.PerformLayout();
            panelResumenSemanal.ResumeLayout(false);
            panelResumenSemanal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblSubtitle;
        private Label lblTitle;
        private Button btnVolver;
        private Panel panelMain;
        private Panel panelEmpleadosList;
        private Panel panelBusqueda;
        private TextBox txtBusqueda;
        private Label lblBusqueda;
        private Button btnAgregarEmpleado;
        private Label lblEmpleadosTitle;
        private ListView listViewEmpleados;
        private Panel panelEmpleadoDetails;
        private Panel panelDetailsHeader;
        private Label lblEmpleadoNombre;
        private Label lblEmpleadoInfo;
        private TabControl tabControlDetails;
        private TabPage tabPageInfoPersonal;
        private Panel panelInfoPersonal;
        private Panel panelDatosBasicos;
        private Label lblTelefonoValor;
        private Label lblTelefono;
        private Label lblDNIValor;
        private Label lblDNI;
        private Label lblNombreCompletoValor;
        private Label lblNombreCompleto;
        private Label lblDireccionValor;
        private Label lblDireccion;
        private Label lblDatosBasicos;
        private Panel panelPrestamosActivos;
        private ListView listViewPrestamosActivos;
        private Label lblPrestamosActivosInfo;
        private Panel panelRegistrarPago;
        private Button btnRegistrarPagoInfo;
        private TextBox txtNumeroCuota;
        private Label lblNumeroCuota;
        private DateTimePicker dateTimePickerFechaPago;
        private Label lblFechaPago;
        private TextBox txtMontoPagoInfo;
        private Label lblMontoPagoInfo;
        private ComboBox cmbPrestamoSeleccion;
        private Label lblPrestamoSeleccion;
        private Label lblRegistrarPagoInfo;
        private TabPage tabPageComisiones;
        private Panel panelComisiones;
        private Panel panelCalculoComisiones;
        private Button btnGenerarPDFDetallado;
        private Button btnMarcarComoPagado;
        private Button btnCalcularPago;
        private Label lblTotalPagar;
        private Panel panelComisionProductos;
        private Label lblComisionProductos;
        private Label lblTotalProductos;
        private Label lblComisionProductosTitle;
        private Panel panelComisionEfectivo;
        private Label lblComisionEfectivo;
        private Label lblTotalEfectivo;
        private Label lblComisionEfectivoTitle;
        private Panel panelPeriodo;
        private DateTimePicker dateTimePickerHasta;
        private Label lblHasta;
        private DateTimePicker dateTimePickerDesde;
        private Label lblDesde;
        private Label lblPeriodo;
        private Label lblCalculoComisiones;
        private TabPage tabPageCajaPersonal;
        private Panel panelCajaPersonal;
        private ListView listViewMovimientosCaja;
        private Panel panelSaldoActual;
        private Label lblSaldoActual;
        private Label lblCajaPersonalTitle;
        private TabPage tabPageSemanal;
        private Panel panelSemanal;
        private Panel panelResumenSemanal;
        private Label lblDeberiaRecaudar;
        private Label lblTotalRecaudar;
        private Button btnDescargarPDFSemanal;
        private ListView listViewCobrosSemana;
        private Label lblCobrosSemanaTitle;
    }
}