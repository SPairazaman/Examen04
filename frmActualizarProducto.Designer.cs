namespace Examen04
{
    partial class frmActualizarProducto
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
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            btnActualizar = new Button();
            lblMensaje = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btmBuscar);
            groupBox1.Controls.Add(txtIdProducto);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(390, 60);
            groupBox1.TabIndex = 1;
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
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(12, 90);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(324, 159);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(79, 114);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(216, 23);
            txtStock.TabIndex = 4;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(79, 75);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(216, 23);
            txtPrecio.TabIndex = 4;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(79, 30);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(216, 23);
            txtNombre.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 110);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 2;
            label3.Text = "Stock";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 75);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 1;
            label2.Text = "Precio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 40);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 0;
            label4.Text = "Nombre";
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(359, 103);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 3;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(27, 271);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(51, 15);
            lblMensaje.TabIndex = 7;
            lblMensaje.Text = "Mensaje";
            // 
            // frmActualizarProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 304);
            Controls.Add(lblMensaje);
            Controls.Add(btnActualizar);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmActualizarProducto";
            Text = "frmActualizarProducto";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btmBuscar;
        private TextBox txtIdProducto;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox txtStock;
        private TextBox txtPrecio;
        private TextBox txtNombre;
        private Label label3;
        private Label label2;
        private Label label4;
        private Button btnActualizar;
        private Label lblMensaje;
    }
}