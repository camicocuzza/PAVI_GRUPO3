
namespace CLASE05.Formularios.TipoDocumento
{
    partial class Frm_Alta_tipoDocumento
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
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.txt_n_cliente = new CLASE05.Clases.LabelText02();
            this.txt_cuil = new CLASE05.Clases.LabelText02();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_id_cliente = new CLASE05.Clases.LabelText02();
            this.txt_ciudadCliente = new CLASE05.Clases.LabelText02();
            this.txt_direccionCliente = new CLASE05.Clases.LabelText02();
            this.txt_razonSocial = new CLASE05.Clases.LabelText02();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_cerrar.Location = new System.Drawing.Point(418, 2);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_minimizar.Location = new System.Drawing.Point(348, 2);
            // 
            // btn_maximizar
            // 
            this.btn_maximizar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_maximizar.Location = new System.Drawing.Point(389, 2);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_titulo.ForeColor = System.Drawing.Color.White;
            this.lbl_titulo.Location = new System.Drawing.Point(23, 48);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(148, 31);
            this.lbl_titulo.TabIndex = 28;
            this.lbl_titulo.Text = "Alta Cliente";
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btn_aceptar.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_aceptar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_aceptar.Location = new System.Drawing.Point(154, 291);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(95, 31);
            this.btn_aceptar.TabIndex = 22;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = false;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // txt_n_cliente
            // 
            this.txt_n_cliente._Ancho = 30;
            this.txt_n_cliente._Decimales = 2;
            this.txt_n_cliente._Etiqueta = "Nombre ";
            this.txt_n_cliente._Mask = "CCCCCCCCCCCCCCCCCCCCCCCCCCCCCC";
            this.txt_n_cliente._MensajeError = "Debe ingresar el nombre del cliente.";
            this.txt_n_cliente._Nombre_campo = "n_cliente";
            this.txt_n_cliente._Nombre_tabla = null;
            this.txt_n_cliente._ReadOnly = false;
            this.txt_n_cliente._Text = "";
            this.txt_n_cliente._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_n_cliente._TipoDato = CLASE05.Clases.LabelText02.TipoDato.texto;
            this.txt_n_cliente._Validable = true;
            this.txt_n_cliente.BackColor = System.Drawing.Color.Transparent;
            this.txt_n_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_n_cliente.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_n_cliente.Location = new System.Drawing.Point(1, 143);
            this.txt_n_cliente.Margin = new System.Windows.Forms.Padding(4);
            this.txt_n_cliente.Name = "txt_n_cliente";
            this.txt_n_cliente.Size = new System.Drawing.Size(353, 33);
            this.txt_n_cliente.TabIndex = 14;
            // 
            // txt_cuil
            // 
            this.txt_cuil._Ancho = 11;
            this.txt_cuil._Decimales = 2;
            this.txt_cuil._Etiqueta = "CUIT";
            this.txt_cuil._Mask = "99-9999999999-9";
            this.txt_cuil._MensajeError = "Debe ingresar CUIT del cliente";
            this.txt_cuil._Nombre_campo = "cuit_cliente";
            this.txt_cuil._Nombre_tabla = null;
            this.txt_cuil._ReadOnly = false;
            this.txt_cuil._Text = "  -          -";
            this.txt_cuil._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_cuil._TipoDato = CLASE05.Clases.LabelText02.TipoDato.mascaraEditada;
            this.txt_cuil._Validable = true;
            this.txt_cuil.BackColor = System.Drawing.Color.Transparent;
            this.txt_cuil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cuil.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_cuil.Location = new System.Drawing.Point(-1, 74);
            this.txt_cuil.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cuil.Name = "txt_cuil";
            this.txt_cuil.Size = new System.Drawing.Size(274, 28);
            this.txt_cuil.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txt_id_cliente);
            this.panel1.Controls.Add(this.txt_ciudadCliente);
            this.panel1.Controls.Add(this.txt_direccionCliente);
            this.panel1.Controls.Add(this.txt_razonSocial);
            this.panel1.Controls.Add(this.txt_cuil);
            this.panel1.Controls.Add(this.txt_n_cliente);
            this.panel1.Controls.Add(this.btn_aceptar);
            this.panel1.Location = new System.Drawing.Point(12, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(397, 367);
            this.panel1.TabIndex = 30;
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
            this.txt_id_cliente.AutoScroll = true;
            this.txt_id_cliente.BackColor = System.Drawing.Color.Transparent;
            this.txt_id_cliente.Enabled = false;
            this.txt_id_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_cliente.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_id_cliente.Location = new System.Drawing.Point(-3, 38);
            this.txt_id_cliente.Margin = new System.Windows.Forms.Padding(4);
            this.txt_id_cliente.Name = "txt_id_cliente";
            this.txt_id_cliente.Size = new System.Drawing.Size(226, 28);
            this.txt_id_cliente.TabIndex = 26;
            // 
            // txt_ciudadCliente
            // 
            this.txt_ciudadCliente._Ancho = 30;
            this.txt_ciudadCliente._Decimales = 2;
            this.txt_ciudadCliente._Etiqueta = "Cuidad";
            this.txt_ciudadCliente._Mask = "CCCCCCCCCCCCCCCCCCCCCCCCCCCCCC";
            this.txt_ciudadCliente._MensajeError = "Debe ingresar la Cuidad del cliente.";
            this.txt_ciudadCliente._Nombre_campo = "cuidad_cliente";
            this.txt_ciudadCliente._Nombre_tabla = null;
            this.txt_ciudadCliente._ReadOnly = false;
            this.txt_ciudadCliente._Text = "";
            this.txt_ciudadCliente._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_ciudadCliente._TipoDato = CLASE05.Clases.LabelText02.TipoDato.texto;
            this.txt_ciudadCliente._Validable = true;
            this.txt_ciudadCliente.BackColor = System.Drawing.Color.Transparent;
            this.txt_ciudadCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ciudadCliente.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_ciudadCliente.Location = new System.Drawing.Point(-1, 222);
            this.txt_ciudadCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ciudadCliente.Name = "txt_ciudadCliente";
            this.txt_ciudadCliente.Size = new System.Drawing.Size(353, 43);
            this.txt_ciudadCliente.TabIndex = 25;
            this.txt_ciudadCliente.Load += new System.EventHandler(this.labelText023_Load);
            // 
            // txt_direccionCliente
            // 
            this.txt_direccionCliente._Ancho = 30;
            this.txt_direccionCliente._Decimales = 2;
            this.txt_direccionCliente._Etiqueta = "Direccion";
            this.txt_direccionCliente._Mask = "CCCCCCCCCCCCCCCCCCCCCCCCCCCCCC";
            this.txt_direccionCliente._MensajeError = "Debe ingresar la Direccion del cliente";
            this.txt_direccionCliente._Nombre_campo = "direccion_cliente";
            this.txt_direccionCliente._Nombre_tabla = null;
            this.txt_direccionCliente._ReadOnly = false;
            this.txt_direccionCliente._Text = "";
            this.txt_direccionCliente._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_direccionCliente._TipoDato = CLASE05.Clases.LabelText02.TipoDato.texto;
            this.txt_direccionCliente._Validable = true;
            this.txt_direccionCliente.BackColor = System.Drawing.Color.Transparent;
            this.txt_direccionCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_direccionCliente.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_direccionCliente.Location = new System.Drawing.Point(-1, 184);
            this.txt_direccionCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txt_direccionCliente.Name = "txt_direccionCliente";
            this.txt_direccionCliente.Size = new System.Drawing.Size(353, 81);
            this.txt_direccionCliente.TabIndex = 24;
            // 
            // txt_razonSocial
            // 
            this.txt_razonSocial._Ancho = 30;
            this.txt_razonSocial._Decimales = 2;
            this.txt_razonSocial._Etiqueta = "Razon Social";
            this.txt_razonSocial._Mask = "CCCCCCCCCCCCCCCCCCCCCCCCCCCCCC";
            this.txt_razonSocial._MensajeError = "Debe ingresar la Razon Social del cliente.";
            this.txt_razonSocial._Nombre_campo = "";
            this.txt_razonSocial._Nombre_tabla = null;
            this.txt_razonSocial._ReadOnly = false;
            this.txt_razonSocial._Text = "";
            this.txt_razonSocial._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_razonSocial._TipoDato = CLASE05.Clases.LabelText02.TipoDato.texto;
            this.txt_razonSocial._Validable = true;
            this.txt_razonSocial.BackColor = System.Drawing.Color.Transparent;
            this.txt_razonSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_razonSocial.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_razonSocial.Location = new System.Drawing.Point(-1, 110);
            this.txt_razonSocial.Margin = new System.Windows.Forms.Padding(4);
            this.txt_razonSocial.Name = "txt_razonSocial";
            this.txt_razonSocial.Size = new System.Drawing.Size(353, 33);
            this.txt_razonSocial.TabIndex = 23;
            // 
            // Frm_Alta_tipoDocumento
            // 
            this._PosiciónVisible = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(455, 527);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_titulo);
            this.Name = "Frm_Alta_tipoDocumento";
            this.Text = "Frm_Alta_tipoDocumento";
            this.Load += new System.EventHandler(this.Frm_Alta_tipoDocumento_Load);
            this.Controls.SetChildIndex(this.lbl_titulo, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.btn_cerrar, 0);
            this.Controls.SetChildIndex(this.btn_maximizar, 0);
            this.Controls.SetChildIndex(this.btn_minimizar, 0);
            this.Controls.SetChildIndex(this.lbl_posicion, 0);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbl_titulo;
        public System.Windows.Forms.Button btn_aceptar;
        public Clases.LabelText02 txt_n_cliente;
        public Clases.LabelText02 txt_cuil;
        public System.Windows.Forms.Panel panel1;
        public Clases.LabelText02 txt_ciudadCliente;
        public Clases.LabelText02 txt_direccionCliente;
        public Clases.LabelText02 txt_razonSocial;
        public Clases.LabelText02 txt_id_cliente;
    }
}