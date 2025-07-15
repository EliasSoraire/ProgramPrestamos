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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.groupBoxEmpleados = new System.Windows.Forms.GroupBox();
            this.comboBoxEmpleados = new System.Windows.Forms.ComboBox();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.lblDineroAsignado = new System.Windows.Forms.Label();
            this.txtDineroAsignado = new System.Windows.Forms.TextBox();
            this.groupBoxOperaciones = new System.Windows.Forms.GroupBox();
            this.btnIngresarDinero = new System.Windows.Forms.Button();
            this.btnVerMovimientos = new System.Windows.Forms.Button();
            this.btnControlIngresos = new System.Windows.Forms.Button();
            this.btnControlEgresos = new System.Windows.Forms.Button();
            this.groupBoxResumen = new System.Windows.Forms.GroupBox();
            this.dataGridViewMovimientos = new System.Windows.Forms.DataGridView();
            this.lblTotalIngresos = new System.Windows.Forms.Label();
            this.lblTotalEgresos = new System.Windows.Forms.Label();
            this.lblSaldoActual = new System.Windows.Forms.Label();
            this.txtTotalIngresos = new System.Windows.Forms.TextBox();
            this.txtTotalEgresos = new System.Windows.Forms.TextBox();
            this.txtSaldoActual = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.groupBoxEmpleados.SuspendLayout();
            this.groupBoxOperaciones.SuspendLayout();
            this.groupBoxResumen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovimientos)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panelHeader.Controls.Add(this.lblTitulo);
            this.panelHeader.Controls.Add(this.lblSubtitulo);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1200, 100);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(20, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(186, 45);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "💵 CAJA";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.LightGray;
            this.lblSubtitulo.Location = new System.Drawing.Point(25, 65);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(351, 21);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Control del dinero manejado por cada empleado";
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.panelContent.Controls.Add(this.groupBoxEmpleados);
            this.panelContent.Controls.Add(this.groupBoxOperaciones);
            this.panelContent.Controls.Add(this.groupBoxResumen);
            this.panelContent.Controls.Add(this.btnActualizar);
            this.panelContent.Controls.Add(this.btnCerrar);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 100);
            this.panelContent.Name = "panelContent";
            this.panelContent.Padding = new System.Windows.Forms.Padding(20);
            this.panelContent.Size = new System.Drawing.Size(1200, 650);
            this.panelContent.TabIndex = 1;
            // 
            // groupBoxEmpleados
            // 
            this.groupBoxEmpleados.Controls.Add(this.comboBoxEmpleados);
            this.groupBoxEmpleados.Controls.Add(this.lblEmpleado);
            this.groupBoxEmpleados.Controls.Add(this.lblDineroAsignado);
            this.groupBoxEmpleados.Controls.Add(this.txtDineroAsignado);
            this.groupBoxEmpleados.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.groupBoxEmpleados.Location = new System.Drawing.Point(30, 30);
            this.groupBoxEmpleados.Name = "groupBoxEmpleados";
            this.groupBoxEmpleados.Size = new System.Drawing.Size(560, 120);
            this.groupBoxEmpleados.TabIndex = 0;
            this.groupBoxEmpleados.TabStop = false;
            this.groupBoxEmpleados.Text = "Selección de Empleado";
            // 
            // comboBoxEmpleados
            // 
            this.comboBoxEmpleados.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.comboBoxEmpleados.FormattingEnabled = true;
            this.comboBoxEmpleados.Location = new System.Drawing.Point(150, 35);
            this.comboBoxEmpleados.Name = "comboBoxEmpleados";
            this.comboBoxEmpleados.Size = new System.Drawing.Size(380, 28);
            this.comboBoxEmpleados.TabIndex = 1;
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblEmpleado.Location = new System.Drawing.Point(20, 38);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(78, 20);
            this.lblEmpleado.TabIndex = 0;
            this.lblEmpleado.Text = "Empleado:";
            // 
            // lblDineroAsignado
            // 
            this.lblDineroAsignado.AutoSize = true;
            this.lblDineroAsignado.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblDineroAsignado.Location = new System.Drawing.Point(20, 78);
            this.lblDineroAsignado.Name = "lblDineroAsignado";
            this.lblDineroAsignado.Size = new System.Drawing.Size(124, 20);
            this.lblDineroAsignado.TabIndex = 2;
            this.lblDineroAsignado.Text = "Dinero Asignado:";
            // 
            // txtDineroAsignado
            // 
            this.txtDineroAsignado.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtDineroAsignado.Location = new System.Drawing.Point(150, 75);
            this.txtDineroAsignado.Name = "txtDineroAsignado";
            this.txtDineroAsignado.ReadOnly = true;
            this.txtDineroAsignado.Size = new System.Drawing.Size(200, 27);
            this.txtDineroAsignado.TabIndex = 3;
            this.txtDineroAsignado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBoxOperaciones
            // 
            this.groupBoxOperaciones.Controls.Add(this.btnIngresarDinero);
            this.groupBoxOperaciones.Controls.Add(this.btnVerMovimientos);
            this.groupBoxOperaciones.Controls.Add(this.btnControlIngresos);
            this.groupBoxOperaciones.Controls.Add(this.btnControlEgresos);
            this.groupBoxOperaciones.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.groupBoxOperaciones.Location = new System.Drawing.Point(610, 30);
            this.groupBoxOperaciones.Name = "groupBoxOperaciones";
            this.groupBoxOperaciones.Size = new System.Drawing.Size(560, 200);
            this.groupBoxOperaciones.TabIndex = 1;
            this.groupBoxOperaciones.TabStop = false;
            this.groupBoxOperaciones.Text = "Operaciones";
            // 
            // btnIngresarDinero
            // 
            this.btnIngresarDinero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnIngresarDinero.FlatAppearance.BorderSize = 0;
            this.btnIngresarDinero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresarDinero.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnIngresarDinero.ForeColor = System.Drawing.Color.White;
            this.btnIngresarDinero.Location = new System.Drawing.Point(20, 35);
            this.btnIngresarDinero.Name = "btnIngresarDinero";
            this.btnIngresarDinero.Size = new System.Drawing.Size(250, 45);
            this.btnIngresarDinero.TabIndex = 0;
            this.btnIngresarDinero.Text = "💰 Ingresar Dinero";
            this.btnIngresarDinero.UseVisualStyleBackColor = false;
            // 
            // btnVerMovimientos
            // 
            this.btnVerMovimientos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnVerMovimientos.FlatAppearance.BorderSize = 0;
            this.btnVerMovimientos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerMovimientos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnVerMovimientos.ForeColor = System.Drawing.Color.White;
            this.btnVerMovimientos.Location = new System.Drawing.Point(290, 35);
            this.btnVerMovimientos.Name = "btnVerMovimientos";
            this.btnVerMovimientos.Size = new System.Drawing.Size(250, 45);
            this.btnVerMovimientos.TabIndex = 1;
            this.btnVerMovimientos.Text = "📊 Ver Movimientos";
            this.btnVerMovimientos.UseVisualStyleBackColor = false;
            // 
            // btnControlIngresos
            // 
            this.btnControlIngresos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.btnControlIngresos.FlatAppearance.BorderSize = 0;
            this.btnControlIngresos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnControlIngresos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnControlIngresos.ForeColor = System.Drawing.Color.White;
            this.btnControlIngresos.Location = new System.Drawing.Point(20, 100);
            this.btnControlIngresos.Name = "btnControlIngresos";
            this.btnControlIngresos.Size = new System.Drawing.Size(250, 45);
            this.btnControlIngresos.TabIndex = 2;
            this.btnControlIngresos.Text = "📈 Control de Ingresos";
            this.btnControlIngresos.UseVisualStyleBackColor = false;
            // 
            // btnControlEgresos
            // 
            this.btnControlEgresos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnControlEgresos.FlatAppearance.BorderSize = 0;
            this.btnControlEgresos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnControlEgresos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnControlEgresos.ForeColor = System.Drawing.Color.White;
            this.btnControlEgresos.Location = new System.Drawing.Point(290, 100);
            this.btnControlEgresos.Name = "btnControlEgresos";
            this.btnControlEgresos.Size = new System.Drawing.Size(250, 45);
            this.btnControlEgresos.TabIndex = 3;
            this.btnControlEgresos.Text = "📉 Control de Egresos";
            this.btnControlEgresos.UseVisualStyleBackColor = false;
            // 
            // groupBoxResumen
            // 
            this.groupBoxResumen.Controls.Add(this.dataGridViewMovimientos);
            this.groupBoxResumen.Controls.Add(this.lblTotalIngresos);
            this.groupBoxResumen.Controls.Add(this.lblTotalEgresos);
            this.groupBoxResumen.Controls.Add(this.lblSaldoActual);
            this.groupBoxResumen.Controls.Add(this.txtTotalIngresos);
            this.groupBoxResumen.Controls.Add(this.txtTotalEgresos);
            this.groupBoxResumen.Controls.Add(this.txtSaldoActual);
            this.groupBoxResumen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.groupBoxResumen.Location = new System.Drawing.Point(30, 170);
            this.groupBoxResumen.Name = "groupBoxResumen";
            this.groupBoxResumen.Size = new System.Drawing.Size(1140, 400);
            this.groupBoxResumen.TabIndex = 2;
            this.groupBoxResumen.TabStop = false;
            this.groupBoxResumen.Text = "Resumen de Movimientos";
            // 
            // dataGridViewMovimientos
            // 
            this.dataGridViewMovimientos.AllowUserToAddRows = false;
            this.dataGridViewMovimientos.AllowUserToDeleteRows = false;
            this.dataGridViewMovimientos.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMovimientos.Location = new System.Drawing.Point(20, 35);
            this.dataGridViewMovimientos.Name = "dataGridViewMovimientos";
            this.dataGridViewMovimientos.ReadOnly = true;
            this.dataGridViewMovimientos.Size = new System.Drawing.Size(1100, 250);
            this.dataGridViewMovimientos.TabIndex = 0;
            // 
            // lblTotalIngresos
            // 
            this.lblTotalIngresos.AutoSize = true;
            this.lblTotalIngresos.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblTotalIngresos.Location = new System.Drawing.Point(20, 310);
            this.lblTotalIngresos.Name = "lblTotalIngresos";
            this.lblTotalIngresos.Size = new System.Drawing.Size(107, 20);
            this.lblTotalIngresos.TabIndex = 1;
            this.lblTotalIngresos.Text = "Total Ingresos:";
            // 
            // lblTotalEgresos
            // 
            this.lblTotalEgresos.AutoSize = true;
            this.lblTotalEgresos.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblTotalEgresos.Location = new System.Drawing.Point(400, 310);
            this.lblTotalEgresos.Name = "lblTotalEgresos";
            this.lblTotalEgresos.Size = new System.Drawing.Size(101, 20);
            this.lblTotalEgresos.TabIndex = 3;
            this.lblTotalEgresos.Text = "Total Egresos:";
            // 
            // lblSaldoActual
            // 
            this.lblSaldoActual.AutoSize = true;
            this.lblSaldoActual.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblSaldoActual.Location = new System.Drawing.Point(780, 310);
            this.lblSaldoActual.Name = "lblSaldoActual";
            this.lblSaldoActual.Size = new System.Drawing.Size(102, 20);
            this.lblSaldoActual.TabIndex = 5;
            this.lblSaldoActual.Text = "Saldo Actual:";
            // 
            // txtTotalIngresos
            // 
            this.txtTotalIngresos.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtTotalIngresos.Location = new System.Drawing.Point(140, 307);
            this.txtTotalIngresos.Name = "txtTotalIngresos";
            this.txtTotalIngresos.ReadOnly = true;
            this.txtTotalIngresos.Size = new System.Drawing.Size(150, 27);
            this.txtTotalIngresos.TabIndex = 2;
            this.txtTotalIngresos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotalEgresos
            // 
            this.txtTotalEgresos.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtTotalEgresos.Location = new System.Drawing.Point(520, 307);
            this.txtTotalEgresos.Name = "txtTotalEgresos";
            this.txtTotalEgresos.ReadOnly = true;
            this.txtTotalEgresos.Size = new System.Drawing.Size(150, 27);
            this.txtTotalEgresos.TabIndex = 4;
            this.txtTotalEgresos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSaldoActual
            // 
            this.txtSaldoActual.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.txtSaldoActual.Location = new System.Drawing.Point(900, 307);
            this.txtSaldoActual.Name = "txtSaldoActual";
            this.txtSaldoActual.ReadOnly = true;
            this.txtSaldoActual.Size = new System.Drawing.Size(150, 27);
            this.txtSaldoActual.TabIndex = 6;
            this.txtSaldoActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(900, 590);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(120, 40);
            this.btnActualizar.TabIndex = 3;
            this.btnActualizar.Text = "🔄 Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(1050, 590);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(120, 40);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "❌ Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            // 
            // Caja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 750);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Caja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Préstamos - Caja";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelContent.ResumeLayout(false);
            this.groupBoxEmpleados.ResumeLayout(false);
            this.groupBoxEmpleados.PerformLayout();
            this.groupBoxOperaciones.ResumeLayout(false);
            this.groupBoxResumen.ResumeLayout(false);
            this.groupBoxResumen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovimientos)).EndInit();
            this.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnIngresarDinero;
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
    }
}