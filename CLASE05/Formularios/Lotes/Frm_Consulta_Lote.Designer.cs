
namespace CLASE05.Formularios.Lotes
{
    partial class Frm_Consulta_Lote
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_fecha_compra = new CLASE05.Clases.LabelText02();
            this.txt_nombre = new CLASE05.Clases.LabelText02();
            this.txt_nro_lote = new CLASE05.Clases.LabelText02();
            this.txt_nro_remito = new CLASE05.Clases.LabelText02();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.lbl_titulo = new System.Windows.Forms.Label();
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txt_fecha_compra);
            this.panel1.Controls.Add(this.txt_nombre);
            this.panel1.Controls.Add(this.txt_nro_lote);
            this.panel1.Controls.Add(this.txt_nro_remito);
            this.panel1.Controls.Add(this.btn_aceptar);
            this.panel1.Location = new System.Drawing.Point(11, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 288);
            this.panel1.TabIndex = 28;
            // 
            // txt_fecha_compra
            // 
            this.txt_fecha_compra._Ancho = 10;
            this.txt_fecha_compra._Decimales = 2;
            this.txt_fecha_compra._Etiqueta = "Fecha de Compra";
            this.txt_fecha_compra._Mask = "CCCCCCCCCC";
            this.txt_fecha_compra._MensajeError = "El password esta vácio";
            this.txt_fecha_compra._Nombre_campo = null;
            this.txt_fecha_compra._Nombre_tabla = null;
            this.txt_fecha_compra._ReadOnly = false;
            this.txt_fecha_compra._Text = "";
            this.txt_fecha_compra._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_fecha_compra._TipoDato = CLASE05.Clases.LabelText02.TipoDato.texto;
            this.txt_fecha_compra._Validable = true;
            this.txt_fecha_compra.BackColor = System.Drawing.Color.Transparent;
            this.txt_fecha_compra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fecha_compra.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_fecha_compra.Location = new System.Drawing.Point(7, 157);
            this.txt_fecha_compra.Margin = new System.Windows.Forms.Padding(4);
            this.txt_fecha_compra.Name = "txt_fecha_compra";
            this.txt_fecha_compra.Size = new System.Drawing.Size(257, 34);
            this.txt_fecha_compra.TabIndex = 27;
            // 
            // txt_nombre
            // 
            this.txt_nombre._Ancho = 10;
            this.txt_nombre._Decimales = 2;
            this.txt_nombre._Etiqueta = "Nombre";
            this.txt_nombre._Mask = "CCCCCCCCCC";
            this.txt_nombre._MensajeError = "El password esta vácio";
            this.txt_nombre._Nombre_campo = null;
            this.txt_nombre._Nombre_tabla = null;
            this.txt_nombre._ReadOnly = false;
            this.txt_nombre._Text = "";
            this.txt_nombre._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_nombre._TipoDato = CLASE05.Clases.LabelText02.TipoDato.texto;
            this.txt_nombre._Validable = true;
            this.txt_nombre.BackColor = System.Drawing.Color.Transparent;
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_nombre.Location = new System.Drawing.Point(7, 115);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(257, 34);
            this.txt_nombre.TabIndex = 26;
            // 
            // txt_nro_lote
            // 
            this.txt_nro_lote._Ancho = 2;
            this.txt_nro_lote._Decimales = 0;
            this.txt_nro_lote._Etiqueta = "Nro de Lote";
            this.txt_nro_lote._Mask = "99";
            this.txt_nro_lote._MensajeError = null;
            this.txt_nro_lote._Nombre_campo = "id_usuario";
            this.txt_nro_lote._Nombre_tabla = null;
            this.txt_nro_lote._ReadOnly = false;
            this.txt_nro_lote._Text = "";
            this.txt_nro_lote._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_nro_lote._TipoDato = CLASE05.Clases.LabelText02.TipoDato.numero;
            this.txt_nro_lote._Validable = false;
            this.txt_nro_lote.BackColor = System.Drawing.Color.Transparent;
            this.txt_nro_lote.Enabled = false;
            this.txt_nro_lote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nro_lote.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_nro_lote.Location = new System.Drawing.Point(7, 40);
            this.txt_nro_lote.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nro_lote.Name = "txt_nro_lote";
            this.txt_nro_lote.Size = new System.Drawing.Size(257, 28);
            this.txt_nro_lote.TabIndex = 24;
            // 
            // txt_nro_remito
            // 
            this.txt_nro_remito._Ancho = 30;
            this.txt_nro_remito._Decimales = 2;
            this.txt_nro_remito._Etiqueta = "Nro Remito  Proveedor";
            this.txt_nro_remito._Mask = "CCCCCCCCCCCCCCCCCCCCCCCCCCCCCC";
            this.txt_nro_remito._MensajeError = "El nombre del usuario está vácio";
            this.txt_nro_remito._Nombre_campo = "n_usuario";
            this.txt_nro_remito._Nombre_tabla = null;
            this.txt_nro_remito._ReadOnly = false;
            this.txt_nro_remito._Text = "";
            this.txt_nro_remito._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_nro_remito._TipoDato = CLASE05.Clases.LabelText02.TipoDato.texto;
            this.txt_nro_remito._Validable = true;
            this.txt_nro_remito.BackColor = System.Drawing.Color.Transparent;
            this.txt_nro_remito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nro_remito.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_nro_remito.Location = new System.Drawing.Point(7, 76);
            this.txt_nro_remito.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nro_remito.Name = "txt_nro_remito";
            this.txt_nro_remito.Size = new System.Drawing.Size(257, 31);
            this.txt_nro_remito.TabIndex = 25;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btn_aceptar.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_aceptar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_aceptar.Location = new System.Drawing.Point(156, 238);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(95, 31);
            this.btn_aceptar.TabIndex = 22;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = false;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_titulo.ForeColor = System.Drawing.Color.White;
            this.lbl_titulo.Location = new System.Drawing.Point(13, 27);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(208, 31);
            this.lbl_titulo.TabIndex = 27;
            this.lbl_titulo.Text = "Consulta de Lote";
            // 
            // Frm_Consulta_Lote
            // 
            this._PosiciónVisible = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(432, 384);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_titulo);
            this.Name = "Frm_Consulta_Lote";
            this.Text = "Frm_Consulta_Lote";
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

        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btn_aceptar;
        public System.Windows.Forms.Label lbl_titulo;
        public Clases.LabelText02 txt_fecha_compra;
        public Clases.LabelText02 txt_nombre;
        public Clases.LabelText02 txt_nro_lote;
        public Clases.LabelText02 txt_nro_remito;
    }
}