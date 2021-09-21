
namespace CLASE05.Formularios.Compra
{
    partial class Frm_Alta_Compra
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
            this.txt_id_compra = new CLASE05.Clases.LabelText02();
            this.txt_n_compra = new CLASE05.Clases.LabelText02();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.txt_fecha = new CLASE05.Clases.LabelText02();
            this.monto_compra = new CLASE05.Clases.LabelText02();
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
            this.panel1.Controls.Add(this.monto_compra);
            this.panel1.Controls.Add(this.txt_fecha);
            this.panel1.Controls.Add(this.txt_id_compra);
            this.panel1.Controls.Add(this.txt_n_compra);
            this.panel1.Controls.Add(this.btn_aceptar);
            this.panel1.Location = new System.Drawing.Point(14, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 288);
            this.panel1.TabIndex = 32;
            // 
            // txt_id_compra
            // 
            this.txt_id_compra._Ancho = 2;
            this.txt_id_compra._Decimales = 0;
            this.txt_id_compra._Etiqueta = "Numero de compra";
            this.txt_id_compra._Mask = "99";
            this.txt_id_compra._MensajeError = null;
            this.txt_id_compra._Nombre_campo = "id_compra";
            this.txt_id_compra._Nombre_tabla = null;
            this.txt_id_compra._ReadOnly = false;
            this.txt_id_compra._Text = "";
            this.txt_id_compra._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_id_compra._TipoDato = CLASE05.Clases.LabelText02.TipoDato.numero;
            this.txt_id_compra._Validable = false;
            this.txt_id_compra.BackColor = System.Drawing.Color.Transparent;
            this.txt_id_compra.Enabled = false;
            this.txt_id_compra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_compra.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_id_compra.Location = new System.Drawing.Point(0, 44);
            this.txt_id_compra.Margin = new System.Windows.Forms.Padding(4);
            this.txt_id_compra.Name = "txt_id_compra";
            this.txt_id_compra.Size = new System.Drawing.Size(353, 28);
            this.txt_id_compra.TabIndex = 13;
            // 
            // txt_n_compra
            // 
            this.txt_n_compra._Ancho = 30;
            this.txt_n_compra._Decimales = 0;
            this.txt_n_compra._Etiqueta = "Cuit de Provedor";
            this.txt_n_compra._Mask = "999999999999999999999999999.99";
            this.txt_n_compra._MensajeError = "El CUIT de la compra está vácia";
            this.txt_n_compra._Nombre_campo = "n_compra";
            this.txt_n_compra._Nombre_tabla = null;
            this.txt_n_compra._ReadOnly = false;
            this.txt_n_compra._Text = "                           .";
            this.txt_n_compra._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_n_compra._TipoDato = CLASE05.Clases.LabelText02.TipoDato.numero;
            this.txt_n_compra._Validable = true;
            this.txt_n_compra.BackColor = System.Drawing.Color.Transparent;
            this.txt_n_compra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_n_compra.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_n_compra.Location = new System.Drawing.Point(0, 80);
            this.txt_n_compra.Margin = new System.Windows.Forms.Padding(4);
            this.txt_n_compra.Name = "txt_n_compra";
            this.txt_n_compra.Size = new System.Drawing.Size(353, 53);
            this.txt_n_compra.TabIndex = 14;
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
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_titulo.ForeColor = System.Drawing.Color.White;
            this.lbl_titulo.Location = new System.Drawing.Point(9, 25);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(205, 31);
            this.lbl_titulo.TabIndex = 31;
            this.lbl_titulo.Text = "Altas de Compra";
            // 
            // txt_fecha
            // 
            this.txt_fecha._Ancho = 30;
            this.txt_fecha._Decimales = 2;
            this.txt_fecha._Etiqueta = "fecha";
            this.txt_fecha._Mask = "00/00/0000";
            this.txt_fecha._MensajeError = "la fecha está vácia";
            this.txt_fecha._Nombre_campo = "fecha_compra";
            this.txt_fecha._Nombre_tabla = null;
            this.txt_fecha._ReadOnly = false;
            this.txt_fecha._Text = "  /  /";
            this.txt_fecha._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_fecha._TipoDato = CLASE05.Clases.LabelText02.TipoDato.fecha;
            this.txt_fecha._Validable = true;
            this.txt_fecha.BackColor = System.Drawing.Color.Transparent;
            this.txt_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fecha.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_fecha.Location = new System.Drawing.Point(0, 119);
            this.txt_fecha.Margin = new System.Windows.Forms.Padding(4);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.Size = new System.Drawing.Size(353, 53);
            this.txt_fecha.TabIndex = 23;
            // 
            // monto_compra
            // 
            this.monto_compra._Ancho = 30;
            this.monto_compra._Decimales = 0;
            this.monto_compra._Etiqueta = "Monto Total";
            this.monto_compra._Mask = "999999999999999999999999999999";
            this.monto_compra._MensajeError = "El monto de la compra está vácio";
            this.monto_compra._Nombre_campo = "monto_compra";
            this.monto_compra._Nombre_tabla = null;
            this.monto_compra._ReadOnly = false;
            this.monto_compra._Text = "";
            this.monto_compra._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.monto_compra._TipoDato = CLASE05.Clases.LabelText02.TipoDato.numero;
            this.monto_compra._Validable = true;
            this.monto_compra.BackColor = System.Drawing.Color.Transparent;
            this.monto_compra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monto_compra.ForeColor = System.Drawing.Color.Gainsboro;
            this.monto_compra.Location = new System.Drawing.Point(0, 159);
            this.monto_compra.Margin = new System.Windows.Forms.Padding(4);
            this.monto_compra.Name = "monto_compra";
            this.monto_compra.Size = new System.Drawing.Size(353, 53);
            this.monto_compra.TabIndex = 24;
            // 
            // Frm_Alta_Compra
            // 
            this._PosiciónVisible = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(432, 384);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_titulo);
            this.Name = "Frm_Alta_Compra";
            this.Text = "Frm_Alta_Compra";
            this.Load += new System.EventHandler(this.Frm_Alta_Compra_Load);
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
        public Clases.LabelText02 monto_compra;
        public Clases.LabelText02 txt_fecha;
        public Clases.LabelText02 txt_id_compra;
        public Clases.LabelText02 txt_n_compra;
        public System.Windows.Forms.Button btn_aceptar;
        public System.Windows.Forms.Label lbl_titulo;
    }
}