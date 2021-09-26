
namespace CLASE05.Formularios.Proveedor
{
    partial class Frm_ABM_Proveedor
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
            this.rb_razon_social = new System.Windows.Forms.RadioButton();
            this.rb_id_proveedor = new System.Windows.Forms.RadioButton();
            this.rb_cuit = new System.Windows.Forms.RadioButton();
            this.rb_fecha_inicio_operacion = new System.Windows.Forms.RadioButton();
            this.rb_id_comprador = new System.Windows.Forms.RadioButton();
            this.rb_id_domicilio = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_patron = new System.Windows.Forms.MaskedTextBox();
            this.grid_consulta_proveedor = new CLASE05.Clases.Grid01();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_consulta_proveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_patron);
            this.groupBox1.Controls.Add(this.rb_id_domicilio);
            this.groupBox1.Controls.Add(this.rb_id_comprador);
            this.groupBox1.Controls.Add(this.rb_fecha_inicio_operacion);
            this.groupBox1.Controls.Add(this.rb_cuit);
            this.groupBox1.Controls.Add(this.rb_id_proveedor);
            this.groupBox1.Controls.Add(this.rb_razon_social);
            this.groupBox1.Size = new System.Drawing.Size(645, 156);
            this.groupBox1.Controls.SetChildIndex(this.btn_buscar, 0);
            this.groupBox1.Controls.SetChildIndex(this.rb_razon_social, 0);
            this.groupBox1.Controls.SetChildIndex(this.rb_id_proveedor, 0);
            this.groupBox1.Controls.SetChildIndex(this.rb_cuit, 0);
            this.groupBox1.Controls.SetChildIndex(this.rb_fecha_inicio_operacion, 0);
            this.groupBox1.Controls.SetChildIndex(this.rb_id_comprador, 0);
            this.groupBox1.Controls.SetChildIndex(this.rb_id_domicilio, 0);
            this.groupBox1.Controls.SetChildIndex(this.txt_patron, 0);
            this.groupBox1.Controls.SetChildIndex(this.label2, 0);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(554, 120);
            // 
            // btn_alta
            // 
            this.btn_alta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_alta.FlatAppearance.BorderSize = 0;
            this.btn_alta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_alta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_alta.Location = new System.Drawing.Point(489, 458);
            this.btn_alta.Click += new System.EventHandler(this.btn_alta_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_modificar.FlatAppearance.BorderSize = 0;
            this.btn_modificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_modificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_modificar.Location = new System.Drawing.Point(550, 458);
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_borrar
            // 
            this.btn_borrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_borrar.FlatAppearance.BorderSize = 0;
            this.btn_borrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_borrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_borrar.Location = new System.Drawing.Point(607, 455);
            this.btn_borrar.Click += new System.EventHandler(this.btn_borrar_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Size = new System.Drawing.Size(266, 31);
            this.label1.Text = "Consulta Proveedores";
            // 
            // btn_consultar
            // 
            this.btn_consultar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_consultar.FlatAppearance.BorderSize = 0;
            this.btn_consultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_consultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_consultar.Location = new System.Drawing.Point(427, 457);
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_cerrar.Location = new System.Drawing.Point(634, 2);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_minimizar.Location = new System.Drawing.Point(564, 2);
            // 
            // btn_maximizar
            // 
            this.btn_maximizar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_maximizar.Location = new System.Drawing.Point(599, 2);
            // 
            // rb_razon_social
            // 
            this.rb_razon_social.AutoSize = true;
            this.rb_razon_social.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.rb_razon_social.Location = new System.Drawing.Point(298, 89);
            this.rb_razon_social.Name = "rb_razon_social";
            this.rb_razon_social.Size = new System.Drawing.Size(102, 21);
            this.rb_razon_social.TabIndex = 14;
            this.rb_razon_social.TabStop = true;
            this.rb_razon_social.Text = "razon_social";
            this.rb_razon_social.UseVisualStyleBackColor = true;
            // 
            // rb_id_proveedor
            // 
            this.rb_id_proveedor.AutoSize = true;
            this.rb_id_proveedor.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.rb_id_proveedor.Location = new System.Drawing.Point(298, 37);
            this.rb_id_proveedor.Name = "rb_id_proveedor";
            this.rb_id_proveedor.Size = new System.Drawing.Size(107, 21);
            this.rb_id_proveedor.TabIndex = 15;
            this.rb_id_proveedor.TabStop = true;
            this.rb_id_proveedor.Text = "id_proveedor";
            this.rb_id_proveedor.UseVisualStyleBackColor = true;
            // 
            // rb_cuit
            // 
            this.rb_cuit.AutoSize = true;
            this.rb_cuit.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.rb_cuit.Location = new System.Drawing.Point(298, 62);
            this.rb_cuit.Name = "rb_cuit";
            this.rb_cuit.Size = new System.Drawing.Size(50, 21);
            this.rb_cuit.TabIndex = 16;
            this.rb_cuit.TabStop = true;
            this.rb_cuit.Text = "cuit";
            this.rb_cuit.UseVisualStyleBackColor = true;
            // 
            // rb_fecha_inicio_operacion
            // 
            this.rb_fecha_inicio_operacion.AutoSize = true;
            this.rb_fecha_inicio_operacion.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.rb_fecha_inicio_operacion.Location = new System.Drawing.Point(413, 62);
            this.rb_fecha_inicio_operacion.Name = "rb_fecha_inicio_operacion";
            this.rb_fecha_inicio_operacion.Size = new System.Drawing.Size(169, 21);
            this.rb_fecha_inicio_operacion.TabIndex = 17;
            this.rb_fecha_inicio_operacion.TabStop = true;
            this.rb_fecha_inicio_operacion.Text = "fecha_inicio_operacion";
            this.rb_fecha_inicio_operacion.UseVisualStyleBackColor = true;
            // 
            // rb_id_comprador
            // 
            this.rb_id_comprador.AutoSize = true;
            this.rb_id_comprador.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.rb_id_comprador.Location = new System.Drawing.Point(413, 89);
            this.rb_id_comprador.Name = "rb_id_comprador";
            this.rb_id_comprador.Size = new System.Drawing.Size(112, 21);
            this.rb_id_comprador.TabIndex = 18;
            this.rb_id_comprador.TabStop = true;
            this.rb_id_comprador.Text = "id_comprador";
            this.rb_id_comprador.UseVisualStyleBackColor = true;
            // 
            // rb_id_domicilio
            // 
            this.rb_id_domicilio.AutoSize = true;
            this.rb_id_domicilio.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.rb_id_domicilio.Location = new System.Drawing.Point(413, 36);
            this.rb_id_domicilio.Name = "rb_id_domicilio";
            this.rb_id_domicilio.Size = new System.Drawing.Size(103, 21);
            this.rb_id_domicilio.TabIndex = 19;
            this.rb_id_domicilio.TabStop = true;
            this.rb_id_domicilio.Text = "id_domicilio";
            this.rb_id_domicilio.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Patrón de Búsqueda";
            // 
            // txt_patron
            // 
            this.txt_patron.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txt_patron.Enabled = false;
            this.txt_patron.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_patron.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_patron.Location = new System.Drawing.Point(142, 37);
            this.txt_patron.Mask = "LLLLLLLLLLLLLLLLLLLL";
            this.txt_patron.Name = "txt_patron";
            this.txt_patron.Size = new System.Drawing.Size(129, 25);
            this.txt_patron.TabIndex = 22;
            // 
            // grid_consulta_proveedor
            // 
            this.grid_consulta_proveedor._formatoLetraHeader = System.Drawing.FontStyle.Regular;
            this.grid_consulta_proveedor._tamannoLetraHeader = 9;
            this.grid_consulta_proveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_consulta_proveedor.Location = new System.Drawing.Point(12, 243);
            this.grid_consulta_proveedor.Name = "grid_consulta_proveedor";
            this.grid_consulta_proveedor.Size = new System.Drawing.Size(645, 150);
            this.grid_consulta_proveedor.TabIndex = 6;
            // 
            // Frm_ABM_Proveedor
            // 
            this._PosiciónVisible = true;
            this._titulo = "Consulta Proveedores";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 521);
            this.Controls.Add(this.grid_consulta_proveedor);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Frm_ABM_Proveedor";
            this.Text = "Frm_ABM_Proveedor";
            this.Load += new System.EventHandler(this.Frm_ABM_Proveedor_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.btn_alta, 0);
            this.Controls.SetChildIndex(this.btn_modificar, 0);
            this.Controls.SetChildIndex(this.btn_borrar, 0);
            this.Controls.SetChildIndex(this.btn_consultar, 0);
            this.Controls.SetChildIndex(this.lbl_posicion, 0);
            this.Controls.SetChildIndex(this.btn_cerrar, 0);
            this.Controls.SetChildIndex(this.btn_maximizar, 0);
            this.Controls.SetChildIndex(this.btn_minimizar, 0);
            this.Controls.SetChildIndex(this.grid_consulta_proveedor, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_consulta_proveedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rb_id_domicilio;
        private System.Windows.Forms.RadioButton rb_id_comprador;
        private System.Windows.Forms.RadioButton rb_fecha_inicio_operacion;
        private System.Windows.Forms.RadioButton rb_cuit;
        private System.Windows.Forms.RadioButton rb_id_proveedor;
        private System.Windows.Forms.RadioButton rb_razon_social;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txt_patron;
        private Clases.Grid01 grid_consulta_proveedor;
    }
}