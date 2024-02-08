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
    public partial class Proveedores : Form
    {
        private string connectionString;
        public Proveedores(string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString;
            lblCiudad.Visible = false;
            lblCorreo.Visible = false;
            lblDomicilio.Visible = false;
            lblEstado.Visible = false;
            lblid.Visible = false;
            lblNombre.Visible = false;
            lblRFC.Visible = false;
            lblTelefoo.Visible = false;
            txtCiudad.Visible=false;
            txtCorreo.Visible=false;    
            txtDomicilio.Visible =false;
            txtEstado.Visible=false;
            txtID.Visible=false;
            txtNombre.Visible=false;
            txtRFC.Visible=false;
            txtTelefono.Visible=false;
            
        }

        private void Proveedores_Load(object sender, EventArgs e)
        {

        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            lblCiudad.Visible = true;
            lblCorreo.Visible = true;
            lblDomicilio.Visible = true;
            lblEstado.Visible = true;
            lblid.Visible = true;
            lblNombre.Visible = true;
            lblRFC.Visible = true;
            lblTelefoo.Visible = true;
            txtCiudad.Visible =     true;
            txtCorreo.Visible = true;
            txtDomicilio.Visible = true;
            txtEstado.Visible = true;
            txtID.Visible = true;
            txtNombre.Visible = true;
            txtRFC.Visible = true;
            txtTelefono.Visible = true;
            if (txtID.Text == "")
            {
                string tablaSeleccionada = "Proveedores";

                DataTable dt = abrirtablas(tablaSeleccionada);
                DGV1.DataSource = dt;
            }
            else
            {
                string tablaSeleccionada = "Proveedores";
                string abrir1 = "Id_proveedor";
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
        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = AbrirConexion();
                string Query = $"DELETE FROM Proveedores WHERE Id_proveedor=@Id_proveedor";
                SqlCommand command;
                command = new SqlCommand(Query, conn);
                command.Parameters.AddWithValue("@Id_proveedor", txtID.Text);
                MessageBox.Show("Se ha eliminado correctamente");
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = AbrirConexion();
                string Query = "INSERT INTO Proveedores (Domicilio,Ciudad,Estado,Nombre,Correo,Telefono,RFC) " +
                  "VALUES (@Domicilio,@Ciudad,@Estado,@Nombre,@Correo,@Telefono,@RFC)";
                SqlCommand command;
                command = new SqlCommand(Query, conn);
                command.Parameters.AddWithValue("@Domicilio", txtDomicilio.Text);
                command.Parameters.AddWithValue("@Ciudad", txtCiudad.Text);
                command.Parameters.AddWithValue("@Estado", txtEstado.Text);
                command.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                command.Parameters.AddWithValue("@Correo", txtCorreo.Text);
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

        private void btnedit_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = AbrirConexion();
                string Query = "UPDATE Proveedores SET Domicilio=@Domicilio,Ciudad=@Ciudad,Estado=@Estado,Nombre=@Nombre," +
                  "Correo=@Correo,Telefono=@Telefono,RFC=@RFC WHERE Id_proveedor=@Id_proveedor";
                SqlCommand command;
                command = new SqlCommand(Query, conn);
                command.Parameters.AddWithValue("@Id_proveedor", txtID.Text);
                command.Parameters.AddWithValue("@Domicilio", txtDomicilio.Text);
                command.Parameters.AddWithValue("@Ciudad", txtCiudad.Text);
                command.Parameters.AddWithValue("@Estado", txtEstado.Text);
                command.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                command.Parameters.AddWithValue("@Correo", txtCorreo.Text);
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

        private void lblCorreo_Click(object sender, EventArgs e)
        {

        }
    }
}
