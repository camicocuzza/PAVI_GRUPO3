
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
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.labelText021 = new CLASE05.Clases.LabelText02();
            this.txt_password = new CLASE05.Clases.LabelText02();
            this.txt_id_usuario = new CLASE05.Clases.LabelText02();
            this.txt_n_usuario = new CLASE05.Clases.LabelText02();
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
            this.panel1.Controls.Add(this.labelText021);
            this.panel1.Controls.Add(this.txt_password);
            this.panel1.Controls.Add(this.txt_id_usuario);
            this.panel1.Controls.Add(this.txt_n_usuario);
            this.panel1.Controls.Add(this.btn_aceptar);
            this.panel1.Location = new System.Drawing.Point(11, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 288);
            this.panel1.TabIndex = 28;
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
            // labelText021
            // 
            this.labelText021._Ancho = 10;
            this.labelText021._Decimales = 2;
            this.labelText021._Etiqueta = "Fecha de Compra";
            this.labelText021._Mask = "CCCCCCCCCC";
            this.labelText021._MensajeError = "El password esta vácio";
            this.labelText021._Nombre_campo = null;
            this.labelText021._Nombre_tabla = null;
            this.labelText021._ReadOnly = false;
            this.labelText021._Text = "";
            this.labelText021._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.labelText021._TipoDato = CLASE05.Clases.LabelText02.TipoDato.texto;
            this.labelText021._Validable = true;
            this.labelText021.BackColor = System.Drawing.Color.Transparent;
            this.labelText021.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelText021.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelText021.Location = new System.Drawing.Point(7, 157);
            this.labelText021.Margin = new System.Windows.Forms.Padding(4);
            this.labelText021.Name = "labelText021";
            this.labelText021.Size = new System.Drawing.Size(257, 53);
            this.labelText021.TabIndex = 27;
            // 
            // txt_password
            // 
            this.txt_password._Ancho = 10;
            this.txt_password._Decimales = 2;
            this.txt_password._Etiqueta = "Nombre";
            this.txt_password._Mask = "CCCCCCCCCC";
            this.txt_password._MensajeError = "El password esta vácio";
            this.txt_password._Nombre_campo = null;
            this.txt_password._Nombre_tabla = null;
            this.txt_password._ReadOnly = false;
            this.txt_password._Text = "";
            this.txt_password._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_password._TipoDato = CLASE05.Clases.LabelText02.TipoDato.texto;
            this.txt_password._Validable = true;
            this.txt_password.BackColor = System.Drawing.Color.Transparent;
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_password.Location = new System.Drawing.Point(7, 115);
            this.txt_password.Margin = new System.Windows.Forms.Padding(4);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(257, 53);
            this.txt_password.TabIndex = 26;
            // 
            // txt_id_usuario
            // 
            this.txt_id_usuario._Ancho = 2;
            this.txt_id_usuario._Decimales = 0;
            this.txt_id_usuario._Etiqueta = "Nro de Lote";
            this.txt_id_usuario._Mask = "99";
            this.txt_id_usuario._MensajeError = null;
            this.txt_id_usuario._Nombre_campo = "id_usuario";
            this.txt_id_usuario._Nombre_tabla = null;
            this.txt_id_usuario._ReadOnly = false;
            this.txt_id_usuario._Text = "";
            this.txt_id_usuario._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_id_usuario._TipoDato = CLASE05.Clases.LabelText02.TipoDato.numero;
            this.txt_id_usuario._Validable = false;
            this.txt_id_usuario.BackColor = System.Drawing.Color.Transparent;
            this.txt_id_usuario.Enabled = false;
            this.txt_id_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_usuario.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_id_usuario.Location = new System.Drawing.Point(7, 40);
            this.txt_id_usuario.Margin = new System.Windows.Forms.Padding(4);
            this.txt_id_usuario.Name = "txt_id_usuario";
            this.txt_id_usuario.Size = new System.Drawing.Size(257, 28);
            this.txt_id_usuario.TabIndex = 24;
            // 
            // txt_n_usuario
            // 
            this.txt_n_usuario._Ancho = 30;
            this.txt_n_usuario._Decimales = 2;
            this.txt_n_usuario._Etiqueta = "Nro Remito  Proveedor";
            this.txt_n_usuario._Mask = "CCCCCCCCCCCCCCCCCCCCCCCCCCCCCC";
            this.txt_n_usuario._MensajeError = "El nombre del usuario está vácio";
            this.txt_n_usuario._Nombre_campo = "n_usuario";
            this.txt_n_usuario._Nombre_tabla = null;
            this.txt_n_usuario._ReadOnly = false;
            this.txt_n_usuario._Text = "";
            this.txt_n_usuario._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_n_usuario._TipoDato = CLASE05.Clases.LabelText02.TipoDato.texto;
            this.txt_n_usuario._Validable = true;
            this.txt_n_usuario.BackColor = System.Drawing.Color.Transparent;
            this.txt_n_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_n_usuario.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_n_usuario.Location = new System.Drawing.Point(7, 76);
            this.txt_n_usuario.Margin = new System.Windows.Forms.Padding(4);
            this.txt_n_usuario.Name = "txt_n_usuario";
            this.txt_n_usuario.Size = new System.Drawing.Size(257, 58);
            this.txt_n_usuario.TabIndex = 25;
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
        public Clases.LabelText02 labelText021;
        public Clases.LabelText02 txt_password;
        public Clases.LabelText02 txt_id_usuario;
        public Clases.LabelText02 txt_n_usuario;
    }
}