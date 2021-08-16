namespace VentaVehiculos.Pantallas_de_Mantenimiento
{
    partial class Vehiculos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.btnEliminarVehiculo = new System.Windows.Forms.Button();
            this.btnModificarVehiculo = new System.Windows.Forms.Button();
            this.btnNuevoVehiculo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataVehiculos = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuCards1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataVehiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.DarkTurquoise;
            this.bunifuCards1.Controls.Add(this.btnEliminarVehiculo);
            this.bunifuCards1.Controls.Add(this.btnModificarVehiculo);
            this.bunifuCards1.Controls.Add(this.btnNuevoVehiculo);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(29, 71);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(443, 88);
            this.bunifuCards1.TabIndex = 6;
            // 
            // btnEliminarVehiculo
            // 
            this.btnEliminarVehiculo.BackColor = System.Drawing.Color.White;
            this.btnEliminarVehiculo.FlatAppearance.BorderSize = 0;
            this.btnEliminarVehiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarVehiculo.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnEliminarVehiculo.Location = new System.Drawing.Point(303, 29);
            this.btnEliminarVehiculo.Name = "btnEliminarVehiculo";
            this.btnEliminarVehiculo.Size = new System.Drawing.Size(99, 35);
            this.btnEliminarVehiculo.TabIndex = 4;
            this.btnEliminarVehiculo.Text = "Eliminar";
            this.btnEliminarVehiculo.UseVisualStyleBackColor = false;
            // 
            // btnModificarVehiculo
            // 
            this.btnModificarVehiculo.BackColor = System.Drawing.Color.AliceBlue;
            this.btnModificarVehiculo.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnModificarVehiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarVehiculo.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarVehiculo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnModificarVehiculo.Location = new System.Drawing.Point(185, 29);
            this.btnModificarVehiculo.Name = "btnModificarVehiculo";
            this.btnModificarVehiculo.Size = new System.Drawing.Size(99, 35);
            this.btnModificarVehiculo.TabIndex = 3;
            this.btnModificarVehiculo.Text = "Modificar";
            this.btnModificarVehiculo.UseVisualStyleBackColor = false;
            // 
            // btnNuevoVehiculo
            // 
            this.btnNuevoVehiculo.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnNuevoVehiculo.FlatAppearance.BorderSize = 0;
            this.btnNuevoVehiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoVehiculo.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoVehiculo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevoVehiculo.Location = new System.Drawing.Point(24, 29);
            this.btnNuevoVehiculo.Name = "btnNuevoVehiculo";
            this.btnNuevoVehiculo.Size = new System.Drawing.Size(140, 35);
            this.btnNuevoVehiculo.TabIndex = 2;
            this.btnNuevoVehiculo.Text = "Nuevo Vehiculo";
            this.btnNuevoVehiculo.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 34);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mantenimiento de Vehiculos";
            // 
            // dataVehiculos
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataVehiculos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataVehiculos.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataVehiculos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataVehiculos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataVehiculos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataVehiculos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataVehiculos.DoubleBuffered = true;
            this.dataVehiculos.EnableHeadersVisualStyles = false;
            this.dataVehiculos.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dataVehiculos.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dataVehiculos.Location = new System.Drawing.Point(0, 197);
            this.dataVehiculos.Name = "dataVehiculos";
            this.dataVehiculos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataVehiculos.Size = new System.Drawing.Size(800, 253);
            this.dataVehiculos.TabIndex = 4;
            // 
            // Vehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bunifuCards1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataVehiculos);
            this.Name = "Vehiculos";
            this.Text = "Vehiculos";
            this.bunifuCards1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataVehiculos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private System.Windows.Forms.Button btnEliminarVehiculo;
        private System.Windows.Forms.Button btnModificarVehiculo;
        private System.Windows.Forms.Button btnNuevoVehiculo;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dataVehiculos;
    }
}