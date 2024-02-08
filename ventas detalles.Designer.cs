namespace SQL_FINAL
{
    partial class ventas_detalles
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
            this.cmbIDventa = new System.Windows.Forms.ComboBox();
            this.lblID_venDet = new System.Windows.Forms.Label();
            this.txtID_VenDet = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.cmbID_producto = new System.Windows.Forms.ComboBox();
            this.lblIVA = new System.Windows.Forms.Label();
            this.txtIVA = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtxCantidad = new System.Windows.Forms.TextBox();
            this.lblID_pro = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV1
            // 
            this.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV1.Location = new System.Drawing.Point(12, 146);
            this.DGV1.Name = "DGV1";
            this.DGV1.RowHeadersWidth = 62;
            this.DGV1.RowTemplate.Height = 28;
            this.DGV1.Size = new System.Drawing.Size(963, 445);
            this.DGV1.TabIndex = 11;
            this.DGV1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV1_CellContentClick);
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(262, 93);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(99, 47);
            this.btnConsulta.TabIndex = 10;
            this.btnConsulta.Text = "Consulta";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(577, 93);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(99, 47);
            this.btneliminar.TabIndex = 14;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(367, 93);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(99, 47);
            this.btnAgregar.TabIndex = 13;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(472, 93);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(99, 47);
            this.btnedit.TabIndex = 12;
            this.btnedit.Text = "Editar";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // lblID_venta
            // 
            this.lblID_venta.AutoSize = true;
            this.lblID_venta.Location = new System.Drawing.Point(208, 611);
            this.lblID_venta.Name = "lblID_venta";
            this.lblID_venta.Size = new System.Drawing.Size(74, 20);
            this.lblID_venta.TabIndex = 26;
            this.lblID_venta.Text = "ID_venta";
            // 
            // cmbIDventa
            // 
            this.cmbIDventa.FormattingEnabled = true;
            this.cmbIDventa.Location = new System.Drawing.Point(207, 642);
            this.cmbIDventa.Name = "cmbIDventa";
            this.cmbIDventa.Size = new System.Drawing.Size(121, 28);
            this.cmbIDventa.TabIndex = 25;
            this.cmbIDventa.DropDown += new System.EventHandler(this.cmbIDventa_DropDown);
            // 
            // lblID_venDet
            // 
            this.lblID_venDet.AutoSize = true;
            this.lblID_venDet.Location = new System.Drawing.Point(73, 611);
            this.lblID_venDet.Name = "lblID_venDet";
            this.lblID_venDet.Size = new System.Drawing.Size(117, 20);
            this.lblID_venDet.TabIndex = 24;
            this.lblID_venDet.Text = "Id venta detalle";
            // 
            // txtID_VenDet
            // 
            this.txtID_VenDet.Location = new System.Drawing.Point(77, 644);
            this.txtID_VenDet.Name = "txtID_VenDet";
            this.txtID_VenDet.Size = new System.Drawing.Size(100, 26);
            this.txtID_VenDet.TabIndex = 23;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(493, 611);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(53, 20);
            this.lblPrecio.TabIndex = 28;
            this.lblPrecio.Text = "Precio";
            // 
            // cmbID_producto
            // 
            this.cmbID_producto.FormattingEnabled = true;
            this.cmbID_producto.Location = new System.Drawing.Point(354, 642);
            this.cmbID_producto.Name = "cmbID_producto";
            this.cmbID_producto.Size = new System.Drawing.Size(121, 28);
            this.cmbID_producto.TabIndex = 27;
            this.cmbID_producto.DropDown += new System.EventHandler(this.cmbID_producto_DropDown);
            // 
            // lblIVA
            // 
            this.lblIVA.AutoSize = true;
            this.lblIVA.Location = new System.Drawing.Point(747, 611);
            this.lblIVA.Name = "lblIVA";
            this.lblIVA.Size = new System.Drawing.Size(36, 20);
            this.lblIVA.TabIndex = 30;
            this.lblIVA.Text = "IVA";
            // 
            // txtIVA
            // 
            this.txtIVA.Location = new System.Drawing.Point(743, 642);
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.Size = new System.Drawing.Size(100, 26);
            this.txtIVA.TabIndex = 29;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(621, 611);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(73, 20);
            this.lblCantidad.TabIndex = 32;
            this.lblCantidad.Text = "Cantidad";
            // 
            // txtxCantidad
            // 
            this.txtxCantidad.Location = new System.Drawing.Point(625, 642);
            this.txtxCantidad.Name = "txtxCantidad";
            this.txtxCantidad.Size = new System.Drawing.Size(100, 26);
            this.txtxCantidad.TabIndex = 31;
            // 
            // lblID_pro
            // 
            this.lblID_pro.AutoSize = true;
            this.lblID_pro.Location = new System.Drawing.Point(350, 611);
            this.lblID_pro.Name = "lblID_pro";
            this.lblID_pro.Size = new System.Drawing.Size(96, 20);
            this.lblID_pro.TabIndex = 34;
            this.lblID_pro.Text = "Id_Producto";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(497, 644);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 26);
            this.txtPrecio.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(193, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(555, 84);
            this.label1.TabIndex = 52;
            this.label1.Text = "Ventas detalles";
            // 
            // ventas_detalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 688);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblID_pro);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.txtxCantidad);
            this.Controls.Add(this.lblIVA);
            this.Controls.Add(this.txtIVA);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.cmbID_producto);
            this.Controls.Add(this.lblID_venta);
            this.Controls.Add(this.cmbIDventa);
            this.Controls.Add(this.lblID_venDet);
            this.Controls.Add(this.txtID_VenDet);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.DGV1);
            this.Controls.Add(this.btnConsulta);
            this.Name = "ventas_detalles";
            this.Text = "ventas_detalles";
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
        private System.Windows.Forms.ComboBox cmbIDventa;
        private System.Windows.Forms.Label lblID_venDet;
        private System.Windows.Forms.TextBox txtID_VenDet;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.ComboBox cmbID_producto;
        private System.Windows.Forms.Label lblIVA;
        private System.Windows.Forms.TextBox txtIVA;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtxCantidad;
        private System.Windows.Forms.Label lblID_pro;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label1;
    }
}