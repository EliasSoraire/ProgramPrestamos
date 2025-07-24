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
            dgvEmpleados = new ListView();
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
            dateTimePickerFechaPago = new DateTimePicker();
            lblFechaPago = new Label();
            txtMontoPagoInfo = new TextBox();
            lblMontoPagoInfo = new Label();
            cmbPrestamoSeleccion = new ComboBox();
            lblPrestamoSeleccion = new Label();
            lblRegistrarPagoInfo = new Label();
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
            panelHeader.Size = new Size(1364, 80);
            panelHeader.TabIndex = 0;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.FromArgb(189, 195, 199);
            lblSubtitle.Location = new Point(20, 50);
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
            lblTitle.Location = new Point(20, 15);
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
            btnVolver.Location = new Point(1223, 25);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(120, 35);
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
            panelMain.Location = new Point(0, 80);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(20, 18, 20, 18);
            panelMain.Size = new Size(1364, 581);
            panelMain.TabIndex = 1;
            // 
            // panelEmpleadosList
            // 
            panelEmpleadosList.BackColor = Color.White;
            panelEmpleadosList.Controls.Add(panelBusqueda);
            panelEmpleadosList.Controls.Add(btnAgregarEmpleado);
            panelEmpleadosList.Controls.Add(lblEmpleadosTitle);
            panelEmpleadosList.Controls.Add(dgvEmpleados);
            panelEmpleadosList.Location = new Point(20, 20);
            panelEmpleadosList.Name = "panelEmpleadosList";
            panelEmpleadosList.Padding = new Padding(15, 13, 15, 13);
            panelEmpleadosList.Size = new Size(400, 573);
            panelEmpleadosList.TabIndex = 0;
            // 
            // panelBusqueda
            // 
            panelBusqueda.BackColor = Color.FromArgb(236, 240, 241);
            panelBusqueda.Controls.Add(txtBusqueda);
            panelBusqueda.Controls.Add(lblBusqueda);
            panelBusqueda.Location = new Point(15, 84);
            panelBusqueda.Name = "panelBusqueda";
            panelBusqueda.Padding = new Padding(10, 9, 10, 9);
            panelBusqueda.Size = new Size(370, 53);
            panelBusqueda.TabIndex = 3;
            // 
            // txtBusqueda
            // 
            txtBusqueda.BorderStyle = BorderStyle.FixedSingle;
            txtBusqueda.Font = new Font("Segoe UI", 10F);
            txtBusqueda.Location = new Point(10, 26);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.PlaceholderText = "Ingrese nombre o DNI...";
            txtBusqueda.Size = new Size(350, 25);
            txtBusqueda.TabIndex = 1;
            txtBusqueda.TextChanged += txtBusqueda_TextChanged;
            // 
            // lblBusqueda
            // 
            lblBusqueda.AutoSize = true;
            lblBusqueda.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblBusqueda.ForeColor = Color.FromArgb(52, 73, 94);
            lblBusqueda.Location = new Point(10, 9);
            lblBusqueda.Name = "lblBusqueda";
            lblBusqueda.Size = new Size(165, 19);
            lblBusqueda.TabIndex = 0;
            lblBusqueda.Text = "🔍 Buscar por Nombre";
            // 
            // btnAgregarEmpleado
            // 
            btnAgregarEmpleado.BackColor = Color.FromArgb(39, 174, 96);
            btnAgregarEmpleado.FlatAppearance.BorderSize = 0;
            btnAgregarEmpleado.FlatStyle = FlatStyle.Flat;
            btnAgregarEmpleado.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAgregarEmpleado.ForeColor = Color.White;
            btnAgregarEmpleado.Location = new Point(15, 44);
            btnAgregarEmpleado.Name = "btnAgregarEmpleado";
            btnAgregarEmpleado.Size = new Size(180, 31);
            btnAgregarEmpleado.TabIndex = 2;
            btnAgregarEmpleado.Text = "➕ Agregar Empleado";
            btnAgregarEmpleado.UseVisualStyleBackColor = false;
            btnAgregarEmpleado.Click += btnAgregarEmpleado_Click;
            // 
            // lblEmpleadosTitle
            // 
            lblEmpleadosTitle.AutoSize = true;
            lblEmpleadosTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblEmpleadosTitle.ForeColor = Color.FromArgb(41, 53, 65);
            lblEmpleadosTitle.Location = new Point(15, 13);
            lblEmpleadosTitle.Name = "lblEmpleadosTitle";
            lblEmpleadosTitle.Size = new Size(180, 25);
            lblEmpleadosTitle.TabIndex = 0;
            lblEmpleadosTitle.Text = "Lista de Empleados";
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.BackColor = Color.White;
            dgvEmpleados.BorderStyle = BorderStyle.None;
            dgvEmpleados.Font = new Font("Segoe UI", 10F);
            dgvEmpleados.FullRowSelect = true;
            dgvEmpleados.GridLines = true;
            dgvEmpleados.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            dgvEmpleados.Location = new Point(15, 170);
            dgvEmpleados.MultiSelect = false;
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.Size = new Size(370, 464);
            dgvEmpleados.TabIndex = 1;
            dgvEmpleados.UseCompatibleStateImageBehavior = false;
            dgvEmpleados.View = View.Details;
            // 
            // panelEmpleadoDetails
            // 
            panelEmpleadoDetails.BackColor = Color.White;
            panelEmpleadoDetails.Controls.Add(panelDetailsHeader);
            panelEmpleadoDetails.Controls.Add(tabControlDetails);
            panelEmpleadoDetails.Location = new Point(440, 18);
            panelEmpleadoDetails.Name = "panelEmpleadoDetails";
            panelEmpleadoDetails.Padding = new Padding(15, 13, 15, 13);
            panelEmpleadoDetails.Size = new Size(940, 573);
            panelEmpleadoDetails.TabIndex = 1;
            // 
            // panelDetailsHeader
            // 
            panelDetailsHeader.BackColor = Color.FromArgb(52, 73, 94);
            panelDetailsHeader.Controls.Add(lblEmpleadoNombre);
            panelDetailsHeader.Controls.Add(lblEmpleadoInfo);
            panelDetailsHeader.Dock = DockStyle.Top;
            panelDetailsHeader.Location = new Point(15, 13);
            panelDetailsHeader.Name = "panelDetailsHeader";
            panelDetailsHeader.Padding = new Padding(15, 13, 15, 13);
            panelDetailsHeader.Size = new Size(910, 71);
            panelDetailsHeader.TabIndex = 0;
            // 
            // lblEmpleadoNombre
            // 
            lblEmpleadoNombre.AutoSize = true;
            lblEmpleadoNombre.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblEmpleadoNombre.ForeColor = Color.White;
            lblEmpleadoNombre.Location = new Point(15, 13);
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
            lblEmpleadoInfo.Location = new Point(15, 44);
            lblEmpleadoInfo.Name = "lblEmpleadoInfo";
            lblEmpleadoInfo.Size = new Size(197, 19);
            lblEmpleadoInfo.TabIndex = 1;
            lblEmpleadoInfo.Text = "Para ver los detalles completos";
            // 
            // tabControlDetails
            // 
            tabControlDetails.Controls.Add(tabPageInfoPersonal);
            tabControlDetails.Font = new Font("Segoe UI", 10F);
            tabControlDetails.Location = new Point(15, 93);
            tabControlDetails.Name = "tabControlDetails";
            tabControlDetails.SelectedIndex = 0;
            tabControlDetails.Size = new Size(910, 467);
            tabControlDetails.TabIndex = 1;
            // 
            // tabPageInfoPersonal
            // 
            tabPageInfoPersonal.BackColor = Color.White;
            tabPageInfoPersonal.Controls.Add(panelInfoPersonal);
            tabPageInfoPersonal.Location = new Point(4, 26);
            tabPageInfoPersonal.Name = "tabPageInfoPersonal";
            tabPageInfoPersonal.Padding = new Padding(10, 9, 10, 9);
            tabPageInfoPersonal.Size = new Size(902, 437);
            tabPageInfoPersonal.TabIndex = 0;
            tabPageInfoPersonal.Text = "👤 Información Personal";
            // 
            // panelInfoPersonal
            // 
            panelInfoPersonal.Controls.Add(panelDatosBasicos);
            panelInfoPersonal.Controls.Add(panelPrestamosActivos);
            panelInfoPersonal.Controls.Add(panelRegistrarPago);
            panelInfoPersonal.Dock = DockStyle.Fill;
            panelInfoPersonal.Location = new Point(10, 9);
            panelInfoPersonal.Name = "panelInfoPersonal";
            panelInfoPersonal.Size = new Size(882, 419);
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
            panelDatosBasicos.Padding = new Padding(15, 13, 15, 13);
            panelDatosBasicos.Size = new Size(882, 125);
            panelDatosBasicos.TabIndex = 0;
            // 
            // lblDireccionValor
            // 
            lblDireccionValor.AutoSize = true;
            lblDireccionValor.Font = new Font("Segoe UI", 10F);
            lblDireccionValor.ForeColor = Color.FromArgb(44, 62, 80);
            lblDireccionValor.Location = new Point(15, 97);
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
            lblDireccion.Location = new Point(15, 79);
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
            lblTelefonoValor.Location = new Point(600, 62);
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
            lblTelefono.Location = new Point(600, 44);
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
            lblDNIValor.Location = new Point(400, 62);
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
            lblDNI.Location = new Point(400, 44);
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
            lblNombreCompletoValor.Location = new Point(15, 62);
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
            lblNombreCompleto.Location = new Point(15, 44);
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
            lblDatosBasicos.Location = new Point(15, 13);
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
            panelPrestamosActivos.Location = new Point(0, 131);
            panelPrestamosActivos.Name = "panelPrestamosActivos";
            panelPrestamosActivos.Padding = new Padding(15, 13, 15, 13);
            panelPrestamosActivos.Size = new Size(882, 143);
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
            listViewPrestamosActivos.Location = new Point(15, 40);
            listViewPrestamosActivos.Name = "listViewPrestamosActivos";
            listViewPrestamosActivos.Size = new Size(852, 106);
            listViewPrestamosActivos.TabIndex = 1;
            listViewPrestamosActivos.UseCompatibleStateImageBehavior = false;
            listViewPrestamosActivos.View = View.Details;
            // 
            // lblPrestamosActivosInfo
            // 
            lblPrestamosActivosInfo.AutoSize = true;
            lblPrestamosActivosInfo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPrestamosActivosInfo.ForeColor = Color.FromArgb(52, 73, 94);
            lblPrestamosActivosInfo.Location = new Point(15, 13);
            lblPrestamosActivosInfo.Name = "lblPrestamosActivosInfo";
            lblPrestamosActivosInfo.Size = new Size(149, 21);
            lblPrestamosActivosInfo.TabIndex = 0;
            lblPrestamosActivosInfo.Text = "Préstamos Activos";
            // 
            // panelRegistrarPago
            // 
            panelRegistrarPago.BackColor = Color.FromArgb(236, 240, 241);
            panelRegistrarPago.Controls.Add(btnRegistrarPagoInfo);
            panelRegistrarPago.Controls.Add(dateTimePickerFechaPago);
            panelRegistrarPago.Controls.Add(lblFechaPago);
            panelRegistrarPago.Controls.Add(txtMontoPagoInfo);
            panelRegistrarPago.Controls.Add(lblMontoPagoInfo);
            panelRegistrarPago.Controls.Add(cmbPrestamoSeleccion);
            panelRegistrarPago.Controls.Add(lblPrestamoSeleccion);
            panelRegistrarPago.Controls.Add(lblRegistrarPagoInfo);
            panelRegistrarPago.Location = new Point(0, 282);
            panelRegistrarPago.Name = "panelRegistrarPago";
            panelRegistrarPago.Padding = new Padding(15, 13, 15, 13);
            panelRegistrarPago.Size = new Size(882, 139);
            panelRegistrarPago.TabIndex = 2;
            // 
            // btnRegistrarPagoInfo
            // 
            btnRegistrarPagoInfo.BackColor = Color.FromArgb(39, 174, 96);
            btnRegistrarPagoInfo.FlatAppearance.BorderSize = 0;
            btnRegistrarPagoInfo.FlatStyle = FlatStyle.Flat;
            btnRegistrarPagoInfo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRegistrarPagoInfo.ForeColor = Color.White;
            btnRegistrarPagoInfo.Location = new Point(15, 97);
            btnRegistrarPagoInfo.Name = "btnRegistrarPagoInfo";
            btnRegistrarPagoInfo.Size = new Size(150, 31);
            btnRegistrarPagoInfo.TabIndex = 9;
            btnRegistrarPagoInfo.Text = "💰 Registrar Pago";
            btnRegistrarPagoInfo.UseVisualStyleBackColor = false;
            btnRegistrarPagoInfo.Click += btnRegistrarPagoInfo_Click;
            // 
            // dateTimePickerFechaPago
            // 
            dateTimePickerFechaPago.Font = new Font("Segoe UI", 10F);
            dateTimePickerFechaPago.Format = DateTimePickerFormat.Short;
            dateTimePickerFechaPago.Location = new Point(550, 62);
            dateTimePickerFechaPago.Name = "dateTimePickerFechaPago";
            dateTimePickerFechaPago.Size = new Size(120, 25);
            dateTimePickerFechaPago.TabIndex = 6;
            // 
            // lblFechaPago
            // 
            lblFechaPago.AutoSize = true;
            lblFechaPago.Font = new Font("Segoe UI", 10F);
            lblFechaPago.ForeColor = Color.FromArgb(52, 73, 94);
            lblFechaPago.Location = new Point(550, 44);
            lblFechaPago.Name = "lblFechaPago";
            lblFechaPago.Size = new Size(47, 19);
            lblFechaPago.TabIndex = 5;
            lblFechaPago.Text = "Fecha:";
            // 
            // txtMontoPagoInfo
            // 
            txtMontoPagoInfo.BorderStyle = BorderStyle.FixedSingle;
            txtMontoPagoInfo.Font = new Font("Segoe UI", 10F);
            txtMontoPagoInfo.Location = new Point(420, 62);
            txtMontoPagoInfo.Name = "txtMontoPagoInfo";
            txtMontoPagoInfo.Size = new Size(100, 25);
            txtMontoPagoInfo.TabIndex = 4;
            // 
            // lblMontoPagoInfo
            // 
            lblMontoPagoInfo.AutoSize = true;
            lblMontoPagoInfo.Font = new Font("Segoe UI", 10F);
            lblMontoPagoInfo.ForeColor = Color.FromArgb(52, 73, 94);
            lblMontoPagoInfo.Location = new Point(420, 44);
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
            cmbPrestamoSeleccion.Location = new Point(15, 62);
            cmbPrestamoSeleccion.Name = "cmbPrestamoSeleccion";
            cmbPrestamoSeleccion.Size = new Size(380, 25);
            cmbPrestamoSeleccion.TabIndex = 2;
            // 
            // lblPrestamoSeleccion
            // 
            lblPrestamoSeleccion.AutoSize = true;
            lblPrestamoSeleccion.Font = new Font("Segoe UI", 10F);
            lblPrestamoSeleccion.ForeColor = Color.FromArgb(52, 73, 94);
            lblPrestamoSeleccion.Location = new Point(15, 44);
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
            lblRegistrarPagoInfo.Location = new Point(15, 13);
            lblRegistrarPagoInfo.Name = "lblRegistrarPagoInfo";
            lblRegistrarPagoInfo.Size = new Size(128, 21);
            lblRegistrarPagoInfo.TabIndex = 0;
            lblRegistrarPagoInfo.Text = "Registrar Pagos";
            // 
            // Empleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 240, 241);
            ClientSize = new Size(1364, 661);
            Controls.Add(panelMain);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Empleados";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Préstamos - Empleados";
            WindowState = FormWindowState.Maximized;
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
        private ListView dgvEmpleados;
        private Panel panelEmpleadoDetails;
        private Panel panelDetailsHeader;
        private Label lblEmpleadoNombre;
        private Label lblEmpleadoInfo;
        private TabControl tabControlDetails;
        private TabPage tabPageInfoPersonal;
        private Panel panelInfoPersonal;
        private Panel panelDatosBasicos;
        private Label lblDireccionValor;
        private Label lblDireccion;
        private Label lblTelefonoValor;
        private Label lblTelefono;
        private Label lblDNIValor;
        private Label lblDNI;
        private Label lblNombreCompletoValor;
        private Label lblNombreCompleto;
        private Label lblDatosBasicos;
        private Panel panelPrestamosActivos;
        private ListView listViewPrestamosActivos;
        private Label lblPrestamosActivosInfo;
        private Panel panelRegistrarPago;
        private Button btnRegistrarPagoInfo;
        private DateTimePicker dateTimePickerFechaPago;
        private Label lblFechaPago;
        private TextBox txtMontoPagoInfo;
        private Label lblMontoPagoInfo;
        private ComboBox cmbPrestamoSeleccion;
        private Label lblPrestamoSeleccion;
        private Label lblRegistrarPagoInfo;
    }
}