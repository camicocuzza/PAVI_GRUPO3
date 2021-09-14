
namespace CLASE05.Formularios.Lotes
{
    partial class Frm_ABM_Lotes
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
            this.grid_consulta = new System.Windows.Forms.DataGridView();
            this.rb_numero_lote = new System.Windows.Forms.RadioButton();
            this.rb_nro_remito_proveedor = new System.Windows.Forms.RadioButton();
            this.lbl_patron_busqueda = new System.Windows.Forms.Label();
            this.txt_patron = new System.Windows.Forms.MaskedTextBox();
            this.rb_nombre = new System.Windows.Forms.RadioButton();
            this.rb_fecha_compra = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_consulta)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_fecha_compra);
            this.groupBox1.Controls.Add(this.rb_nombre);
            this.groupBox1.Controls.Add(this.lbl_patron_busqueda);
            this.groupBox1.Controls.Add(this.txt_patron);
            this.groupBox1.Controls.Add(this.rb_nro_remito_proveedor);
            this.groupBox1.Controls.Add(this.rb_numero_lote);
            this.groupBox1.Size = new System.Drawing.Size(645, 130);
            this.groupBox1.Controls.SetChildIndex(this.rb_numero_lote, 0);
            this.groupBox1.Controls.SetChildIndex(this.rb_nro_remito_proveedor, 0);
            this.groupBox1.Controls.SetChildIndex(this.txt_patron, 0);
            this.groupBox1.Controls.SetChildIndex(this.lbl_patron_busqueda, 0);
            this.groupBox1.Controls.SetChildIndex(this.btn_buscar, 0);
            this.groupBox1.Controls.SetChildIndex(this.rb_nombre, 0);
            this.groupBox1.Controls.SetChildIndex(this.rb_fecha_compra, 0);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(554, 94);
            // 
            // btn_alta
            // 
            this.btn_alta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_alta.FlatAppearance.BorderSize = 0;
            this.btn_alta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_alta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_alta.Location = new System.Drawing.Point(505, 404);
            this.btn_alta.Click += new System.EventHandler(this.btn_alta_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_modificar.FlatAppearance.BorderSize = 0;
            this.btn_modificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_modificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_modificar.Location = new System.Drawing.Point(556, 404);
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_borrar
            // 
            this.btn_borrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_borrar.FlatAppearance.BorderSize = 0;
            this.btn_borrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_borrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_borrar.Location = new System.Drawing.Point(607, 404);
            this.btn_borrar.Click += new System.EventHandler(this.btn_borrar_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(15, 47);
            this.label1.Size = new System.Drawing.Size(208, 31);
            this.label1.Text = "Consulta de Lote";
            // 
            // btn_consultar
            // 
            this.btn_consultar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_consultar.FlatAppearance.BorderSize = 0;
            this.btn_consultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_consultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_consultar.Location = new System.Drawing.Point(452, 402);
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_cerrar.Location = new System.Drawing.Point(649, 1);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_minimizar.Location = new System.Drawing.Point(579, 1);
            // 
            // btn_maximizar
            // 
            this.btn_maximizar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_maximizar.Location = new System.Drawing.Point(614, 1);
            // 
            // grid_consulta
            // 
            this.grid_consulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_consulta.Location = new System.Drawing.Point(10, 217);
            this.grid_consulta.Name = "grid_consulta";
            this.grid_consulta.Size = new System.Drawing.Size(647, 181);
            this.grid_consulta.TabIndex = 6;
            // 
            // rb_numero_lote
            // 
            this.rb_numero_lote.AutoSize = true;
            this.rb_numero_lote.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.rb_numero_lote.Location = new System.Drawing.Point(301, 18);
            this.rb_numero_lote.Name = "rb_numero_lote";
            this.rb_numero_lote.Size = new System.Drawing.Size(122, 21);
            this.rb_numero_lote.TabIndex = 13;
            this.rb_numero_lote.TabStop = true;
            this.rb_numero_lote.Text = "numero de Lote";
            this.rb_numero_lote.UseVisualStyleBackColor = true;
            // 
            // rb_nro_remito_proveedor
            // 
            this.rb_nro_remito_proveedor.AutoSize = true;
            this.rb_nro_remito_proveedor.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.rb_nro_remito_proveedor.Location = new System.Drawing.Point(301, 45);
            this.rb_nro_remito_proveedor.Name = "rb_nro_remito_proveedor";
            this.rb_nro_remito_proveedor.Size = new System.Drawing.Size(163, 21);
            this.rb_nro_remito_proveedor.TabIndex = 18;
            this.rb_nro_remito_proveedor.TabStop = true;
            this.rb_nro_remito_proveedor.Text = "nro_remito_proveedor";
            this.rb_nro_remito_proveedor.UseVisualStyleBackColor = true;
            // 
            // lbl_patron_busqueda
            // 
            this.lbl_patron_busqueda.AutoSize = true;
            this.lbl_patron_busqueda.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_patron_busqueda.Location = new System.Drawing.Point(6, 52);
            this.lbl_patron_busqueda.Name = "lbl_patron_busqueda";
            this.lbl_patron_busqueda.Size = new System.Drawing.Size(130, 17);
            this.lbl_patron_busqueda.TabIndex = 21;
            this.lbl_patron_busqueda.Text = "Patrón de Búsqueda";
            // 
            // txt_patron
            // 
            this.txt_patron.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txt_patron.Enabled = false;
            this.txt_patron.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_patron.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_patron.Location = new System.Drawing.Point(142, 49);
            this.txt_patron.Mask = "LLLLLLLLLLLLLLLLLLLL";
            this.txt_patron.Name = "txt_patron";
            this.txt_patron.Size = new System.Drawing.Size(129, 25);
            this.txt_patron.TabIndex = 20;
            // 
            // rb_nombre
            // 
            this.rb_nombre.AutoSize = true;
            this.rb_nombre.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.rb_nombre.Location = new System.Drawing.Point(301, 72);
            this.rb_nombre.Name = "rb_nombre";
            this.rb_nombre.Size = new System.Drawing.Size(74, 21);
            this.rb_nombre.TabIndex = 22;
            this.rb_nombre.TabStop = true;
            this.rb_nombre.Text = "nombre";
            this.rb_nombre.UseVisualStyleBackColor = true;
            // 
            // rb_fecha_compra
            // 
            this.rb_fecha_compra.AutoSize = true;
            this.rb_fecha_compra.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.rb_fecha_compra.Location = new System.Drawing.Point(301, 99);
            this.rb_fecha_compra.Name = "rb_fecha_compra";
            this.rb_fecha_compra.Size = new System.Drawing.Size(113, 21);
            this.rb_fecha_compra.TabIndex = 23;
            this.rb_fecha_compra.TabStop = true;
            this.rb_fecha_compra.Text = "fecha_compra";
            this.rb_fecha_compra.UseVisualStyleBackColor = true;
            // 
            // Frm_ABM_Lotes
            // 
            this._PosiciónVisible = true;
            this._titulo = "Consulta de Lote";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 453);
            this.Controls.Add(this.grid_consulta);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Frm_ABM_Lotes";
            this.Text = "Frm_ABM_Lotes";
            this.Controls.SetChildIndex(this.grid_consulta, 0);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_consulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_consulta;
        private System.Windows.Forms.RadioButton rb_numero_lote;
        private System.Windows.Forms.RadioButton rb_nro_remito_proveedor;
        private System.Windows.Forms.Label lbl_patron_busqueda;
        private System.Windows.Forms.MaskedTextBox txt_patron;
        private System.Windows.Forms.RadioButton rb_fecha_compra;
        private System.Windows.Forms.RadioButton rb_nombre;
    }
}