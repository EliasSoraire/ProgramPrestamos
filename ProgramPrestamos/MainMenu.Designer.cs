namespace ProgramPrestamos
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelHeader = new Panel();
            lblSubtitle = new Label();
            lblTitle = new Label();
            panelNavigation = new Panel();
            btnResumen = new Button();
            btnCaja = new Button();
            btnProductos = new Button();
            btnNuevoPrestamo = new Button();
            btnEstados = new Button();
            btnEmpleados = new Button();
            btnClientes = new Button();
            panelChart = new Panel();
            lblChartTitle = new Label();
            panelStats = new Panel();
            lblGananciasMes = new Label();
            lblGananciasHoy = new Label();
            lblTotalClientes = new Label();
            lblTotalPrestamos = new Label();
            panelHeader.SuspendLayout();
            panelNavigation.SuspendLayout();
            panelChart.SuspendLayout();
            panelStats.SuspendLayout();
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
            panelHeader.Size = new Size(1200, 80);
            panelHeader.TabIndex = 0;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.FromArgb(189, 195, 199);
            lblSubtitle.Location = new Point(20, 50);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(166, 19);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Panel de Control Principal";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(263, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Sistema de Préstamos";
            // 
            // panelNavigation
            // 
            panelNavigation.BackColor = Color.FromArgb(52, 73, 94);
            panelNavigation.Controls.Add(btnResumen);
            panelNavigation.Controls.Add(btnCaja);
            panelNavigation.Controls.Add(btnProductos);
            panelNavigation.Controls.Add(btnNuevoPrestamo);
            panelNavigation.Controls.Add(btnEstados);
            panelNavigation.Controls.Add(btnEmpleados);
            panelNavigation.Controls.Add(btnClientes);
            panelNavigation.Dock = DockStyle.Left;
            panelNavigation.Location = new Point(0, 80);
            panelNavigation.Name = "panelNavigation";
            panelNavigation.Size = new Size(200, 520);
            panelNavigation.TabIndex = 1;
            // 
            // btnResumen
            // 
            btnResumen.BackColor = Color.FromArgb(52, 73, 94);
            btnResumen.FlatAppearance.BorderSize = 0;
            btnResumen.FlatStyle = FlatStyle.Flat;
            btnResumen.Font = new Font("Segoe UI", 10F);
            btnResumen.ForeColor = Color.White;
            btnResumen.Location = new Point(0, 302);
            btnResumen.Name = "btnResumen";
            btnResumen.Padding = new Padding(10, 0, 0, 0);
            btnResumen.Size = new Size(200, 50);
            btnResumen.TabIndex = 6;
            btnResumen.Text = "📋 Resumen";
            btnResumen.TextAlign = ContentAlignment.MiddleLeft;
            btnResumen.UseVisualStyleBackColor = false;
            btnResumen.Click += BtnResumen_Click;
            // 
            // btnCaja
            // 
            btnCaja.BackColor = Color.FromArgb(52, 73, 94);
            btnCaja.FlatAppearance.BorderSize = 0;
            btnCaja.FlatStyle = FlatStyle.Flat;
            btnCaja.Font = new Font("Segoe UI", 10F);
            btnCaja.ForeColor = Color.White;
            btnCaja.Location = new Point(0, 251);
            btnCaja.Name = "btnCaja";
            btnCaja.Padding = new Padding(10, 0, 0, 0);
            btnCaja.Size = new Size(200, 50);
            btnCaja.TabIndex = 5;
            btnCaja.Text = "💳 Caja";
            btnCaja.TextAlign = ContentAlignment.MiddleLeft;
            btnCaja.UseVisualStyleBackColor = false;
            btnCaja.Click += BtnCaja_Click;
            // 
            // btnProductos
            // 
            btnProductos.BackColor = Color.FromArgb(52, 73, 94);
            btnProductos.FlatAppearance.BorderSize = 0;
            btnProductos.FlatStyle = FlatStyle.Flat;
            btnProductos.Font = new Font("Segoe UI", 10F);
            btnProductos.ForeColor = Color.White;
            btnProductos.Location = new Point(0, 201);
            btnProductos.Name = "btnProductos";
            btnProductos.Padding = new Padding(10, 0, 0, 0);
            btnProductos.Size = new Size(200, 50);
            btnProductos.TabIndex = 4;
            btnProductos.Text = "📦 Productos";
            btnProductos.TextAlign = ContentAlignment.MiddleLeft;
            btnProductos.UseVisualStyleBackColor = false;
            btnProductos.Click += BtnProductos_Click;
            // 
            // btnNuevoPrestamo
            // 
            btnNuevoPrestamo.BackColor = Color.FromArgb(52, 73, 94);
            btnNuevoPrestamo.FlatAppearance.BorderSize = 0;
            btnNuevoPrestamo.FlatStyle = FlatStyle.Flat;
            btnNuevoPrestamo.Font = new Font("Segoe UI", 10F);
            btnNuevoPrestamo.ForeColor = Color.White;
            btnNuevoPrestamo.Location = new Point(0, 151);
            btnNuevoPrestamo.Name = "btnNuevoPrestamo";
            btnNuevoPrestamo.Padding = new Padding(10, 0, 0, 0);
            btnNuevoPrestamo.Size = new Size(200, 50);
            btnNuevoPrestamo.TabIndex = 3;
            btnNuevoPrestamo.Text = "💰 Nuevo Préstamo";
            btnNuevoPrestamo.TextAlign = ContentAlignment.MiddleLeft;
            btnNuevoPrestamo.UseVisualStyleBackColor = false;
            btnNuevoPrestamo.Click += BtnNuevoPrestamo_Click;
            // 
            // btnEstados
            // 
            btnEstados.BackColor = Color.FromArgb(52, 73, 94);
            btnEstados.FlatAppearance.BorderSize = 0;
            btnEstados.FlatStyle = FlatStyle.Flat;
            btnEstados.Font = new Font("Segoe UI", 10F);
            btnEstados.ForeColor = Color.White;
            btnEstados.Location = new Point(0, 101);
            btnEstados.Name = "btnEstados";
            btnEstados.Padding = new Padding(10, 0, 0, 0);
            btnEstados.Size = new Size(200, 50);
            btnEstados.TabIndex = 2;
            btnEstados.Text = "📊 Estados";
            btnEstados.TextAlign = ContentAlignment.MiddleLeft;
            btnEstados.UseVisualStyleBackColor = false;
            btnEstados.Click += BtnEstados_Click;
            // 
            // btnEmpleados
            // 
            btnEmpleados.BackColor = Color.FromArgb(52, 73, 94);
            btnEmpleados.FlatAppearance.BorderSize = 0;
            btnEmpleados.FlatStyle = FlatStyle.Flat;
            btnEmpleados.Font = new Font("Segoe UI", 10F);
            btnEmpleados.ForeColor = Color.White;
            btnEmpleados.Location = new Point(0, 50);
            btnEmpleados.Name = "btnEmpleados";
            btnEmpleados.Padding = new Padding(10, 0, 0, 0);
            btnEmpleados.Size = new Size(200, 50);
            btnEmpleados.TabIndex = 1;
            btnEmpleados.Text = "👨‍💼 Empleados";
            btnEmpleados.TextAlign = ContentAlignment.MiddleLeft;
            btnEmpleados.UseVisualStyleBackColor = false;
            btnEmpleados.Click += BtnEmpleados_Click;
            // 
            // btnClientes
            // 
            btnClientes.BackColor = Color.FromArgb(52, 73, 94);
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Segoe UI", 10F);
            btnClientes.ForeColor = Color.White;
            btnClientes.Location = new Point(0, 0);
            btnClientes.Name = "btnClientes";
            btnClientes.Padding = new Padding(10, 0, 0, 0);
            btnClientes.Size = new Size(200, 50);
            btnClientes.TabIndex = 0;
            btnClientes.Text = "👥 Clientes";
            btnClientes.TextAlign = ContentAlignment.MiddleLeft;
            btnClientes.UseVisualStyleBackColor = false;
            btnClientes.Click += BtnClientes_Click;
            // 
            // panelChart
            // 
            panelChart.BackColor = Color.White;
            panelChart.Controls.Add(lblChartTitle);
            panelChart.Location = new Point(220, 200);
            panelChart.Name = "panelChart";
            panelChart.Size = new Size(960, 380);
            panelChart.TabIndex = 2;
            // 
            // lblChartTitle
            // 
            lblChartTitle.AutoSize = true;
            lblChartTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblChartTitle.ForeColor = Color.FromArgb(41, 53, 65);
            lblChartTitle.Location = new Point(20, 15);
            lblChartTitle.Name = "lblChartTitle";
            lblChartTitle.Size = new Size(200, 25);
            lblChartTitle.TabIndex = 0;
            lblChartTitle.Text = "Ganancias Mensuales";
            // 
            // panelStats
            // 
            panelStats.BackColor = Color.FromArgb(236, 240, 241);
            panelStats.Controls.Add(lblGananciasMes);
            panelStats.Controls.Add(lblGananciasHoy);
            panelStats.Controls.Add(lblTotalClientes);
            panelStats.Controls.Add(lblTotalPrestamos);
            panelStats.Location = new Point(220, 100);
            panelStats.Name = "panelStats";
            panelStats.Size = new Size(960, 80);
            panelStats.TabIndex = 3;
            // 
            // lblGananciasMes
            // 
            lblGananciasMes.AutoSize = true;
            lblGananciasMes.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblGananciasMes.ForeColor = Color.FromArgb(39, 174, 96);
            lblGananciasMes.Location = new Point(250, 45);
            lblGananciasMes.Name = "lblGananciasMes";
            lblGananciasMes.Size = new Size(131, 21);
            lblGananciasMes.TabIndex = 3;
            lblGananciasMes.Text = "Ganancias Mes: ";
            // 
            // lblGananciasHoy
            // 
            lblGananciasHoy.AutoSize = true;
            lblGananciasHoy.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblGananciasHoy.ForeColor = Color.FromArgb(39, 174, 96);
            lblGananciasHoy.Location = new Point(250, 15);
            lblGananciasHoy.Name = "lblGananciasHoy";
            lblGananciasHoy.Size = new Size(131, 21);
            lblGananciasHoy.TabIndex = 2;
            lblGananciasHoy.Text = "Ganancias Hoy: ";
            // 
            // lblTotalClientes
            // 
            lblTotalClientes.AutoSize = true;
            lblTotalClientes.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTotalClientes.ForeColor = Color.FromArgb(52, 73, 94);
            lblTotalClientes.Location = new Point(20, 45);
            lblTotalClientes.Name = "lblTotalClientes";
            lblTotalClientes.Size = new Size(130, 21);
            lblTotalClientes.TabIndex = 1;
            lblTotalClientes.Text = "Total Clientes: 0";
            // 
            // lblTotalPrestamos
            // 
            lblTotalPrestamos.AutoSize = true;
            lblTotalPrestamos.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTotalPrestamos.ForeColor = Color.FromArgb(52, 73, 94);
            lblTotalPrestamos.Location = new Point(20, 15);
            lblTotalPrestamos.Name = "lblTotalPrestamos";
            lblTotalPrestamos.Size = new Size(148, 21);
            lblTotalPrestamos.TabIndex = 0;
            lblTotalPrestamos.Text = "Total Préstamos: 0";
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 240, 241);
            ClientSize = new Size(1200, 600);
            Controls.Add(panelStats);
            Controls.Add(panelChart);
            Controls.Add(panelNavigation);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "MainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Panel Principal";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelNavigation.ResumeLayout(false);
            panelChart.ResumeLayout(false);
            panelChart.PerformLayout();
            panelStats.ResumeLayout(false);
            panelStats.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel panelNavigation;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Button btnEstados;
        private System.Windows.Forms.Button btnNuevoPrestamo;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnCaja;
        private System.Windows.Forms.Button btnResumen;
        private System.Windows.Forms.Panel panelChart;
        private System.Windows.Forms.Label lblChartTitle;
        private System.Windows.Forms.Panel panelStats;
        private System.Windows.Forms.Label lblTotalPrestamos;
        private System.Windows.Forms.Label lblTotalClientes;
        private System.Windows.Forms.Label lblGananciasHoy;
        private System.Windows.Forms.Label lblGananciasMes;
    }
}