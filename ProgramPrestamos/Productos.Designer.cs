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
            panelMain = new Panel();
            panelProductList = new Panel();
            dgvProductos = new DataGridView();
            lblProductList = new Label();
            groupBoxProducto = new GroupBox();
            btnCancelar = new Button();
            txtStock = new TextBox();
            lblStock = new Label();
            txtPrecio = new TextBox();
            lblPrecio = new Label();
            txtDescripcion = new TextBox();
            lblDescripcion = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            btnGuardarProducto = new Button();
            panelHeader.SuspendLayout();
            panelMain.SuspendLayout();
            panelProductList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            groupBoxProducto.SuspendLayout();
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
            panelHeader.Size = new Size(1200, 80);
            panelHeader.TabIndex = 0;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.FromArgb(231, 76, 60);
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnVolver.ForeColor = Color.White;
            btnVolver.Location = new Point(1089, 18);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(90, 44);
            btnVolver.TabIndex = 2;
            btnVolver.Text = "← Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.FromArgb(189, 195, 199);
            lblSubtitle.Location = new Point(20, 50);
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
            lblTitle.Location = new Point(20, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(172, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "🛍️ Productos";
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(236, 240, 241);
            panelMain.Controls.Add(panelProductList);
            panelMain.Controls.Add(groupBoxProducto);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 80);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(20);
            panelMain.Size = new Size(1200, 520);
            panelMain.TabIndex = 1;
            // 
            // panelProductList
            // 
            panelProductList.BackColor = Color.White;
            panelProductList.Controls.Add(dgvProductos);
            panelProductList.Controls.Add(lblProductList);
            panelProductList.Location = new Point(500, 20);
            panelProductList.Name = "panelProductList";
            panelProductList.Size = new Size(680, 480);
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
            dgvProductos.Location = new Point(20, 50);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.Size = new Size(640, 410);
            dgvProductos.TabIndex = 1;
            dgvProductos.CellClick += dgvProductos_CellClick;
            // 
            // lblProductList
            // 
            lblProductList.AutoSize = true;
            lblProductList.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblProductList.ForeColor = Color.FromArgb(41, 53, 65);
            lblProductList.Location = new Point(20, 15);
            lblProductList.Name = "lblProductList";
            lblProductList.Size = new Size(199, 25);
            lblProductList.TabIndex = 0;
            lblProductList.Text = "📋 Lista de Productos";
            // 
            // groupBoxProducto
            // 
            groupBoxProducto.BackColor = Color.White;
            groupBoxProducto.Controls.Add(btnCancelar);
            groupBoxProducto.Controls.Add(txtStock);
            groupBoxProducto.Controls.Add(lblStock);
            groupBoxProducto.Controls.Add(txtPrecio);
            groupBoxProducto.Controls.Add(lblPrecio);
            groupBoxProducto.Controls.Add(txtDescripcion);
            groupBoxProducto.Controls.Add(lblDescripcion);
            groupBoxProducto.Controls.Add(txtNombre);
            groupBoxProducto.Controls.Add(lblNombre);
            groupBoxProducto.Controls.Add(btnGuardarProducto);
            groupBoxProducto.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupBoxProducto.ForeColor = Color.FromArgb(41, 53, 65);
            groupBoxProducto.Location = new Point(20, 20);
            groupBoxProducto.Name = "groupBoxProducto";
            groupBoxProducto.Size = new Size(460, 480);
            groupBoxProducto.TabIndex = 0;
            groupBoxProducto.TabStop = false;
            groupBoxProducto.Text = "📦 Agregar Nuevo Producto";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(149, 165, 166);
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(240, 420);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(200, 40);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "❌ Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtStock
            // 
            txtStock.Font = new Font("Segoe UI", 10F);
            txtStock.Location = new Point(240, 120);
            txtStock.Name = "txtStock";
            txtStock.PlaceholderText = "Cantidad disponible";
            txtStock.Size = new Size(200, 25);
            txtStock.TabIndex = 3;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Segoe UI", 10F);
            lblStock.ForeColor = Color.FromArgb(52, 73, 94);
            lblStock.Location = new Point(240, 100);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(45, 19);
            lblStock.TabIndex = 8;
            lblStock.Text = "Stock:";
            // 
            // txtPrecio
            // 
            txtPrecio.Font = new Font("Segoe UI", 10F);
            txtPrecio.Location = new Point(20, 120);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.PlaceholderText = "0.00";
            txtPrecio.Size = new Size(200, 25);
            txtPrecio.TabIndex = 2;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 10F);
            lblPrecio.ForeColor = Color.FromArgb(52, 73, 94);
            lblPrecio.Location = new Point(20, 100);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(49, 19);
            lblPrecio.TabIndex = 6;
            lblPrecio.Text = "Precio:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Font = new Font("Segoe UI", 10F);
            txtDescripcion.Location = new Point(20, 180);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.PlaceholderText = "Descripción del producto...";
            txtDescripcion.ScrollBars = ScrollBars.Vertical;
            txtDescripcion.Size = new Size(420, 120);
            txtDescripcion.TabIndex = 4;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI", 10F);
            lblDescripcion.ForeColor = Color.FromArgb(52, 73, 94);
            lblDescripcion.Location = new Point(20, 160);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(82, 19);
            lblDescripcion.TabIndex = 4;
            lblDescripcion.Text = "Descripción:";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 10F);
            txtNombre.Location = new Point(20, 60);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre del producto";
            txtNombre.Size = new Size(420, 25);
            txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 10F);
            lblNombre.ForeColor = Color.FromArgb(52, 73, 94);
            lblNombre.Location = new Point(20, 40);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(62, 19);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre:";
            // 
            // btnGuardarProducto
            // 
            btnGuardarProducto.BackColor = Color.FromArgb(41, 128, 185);
            btnGuardarProducto.FlatAppearance.BorderSize = 0;
            btnGuardarProducto.FlatStyle = FlatStyle.Flat;
            btnGuardarProducto.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnGuardarProducto.ForeColor = Color.White;
            btnGuardarProducto.Location = new Point(20, 420);
            btnGuardarProducto.Name = "btnGuardarProducto";
            btnGuardarProducto.Size = new Size(200, 40);
            btnGuardarProducto.TabIndex = 5;
            btnGuardarProducto.Text = "💾 Guardar Producto";
            btnGuardarProducto.UseVisualStyleBackColor = false;
            btnGuardarProducto.Click += btnGuardarProducto_Click;
            // 
            // Productos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 240, 241);
            ClientSize = new Size(1200, 600);
            Controls.Add(panelMain);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Productos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Productos";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelMain.ResumeLayout(false);
            panelProductList.ResumeLayout(false);
            panelProductList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            groupBoxProducto.ResumeLayout(false);
            groupBoxProducto.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblTitle;
        private Label lblSubtitle;
        private Button btnVolver;
        private Panel panelMain;
        private GroupBox groupBoxProducto;
        private Button btnGuardarProducto;
        private TextBox txtNombre;
        private Label lblNombre;
        private TextBox txtDescripcion;
        private Label lblDescripcion;
        private TextBox txtPrecio;
        private Label lblPrecio;
        private TextBox txtStock;
        private Label lblStock;
        private Button btnCancelar;
        private Panel panelProductList;
        private Label lblProductList;
        private DataGridView dgvProductos;
    }
}