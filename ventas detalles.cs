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
    public partial class ventas_detalles : Form
    {
        private string connectionString;
        public ventas_detalles(string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString;
            lblCantidad.Visible = false;
            lblID_pro.Visible = false;
            lblID_venDet.Visible = false;
            lblID_venta.Visible = false;
            lblIVA.Visible = false;
            lblPrecio.Visible = false;
            txtID_VenDet.Visible = false;
            cmbIDventa.Visible=false;
            cmbID_producto.Visible=false;
            txtIVA.Visible=false;
            txtPrecio.Visible=false;
            txtxCantidad.Visible=false;
        
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            lblCantidad.Visible = true;
            lblID_pro.Visible = true;
            lblID_venDet.Visible = true;
            lblID_venta.Visible = true;
            lblIVA.Visible = true;
            lblPrecio.Visible = true;
            txtID_VenDet.Visible = true;
            cmbIDventa.Visible = true;
            cmbID_producto.Visible = true;
            txtIVA.Visible = true;
            txtPrecio.Visible = true;
            txtxCantidad.Visible = true;

            if (txtID_VenDet.Text == "")
            {
                string tablaSeleccionada = "VentasDetalles";

                DataTable dt = abrirtablas(tablaSeleccionada);
                DGV1.DataSource = dt;
            }
            else
            {
                string tablaSeleccionada = "VentasDetalles";
                string abrir1 = "Id_ventaDetalle";
                string abrir2 = txtID_VenDet.Text;

                DataTable dt = IDbrirtablas(tablaSeleccionada, abrir1, abrir2);
                DGV1.DataSource = dt;
            }
        }

        private void DGV1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
                string Query = "INSERT INTO VentasDetalles (Id_venta,Id_producto,Precio,Cantidad,IVA) " +
                  "VALUES (@Id_venta,@Id_producto,@Precio,@Cantidad,@IVA)";
                SqlCommand command;
                command = new SqlCommand(Query, conn);
                command.Parameters.AddWithValue("@Id_venta", cmbIDventa.Text);
                command.Parameters.AddWithValue("@Id_producto", cmbID_producto.Text);
                command.Parameters.AddWithValue("@Precio", txtPrecio.Text);
                command.Parameters.AddWithValue("@Cantidad", txtxCantidad.Text);
                command.Parameters.AddWithValue("@IVA", txtIVA.Text);
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
                string Query = "UPDATE VentasDetalles SET Id_venta=@Id_venta,Id_producto=@Id_producto," +
                    "Precio=@Precio,Cantidad=@Cantidad,IVA=@IVA  WHERE Id_ventaDetalle=@Id_ventaDetalle";
                SqlCommand command;
                command = new SqlCommand(Query, conn);
                command.Parameters.AddWithValue("@Id_ventaDetalle", txtID_VenDet.Text);
                command.Parameters.AddWithValue("@Id_venta", cmbIDventa.Text);
                command.Parameters.AddWithValue("@Id_producto", cmbID_producto.Text);
                command.Parameters.AddWithValue("@Precio", txtPrecio.Text);
                command.Parameters.AddWithValue("@Cantidad", txtxCantidad.Text);
                command.Parameters.AddWithValue("@IVA", txtIVA.Text);
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
                string Query = $"DELETE FROM VentasDetalles WHERE Id_ventaDetalle=@Id_ventaDetalle";
                SqlCommand command;
                command = new SqlCommand(Query, conn);
                command.Parameters.AddWithValue("@Id_ventaDetalle", txtID_VenDet.Text);
                MessageBox.Show("Se ha eliminado correctamente");
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void cmbIDventa_DropDown(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            dataTable = tablas("Ventas");
            cmbIDventa.Items.Clear();
            foreach (DataRow row in dataTable.Rows)
            {

                cmbIDventa.Items.Add(row[0].ToString());

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
