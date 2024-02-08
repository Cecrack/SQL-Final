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
    public partial class Inventario : Form
    {
        private string connectionString;
        public Inventario(string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString;

            lblID_Bodega.Visible = false;
            label2.Visible = false;
            lblID_invenatrio.Visible = false;
            lblID_pro.Visible = false;
            lblTotalPro.Visible = false;
            lbl_venta.Visible = false;
            txtID_invenatrio.Visible=false;
            txtTP.Visible=false;
            cmbVengta.Visible=false;
            cmbID_producto.Visible=false;
            cmbCompra.Visible=false;
            cmbBodega.Visible=false;
        
           
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            lblID_Bodega.Visible = true;
            label2.Visible=true;
            lblID_invenatrio.Visible = true;
            lblID_pro.Visible = true;
            lblTotalPro.Visible = true;
            lbl_venta.Visible = true;
            txtID_invenatrio.Visible = true;
            txtTP.Visible = true;
            cmbVengta.Visible = true;
            cmbID_producto.Visible = true;
            cmbCompra.Visible = true;
            cmbBodega.Visible = true;
            if (txtID_invenatrio.Text == "")
            {
                string tablaSeleccionada = "Inventarios";

                DataTable dt = abrirtablas(tablaSeleccionada);
                DGV1.DataSource = dt;
            }
            else
            {
                string tablaSeleccionada = "Inventarios";
                string abrir1 = "Id_inventario";
                string abrir2 =txtID_invenatrio.Text;

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
        private void Inventario_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = AbrirConexion();
                string Query = "INSERT INTO Inventarios (Id_producto,Id_Bodega,Id_compra,Id_venta,TotalProductos) " +
                  "VALUES (@Id_producto,@Id_Bodega,@Id_compra,@Id_venta,@TotalProductos)";
                SqlCommand command;
                command = new SqlCommand(Query, conn);
                command.Parameters.AddWithValue("@Id_producto", cmbID_producto.Text);
                command.Parameters.AddWithValue("@Id_Bodega", cmbBodega.Text);
                command.Parameters.AddWithValue("@Id_compra", cmbCompra.Text);
                command.Parameters.AddWithValue("@Id_venta", cmbVengta.Text);
                command.Parameters.AddWithValue("@TotalProductos", txtTP.Text);
                MessageBox.Show("se agrego correctamente la tabla");
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
                string Query = $"DELETE FROM Inventarios WHERE Id_inventario=@Id_inventario";
                SqlCommand command;
                command = new SqlCommand(Query, conn);
                command.Parameters.AddWithValue("@Id_inventario", txtID_invenatrio.Text);
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
                string Query = "UPDATE Inventarios SET Id_producto=@Id_producto,Id_Bodega=@Id_Bodega,Id_compra=@Id_compra," +
                    "Id_venta=@Id_venta,TotalProductos=@TotalProductos WHERE Id_inventario=@Id_inventario";
                SqlCommand command;
                command = new SqlCommand(Query, conn);
                command.Parameters.AddWithValue("@Id_inventario", txtID_invenatrio.Text);
                command.Parameters.AddWithValue("@Id_producto", cmbID_producto.Text);
                command.Parameters.AddWithValue("@Id_Bodega", cmbBodega.Text);
                command.Parameters.AddWithValue("@Id_compra", cmbCompra.Text);
                command.Parameters.AddWithValue("@Id_venta", cmbVengta.Text);
                command.Parameters.AddWithValue("@TotalProductos", txtTP.Text);
                MessageBox.Show("Se ha modificado correctamente");
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
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

        private void cmbBodega_DropDown(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            dataTable = tablas("Bodegas");
            cmbBodega.Items.Clear();
            foreach (DataRow row in dataTable.Rows)
            {

                cmbBodega.Items.Add(row[0].ToString());

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

        private void cmbVengta_DropDown(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            dataTable = tablas("Ventas");
            cmbVengta.Items.Clear();
            foreach (DataRow row in dataTable.Rows)
            {

                cmbVengta.Items.Add(row[0].ToString());

            }
        }
    }
}
