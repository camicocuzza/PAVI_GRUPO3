
namespace CLASE05.Formularios.Stock
{
    partial class Frm_Consulta_Stock
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
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_cantidad = new CLASE05.Clases.LabelText02();
            this.txt_codigo = new CLASE05.Clases.LabelText02();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_cerrar.Location = new System.Drawing.Point(395, 2);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_minimizar.Location = new System.Drawing.Point(325, 2);
            // 
            // btn_maximizar
            // 
            this.btn_maximizar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_maximizar.Location = new System.Drawing.Point(360, 2);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_titulo.ForeColor = System.Drawing.Color.White;
            this.lbl_titulo.Location = new System.Drawing.Point(13, 27);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(220, 31);
            this.lbl_titulo.TabIndex = 31;
            this.lbl_titulo.Text = "Consulta de Stock";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txt_cantidad);
            this.panel1.Controls.Add(this.txt_codigo);
            this.panel1.Controls.Add(this.btn_aceptar);
            this.panel1.Location = new System.Drawing.Point(11, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 200);
            this.panel1.TabIndex = 32;
            // 
            // txt_cantidad
            // 
            this.txt_cantidad._Ancho = 4;
            this.txt_cantidad._Decimales = 0;
            this.txt_cantidad._Etiqueta = "Stock";
            this.txt_cantidad._Mask = "9999";
            this.txt_cantidad._MensajeError = null;
            this.txt_cantidad._Nombre_campo = "id_usuario";
            this.txt_cantidad._Nombre_tabla = null;
            this.txt_cantidad._ReadOnly = false;
            this.txt_cantidad._Text = "";
            this.txt_cantidad._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_cantidad._TipoDato = CLASE05.Clases.LabelText02.TipoDato.numero;
            this.txt_cantidad._Validable = false;
            this.txt_cantidad.BackColor = System.Drawing.Color.Transparent;
            this.txt_cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidad.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_cantidad.Location = new System.Drawing.Point(-2, 59);
            this.txt_cantidad.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(284, 28);
            this.txt_cantidad.TabIndex = 40;
            // 
            // txt_codigo
            // 
            this.txt_codigo._Ancho = 2;
            this.txt_codigo._Decimales = 0;
            this.txt_codigo._Etiqueta = "Codigo";
            this.txt_codigo._Mask = "99";
            this.txt_codigo._MensajeError = null;
            this.txt_codigo._Nombre_campo = "id_usuario";
            this.txt_codigo._Nombre_tabla = null;
            this.txt_codigo._ReadOnly = false;
            this.txt_codigo._Text = "";
            this.txt_codigo._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_codigo._TipoDato = CLASE05.Clases.LabelText02.TipoDato.numero;
            this.txt_codigo._Validable = false;
            this.txt_codigo.BackColor = System.Drawing.Color.Transparent;
            this.txt_codigo.Enabled = false;
            this.txt_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigo.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_codigo.Location = new System.Drawing.Point(-1, 9);
            this.txt_codigo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(283, 28);
            this.txt_codigo.TabIndex = 34;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btn_aceptar.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_aceptar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_aceptar.Location = new System.Drawing.Point(164, 111);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(95, 31);
            this.btn_aceptar.TabIndex = 22;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = false;
            // 
            // Frm_Consulta_Stock
            // 
            this._PosiciónVisible = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(432, 286);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_titulo);
            this.Name = "Frm_Consulta_Stock";
            this.Text = "Frm_Consulta_Stock";
            this.Controls.SetChildIndex(this.btn_cerrar, 0);
            this.Controls.SetChildIndex(this.btn_maximizar, 0);
            this.Controls.SetChildIndex(this.btn_minimizar, 0);
            this.Controls.SetChildIndex(this.lbl_posicion, 0);
            this.Controls.SetChildIndex(this.lbl_titulo, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbl_titulo;
        public System.Windows.Forms.Panel panel1;
        public Clases.LabelText02 txt_cantidad;
        public Clases.LabelText02 txt_codigo;
        public System.Windows.Forms.Button btn_aceptar;
    }
}