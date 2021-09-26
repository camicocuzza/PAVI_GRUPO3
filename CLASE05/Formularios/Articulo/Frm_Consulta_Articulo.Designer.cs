
namespace CLASE05.Formularios.Articulo
{
    partial class Frm_Consulta_Articulo
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
            this.txt_plazo_pago = new CLASE05.Clases.LabelText02();
            this.txt_id_rubro = new CLASE05.Clases.LabelText02();
            this.txt_cuit_proveedor = new CLASE05.Clases.LabelText02();
            this.txt_nombre = new CLASE05.Clases.LabelText02();
            this.txt_tiempo_envio = new CLASE05.Clases.LabelText02();
            this.txt_codigo = new CLASE05.Clases.LabelText02();
            this.txt_precio = new CLASE05.Clases.LabelText02();
            this.txt_nro_lote = new CLASE05.Clases.LabelText02();
            this.txt_nro_serie = new CLASE05.Clases.LabelText02();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.txt_stock = new CLASE05.Clases.LabelText02();
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
            this.panel1.Controls.Add(this.txt_stock);
            this.panel1.Controls.Add(this.txt_plazo_pago);
            this.panel1.Controls.Add(this.txt_id_rubro);
            this.panel1.Controls.Add(this.txt_cuit_proveedor);
            this.panel1.Controls.Add(this.txt_nombre);
            this.panel1.Controls.Add(this.txt_tiempo_envio);
            this.panel1.Controls.Add(this.txt_codigo);
            this.panel1.Controls.Add(this.txt_precio);
            this.panel1.Controls.Add(this.txt_nro_lote);
            this.panel1.Controls.Add(this.txt_nro_serie);
            this.panel1.Controls.Add(this.btn_aceptar);
            this.panel1.Location = new System.Drawing.Point(11, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 445);
            this.panel1.TabIndex = 29;
            // 
            // txt_plazo_pago
            // 
            this.txt_plazo_pago._Ancho = 2;
            this.txt_plazo_pago._Decimales = 0;
            this.txt_plazo_pago._Etiqueta = "Plazo de Pago";
            this.txt_plazo_pago._Mask = "99";
            this.txt_plazo_pago._MensajeError = null;
            this.txt_plazo_pago._Nombre_campo = "id_usuario";
            this.txt_plazo_pago._Nombre_tabla = null;
            this.txt_plazo_pago._ReadOnly = false;
            this.txt_plazo_pago._Text = "";
            this.txt_plazo_pago._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_plazo_pago._TipoDato = CLASE05.Clases.LabelText02.TipoDato.numero;
            this.txt_plazo_pago._Validable = false;
            this.txt_plazo_pago.BackColor = System.Drawing.Color.Transparent;
            this.txt_plazo_pago.Enabled = false;
            this.txt_plazo_pago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_plazo_pago.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_plazo_pago.Location = new System.Drawing.Point(0, 268);
            this.txt_plazo_pago.Margin = new System.Windows.Forms.Padding(4);
            this.txt_plazo_pago.Name = "txt_plazo_pago";
            this.txt_plazo_pago.Size = new System.Drawing.Size(284, 28);
            this.txt_plazo_pago.TabIndex = 29;
            // 
            // txt_id_rubro
            // 
            this.txt_id_rubro._Ancho = 2;
            this.txt_id_rubro._Decimales = 0;
            this.txt_id_rubro._Etiqueta = "ID Rubro";
            this.txt_id_rubro._Mask = "99";
            this.txt_id_rubro._MensajeError = null;
            this.txt_id_rubro._Nombre_campo = "id_usuario";
            this.txt_id_rubro._Nombre_tabla = null;
            this.txt_id_rubro._ReadOnly = false;
            this.txt_id_rubro._Text = "";
            this.txt_id_rubro._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_id_rubro._TipoDato = CLASE05.Clases.LabelText02.TipoDato.numero;
            this.txt_id_rubro._Validable = false;
            this.txt_id_rubro.BackColor = System.Drawing.Color.Transparent;
            this.txt_id_rubro.Enabled = false;
            this.txt_id_rubro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_rubro.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_id_rubro.Location = new System.Drawing.Point(0, 304);
            this.txt_id_rubro.Margin = new System.Windows.Forms.Padding(4);
            this.txt_id_rubro.Name = "txt_id_rubro";
            this.txt_id_rubro.Size = new System.Drawing.Size(284, 28);
            this.txt_id_rubro.TabIndex = 28;
            // 
            // txt_cuit_proveedor
            // 
            this.txt_cuit_proveedor._Ancho = 2;
            this.txt_cuit_proveedor._Decimales = 0;
            this.txt_cuit_proveedor._Etiqueta = "Cuit Proveedor";
            this.txt_cuit_proveedor._Mask = "99";
            this.txt_cuit_proveedor._MensajeError = null;
            this.txt_cuit_proveedor._Nombre_campo = "id_usuario";
            this.txt_cuit_proveedor._Nombre_tabla = null;
            this.txt_cuit_proveedor._ReadOnly = false;
            this.txt_cuit_proveedor._Text = "";
            this.txt_cuit_proveedor._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_cuit_proveedor._TipoDato = CLASE05.Clases.LabelText02.TipoDato.numero;
            this.txt_cuit_proveedor._Validable = false;
            this.txt_cuit_proveedor.BackColor = System.Drawing.Color.Transparent;
            this.txt_cuit_proveedor.Enabled = false;
            this.txt_cuit_proveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cuit_proveedor.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_cuit_proveedor.Location = new System.Drawing.Point(0, 159);
            this.txt_cuit_proveedor.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cuit_proveedor.Name = "txt_cuit_proveedor";
            this.txt_cuit_proveedor.Size = new System.Drawing.Size(284, 28);
            this.txt_cuit_proveedor.TabIndex = 26;
            // 
            // txt_nombre
            // 
            this.txt_nombre._Ancho = 2;
            this.txt_nombre._Decimales = 0;
            this.txt_nombre._Etiqueta = "Nombre";
            this.txt_nombre._Mask = "99";
            this.txt_nombre._MensajeError = null;
            this.txt_nombre._Nombre_campo = "id_usuario";
            this.txt_nombre._Nombre_tabla = null;
            this.txt_nombre._ReadOnly = false;
            this.txt_nombre._Text = "";
            this.txt_nombre._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_nombre._TipoDato = CLASE05.Clases.LabelText02.TipoDato.numero;
            this.txt_nombre._Validable = false;
            this.txt_nombre.BackColor = System.Drawing.Color.Transparent;
            this.txt_nombre.Enabled = false;
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_nombre.Location = new System.Drawing.Point(0, 123);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(284, 28);
            this.txt_nombre.TabIndex = 25;
            // 
            // txt_tiempo_envio
            // 
            this.txt_tiempo_envio._Ancho = 2;
            this.txt_tiempo_envio._Decimales = 0;
            this.txt_tiempo_envio._Etiqueta = "Tiempo de Envio";
            this.txt_tiempo_envio._Mask = "99";
            this.txt_tiempo_envio._MensajeError = null;
            this.txt_tiempo_envio._Nombre_campo = "id_usuario";
            this.txt_tiempo_envio._Nombre_tabla = null;
            this.txt_tiempo_envio._ReadOnly = false;
            this.txt_tiempo_envio._Text = "";
            this.txt_tiempo_envio._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_tiempo_envio._TipoDato = CLASE05.Clases.LabelText02.TipoDato.numero;
            this.txt_tiempo_envio._Validable = false;
            this.txt_tiempo_envio.BackColor = System.Drawing.Color.Transparent;
            this.txt_tiempo_envio.Enabled = false;
            this.txt_tiempo_envio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tiempo_envio.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_tiempo_envio.Location = new System.Drawing.Point(-2, 232);
            this.txt_tiempo_envio.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tiempo_envio.Name = "txt_tiempo_envio";
            this.txt_tiempo_envio.Size = new System.Drawing.Size(286, 28);
            this.txt_tiempo_envio.TabIndex = 24;
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
            this.txt_codigo.Location = new System.Drawing.Point(1, 17);
            this.txt_codigo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(283, 28);
            this.txt_codigo.TabIndex = 23;
            // 
            // txt_precio
            // 
            this.txt_precio._Ancho = 10;
            this.txt_precio._Decimales = 2;
            this.txt_precio._Etiqueta = "Precio";
            this.txt_precio._Mask = "CCCCCCCCCC";
            this.txt_precio._MensajeError = "El password esta vácio";
            this.txt_precio._Nombre_campo = null;
            this.txt_precio._Nombre_tabla = null;
            this.txt_precio._ReadOnly = false;
            this.txt_precio._Text = "";
            this.txt_precio._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_precio._TipoDato = CLASE05.Clases.LabelText02.TipoDato.texto;
            this.txt_precio._Validable = true;
            this.txt_precio.BackColor = System.Drawing.Color.Transparent;
            this.txt_precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precio.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_precio.Location = new System.Drawing.Point(-1, 195);
            this.txt_precio.Margin = new System.Windows.Forms.Padding(4);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(285, 29);
            this.txt_precio.TabIndex = 15;
            // 
            // txt_nro_lote
            // 
            this.txt_nro_lote._Ancho = 2;
            this.txt_nro_lote._Decimales = 0;
            this.txt_nro_lote._Etiqueta = "Nro Lote";
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
            this.txt_nro_lote.Location = new System.Drawing.Point(0, 87);
            this.txt_nro_lote.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nro_lote.Name = "txt_nro_lote";
            this.txt_nro_lote.Size = new System.Drawing.Size(284, 28);
            this.txt_nro_lote.TabIndex = 13;
            // 
            // txt_nro_serie
            // 
            this.txt_nro_serie._Ancho = 30;
            this.txt_nro_serie._Decimales = 2;
            this.txt_nro_serie._Etiqueta = "Nro Serie";
            this.txt_nro_serie._Mask = "CCCCCCCCCCCCCCCCCCCCCCCCCCCCCC";
            this.txt_nro_serie._MensajeError = "El nombre del usuario está vácio";
            this.txt_nro_serie._Nombre_campo = "n_usuario";
            this.txt_nro_serie._Nombre_tabla = null;
            this.txt_nro_serie._ReadOnly = false;
            this.txt_nro_serie._Text = "";
            this.txt_nro_serie._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_nro_serie._TipoDato = CLASE05.Clases.LabelText02.TipoDato.texto;
            this.txt_nro_serie._Validable = true;
            this.txt_nro_serie.BackColor = System.Drawing.Color.Transparent;
            this.txt_nro_serie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nro_serie.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_nro_serie.Location = new System.Drawing.Point(1, 53);
            this.txt_nro_serie.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nro_serie.Name = "txt_nro_serie";
            this.txt_nro_serie.Size = new System.Drawing.Size(283, 35);
            this.txt_nro_serie.TabIndex = 14;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btn_aceptar.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_aceptar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_aceptar.Location = new System.Drawing.Point(167, 394);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(95, 31);
            this.btn_aceptar.TabIndex = 22;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = false;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_titulo.ForeColor = System.Drawing.Color.White;
            this.lbl_titulo.Location = new System.Drawing.Point(12, 9);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(221, 31);
            this.lbl_titulo.TabIndex = 30;
            this.lbl_titulo.Text = "Consultar Articulo";
            // 
            // txt_stock
            // 
            this.txt_stock._Ancho = 2;
            this.txt_stock._Decimales = 0;
            this.txt_stock._Etiqueta = "Stock";
            this.txt_stock._Mask = "99";
            this.txt_stock._MensajeError = null;
            this.txt_stock._Nombre_campo = "id_usuario";
            this.txt_stock._Nombre_tabla = null;
            this.txt_stock._ReadOnly = false;
            this.txt_stock._Text = "";
            this.txt_stock._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_stock._TipoDato = CLASE05.Clases.LabelText02.TipoDato.numero;
            this.txt_stock._Validable = false;
            this.txt_stock.BackColor = System.Drawing.Color.Transparent;
            this.txt_stock.Enabled = false;
            this.txt_stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_stock.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_stock.Location = new System.Drawing.Point(0, 340);
            this.txt_stock.Margin = new System.Windows.Forms.Padding(4);
            this.txt_stock.Name = "txt_stock";
            this.txt_stock.Size = new System.Drawing.Size(284, 28);
            this.txt_stock.TabIndex = 30;
            // 
            // Frm_Consulta_Articulo
            // 
            this._PosiciónVisible = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(432, 504);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_Consulta_Articulo";
            this.Text = "Frm_Consulta_Articulo";
            this.Load += new System.EventHandler(this.Frm_Consulta_Articulo_Load);
            this.Controls.SetChildIndex(this.btn_cerrar, 0);
            this.Controls.SetChildIndex(this.btn_maximizar, 0);
            this.Controls.SetChildIndex(this.btn_minimizar, 0);
            this.Controls.SetChildIndex(this.lbl_posicion, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.lbl_titulo, 0);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        public Clases.LabelText02 txt_plazo_pago;
        public Clases.LabelText02 txt_id_rubro;
        public Clases.LabelText02 txt_cuit_proveedor;
        public Clases.LabelText02 txt_nombre;
        public Clases.LabelText02 txt_tiempo_envio;
        public Clases.LabelText02 txt_codigo;
        public Clases.LabelText02 txt_precio;
        public Clases.LabelText02 txt_nro_lote;
        public Clases.LabelText02 txt_nro_serie;
        public System.Windows.Forms.Button btn_aceptar;
        public System.Windows.Forms.Label lbl_titulo;
        public Clases.LabelText02 txt_stock;
    }
}