
namespace CLASE05.Formularios.TipoDocumento
{
    partial class frm_ABM_tipoDocumento
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
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPatronBusqueda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGrid_cliente = new CLASE05.Clases.Grid01();
            this.rb_id_cliente = new System.Windows.Forms.RadioButton();
            this.txt_id_cliente = new System.Windows.Forms.MaskedTextBox();
            this.rb_razon_social = new System.Windows.Forms.RadioButton();
            this.rb_todo = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_cliente)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_todo);
            this.groupBox1.Controls.Add(this.rb_razon_social);
            this.groupBox1.Controls.Add(this.rb_id_cliente);
            this.groupBox1.Controls.Add(this.txt_id_cliente);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxPatronBusqueda);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.SetChildIndex(this.btn_buscar, 0);
            this.groupBox1.Controls.SetChildIndex(this.label2, 0);
            this.groupBox1.Controls.SetChildIndex(this.textBoxPatronBusqueda, 0);
            this.groupBox1.Controls.SetChildIndex(this.label3, 0);
            this.groupBox1.Controls.SetChildIndex(this.txt_id_cliente, 0);
            this.groupBox1.Controls.SetChildIndex(this.rb_id_cliente, 0);
            this.groupBox1.Controls.SetChildIndex(this.rb_razon_social, 0);
            this.groupBox1.Controls.SetChildIndex(this.rb_todo, 0);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
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
            this.btn_borrar.Click += new System.EventHandler(this.btn_borrar_Click_1);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(212, 31);
            this.label1.Text = "Consultar Cliente";
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
            this.btn_cerrar.Location = new System.Drawing.Point(765, 1);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_minimizar.Location = new System.Drawing.Point(695, 1);
            // 
            // btn_maximizar
            // 
            this.btn_maximizar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_maximizar.Location = new System.Drawing.Point(736, 2);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(414, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Buscar por: ";
            // 
            // textBoxPatronBusqueda
            // 
            this.textBoxPatronBusqueda.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPatronBusqueda.Location = new System.Drawing.Point(129, 39);
            this.textBoxPatronBusqueda.Name = "textBoxPatronBusqueda";
            this.textBoxPatronBusqueda.Size = new System.Drawing.Size(200, 22);
            this.textBoxPatronBusqueda.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Patron de Busqueda";
            // 
            // dataGrid_cliente
            // 
            this.dataGrid_cliente._formatoLetraHeader = System.Drawing.FontStyle.Regular;
            this.dataGrid_cliente._tamannoLetraHeader = 9;
            this.dataGrid_cliente.AllowUserToAddRows = false;
            this.dataGrid_cliente.AllowUserToDeleteRows = false;
            this.dataGrid_cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_cliente.Location = new System.Drawing.Point(12, 213);
            this.dataGrid_cliente.Name = "dataGrid_cliente";
            this.dataGrid_cliente.ReadOnly = true;
            this.dataGrid_cliente.Size = new System.Drawing.Size(645, 150);
            this.dataGrid_cliente.TabIndex = 6;
            this.dataGrid_cliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_cliente_CellContentClick);
            this.dataGrid_cliente.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_cliente_CellDoubleClick);
            // 
            // rb_id_cliente
            // 
            this.rb_id_cliente.AutoSize = true;
            this.rb_id_cliente.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.rb_id_cliente.Location = new System.Drawing.Point(46, 75);
            this.rb_id_cliente.Name = "rb_id_cliente";
            this.rb_id_cliente.Size = new System.Drawing.Size(86, 21);
            this.rb_id_cliente.TabIndex = 20;
            this.rb_id_cliente.TabStop = true;
            this.rb_id_cliente.Text = "id_cliente";
            this.rb_id_cliente.UseVisualStyleBackColor = true;
            this.rb_id_cliente.CheckedChanged += new System.EventHandler(this.rb_cuit_CheckedChanged);
            // 
            // txt_id_cliente
            // 
            this.txt_id_cliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txt_id_cliente.Enabled = false;
            this.txt_id_cliente.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_cliente.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.txt_id_cliente.Location = new System.Drawing.Point(138, 71);
            this.txt_id_cliente.Mask = "99999";
            this.txt_id_cliente.Name = "txt_id_cliente";
            this.txt_id_cliente.Size = new System.Drawing.Size(71, 25);
            this.txt_id_cliente.TabIndex = 21;
            // 
            // rb_razon_social
            // 
            this.rb_razon_social.AutoSize = true;
            this.rb_razon_social.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.rb_razon_social.Location = new System.Drawing.Point(413, 46);
            this.rb_razon_social.Name = "rb_razon_social";
            this.rb_razon_social.Size = new System.Drawing.Size(105, 21);
            this.rb_razon_social.TabIndex = 22;
            this.rb_razon_social.TabStop = true;
            this.rb_razon_social.Text = "Razon Social";
            this.rb_razon_social.UseVisualStyleBackColor = true;
            // 
            // rb_todo
            // 
            this.rb_todo.AutoSize = true;
            this.rb_todo.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.rb_todo.Location = new System.Drawing.Point(413, 71);
            this.rb_todo.Name = "rb_todo";
            this.rb_todo.Size = new System.Drawing.Size(58, 21);
            this.rb_todo.TabIndex = 23;
            this.rb_todo.TabStop = true;
            this.rb_todo.Text = "Todo";
            this.rb_todo.UseVisualStyleBackColor = true;
            // 
            // frm_ABM_tipoDocumento
            // 
            this._PosiciónVisible = true;
            this._titulo = "Consultar Cliente";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGrid_cliente);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frm_ABM_tipoDocumento";
            this.Text = "frm_ABM_Cliente";
            this.Load += new System.EventHandler(this.frm_ABM_tipoDocumento_Load);
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
            this.Controls.SetChildIndex(this.dataGrid_cliente, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_cliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPatronBusqueda;
        private System.Windows.Forms.Label label2;
        private Clases.Grid01 dataGrid_cliente;
        private System.Windows.Forms.RadioButton rb_id_cliente;
        private System.Windows.Forms.MaskedTextBox txt_id_cliente;
        private System.Windows.Forms.RadioButton rb_todo;
        private System.Windows.Forms.RadioButton rb_razon_social;
    }
}