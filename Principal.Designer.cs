namespace VentaVehiculos
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.manteminiemtoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modelosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDeTransmisionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDeCombustibleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventaDeVehiculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manteminiemtoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(603, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // manteminiemtoToolStripMenuItem
            // 
            this.manteminiemtoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.vehiculosToolStripMenuItem,
            this.marcasToolStripMenuItem,
            this.modelosToolStripMenuItem,
            this.tipoDeTransmisionToolStripMenuItem,
            this.tipoDeCombustibleToolStripMenuItem,
            this.ventaDeVehiculoToolStripMenuItem});
            this.manteminiemtoToolStripMenuItem.Name = "manteminiemtoToolStripMenuItem";
            this.manteminiemtoToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.manteminiemtoToolStripMenuItem.Text = "Manteminiento";
            this.manteminiemtoToolStripMenuItem.Click += new System.EventHandler(this.manteminiemtoToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // vehiculosToolStripMenuItem
            // 
            this.vehiculosToolStripMenuItem.Name = "vehiculosToolStripMenuItem";
            this.vehiculosToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.vehiculosToolStripMenuItem.Text = "Vehiculos";
            this.vehiculosToolStripMenuItem.Click += new System.EventHandler(this.vehiculosToolStripMenuItem_Click);
            // 
            // marcasToolStripMenuItem
            // 
            this.marcasToolStripMenuItem.Name = "marcasToolStripMenuItem";
            this.marcasToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.marcasToolStripMenuItem.Text = "Marcas";
            this.marcasToolStripMenuItem.Click += new System.EventHandler(this.marcasToolStripMenuItem_Click);
            // 
            // modelosToolStripMenuItem
            // 
            this.modelosToolStripMenuItem.Name = "modelosToolStripMenuItem";
            this.modelosToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.modelosToolStripMenuItem.Text = "Modelos";
            this.modelosToolStripMenuItem.Click += new System.EventHandler(this.modelosToolStripMenuItem_Click);
            // 
            // tipoDeTransmisionToolStripMenuItem
            // 
            this.tipoDeTransmisionToolStripMenuItem.Name = "tipoDeTransmisionToolStripMenuItem";
            this.tipoDeTransmisionToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.tipoDeTransmisionToolStripMenuItem.Text = "Tipo de Transmision";
            this.tipoDeTransmisionToolStripMenuItem.Click += new System.EventHandler(this.tipoDeTransmisionToolStripMenuItem_Click);
            // 
            // tipoDeCombustibleToolStripMenuItem
            // 
            this.tipoDeCombustibleToolStripMenuItem.Name = "tipoDeCombustibleToolStripMenuItem";
            this.tipoDeCombustibleToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.tipoDeCombustibleToolStripMenuItem.Text = "Tipo de Combustible";
            this.tipoDeCombustibleToolStripMenuItem.Click += new System.EventHandler(this.tipoDeCombustibleToolStripMenuItem_Click);
            // 
            // ventaDeVehiculoToolStripMenuItem
            // 
            this.ventaDeVehiculoToolStripMenuItem.Name = "ventaDeVehiculoToolStripMenuItem";
            this.ventaDeVehiculoToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.ventaDeVehiculoToolStripMenuItem.Text = "Venta de Vehiculo";
            this.ventaDeVehiculoToolStripMenuItem.Click += new System.EventHandler(this.ventaDeVehiculoToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 234);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "Pantalla Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manteminiemtoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehiculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modelosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDeTransmisionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDeCombustibleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventaDeVehiculoToolStripMenuItem;
    }
}

