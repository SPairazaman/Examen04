using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen04
{
    public partial class frmEliminarProdudcto : Form
    {
        public frmEliminarProdudcto()
        {
            InitializeComponent();
        }

        private void btmBuscar_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtIdProducto.Text, "^[0-9]+$"))
            {
                MessageBox.Show("Por favor, ingrese solo números.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtIdProducto.Text = "";
                return;
            }

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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = null;
            SqlParameter sqlParameterID = null;
   
            try
            {
                using (SqlConnection connection = new SqlConnection(Constantes.cadenaConexion))
                {
                    connection.Open();

                    sqlCommand = new SqlCommand("USP_EliminarProductos", connection);
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlParameterID = new SqlParameter("@IdProducto", SqlDbType.Int);
                    sqlParameterID.Value = txtIdProducto.Text;

                    sqlCommand.Parameters.Add(sqlParameterID);
              
                    sqlCommand.ExecuteNonQuery();

                    MessageBox.Show("Elimación satisfatoria");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error comuniquese con el administrador");
            }
        }
    }
}
