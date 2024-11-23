using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen04
{
    public partial class frmActualizarProducto : Form
    {
        public frmActualizarProducto()
        {
            InitializeComponent();
        }

        private void btmBuscar_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = null;
            SqlParameter sqlParameterID = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(Constantes.cadenaConexion))
                {
                    connection.Open();

                    sqlCommand = new SqlCommand("USP_BuscarProductoPorId", connection);
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlParameterID = new SqlParameter("@IdProducto", SqlDbType.Int);
                    sqlParameterID.Value = Convert.ToInt32(txtIdProducto.Text);

                    sqlCommand.Parameters.Add(sqlParameterID);

                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        txtIdProducto.Text = Convert.ToString(reader["IdProducto"]);
                        txtNombre.Text = reader["Nombre"].ToString();
                        txtPrecio.Text = Convert.ToString(reader["precio"]);
                        txtStock.Text = Convert.ToString(reader["stock"]);
                    }

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error comuniquese con el administrador");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = null;
            SqlParameter sqlParameterID = null;
            SqlParameter sqlParameterNombre = null;
            SqlParameter sqlParameterPrecio = null;
            SqlParameter sqlParameterStock = null;


            Producto producto = new Producto
            {
                IdProducto=Convert.ToInt32(txtIdProducto.Text),
                Nombre = txtNombre.Text,
                Precio = Convert.ToInt32(txtPrecio.Text),
                Stock = Convert.ToInt32(txtStock.Text)
            };

            try
            {
                using (SqlConnection connection = new SqlConnection(Constantes.cadenaConexion))
                {
                    connection.Open();

                    sqlCommand = new SqlCommand("USP_ActualizarProductos", connection);
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlParameterID = new SqlParameter("@IdProducto", SqlDbType.Int);
                    sqlParameterID.Value = producto.IdProducto;

                    sqlParameterNombre = new SqlParameter("@Nombre", SqlDbType.VarChar, 100);
                    sqlParameterNombre.Value = producto.Nombre;

                    sqlParameterPrecio = new SqlParameter("@Precio", SqlDbType.Decimal);
                    sqlParameterPrecio.Value = producto.Precio;

                    sqlParameterStock = new SqlParameter("@Stock", SqlDbType.Int);
                    sqlParameterStock.Value = producto.Stock;

                    sqlCommand.Parameters.Add(sqlParameterID);
                    sqlCommand.Parameters.Add(sqlParameterNombre);
                    sqlCommand.Parameters.Add(sqlParameterPrecio);
                    sqlCommand.Parameters.Add(sqlParameterStock);

                    sqlCommand.ExecuteNonQuery();

                    MessageBox.Show("Actualización satisfatoria");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error comuniquese con el administrador");
            }
        }
    }
}
