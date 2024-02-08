namespace SQL_FINAL
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
            this.DGV1 = new System.Windows.Forms.DataGridView();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.txtSAT = new System.Windows.Forms.TextBox();
            this.txtDes = new System.Windows.Forms.TextBox();
            this.txtPreVen = new System.Windows.Forms.TextBox();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.lbDescripcion = new System.Windows.Forms.Label();
            this.lblSAT = new System.Windows.Forms.Label();
            this.lblCosto = new System.Windows.Forms.Label();
            this.lblPreVen = new System.Windows.Forms.Label();
            this.lblID_pro = new System.Windows.Forms.Label();
            this.txtID_Pro = new System.Windows.Forms.TextBox();
            this.lblId_proveedores = new System.Windows.Forms.Label();
            this.cmbProveedor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV1
            // 
            this.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV1.Location = new System.Drawing.Point(12, 161);
            this.DGV1.Name = "DGV1";
            this.DGV1.RowHeadersWidth = 62;
            this.DGV1.RowTemplate.Height = 28;
            this.DGV1.Size = new System.Drawing.Size(928, 562);
            this.DGV1.TabIndex = 5;
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(220, 94);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(99, 47);
            this.btnConsulta.TabIndex = 4;
            this.btnConsulta.Text = "Consulta";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(535, 94);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(99, 47);
            this.btneliminar.TabIndex = 10;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(325, 94);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(99, 47);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(430, 94);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(99, 47);
            this.btnedit.TabIndex = 8;
            this.btnedit.Text = "Editar";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // txtSAT
            // 
            this.txtSAT.Location = new System.Drawing.Point(473, 768);
            this.txtSAT.Name = "txtSAT";
            this.txtSAT.Size = new System.Drawing.Size(100, 26);
            this.txtSAT.TabIndex = 11;
            // 
            // txtDes
            // 
            this.txtDes.Location = new System.Drawing.Point(345, 768);
            this.txtDes.Name = "txtDes";
            this.txtDes.Size = new System.Drawing.Size(100, 26);
            this.txtDes.TabIndex = 12;
            // 
            // txtPreVen
            // 
            this.txtPreVen.Location = new System.Drawing.Point(728, 768);
            this.txtPreVen.Name = "txtPreVen";
            this.txtPreVen.Size = new System.Drawing.Size(100, 26);
            this.txtPreVen.TabIndex = 13;
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(604, 768);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(100, 26);
            this.txtCosto.TabIndex = 14;
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.AutoSize = true;
            this.lbDescripcion.Location = new System.Drawing.Point(341, 735);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(92, 20);
            this.lbDescripcion.TabIndex = 15;
            this.lbDescripcion.Text = "Descripcion";
            // 
            // lblSAT
            // 
            this.lblSAT.AutoSize = true;
            this.lblSAT.Location = new System.Drawing.Point(478, 735);
            this.lblSAT.Name = "lblSAT";
            this.lblSAT.Size = new System.Drawing.Size(83, 20);
            this.lblSAT.TabIndex = 16;
            this.lblSAT.Text = "Clave SAT";
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Location = new System.Drawing.Point(600, 735);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(51, 20);
            this.lblCosto.TabIndex = 17;
            this.lblCosto.Text = "Costo";
            // 
            // lblPreVen
            // 
            this.lblPreVen.AutoSize = true;
            this.lblPreVen.Location = new System.Drawing.Point(724, 735);
            this.lblPreVen.Name = "lblPreVen";
            this.lblPreVen.Size = new System.Drawing.Size(96, 20);
            this.lblPreVen.TabIndex = 18;
            this.lblPreVen.Text = "Precio venta";
            // 
            // lblID_pro
            // 
            this.lblID_pro.AutoSize = true;
            this.lblID_pro.Location = new System.Drawing.Point(87, 735);
            this.lblID_pro.Name = "lblID_pro";
            this.lblID_pro.Size = new System.Drawing.Size(96, 20);
            this.lblID_pro.TabIndex = 20;
            this.lblID_pro.Text = "Id_Producto";
            // 
            // txtID_Pro
            // 
            this.txtID_Pro.Location = new System.Drawing.Point(91, 768);
            this.txtID_Pro.Name = "txtID_Pro";
            this.txtID_Pro.Size = new System.Drawing.Size(100, 26);
            this.txtID_Pro.TabIndex = 19;
            // 
            // lblId_proveedores
            // 
            this.lblId_proveedores.AutoSize = true;
            this.lblId_proveedores.Location = new System.Drawing.Point(202, 735);
            this.lblId_proveedores.Name = "lblId_proveedores";
            this.lblId_proveedores.Size = new System.Drawing.Size(120, 20);
            this.lblId_proveedores.TabIndex = 22;
            this.lblId_proveedores.Text = "Id_proveedores";
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.Location = new System.Drawing.Point(206, 766);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(121, 28);
            this.cmbProveedor.TabIndex = 21;
            this.cmbProveedor.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cmbProveedor_DrawItem);
            this.cmbProveedor.DropDown += new System.EventHandler(this.cmbProveedor_DropDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(231, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 84);
            this.label1.TabIndex = 49;
            this.label1.Text = "Productos";
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 816);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblId_proveedores);
            this.Controls.Add(this.cmbProveedor);
            this.Controls.Add(this.lblID_pro);
            this.Controls.Add(this.txtID_Pro);
            this.Controls.Add(this.lblPreVen);
            this.Controls.Add(this.lblCosto);
            this.Controls.Add(this.lblSAT);
            this.Controls.Add(this.lbDescripcion);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.txtPreVen);
            this.Controls.Add(this.txtDes);
            this.Controls.Add(this.txtSAT);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.DGV1);
            this.Controls.Add(this.btnConsulta);
            this.Name = "Productos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
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
        private System.Windows.Forms.TextBox txtSAT;
        private System.Windows.Forms.TextBox txtDes;
        private System.Windows.Forms.TextBox txtPreVen;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.Label lbDescripcion;
        private System.Windows.Forms.Label lblSAT;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.Label lblPreVen;
        private System.Windows.Forms.Label lblID_pro;
        private System.Windows.Forms.TextBox txtID_Pro;
        private System.Windows.Forms.Label lblId_proveedores;
        private System.Windows.Forms.ComboBox cmbProveedor;
        private System.Windows.Forms.Label label1;
    }
}