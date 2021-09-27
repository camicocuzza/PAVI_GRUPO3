
namespace CLASE05.Formularios.Empleado
{
    partial class Frm_Empleado_Modificar
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
            this.txt_documento = new CLASE05.Clases.LabelText02();
            this.txt_puesto = new CLASE05.Clases.LabelText02();
            this.txt_fecha_ingreso = new CLASE05.Clases.LabelText02();
            this.txt_telefono = new CLASE05.Clases.LabelText02();
            this.txt_apellido = new CLASE05.Clases.LabelText02();
            this.txt_legajo = new CLASE05.Clases.LabelText02();
            this.txt_direccion = new CLASE05.Clases.LabelText02();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.lbl_titulo = new System.Windows.Forms.Label();
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
            this.btn_maximizar.Location = new System.Drawing.Point(383, 2);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txt_documento);
            this.panel1.Controls.Add(this.txt_puesto);
            this.panel1.Controls.Add(this.txt_fecha_ingreso);
            this.panel1.Controls.Add(this.txt_telefono);
            this.panel1.Controls.Add(this.txt_apellido);
            this.panel1.Controls.Add(this.txt_legajo);
            this.panel1.Controls.Add(this.txt_direccion);
            this.panel1.Controls.Add(this.btn_aceptar);
            this.panel1.Location = new System.Drawing.Point(29, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(397, 367);
            this.panel1.TabIndex = 34;
            // 
            // txt_documento
            // 
            this.txt_documento._Ancho = 30;
            this.txt_documento._Decimales = 2;
            this.txt_documento._Etiqueta = "Documento";
            this.txt_documento._Mask = "CCCCCCCCCCCCCCCCCCCCCCCCCCCCCC";
            this.txt_documento._MensajeError = "Debe ingresar la Direccion del cliente";
            this.txt_documento._Nombre_campo = "direccion_cliente";
            this.txt_documento._Nombre_tabla = null;
            this.txt_documento._ReadOnly = false;
            this.txt_documento._Text = "";
            this.txt_documento._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_documento._TipoDato = CLASE05.Clases.LabelText02.TipoDato.texto;
            this.txt_documento._Validable = true;
            this.txt_documento.BackColor = System.Drawing.Color.Transparent;
            this.txt_documento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_documento.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_documento.Location = new System.Drawing.Point(-3, 145);
            this.txt_documento.Margin = new System.Windows.Forms.Padding(4);
            this.txt_documento.Name = "txt_documento";
            this.txt_documento.Size = new System.Drawing.Size(353, 30);
            this.txt_documento.TabIndex = 27;
            // 
            // txt_puesto
            // 
            this.txt_puesto._Ancho = 30;
            this.txt_puesto._Decimales = 2;
            this.txt_puesto._Etiqueta = "Puesto";
            this.txt_puesto._Mask = "CCCCCCCCCCCCCCCCCCCCCCCCCCCCCC";
            this.txt_puesto._MensajeError = "Debe ingresar el nombre del cliente.";
            this.txt_puesto._Nombre_campo = "n_cliente";
            this.txt_puesto._Nombre_tabla = null;
            this.txt_puesto._ReadOnly = false;
            this.txt_puesto._Text = "";
            this.txt_puesto._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_puesto._TipoDato = CLASE05.Clases.LabelText02.TipoDato.texto;
            this.txt_puesto._Validable = true;
            this.txt_puesto.BackColor = System.Drawing.Color.Transparent;
            this.txt_puesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_puesto.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_puesto.Location = new System.Drawing.Point(-3, 251);
            this.txt_puesto.Margin = new System.Windows.Forms.Padding(4);
            this.txt_puesto.Name = "txt_puesto";
            this.txt_puesto.Size = new System.Drawing.Size(353, 33);
            this.txt_puesto.TabIndex = 26;
            // 
            // txt_fecha_ingreso
            // 
            this.txt_fecha_ingreso._Ancho = 30;
            this.txt_fecha_ingreso._Decimales = 2;
            this.txt_fecha_ingreso._Etiqueta = "Fecha Ingreso";
            this.txt_fecha_ingreso._Mask = "00/00/0000";
            this.txt_fecha_ingreso._MensajeError = "Debe ingresar la Cuidad del cliente.";
            this.txt_fecha_ingreso._Nombre_campo = "cuidad_cliente";
            this.txt_fecha_ingreso._Nombre_tabla = null;
            this.txt_fecha_ingreso._ReadOnly = false;
            this.txt_fecha_ingreso._Text = "  /  /";
            this.txt_fecha_ingreso._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_fecha_ingreso._TipoDato = CLASE05.Clases.LabelText02.TipoDato.fecha;
            this.txt_fecha_ingreso._Validable = true;
            this.txt_fecha_ingreso.BackColor = System.Drawing.Color.Transparent;
            this.txt_fecha_ingreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fecha_ingreso.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_fecha_ingreso.Location = new System.Drawing.Point(-1, 215);
            this.txt_fecha_ingreso.Margin = new System.Windows.Forms.Padding(4);
            this.txt_fecha_ingreso.Name = "txt_fecha_ingreso";
            this.txt_fecha_ingreso.Size = new System.Drawing.Size(220, 28);
            this.txt_fecha_ingreso.TabIndex = 25;
            // 
            // txt_telefono
            // 
            this.txt_telefono._Ancho = 30;
            this.txt_telefono._Decimales = 2;
            this.txt_telefono._Etiqueta = "Telefono";
            this.txt_telefono._Mask = "CCCCCCCCCCCCCCCCCCCCCCCCCCCCCC";
            this.txt_telefono._MensajeError = "Debe ingresar la Direccion del cliente";
            this.txt_telefono._Nombre_campo = "direccion_cliente";
            this.txt_telefono._Nombre_tabla = null;
            this.txt_telefono._ReadOnly = false;
            this.txt_telefono._Text = "";
            this.txt_telefono._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_telefono._TipoDato = CLASE05.Clases.LabelText02.TipoDato.texto;
            this.txt_telefono._Validable = true;
            this.txt_telefono.BackColor = System.Drawing.Color.Transparent;
            this.txt_telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telefono.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_telefono.Location = new System.Drawing.Point(-1, 177);
            this.txt_telefono.Margin = new System.Windows.Forms.Padding(4);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(353, 30);
            this.txt_telefono.TabIndex = 24;
            // 
            // txt_apellido
            // 
            this.txt_apellido._Ancho = 30;
            this.txt_apellido._Decimales = 2;
            this.txt_apellido._Etiqueta = "Apellido";
            this.txt_apellido._Mask = "CCCCCCCCCCCCCCCCCCCCCCCCCCCCCC";
            this.txt_apellido._MensajeError = "Debe ingresar la Razon Social del cliente.";
            this.txt_apellido._Nombre_campo = "";
            this.txt_apellido._Nombre_tabla = null;
            this.txt_apellido._ReadOnly = false;
            this.txt_apellido._Text = "";
            this.txt_apellido._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_apellido._TipoDato = CLASE05.Clases.LabelText02.TipoDato.texto;
            this.txt_apellido._Validable = true;
            this.txt_apellido.BackColor = System.Drawing.Color.Transparent;
            this.txt_apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_apellido.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_apellido.Location = new System.Drawing.Point(-3, 71);
            this.txt_apellido.Margin = new System.Windows.Forms.Padding(4);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(353, 33);
            this.txt_apellido.TabIndex = 23;
            // 
            // txt_legajo
            // 
            this.txt_legajo._Ancho = 4;
            this.txt_legajo._Decimales = 0;
            this.txt_legajo._Etiqueta = "Legajo";
            this.txt_legajo._Mask = "9999";
            this.txt_legajo._MensajeError = "Debe ingresar CUIT del cliente";
            this.txt_legajo._Nombre_campo = "cuit_cliente";
            this.txt_legajo._Nombre_tabla = null;
            this.txt_legajo._ReadOnly = false;
            this.txt_legajo._Text = "";
            this.txt_legajo._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_legajo._TipoDato = CLASE05.Clases.LabelText02.TipoDato.numero;
            this.txt_legajo._Validable = true;
            this.txt_legajo.BackColor = System.Drawing.Color.Transparent;
            this.txt_legajo.Enabled = false;
            this.txt_legajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_legajo.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_legajo.Location = new System.Drawing.Point(-3, 35);
            this.txt_legajo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_legajo.Name = "txt_legajo";
            this.txt_legajo.Size = new System.Drawing.Size(222, 28);
            this.txt_legajo.TabIndex = 13;
            // 
            // txt_direccion
            // 
            this.txt_direccion._Ancho = 30;
            this.txt_direccion._Decimales = 2;
            this.txt_direccion._Etiqueta = "Direccion";
            this.txt_direccion._Mask = "CCCCCCCCCCCCCCCCCCCCCCCCCCCCCC";
            this.txt_direccion._MensajeError = "Debe ingresar el nombre del cliente.";
            this.txt_direccion._Nombre_campo = "n_cliente";
            this.txt_direccion._Nombre_tabla = null;
            this.txt_direccion._ReadOnly = false;
            this.txt_direccion._Text = "";
            this.txt_direccion._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_direccion._TipoDato = CLASE05.Clases.LabelText02.TipoDato.texto;
            this.txt_direccion._Validable = true;
            this.txt_direccion.BackColor = System.Drawing.Color.Transparent;
            this.txt_direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_direccion.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_direccion.Location = new System.Drawing.Point(-1, 104);
            this.txt_direccion.Margin = new System.Windows.Forms.Padding(4);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(353, 33);
            this.txt_direccion.TabIndex = 14;
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
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_titulo.ForeColor = System.Drawing.Color.White;
            this.lbl_titulo.Location = new System.Drawing.Point(40, 63);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(249, 31);
            this.lbl_titulo.TabIndex = 33;
            this.lbl_titulo.Text = "Modificar Empleado";
            // 
            // Frm_Empleado_Modificar
            // 
            this._PosiciónVisible = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(455, 527);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_titulo);
            this.Name = "Frm_Empleado_Modificar";
            this.Text = "Frm_Empleado_Modificar";
            this.Load += new System.EventHandler(this.Frm_Empleado_Modificar_Load);
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
        public Clases.LabelText02 txt_documento;
        public Clases.LabelText02 txt_puesto;
        public Clases.LabelText02 txt_fecha_ingreso;
        public Clases.LabelText02 txt_telefono;
        public Clases.LabelText02 txt_apellido;
        public Clases.LabelText02 txt_legajo;
        public Clases.LabelText02 txt_direccion;
        public System.Windows.Forms.Button btn_aceptar;
        public System.Windows.Forms.Label lbl_titulo;
    }
}