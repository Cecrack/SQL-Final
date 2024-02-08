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
    public partial class compraDetalles : Form
    {
        private string connectionString;
        public compraDetalles(string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString;
            lblCantidad.Visible = false;
            lblID_ComDet.Visible = false;
            lblID_compra.Visible = false;
            lblID_pro.Visible = false;
            lblPreUni.Visible = false;
            txtID_ComDet.Visible=false;
            cmbCompra.Visible = false;
            cmbID_producto.Visible = false;
            txtPrecio.Visible = false;
            txtxCantidad.Visible = false;
        }

        private void compraDetalles_Load(object sender, EventArgs e)
        {

        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            lblCantidad.Visible = true;
            lblID_ComDet.Visible = true;
            lblID_compra.Visible = true;
            lblID_pro.Visible = true;
            lblPreUni.Visible = true;
            txtID_ComDet.Visible = true;
            cmbCompra.Visible = true;
            cmbID_producto.Visible = true;
            txtPrecio.Visible = true;
            txtxCantidad.Visible = true;
            if (txtID_ComDet.Text == "")
            {
                string tablaSeleccionada = "ComprasDetalles";

                DataTable dt = abrirtablas(tablaSeleccionada);
                DGV1.DataSource = dt;
            }
            else
            {
                string tablaSeleccionada = "ComprasDetalles";
                string abrir1 = "Id_compraDetalle";
                string abrir2 = txtID_ComDet.Text;

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

        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = AbrirConexion();
                string Query = $"DELETE FROM ComprasDetalles WHERE Id_compraDetalle=@Id_compraDetalle";
                SqlCommand command;
                command = new SqlCommand(Query, conn);
                command.Parameters.AddWithValue("@Id_compraDetalle", txtID_ComDet.Text);
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
                string Query = "INSERT INTO ComprasDetalles (Id_compra,Id_producto,Cantidad,PrecioUnitario) " +
                  "VALUES (@Id_compra,@Id_producto,@Cantidad,@PrecioUnitario)";
                SqlCommand command;
                command = new SqlCommand(Query, conn);
                command.Parameters.AddWithValue("@Id_compra", cmbCompra.Text);
                command.Parameters.AddWithValue("@Id_producto", cmbID_producto.Text);
                command.Parameters.AddWithValue("@Cantidad", txtxCantidad.Text);
                command.Parameters.AddWithValue("@PrecioUnitario", txtPrecio.Text);
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
                string Query = "UPDATE ComprasDetalles SET Id_compra=@Id_compra,Id_producto=@Id_producto,Cantidad=@Cantidad," +
                    "PrecioUnitario=@PrecioUnitario WHERE Id_compraDetalle=@Id_compraDetalle";
                SqlCommand command;
                command = new SqlCommand(Query, conn);
                command.Parameters.AddWithValue("@Id_compraDetalle", txtID_ComDet.Text);
                command.Parameters.AddWithValue("@Id_compra", cmbCompra.Text);
                command.Parameters.AddWithValue("@Id_producto", cmbID_producto.Text);
                command.Parameters.AddWithValue("@Cantidad", txtxCantidad.Text);
                command.Parameters.AddWithValue("@PrecioUnitario", txtPrecio.Text);
                MessageBox.Show("Se ha modificado correctamente");
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void cmbCompra_DropDown(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            dataTable = tablas("Compras");
            cmbCompra.Items.Clear();
            foreach (DataRow row in dataTable.Rows)
            {

                cmbCompra.Items.Add(row[0].ToString());

            }
        }

        private void cmbID_producto_DropDown(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            dataTable = tablas("Productos");
            cmbID_producto.Items.Clear();
            foreach (DataRow row in dataTable.Rows)
            {

                cmbID_producto.Items.Add(row[0].ToString());

            }
        }
    }
}
