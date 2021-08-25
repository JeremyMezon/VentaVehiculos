namespace VentaVehiculos.Pantallas_de_Mantenimiento
{
    partial class AdmVehiculos
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
            this.comboEstado = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.LbTituloCliente = new System.Windows.Forms.Label();
            this.btnGuardarCliente = new System.Windows.Forms.Button();
            this.txtKilometraje = new System.Windows.Forms.TextBox();
            this.txtCilindraje = new System.Windows.Forms.TextBox();
            this.txtChasis = new System.Windows.Forms.TextBox();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.txtCantidadPuertas = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPrecioVehiculo = new System.Windows.Forms.TextBox();
            this.comboCombustible = new System.Windows.Forms.ComboBox();
            this.comboTransmision = new System.Windows.Forms.ComboBox();
            this.comboModelo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
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
            this.comboEstado.Location = new System.Drawing.Point(579, 296);
            this.comboEstado.Name = "comboEstado";
            this.comboEstado.Size = new System.Drawing.Size(166, 21);
            this.comboEstado.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(404, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 19);
            this.label7.TabIndex = 32;
            this.label7.Text = "Modelo:";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(16, 55);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(607, 10);
            this.bunifuSeparator1.TabIndex = 31;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // LbTituloCliente
            // 
            this.LbTituloCliente.AutoSize = true;
            this.LbTituloCliente.Font = new System.Drawing.Font("Lato", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTituloCliente.Location = new System.Drawing.Point(12, 18);
            this.LbTituloCliente.Name = "LbTituloCliente";
            this.LbTituloCliente.Size = new System.Drawing.Size(213, 34);
            this.LbTituloCliente.TabIndex = 30;
            this.LbTituloCliente.Text = "Nuevo Vehiculo";
            // 
            // btnGuardarCliente
            // 
            this.btnGuardarCliente.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGuardarCliente.FlatAppearance.BorderSize = 0;
            this.btnGuardarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarCliente.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardarCliente.Location = new System.Drawing.Point(560, 364);
            this.btnGuardarCliente.Name = "btnGuardarCliente";
            this.btnGuardarCliente.Size = new System.Drawing.Size(185, 35);
            this.btnGuardarCliente.TabIndex = 28;
            this.btnGuardarCliente.Text = "Guardar";
            this.btnGuardarCliente.UseVisualStyleBackColor = false;
            this.btnGuardarCliente.Click += new System.EventHandler(this.btnGuardarCliente_Click);
            // 
            // txtKilometraje
            // 
            this.txtKilometraje.Location = new System.Drawing.Point(169, 293);
            this.txtKilometraje.MaxLength = 75;
            this.txtKilometraje.Name = "txtKilometraje";
            this.txtKilometraje.Size = new System.Drawing.Size(203, 20);
            this.txtKilometraje.TabIndex = 26;
            // 
            // txtCilindraje
            // 
            this.txtCilindraje.Location = new System.Drawing.Point(169, 253);
            this.txtCilindraje.MaxLength = 100;
            this.txtCilindraje.Name = "txtCilindraje";
            this.txtCilindraje.Size = new System.Drawing.Size(203, 20);
            this.txtCilindraje.TabIndex = 22;
            // 
            // txtChasis
            // 
            this.txtChasis.Location = new System.Drawing.Point(170, 93);
            this.txtChasis.MaxLength = 100;
            this.txtChasis.Name = "txtChasis";
            this.txtChasis.Size = new System.Drawing.Size(203, 20);
            this.txtChasis.TabIndex = 18;
            // 
            // txtAnio
            // 
            this.txtAnio.Location = new System.Drawing.Point(170, 173);
            this.txtAnio.MaxLength = 100;
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(203, 20);
            this.txtAnio.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 334);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 19);
            this.label6.TabIndex = 29;
            this.label6.Text = "Cantidad de Puertas:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 19);
            this.label5.TabIndex = 25;
            this.label5.Text = "Chasis:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 19);
            this.label4.TabIndex = 23;
            this.label4.Text = "Cilindraje:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 19);
            this.label3.TabIndex = 21;
            this.label3.Text = "Año:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 19);
            this.label2.TabIndex = 20;
            this.label2.Text = "Color:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 19);
            this.label1.TabIndex = 17;
            this.label1.Text = "Placa:";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(170, 133);
            this.txtPlaca.MaxLength = 100;
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(203, 20);
            this.txtPlaca.TabIndex = 19;
            // 
            // txtCantidadPuertas
            // 
            this.txtCantidadPuertas.Location = new System.Drawing.Point(169, 333);
            this.txtCantidadPuertas.MaxLength = 75;
            this.txtCantidadPuertas.Name = "txtCantidadPuertas";
            this.txtCantidadPuertas.Size = new System.Drawing.Size(203, 20);
            this.txtCantidadPuertas.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 294);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 19);
            this.label8.TabIndex = 34;
            this.label8.Text = "Kilometraje:";
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(170, 213);
            this.txtColor.MaxLength = 100;
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(203, 20);
            this.txtColor.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(404, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 19);
            this.label9.TabIndex = 37;
            this.label9.Text = "Precio:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(404, 194);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(151, 19);
            this.label10.TabIndex = 39;
            this.label10.Text = "Tipo de Transmision:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(404, 244);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(152, 19);
            this.label11.TabIndex = 40;
            this.label11.Text = "Tipo de combustible:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(404, 294);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 19);
            this.label12.TabIndex = 41;
            this.label12.Text = "Estado";
            // 
            // txtPrecioVehiculo
            // 
            this.txtPrecioVehiculo.Location = new System.Drawing.Point(579, 96);
            this.txtPrecioVehiculo.MaxLength = 100;
            this.txtPrecioVehiculo.Name = "txtPrecioVehiculo";
            this.txtPrecioVehiculo.Size = new System.Drawing.Size(166, 20);
            this.txtPrecioVehiculo.TabIndex = 43;
            // 
            // comboCombustible
            // 
            this.comboCombustible.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.comboCombustible.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboCombustible.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCombustible.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboCombustible.FormattingEnabled = true;
            this.comboCombustible.Location = new System.Drawing.Point(579, 246);
            this.comboCombustible.Name = "comboCombustible";
            this.comboCombustible.Size = new System.Drawing.Size(166, 21);
            this.comboCombustible.TabIndex = 44;
            // 
            // comboTransmision
            // 
            this.comboTransmision.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.comboTransmision.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboTransmision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTransmision.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboTransmision.FormattingEnabled = true;
            this.comboTransmision.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.comboTransmision.Location = new System.Drawing.Point(579, 196);
            this.comboTransmision.Name = "comboTransmision";
            this.comboTransmision.Size = new System.Drawing.Size(166, 21);
            this.comboTransmision.TabIndex = 45;
            // 
            // comboModelo
            // 
            this.comboModelo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.comboModelo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboModelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboModelo.FormattingEnabled = true;
            this.comboModelo.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.comboModelo.Location = new System.Drawing.Point(579, 142);
            this.comboModelo.Name = "comboModelo";
            this.comboModelo.Size = new System.Drawing.Size(166, 21);
            this.comboModelo.TabIndex = 46;
            // 
            // AdmVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboModelo);
            this.Controls.Add(this.comboTransmision);
            this.Controls.Add(this.comboCombustible);
            this.Controls.Add(this.txtPrecioVehiculo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.txtCantidadPuertas);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboEstado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.LbTituloCliente);
            this.Controls.Add(this.btnGuardarCliente);
            this.Controls.Add(this.txtKilometraje);
            this.Controls.Add(this.txtCilindraje);
            this.Controls.Add(this.txtChasis);
            this.Controls.Add(this.txtAnio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPlaca);
            this.Name = "AdmVehiculos";
            this.Text = "AdmVehiculos";
            this.Load += new System.EventHandler(this.AdmVehiculos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboEstado;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        public System.Windows.Forms.Label LbTituloCliente;
        private System.Windows.Forms.Button btnGuardarCliente;
        private System.Windows.Forms.TextBox txtKilometraje;
        private System.Windows.Forms.TextBox txtCilindraje;
        private System.Windows.Forms.TextBox txtChasis;
        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.TextBox txtCantidadPuertas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPrecioVehiculo;
        private System.Windows.Forms.ComboBox comboCombustible;
        private System.Windows.Forms.ComboBox comboTransmision;
        private System.Windows.Forms.ComboBox comboModelo;
    }
}