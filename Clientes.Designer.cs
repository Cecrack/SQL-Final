namespace SQL_FINAL
{
    partial class Clientes
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
            this.lblid = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblprimerApellido = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblTelefoo = new System.Windows.Forms.Label();
            this.lblRFC = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPA = new System.Windows.Forms.TextBox();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtRFC = new System.Windows.Forms.TextBox();
            this.lblSegApellido = new System.Windows.Forms.Label();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.txtSA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV1
            // 
            this.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV1.Location = new System.Drawing.Point(12, 177);
            this.DGV1.Name = "DGV1";
            this.DGV1.RowHeadersWidth = 62;
            this.DGV1.RowTemplate.Height = 28;
            this.DGV1.Size = new System.Drawing.Size(1616, 597);
            this.DGV1.TabIndex = 3;
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(586, 140);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(99, 31);
            this.btnConsulta.TabIndex = 2;
            this.btnConsulta.Text = "Consulta";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(901, 140);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(99, 31);
            this.btneliminar.TabIndex = 7;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(691, 140);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(99, 31);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(796, 140);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(99, 31);
            this.btnedit.TabIndex = 5;
            this.btnedit.Text = "Editar";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(576, 802);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(26, 20);
            this.lblid.TabIndex = 8;
            this.lblid.Text = "ID";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(576, 871);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(75, 20);
            this.lblDireccion.TabIndex = 9;
            this.lblDireccion.Text = "Direccion";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(577, 958);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(57, 20);
            this.lblCorreo.TabIndex = 11;
            this.lblCorreo.Text = "Correo";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(576, 1058);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(65, 20);
            this.lblNombre.TabIndex = 10;
            this.lblNombre.Text = "Nombre";
            // 
            // lblprimerApellido
            // 
            this.lblprimerApellido.AutoSize = true;
            this.lblprimerApellido.Location = new System.Drawing.Point(576, 1161);
            this.lblprimerApellido.Name = "lblprimerApellido";
            this.lblprimerApellido.Size = new System.Drawing.Size(114, 20);
            this.lblprimerApellido.TabIndex = 13;
            this.lblprimerApellido.Text = "Primer Apellido";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(976, 958);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(60, 20);
            this.lblEstado.TabIndex = 14;
            this.lblEstado.Text = "Estado";
            // 
            // lblTelefoo
            // 
            this.lblTelefoo.AutoSize = true;
            this.lblTelefoo.Location = new System.Drawing.Point(976, 1058);
            this.lblTelefoo.Name = "lblTelefoo";
            this.lblTelefoo.Size = new System.Drawing.Size(67, 20);
            this.lblTelefoo.TabIndex = 17;
            this.lblTelefoo.Text = "telefono";
            // 
            // lblRFC
            // 
            this.lblRFC.AutoSize = true;
            this.lblRFC.Location = new System.Drawing.Point(976, 1161);
            this.lblRFC.Name = "lblRFC";
            this.lblRFC.Size = new System.Drawing.Size(42, 20);
            this.lblRFC.TabIndex = 16;
            this.lblRFC.Text = "RFC";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(581, 825);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(80, 26);
            this.txtID.TabIndex = 18;
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(580, 913);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(176, 26);
            this.txtDireccion.TabIndex = 19;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(580, 1006);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(176, 26);
            this.txtCorreo.TabIndex = 20;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(580, 1106);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(176, 26);
            this.txtNombre.TabIndex = 21;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtPA
            // 
            this.txtPA.Location = new System.Drawing.Point(580, 1205);
            this.txtPA.Name = "txtPA";
            this.txtPA.Size = new System.Drawing.Size(176, 26);
            this.txtPA.TabIndex = 22;
            this.txtPA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPA_KeyPress);
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(971, 913);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(176, 26);
            this.txtCiudad.TabIndex = 24;
            this.txtCiudad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCiudad_KeyPress);
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(971, 1006);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(176, 26);
            this.txtEstado.TabIndex = 25;
            this.txtEstado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEstado_KeyPress);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(971, 1106);
            this.txtTelefono.MaxLength = 10;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(176, 26);
            this.txtTelefono.TabIndex = 26;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // txtRFC
            // 
            this.txtRFC.Location = new System.Drawing.Point(971, 1205);
            this.txtRFC.MaxLength = 13;
            this.txtRFC.Name = "txtRFC";
            this.txtRFC.Size = new System.Drawing.Size(176, 26);
            this.txtRFC.TabIndex = 27;
            // 
            // lblSegApellido
            // 
            this.lblSegApellido.AutoSize = true;
            this.lblSegApellido.Location = new System.Drawing.Point(967, 802);
            this.lblSegApellido.Name = "lblSegApellido";
            this.lblSegApellido.Size = new System.Drawing.Size(134, 20);
            this.lblSegApellido.TabIndex = 12;
            this.lblSegApellido.Text = "Segundo Apellido";
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Location = new System.Drawing.Point(976, 871);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(59, 20);
            this.lblCiudad.TabIndex = 15;
            this.lblCiudad.Text = "Ciudad";
            // 
            // txtSA
            // 
            this.txtSA.Location = new System.Drawing.Point(971, 825);
            this.txtSA.Name = "txtSA";
            this.txtSA.Size = new System.Drawing.Size(176, 26);
            this.txtSA.TabIndex = 23;
            this.txtSA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSA_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(651, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 84);
            this.label1.TabIndex = 28;
            this.label1.Text = "Clientes";
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1692, 1257);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRFC);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtCiudad);
            this.Controls.Add(this.txtSA);
            this.Controls.Add(this.txtPA);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblTelefoo);
            this.Controls.Add(this.lblRFC);
            this.Controls.Add(this.lblCiudad);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblprimerApellido);
            this.Controls.Add(this.lblSegApellido);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.DGV1);
            this.Controls.Add(this.btnConsulta);
            this.Name = "Clientes";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Clientes_Load);
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
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblprimerApellido;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblTelefoo;
        private System.Windows.Forms.Label lblRFC;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPA;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtRFC;
        private System.Windows.Forms.Label lblSegApellido;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.TextBox txtSA;
        private System.Windows.Forms.Label label1;
    }
}