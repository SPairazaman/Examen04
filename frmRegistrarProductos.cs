using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen04
{
    public partial class frmRegistrarProductos : Form
    {
        public frmRegistrarProductos()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = null;
            SqlParameter sqlParameterNombre = null;
            SqlParameter sqlParameterPrecio = null;
            SqlParameter sqlParameterStock = null;


            Producto producto = new Producto {
                Nombre=txtNombre.Text,
                Precio=Convert.ToInt32(txtPrecio.Text),
                Stock= Convert.ToInt32(txtStock.Text)
            };

            try
            {
                using (SqlConnection connection = new SqlConnection(Constantes.cadenaConexion) )
                {
                    connection.Open();

                    sqlCommand = new SqlCommand("USP_RegistrarProductos", connection);
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlParameterNombre = new SqlParameter("@Nombre", SqlDbType.VarChar,100);
                    sqlParameterNombre.Value = producto.Nombre;

                    sqlParameterPrecio = new SqlParameter("@Precio", SqlDbType.Decimal);
                    sqlParameterPrecio.Value = producto.Precio;

                    sqlParameterStock = new SqlParameter("@Stock", SqlDbType.Int);
                    sqlParameterStock.Value = producto.Stock;

                    sqlCommand.Parameters.Add(sqlParameterNombre);
                    sqlCommand.Parameters.Add(sqlParameterPrecio);
                    sqlCommand.Parameters.Add(sqlParameterStock);

                   sqlCommand.ExecuteNonQuery();

                    MessageBox.Show("Registro del producto satisfatoriamente");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error comuniquese con el administrador");
            }

        }
    }
}
