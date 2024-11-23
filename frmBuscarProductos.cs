﻿using Microsoft.Data.SqlClient;
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
    public partial class frmBuscarProductos : Form
    {
        public frmBuscarProductos()
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
    }
}