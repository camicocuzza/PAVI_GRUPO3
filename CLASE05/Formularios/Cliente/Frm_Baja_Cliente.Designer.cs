
namespace CLASE05.Formularios.TipoDocumento
{
    partial class Frm_Baja_tipoDocumento
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
            this.txt_cuit_cliente = new CLASE05.Clases.LabelText02();
            this.txt_id_cliente = new CLASE05.Clases.LabelText02();
            this.aceptar_baja = new System.Windows.Forms.Button();
            this.txt_ciudad_cliente = new CLASE05.Clases.LabelText02();
            this.txt_direccion_cliente = new CLASE05.Clases.LabelText02();
            this.txt_razon_social = new CLASE05.Clases.LabelText02();
            this.nombre_cliente = new CLASE05.Clases.LabelText02();
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
            this.lbl_titulo.Location = new System.Drawing.Point(26, 60);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(178, 31);
            this.lbl_titulo.TabIndex = 29;
            this.lbl_titulo.Text = "Borrar  Cliente";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txt_cuit_cliente);
            this.panel1.Controls.Add(this.txt_id_cliente);
            this.panel1.Controls.Add(this.aceptar_baja);
            this.panel1.Controls.Add(this.txt_ciudad_cliente);
            this.panel1.Controls.Add(this.txt_direccion_cliente);
            this.panel1.Controls.Add(this.txt_razon_social);
            this.panel1.Controls.Add(this.nombre_cliente);
            this.panel1.Controls.Add(this.btn_aceptar);
            this.panel1.Location = new System.Drawing.Point(12, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(397, 340);
            this.panel1.TabIndex = 32;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txt_cuit_cliente
            // 
            this.txt_cuit_cliente._Ancho = 11;
            this.txt_cuit_cliente._Decimales = 2;
            this.txt_cuit_cliente._Etiqueta = "CUIT";
            this.txt_cuit_cliente._Mask = "99-9999999-9";
            this.txt_cuit_cliente._MensajeError = null;
            this.txt_cuit_cliente._Nombre_campo = "cuit_cliente";
            this.txt_cuit_cliente._Nombre_tabla = null;
            this.txt_cuit_cliente._ReadOnly = false;
            this.txt_cuit_cliente._Text = "  -       -";
            this.txt_cuit_cliente._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_cuit_cliente._TipoDato = CLASE05.Clases.LabelText02.TipoDato.mascaraEditada;
            this.txt_cuit_cliente._Validable = false;
            this.txt_cuit_cliente.BackColor = System.Drawing.Color.Transparent;
            this.txt_cuit_cliente.Enabled = false;
            this.txt_cuit_cliente.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_cuit_cliente.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_cuit_cliente.Location = new System.Drawing.Point(-1, 77);
            this.txt_cuit_cliente.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cuit_cliente.Name = "txt_cuit_cliente";
            this.txt_cuit_cliente.Size = new System.Drawing.Size(262, 30);
            this.txt_cuit_cliente.TabIndex = 33;
            // 
            // txt_id_cliente
            // 
            this.txt_id_cliente._Ancho = 4;
            this.txt_id_cliente._Decimales = 0;
            this.txt_id_cliente._Etiqueta = "Id_Cliente";
            this.txt_id_cliente._Mask = "9999";
            this.txt_id_cliente._MensajeError = "Debe ingresar CUIT del cliente";
            this.txt_id_cliente._Nombre_campo = "id_cliente";
            this.txt_id_cliente._Nombre_tabla = null;
            this.txt_id_cliente._ReadOnly = false;
            this.txt_id_cliente._Text = "";
            this.txt_id_cliente._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_id_cliente._TipoDato = CLASE05.Clases.LabelText02.TipoDato.numero;
            this.txt_id_cliente._Validable = true;
            this.txt_id_cliente.BackColor = System.Drawing.Color.Transparent;
            this.txt_id_cliente.Enabled = false;
            this.txt_id_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_cliente.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_id_cliente.Location = new System.Drawing.Point(5, 41);
            this.txt_id_cliente.Margin = new System.Windows.Forms.Padding(4);
            this.txt_id_cliente.Name = "txt_id_cliente";
            this.txt_id_cliente.Size = new System.Drawing.Size(226, 28);
            this.txt_id_cliente.TabIndex = 32;
            // 
            // aceptar_baja
            // 
            this.aceptar_baja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.aceptar_baja.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold);
            this.aceptar_baja.ForeColor = System.Drawing.Color.Gainsboro;
            this.aceptar_baja.Location = new System.Drawing.Point(166, 284);
            this.aceptar_baja.Name = "aceptar_baja";
            this.aceptar_baja.Size = new System.Drawing.Size(95, 31);
            this.aceptar_baja.TabIndex = 31;
            this.aceptar_baja.Text = "Borrar";
            this.aceptar_baja.UseVisualStyleBackColor = false;
            this.aceptar_baja.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_ciudad_cliente
            // 
            this.txt_ciudad_cliente._Ancho = 30;
            this.txt_ciudad_cliente._Decimales = 2;
            this.txt_ciudad_cliente._Etiqueta = "Cuidad";
            this.txt_ciudad_cliente._Mask = "CCCCCCCCCCCCCCCCCCCCCCCCCCCCCC";
            this.txt_ciudad_cliente._MensajeError = "El nombre del usuario está vácio";
            this.txt_ciudad_cliente._Nombre_campo = "cuidad_cliente";
            this.txt_ciudad_cliente._Nombre_tabla = null;
            this.txt_ciudad_cliente._ReadOnly = false;
            this.txt_ciudad_cliente._Text = "";
            this.txt_ciudad_cliente._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_ciudad_cliente._TipoDato = CLASE05.Clases.LabelText02.TipoDato.texto;
            this.txt_ciudad_cliente._Validable = true;
            this.txt_ciudad_cliente.BackColor = System.Drawing.Color.Transparent;
            this.txt_ciudad_cliente.Enabled = false;
            this.txt_ciudad_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ciudad_cliente.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_ciudad_cliente.Location = new System.Drawing.Point(4, 225);
            this.txt_ciudad_cliente.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ciudad_cliente.Name = "txt_ciudad_cliente";
            this.txt_ciudad_cliente.Size = new System.Drawing.Size(353, 43);
            this.txt_ciudad_cliente.TabIndex = 30;
            // 
            // txt_direccion_cliente
            // 
            this.txt_direccion_cliente._Ancho = 30;
            this.txt_direccion_cliente._Decimales = 2;
            this.txt_direccion_cliente._Etiqueta = "Direccion";
            this.txt_direccion_cliente._Mask = "CCCCCCCCCCCCCCCCCCCCCCCCCCCCCC";
            this.txt_direccion_cliente._MensajeError = "El nombre del usuario está vácio";
            this.txt_direccion_cliente._Nombre_campo = "direccion_cliente";
            this.txt_direccion_cliente._Nombre_tabla = null;
            this.txt_direccion_cliente._ReadOnly = false;
            this.txt_direccion_cliente._Text = "";
            this.txt_direccion_cliente._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_direccion_cliente._TipoDato = CLASE05.Clases.LabelText02.TipoDato.texto;
            this.txt_direccion_cliente._Validable = true;
            this.txt_direccion_cliente.BackColor = System.Drawing.Color.Transparent;
            this.txt_direccion_cliente.Enabled = false;
            this.txt_direccion_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_direccion_cliente.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_direccion_cliente.Location = new System.Drawing.Point(4, 187);
            this.txt_direccion_cliente.Margin = new System.Windows.Forms.Padding(4);
            this.txt_direccion_cliente.Name = "txt_direccion_cliente";
            this.txt_direccion_cliente.Size = new System.Drawing.Size(353, 81);
            this.txt_direccion_cliente.TabIndex = 29;
            // 
            // txt_razon_social
            // 
            this.txt_razon_social._Ancho = 30;
            this.txt_razon_social._Decimales = 2;
            this.txt_razon_social._Etiqueta = "Razon Social";
            this.txt_razon_social._Mask = "CCCCCCCCCCCCCCCCCCCCCCCCCCCCCC";
            this.txt_razon_social._MensajeError = "El nombre del usuario está vácio";
            this.txt_razon_social._Nombre_campo = "razon_social";
            this.txt_razon_social._Nombre_tabla = null;
            this.txt_razon_social._ReadOnly = false;
            this.txt_razon_social._Text = "";
            this.txt_razon_social._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_razon_social._TipoDato = CLASE05.Clases.LabelText02.TipoDato.texto;
            this.txt_razon_social._Validable = true;
            this.txt_razon_social.BackColor = System.Drawing.Color.Transparent;
            this.txt_razon_social.Enabled = false;
            this.txt_razon_social.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_razon_social.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_razon_social.Location = new System.Drawing.Point(4, 113);
            this.txt_razon_social.Margin = new System.Windows.Forms.Padding(4);
            this.txt_razon_social.Name = "txt_razon_social";
            this.txt_razon_social.Size = new System.Drawing.Size(353, 38);
            this.txt_razon_social.TabIndex = 28;
            // 
            // nombre_cliente
            // 
            this.nombre_cliente._Ancho = 30;
            this.nombre_cliente._Decimales = 2;
            this.nombre_cliente._Etiqueta = "Nombre ";
            this.nombre_cliente._Mask = "CCCCCCCCCCCCCCCCCCCCCCCCCCCCCC";
            this.nombre_cliente._MensajeError = "El nombre del usuario está vácio";
            this.nombre_cliente._Nombre_campo = "n_usuario";
            this.nombre_cliente._Nombre_tabla = null;
            this.nombre_cliente._ReadOnly = false;
            this.nombre_cliente._Text = "";
            this.nombre_cliente._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.nombre_cliente._TipoDato = CLASE05.Clases.LabelText02.TipoDato.texto;
            this.nombre_cliente._Validable = true;
            this.nombre_cliente.BackColor = System.Drawing.Color.Transparent;
            this.nombre_cliente.Enabled = false;
            this.nombre_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre_cliente.ForeColor = System.Drawing.Color.Gainsboro;
            this.nombre_cliente.Location = new System.Drawing.Point(4, 148);
            this.nombre_cliente.Margin = new System.Windows.Forms.Padding(4);
            this.nombre_cliente.Name = "nombre_cliente";
            this.nombre_cliente.Size = new System.Drawing.Size(353, 31);
            this.nombre_cliente.TabIndex = 27;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btn_aceptar.Enabled = false;
            this.btn_aceptar.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_aceptar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_aceptar.Location = new System.Drawing.Point(133, 228);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(95, 31);
            this.btn_aceptar.TabIndex = 22;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = false;
            // 
            // Frm_Baja_tipoDocumento
            // 
            this._PosiciónVisible = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(432, 508);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_titulo);
            this.Name = "Frm_Baja_tipoDocumento";
            this.Text = "Frm_Baja_tipoDocumento";
            this.Load += new System.EventHandler(this.Frm_Baja_tipoDocumento_Load);
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
        public System.Windows.Forms.Button btn_aceptar;
        public Clases.LabelText02 txt_ciudad_cliente;
        public Clases.LabelText02 txt_direccion_cliente;
        public Clases.LabelText02 txt_razon_social;
        public Clases.LabelText02 nombre_cliente;
        public System.Windows.Forms.Button aceptar_baja;
        public Clases.LabelText02 txt_id_cliente;
        private Clases.LabelText02 txt_cuit_cliente;
    }
}