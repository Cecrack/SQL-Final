namespace SQL_FINAL
{
    partial class ventas
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
            this.DGV1 = new System.Windows.Forms.DataGridView();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.lblID_venta = new System.Windows.Forms.Label();
            this.txtId_venta = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTP = new System.Windows.Forms.Label();
            this.DTP1 = new System.Windows.Forms.DateTimePicker();
            this.lblID_clientes = new System.Windows.Forms.Label();
            this.cmbClientes = new System.Windows.Forms.ComboBox();
            this.cmbTP = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV1
            // 
            this.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV1.Location = new System.Drawing.Point(62, 194);
            this.DGV1.Name = "DGV1";
            this.DGV1.RowHeadersWidth = 62;
            this.DGV1.RowTemplate.Height = 28;
            this.DGV1.Size = new System.Drawing.Size(881, 429);
            this.DGV1.TabIndex = 9;
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(249, 129);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(99, 45);
            this.btnConsulta.TabIndex = 8;
            this.btnConsulta.Text = "Consulta";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(564, 129);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(99, 45);
            this.btneliminar.TabIndex = 12;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(354, 129);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(99, 45);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(459, 129);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(99, 45);
            this.btnedit.TabIndex = 10;
            this.btnedit.Text = "Editar";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // lblID_venta
            // 
            this.lblID_venta.AutoSize = true;
            this.lblID_venta.Location = new System.Drawing.Point(98, 638);
            this.lblID_venta.Name = "lblID_venta";
            this.lblID_venta.Size = new System.Drawing.Size(75, 20);
            this.lblID_venta.TabIndex = 26;
            this.lblID_venta.Text = "Id_Venta";
            // 
            // txtId_venta
            // 
            this.txtId_venta.Location = new System.Drawing.Point(102, 671);
            this.txtId_venta.Name = "txtId_venta";
            this.txtId_venta.Size = new System.Drawing.Size(100, 26);
            this.txtId_venta.TabIndex = 25;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(655, 638);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(44, 20);
            this.lblTotal.TabIndex = 24;
            this.lblTotal.Text = "Total";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(413, 638);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(54, 20);
            this.lblFecha.TabIndex = 23;
            this.lblFecha.Text = "Fecha";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(650, 671);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 26);
            this.txtTotal.TabIndex = 21;
            // 
            // lblTP
            // 
            this.lblTP.AutoSize = true;
            this.lblTP.Location = new System.Drawing.Point(785, 638);
            this.lblTP.Name = "lblTP";
            this.lblTP.Size = new System.Drawing.Size(101, 20);
            this.lblTP.TabIndex = 28;
            this.lblTP.Text = "Tipo de pago";
            // 
            // DTP1
            // 
            this.DTP1.Location = new System.Drawing.Point(417, 671);
            this.DTP1.Name = "DTP1";
            this.DTP1.Size = new System.Drawing.Size(200, 26);
            this.DTP1.TabIndex = 29;
            // 
            // lblID_clientes
            // 
            this.lblID_clientes.AutoSize = true;
            this.lblID_clientes.Location = new System.Drawing.Point(238, 638);
            this.lblID_clientes.Name = "lblID_clientes";
            this.lblID_clientes.Size = new System.Drawing.Size(84, 20);
            this.lblID_clientes.TabIndex = 31;
            this.lblID_clientes.Text = "ID clientes";
            // 
            // cmbClientes
            // 
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.Location = new System.Drawing.Point(242, 669);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(121, 28);
            this.cmbClientes.TabIndex = 30;
            this.cmbClientes.DropDown += new System.EventHandler(this.cmbClientes_DropDown);
            // 
            // cmbTP
            // 
            this.cmbTP.FormattingEnabled = true;
            this.cmbTP.Location = new System.Drawing.Point(789, 673);
            this.cmbTP.Name = "cmbTP";
            this.cmbTP.Size = new System.Drawing.Size(121, 28);
            this.cmbTP.TabIndex = 32;
            this.cmbTP.DropDown += new System.EventHandler(this.cmbTP_DropDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(328, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 84);
            this.label1.TabIndex = 51;
            this.label1.Text = "Ventas";
            // 
            // ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 752);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTP);
            this.Controls.Add(this.lblID_clientes);
            this.Controls.Add(this.cmbClientes);
            this.Controls.Add(this.DTP1);
            this.Controls.Add(this.lblTP);
            this.Controls.Add(this.lblID_venta);
            this.Controls.Add(this.txtId_venta);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.DGV1);
            this.Controls.Add(this.btnConsulta);
            this.Name = "ventas";
            this.Text = "ventas";
            this.Load += new System.EventHandler(this.ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV1;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Label lblID_venta;
        private System.Windows.Forms.TextBox txtId_venta;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTP;
        private System.Windows.Forms.DateTimePicker DTP1;
        private System.Windows.Forms.Label lblID_clientes;
        private System.Windows.Forms.ComboBox cmbClientes;
        private System.Windows.Forms.ComboBox cmbTP;
        private System.Windows.Forms.Label label1;
    }
}