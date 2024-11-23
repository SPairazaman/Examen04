namespace Examen04
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmRegistrarProductos productos = new frmRegistrarProductos();
            productos.ShowDialog();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            frmActualizarProducto productos = new frmActualizarProducto();
            productos.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            frmEliminarProdudcto productos = new frmEliminarProdudcto();
            productos.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarProductos productos = new frmBuscarProductos();
            productos.ShowDialog();
        }
    }
}
