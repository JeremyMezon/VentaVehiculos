namespace VentaVehiculos.Pantallas_de_Mantenimiento
{
    partial class AdmVentas
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
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.LbTituloVenta = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboClientes = new System.Windows.Forms.ComboBox();
            this.comboVehiculo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboMetodoPago = new System.Windows.Forms.ComboBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGuardarVenta = new System.Windows.Forms.Button();
            this.comboEstado = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.LbVehiculoCombustible = new System.Windows.Forms.Label();
            this.LbVehiculoAnio = new System.Windows.Forms.Label();
            this.LbVehiculoColor = new System.Windows.Forms.Label();
            this.LbVehiculoTransmision = new System.Windows.Forms.Label();
            this.LbVehiculoPrecio = new System.Windows.Forms.Label();
            this.LbVehiculoModelo = new System.Windows.Forms.Label();
            this.LbVehiculoMarca = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.bunifuCards1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(13, 59);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(367, 18);
            this.bunifuSeparator1.TabIndex = 35;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // LbTituloVenta
            // 
            this.LbTituloVenta.AutoSize = true;
            this.LbTituloVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTituloVenta.Location = new System.Drawing.Point(9, 22);
            this.LbTituloVenta.Name = "LbTituloVenta";
            this.LbTituloVenta.Size = new System.Drawing.Size(190, 32);
            this.LbTituloVenta.TabIndex = 34;
            this.LbTituloVenta.Text = "Nueva Venta";
            this.LbTituloVenta.Click += new System.EventHandler(this.LbTituloMarca_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 33;
            this.label5.Text = "Cliente:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // comboClientes
            // 
            this.comboClientes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.comboClientes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboClientes.FormattingEnabled = true;
            this.comboClientes.Location = new System.Drawing.Point(165, 85);
            this.comboClientes.Name = "comboClientes";
            this.comboClientes.Size = new System.Drawing.Size(203, 21);
            this.comboClientes.TabIndex = 44;
            this.comboClientes.SelectedIndexChanged += new System.EventHandler(this.comboClientes_SelectedIndexChanged);
            // 
            // comboVehiculo
            // 
            this.comboVehiculo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.comboVehiculo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboVehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboVehiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboVehiculo.FormattingEnabled = true;
            this.comboVehiculo.Location = new System.Drawing.Point(165, 118);
            this.comboVehiculo.Name = "comboVehiculo";
            this.comboVehiculo.Size = new System.Drawing.Size(203, 21);
            this.comboVehiculo.TabIndex = 46;
            this.comboVehiculo.SelectedIndexChanged += new System.EventHandler(this.comboVehiculo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 45;
            this.label1.Text = "Vehiculo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 47;
            this.label2.Text = "Metodo de Pago:";
            // 
            // comboMetodoPago
            // 
            this.comboMetodoPago.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.comboMetodoPago.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboMetodoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMetodoPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboMetodoPago.FormattingEnabled = true;
            this.comboMetodoPago.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta",
            "Cheque"});
            this.comboMetodoPago.Location = new System.Drawing.Point(165, 155);
            this.comboMetodoPago.Name = "comboMetodoPago";
            this.comboMetodoPago.Size = new System.Drawing.Size(203, 21);
            this.comboMetodoPago.TabIndex = 49;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(165, 194);
            this.txtPrecio.MaxLength = 100;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(203, 20);
            this.txtPrecio.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 51;
            this.label3.Text = "Precio RD$:";
            // 
            // btnGuardarVenta
            // 
            this.btnGuardarVenta.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGuardarVenta.FlatAppearance.BorderSize = 0;
            this.btnGuardarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarVenta.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarVenta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardarVenta.Location = new System.Drawing.Point(226, 279);
            this.btnGuardarVenta.Name = "btnGuardarVenta";
            this.btnGuardarVenta.Size = new System.Drawing.Size(140, 35);
            this.btnGuardarVenta.TabIndex = 52;
            this.btnGuardarVenta.Text = "Guardar";
            this.btnGuardarVenta.UseVisualStyleBackColor = false;
            this.btnGuardarVenta.Click += new System.EventHandler(this.btnGuardarVenta_Click);
            // 
            // comboEstado
            // 
            this.comboEstado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.comboEstado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboEstado.FormattingEnabled = true;
            this.comboEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.comboEstado.Location = new System.Drawing.Point(165, 224);
            this.comboEstado.Name = "comboEstado";
            this.comboEstado.Size = new System.Drawing.Size(203, 21);
            this.comboEstado.TabIndex = 54;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 20);
            this.label7.TabIndex = 53;
            this.label7.Text = "Estado";
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Tomato;
            this.bunifuCards1.Controls.Add(this.LbVehiculoModelo);
            this.bunifuCards1.Controls.Add(this.LbVehiculoPrecio);
            this.bunifuCards1.Controls.Add(this.LbVehiculoTransmision);
            this.bunifuCards1.Controls.Add(this.LbVehiculoMarca);
            this.bunifuCards1.Controls.Add(this.LbVehiculoColor);
            this.bunifuCards1.Controls.Add(this.LbVehiculoAnio);
            this.bunifuCards1.Controls.Add(this.label14);
            this.bunifuCards1.Controls.Add(this.LbVehiculoCombustible);
            this.bunifuCards1.Controls.Add(this.label15);
            this.bunifuCards1.Controls.Add(this.label11);
            this.bunifuCards1.Controls.Add(this.label10);
            this.bunifuCards1.Controls.Add(this.label9);
            this.bunifuCards1.Controls.Add(this.label8);
            this.bunifuCards1.Controls.Add(this.label6);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(398, 76);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(362, 269);
            this.bunifuCards1.TabIndex = 55;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "Color:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(394, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 24);
            this.label4.TabIndex = 56;
            this.label4.Text = "Datos del vehiculo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 19);
            this.label8.TabIndex = 2;
            this.label8.Text = "Año:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 19);
            this.label9.TabIndex = 3;
            this.label9.Text = "Tipo de Combustile:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(20, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 19);
            this.label10.TabIndex = 4;
            this.label10.Text = "Transmision:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(20, 154);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 19);
            this.label11.TabIndex = 5;
            this.label11.Text = "Precio:";
            // 
            // LbVehiculoCombustible
            // 
            this.LbVehiculoCombustible.AutoSize = true;
            this.LbVehiculoCombustible.Location = new System.Drawing.Point(177, 100);
            this.LbVehiculoCombustible.Name = "LbVehiculoCombustible";
            this.LbVehiculoCombustible.Size = new System.Drawing.Size(25, 13);
            this.LbVehiculoCombustible.TabIndex = 6;
            this.LbVehiculoCombustible.Text = "------";
            // 
            // LbVehiculoAnio
            // 
            this.LbVehiculoAnio.AutoSize = true;
            this.LbVehiculoAnio.Location = new System.Drawing.Point(177, 70);
            this.LbVehiculoAnio.Name = "LbVehiculoAnio";
            this.LbVehiculoAnio.Size = new System.Drawing.Size(25, 13);
            this.LbVehiculoAnio.TabIndex = 7;
            this.LbVehiculoAnio.Text = "------";
            // 
            // LbVehiculoColor
            // 
            this.LbVehiculoColor.AutoSize = true;
            this.LbVehiculoColor.Location = new System.Drawing.Point(177, 40);
            this.LbVehiculoColor.Name = "LbVehiculoColor";
            this.LbVehiculoColor.Size = new System.Drawing.Size(25, 13);
            this.LbVehiculoColor.TabIndex = 8;
            this.LbVehiculoColor.Text = "------";
            // 
            // LbVehiculoTransmision
            // 
            this.LbVehiculoTransmision.AutoSize = true;
            this.LbVehiculoTransmision.Location = new System.Drawing.Point(177, 130);
            this.LbVehiculoTransmision.Name = "LbVehiculoTransmision";
            this.LbVehiculoTransmision.Size = new System.Drawing.Size(25, 13);
            this.LbVehiculoTransmision.TabIndex = 9;
            this.LbVehiculoTransmision.Text = "------";
            // 
            // LbVehiculoPrecio
            // 
            this.LbVehiculoPrecio.AutoSize = true;
            this.LbVehiculoPrecio.Location = new System.Drawing.Point(177, 160);
            this.LbVehiculoPrecio.Name = "LbVehiculoPrecio";
            this.LbVehiculoPrecio.Size = new System.Drawing.Size(25, 13);
            this.LbVehiculoPrecio.TabIndex = 10;
            this.LbVehiculoPrecio.Text = "------";
            // 
            // LbVehiculoModelo
            // 
            this.LbVehiculoModelo.AutoSize = true;
            this.LbVehiculoModelo.Location = new System.Drawing.Point(177, 220);
            this.LbVehiculoModelo.Name = "LbVehiculoModelo";
            this.LbVehiculoModelo.Size = new System.Drawing.Size(25, 13);
            this.LbVehiculoModelo.TabIndex = 14;
            this.LbVehiculoModelo.Text = "------";
            // 
            // LbVehiculoMarca
            // 
            this.LbVehiculoMarca.AutoSize = true;
            this.LbVehiculoMarca.Location = new System.Drawing.Point(177, 190);
            this.LbVehiculoMarca.Name = "LbVehiculoMarca";
            this.LbVehiculoMarca.Size = new System.Drawing.Size(25, 13);
            this.LbVehiculoMarca.TabIndex = 13;
            this.LbVehiculoMarca.Text = "------";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(20, 216);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 19);
            this.label14.TabIndex = 12;
            this.label14.Text = "Modelo:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(20, 185);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 19);
            this.label15.TabIndex = 11;
            this.label15.Text = "Marca:";
            // 
            // AdmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 368);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bunifuCards1);
            this.Controls.Add(this.comboEstado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnGuardarVenta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.comboMetodoPago);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboVehiculo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboClientes);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.LbTituloVenta);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdmVentas";
            this.Text = "AdmVentas";
            this.Load += new System.EventHandler(this.AdmVentas_Load_1);
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        public System.Windows.Forms.Label LbTituloVenta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboClientes;
        private System.Windows.Forms.ComboBox comboVehiculo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboMetodoPago;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGuardarVenta;
        private System.Windows.Forms.ComboBox comboEstado;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LbVehiculoPrecio;
        private System.Windows.Forms.Label LbVehiculoTransmision;
        private System.Windows.Forms.Label LbVehiculoColor;
        private System.Windows.Forms.Label LbVehiculoAnio;
        private System.Windows.Forms.Label LbVehiculoCombustible;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LbVehiculoModelo;
        private System.Windows.Forms.Label LbVehiculoMarca;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
    }
}