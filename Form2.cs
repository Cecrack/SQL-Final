using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;  
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SQL_FINAL
{

    public partial class Form2 : Form
    {


        private string connectionString;
        public Form2(string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString; // Asignar la cadena de conexión al campo connectionString
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnBodegas_Click(object sender, EventArgs e)
        {
            bodegas bodega = new bodegas(connectionString); // Pasar la cadena de conexión al constructor de Form2
            bodega.ShowDialog();
            
        }

        private void brnClientes_Click(object sender, EventArgs e)
        {
            Clientes bodega = new Clientes(connectionString); // Pasar la cadena de conexión al constructor de Form2
            bodega.ShowDialog();
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            Compras bodega = new Compras(connectionString); // Pasar la cadena de conexión al constructor de Form2
            bodega.ShowDialog();
        }

        private void btnComDet_Click(object sender, EventArgs e)
        {
            compraDetalles bodega = new compraDetalles(connectionString); // Pasar la cadena de conexión al constructor de Form2
            bodega.ShowDialog();

            
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            Inventario bodega = new Inventario(connectionString); // Pasar la cadena de conexión al constructor de Form2
            bodega.ShowDialog();

        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            Productos bodega = new Productos(connectionString); // Pasar la cadena de conexión al constructor de Form2
            bodega.ShowDialog();

        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            Proveedores bodega = new Proveedores(connectionString); // Pasar la cadena de conexión al constructor de Form2
            bodega.ShowDialog();

        }

        private void btnTdP_Click(object sender, EventArgs e)
        {
            Tipos_de_pago bodega = new Tipos_de_pago(connectionString); // Pasar la cadena de conexión al constructor de Form2
            bodega.ShowDialog();

        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            ventas bodega = new ventas(connectionString); // Pasar la cadena de conexión al constructor de Form2
            bodega.ShowDialog();

            
        }

        private void btnVenDet_Click(object sender, EventArgs e)
        {
            ventas_detalles bodega = new ventas_detalles(connectionString); // Pasar la cadena de conexión al constructor de Form2
            bodega.ShowDialog();
            
        }

        
    }
}

