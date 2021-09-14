
namespace CLASE05.Formularios.Articulo
{
    partial class Frm_Modificar_Articulo
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
            this.txt_plazo_pago = new CLASE05.Clases.LabelText02();
            this.txt_id_rubro = new CLASE05.Clases.LabelText02();
            this.txt_id_pais_origen = new CLASE05.Clases.LabelText02();
            this.txt_id_proveedor = new CLASE05.Clases.LabelText02();
            this.txt_nombre = new CLASE05.Clases.LabelText02();
            this.txt_tiempo_envio = new CLASE05.Clases.LabelText02();
            this.txt_Codigo = new CLASE05.Clases.LabelText02();
            this.txt_costo = new CLASE05.Clases.LabelText02();
            this.txt_nro_lote = new CLASE05.Clases.LabelText02();
            this.txt_nro_serie = new CLASE05.Clases.LabelText02();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_cerrar.Location = new System.Drawing.Point(407, 2);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_minimizar.Location = new System.Drawing.Point(337, 2);
            // 
            // btn_maximizar
            // 
            this.btn_maximizar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_maximizar.Location = new System.Drawing.Point(372, 2);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_titulo.ForeColor = System.Drawing.Color.White;
            this.lbl_titulo.Location = new System.Drawing.Point(4, 26);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(258, 31);
            this.lbl_titulo.TabIndex = 31;
            this.lbl_titulo.Text = "Modificar  Proveedor";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txt_plazo_pago);
            this.panel1.Controls.Add(this.txt_id_rubro);
            this.panel1.Controls.Add(this.txt_id_pais_origen);
            this.panel1.Controls.Add(this.txt_id_proveedor);
            this.panel1.Controls.Add(this.txt_nombre);
            this.panel1.Controls.Add(this.txt_tiempo_envio);
            this.panel1.Controls.Add(this.txt_Codigo);
            this.panel1.Controls.Add(this.txt_costo);
            this.panel1.Controls.Add(this.txt_nro_lote);
            this.panel1.Controls.Add(this.txt_nro_serie);
            this.panel1.Controls.Add(this.btn_aceptar);
            this.panel1.Location = new System.Drawing.Point(10, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(432, 449);
            this.panel1.TabIndex = 32;
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
            this.txt_plazo_pago.Location = new System.Drawing.Point(0, 196);
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
            this.txt_id_rubro.Location = new System.Drawing.Point(0, 268);
            this.txt_id_rubro.Margin = new System.Windows.Forms.Padding(4);
            this.txt_id_rubro.Name = "txt_id_rubro";
            this.txt_id_rubro.Size = new System.Drawing.Size(284, 28);
            this.txt_id_rubro.TabIndex = 28;
            // 
            // txt_id_pais_origen
            // 
            this.txt_id_pais_origen._Ancho = 2;
            this.txt_id_pais_origen._Decimales = 0;
            this.txt_id_pais_origen._Etiqueta = "ID Pais Origen";
            this.txt_id_pais_origen._Mask = "99";
            this.txt_id_pais_origen._MensajeError = null;
            this.txt_id_pais_origen._Nombre_campo = "id_usuario";
            this.txt_id_pais_origen._Nombre_tabla = null;
            this.txt_id_pais_origen._ReadOnly = false;
            this.txt_id_pais_origen._Text = "";
            this.txt_id_pais_origen._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_id_pais_origen._TipoDato = CLASE05.Clases.LabelText02.TipoDato.numero;
            this.txt_id_pais_origen._Validable = false;
            this.txt_id_pais_origen.BackColor = System.Drawing.Color.Transparent;
            this.txt_id_pais_origen.Enabled = false;
            this.txt_id_pais_origen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_pais_origen.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_id_pais_origen.Location = new System.Drawing.Point(1, 304);
            this.txt_id_pais_origen.Margin = new System.Windows.Forms.Padding(4);
            this.txt_id_pais_origen.Name = "txt_id_pais_origen";
            this.txt_id_pais_origen.Size = new System.Drawing.Size(283, 28);
            this.txt_id_pais_origen.TabIndex = 27;
            // 
            // txt_id_proveedor
            // 
            this.txt_id_proveedor._Ancho = 2;
            this.txt_id_proveedor._Decimales = 0;
            this.txt_id_proveedor._Etiqueta = "ID Proveedor";
            this.txt_id_proveedor._Mask = "99";
            this.txt_id_proveedor._MensajeError = null;
            this.txt_id_proveedor._Nombre_campo = "id_usuario";
            this.txt_id_proveedor._Nombre_tabla = null;
            this.txt_id_proveedor._ReadOnly = false;
            this.txt_id_proveedor._Text = "";
            this.txt_id_proveedor._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_id_proveedor._TipoDato = CLASE05.Clases.LabelText02.TipoDato.numero;
            this.txt_id_proveedor._Validable = false;
            this.txt_id_proveedor.BackColor = System.Drawing.Color.Transparent;
            this.txt_id_proveedor.Enabled = false;
            this.txt_id_proveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_proveedor.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_id_proveedor.Location = new System.Drawing.Point(0, 340);
            this.txt_id_proveedor.Margin = new System.Windows.Forms.Padding(4);
            this.txt_id_proveedor.Name = "txt_id_proveedor";
            this.txt_id_proveedor.Size = new System.Drawing.Size(284, 28);
            this.txt_id_proveedor.TabIndex = 26;
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
            this.txt_nombre.Location = new System.Drawing.Point(0, 232);
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
            this.txt_tiempo_envio.Location = new System.Drawing.Point(-2, 160);
            this.txt_tiempo_envio.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tiempo_envio.Name = "txt_tiempo_envio";
            this.txt_tiempo_envio.Size = new System.Drawing.Size(286, 28);
            this.txt_tiempo_envio.TabIndex = 24;
            // 
            // txt_Codigo
            // 
            this.txt_Codigo._Ancho = 2;
            this.txt_Codigo._Decimales = 0;
            this.txt_Codigo._Etiqueta = "Codigo";
            this.txt_Codigo._Mask = "99";
            this.txt_Codigo._MensajeError = null;
            this.txt_Codigo._Nombre_campo = "id_usuario";
            this.txt_Codigo._Nombre_tabla = null;
            this.txt_Codigo._ReadOnly = false;
            this.txt_Codigo._Text = "";
            this.txt_Codigo._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_Codigo._TipoDato = CLASE05.Clases.LabelText02.TipoDato.numero;
            this.txt_Codigo._Validable = false;
            this.txt_Codigo.BackColor = System.Drawing.Color.Transparent;
            this.txt_Codigo.Enabled = false;
            this.txt_Codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Codigo.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_Codigo.Location = new System.Drawing.Point(1, 17);
            this.txt_Codigo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Codigo.Name = "txt_Codigo";
            this.txt_Codigo.Size = new System.Drawing.Size(283, 28);
            this.txt_Codigo.TabIndex = 23;
            // 
            // txt_costo
            // 
            this.txt_costo._Ancho = 10;
            this.txt_costo._Decimales = 2;
            this.txt_costo._Etiqueta = "Costo";
            this.txt_costo._Mask = "CCCCCCCCCC";
            this.txt_costo._MensajeError = "El password esta vácio";
            this.txt_costo._Nombre_campo = null;
            this.txt_costo._Nombre_tabla = null;
            this.txt_costo._ReadOnly = false;
            this.txt_costo._Text = "";
            this.txt_costo._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_costo._TipoDato = CLASE05.Clases.LabelText02.TipoDato.texto;
            this.txt_costo._Validable = true;
            this.txt_costo.BackColor = System.Drawing.Color.Transparent;
            this.txt_costo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_costo.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_costo.Location = new System.Drawing.Point(-1, 123);
            this.txt_costo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_costo.Name = "txt_costo";
            this.txt_costo.Size = new System.Drawing.Size(285, 29);
            this.txt_costo.TabIndex = 15;
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
            this.txt_nro_lote.Location = new System.Drawing.Point(0, 53);
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
            this.txt_nro_serie.Location = new System.Drawing.Point(1, 89);
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
            this.btn_aceptar.Location = new System.Drawing.Point(166, 402);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(95, 31);
            this.btn_aceptar.TabIndex = 22;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = false;
            // 
            // Frm_Modificar_Articulo
            // 
            this._PosiciónVisible = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(444, 515);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_titulo);
            this.Name = "Frm_Modificar_Articulo";
            this.Text = "Frm_Modificar_Articulo";
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
        public Clases.LabelText02 txt_plazo_pago;
        public Clases.LabelText02 txt_id_rubro;
        public Clases.LabelText02 txt_id_pais_origen;
        public Clases.LabelText02 txt_id_proveedor;
        public Clases.LabelText02 txt_nombre;
        public Clases.LabelText02 txt_tiempo_envio;
        public Clases.LabelText02 txt_Codigo;
        public Clases.LabelText02 txt_costo;
        public Clases.LabelText02 txt_nro_lote;
        public Clases.LabelText02 txt_nro_serie;
        public System.Windows.Forms.Button btn_aceptar;
    }
}