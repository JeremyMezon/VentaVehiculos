namespace VentaVehiculos.Pantallas_de_Mantenimiento
{
    partial class Clientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataClientes = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNuevoCliente = new System.Windows.Forms.Button();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.btnBorrarCliente = new System.Windows.Forms.Button();
            this.btnModificarCliente = new System.Windows.Forms.Button();
            this.btnActualizarClientes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataClientes)).BeginInit();
            this.bunifuCards1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataClientes
            // 
            this.dataClientes.AllowUserToAddRows = false;
            this.dataClientes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataClientes.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataClientes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataClientes.DoubleBuffered = true;
            this.dataClientes.EnableHeadersVisualStyles = false;
            this.dataClientes.HeaderBgColor = System.Drawing.Color.DeepSkyBlue;
            this.dataClientes.HeaderForeColor = System.Drawing.Color.Black;
            this.dataClientes.Location = new System.Drawing.Point(0, 197);
            this.dataClientes.MultiSelect = false;
            this.dataClientes.Name = "dataClientes";
            this.dataClientes.ReadOnly = true;
            this.dataClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataClientes.Size = new System.Drawing.Size(800, 253);
            this.dataClientes.TabIndex = 0;
            this.dataClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataClientes_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mantenimiento de Clientes";
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnNuevoCliente.FlatAppearance.BorderSize = 0;
            this.btnNuevoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoCliente.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevoCliente.Location = new System.Drawing.Point(24, 29);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Size = new System.Drawing.Size(99, 35);
            this.btnNuevoCliente.TabIndex = 2;
            this.btnNuevoCliente.Text = "Nuevo Cliente";
            this.btnNuevoCliente.UseVisualStyleBackColor = false;
            this.btnNuevoCliente.Click += new System.EventHandler(this.btnNuevoCliente_Click);
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.DarkTurquoise;
            this.bunifuCards1.Controls.Add(this.btnBorrarCliente);
            this.bunifuCards1.Controls.Add(this.btnModificarCliente);
            this.bunifuCards1.Controls.Add(this.btnNuevoCliente);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(29, 81);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(381, 88);
            this.bunifuCards1.TabIndex = 3;
            // 
            // btnBorrarCliente
            // 
            this.btnBorrarCliente.BackColor = System.Drawing.Color.White;
            this.btnBorrarCliente.FlatAppearance.BorderSize = 0;
            this.btnBorrarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarCliente.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnBorrarCliente.Location = new System.Drawing.Point(258, 29);
            this.btnBorrarCliente.Name = "btnBorrarCliente";
            this.btnBorrarCliente.Size = new System.Drawing.Size(99, 35);
            this.btnBorrarCliente.TabIndex = 4;
            this.btnBorrarCliente.Text = "Eliminar";
            this.btnBorrarCliente.UseVisualStyleBackColor = false;
            this.btnBorrarCliente.Click += new System.EventHandler(this.btnBorrarCliente_Click);
            // 
            // btnModificarCliente
            // 
            this.btnModificarCliente.BackColor = System.Drawing.Color.AliceBlue;
            this.btnModificarCliente.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnModificarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarCliente.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarCliente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnModificarCliente.Location = new System.Drawing.Point(140, 29);
            this.btnModificarCliente.Name = "btnModificarCliente";
            this.btnModificarCliente.Size = new System.Drawing.Size(99, 35);
            this.btnModificarCliente.TabIndex = 3;
            this.btnModificarCliente.Text = "Modificar";
            this.btnModificarCliente.UseVisualStyleBackColor = false;
            this.btnModificarCliente.Click += new System.EventHandler(this.btnModificarCliente_Click);
            // 
            // btnActualizarClientes
            // 
            this.btnActualizarClientes.BackColor = System.Drawing.Color.AliceBlue;
            this.btnActualizarClientes.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnActualizarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarClientes.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarClientes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnActualizarClientes.Location = new System.Drawing.Point(546, 111);
            this.btnActualizarClientes.Name = "btnActualizarClientes";
            this.btnActualizarClientes.Size = new System.Drawing.Size(174, 35);
            this.btnActualizarClientes.TabIndex = 5;
            this.btnActualizarClientes.Text = "Actualizar Datos";
            this.btnActualizarClientes.UseVisualStyleBackColor = false;
            this.btnActualizarClientes.Click += new System.EventHandler(this.btnActualizarClientes_Click);
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnActualizarClientes);
            this.Controls.Add(this.bunifuCards1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataClientes);
            this.Name = "Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataClientes)).EndInit();
            this.bunifuCards1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid dataClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNuevoCliente;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private System.Windows.Forms.Button btnBorrarCliente;
        private System.Windows.Forms.Button btnModificarCliente;
        private System.Windows.Forms.Button btnActualizarClientes;
    }
}