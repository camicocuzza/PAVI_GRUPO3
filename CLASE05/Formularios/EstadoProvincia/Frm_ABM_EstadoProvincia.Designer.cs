
namespace CLASE05.Formularios.EstadoProvincia
{
    partial class Frm_ABM_EstadoProvincia
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
            this.lbl_patron_busqueda = new System.Windows.Forms.Label();
            this.txt_patron = new System.Windows.Forms.MaskedTextBox();
            this.rb_estado = new System.Windows.Forms.RadioButton();
            this.rb_provincia = new System.Windows.Forms.RadioButton();
            this.rb_id_cliente = new System.Windows.Forms.RadioButton();
            this.grid_estado_provincia = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_estado_provincia)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_estado);
            this.groupBox1.Controls.Add(this.rb_provincia);
            this.groupBox1.Controls.Add(this.rb_id_cliente);
            this.groupBox1.Controls.Add(this.lbl_patron_busqueda);
            this.groupBox1.Controls.Add(this.txt_patron);
            this.groupBox1.Controls.SetChildIndex(this.txt_patron, 0);
            this.groupBox1.Controls.SetChildIndex(this.btn_buscar, 0);
            this.groupBox1.Controls.SetChildIndex(this.lbl_patron_busqueda, 0);
            this.groupBox1.Controls.SetChildIndex(this.rb_id_cliente, 0);
            this.groupBox1.Controls.SetChildIndex(this.rb_provincia, 0);
            this.groupBox1.Controls.SetChildIndex(this.rb_estado, 0);
            // 
            // btn_alta
            // 
            this.btn_alta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_alta.FlatAppearance.BorderSize = 0;
            this.btn_alta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_alta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_alta.Click += new System.EventHandler(this.btn_alta_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_modificar.FlatAppearance.BorderSize = 0;
            this.btn_modificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_modificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_borrar
            // 
            this.btn_borrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_borrar.FlatAppearance.BorderSize = 0;
            this.btn_borrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_borrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_borrar.Click += new System.EventHandler(this.btn_borrar_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 47);
            this.label1.Size = new System.Drawing.Size(310, 31);
            this.label1.Text = "Consulta Estado Provincia";
            // 
            // btn_consultar
            // 
            this.btn_consultar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_consultar.FlatAppearance.BorderSize = 0;
            this.btn_consultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_consultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_cerrar.Location = new System.Drawing.Point(636, 1);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_minimizar.Location = new System.Drawing.Point(566, 1);
            // 
            // btn_maximizar
            // 
            this.btn_maximizar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_maximizar.Location = new System.Drawing.Point(601, 1);
            // 
            // lbl_patron_busqueda
            // 
            this.lbl_patron_busqueda.AutoSize = true;
            this.lbl_patron_busqueda.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_patron_busqueda.Location = new System.Drawing.Point(4, 32);
            this.lbl_patron_busqueda.Name = "lbl_patron_busqueda";
            this.lbl_patron_busqueda.Size = new System.Drawing.Size(130, 17);
            this.lbl_patron_busqueda.TabIndex = 25;
            this.lbl_patron_busqueda.Text = "Patrón de Búsqueda";
            // 
            // txt_patron
            // 
            this.txt_patron.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txt_patron.Enabled = false;
            this.txt_patron.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_patron.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_patron.Location = new System.Drawing.Point(140, 29);
            this.txt_patron.Mask = "LLLLLLLLLLLLLLLLLLLL";
            this.txt_patron.Name = "txt_patron";
            this.txt_patron.Size = new System.Drawing.Size(129, 25);
            this.txt_patron.TabIndex = 24;
            // 
            // rb_estado
            // 
            this.rb_estado.AutoSize = true;
            this.rb_estado.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.rb_estado.Location = new System.Drawing.Point(302, 44);
            this.rb_estado.Name = "rb_estado";
            this.rb_estado.Size = new System.Drawing.Size(67, 21);
            this.rb_estado.TabIndex = 28;
            this.rb_estado.TabStop = true;
            this.rb_estado.Text = "estado";
            this.rb_estado.UseVisualStyleBackColor = true;
            // 
            // rb_provincia
            // 
            this.rb_provincia.AutoSize = true;
            this.rb_provincia.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.rb_provincia.Location = new System.Drawing.Point(302, 19);
            this.rb_provincia.Name = "rb_provincia";
            this.rb_provincia.Size = new System.Drawing.Size(84, 21);
            this.rb_provincia.TabIndex = 27;
            this.rb_provincia.TabStop = true;
            this.rb_provincia.Text = "provincia";
            this.rb_provincia.UseVisualStyleBackColor = true;
            // 
            // rb_id_cliente
            // 
            this.rb_id_cliente.AutoSize = true;
            this.rb_id_cliente.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.rb_id_cliente.Location = new System.Drawing.Point(302, 71);
            this.rb_id_cliente.Name = "rb_id_cliente";
            this.rb_id_cliente.Size = new System.Drawing.Size(86, 21);
            this.rb_id_cliente.TabIndex = 26;
            this.rb_id_cliente.TabStop = true;
            this.rb_id_cliente.Text = "id_cliente";
            this.rb_id_cliente.UseVisualStyleBackColor = true;
            // 
            // grid_estado_provincia
            // 
            this.grid_estado_provincia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_estado_provincia.Location = new System.Drawing.Point(10, 200);
            this.grid_estado_provincia.Name = "grid_estado_provincia";
            this.grid_estado_provincia.Size = new System.Drawing.Size(647, 154);
            this.grid_estado_provincia.TabIndex = 29;
            // 
            // Frm_ABM_EstadoProvincia
            // 
            this._PosiciónVisible = true;
            this._titulo = "Consulta Estado Provincia";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 521);
            this.Controls.Add(this.grid_estado_provincia);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Frm_ABM_EstadoProvincia";
            this.Text = "Frm_ABM_EstadoProvincia";
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
            this.Controls.SetChildIndex(this.grid_estado_provincia, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_estado_provincia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_patron_busqueda;
        private System.Windows.Forms.MaskedTextBox txt_patron;
        private System.Windows.Forms.RadioButton rb_estado;
        private System.Windows.Forms.RadioButton rb_provincia;
        private System.Windows.Forms.RadioButton rb_id_cliente;
        private System.Windows.Forms.DataGridView grid_estado_provincia;
    }
}