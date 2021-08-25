namespace VentaVehiculos.Pantallas_de_Mantenimiento
{
    partial class AdmTipoTransmisions
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
            this.LbTituloCombustible = new System.Windows.Forms.Label();
            this.btnGuardarMarca = new System.Windows.Forms.Button();
            this.txtNombreTransmision = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
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
            this.comboEstado.Location = new System.Drawing.Point(172, 142);
            this.comboEstado.Name = "comboEstado";
            this.comboEstado.Size = new System.Drawing.Size(121, 21);
            this.comboEstado.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 19);
            this.label7.TabIndex = 46;
            this.label7.Text = "Estado";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(16, 46);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(607, 10);
            this.bunifuSeparator1.TabIndex = 45;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // LbTituloCombustible
            // 
            this.LbTituloCombustible.AutoSize = true;
            this.LbTituloCombustible.Font = new System.Drawing.Font("Lato", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTituloCombustible.Location = new System.Drawing.Point(12, 9);
            this.LbTituloCombustible.Name = "LbTituloCombustible";
            this.LbTituloCombustible.Size = new System.Drawing.Size(361, 34);
            this.LbTituloCombustible.TabIndex = 44;
            this.LbTituloCombustible.Text = "Nueva Tipo de Transimision";
            // 
            // btnGuardarMarca
            // 
            this.btnGuardarMarca.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGuardarMarca.FlatAppearance.BorderSize = 0;
            this.btnGuardarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarMarca.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarMarca.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardarMarca.Location = new System.Drawing.Point(447, 108);
            this.btnGuardarMarca.Name = "btnGuardarMarca";
            this.btnGuardarMarca.Size = new System.Drawing.Size(140, 35);
            this.btnGuardarMarca.TabIndex = 43;
            this.btnGuardarMarca.Text = "Guardar";
            this.btnGuardarMarca.UseVisualStyleBackColor = false;
            this.btnGuardarMarca.Click += new System.EventHandler(this.btnGuardarMarca_Click);
            // 
            // txtNombreTransmision
            // 
            this.txtNombreTransmision.Location = new System.Drawing.Point(172, 87);
            this.txtNombreTransmision.MaxLength = 100;
            this.txtNombreTransmision.Name = "txtNombreTransmision";
            this.txtNombreTransmision.Size = new System.Drawing.Size(203, 20);
            this.txtNombreTransmision.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 19);
            this.label5.TabIndex = 42;
            this.label5.Text = "Tipo de Transmision:";
            // 
            // AdmTipoTransmisions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 203);
            this.Controls.Add(this.comboEstado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.LbTituloCombustible);
            this.Controls.Add(this.btnGuardarMarca);
            this.Controls.Add(this.txtNombreTransmision);
            this.Controls.Add(this.label5);
            this.Name = "AdmTipoTransmisions";
            this.Text = "AdmTipoTransmisions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboEstado;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        public System.Windows.Forms.Label LbTituloCombustible;
        private System.Windows.Forms.Button btnGuardarMarca;
        private System.Windows.Forms.TextBox txtNombreTransmision;
        private System.Windows.Forms.Label label5;
    }
}