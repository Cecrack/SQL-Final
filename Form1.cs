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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SQL_FINAL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
            
        private string connectionString;
        public string    baseDatos;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnconnect_Click(object sender, EventArgs e)
        {
            string servidor = "LAPTOP-M0P6SDBJ\\SQLEXPRESS";
            string baseDeDatos=cmbBasedDatos.Text;
            string usuario = txtUser.Text;
            string contrasena = txtContra.Text;


            try
            {
                if(connect(servidor, baseDeDatos, usuario, contrasena))
                {
                    connectionString = $"Data Source={servidor};Initial Catalog={baseDeDatos};User ID={usuario};Password={contrasena}";

                    Form2 form2 = new Form2( connectionString); // Pasar la cadena de conexión al constructor de Form2
                    form2.ShowDialog();
                }
                
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error al conectar a la base de datos: {ex.Message}");
            }
         
        }

        private void cmbBasedDatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            baseDatos = cmbBasedDatos.SelectedItem.ToString();
        }

      


        public bool connect(string servidor, string baseDeDatos, string usuario, string contraseña)
        {
            bool estado=false;
            try
            {
                if (baseDeDatos != "") {
                    string stringConectar = $"Data Source={servidor};Initial Catalog={baseDeDatos};User ID={usuario};Password={contraseña}";
                    SqlConnection conexion = new SqlConnection(stringConectar);
                    conexion.Open();
                    estado=true;
                }
                else{
                    MessageBox.Show("Conexión no exitosa");
                }
                
                
            }
            catch {
                MessageBox.Show("Conexión no exitosa");
            }

            return estado;
        }

        public DataTable consultaBaseDeDAtos()
        {
            string stringConectar = $"Data Source=LAPTOP-M0P6SDBJ\\SQLEXPRESS;Integrated Security=true";
            DataTable dt = new DataTable("DataBaseNames");

            try
            {
                using(SqlConnection conexion = new SqlConnection(stringConectar))
                {
                    conexion.Open();
                    string query = "select name FROM sys.databases";


                    using (SqlCommand command = new SqlCommand(query,conexion))
                    {

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
               
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error al conectar a la base de datos: {ex.Message}");
            }
            return dt;
        }

        private void cmbBasedDatos_DropDown(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            dataTable=consultaBaseDeDAtos();
            cmbBasedDatos.Items.Clear();
            foreach (DataRow row in dataTable.Rows) 
            {
               
                cmbBasedDatos.Items.Add(row[0].ToString());    
                
            }
        }
    }
}
