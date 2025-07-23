namespace ProgramPrestamos
{
    partial class Caja
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
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            panelContent = new Panel();
            groupBoxEmpleados = new GroupBox();
            btnAsignarDinero = new Button();
            comboBoxEmpleados = new ComboBox();
            lblEmpleado = new Label();
            lblDineroAsignado = new Label();
            txtDineroAsignado = new TextBox();
            groupBoxOperaciones = new GroupBox();
            btnVerDetalles = new Button();
            btnVerMovimientos = new Button();
            btnControlIngresos = new Button();
            btnControlEgresos = new Button();
            groupBoxResumen = new GroupBox();
            dataGridViewMovimientos = new DataGridView();
            lblTotalIngresos = new Label();
            lblTotalEgresos = new Label();
            lblSaldoActual = new Label();
            txtTotalIngresos = new TextBox();
            txtTotalEgresos = new TextBox();
            txtSaldoActual = new TextBox();
            btnActualizar = new Button();
            btnCerrar = new Button();
            panelHeader.SuspendLayout();
            panelContent.SuspendLayout();
            groupBoxEmpleados.SuspendLayout();
            groupBoxOperaciones.SuspendLayout();
            groupBoxResumen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMovimientos).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(52, 73, 94);
            panelHeader.Controls.Add(lblTitulo);
            panelHeader.Controls.Add(lblSubtitulo);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(4, 3, 4, 3);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1364, 130);
            panelHeader.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(23, 19);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(154, 45);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "💵 CAJA";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 12F);
            lblSubtitulo.ForeColor = Color.LightGray;
            lblSubtitulo.Location = new Point(29, 85);
            lblSubtitulo.Margin = new Padding(4, 0, 4, 0);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(346, 21);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Control del dinero manejado por cada empleado";
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.FromArgb(236, 240, 241);
            panelContent.Controls.Add(groupBoxEmpleados);
            panelContent.Controls.Add(groupBoxOperaciones);
            panelContent.Controls.Add(groupBoxResumen);
            panelContent.Controls.Add(btnActualizar);
            panelContent.Controls.Add(btnCerrar);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 130);
            panelContent.Margin = new Padding(4, 3, 4, 3);
            panelContent.Name = "panelContent";
            panelContent.Padding = new Padding(23, 26, 23, 26);
            panelContent.Size = new Size(1364, 619);
            panelContent.TabIndex = 1;
            // 
            // groupBoxEmpleados
            // 
            groupBoxEmpleados.Controls.Add(btnAsignarDinero);
            groupBoxEmpleados.Controls.Add(comboBoxEmpleados);
            groupBoxEmpleados.Controls.Add(lblEmpleado);
            groupBoxEmpleados.Controls.Add(lblDineroAsignado);
            groupBoxEmpleados.Controls.Add(txtDineroAsignado);
            groupBoxEmpleados.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBoxEmpleados.Location = new Point(35, 40);
            groupBoxEmpleados.Margin = new Padding(4, 3, 4, 3);
            groupBoxEmpleados.Name = "groupBoxEmpleados";
            groupBoxEmpleados.Padding = new Padding(4, 3, 4, 3);
            groupBoxEmpleados.Size = new Size(653, 156);
            groupBoxEmpleados.TabIndex = 0;
            groupBoxEmpleados.TabStop = false;
            groupBoxEmpleados.Text = "Selección de Empleado";
            // 
            // btnAsignarDinero
            // 
            btnAsignarDinero.BackColor = Color.FromArgb(46, 204, 113);
            btnAsignarDinero.FlatAppearance.BorderSize = 0;
            btnAsignarDinero.FlatStyle = FlatStyle.Flat;
            btnAsignarDinero.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnAsignarDinero.ForeColor = Color.White;
            btnAsignarDinero.Location = new Point(533, 113);
            btnAsignarDinero.Margin = new Padding(4, 3, 4, 3);
            btnAsignarDinero.Name = "btnAsignarDinero";
            btnAsignarDinero.Size = new Size(112, 36);
            btnAsignarDinero.TabIndex = 4;
            btnAsignarDinero.Text = "Asignar";
            btnAsignarDinero.UseVisualStyleBackColor = false;
            // 
            // comboBoxEmpleados
            // 
            comboBoxEmpleados.Font = new Font("Segoe UI", 11F);
            comboBoxEmpleados.FormattingEnabled = true;
            comboBoxEmpleados.Location = new Point(175, 45);
            comboBoxEmpleados.Margin = new Padding(4, 3, 4, 3);
            comboBoxEmpleados.Name = "comboBoxEmpleados";
            comboBoxEmpleados.Size = new Size(443, 28);
            comboBoxEmpleados.TabIndex = 1;
            // 
            // lblEmpleado
            // 
            lblEmpleado.AutoSize = true;
            lblEmpleado.Font = new Font("Segoe UI", 11F);
            lblEmpleado.Location = new Point(23, 50);
            lblEmpleado.Margin = new Padding(4, 0, 4, 0);
            lblEmpleado.Name = "lblEmpleado";
            lblEmpleado.Size = new Size(80, 20);
            lblEmpleado.TabIndex = 0;
            lblEmpleado.Text = "Empleado:";
            // 
            // lblDineroAsignado
            // 
            lblDineroAsignado.AutoSize = true;
            lblDineroAsignado.Font = new Font("Segoe UI", 11F);
            lblDineroAsignado.Location = new Point(23, 102);
            lblDineroAsignado.Margin = new Padding(4, 0, 4, 0);
            lblDineroAsignado.Name = "lblDineroAsignado";
            lblDineroAsignado.Size = new Size(124, 20);
            lblDineroAsignado.TabIndex = 2;
            lblDineroAsignado.Text = "Dinero Asignado:";
            // 
            // txtDineroAsignado
            // 
            txtDineroAsignado.Font = new Font("Segoe UI", 11F);
            txtDineroAsignado.Location = new Point(175, 99);
            txtDineroAsignado.Margin = new Padding(4, 3, 4, 3);
            txtDineroAsignado.Name = "txtDineroAsignado";
            txtDineroAsignado.Size = new Size(233, 27);
            txtDineroAsignado.TabIndex = 3;
            // 
            // groupBoxOperaciones
            // 
            groupBoxOperaciones.Controls.Add(btnVerDetalles);
            groupBoxOperaciones.Controls.Add(btnVerMovimientos);
            groupBoxOperaciones.Controls.Add(btnControlIngresos);
            groupBoxOperaciones.Controls.Add(btnControlEgresos);
            groupBoxOperaciones.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBoxOperaciones.Location = new Point(712, 40);
            groupBoxOperaciones.Margin = new Padding(4, 3, 4, 3);
            groupBoxOperaciones.Name = "groupBoxOperaciones";
            groupBoxOperaciones.Padding = new Padding(4, 3, 4, 3);
            groupBoxOperaciones.Size = new Size(653, 198);
            groupBoxOperaciones.TabIndex = 1;
            groupBoxOperaciones.TabStop = false;
            groupBoxOperaciones.Text = "Operaciones";
            // 
            // btnVerDetalles
            // 
            btnVerDetalles.BackColor = Color.FromArgb(46, 204, 113);
            btnVerDetalles.FlatAppearance.BorderSize = 0;
            btnVerDetalles.FlatStyle = FlatStyle.Flat;
            btnVerDetalles.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnVerDetalles.ForeColor = Color.White;
            btnVerDetalles.Location = new Point(23, 45);
            btnVerDetalles.Margin = new Padding(4, 3, 4, 3);
            btnVerDetalles.Name = "btnVerDetalles";
            btnVerDetalles.Size = new Size(292, 59);
            btnVerDetalles.TabIndex = 0;
            btnVerDetalles.Text = "Ver Detalles";
            btnVerDetalles.UseVisualStyleBackColor = false;
            btnVerDetalles.Click += btnVerDetalles_Click;
            // 
            // btnVerMovimientos
            // 
            btnVerMovimientos.BackColor = Color.FromArgb(52, 152, 219);
            btnVerMovimientos.FlatAppearance.BorderSize = 0;
            btnVerMovimientos.FlatStyle = FlatStyle.Flat;
            btnVerMovimientos.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnVerMovimientos.ForeColor = Color.White;
            btnVerMovimientos.Location = new Point(338, 45);
            btnVerMovimientos.Margin = new Padding(4, 3, 4, 3);
            btnVerMovimientos.Name = "btnVerMovimientos";
            btnVerMovimientos.Size = new Size(292, 59);
            btnVerMovimientos.TabIndex = 1;
            btnVerMovimientos.Text = "📊 Ver Movimientos";
            btnVerMovimientos.UseVisualStyleBackColor = false;
            btnVerMovimientos.Click += btnVerMovimientos_Click;
            // 
            // btnControlIngresos
            // 
            btnControlIngresos.BackColor = Color.FromArgb(155, 89, 182);
            btnControlIngresos.FlatAppearance.BorderSize = 0;
            btnControlIngresos.FlatStyle = FlatStyle.Flat;
            btnControlIngresos.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnControlIngresos.ForeColor = Color.White;
            btnControlIngresos.Location = new Point(23, 130);
            btnControlIngresos.Margin = new Padding(4, 3, 4, 3);
            btnControlIngresos.Name = "btnControlIngresos";
            btnControlIngresos.Size = new Size(292, 59);
            btnControlIngresos.TabIndex = 2;
            btnControlIngresos.Text = "📈 Control de Ingresos";
            btnControlIngresos.UseVisualStyleBackColor = false;
            // 
            // btnControlEgresos
            // 
            btnControlEgresos.BackColor = Color.FromArgb(231, 76, 60);
            btnControlEgresos.FlatAppearance.BorderSize = 0;
            btnControlEgresos.FlatStyle = FlatStyle.Flat;
            btnControlEgresos.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnControlEgresos.ForeColor = Color.White;
            btnControlEgresos.Location = new Point(338, 130);
            btnControlEgresos.Margin = new Padding(4, 3, 4, 3);
            btnControlEgresos.Name = "btnControlEgresos";
            btnControlEgresos.Size = new Size(292, 59);
            btnControlEgresos.TabIndex = 3;
            btnControlEgresos.Text = "📉 Control de Egresos";
            btnControlEgresos.UseVisualStyleBackColor = false;
            // 
            // groupBoxResumen
            // 
            groupBoxResumen.Controls.Add(dataGridViewMovimientos);
            groupBoxResumen.Controls.Add(lblTotalIngresos);
            groupBoxResumen.Controls.Add(lblTotalEgresos);
            groupBoxResumen.Controls.Add(lblSaldoActual);
            groupBoxResumen.Controls.Add(txtTotalIngresos);
            groupBoxResumen.Controls.Add(txtTotalEgresos);
            groupBoxResumen.Controls.Add(txtSaldoActual);
            groupBoxResumen.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            groupBoxResumen.Location = new Point(35, 222);
            groupBoxResumen.Margin = new Padding(4, 3, 4, 3);
            groupBoxResumen.Name = "groupBoxResumen";
            groupBoxResumen.Padding = new Padding(4, 3, 4, 3);
            groupBoxResumen.Size = new Size(1330, 524);
            groupBoxResumen.TabIndex = 2;
            groupBoxResumen.TabStop = false;
            groupBoxResumen.Text = "Resumen de Movimientos";
            // 
            // dataGridViewMovimientos
            // 
            dataGridViewMovimientos.AllowUserToAddRows = false;
            dataGridViewMovimientos.AllowUserToDeleteRows = false;
            dataGridViewMovimientos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMovimientos.BackgroundColor = Color.White;
            dataGridViewMovimientos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMovimientos.Location = new Point(0, 39);
            dataGridViewMovimientos.Margin = new Padding(4, 3, 4, 3);
            dataGridViewMovimientos.Name = "dataGridViewMovimientos";
            dataGridViewMovimientos.ReadOnly = true;
            dataGridViewMovimientos.Size = new Size(1298, 346);
            dataGridViewMovimientos.TabIndex = 0;
            // 
            // lblTotalIngresos
            // 
            lblTotalIngresos.AutoSize = true;
            lblTotalIngresos.Font = new Font("Segoe UI", 11F);
            lblTotalIngresos.Location = new Point(23, 406);
            lblTotalIngresos.Margin = new Padding(4, 0, 4, 0);
            lblTotalIngresos.Name = "lblTotalIngresos";
            lblTotalIngresos.Size = new Size(104, 20);
            lblTotalIngresos.TabIndex = 1;
            lblTotalIngresos.Text = "Total Ingresos:";
            // 
            // lblTotalEgresos
            // 
            lblTotalEgresos.AutoSize = true;
            lblTotalEgresos.Font = new Font("Segoe UI", 11F);
            lblTotalEgresos.Location = new Point(467, 406);
            lblTotalEgresos.Margin = new Padding(4, 0, 4, 0);
            lblTotalEgresos.Name = "lblTotalEgresos";
            lblTotalEgresos.Size = new Size(100, 20);
            lblTotalEgresos.TabIndex = 3;
            lblTotalEgresos.Text = "Total Egresos:";
            // 
            // lblSaldoActual
            // 
            lblSaldoActual.AutoSize = true;
            lblSaldoActual.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblSaldoActual.Location = new Point(910, 406);
            lblSaldoActual.Margin = new Padding(4, 0, 4, 0);
            lblSaldoActual.Name = "lblSaldoActual";
            lblSaldoActual.Size = new Size(100, 20);
            lblSaldoActual.TabIndex = 5;
            lblSaldoActual.Text = "Saldo Actual:";
            // 
            // txtTotalIngresos
            // 
            txtTotalIngresos.Font = new Font("Segoe UI", 11F);
            txtTotalIngresos.Location = new Point(163, 401);
            txtTotalIngresos.Margin = new Padding(4, 3, 4, 3);
            txtTotalIngresos.Name = "txtTotalIngresos";
            txtTotalIngresos.ReadOnly = true;
            txtTotalIngresos.Size = new Size(174, 27);
            txtTotalIngresos.TabIndex = 2;
            txtTotalIngresos.TextAlign = HorizontalAlignment.Right;
            // 
            // txtTotalEgresos
            // 
            txtTotalEgresos.Font = new Font("Segoe UI", 11F);
            txtTotalEgresos.Location = new Point(607, 401);
            txtTotalEgresos.Margin = new Padding(4, 3, 4, 3);
            txtTotalEgresos.Name = "txtTotalEgresos";
            txtTotalEgresos.ReadOnly = true;
            txtTotalEgresos.Size = new Size(174, 27);
            txtTotalEgresos.TabIndex = 4;
            txtTotalEgresos.TextAlign = HorizontalAlignment.Right;
            // 
            // txtSaldoActual
            // 
            txtSaldoActual.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            txtSaldoActual.Location = new Point(1050, 401);
            txtSaldoActual.Margin = new Padding(4, 3, 4, 3);
            txtSaldoActual.Name = "txtSaldoActual";
            txtSaldoActual.ReadOnly = true;
            txtSaldoActual.Size = new Size(174, 27);
            txtSaldoActual.TabIndex = 6;
            txtSaldoActual.TextAlign = HorizontalAlignment.Right;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.FromArgb(241, 196, 15);
            btnActualizar.FlatAppearance.BorderSize = 0;
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnActualizar.ForeColor = Color.White;
            btnActualizar.Location = new Point(1050, 772);
            btnActualizar.Margin = new Padding(4, 3, 4, 3);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(140, 52);
            btnActualizar.TabIndex = 3;
            btnActualizar.Text = "🔄 Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.FromArgb(149, 165, 166);
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCerrar.ForeColor = Color.White;
            btnCerrar.Location = new Point(1225, 772);
            btnCerrar.Margin = new Padding(4, 3, 4, 3);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(140, 52);
            btnCerrar.TabIndex = 4;
            btnCerrar.Text = "❌ Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            // 
            // Caja
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1364, 749);
            Controls.Add(panelContent);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "Caja";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Caja";
            WindowState = FormWindowState.Maximized;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelContent.ResumeLayout(false);
            groupBoxEmpleados.ResumeLayout(false);
            groupBoxEmpleados.PerformLayout();
            groupBoxOperaciones.ResumeLayout(false);
            groupBoxResumen.ResumeLayout(false);
            groupBoxResumen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMovimientos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.GroupBox groupBoxEmpleados;
        private System.Windows.Forms.ComboBox comboBoxEmpleados;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.Label lblDineroAsignado;
        private System.Windows.Forms.TextBox txtDineroAsignado;
        private System.Windows.Forms.GroupBox groupBoxOperaciones;
        private System.Windows.Forms.Button btnVerDetalles;
        private System.Windows.Forms.Button btnVerMovimientos;
        private System.Windows.Forms.Button btnControlIngresos;
        private System.Windows.Forms.Button btnControlEgresos;
        private System.Windows.Forms.GroupBox groupBoxResumen;
        private System.Windows.Forms.DataGridView dataGridViewMovimientos;
        private System.Windows.Forms.Label lblTotalIngresos;
        private System.Windows.Forms.Label lblTotalEgresos;
        private System.Windows.Forms.Label lblSaldoActual;
        private System.Windows.Forms.TextBox txtTotalIngresos;
        private System.Windows.Forms.TextBox txtTotalEgresos;
        private System.Windows.Forms.TextBox txtSaldoActual;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnCerrar;
        private Button btnAsignarDinero;
    }
}