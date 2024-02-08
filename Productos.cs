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
    public partial class Productos : Form
    {
        private string connectionString;
        public Productos(string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString;
            lblID_pro.Visible = false;
            lbDescripcion.Visible = false;
            lblCosto.Visible = false;
            lblPreVen.Visible = false;    
            lblSAT.Visible = false;
            txtCosto.Visible = false;
            txtDes.Visible = false; 
            txtID_Pro.Visible = false;
            txtPreVen.Visible = false;
            txtSAT.Visible = false;
            lblId_proveedores.Visible = false;
            cmbProveedor.Visible = false;
        }

        private void Productos_Load(object sender, EventArgs e)
        {

        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            lblID_pro.Visible = true;
            lbDescripcion.Visible = true;
            lblCosto.Visible = true;
            lblPreVen.Visible = true;
            lblSAT.Visible = true;
            txtCosto.Visible = true;
            txtDes.Visible = true;
            txtID_Pro.Visible = true;
            txtPreVen.Visible = true;
            txtSAT.Visible = true;
            lblId_proveedores.Visible = true;
            cmbProveedor.Visible = true;
            if (txtID_Pro.Text == "")
            {
                string tablaSeleccionada = "Productos";

                DataTable dt = abrirtablas(tablaSeleccionada);
                DGV1.DataSource = dt;
            }
            else
            {
                string tablaSeleccionada = "Productos";
                string abrir1 = "Id_producto";
                string abrir2 = txtID_Pro.Text;

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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = AbrirConexion();
                string Query = "INSERT INTO Productos (Id_proveedor,Descripcion,ClaveSAT,Costo,PrecioVenta) " +
                  "VALUES (@Id_proveedor,@Descripcion,@ClaveSAT,@Costo,@PrecioVenta)";
                SqlCommand command;
                command = new SqlCommand(Query, conn);
                command.Parameters.AddWithValue("@Id_proveedor", cmbProveedor.Text);
                command.Parameters.AddWithValue("@Descripcion", txtDes.Text);
                command.Parameters.AddWithValue("@ClaveSAT", txtSAT.Text);
                command.Parameters.AddWithValue("@Costo", txtCosto.Text);
                command.Parameters.AddWithValue("@PrecioVenta", txtPreVen.Text);
                MessageBox.Show("se agrego correctamente la tabla");
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
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
                string Query = $"DELETE FROM Productos WHERE Id_producto=@Id_producto";
                SqlCommand command;
                command = new SqlCommand(Query, conn);
                command.Parameters.AddWithValue("@Id_producto", txtID_Pro.Text);
                MessageBox.Show("Se ha eliminado correctamente");
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
                string Query = "UPDATE Productos SET Id_proveedor=@Id_proveedor, Descripcion=@Descripcion,ClaveSAT=@ClaveSAT," +
                    "Costo=@Costo,PrecioVenta=@PrecioVenta" +
                    " WHERE Id_producto=@Id_producto";
                SqlCommand command;
                command = new SqlCommand(Query, conn);
                command.Parameters.AddWithValue("@Id_producto", txtID_Pro.Text);
                command.Parameters.AddWithValue("@Id_proveedor", cmbProveedor.Text);
                command.Parameters.AddWithValue("@Descripcion", txtDes.Text);
                command.Parameters.AddWithValue("@ClaveSAT", txtSAT.Text);
                command.Parameters.AddWithValue("@Costo", txtCosto.Text);
                command.Parameters.AddWithValue("@PrecioVenta", txtPreVen.Text);
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

        private void cmbProveedor_DropDown(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            dataTable = tablas("Proveedores");
            cmbProveedor.Items.Clear();
            foreach (DataRow row in dataTable.Rows)
            {

                cmbProveedor.Items.Add(row[0].ToString());

            }
        }
        public DataTable tablas(string tabla)
        {
            DataTable dt = new DataTable();

            try
            {
                SqlConnection conexion = null;
                conexion = new SqlConnection(connectionString);
                conexion.Open();
                // Construir la consulta SQL para seleccionar todos los datos de la tabla seleccionada
                string sql = $"SELECT * FROM {tabla}";
                //  DataTable tabla = new DataTable();
                SqlDataAdapter adaptador = new SqlDataAdapter(sql, connectionString);
                adaptador.Fill(dt);
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error al conectar a la base de datos: {ex.Message}");
            }
            return dt;
        }

        public DataTable Idtablas(string tabla, string FOLIO)
        {
            DataTable dt = new DataTable();

            try
            {
                SqlConnection conexion = null;
                conexion = new SqlConnection(connectionString);
                conexion.Open();
                // Construir la consulta SQL para seleccionar todos los datos de la tabla seleccionada
                string sql = $"SELECT * FROM {tabla} WHERE {FOLIO}";
                //  DataTable tabla = new DataTable();
                SqlDataAdapter adaptador = new SqlDataAdapter(sql, connectionString);
                adaptador.Fill(dt);
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error al conectar a la base de datos: {ex.Message}");
            }
            return dt;
        }

        private void cmbProveedor_DrawItem(object sender, DrawItemEventArgs e)
        {

        }
    }
}
