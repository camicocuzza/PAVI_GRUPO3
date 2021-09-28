
namespace CLASE05.Formularios.Stock
{
    partial class Frm_ABM_Stock
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
            this.grid011 = new CLASE05.Clases.Grid01();
            this.lbl_pat_bus_articulo = new System.Windows.Forms.Label();
            this.txt_patron = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_id_stock = new System.Windows.Forms.MaskedTextBox();
            this.rb_todo_stock = new System.Windows.Forms.RadioButton();
            this.rb_codigo_stock = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid011)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_todo_stock);
            this.groupBox1.Controls.Add(this.rb_codigo_stock);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_id_stock);
            this.groupBox1.Controls.Add(this.lbl_pat_bus_articulo);
            this.groupBox1.Controls.Add(this.txt_patron);
            this.groupBox1.Location = new System.Drawing.Point(12, 64);
            this.groupBox1.Size = new System.Drawing.Size(751, 130);
            this.groupBox1.Controls.SetChildIndex(this.txt_patron, 0);
            this.groupBox1.Controls.SetChildIndex(this.lbl_pat_bus_articulo, 0);
            this.groupBox1.Controls.SetChildIndex(this.txt_id_stock, 0);
            this.groupBox1.Controls.SetChildIndex(this.label2, 0);
            this.groupBox1.Controls.SetChildIndex(this.rb_codigo_stock, 0);
            this.groupBox1.Controls.SetChildIndex(this.rb_todo_stock, 0);
            this.groupBox1.Controls.SetChildIndex(this.btn_buscar, 0);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(660, 94);
            // 
            // btn_alta
            // 
            this.btn_alta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_alta.FlatAppearance.BorderSize = 0;
            this.btn_alta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_alta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_alta.Location = new System.Drawing.Point(598, 392);
            // 
            // btn_modificar
            // 
            this.btn_modificar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_modificar.FlatAppearance.BorderSize = 0;
            this.btn_modificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_modificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_modificar.Location = new System.Drawing.Point(659, 392);
            // 
            // btn_borrar
            // 
            this.btn_borrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_borrar.FlatAppearance.BorderSize = 0;
            this.btn_borrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_borrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_borrar.Location = new System.Drawing.Point(716, 389);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(27, 30);
            this.label1.Size = new System.Drawing.Size(184, 31);
            this.label1.Text = "Consulta Stock";
            // 
            // btn_consultar
            // 
            this.btn_consultar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_consultar.FlatAppearance.BorderSize = 0;
            this.btn_consultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_consultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_consultar.Location = new System.Drawing.Point(536, 391);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_cerrar.Location = new System.Drawing.Point(722, 2);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_minimizar.Location = new System.Drawing.Point(652, 2);
            // 
            // btn_maximizar
            // 
            this.btn_maximizar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_maximizar.Location = new System.Drawing.Point(687, 2);
            // 
            // grid011
            // 
            this.grid011._formatoLetraHeader = System.Drawing.FontStyle.Regular;
            this.grid011._tamannoLetraHeader = 9;
            this.grid011.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid011.Location = new System.Drawing.Point(12, 200);
            this.grid011.Name = "grid011";
            this.grid011.Size = new System.Drawing.Size(751, 168);
            this.grid011.TabIndex = 6;
            // 
            // lbl_pat_bus_articulo
            // 
            this.lbl_pat_bus_articulo.AutoSize = true;
            this.lbl_pat_bus_articulo.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pat_bus_articulo.Location = new System.Drawing.Point(69, 37);
            this.lbl_pat_bus_articulo.Name = "lbl_pat_bus_articulo";
            this.lbl_pat_bus_articulo.Size = new System.Drawing.Size(130, 17);
            this.lbl_pat_bus_articulo.TabIndex = 29;
            this.lbl_pat_bus_articulo.Text = "Patrón de Búsqueda";
            // 
            // txt_patron
            // 
            this.txt_patron.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txt_patron.Enabled = false;
            this.txt_patron.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_patron.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_patron.Location = new System.Drawing.Point(205, 29);
            this.txt_patron.Mask = "LLLLLLLLLLLLLLLLLLLL";
            this.txt_patron.Name = "txt_patron";
            this.txt_patron.Size = new System.Drawing.Size(129, 25);
            this.txt_patron.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 35;
            this.label2.Text = "Codigo Articulo";
            // 
            // txt_id_stock
            // 
            this.txt_id_stock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txt_id_stock.Enabled = false;
            this.txt_id_stock.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_stock.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.txt_id_stock.Location = new System.Drawing.Point(205, 70);
            this.txt_id_stock.Mask = "99999";
            this.txt_id_stock.Name = "txt_id_stock";
            this.txt_id_stock.Size = new System.Drawing.Size(48, 25);
            this.txt_id_stock.TabIndex = 34;
            // 
            // rb_todo_stock
            // 
            this.rb_todo_stock.AutoSize = true;
            this.rb_todo_stock.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.rb_todo_stock.Location = new System.Drawing.Point(506, 56);
            this.rb_todo_stock.Name = "rb_todo_stock";
            this.rb_todo_stock.Size = new System.Drawing.Size(61, 21);
            this.rb_todo_stock.TabIndex = 38;
            this.rb_todo_stock.TabStop = true;
            this.rb_todo_stock.Text = "todos";
            this.rb_todo_stock.UseVisualStyleBackColor = true;
            // 
            // rb_codigo_stock
            // 
            this.rb_codigo_stock.AutoSize = true;
            this.rb_codigo_stock.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.rb_codigo_stock.Location = new System.Drawing.Point(506, 29);
            this.rb_codigo_stock.Name = "rb_codigo_stock";
            this.rb_codigo_stock.Size = new System.Drawing.Size(120, 21);
            this.rb_codigo_stock.TabIndex = 37;
            this.rb_codigo_stock.TabStop = true;
            this.rb_codigo_stock.Text = "codigo articulo";
            this.rb_codigo_stock.UseVisualStyleBackColor = true;
            // 
            // Frm_ABM_Stock
            // 
            this._PosiciónVisible = true;
            this._titulo = "Consulta Stock";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 450);
            this.Controls.Add(this.grid011);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Frm_ABM_Stock";
            this.Text = "Frm_ABM_Stock";
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
            this.Controls.SetChildIndex(this.grid011, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid011)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Clases.Grid01 grid011;
        private System.Windows.Forms.Label lbl_pat_bus_articulo;
        private System.Windows.Forms.MaskedTextBox txt_patron;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txt_id_stock;
        private System.Windows.Forms.RadioButton rb_todo_stock;
        private System.Windows.Forms.RadioButton rb_codigo_stock;
    }
}