
namespace CLASE05.Formularios.Articulo
{
    partial class Frm_ABM_Articulo
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
            this.lbl_pat_bus_articulo = new System.Windows.Forms.Label();
            this.txt_patron = new System.Windows.Forms.MaskedTextBox();
            this.rb_nombre_articulo = new System.Windows.Forms.RadioButton();
            this.rb_codigo_articulo = new System.Windows.Forms.RadioButton();
            this.txt_id_articulo = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rb_todo_articulo = new System.Windows.Forms.RadioButton();
            this.grid_articulo = new CLASE05.Clases.Grid01();
            this.btn_blan_patron = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_articulo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_blan_patron);
            this.groupBox1.Controls.Add(this.rb_todo_articulo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_id_articulo);
            this.groupBox1.Controls.Add(this.rb_codigo_articulo);
            this.groupBox1.Controls.Add(this.lbl_pat_bus_articulo);
            this.groupBox1.Controls.Add(this.txt_patron);
            this.groupBox1.Controls.Add(this.rb_nombre_articulo);
            this.groupBox1.Size = new System.Drawing.Size(645, 162);
            this.groupBox1.Controls.SetChildIndex(this.btn_buscar, 0);
            this.groupBox1.Controls.SetChildIndex(this.rb_nombre_articulo, 0);
            this.groupBox1.Controls.SetChildIndex(this.txt_patron, 0);
            this.groupBox1.Controls.SetChildIndex(this.lbl_pat_bus_articulo, 0);
            this.groupBox1.Controls.SetChildIndex(this.rb_codigo_articulo, 0);
            this.groupBox1.Controls.SetChildIndex(this.txt_id_articulo, 0);
            this.groupBox1.Controls.SetChildIndex(this.label2, 0);
            this.groupBox1.Controls.SetChildIndex(this.rb_todo_articulo, 0);
            this.groupBox1.Controls.SetChildIndex(this.btn_blan_patron, 0);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(554, 120);
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // btn_alta
            // 
            this.btn_alta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_alta.FlatAppearance.BorderSize = 0;
            this.btn_alta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_alta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_alta.Location = new System.Drawing.Point(489, 510);
            this.btn_alta.Click += new System.EventHandler(this.btn_alta_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_modificar.FlatAppearance.BorderSize = 0;
            this.btn_modificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_modificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_modificar.Location = new System.Drawing.Point(550, 510);
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_borrar
            // 
            this.btn_borrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_borrar.FlatAppearance.BorderSize = 0;
            this.btn_borrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_borrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_borrar.Location = new System.Drawing.Point(607, 507);
            this.btn_borrar.Click += new System.EventHandler(this.btn_borrar_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Size = new System.Drawing.Size(248, 31);
            this.label1.Text = "Consulta de Articulo";
            // 
            // btn_consultar
            // 
            this.btn_consultar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_consultar.FlatAppearance.BorderSize = 0;
            this.btn_consultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_consultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_consultar.Location = new System.Drawing.Point(427, 509);
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_cerrar.Location = new System.Drawing.Point(637, 1);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_minimizar.Location = new System.Drawing.Point(567, 1);
            // 
            // btn_maximizar
            // 
            this.btn_maximizar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_maximizar.Location = new System.Drawing.Point(602, 1);
            // 
            // lbl_pat_bus_articulo
            // 
            this.lbl_pat_bus_articulo.AutoSize = true;
            this.lbl_pat_bus_articulo.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pat_bus_articulo.Location = new System.Drawing.Point(18, 41);
            this.lbl_pat_bus_articulo.Name = "lbl_pat_bus_articulo";
            this.lbl_pat_bus_articulo.Size = new System.Drawing.Size(130, 17);
            this.lbl_pat_bus_articulo.TabIndex = 27;
            this.lbl_pat_bus_articulo.Text = "Patrón de Búsqueda";
            // 
            // txt_patron
            // 
            this.txt_patron.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txt_patron.Enabled = false;
            this.txt_patron.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_patron.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_patron.Location = new System.Drawing.Point(154, 38);
            this.txt_patron.Mask = "LLLLLLLLLLLLLLLLLLLL";
            this.txt_patron.Name = "txt_patron";
            this.txt_patron.Size = new System.Drawing.Size(129, 25);
            this.txt_patron.TabIndex = 26;
            this.txt_patron.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txt_patron_MaskInputRejected);
            // 
            // rb_nombre_articulo
            // 
            this.rb_nombre_articulo.AutoSize = true;
            this.rb_nombre_articulo.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.rb_nombre_articulo.Location = new System.Drawing.Point(357, 37);
            this.rb_nombre_articulo.Name = "rb_nombre_articulo";
            this.rb_nombre_articulo.Size = new System.Drawing.Size(74, 21);
            this.rb_nombre_articulo.TabIndex = 25;
            this.rb_nombre_articulo.TabStop = true;
            this.rb_nombre_articulo.Text = "nombre";
            this.rb_nombre_articulo.UseVisualStyleBackColor = true;
            this.rb_nombre_articulo.CheckedChanged += new System.EventHandler(this.rb_nombre_articulo_CheckedChanged);
            // 
            // rb_codigo_articulo
            // 
            this.rb_codigo_articulo.AutoSize = true;
            this.rb_codigo_articulo.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.rb_codigo_articulo.Location = new System.Drawing.Point(357, 64);
            this.rb_codigo_articulo.Name = "rb_codigo_articulo";
            this.rb_codigo_articulo.Size = new System.Drawing.Size(120, 21);
            this.rb_codigo_articulo.TabIndex = 30;
            this.rb_codigo_articulo.TabStop = true;
            this.rb_codigo_articulo.Text = "codigo articulo";
            this.rb_codigo_articulo.UseVisualStyleBackColor = true;
            this.rb_codigo_articulo.CheckedChanged += new System.EventHandler(this.rb_codigo_articulo_CheckedChanged);
            // 
            // txt_id_articulo
            // 
            this.txt_id_articulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txt_id_articulo.Enabled = false;
            this.txt_id_articulo.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_articulo.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.txt_id_articulo.Location = new System.Drawing.Point(154, 70);
            this.txt_id_articulo.Mask = "99999";
            this.txt_id_articulo.Name = "txt_id_articulo";
            this.txt_id_articulo.Size = new System.Drawing.Size(48, 25);
            this.txt_id_articulo.TabIndex = 32;
            this.txt_id_articulo.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txt_id_articulo_MaskInputRejected);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 33;
            this.label2.Text = "Codigo Articulo";
            // 
            // rb_todo_articulo
            // 
            this.rb_todo_articulo.AutoSize = true;
            this.rb_todo_articulo.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.rb_todo_articulo.Location = new System.Drawing.Point(357, 91);
            this.rb_todo_articulo.Name = "rb_todo_articulo";
            this.rb_todo_articulo.Size = new System.Drawing.Size(61, 21);
            this.rb_todo_articulo.TabIndex = 34;
            this.rb_todo_articulo.TabStop = true;
            this.rb_todo_articulo.Text = "todos";
            this.rb_todo_articulo.UseVisualStyleBackColor = true;
            this.rb_todo_articulo.CheckedChanged += new System.EventHandler(this.rb_todo_articulo_CheckedChanged);
            // 
            // grid_articulo
            // 
            this.grid_articulo._formatoLetraHeader = System.Drawing.FontStyle.Regular;
            this.grid_articulo._tamannoLetraHeader = 9;
            this.grid_articulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_articulo.Location = new System.Drawing.Point(12, 249);
            this.grid_articulo.Name = "grid_articulo";
            this.grid_articulo.Size = new System.Drawing.Size(645, 150);
            this.grid_articulo.TabIndex = 6;
            // 
            // btn_blan_patron
            // 
            this.btn_blan_patron.BackColor = System.Drawing.Color.Transparent;
            this.btn_blan_patron.BackgroundImage = global::CLASE05.Properties.Resources.btn_eliminar__7_;
            this.btn_blan_patron.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_blan_patron.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_blan_patron.FlatAppearance.BorderSize = 0;
            this.btn_blan_patron.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_blan_patron.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_blan_patron.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_blan_patron.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_blan_patron.Location = new System.Drawing.Point(286, 38);
            this.btn_blan_patron.Name = "btn_blan_patron";
            this.btn_blan_patron.Size = new System.Drawing.Size(36, 35);
            this.btn_blan_patron.TabIndex = 35;
            this.btn_blan_patron.TabStop = false;
            this.btn_blan_patron.UseVisualStyleBackColor = false;
            this.btn_blan_patron.Click += new System.EventHandler(this.btn_blan_patron_Click_1);
            // 
            // Frm_ABM_Articulo
            // 
            this._PosiciónVisible = true;
            this._titulo = "Consulta de Articulo";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 576);
            this.Controls.Add(this.grid_articulo);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Frm_ABM_Articulo";
            this.Text = "Frm_ABM_Articulo";
            this.Load += new System.EventHandler(this.Frm_ABM_Articulo_Load);
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
            this.Controls.SetChildIndex(this.grid_articulo, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_articulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_pat_bus_articulo;
        private System.Windows.Forms.MaskedTextBox txt_patron;
        private System.Windows.Forms.RadioButton rb_nombre_articulo;
        private System.Windows.Forms.RadioButton rb_codigo_articulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txt_id_articulo;
        private System.Windows.Forms.RadioButton rb_todo_articulo;
        private Clases.Grid01 grid_articulo;
        private System.Windows.Forms.Button btn_blan_patron;
    }
}