namespace SQL_FINAL
{
    partial class compraDetalles
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
            this.lblID_pro = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtxCantidad = new System.Windows.Forms.TextBox();
            this.lblPreUni = new System.Windows.Forms.Label();
            this.cmbID_producto = new System.Windows.Forms.ComboBox();
            this.lblID_compra = new System.Windows.Forms.Label();
            this.cmbCompra = new System.Windows.Forms.ComboBox();
            this.lblID_ComDet = new System.Windows.Forms.Label();
            this.txtID_ComDet = new System.Windows.Forms.TextBox();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV1
            // 
            this.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV1.Location = new System.Drawing.Point(36, 179);
            this.DGV1.Name = "DGV1";
            this.DGV1.RowHeadersWidth = 62;
            this.DGV1.RowTemplate.Height = 28;
            this.DGV1.Size = new System.Drawing.Size(866, 304);
            this.DGV1.TabIndex = 3;
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(265, 126);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(99, 47);
            this.btnConsulta.TabIndex = 2;
            this.btnConsulta.Text = "Consulta";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // lblID_pro
            // 
            this.lblID_pro.AutoSize = true;
            this.lblID_pro.Location = new System.Drawing.Point(422, 502);
            this.lblID_pro.Name = "lblID_pro";
            this.lblID_pro.Size = new System.Drawing.Size(96, 20);
            this.lblID_pro.TabIndex = 44;
            this.lblID_pro.Text = "Id_Producto";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(701, 535);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 26);
            this.txtPrecio.TabIndex = 43;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(565, 502);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(73, 20);
            this.lblCantidad.TabIndex = 42;
            this.lblCantidad.Text = "Cantidad";
            // 
            // txtxCantidad
            // 
            this.txtxCantidad.Location = new System.Drawing.Point(569, 535);
            this.txtxCantidad.Name = "txtxCantidad";
            this.txtxCantidad.Size = new System.Drawing.Size(100, 26);
            this.txtxCantidad.TabIndex = 41;
            // 
            // lblPreUni
            // 
            this.lblPreUni.AutoSize = true;
            this.lblPreUni.Location = new System.Drawing.Point(697, 502);
            this.lblPreUni.Name = "lblPreUni";
            this.lblPreUni.Size = new System.Drawing.Size(112, 20);
            this.lblPreUni.TabIndex = 40;
            this.lblPreUni.Text = "Precio Unitario";
            // 
            // cmbID_producto
            // 
            this.cmbID_producto.FormattingEnabled = true;
            this.cmbID_producto.Location = new System.Drawing.Point(426, 533);
            this.cmbID_producto.Name = "cmbID_producto";
            this.cmbID_producto.Size = new System.Drawing.Size(121, 28);
            this.cmbID_producto.TabIndex = 39;
            this.cmbID_producto.DropDown += new System.EventHandler(this.cmbID_producto_DropDown);
            // 
            // lblID_compra
            // 
            this.lblID_compra.AutoSize = true;
            this.lblID_compra.Location = new System.Drawing.Point(280, 502);
            this.lblID_compra.Name = "lblID_compra";
            this.lblID_compra.Size = new System.Drawing.Size(85, 20);
            this.lblID_compra.TabIndex = 38;
            this.lblID_compra.Text = "Id_compra";
            // 
            // cmbCompra
            // 
            this.cmbCompra.FormattingEnabled = true;
            this.cmbCompra.Location = new System.Drawing.Point(279, 533);
            this.cmbCompra.Name = "cmbCompra";
            this.cmbCompra.Size = new System.Drawing.Size(121, 28);
            this.cmbCompra.TabIndex = 37;
            this.cmbCompra.DropDown += new System.EventHandler(this.cmbCompra_DropDown);
            // 
            // lblID_ComDet
            // 
            this.lblID_ComDet.AutoSize = true;
            this.lblID_ComDet.Location = new System.Drawing.Point(131, 502);
            this.lblID_ComDet.Name = "lblID_ComDet";
            this.lblID_ComDet.Size = new System.Drawing.Size(142, 20);
            this.lblID_ComDet.TabIndex = 36;
            this.lblID_ComDet.Text = "ID_Compra detalle";
            // 
            // txtID_ComDet
            // 
            this.txtID_ComDet.Location = new System.Drawing.Point(135, 533);
            this.txtID_ComDet.Name = "txtID_ComDet";
            this.txtID_ComDet.Size = new System.Drawing.Size(100, 26);
            this.txtID_ComDet.TabIndex = 35;
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(580, 126);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(99, 47);
            this.btneliminar.TabIndex = 47;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(370, 126);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(99, 47);
            this.btnAgregar.TabIndex = 46;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(475, 126);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(99, 47);
            this.btnedit.TabIndex = 45;
            this.btnedit.Text = "Editar";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(635, 84);
            this.label1.TabIndex = 52;
            this.label1.Text = "Compras detalles";
            // 
            // compraDetalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 617);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.lblID_pro);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.txtxCantidad);
            this.Controls.Add(this.lblPreUni);
            this.Controls.Add(this.cmbID_producto);
            this.Controls.Add(this.lblID_compra);
            this.Controls.Add(this.cmbCompra);
            this.Controls.Add(this.lblID_ComDet);
            this.Controls.Add(this.txtID_ComDet);
            this.Controls.Add(this.DGV1);
            this.Controls.Add(this.btnConsulta);
            this.Name = "compraDetalles";
            this.Text = "compraDetalles";
            this.Load += new System.EventHandler(this.compraDetalles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV1;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Label lblID_pro;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtxCantidad;
        private System.Windows.Forms.Label lblPreUni;
        private System.Windows.Forms.ComboBox cmbID_producto;
        private System.Windows.Forms.Label lblID_compra;
        private System.Windows.Forms.ComboBox cmbCompra;
        private System.Windows.Forms.Label lblID_ComDet;
        private System.Windows.Forms.TextBox txtID_ComDet;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Label label1;
    }
}