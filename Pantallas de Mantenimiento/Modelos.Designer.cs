namespace VentaVehiculos.Pantallas_de_Mantenimiento
{
    partial class Modelos
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
            this.btnActualizarTablaModelos = new System.Windows.Forms.Button();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.btnBorrarModelo = new System.Windows.Forms.Button();
            this.btnModificarModelo = new System.Windows.Forms.Button();
            this.btnNuevoModelo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataModelos = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuCards1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataModelos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnActualizarTablaModelos
            // 
            this.btnActualizarTablaModelos.BackColor = System.Drawing.Color.AliceBlue;
            this.btnActualizarTablaModelos.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnActualizarTablaModelos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarTablaModelos.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarTablaModelos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnActualizarTablaModelos.Location = new System.Drawing.Point(546, 101);
            this.btnActualizarTablaModelos.Name = "btnActualizarTablaModelos";
            this.btnActualizarTablaModelos.Size = new System.Drawing.Size(174, 35);
            this.btnActualizarTablaModelos.TabIndex = 9;
            this.btnActualizarTablaModelos.Text = "Actualizar Datos";
            this.btnActualizarTablaModelos.UseVisualStyleBackColor = false;
            this.btnActualizarTablaModelos.Click += new System.EventHandler(this.btnActualizarTablaModelos_Click);
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.DarkTurquoise;
            this.bunifuCards1.Controls.Add(this.btnBorrarModelo);
            this.bunifuCards1.Controls.Add(this.btnModificarModelo);
            this.bunifuCards1.Controls.Add(this.btnNuevoModelo);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(29, 71);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(381, 88);
            this.bunifuCards1.TabIndex = 8;
            // 
            // btnBorrarModelo
            // 
            this.btnBorrarModelo.BackColor = System.Drawing.Color.White;
            this.btnBorrarModelo.FlatAppearance.BorderSize = 0;
            this.btnBorrarModelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarModelo.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnBorrarModelo.Location = new System.Drawing.Point(258, 29);
            this.btnBorrarModelo.Name = "btnBorrarModelo";
            this.btnBorrarModelo.Size = new System.Drawing.Size(99, 35);
            this.btnBorrarModelo.TabIndex = 4;
            this.btnBorrarModelo.Text = "Eliminar";
            this.btnBorrarModelo.UseVisualStyleBackColor = false;
            // 
            // btnModificarModelo
            // 
            this.btnModificarModelo.BackColor = System.Drawing.Color.AliceBlue;
            this.btnModificarModelo.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnModificarModelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarModelo.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarModelo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnModificarModelo.Location = new System.Drawing.Point(140, 29);
            this.btnModificarModelo.Name = "btnModificarModelo";
            this.btnModificarModelo.Size = new System.Drawing.Size(99, 35);
            this.btnModificarModelo.TabIndex = 3;
            this.btnModificarModelo.Text = "Modificar";
            this.btnModificarModelo.UseVisualStyleBackColor = false;
            // 
            // btnNuevoModelo
            // 
            this.btnNuevoModelo.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnNuevoModelo.FlatAppearance.BorderSize = 0;
            this.btnNuevoModelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoModelo.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoModelo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevoModelo.Location = new System.Drawing.Point(24, 29);
            this.btnNuevoModelo.Name = "btnNuevoModelo";
            this.btnNuevoModelo.Size = new System.Drawing.Size(99, 35);
            this.btnNuevoModelo.TabIndex = 2;
            this.btnNuevoModelo.Text = "Nuevo Modelo";
            this.btnNuevoModelo.UseVisualStyleBackColor = false;
            this.btnNuevoModelo.Click += new System.EventHandler(this.btnNuevoModelo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 34);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mantenimiento de Modelos";
            // 
            // dataModelos
            // 
            this.dataModelos.AllowUserToAddRows = false;
            this.dataModelos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataModelos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataModelos.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataModelos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataModelos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataModelos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataModelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataModelos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataModelos.DoubleBuffered = true;
            this.dataModelos.EnableHeadersVisualStyles = false;
            this.dataModelos.HeaderBgColor = System.Drawing.Color.DeepSkyBlue;
            this.dataModelos.HeaderForeColor = System.Drawing.Color.Black;
            this.dataModelos.Location = new System.Drawing.Point(0, 197);
            this.dataModelos.MultiSelect = false;
            this.dataModelos.Name = "dataModelos";
            this.dataModelos.ReadOnly = true;
            this.dataModelos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataModelos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataModelos.Size = new System.Drawing.Size(800, 253);
            this.dataModelos.TabIndex = 6;
            // 
            // Modelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnActualizarTablaModelos);
            this.Controls.Add(this.bunifuCards1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataModelos);
            this.Name = "Modelos";
            this.Text = "Modelos";
            this.Load += new System.EventHandler(this.Modelos_Load);
            this.bunifuCards1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataModelos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnActualizarTablaModelos;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private System.Windows.Forms.Button btnBorrarModelo;
        private System.Windows.Forms.Button btnModificarModelo;
        private System.Windows.Forms.Button btnNuevoModelo;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dataModelos;
    }
}