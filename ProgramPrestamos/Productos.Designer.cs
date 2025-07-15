namespace ProgramPrestamos
{
    partial class Productos
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
            panelNavigation = new Panel();
            btnEliminarProducto = new Button();
            btnEditarProducto = new Button();
            btnAgregarProducto = new Button();
            panelMain = new Panel();
            panelProductInfo = new Panel();
            groupBoxVentaCredito = new GroupBox();
            lblInteresInfo = new Label();
            txtInteres = new TextBox();
            lblInteres = new Label();
            cmbModalidad = new ComboBox();
            lblModalidad = new Label();
            txtCuotas = new TextBox();
            lblCuotas = new Label();
            cmbEmpleado = new ComboBox();
            lblEmpleado = new Label();
            cmbCliente = new ComboBox();
            lblCliente = new Label();
            btnVenderCredito = new Button();
            groupBoxProducto = new GroupBox();
            txtStock = new TextBox();
            lblStock = new Label();
            txtPrecio = new TextBox();
            lblPrecio = new Label();
            txtDescripcion = new TextBox();
            lblDescripcion = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            txtCodigo = new TextBox();
            lblCodigo = new Label();
            btnGuardarProducto = new Button();
            panelProductList = new Panel();
            dgvProductos = new DataGridView();
            lblProductList = new Label();
            panelStats = new Panel();
            lblVentasCredito = new Label();
            lblProductosStock = new Label();
            lblTotalProductos = new Label();
            panelHeader.SuspendLayout();
            panelNavigation.SuspendLayout();
            panelMain.SuspendLayout();
            panelProductInfo.SuspendLayout();
            groupBoxVentaCredito.SuspendLayout();
            groupBoxProducto.SuspendLayout();
            panelProductList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            panelStats.SuspendLayout();
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
            panelHeader.Size = new Size(1200, 91);
            panelHeader.TabIndex = 0;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.FromArgb(231, 76, 60);
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnVolver.ForeColor = Color.White;
            btnVolver.Location = new Point(1089, 20);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(90, 50);
            btnVolver.TabIndex = 2;
            btnVolver.Text = "← Volver";
            btnVolver.UseVisualStyleBackColor = false;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.FromArgb(189, 195, 199);
            lblSubtitle.Location = new Point(20, 57);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(257, 19);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Gestión de productos ofrecidos a crédito";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 17);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(172, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "🛍️ Productos";
            // 
            // panelNavigation
            // 
            panelNavigation.BackColor = Color.FromArgb(52, 73, 94);
            panelNavigation.Controls.Add(btnEliminarProducto);
            panelNavigation.Controls.Add(btnEditarProducto);
            panelNavigation.Controls.Add(btnAgregarProducto);
            panelNavigation.Dock = DockStyle.Left;
            panelNavigation.Location = new Point(0, 91);
            panelNavigation.Name = "panelNavigation";
            panelNavigation.Size = new Size(200, 589);
            panelNavigation.TabIndex = 1;
            // 
            // btnEliminarProducto
            // 
            btnEliminarProducto.BackColor = Color.FromArgb(52, 73, 94);
            btnEliminarProducto.FlatAppearance.BorderSize = 0;
            btnEliminarProducto.FlatStyle = FlatStyle.Flat;
            btnEliminarProducto.Font = new Font("Segoe UI", 10F);
            btnEliminarProducto.ForeColor = Color.White;
            btnEliminarProducto.Location = new Point(0, 114);
            btnEliminarProducto.Name = "btnEliminarProducto";
            btnEliminarProducto.Size = new Size(200, 57);
            btnEliminarProducto.TabIndex = 2;
            btnEliminarProducto.Text = "🗑️ Eliminar Producto";
            btnEliminarProducto.TextAlign = ContentAlignment.MiddleLeft;
            btnEliminarProducto.UseVisualStyleBackColor = false;
            // 
            // btnEditarProducto
            // 
            btnEditarProducto.BackColor = Color.FromArgb(52, 73, 94);
            btnEditarProducto.FlatAppearance.BorderSize = 0;
            btnEditarProducto.FlatStyle = FlatStyle.Flat;
            btnEditarProducto.Font = new Font("Segoe UI", 10F);
            btnEditarProducto.ForeColor = Color.White;
            btnEditarProducto.Location = new Point(0, 57);
            btnEditarProducto.Name = "btnEditarProducto";
            btnEditarProducto.Size = new Size(200, 57);
            btnEditarProducto.TabIndex = 1;
            btnEditarProducto.Text = "✏️ Editar Producto";
            btnEditarProducto.TextAlign = ContentAlignment.MiddleLeft;
            btnEditarProducto.UseVisualStyleBackColor = false;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.BackColor = Color.FromArgb(39, 174, 96);
            btnAgregarProducto.FlatAppearance.BorderSize = 0;
            btnAgregarProducto.FlatStyle = FlatStyle.Flat;
            btnAgregarProducto.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAgregarProducto.ForeColor = Color.White;
            btnAgregarProducto.Location = new Point(0, 0);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(200, 57);
            btnAgregarProducto.TabIndex = 0;
            btnAgregarProducto.Text = "➕ Agregar Producto";
            btnAgregarProducto.TextAlign = ContentAlignment.MiddleLeft;
            btnAgregarProducto.UseVisualStyleBackColor = false;
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(236, 240, 241);
            panelMain.Controls.Add(panelProductInfo);
            panelMain.Controls.Add(panelProductList);
            panelMain.Controls.Add(panelStats);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(200, 91);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1000, 589);
            panelMain.TabIndex = 2;
            // 
            // panelProductInfo
            // 
            panelProductInfo.BackColor = Color.White;
            panelProductInfo.Controls.Add(groupBoxVentaCredito);
            panelProductInfo.Controls.Add(groupBoxProducto);
            panelProductInfo.Location = new Point(20, 111);
            panelProductInfo.Name = "panelProductInfo";
            panelProductInfo.Size = new Size(960, 280);
            panelProductInfo.TabIndex = 2;
            // 
            // groupBoxVentaCredito
            // 
            groupBoxVentaCredito.Controls.Add(lblInteresInfo);
            groupBoxVentaCredito.Controls.Add(txtInteres);
            groupBoxVentaCredito.Controls.Add(lblInteres);
            groupBoxVentaCredito.Controls.Add(cmbModalidad);
            groupBoxVentaCredito.Controls.Add(lblModalidad);
            groupBoxVentaCredito.Controls.Add(txtCuotas);
            groupBoxVentaCredito.Controls.Add(lblCuotas);
            groupBoxVentaCredito.Controls.Add(cmbEmpleado);
            groupBoxVentaCredito.Controls.Add(lblEmpleado);
            groupBoxVentaCredito.Controls.Add(cmbCliente);
            groupBoxVentaCredito.Controls.Add(lblCliente);
            groupBoxVentaCredito.Controls.Add(btnVenderCredito);
            groupBoxVentaCredito.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupBoxVentaCredito.ForeColor = Color.FromArgb(41, 53, 65);
            groupBoxVentaCredito.Location = new Point(500, 20);
            groupBoxVentaCredito.Name = "groupBoxVentaCredito";
            groupBoxVentaCredito.Size = new Size(440, 240);
            groupBoxVentaCredito.TabIndex = 1;
            groupBoxVentaCredito.TabStop = false;
            groupBoxVentaCredito.Text = "💳 Venta a Crédito";
            // 
            // lblInteresInfo
            // 
            lblInteresInfo.AutoSize = true;
            lblInteresInfo.Font = new Font("Segoe UI", 8F);
            lblInteresInfo.ForeColor = Color.FromArgb(127, 140, 141);
            lblInteresInfo.Location = new Point(280, 170);
            lblInteresInfo.Name = "lblInteresInfo";
            lblInteresInfo.Size = new Size(90, 13);
            lblInteresInfo.TabIndex = 11;
            lblInteresInfo.Text = "(Ej: 15 para 15%)";
            // 
            // txtInteres
            // 
            txtInteres.Font = new Font("Segoe UI", 10F);
            txtInteres.Location = new Point(280, 145);
            txtInteres.Name = "txtInteres";
            txtInteres.PlaceholderText = "0";
            txtInteres.Size = new Size(140, 25);
            txtInteres.TabIndex = 10;
            // 
            // lblInteres
            // 
            lblInteres.AutoSize = true;
            lblInteres.Font = new Font("Segoe UI", 10F);
            lblInteres.ForeColor = Color.FromArgb(52, 73, 94);
            lblInteres.Location = new Point(280, 125);
            lblInteres.Name = "lblInteres";
            lblInteres.Size = new Size(77, 19);
            lblInteres.TabIndex = 9;
            lblInteres.Text = "Interés (%):";
            // 
            // cmbModalidad
            // 
            cmbModalidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbModalidad.Font = new Font("Segoe UI", 10F);
            cmbModalidad.FormattingEnabled = true;
            cmbModalidad.Items.AddRange(new object[] { "Diario", "Semanal", "Mensual" });
            cmbModalidad.Location = new Point(20, 145);
            cmbModalidad.Name = "cmbModalidad";
            cmbModalidad.Size = new Size(240, 25);
            cmbModalidad.TabIndex = 8;
            // 
            // lblModalidad
            // 
            lblModalidad.AutoSize = true;
            lblModalidad.Font = new Font("Segoe UI", 10F);
            lblModalidad.ForeColor = Color.FromArgb(52, 73, 94);
            lblModalidad.Location = new Point(20, 125);
            lblModalidad.Name = "lblModalidad";
            lblModalidad.Size = new Size(77, 19);
            lblModalidad.TabIndex = 7;
            lblModalidad.Text = "Modalidad:";
            // 
            // txtCuotas
            // 
            txtCuotas.Font = new Font("Segoe UI", 10F);
            txtCuotas.Location = new Point(280, 97);
            txtCuotas.Name = "txtCuotas";
            txtCuotas.PlaceholderText = "Número de cuotas";
            txtCuotas.Size = new Size(140, 25);
            txtCuotas.TabIndex = 6;
            // 
            // lblCuotas
            // 
            lblCuotas.AutoSize = true;
            lblCuotas.Font = new Font("Segoe UI", 10F);
            lblCuotas.ForeColor = Color.FromArgb(52, 73, 94);
            lblCuotas.Location = new Point(280, 75);
            lblCuotas.Name = "lblCuotas";
            lblCuotas.Size = new Size(55, 19);
            lblCuotas.TabIndex = 5;
            lblCuotas.Text = "Cuotas:";
            // 
            // cmbEmpleado
            // 
            cmbEmpleado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEmpleado.Font = new Font("Segoe UI", 10F);
            cmbEmpleado.FormattingEnabled = true;
            cmbEmpleado.Location = new Point(20, 97);
            cmbEmpleado.Name = "cmbEmpleado";
            cmbEmpleado.Size = new Size(240, 25);
            cmbEmpleado.TabIndex = 4;
            // 
            // lblEmpleado
            // 
            lblEmpleado.AutoSize = true;
            lblEmpleado.Font = new Font("Segoe UI", 10F);
            lblEmpleado.ForeColor = Color.FromArgb(52, 73, 94);
            lblEmpleado.Location = new Point(20, 75);
            lblEmpleado.Name = "lblEmpleado";
            lblEmpleado.Size = new Size(72, 19);
            lblEmpleado.TabIndex = 3;
            lblEmpleado.Text = "Empleado:";
            // 
            // cmbCliente
            // 
            cmbCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCliente.Font = new Font("Segoe UI", 10F);
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(20, 47);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(400, 25);
            cmbCliente.TabIndex = 2;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Segoe UI", 10F);
            lblCliente.ForeColor = Color.FromArgb(52, 73, 94);
            lblCliente.Location = new Point(20, 25);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(54, 19);
            lblCliente.TabIndex = 1;
            lblCliente.Text = "Cliente:";
            // 
            // btnVenderCredito
            // 
            btnVenderCredito.BackColor = Color.FromArgb(39, 174, 96);
            btnVenderCredito.FlatAppearance.BorderSize = 0;
            btnVenderCredito.FlatStyle = FlatStyle.Flat;
            btnVenderCredito.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnVenderCredito.ForeColor = Color.White;
            btnVenderCredito.Location = new Point(20, 190);
            btnVenderCredito.Name = "btnVenderCredito";
            btnVenderCredito.Size = new Size(400, 35);
            btnVenderCredito.TabIndex = 0;
            btnVenderCredito.Text = "💰 Vender a Crédito";
            btnVenderCredito.UseVisualStyleBackColor = false;
            // 
            // groupBoxProducto
            // 
            groupBoxProducto.Controls.Add(txtStock);
            groupBoxProducto.Controls.Add(lblStock);
            groupBoxProducto.Controls.Add(txtPrecio);
            groupBoxProducto.Controls.Add(lblPrecio);
            groupBoxProducto.Controls.Add(txtDescripcion);
            groupBoxProducto.Controls.Add(lblDescripcion);
            groupBoxProducto.Controls.Add(txtNombre);
            groupBoxProducto.Controls.Add(lblNombre);
            groupBoxProducto.Controls.Add(txtCodigo);
            groupBoxProducto.Controls.Add(lblCodigo);
            groupBoxProducto.Controls.Add(btnGuardarProducto);
            groupBoxProducto.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupBoxProducto.ForeColor = Color.FromArgb(41, 53, 65);
            groupBoxProducto.Location = new Point(20, 20);
            groupBoxProducto.Name = "groupBoxProducto";
            groupBoxProducto.Size = new Size(460, 240);
            groupBoxProducto.TabIndex = 0;
            groupBoxProducto.TabStop = false;
            groupBoxProducto.Text = "📦 Información del Producto";
            // 
            // txtStock
            // 
            txtStock.Font = new Font("Segoe UI", 10F);
            txtStock.Location = new Point(310, 97);
            txtStock.Name = "txtStock";
            txtStock.PlaceholderText = "Cantidad disponible";
            txtStock.Size = new Size(130, 25);
            txtStock.TabIndex = 10;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Segoe UI", 10F);
            lblStock.ForeColor = Color.FromArgb(52, 73, 94);
            lblStock.Location = new Point(310, 77);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(45, 19);
            lblStock.TabIndex = 9;
            lblStock.Text = "Stock:";
            // 
            // txtPrecio
            // 
            txtPrecio.Font = new Font("Segoe UI", 10F);
            txtPrecio.Location = new Point(160, 97);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.PlaceholderText = "0.00";
            txtPrecio.Size = new Size(130, 25);
            txtPrecio.TabIndex = 8;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 10F);
            lblPrecio.ForeColor = Color.FromArgb(52, 73, 94);
            lblPrecio.Location = new Point(160, 77);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(49, 19);
            lblPrecio.TabIndex = 7;
            lblPrecio.Text = "Precio:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Font = new Font("Segoe UI", 10F);
            txtDescripcion.Location = new Point(20, 135);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.PlaceholderText = "Descripción del producto...";
            txtDescripcion.Size = new Size(420, 45);
            txtDescripcion.TabIndex = 6;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI", 10F);
            lblDescripcion.ForeColor = Color.FromArgb(52, 73, 94);
            lblDescripcion.Location = new Point(20, 115);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(82, 19);
            lblDescripcion.TabIndex = 5;
            lblDescripcion.Text = "Descripción:";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 10F);
            txtNombre.Location = new Point(160, 47);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre del producto";
            txtNombre.Size = new Size(280, 25);
            txtNombre.TabIndex = 4;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 10F);
            lblNombre.ForeColor = Color.FromArgb(52, 73, 94);
            lblNombre.Location = new Point(160, 25);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(62, 19);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre:";
            // 
            // txtCodigo
            // 
            txtCodigo.Font = new Font("Segoe UI", 10F);
            txtCodigo.Location = new Point(20, 47);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.PlaceholderText = "PROD001";
            txtCodigo.Size = new Size(120, 25);
            txtCodigo.TabIndex = 2;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Segoe UI", 10F);
            lblCodigo.ForeColor = Color.FromArgb(52, 73, 94);
            lblCodigo.Location = new Point(20, 25);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(56, 19);
            lblCodigo.TabIndex = 1;
            lblCodigo.Text = "Código:";
            // 
            // btnGuardarProducto
            // 
            btnGuardarProducto.BackColor = Color.FromArgb(41, 128, 185);
            btnGuardarProducto.FlatAppearance.BorderSize = 0;
            btnGuardarProducto.FlatStyle = FlatStyle.Flat;
            btnGuardarProducto.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnGuardarProducto.ForeColor = Color.White;
            btnGuardarProducto.Location = new Point(20, 190);
            btnGuardarProducto.Name = "btnGuardarProducto";
            btnGuardarProducto.Size = new Size(420, 35);
            btnGuardarProducto.TabIndex = 0;
            btnGuardarProducto.Text = "💾 Guardar Producto";
            btnGuardarProducto.UseVisualStyleBackColor = false;
            // 
            // panelProductList
            // 
            panelProductList.BackColor = Color.White;
            panelProductList.Controls.Add(dgvProductos);
            panelProductList.Controls.Add(lblProductList);
            panelProductList.Location = new Point(20, 410);
            panelProductList.Name = "panelProductList";
            panelProductList.Size = new Size(960, 160);
            panelProductList.TabIndex = 1;
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.BackgroundColor = Color.White;
            dgvProductos.BorderStyle = BorderStyle.None;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(20, 45);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.Size = new Size(920, 100);
            dgvProductos.TabIndex = 1;
            // 
            // lblProductList
            // 
            lblProductList.AutoSize = true;
            lblProductList.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblProductList.ForeColor = Color.FromArgb(41, 53, 65);
            lblProductList.Location = new Point(20, 17);
            lblProductList.Name = "lblProductList";
            lblProductList.Size = new Size(199, 25);
            lblProductList.TabIndex = 0;
            lblProductList.Text = "📋 Lista de Productos";
            // 
            // panelStats
            // 
            panelStats.BackColor = Color.FromArgb(236, 240, 241);
            panelStats.Controls.Add(lblVentasCredito);
            panelStats.Controls.Add(lblProductosStock);
            panelStats.Controls.Add(lblTotalProductos);
            panelStats.Location = new Point(20, 20);
            panelStats.Name = "panelStats";
            panelStats.Size = new Size(960, 70);
            panelStats.TabIndex = 0;
            // 
            // lblVentasCredito
            // 
            lblVentasCredito.AutoSize = true;
            lblVentasCredito.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblVentasCredito.ForeColor = Color.FromArgb(39, 174, 96);
            lblVentasCredito.Location = new Point(650, 25);
            lblVentasCredito.Name = "lblVentasCredito";
            lblVentasCredito.Size = new Size(138, 21);
            lblVentasCredito.TabIndex = 2;
            lblVentasCredito.Text = "Ventas Crédito: 0";
            // 
            // lblProductosStock
            // 
            lblProductosStock.AutoSize = true;
            lblProductosStock.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblProductosStock.ForeColor = Color.FromArgb(230, 126, 34);
            lblProductosStock.Location = new Point(330, 25);
            lblProductosStock.Name = "lblProductosStock";
            lblProductosStock.Size = new Size(130, 21);
            lblProductosStock.TabIndex = 1;
            lblProductosStock.Text = "En Stock Bajo: 0";
            // 
            // lblTotalProductos
            // 
            lblTotalProductos.AutoSize = true;
            lblTotalProductos.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTotalProductos.ForeColor = Color.FromArgb(52, 73, 94);
            lblTotalProductos.Location = new Point(20, 25);
            lblTotalProductos.Name = "lblTotalProductos";
            lblTotalProductos.Size = new Size(146, 21);
            lblTotalProductos.TabIndex = 0;
            lblTotalProductos.Text = "Total Productos: 0";
            // 
            // Productos
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 240, 241);
            ClientSize = new Size(1200, 680);
            Controls.Add(panelMain);
            Controls.Add(panelNavigation);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Productos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Préstamos - Productos";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelNavigation.ResumeLayout(false);
            panelMain.ResumeLayout(false);
            panelProductInfo.ResumeLayout(false);
            groupBoxVentaCredito.ResumeLayout(false);
            groupBoxVentaCredito.PerformLayout();
            groupBoxProducto.ResumeLayout(false);
            groupBoxProducto.PerformLayout();
            panelProductList.ResumeLayout(false);
            panelProductList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            panelStats.ResumeLayout(false);
            panelStats.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Panel panelNavigation;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Button btnEditarProducto;
        private System.Windows.Forms.Button btnEliminarProducto;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelStats;
        private System.Windows.Forms.Label lblTotalProductos;
        private System.Windows.Forms.Label lblProductosStock;
        private System.Windows.Forms.Label lblVentasCredito;
        private System.Windows.Forms.Panel panelProductInfo;
        private System.Windows.Forms.GroupBox groupBoxProducto;
        private System.Windows.Forms.Button btnGuardarProducto;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.GroupBox groupBoxVentaCredito;
        private System.Windows.Forms.Button btnVenderCredito;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.ComboBox cmbEmpleado;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.TextBox txtCuotas;
        private System.Windows.Forms.Label lblCuotas;
        private System.Windows.Forms.ComboBox cmbModalidad;
        private System.Windows.Forms.Label lblModalidad;
        private System.Windows.Forms.TextBox txtInteres;
        private System.Windows.Forms.Label lblInteres;
        private System.Windows.Forms.Label lblInteresInfo;
        private System.Windows.Forms.Panel panelProductList;
        private System.Windows.Forms.Label lblProductList;
        private System.Windows.Forms.DataGridView dgvProductos;
    }
}