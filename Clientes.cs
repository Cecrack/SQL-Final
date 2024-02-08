using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_FINAL
{
    public partial class Clientes : Form
    {
        private string connectionString;
        public Clientes(string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString;
           lblid.Visible = false;
           lblDireccion.Visible = false;    
            lblCorreo.Visible = false;
            lblNombre.Visible = false;  
            lblprimerApellido.Visible = false;
            lblSegApellido.Visible = false;
            lblCiudad.Visible = false;    
            lblEstado.Visible = false;  
            lblTelefoo.Visible = false;
            lblRFC.Visible = false; 
            txtID.Visible = false;
            txtDireccion.Visible=false;
            txtCorreo.Visible=false;
            txtNombre.Visible=false;
            txtPA.Visible=false;    
            txtSA.Visible=false;
            txtCiudad.Visible=false;    
            txtEstado.Visible=false;
            txtTelefono.Visible=false;
            txtRFC.Visible=false;

        }

        private void Clientes_Load(object sender, EventArgs e)
        {

        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            lblid.Visible = true;
            lblDireccion.Visible = true;
            lblCorreo.Visible = true;
            lblNombre.Visible =true;
            lblprimerApellido.Visible = true;
            lblSegApellido.Visible = true;
            lblCiudad.Visible = true;
            lblEstado.Visible = true;
            lblTelefoo.Visible = true;
            lblRFC.Visible = true;
            txtID.Visible =     true;
            txtDireccion.Visible = true;
            txtCorreo.Visible = true;
            txtNombre.Visible = true;
            txtPA.Visible = true;
            txtSA.Visible = true;
            txtCiudad.Visible = true;
            txtEstado.Visible = true;
            txtTelefono.Visible = true;
            txtRFC.Visible = true;
            if (txtID.Text == "")
            {
                string tablaSeleccionada = "Clientes";

                DataTable dt = abrirtablas(tablaSeleccionada);
                DGV1.DataSource = dt;
            }
            else
            {
                string tablaSeleccionada = "Clientes";
                string abrir1 = "Id_cliente";
                string abrir2 = txtID.Text;

                DataTable dt = IDbrirtablas(tablaSeleccionada, abrir1, abrir2);
                DGV1.DataSource = dt;
            }
        }

        public DataTable abrirtablas(string abrir)
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    string sql = $"SELECT * FROM {abrir}";

                    using (SqlCommand command = new SqlCommand(sql, conexion))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(dt);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error al conectar a la base de datos: {ex.Message}");
            }

            return dt;
        }
        public DataTable IDbrirtablas(string abrir, string consulta1, string consulta2)
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    string sql = $"SELECT * FROM {abrir} WHERE {consulta1} = '{consulta2}'";

                    using (SqlCommand command = new SqlCommand(sql, conexion))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(dt);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error al conectar a la base de datos: {ex.Message}");
            }

            return dt;
        }

        public SqlConnection AbrirConexion()
        {
            SqlConnection conexion = new SqlConnection();
            try
            {

                //variable para crear conexion 
                conexion = new SqlConnection(connectionString);
                conexion.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return conexion;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = AbrirConexion();
                string Query = "INSERT INTO Clientes (Direccion,Correo,Nombre,PrimerApellido,SegundoApellido,Ciudad,Estado,Telefono,RFC) " +
                  "VALUES (@Direccion,@Correo,@Nombre,@PrimerApellido,@SegundoApellido,@Ciudad,@Estado,@Telefono,@RFC)";
                SqlCommand command;
                command = new SqlCommand(Query, conn);
                command.Parameters.AddWithValue("@Direccion", txtDireccion.Text);
                command.Parameters.AddWithValue("@Correo", txtCorreo.Text);
                command.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                command.Parameters.AddWithValue("@PrimerApellido", txtPA.Text);
                command.Parameters.AddWithValue("@SegundoApellido", txtSA.Text);
                command.Parameters.AddWithValue("@Ciudad", txtCiudad.Text);
                command.Parameters.AddWithValue("@Estado", txtEstado.Text);
                command.Parameters.AddWithValue("@Telefono", txtTelefono.Text);
                command.Parameters.AddWithValue("@RFC", txtRFC.Text);
                MessageBox.Show("se agrego correctamente la tabla");
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
                e.Handled = true;
            else
               if (char.IsPunctuation(e.KeyChar))
                e.Handled = true;
        }

        private void txtPA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
                e.Handled = true;
            else
               if (char.IsPunctuation(e.KeyChar))
                e.Handled = true;
        }

        private void txtSA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
                e.Handled = true;
            else
               if (char.IsPunctuation(e.KeyChar))
                e.Handled = true;
        }

        private void txtCiudad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
                e.Handled = true;
            else
               if (char.IsPunctuation(e.KeyChar))
                e.Handled = true;
        }

        private void txtEstado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
                e.Handled = true;
            else
               if (char.IsPunctuation(e.KeyChar))
                e.Handled = true;
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
                e.Handled = true;
            else
                if (char.IsPunctuation(e.KeyChar))
                e.Handled = true;
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
                e.Handled = true;
            else
                if (char.IsPunctuation(e.KeyChar))
                e.Handled = true;
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = AbrirConexion();
                string Query = "UPDATE Clientes SET Direccion=@Direccion,Correo=@Correo,Nombre=@Nombre,PrimerApellido=@PrimerApellido," +
                    "SegundoApellido=@SegundoApellido,Ciudad=@Ciudad,Estado=@Estado,Telefono=@Telefono,RFC=@RFC WHERE Id_cliente=@Id_cliente";
                SqlCommand command;
                command = new SqlCommand(Query, conn);
                command.Parameters.AddWithValue("@Id_cliente", txtID.Text);
                command.Parameters.AddWithValue("@Direccion", txtDireccion.Text);
                command.Parameters.AddWithValue("@Correo", txtCorreo.Text);
                command.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                command.Parameters.AddWithValue("@PrimerApellido", txtPA.Text);
                command.Parameters.AddWithValue("@SegundoApellido", txtSA.Text);
                command.Parameters.AddWithValue("@Ciudad", txtCiudad.Text);
                command.Parameters.AddWithValue("@Estado", txtEstado.Text);
                command.Parameters.AddWithValue("@Telefono", txtTelefono.Text);
                command.Parameters.AddWithValue("@RFC", txtRFC.Text);
                MessageBox.Show("Se ha modificado correctamente");
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
     
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = AbrirConexion();
                string Query = $"DELETE FROM Clientes WHERE Id_cliente=@Id_cliente";
                SqlCommand command;
                command = new SqlCommand(Query, conn);
                command.Parameters.AddWithValue("@Id_cliente", txtID.Text);
                MessageBox.Show("Se ha eliminado correctamente");
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
