namespace Examen04
{
    partial class frmRegistrarProductos
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNombre = new TextBox();
            txtPrecio = new TextBox();
            txtStock = new TextBox();
            btnRegistrar = new Button();
            lblMensaje = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtStock);
            groupBox1.Controls.Add(txtPrecio);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 10);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(324, 159);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 40);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 110);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 2;
            label3.Text = "Stock";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(79, 30);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(216, 23);
            txtNombre.TabIndex = 3;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(79, 75);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(216, 23);
            txtPrecio.TabIndex = 4;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(79, 114);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(216, 23);
            txtStock.TabIndex = 4;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(353, 21);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 23);
            btnRegistrar.TabIndex = 1;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(12, 191);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(51, 15);
            lblMensaje.TabIndex = 6;
            lblMensaje.Text = "Mensaje";
            // 
            // frmRegistrarProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 224);
            Controls.Add(lblMensaje);
            Controls.Add(btnRegistrar);
            Controls.Add(groupBox1);
            Name = "frmRegistrarProductos";
            Text = "frmRegistrarProductos";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtStock;
        private TextBox txtPrecio;
        private TextBox txtNombre;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnRegistrar;
        private Label lblMensaje;
    }
}