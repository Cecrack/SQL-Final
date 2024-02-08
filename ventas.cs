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
    public partial class ventas : Form
    {
        private string connectionString;
        public ventas(string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString;
            lblFecha.Visible = false;
            lblID_venta.Visible = false;
            lblTotal.Visible = false;
            lblTP.Visible = false;
            lblID_clientes.Visible = false;
            txtId_venta.Visible = false;
            DTP1.Visible = false;
            cmbTP.Visible = false;
            txtTotal.Visible = false;
            cmbClientes.Visible = false;

        }



        private void btnConsulta_Click(object sender, EventArgs e)
        {
            lblFecha.Visible = true;
            lblID_venta.Visible = true;
            lblID_clientes.Visible=true;
            lblTotal.Visible = true;
            lblTP.Visible = true;
            txtId_venta.Visible = true;
            DTP1.Visible = true;
            cmbTP.Visible =  true;
            txtTotal.Visible = true;
            cmbClientes.Visible = true;
            if (txtId_venta.Text == "")
            {
                string tablaSeleccionada = "Ventas";

                DataTable dt = abrirtablas(tablaSeleccionada);
                DGV1.DataSource = dt;
            }
            else
            {
                string tablaSeleccionada = "Ventas";
                string abrir1 = "Id_venta";
                string abrir2 = txtId_venta.Text;

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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = AbrirConexion();
                string Query = "INSERT INTO Ventas (Id_cliente,Fecha,Total,Id_TipoPago) " +
                  "VALUES (@Id_cliente,@Fecha,@Total,@Id_TipoPago)";
                SqlCommand command;
                command = new SqlCommand(Query, conn);
                command.Parameters.AddWithValue("@Id_cliente", cmbClientes.Text);
                command.Parameters.AddWithValue("@Fecha", DTP1.Value);
                command.Parameters.AddWithValue("@Total", txtTotal.Text);
                command.Parameters.AddWithValue("@Id_TipoPago", cmbTP.Text);
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
                string Query = $"DELETE FROM Ventas WHERE Id_venta=@Id_venta";
                SqlCommand command;
                command = new SqlCommand(Query, conn);
                command.Parameters.AddWithValue("@Id_venta", txtId_venta.Text);
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
                string Query = "UPDATE Ventas SET Id_cliente=@Id_cliente,Fecha=@Fecha,Total=@Total,Id_TipoPago=@Id_TipoPago WHERE Id_venta=@Id_venta";
                SqlCommand command;
                command = new SqlCommand(Query, conn);
                command.Parameters.AddWithValue("@Id_venta", txtId_venta.Text);
                command.Parameters.AddWithValue("@Id_cliente", cmbClientes.Text);
                command.Parameters.AddWithValue("@Fecha", DTP1.Value);
                command.Parameters.AddWithValue("@Total", txtTotal.Text);
                command.Parameters.AddWithValue("@Id_TipoPago", cmbTP.Text);
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

        private void ventas_Load(object sender, EventArgs e)
        {

        }

        private void cmbClientes_DropDown(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            dataTable = tablas("Clientes");
            cmbClientes.Items.Clear();
            foreach (DataRow row in dataTable.Rows)
            {

                cmbClientes.Items.Add(row[0].ToString());

            }
        }

        private void cmbTP_DropDown(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            dataTable = tablas("TiposPagos");
            cmbTP.Items.Clear();
            foreach (DataRow row in dataTable.Rows)
            {

                    cmbTP.Items.Add(row[0].ToString());

            }
        }
    }
}
