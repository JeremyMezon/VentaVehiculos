namespace VentaVehiculos.Pantallas_de_Mantenimiento
{
    partial class Venta
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
            this.btnActualizarTablaVenta = new System.Windows.Forms.Button();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.btnBorrarVenta = new System.Windows.Forms.Button();
            this.btnModificarVenta = new System.Windows.Forms.Button();
            this.btnNuevaVenta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataVenta = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuCards1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // btnActualizarTablaVenta
            // 
            this.btnActualizarTablaVenta.BackColor = System.Drawing.Color.AliceBlue;
            this.btnActualizarTablaVenta.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnActualizarTablaVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarTablaVenta.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarTablaVenta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnActualizarTablaVenta.Location = new System.Drawing.Point(546, 93);
            this.btnActualizarTablaVenta.Name = "btnActualizarTablaVenta";
            this.btnActualizarTablaVenta.Size = new System.Drawing.Size(174, 35);
            this.btnActualizarTablaVenta.TabIndex = 21;
            this.btnActualizarTablaVenta.Text = "Actualizar Datos";
            this.btnActualizarTablaVenta.UseVisualStyleBackColor = false;
            this.btnActualizarTablaVenta.Click += new System.EventHandler(this.btnActualizarTablaVenta_Click);
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.DarkTurquoise;
            this.bunifuCards1.Controls.Add(this.btnBorrarVenta);
            this.bunifuCards1.Controls.Add(this.btnModificarVenta);
            this.bunifuCards1.Controls.Add(this.btnNuevaVenta);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(29, 63);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(381, 88);
            this.bunifuCards1.TabIndex = 20;
            // 
            // btnBorrarVenta
            // 
            this.btnBorrarVenta.BackColor = System.Drawing.Color.White;
            this.btnBorrarVenta.FlatAppearance.BorderSize = 0;
            this.btnBorrarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarVenta.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnBorrarVenta.Location = new System.Drawing.Point(258, 29);
            this.btnBorrarVenta.Name = "btnBorrarVenta";
            this.btnBorrarVenta.Size = new System.Drawing.Size(99, 35);
            this.btnBorrarVenta.TabIndex = 4;
            this.btnBorrarVenta.Text = "Eliminar";
            this.btnBorrarVenta.UseVisualStyleBackColor = false;
            // 
            // btnModificarVenta
            // 
            this.btnModificarVenta.BackColor = System.Drawing.Color.AliceBlue;
            this.btnModificarVenta.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnModificarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarVenta.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarVenta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnModificarVenta.Location = new System.Drawing.Point(140, 29);
            this.btnModificarVenta.Name = "btnModificarVenta";
            this.btnModificarVenta.Size = new System.Drawing.Size(99, 35);
            this.btnModificarVenta.TabIndex = 3;
            this.btnModificarVenta.Text = "Modificar";
            this.btnModificarVenta.UseVisualStyleBackColor = false;
            // 
            // btnNuevaVenta
            // 
            this.btnNuevaVenta.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnNuevaVenta.FlatAppearance.BorderSize = 0;
            this.btnNuevaVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaVenta.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaVenta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevaVenta.Location = new System.Drawing.Point(24, 29);
            this.btnNuevaVenta.Name = "btnNuevaVenta";
            this.btnNuevaVenta.Size = new System.Drawing.Size(99, 35);
            this.btnNuevaVenta.TabIndex = 2;
            this.btnNuevaVenta.Text = "Nueva Venta";
            this.btnNuevaVenta.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 34);
            this.label1.TabIndex = 19;
            this.label1.Text = "Venta de Vehiculo";
            // 
            // dataVenta
            // 
            this.dataVenta.AllowUserToAddRows = false;
            this.dataVenta.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataVenta.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataVenta.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataVenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataVenta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataVenta.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataVenta.DoubleBuffered = true;
            this.dataVenta.EnableHeadersVisualStyles = false;
            this.dataVenta.HeaderBgColor = System.Drawing.Color.DeepSkyBlue;
            this.dataVenta.HeaderForeColor = System.Drawing.Color.Black;
            this.dataVenta.Location = new System.Drawing.Point(0, 197);
            this.dataVenta.MultiSelect = false;
            this.dataVenta.Name = "dataVenta";
            this.dataVenta.ReadOnly = true;
            this.dataVenta.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataVenta.Size = new System.Drawing.Size(800, 253);
            this.dataVenta.TabIndex = 18;
            // 
            // Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnActualizarTablaVenta);
            this.Controls.Add(this.bunifuCards1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataVenta);
            this.Name = "Venta";
            this.Text = "Venta";
            this.bunifuCards1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnActualizarTablaVenta;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private System.Windows.Forms.Button btnBorrarVenta;
        private System.Windows.Forms.Button btnModificarVenta;
        private System.Windows.Forms.Button btnNuevaVenta;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dataVenta;
    }
}