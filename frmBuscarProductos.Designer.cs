namespace Examen04
{
    partial class frmBuscarProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btmBuscar = new Button();
            txtIdProducto = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            txtStock = new TextBox();
            txtPrecio = new TextBox();
            txtNombre = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btmBuscar);
            groupBox1.Controls.Add(txtIdProducto);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(8, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(390, 60);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Buscar";
            // 
            // btmBuscar
            // 
            btmBuscar.Location = new Point(224, 21);
            btmBuscar.Name = "btmBuscar";
            btmBuscar.Size = new Size(115, 26);
            btmBuscar.TabIndex = 2;
            btmBuscar.Text = "Buscar";
            btmBuscar.UseVisualStyleBackColor = true;
            btmBuscar.Click += btmBuscar_Click;
            // 
            // txtIdProducto
            // 
            txtIdProducto.Location = new Point(87, 23);
            txtIdProducto.Name = "txtIdProducto";
            txtIdProducto.Size = new Size(123, 23);
            txtIdProducto.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 31);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 0;
            label1.Text = "IdProducto";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtStock);
            groupBox2.Controls.Add(txtPrecio);
            groupBox2.Controls.Add(txtNombre);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(10, 80);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(533, 151);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(99, 91);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(196, 23);
            txtStock.TabIndex = 5;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(99, 49);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(196, 23);
            txtPrecio.TabIndex = 4;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(99, 12);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(196, 23);
            txtNombre.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 91);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 2;
            label4.Text = "Stock";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 57);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 1;
            label3.Text = "Precio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 20);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 0;
            label2.Text = "Nombre";
            // 
            // frmBuscarProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 250);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmBuscarProductos";
            Text = "frmBuscarProductos";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtIdProducto;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox txtStock;
        private TextBox txtPrecio;
        private TextBox txtNombre;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btmBuscar;
    }
}