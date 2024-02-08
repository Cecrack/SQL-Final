namespace SQL_FINAL
{
    partial class Compras
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
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.DTP1 = new System.Windows.Forms.DateTimePicker();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.cmbProveedor = new System.Windows.Forms.ComboBox();
            this.lblId_proveedores = new System.Windows.Forms.Label();
            this.txtId_compras = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV1
            // 
            this.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV1.Location = new System.Drawing.Point(12, 127);
            this.DGV1.Name = "DGV1";
            this.DGV1.RowHeadersWidth = 62;
            this.DGV1.RowTemplate.Height = 28;
            this.DGV1.Size = new System.Drawing.Size(881, 441);
            this.DGV1.TabIndex = 3;
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(205, 90);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(99, 31);
            this.btnConsulta.TabIndex = 2;
            this.btnConsulta.Text = "Consulta";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(520, 90);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(99, 31);
            this.btneliminar.TabIndex = 10;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(310, 90);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(99, 31);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(415, 90);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(99, 31);
            this.btnedit.TabIndex = 8;
            this.btnedit.Text = "Editar";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(446, 589);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(54, 20);
            this.lblFecha.TabIndex = 11;
            this.lblFecha.Text = "Fecha";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(677, 591);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(44, 20);
            this.lblTotal.TabIndex = 12;
            this.lblTotal.Text = "Total";
            // 
            // DTP1
            // 
            this.DTP1.Location = new System.Drawing.Point(450, 612);
            this.DTP1.Name = "DTP1";
            this.DTP1.Size = new System.Drawing.Size(200, 26);
            this.DTP1.TabIndex = 13;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(681, 614);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(159, 26);
            this.txtTotal.TabIndex = 14;
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.Location = new System.Drawing.Point(276, 612);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(121, 28);
            this.cmbProveedor.TabIndex = 15;
            this.cmbProveedor.DropDown += new System.EventHandler(this.cmbProveedor_DropDown);
            // 
            // lblId_proveedores
            // 
            this.lblId_proveedores.AutoSize = true;
            this.lblId_proveedores.Location = new System.Drawing.Point(272, 589);
            this.lblId_proveedores.Name = "lblId_proveedores";
            this.lblId_proveedores.Size = new System.Drawing.Size(120, 20);
            this.lblId_proveedores.TabIndex = 16;
            this.lblId_proveedores.Text = "Id_proveedores";
            // 
            // txtId_compras
            // 
            this.txtId_compras.Location = new System.Drawing.Point(63, 612);
            this.txtId_compras.Name = "txtId_compras";
            this.txtId_compras.Size = new System.Drawing.Size(159, 26);
            this.txtId_compras.TabIndex = 18;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(59, 589);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(93, 20);
            this.lblId.TabIndex = 17;
            this.lblId.Text = "Id_compras";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(233, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 84);
            this.label1.TabIndex = 49;
            this.label1.Text = "Compras";
            // 
            // Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 676);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtId_compras);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblId_proveedores);
            this.Controls.Add(this.cmbProveedor);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.DTP1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.DGV1);
            this.Controls.Add(this.btnConsulta);
            this.Name = "Compras";
            this.Text = "Compras";
            this.Load += new System.EventHandler(this.Compras_Load);
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
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DateTimePicker DTP1;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.ComboBox cmbProveedor;
        private System.Windows.Forms.Label lblId_proveedores;
        private System.Windows.Forms.TextBox txtId_compras;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label label1;
    }
}