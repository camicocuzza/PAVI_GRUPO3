
namespace CLASE05.Formularios.Proveedor
{
    partial class Frm_Consulta_Proveedor
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
            this.txt_id_comprador = new CLASE05.Clases.LabelText02();
            this.txt_inicio_operacion = new CLASE05.Clases.LabelText02();
            this.txt_id_domicilio = new CLASE05.Clases.LabelText02();
            this.txt_razon_social = new CLASE05.Clases.LabelText02();
            this.txt_id_proveedor = new CLASE05.Clases.LabelText02();
            this.txt_cuit = new CLASE05.Clases.LabelText02();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_cerrar.Location = new System.Drawing.Point(396, 2);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_minimizar.Location = new System.Drawing.Point(326, 2);
            // 
            // btn_maximizar
            // 
            this.btn_maximizar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_maximizar.Location = new System.Drawing.Point(361, 2);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_titulo.ForeColor = System.Drawing.Color.White;
            this.lbl_titulo.Location = new System.Drawing.Point(4, 45);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(241, 31);
            this.lbl_titulo.TabIndex = 29;
            this.lbl_titulo.Text = "Consulta Proveedor";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txt_id_comprador);
            this.panel1.Controls.Add(this.txt_inicio_operacion);
            this.panel1.Controls.Add(this.txt_id_domicilio);
            this.panel1.Controls.Add(this.txt_razon_social);
            this.panel1.Controls.Add(this.txt_id_proveedor);
            this.panel1.Controls.Add(this.txt_cuit);
            this.panel1.Controls.Add(this.btn_aceptar);
            this.panel1.Location = new System.Drawing.Point(10, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 347);
            this.panel1.TabIndex = 30;
            // 
            // txt_id_comprador
            // 
            this.txt_id_comprador._Ancho = 2;
            this.txt_id_comprador._Decimales = 0;
            this.txt_id_comprador._Etiqueta = "ID Comprador";
            this.txt_id_comprador._Mask = "99";
            this.txt_id_comprador._MensajeError = null;
            this.txt_id_comprador._Nombre_campo = "id_usuario";
            this.txt_id_comprador._Nombre_tabla = null;
            this.txt_id_comprador._ReadOnly = false;
            this.txt_id_comprador._Text = "";
            this.txt_id_comprador._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_id_comprador._TipoDato = CLASE05.Clases.LabelText02.TipoDato.numero;
            this.txt_id_comprador._Validable = false;
            this.txt_id_comprador.BackColor = System.Drawing.Color.Transparent;
            this.txt_id_comprador.Enabled = false;
            this.txt_id_comprador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_comprador.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_id_comprador.Location = new System.Drawing.Point(2, 205);
            this.txt_id_comprador.Margin = new System.Windows.Forms.Padding(4);
            this.txt_id_comprador.Name = "txt_id_comprador";
            this.txt_id_comprador.Size = new System.Drawing.Size(257, 28);
            this.txt_id_comprador.TabIndex = 25;
            // 
            // txt_inicio_operacion
            // 
            this.txt_inicio_operacion._Ancho = 2;
            this.txt_inicio_operacion._Decimales = 0;
            this.txt_inicio_operacion._Etiqueta = "Inicio Operacion";
            this.txt_inicio_operacion._Mask = "99";
            this.txt_inicio_operacion._MensajeError = null;
            this.txt_inicio_operacion._Nombre_campo = "id_usuario";
            this.txt_inicio_operacion._Nombre_tabla = null;
            this.txt_inicio_operacion._ReadOnly = false;
            this.txt_inicio_operacion._Text = "";
            this.txt_inicio_operacion._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_inicio_operacion._TipoDato = CLASE05.Clases.LabelText02.TipoDato.numero;
            this.txt_inicio_operacion._Validable = false;
            this.txt_inicio_operacion.BackColor = System.Drawing.Color.Transparent;
            this.txt_inicio_operacion.Enabled = false;
            this.txt_inicio_operacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_inicio_operacion.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_inicio_operacion.Location = new System.Drawing.Point(4, 169);
            this.txt_inicio_operacion.Margin = new System.Windows.Forms.Padding(4);
            this.txt_inicio_operacion.Name = "txt_inicio_operacion";
            this.txt_inicio_operacion.Size = new System.Drawing.Size(257, 28);
            this.txt_inicio_operacion.TabIndex = 24;
            // 
            // txt_id_domicilio
            // 
            this.txt_id_domicilio._Ancho = 10;
            this.txt_id_domicilio._Decimales = 2;
            this.txt_id_domicilio._Etiqueta = "ID Domicilio";
            this.txt_id_domicilio._Mask = "CCCCCCCCCC";
            this.txt_id_domicilio._MensajeError = "El password esta vácio";
            this.txt_id_domicilio._Nombre_campo = null;
            this.txt_id_domicilio._Nombre_tabla = null;
            this.txt_id_domicilio._ReadOnly = false;
            this.txt_id_domicilio._Text = "";
            this.txt_id_domicilio._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_id_domicilio._TipoDato = CLASE05.Clases.LabelText02.TipoDato.texto;
            this.txt_id_domicilio._Validable = true;
            this.txt_id_domicilio.BackColor = System.Drawing.Color.Transparent;
            this.txt_id_domicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_domicilio.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_id_domicilio.Location = new System.Drawing.Point(4, 133);
            this.txt_id_domicilio.Margin = new System.Windows.Forms.Padding(4);
            this.txt_id_domicilio.Name = "txt_id_domicilio";
            this.txt_id_domicilio.Size = new System.Drawing.Size(257, 28);
            this.txt_id_domicilio.TabIndex = 23;
            // 
            // txt_razon_social
            // 
            this.txt_razon_social._Ancho = 10;
            this.txt_razon_social._Decimales = 2;
            this.txt_razon_social._Etiqueta = "Razon Social";
            this.txt_razon_social._Mask = "CCCCCCCCCC";
            this.txt_razon_social._MensajeError = "El password esta vácio";
            this.txt_razon_social._Nombre_campo = null;
            this.txt_razon_social._Nombre_tabla = null;
            this.txt_razon_social._ReadOnly = false;
            this.txt_razon_social._Text = "";
            this.txt_razon_social._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_razon_social._TipoDato = CLASE05.Clases.LabelText02.TipoDato.texto;
            this.txt_razon_social._Validable = true;
            this.txt_razon_social.BackColor = System.Drawing.Color.Transparent;
            this.txt_razon_social.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_razon_social.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_razon_social.Location = new System.Drawing.Point(4, 91);
            this.txt_razon_social.Margin = new System.Windows.Forms.Padding(4);
            this.txt_razon_social.Name = "txt_razon_social";
            this.txt_razon_social.Size = new System.Drawing.Size(257, 34);
            this.txt_razon_social.TabIndex = 15;
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
            this.txt_id_proveedor.Location = new System.Drawing.Point(4, 16);
            this.txt_id_proveedor.Margin = new System.Windows.Forms.Padding(4);
            this.txt_id_proveedor.Name = "txt_id_proveedor";
            this.txt_id_proveedor.Size = new System.Drawing.Size(257, 28);
            this.txt_id_proveedor.TabIndex = 13;
            // 
            // txt_cuit
            // 
            this.txt_cuit._Ancho = 30;
            this.txt_cuit._Decimales = 2;
            this.txt_cuit._Etiqueta = "Cuit";
            this.txt_cuit._Mask = "CCCCCCCCCCCCCCCCCCCCCCCCCCCCCC";
            this.txt_cuit._MensajeError = "El nombre del usuario está vácio";
            this.txt_cuit._Nombre_campo = "n_usuario";
            this.txt_cuit._Nombre_tabla = null;
            this.txt_cuit._ReadOnly = false;
            this.txt_cuit._Text = "";
            this.txt_cuit._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_cuit._TipoDato = CLASE05.Clases.LabelText02.TipoDato.texto;
            this.txt_cuit._Validable = true;
            this.txt_cuit.BackColor = System.Drawing.Color.Transparent;
            this.txt_cuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cuit.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_cuit.Location = new System.Drawing.Point(4, 52);
            this.txt_cuit.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cuit.Name = "txt_cuit";
            this.txt_cuit.Size = new System.Drawing.Size(257, 31);
            this.txt_cuit.TabIndex = 14;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btn_aceptar.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_aceptar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_aceptar.Location = new System.Drawing.Point(148, 287);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(95, 31);
            this.btn_aceptar.TabIndex = 22;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = false;
            // 
            // Frm_Consulta_Proveedor
            // 
            this._PosiciónVisible = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(432, 436);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_titulo);
            this.Name = "Frm_Consulta_Proveedor";
            this.Text = "Frm_Consulta_Proveedor";
            this.Load += new System.EventHandler(this.Frm_Consulta_Proveedor_Load);
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
        public Clases.LabelText02 txt_id_comprador;
        public Clases.LabelText02 txt_inicio_operacion;
        public Clases.LabelText02 txt_id_domicilio;
        public Clases.LabelText02 txt_razon_social;
        public Clases.LabelText02 txt_id_proveedor;
        public Clases.LabelText02 txt_cuit;
        public System.Windows.Forms.Button btn_aceptar;
    }
}