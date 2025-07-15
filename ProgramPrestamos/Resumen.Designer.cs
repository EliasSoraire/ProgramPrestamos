namespace ProgramPrestamos
{
    partial class Resumen
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panelHeader = new Panel();
            lblSubtitle = new Label();
            lblTitle = new Label();
            panelFilters = new Panel();
            btnDescargarPDF = new Button();
            btnFiltrar = new Button();
            dtpFechaHasta = new DateTimePicker();
            dtpFechaDesde = new DateTimePicker();
            lblFechaHasta = new Label();
            lblFechaDesde = new Label();
            lblFiltros = new Label();
            panelStats = new Panel();
            lblTotalCuotasCobradas = new Label();
            lblTotalMontosPrestados = new Label();
            lblTotalInteresesGenerados = new Label();
            lblTotalPrestamos = new Label();
            panelDataGrid = new Panel();
            dgvPrestamos = new DataGridView();
            lblHistorialTitle = new Label();
            panelHeader.SuspendLayout();
            panelFilters.SuspendLayout();
            panelStats.SuspendLayout();
            panelDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPrestamos).BeginInit();
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
            lblSubtitle.Size = new Size(337, 19);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Historial completo del sistema y análisis de préstamos";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 17);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(251, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "📚 Resumen General";
            // 
            // panelFilters
            // 
            panelFilters.BackColor = Color.FromArgb(52, 73, 94);
            panelFilters.Controls.Add(btnDescargarPDF);
            panelFilters.Controls.Add(btnFiltrar);
            panelFilters.Controls.Add(dtpFechaHasta);
            panelFilters.Controls.Add(dtpFechaDesde);
            panelFilters.Controls.Add(lblFechaHasta);
            panelFilters.Controls.Add(lblFechaDesde);
            panelFilters.Controls.Add(lblFiltros);
            panelFilters.Dock = DockStyle.Top;
            panelFilters.Location = new Point(0, 91);
            panelFilters.Name = "panelFilters";
            panelFilters.Size = new Size(1200, 80);
            panelFilters.TabIndex = 1;
            // 
            // btnDescargarPDF
            // 
            btnDescargarPDF.BackColor = Color.FromArgb(231, 76, 60);
            btnDescargarPDF.FlatAppearance.BorderSize = 0;
            btnDescargarPDF.FlatStyle = FlatStyle.Flat;
            btnDescargarPDF.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDescargarPDF.ForeColor = Color.White;
            btnDescargarPDF.Location = new Point(900, 25);
            btnDescargarPDF.Name = "btnDescargarPDF";
            btnDescargarPDF.Size = new Size(130, 30);
            btnDescargarPDF.TabIndex = 6;
            btnDescargarPDF.Text = "📄 Descargar PDF";
            btnDescargarPDF.UseVisualStyleBackColor = false;
            // 
            // btnFiltrar
            // 
            btnFiltrar.BackColor = Color.FromArgb(39, 174, 96);
            btnFiltrar.FlatAppearance.BorderSize = 0;
            btnFiltrar.FlatStyle = FlatStyle.Flat;
            btnFiltrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnFiltrar.ForeColor = Color.White;
            btnFiltrar.Location = new Point(750, 25);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(100, 30);
            btnFiltrar.TabIndex = 5;
            btnFiltrar.Text = "🔍 Filtrar";
            btnFiltrar.UseVisualStyleBackColor = false;
            // 
            // dtpFechaHasta
            // 
            dtpFechaHasta.Font = new Font("Segoe UI", 9F);
            dtpFechaHasta.Location = new Point(560, 28);
            dtpFechaHasta.Name = "dtpFechaHasta";
            dtpFechaHasta.Size = new Size(150, 23);
            dtpFechaHasta.TabIndex = 4;
            // 
            // dtpFechaDesde
            // 
            dtpFechaDesde.Font = new Font("Segoe UI", 9F);
            dtpFechaDesde.Location = new Point(320, 28);
            dtpFechaDesde.Name = "dtpFechaDesde";
            dtpFechaDesde.Size = new Size(150, 23);
            dtpFechaDesde.TabIndex = 3;
            // 
            // lblFechaHasta
            // 
            lblFechaHasta.AutoSize = true;
            lblFechaHasta.Font = new Font("Segoe UI", 9F);
            lblFechaHasta.ForeColor = Color.White;
            lblFechaHasta.Location = new Point(485, 31);
            lblFechaHasta.Name = "lblFechaHasta";
            lblFechaHasta.Size = new Size(72, 15);
            lblFechaHasta.TabIndex = 2;
            lblFechaHasta.Text = "Fecha hasta:";
            // 
            // lblFechaDesde
            // 
            lblFechaDesde.AutoSize = true;
            lblFechaDesde.Font = new Font("Segoe UI", 9F);
            lblFechaDesde.ForeColor = Color.White;
            lblFechaDesde.Location = new Point(240, 31);
            lblFechaDesde.Name = "lblFechaDesde";
            lblFechaDesde.Size = new Size(75, 15);
            lblFechaDesde.TabIndex = 1;
            lblFechaDesde.Text = "Fecha desde:";
            // 
            // lblFiltros
            // 
            lblFiltros.AutoSize = true;
            lblFiltros.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblFiltros.ForeColor = Color.White;
            lblFiltros.Location = new Point(20, 30);
            lblFiltros.Name = "lblFiltros";
            lblFiltros.Size = new Size(160, 21);
            lblFiltros.TabIndex = 0;
            lblFiltros.Text = "🗓️ Filtros por Fecha";
            // 
            // panelStats
            // 
            panelStats.BackColor = Color.FromArgb(236, 240, 241);
            panelStats.Controls.Add(lblTotalCuotasCobradas);
            panelStats.Controls.Add(lblTotalMontosPrestados);
            panelStats.Controls.Add(lblTotalInteresesGenerados);
            panelStats.Controls.Add(lblTotalPrestamos);
            panelStats.Dock = DockStyle.Top;
            panelStats.Location = new Point(0, 171);
            panelStats.Name = "panelStats";
            panelStats.Size = new Size(1200, 100);
            panelStats.TabIndex = 2;
            // 
            // lblTotalCuotasCobradas
            // 
            lblTotalCuotasCobradas.AutoSize = true;
            lblTotalCuotasCobradas.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTotalCuotasCobradas.ForeColor = Color.FromArgb(142, 68, 173);
            lblTotalCuotasCobradas.Location = new Point(650, 57);
            lblTotalCuotasCobradas.Name = "lblTotalCuotasCobradas";
            lblTotalCuotasCobradas.Size = new Size(190, 21);
            lblTotalCuotasCobradas.TabIndex = 3;
            lblTotalCuotasCobradas.Text = "💳 Cuotas Cobradas: $0";
            // 
            // lblTotalMontosPrestados
            // 
            lblTotalMontosPrestados.AutoSize = true;
            lblTotalMontosPrestados.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTotalMontosPrestados.ForeColor = Color.FromArgb(52, 152, 219);
            lblTotalMontosPrestados.Location = new Point(350, 57);
            lblTotalMontosPrestados.Name = "lblTotalMontosPrestados";
            lblTotalMontosPrestados.Size = new Size(196, 21);
            lblTotalMontosPrestados.TabIndex = 2;
            lblTotalMontosPrestados.Text = "💰 Montos Prestados: $0";
            // 
            // lblTotalInteresesGenerados
            // 
            lblTotalInteresesGenerados.AutoSize = true;
            lblTotalInteresesGenerados.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTotalInteresesGenerados.ForeColor = Color.FromArgb(39, 174, 96);
            lblTotalInteresesGenerados.Location = new Point(350, 20);
            lblTotalInteresesGenerados.Name = "lblTotalInteresesGenerados";
            lblTotalInteresesGenerados.Size = new Size(215, 21);
            lblTotalInteresesGenerados.TabIndex = 1;
            lblTotalInteresesGenerados.Text = "📈 Intereses Generados: $0";
            // 
            // lblTotalPrestamos
            // 
            lblTotalPrestamos.AutoSize = true;
            lblTotalPrestamos.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTotalPrestamos.ForeColor = Color.FromArgb(52, 73, 94);
            lblTotalPrestamos.Location = new Point(20, 38);
            lblTotalPrestamos.Name = "lblTotalPrestamos";
            lblTotalPrestamos.Size = new Size(197, 21);
            lblTotalPrestamos.TabIndex = 0;
            lblTotalPrestamos.Text = "📊 Total de Préstamos: 0";
            // 
            // panelDataGrid
            // 
            panelDataGrid.BackColor = Color.White;
            panelDataGrid.Controls.Add(dgvPrestamos);
            panelDataGrid.Controls.Add(lblHistorialTitle);
            panelDataGrid.Dock = DockStyle.Fill;
            panelDataGrid.Location = new Point(0, 271);
            panelDataGrid.Name = "panelDataGrid";
            panelDataGrid.Padding = new Padding(20);
            panelDataGrid.Size = new Size(1200, 409);
            panelDataGrid.TabIndex = 3;
            // 
            // dgvPrestamos
            // 
            dgvPrestamos.AllowUserToAddRows = false;
            dgvPrestamos.AllowUserToDeleteRows = false;
            dgvPrestamos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPrestamos.BackgroundColor = Color.White;
            dgvPrestamos.BorderStyle = BorderStyle.None;
            dgvPrestamos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvPrestamos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(52, 73, 94);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(52, 73, 94);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPrestamos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPrestamos.ColumnHeadersHeight = 40;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(44, 62, 80);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvPrestamos.DefaultCellStyle = dataGridViewCellStyle2;
            dgvPrestamos.Dock = DockStyle.Fill;
            dgvPrestamos.EnableHeadersVisualStyles = false;
            dgvPrestamos.GridColor = Color.FromArgb(189, 195, 199);
            dgvPrestamos.Location = new Point(20, 55);
            dgvPrestamos.Name = "dgvPrestamos";
            dgvPrestamos.ReadOnly = true;
            dgvPrestamos.RowHeadersVisible = false;
            dgvPrestamos.RowTemplate.Height = 35;
            dgvPrestamos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPrestamos.Size = new Size(1160, 334);
            dgvPrestamos.TabIndex = 1;
            // 
            // lblHistorialTitle
            // 
            lblHistorialTitle.AutoSize = true;
            lblHistorialTitle.Dock = DockStyle.Top;
            lblHistorialTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblHistorialTitle.ForeColor = Color.FromArgb(41, 53, 65);
            lblHistorialTitle.Location = new Point(20, 20);
            lblHistorialTitle.Name = "lblHistorialTitle";
            lblHistorialTitle.Padding = new Padding(0, 0, 0, 10);
            lblHistorialTitle.Size = new Size(326, 35);
            lblHistorialTitle.TabIndex = 0;
            lblHistorialTitle.Text = "📋 Historial Completo de Préstamos";
            // 
            // Resumen
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 240, 241);
            ClientSize = new Size(1200, 680);
            Controls.Add(panelDataGrid);
            Controls.Add(panelStats);
            Controls.Add(panelFilters);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Resumen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Préstamos - Resumen General";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelFilters.ResumeLayout(false);
            panelFilters.PerformLayout();
            panelStats.ResumeLayout(false);
            panelStats.PerformLayout();
            panelDataGrid.ResumeLayout(false);
            panelDataGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPrestamos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel panelFilters;
        private System.Windows.Forms.Label lblFiltros;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnDescargarPDF;
        private System.Windows.Forms.Panel panelStats;
        private System.Windows.Forms.Label lblTotalPrestamos;
        private System.Windows.Forms.Label lblTotalInteresesGenerados;
        private System.Windows.Forms.Label lblTotalMontosPrestados;
        private System.Windows.Forms.Label lblTotalCuotasCobradas;
        private System.Windows.Forms.Panel panelDataGrid;
        private System.Windows.Forms.Label lblHistorialTitle;
        private System.Windows.Forms.DataGridView dgvPrestamos;
    }
}