namespace SQL_FINAL
{
    partial class Inventario
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
            this.lblID_pro = new System.Windows.Forms.Label();
            this.cmbID_producto = new System.Windows.Forms.ComboBox();
            this.lblID_Bodega = new System.Windows.Forms.Label();
            this.cmbBodega = new System.Windows.Forms.ComboBox();
            this.lblID_invenatrio = new System.Windows.Forms.Label();
            this.txtID_invenatrio = new System.Windows.Forms.TextBox();
            this.lbl_venta = new System.Windows.Forms.Label();
            this.cmbVengta = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCompra = new System.Windows.Forms.ComboBox();
            this.lblTotalPro = new System.Windows.Forms.Label();
            this.txtTP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV1
            // 
            this.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV1.Location = new System.Drawing.Point(61, 170);
            this.DGV1.Name = "DGV1";
            this.DGV1.RowHeadersWidth = 62;
            this.DGV1.RowTemplate.Height = 28;
            this.DGV1.Size = new System.Drawing.Size(959, 368);
            this.DGV1.TabIndex = 7;
            this.DGV1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV1_CellContentClick);
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(308, 117);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(99, 47);
            this.btnConsulta.TabIndex = 6;
            this.btnConsulta.Text = "Consulta";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(623, 117);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(99, 47);
            this.btneliminar.TabIndex = 50;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(413, 117);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(99, 47);
            this.btnAgregar.TabIndex = 49;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(518, 117);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(99, 47);
            this.btnedit.TabIndex = 48;
            this.btnedit.Text = "Editar";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // lblID_pro
            // 
            this.lblID_pro.AutoSize = true;
            this.lblID_pro.Location = new System.Drawing.Point(275, 541);
            this.lblID_pro.Name = "lblID_pro";
            this.lblID_pro.Size = new System.Drawing.Size(96, 20);
            this.lblID_pro.TabIndex = 56;
            this.lblID_pro.Text = "Id_Producto";
            // 
            // cmbID_producto
            // 
            this.cmbID_producto.FormattingEnabled = true;
            this.cmbID_producto.Location = new System.Drawing.Point(279, 572);
            this.cmbID_producto.Name = "cmbID_producto";
            this.cmbID_producto.Size = new System.Drawing.Size(121, 28);
            this.cmbID_producto.TabIndex = 55;
            this.cmbID_producto.DropDown += new System.EventHandler(this.cmbID_producto_DropDown);
            // 
            // lblID_Bodega
            // 
            this.lblID_Bodega.AutoSize = true;
            this.lblID_Bodega.Location = new System.Drawing.Point(412, 541);
            this.lblID_Bodega.Name = "lblID_Bodega";
            this.lblID_Bodega.Size = new System.Drawing.Size(91, 20);
            this.lblID_Bodega.TabIndex = 54;
            this.lblID_Bodega.Text = "ID_Bodega";
            // 
            // cmbBodega
            // 
            this.cmbBodega.FormattingEnabled = true;
            this.cmbBodega.Location = new System.Drawing.Point(411, 572);
            this.cmbBodega.Name = "cmbBodega";
            this.cmbBodega.Size = new System.Drawing.Size(121, 28);
            this.cmbBodega.TabIndex = 53;
            this.cmbBodega.DropDown += new System.EventHandler(this.cmbBodega_DropDown);
            // 
            // lblID_invenatrio
            // 
            this.lblID_invenatrio.AutoSize = true;
            this.lblID_invenatrio.Location = new System.Drawing.Point(138, 541);
            this.lblID_invenatrio.Name = "lblID_invenatrio";
            this.lblID_invenatrio.Size = new System.Drawing.Size(94, 20);
            this.lblID_invenatrio.TabIndex = 52;
            this.lblID_invenatrio.Text = "ID_invetario";
            // 
            // txtID_invenatrio
            // 
            this.txtID_invenatrio.Location = new System.Drawing.Point(142, 572);
            this.txtID_invenatrio.Name = "txtID_invenatrio";
            this.txtID_invenatrio.Size = new System.Drawing.Size(100, 26);
            this.txtID_invenatrio.TabIndex = 51;
            // 
            // lbl_venta
            // 
            this.lbl_venta.AutoSize = true;
            this.lbl_venta.Location = new System.Drawing.Point(683, 541);
            this.lbl_venta.Name = "lbl_venta";
            this.lbl_venta.Size = new System.Drawing.Size(74, 20);
            this.lbl_venta.TabIndex = 60;
            this.lbl_venta.Text = "ID_venta";
            // 
            // cmbVengta
            // 
            this.cmbVengta.FormattingEnabled = true;
            this.cmbVengta.Location = new System.Drawing.Point(687, 572);
            this.cmbVengta.Name = "cmbVengta";
            this.cmbVengta.Size = new System.Drawing.Size(121, 28);
            this.cmbVengta.TabIndex = 59;
            this.cmbVengta.DropDown += new System.EventHandler(this.cmbVengta_DropDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(541, 541);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 58;
            this.label2.Text = "Id_compra";
            // 
            // cmbCompra
            // 
            this.cmbCompra.FormattingEnabled = true;
            this.cmbCompra.Location = new System.Drawing.Point(540, 572);
            this.cmbCompra.Name = "cmbCompra";
            this.cmbCompra.Size = new System.Drawing.Size(121, 28);
            this.cmbCompra.TabIndex = 57;
            this.cmbCompra.DropDown += new System.EventHandler(this.cmbCompra_DropDown);
            // 
            // lblTotalPro
            // 
            this.lblTotalPro.AutoSize = true;
            this.lblTotalPro.Location = new System.Drawing.Point(825, 541);
            this.lblTotalPro.Name = "lblTotalPro";
            this.lblTotalPro.Size = new System.Drawing.Size(119, 20);
            this.lblTotalPro.TabIndex = 62;
            this.lblTotalPro.Text = "Total productos";
            // 
            // txtTP
            // 
            this.txtTP.Location = new System.Drawing.Point(829, 572);
            this.txtTP.Name = "txtTP";
            this.txtTP.Size = new System.Drawing.Size(100, 26);
            this.txtTP.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(327, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 84);
            this.label1.TabIndex = 63;
            this.label1.Text = "Invetarios";
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 637);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTotalPro);
            this.Controls.Add(this.txtTP);
            this.Controls.Add(this.lbl_venta);
            this.Controls.Add(this.cmbVengta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbCompra);
            this.Controls.Add(this.lblID_pro);
            this.Controls.Add(this.cmbID_producto);
            this.Controls.Add(this.lblID_Bodega);
            this.Controls.Add(this.cmbBodega);
            this.Controls.Add(this.lblID_invenatrio);
            this.Controls.Add(this.txtID_invenatrio);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.DGV1);
            this.Controls.Add(this.btnConsulta);
            this.Name = "Inventario";
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.Inventario_Load);
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
        private System.Windows.Forms.Label lblID_pro;
        private System.Windows.Forms.ComboBox cmbID_producto;
        private System.Windows.Forms.Label lblID_Bodega;
        private System.Windows.Forms.ComboBox cmbBodega;
        private System.Windows.Forms.Label lblID_invenatrio;
        private System.Windows.Forms.TextBox txtID_invenatrio;
        private System.Windows.Forms.Label lbl_venta;
        private System.Windows.Forms.ComboBox cmbVengta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCompra;
        private System.Windows.Forms.Label lblTotalPro;
        private System.Windows.Forms.TextBox txtTP;
        private System.Windows.Forms.Label label1;
    }
}