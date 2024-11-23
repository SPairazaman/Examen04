namespace Examen04
{
    partial class frmMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnBuscar = new Button();
            btnRegistrar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            SuspendLayout();
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(126, 26);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(153, 70);
            btnBuscar.TabIndex = 0;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.AccessibleDescription = "btnRegistrar";
            btnRegistrar.Location = new Point(126, 102);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(153, 70);
            btnRegistrar.TabIndex = 1;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += button1_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.AccessibleDescription = "btnRegistrar";
            btnActualizar.Location = new Point(126, 187);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(153, 70);
            btnActualizar.TabIndex = 2;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.AccessibleDescription = "btnRegistrar";
            btnEliminar.Location = new Point(126, 263);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(153, 70);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(433, 390);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnRegistrar);
            Controls.Add(btnBuscar);
            Name = "frmMenu";
            Text = "MENU";
            ResumeLayout(false);
        }

        #endregion

        private Button btnBuscar;
        private Button btnRegistrar;
        private Button btnActualizar;
        private Button btnEliminar;
    }
}
