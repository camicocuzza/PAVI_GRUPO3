
namespace CLASE05.Formularios.Cliente
{
    partial class Frm_Validar_Cliente
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
            this.txt_id_cliente = new CLASE05.Clases.LabelText02();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.txt_ciudad = new CLASE05.Clases.LabelText02();
            this.txt_direccion = new CLASE05.Clases.LabelText02();
            this.txt_razon_social = new CLASE05.Clases.LabelText02();
            this.txt_cuil = new CLASE05.Clases.LabelText02();
            this.txt_nombre_cliente = new CLASE05.Clases.LabelText02();
            this.button2 = new System.Windows.Forms.Button();
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
            this.panel1.Controls.Add(this.txt_id_cliente);
            this.panel1.Controls.Add(this.btn_modificar);
            this.panel1.Controls.Add(this.txt_ciudad);
            this.panel1.Controls.Add(this.txt_direccion);
            this.panel1.Controls.Add(this.txt_razon_social);
            this.panel1.Controls.Add(this.txt_cuil);
            this.panel1.Controls.Add(this.txt_nombre_cliente);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(18, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(397, 339);
            this.panel1.TabIndex = 38;
            // 
            // txt_id_cliente
            // 
            this.txt_id_cliente._Ancho = 4;
            this.txt_id_cliente._Decimales = 0;
            this.txt_id_cliente._Etiqueta = "Id_Cliente";
            this.txt_id_cliente._Mask = "9999";
            this.txt_id_cliente._MensajeError = "Debe ingresar CUIT del cliente";
            this.txt_id_cliente._Nombre_campo = "cuit_cliente";
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
            this.txt_id_cliente.Location = new System.Drawing.Point(-6, 21);
            this.txt_id_cliente.Margin = new System.Windows.Forms.Padding(4);
            this.txt_id_cliente.Name = "txt_id_cliente";
            this.txt_id_cliente.Size = new System.Drawing.Size(226, 28);
            this.txt_id_cliente.TabIndex = 46;
            // 
            // btn_modificar
            // 
            this.btn_modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btn_modificar.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_modificar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_modificar.Location = new System.Drawing.Point(156, 264);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(95, 31);
            this.btn_modificar.TabIndex = 45;
            this.btn_modificar.Text = "Aceptar";
            this.btn_modificar.UseVisualStyleBackColor = false;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // txt_ciudad
            // 
            this.txt_ciudad._Ancho = 30;
            this.txt_ciudad._Decimales = 2;
            this.txt_ciudad._Etiqueta = "Cuidad";
            this.txt_ciudad._Mask = "CCCCCCCCCCCCCCCCCCCCCCCCCCCCCC";
            this.txt_ciudad._MensajeError = "El nombre del usuario está vácio";
            this.txt_ciudad._Nombre_campo = "cuidad_cliente";
            this.txt_ciudad._Nombre_tabla = null;
            this.txt_ciudad._ReadOnly = false;
            this.txt_ciudad._Text = "";
            this.txt_ciudad._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_ciudad._TipoDato = CLASE05.Clases.LabelText02.TipoDato.texto;
            this.txt_ciudad._Validable = true;
            this.txt_ciudad.BackColor = System.Drawing.Color.Transparent;
            this.txt_ciudad.Enabled = false;
            this.txt_ciudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ciudad.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_ciudad.Location = new System.Drawing.Point(-6, 205);
            this.txt_ciudad.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ciudad.Name = "txt_ciudad";
            this.txt_ciudad.Size = new System.Drawing.Size(353, 43);
            this.txt_ciudad.TabIndex = 44;
            // 
            // txt_direccion
            // 
            this.txt_direccion._Ancho = 30;
            this.txt_direccion._Decimales = 2;
            this.txt_direccion._Etiqueta = "Direccion";
            this.txt_direccion._Mask = "CCCCCCCCCCCCCCCCCCCCCCCCCCCCCC";
            this.txt_direccion._MensajeError = "El nombre del usuario está vácio";
            this.txt_direccion._Nombre_campo = "direccion_cliente";
            this.txt_direccion._Nombre_tabla = null;
            this.txt_direccion._ReadOnly = false;
            this.txt_direccion._Text = "";
            this.txt_direccion._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_direccion._TipoDato = CLASE05.Clases.LabelText02.TipoDato.texto;
            this.txt_direccion._Validable = true;
            this.txt_direccion.BackColor = System.Drawing.Color.Transparent;
            this.txt_direccion.Enabled = false;
            this.txt_direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_direccion.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_direccion.Location = new System.Drawing.Point(-6, 167);
            this.txt_direccion.Margin = new System.Windows.Forms.Padding(4);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(353, 81);
            this.txt_direccion.TabIndex = 43;
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
            this.txt_razon_social.Location = new System.Drawing.Point(-8, 93);
            this.txt_razon_social.Margin = new System.Windows.Forms.Padding(4);
            this.txt_razon_social.Name = "txt_razon_social";
            this.txt_razon_social.Size = new System.Drawing.Size(353, 35);
            this.txt_razon_social.TabIndex = 42;
            // 
            // txt_cuil
            // 
            this.txt_cuil._Ancho = 11;
            this.txt_cuil._Decimales = 2;
            this.txt_cuil._Etiqueta = "CUIT";
            this.txt_cuil._Mask = "99-999999999-9";
            this.txt_cuil._MensajeError = null;
            this.txt_cuil._Nombre_campo = "cuit_cliente";
            this.txt_cuil._Nombre_tabla = null;
            this.txt_cuil._ReadOnly = false;
            this.txt_cuil._Text = "  -         -";
            this.txt_cuil._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_cuil._TipoDato = CLASE05.Clases.LabelText02.TipoDato.mascaraEditada;
            this.txt_cuil._Validable = false;
            this.txt_cuil.BackColor = System.Drawing.Color.Transparent;
            this.txt_cuil.Enabled = false;
            this.txt_cuil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cuil.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_cuil.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_cuil.Location = new System.Drawing.Point(-6, 57);
            this.txt_cuil.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cuil.Name = "txt_cuil";
            this.txt_cuil.Size = new System.Drawing.Size(274, 28);
            this.txt_cuil.TabIndex = 40;
            // 
            // txt_nombre_cliente
            // 
            this.txt_nombre_cliente._Ancho = 30;
            this.txt_nombre_cliente._Decimales = 2;
            this.txt_nombre_cliente._Etiqueta = "Nombre ";
            this.txt_nombre_cliente._Mask = "CCCCCCCCCCCCCCCCCCCCCCCCCCCCCC";
            this.txt_nombre_cliente._MensajeError = "El nombre del usuario está vácio";
            this.txt_nombre_cliente._Nombre_campo = "n_usuario";
            this.txt_nombre_cliente._Nombre_tabla = null;
            this.txt_nombre_cliente._ReadOnly = false;
            this.txt_nombre_cliente._Text = "";
            this.txt_nombre_cliente._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_nombre_cliente._TipoDato = CLASE05.Clases.LabelText02.TipoDato.texto;
            this.txt_nombre_cliente._Validable = true;
            this.txt_nombre_cliente.BackColor = System.Drawing.Color.Transparent;
            this.txt_nombre_cliente.Enabled = false;
            this.txt_nombre_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre_cliente.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_nombre_cliente.Location = new System.Drawing.Point(-8, 127);
            this.txt_nombre_cliente.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nombre_cliente.Name = "txt_nombre_cliente";
            this.txt_nombre_cliente.Size = new System.Drawing.Size(353, 32);
            this.txt_nombre_cliente.TabIndex = 41;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.Gainsboro;
            this.button2.Location = new System.Drawing.Point(123, 208);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 31);
            this.button2.TabIndex = 39;
            this.button2.Text = "Aceptar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_titulo.ForeColor = System.Drawing.Color.White;
            this.lbl_titulo.Location = new System.Drawing.Point(32, 49);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(212, 31);
            this.lbl_titulo.TabIndex = 37;
            this.lbl_titulo.Text = "Consultar Cliente";
            // 
            // Frm_Validar_Cliente
            // 
            this._PosiciónVisible = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(432, 477);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_titulo);
            this.Name = "Frm_Validar_Cliente";
            this.Text = "Frm_Validar_Cliente";
            this.Load += new System.EventHandler(this.Frm_Validar_Cliente_Load);
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
        public Clases.LabelText02 txt_id_cliente;
        public System.Windows.Forms.Button btn_modificar;
        public Clases.LabelText02 txt_ciudad;
        public Clases.LabelText02 txt_direccion;
        public Clases.LabelText02 txt_razon_social;
        public Clases.LabelText02 txt_cuil;
        public Clases.LabelText02 txt_nombre_cliente;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Label lbl_titulo;
    }
}