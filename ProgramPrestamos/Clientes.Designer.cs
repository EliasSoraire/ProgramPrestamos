namespace ProgramPrestamos
{
    partial class Clientes
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
            panelListado = new Panel();
            lblBuscar = new Label();
            txtBuscar = new TextBox();
            dgvClientes = new DataGridView();
            lblListadoClientes = new Label();
            panelForm = new Panel();
            txtNombreApellido = new TextBox();
            btnCancelar = new Button();
            btnGuardar = new Button();
            cmbEmpleadoAsignado = new ComboBox();
            lblEmpleadoAsignado = new Label();
            txtTelefono = new TextBox();
            lblTelefono = new Label();
            txtDomicilioComercial = new TextBox();
            lblDomicilioComercial = new Label();
            txtDomicilioParticular = new TextBox();
            lblDomicilioParticular = new Label();
            panelFotos = new Panel();
            btnEliminarFotoDorso = new Button();
            btnEliminarFotoFrente = new Button();
            btnCargarFotoDorso = new Button();
            btnCargarFotoFrente = new Button();
            picFotoDorso = new PictureBox();
            picFotoFrente = new PictureBox();
            lblFotosDNI = new Label();
            panelDNI = new Panel();
            lblValidacionDNI = new Label();
            txtDNI = new TextBox();
            lblDNI = new Label();
            lblNombreApellido = new Label();
            lblFormularioCliente = new Label();
            panelHeader.SuspendLayout();
            panelListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            panelForm.SuspendLayout();
            panelFotos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picFotoDorso).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picFotoFrente).BeginInit();
            panelDNI.SuspendLayout();
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
            btnVolver.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnVolver.BackColor = Color.FromArgb(52, 73, 94);
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Segoe UI", 10F);
            btnVolver.ForeColor = Color.White;
            btnVolver.Location = new Point(1050, 25);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(120, 40);
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
            lblSubtitle.Size = new Size(256, 19);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Gestión completa de clientes del sistema";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 17);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(145, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "👥 Clientes";
            // 
            // panelListado
            // 
            panelListado.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelListado.BackColor = Color.White;
            panelListado.Controls.Add(lblBuscar);
            panelListado.Controls.Add(txtBuscar);
            panelListado.Controls.Add(dgvClientes);
            panelListado.Controls.Add(lblListadoClientes);
            panelListado.Location = new Point(598, 106);
            panelListado.Name = "panelListado";
            panelListado.Padding = new Padding(20, 23, 20, 23);
            panelListado.Size = new Size(599, 649);
            panelListado.TabIndex = 3;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblBuscar.ForeColor = Color.FromArgb(52, 73, 94);
            lblBuscar.Location = new Point(23, 70);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(221, 20);
            lblBuscar.TabIndex = 3;
            lblBuscar.Text = "🔍 Buscar por Nombre o DNI:";
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBuscar.Font = new Font("Segoe UI", 10F);
            txtBuscar.Location = new Point(23, 100);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Escriba para buscar...";
            txtBuscar.Size = new Size(539, 25);
            txtBuscar.TabIndex = 2;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvClientes.BackgroundColor = Color.White;
            dgvClientes.BorderStyle = BorderStyle.None;
            dgvClientes.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvClientes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvClientes.ColumnHeadersHeight = 35;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvClientes.GridColor = Color.FromArgb(189, 195, 199);
            dgvClientes.Location = new Point(23, 140);
            dgvClientes.MultiSelect = false;
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowHeadersVisible = false;
            dgvClientes.RowTemplate.Height = 30;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.Size = new Size(539, 496);
            dgvClientes.TabIndex = 1;
            // 
            // lblListadoClientes
            // 
            lblListadoClientes.AutoSize = true;
            lblListadoClientes.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblListadoClientes.ForeColor = Color.FromArgb(41, 53, 65);
            lblListadoClientes.Location = new Point(23, 23);
            lblListadoClientes.Name = "lblListadoClientes";
            lblListadoClientes.Size = new Size(228, 32);
            lblListadoClientes.TabIndex = 0;
            lblListadoClientes.Text = "Listado de Clientes";
            // 
            // panelForm
            // 
            panelForm.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelForm.BackColor = Color.White;
            panelForm.Controls.Add(txtNombreApellido);
            panelForm.Controls.Add(btnCancelar);
            panelForm.Controls.Add(btnGuardar);
            panelForm.Controls.Add(cmbEmpleadoAsignado);
            panelForm.Controls.Add(lblEmpleadoAsignado);
            panelForm.Controls.Add(txtTelefono);
            panelForm.Controls.Add(lblTelefono);
            panelForm.Controls.Add(txtDomicilioComercial);
            panelForm.Controls.Add(lblDomicilioComercial);
            panelForm.Controls.Add(txtDomicilioParticular);
            panelForm.Controls.Add(lblDomicilioParticular);
            panelForm.Controls.Add(panelFotos);
            panelForm.Controls.Add(lblFotosDNI);
            panelForm.Controls.Add(panelDNI);
            panelForm.Controls.Add(lblNombreApellido);
            panelForm.Controls.Add(lblFormularioCliente);
            panelForm.Location = new Point(12, 106);
            panelForm.Name = "panelForm";
            panelForm.Padding = new Padding(20);
            panelForm.Size = new Size(580, 649);
            panelForm.TabIndex = 2;
            // 
            // txtNombreApellido
            // 
            txtNombreApellido.Location = new Point(20, 105);
            txtNombreApellido.Name = "txtNombreApellido";
            txtNombreApellido.PlaceholderText = "Nombre Completo del Cliente";
            txtNombreApellido.Size = new Size(297, 25);
            txtNombreApellido.TabIndex = 23;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCancelar.BackColor = Color.FromArgb(149, 165, 166);
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(286, 571);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(120, 44);
            btnCancelar.TabIndex = 22;
            btnCancelar.Text = "❌ Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnGuardar.BackColor = Color.FromArgb(39, 174, 96);
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(150, 571);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(120, 44);
            btnGuardar.TabIndex = 21;
            btnGuardar.Text = "💾 Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // cmbEmpleadoAsignado
            // 
            cmbEmpleadoAsignado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEmpleadoAsignado.Font = new Font("Segoe UI", 10F);
            cmbEmpleadoAsignado.FormattingEnabled = true;
            cmbEmpleadoAsignado.Location = new Point(290, 510);
            cmbEmpleadoAsignado.Name = "cmbEmpleadoAsignado";
            cmbEmpleadoAsignado.Size = new Size(270, 25);
            cmbEmpleadoAsignado.TabIndex = 15;
            // 
            // lblEmpleadoAsignado
            // 
            lblEmpleadoAsignado.AutoSize = true;
            lblEmpleadoAsignado.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEmpleadoAsignado.ForeColor = Color.FromArgb(52, 73, 94);
            lblEmpleadoAsignado.Location = new Point(296, 485);
            lblEmpleadoAsignado.Name = "lblEmpleadoAsignado";
            lblEmpleadoAsignado.Size = new Size(147, 19);
            lblEmpleadoAsignado.TabIndex = 14;
            lblEmpleadoAsignado.Text = "Empleado Asignado:";
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 10F);
            txtTelefono.Location = new Point(20, 510);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "Ej: +54 9 11 1234-5678";
            txtTelefono.Size = new Size(250, 25);
            txtTelefono.TabIndex = 13;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTelefono.ForeColor = Color.FromArgb(52, 73, 94);
            lblTelefono.Location = new Point(20, 485);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(71, 19);
            lblTelefono.TabIndex = 12;
            lblTelefono.Text = "Teléfono:";
            // 
            // txtDomicilioComercial
            // 
            txtDomicilioComercial.Font = new Font("Segoe UI", 10F);
            txtDomicilioComercial.Location = new Point(20, 445);
            txtDomicilioComercial.Name = "txtDomicilioComercial";
            txtDomicilioComercial.PlaceholderText = "Dirección del negocio o trabajo (opcional)";
            txtDomicilioComercial.Size = new Size(540, 25);
            txtDomicilioComercial.TabIndex = 11;
            // 
            // lblDomicilioComercial
            // 
            lblDomicilioComercial.AutoSize = true;
            lblDomicilioComercial.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDomicilioComercial.ForeColor = Color.FromArgb(52, 73, 94);
            lblDomicilioComercial.Location = new Point(20, 420);
            lblDomicilioComercial.Name = "lblDomicilioComercial";
            lblDomicilioComercial.Size = new Size(149, 19);
            lblDomicilioComercial.TabIndex = 10;
            lblDomicilioComercial.Text = "Domicilio Comercial:";
            // 
            // txtDomicilioParticular
            // 
            txtDomicilioParticular.Font = new Font("Segoe UI", 10F);
            txtDomicilioParticular.Location = new Point(20, 380);
            txtDomicilioParticular.Name = "txtDomicilioParticular";
            txtDomicilioParticular.PlaceholderText = "Dirección completa de la casa";
            txtDomicilioParticular.Size = new Size(540, 25);
            txtDomicilioParticular.TabIndex = 9;
            // 
            // lblDomicilioParticular
            // 
            lblDomicilioParticular.AutoSize = true;
            lblDomicilioParticular.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDomicilioParticular.ForeColor = Color.FromArgb(52, 73, 94);
            lblDomicilioParticular.Location = new Point(20, 355);
            lblDomicilioParticular.Name = "lblDomicilioParticular";
            lblDomicilioParticular.Size = new Size(147, 19);
            lblDomicilioParticular.TabIndex = 8;
            lblDomicilioParticular.Text = "Domicilio Particular:";
            // 
            // panelFotos
            // 
            panelFotos.Controls.Add(btnEliminarFotoDorso);
            panelFotos.Controls.Add(btnEliminarFotoFrente);
            panelFotos.Controls.Add(btnCargarFotoDorso);
            panelFotos.Controls.Add(btnCargarFotoFrente);
            panelFotos.Controls.Add(picFotoDorso);
            panelFotos.Controls.Add(picFotoFrente);
            panelFotos.Location = new Point(20, 210);
            panelFotos.Name = "panelFotos";
            panelFotos.Size = new Size(540, 130);
            panelFotos.TabIndex = 7;
            // 
            // btnEliminarFotoDorso
            // 
            btnEliminarFotoDorso.BackColor = Color.FromArgb(231, 76, 60);
            btnEliminarFotoDorso.FlatAppearance.BorderSize = 0;
            btnEliminarFotoDorso.FlatStyle = FlatStyle.Flat;
            btnEliminarFotoDorso.Font = new Font("Segoe UI", 8F);
            btnEliminarFotoDorso.ForeColor = Color.White;
            btnEliminarFotoDorso.Location = new Point(420, 100);
            btnEliminarFotoDorso.Name = "btnEliminarFotoDorso";
            btnEliminarFotoDorso.Size = new Size(120, 25);
            btnEliminarFotoDorso.TabIndex = 5;
            btnEliminarFotoDorso.Text = "🗑️ Eliminar";
            btnEliminarFotoDorso.UseVisualStyleBackColor = false;
            btnEliminarFotoDorso.Visible = false;
            // 
            // btnEliminarFotoFrente
            // 
            btnEliminarFotoFrente.BackColor = Color.FromArgb(231, 76, 60);
            btnEliminarFotoFrente.FlatAppearance.BorderSize = 0;
            btnEliminarFotoFrente.FlatStyle = FlatStyle.Flat;
            btnEliminarFotoFrente.Font = new Font("Segoe UI", 8F);
            btnEliminarFotoFrente.ForeColor = Color.White;
            btnEliminarFotoFrente.Location = new Point(150, 100);
            btnEliminarFotoFrente.Name = "btnEliminarFotoFrente";
            btnEliminarFotoFrente.Size = new Size(120, 25);
            btnEliminarFotoFrente.TabIndex = 4;
            btnEliminarFotoFrente.Text = "🗑️ Eliminar";
            btnEliminarFotoFrente.UseVisualStyleBackColor = false;
            btnEliminarFotoFrente.Visible = false;
            // 
            // btnCargarFotoDorso
            // 
            btnCargarFotoDorso.BackColor = Color.FromArgb(52, 73, 94);
            btnCargarFotoDorso.FlatAppearance.BorderSize = 0;
            btnCargarFotoDorso.FlatStyle = FlatStyle.Flat;
            btnCargarFotoDorso.Font = new Font("Segoe UI", 9F);
            btnCargarFotoDorso.ForeColor = Color.White;
            btnCargarFotoDorso.Location = new Point(420, 70);
            btnCargarFotoDorso.Name = "btnCargarFotoDorso";
            btnCargarFotoDorso.Size = new Size(120, 29);
            btnCargarFotoDorso.TabIndex = 3;
            btnCargarFotoDorso.Text = "📷 Cargar Dorso";
            btnCargarFotoDorso.UseVisualStyleBackColor = false;
            // 
            // btnCargarFotoFrente
            // 
            btnCargarFotoFrente.BackColor = Color.FromArgb(52, 73, 94);
            btnCargarFotoFrente.FlatAppearance.BorderSize = 0;
            btnCargarFotoFrente.FlatStyle = FlatStyle.Flat;
            btnCargarFotoFrente.Font = new Font("Segoe UI", 9F);
            btnCargarFotoFrente.ForeColor = Color.White;
            btnCargarFotoFrente.Location = new Point(150, 70);
            btnCargarFotoFrente.Name = "btnCargarFotoFrente";
            btnCargarFotoFrente.Size = new Size(120, 29);
            btnCargarFotoFrente.TabIndex = 2;
            btnCargarFotoFrente.Text = "📷 Cargar Frente";
            btnCargarFotoFrente.UseVisualStyleBackColor = false;
            // 
            // picFotoDorso
            // 
            picFotoDorso.BackColor = Color.FromArgb(241, 243, 244);
            picFotoDorso.BorderStyle = BorderStyle.FixedSingle;
            picFotoDorso.Location = new Point(280, 0);
            picFotoDorso.Name = "picFotoDorso";
            picFotoDorso.Size = new Size(130, 65);
            picFotoDorso.SizeMode = PictureBoxSizeMode.Zoom;
            picFotoDorso.TabIndex = 1;
            picFotoDorso.TabStop = false;
            // 
            // picFotoFrente
            // 
            picFotoFrente.BackColor = Color.FromArgb(241, 243, 244);
            picFotoFrente.BorderStyle = BorderStyle.FixedSingle;
            picFotoFrente.Location = new Point(10, 0);
            picFotoFrente.Name = "picFotoFrente";
            picFotoFrente.Size = new Size(130, 65);
            picFotoFrente.SizeMode = PictureBoxSizeMode.Zoom;
            picFotoFrente.TabIndex = 0;
            picFotoFrente.TabStop = false;
            // 
            // lblFotosDNI
            // 
            lblFotosDNI.AutoSize = true;
            lblFotosDNI.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFotosDNI.ForeColor = Color.FromArgb(52, 73, 94);
            lblFotosDNI.Location = new Point(40, 210);
            lblFotosDNI.Name = "lblFotosDNI";
            lblFotosDNI.Size = new Size(200, 19);
            lblFotosDNI.TabIndex = 6;
            lblFotosDNI.Text = "Fotos del DNI (ambas caras):";
            // 
            // panelDNI
            // 
            panelDNI.Controls.Add(lblValidacionDNI);
            panelDNI.Controls.Add(txtDNI);
            panelDNI.Controls.Add(lblDNI);
            panelDNI.Location = new Point(20, 145);
            panelDNI.Name = "panelDNI";
            panelDNI.Size = new Size(540, 50);
            panelDNI.TabIndex = 5;
            // 
            // lblValidacionDNI
            // 
            lblValidacionDNI.AutoSize = true;
            lblValidacionDNI.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblValidacionDNI.ForeColor = Color.FromArgb(127, 140, 141);
            lblValidacionDNI.Location = new Point(220, 25);
            lblValidacionDNI.Name = "lblValidacionDNI";
            lblValidacionDNI.Size = new Size(162, 15);
            lblValidacionDNI.TabIndex = 2;
            lblValidacionDNI.Text = "Se validará automáticamente";
            // 
            // txtDNI
            // 
            txtDNI.Font = new Font("Segoe UI", 10F);
            txtDNI.Location = new Point(0, 25);
            txtDNI.MaxLength = 8;
            txtDNI.Name = "txtDNI";
            txtDNI.PlaceholderText = "Solo números, sin puntos";
            txtDNI.Size = new Size(200, 25);
            txtDNI.TabIndex = 1;
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDNI.ForeColor = Color.FromArgb(52, 73, 94);
            lblDNI.Location = new Point(0, 0);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(38, 19);
            lblDNI.TabIndex = 0;
            lblDNI.Text = "DNI:";
            // 
            // lblNombreApellido
            // 
            lblNombreApellido.AutoSize = true;
            lblNombreApellido.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblNombreApellido.ForeColor = Color.FromArgb(52, 73, 94);
            lblNombreApellido.Location = new Point(20, 80);
            lblNombreApellido.Name = "lblNombreApellido";
            lblNombreApellido.Size = new Size(145, 20);
            lblNombreApellido.TabIndex = 2;
            lblNombreApellido.Text = "Nombre y Apellido:";
            // 
            // lblFormularioCliente
            // 
            lblFormularioCliente.AutoSize = true;
            lblFormularioCliente.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblFormularioCliente.ForeColor = Color.FromArgb(41, 53, 65);
            lblFormularioCliente.Location = new Point(20, 20);
            lblFormularioCliente.Name = "lblFormularioCliente";
            lblFormularioCliente.Size = new Size(261, 32);
            lblFormularioCliente.TabIndex = 0;
            lblFormularioCliente.Text = "Formulario de Cliente";
            // 
            // Clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 240, 241);
            ClientSize = new Size(1200, 749);
            Controls.Add(panelListado);
            Controls.Add(panelForm);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Clientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Préstamos - Gestión de Clientes";
            WindowState = FormWindowState.Maximized;
            Load += Clientes_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelListado.ResumeLayout(false);
            panelListado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            panelForm.ResumeLayout(false);
            panelForm.PerformLayout();
            panelFotos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picFotoDorso).EndInit();
            ((System.ComponentModel.ISupportInitialize)picFotoFrente).EndInit();
            panelDNI.ResumeLayout(false);
            panelDNI.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblTitle;
        private Label lblSubtitle;
        private Button btnVolver;
        private Panel panelListado;
        private Label lblBuscar;
        private TextBox txtBuscar;
        private DataGridView dgvClientes;
        private Label lblListadoClientes;
        private Panel panelForm;
        private ComboBox cmbEmpleadoAsignado;
        private Label lblEmpleadoAsignado;
        private TextBox txtTelefono;
        private Label lblTelefono;
        private TextBox txtDomicilioComercial;
        private Label lblDomicilioComercial;
        private TextBox txtDomicilioParticular;
        private Label lblDomicilioParticular;
        private Panel panelFotos;
        private Button btnEliminarFotoDorso;
        private Button btnEliminarFotoFrente;
        private Button btnCargarFotoDorso;
        private Button btnCargarFotoFrente;
        private PictureBox picFotoDorso;
        private PictureBox picFotoFrente;
        private Label lblFotosDNI;
        private Panel panelDNI;
        private Label lblValidacionDNI;
        private TextBox txtDNI;
        private Label lblDNI;
        private Label lblFormularioCliente;
        private Button btnCancelar;
        private Button btnGuardar;
        private TextBox txtNombreApellido;
        private Label lblNombreApellido;
    }
}
