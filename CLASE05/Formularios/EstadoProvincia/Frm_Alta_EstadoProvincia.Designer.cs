﻿
namespace CLASE05.Formularios.EstadoProvincia
{
    partial class Frm_Alta_EstadoProvincia
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
            this.txt_id_cliente = new CLASE05.Clases.LabelText02();
            this.txt_provincia = new CLASE05.Clases.LabelText02();
            this.txt_estado = new CLASE05.Clases.LabelText02();
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
            this.lbl_titulo.Location = new System.Drawing.Point(4, 26);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(186, 31);
            this.lbl_titulo.TabIndex = 29;
            this.lbl_titulo.Text = "Alta Proveedor";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txt_id_cliente);
            this.panel1.Controls.Add(this.txt_provincia);
            this.panel1.Controls.Add(this.txt_estado);
            this.panel1.Controls.Add(this.btn_aceptar);
            this.panel1.Location = new System.Drawing.Point(10, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 266);
            this.panel1.TabIndex = 30;
            // 
            // txt_id_cliente
            // 
            this.txt_id_cliente._Ancho = 10;
            this.txt_id_cliente._Decimales = 2;
            this.txt_id_cliente._Etiqueta = "ID Cliente";
            this.txt_id_cliente._Mask = "CCCCCCCCCC";
            this.txt_id_cliente._MensajeError = "El password esta vácio";
            this.txt_id_cliente._Nombre_campo = null;
            this.txt_id_cliente._Nombre_tabla = null;
            this.txt_id_cliente._ReadOnly = false;
            this.txt_id_cliente._Text = "";
            this.txt_id_cliente._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_id_cliente._TipoDato = CLASE05.Clases.LabelText02.TipoDato.texto;
            this.txt_id_cliente._Validable = true;
            this.txt_id_cliente.BackColor = System.Drawing.Color.Transparent;
            this.txt_id_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_cliente.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_id_cliente.Location = new System.Drawing.Point(4, 91);
            this.txt_id_cliente.Margin = new System.Windows.Forms.Padding(4);
            this.txt_id_cliente.Name = "txt_id_cliente";
            this.txt_id_cliente.Size = new System.Drawing.Size(257, 35);
            this.txt_id_cliente.TabIndex = 15;
            // 
            // txt_provincia
            // 
            this.txt_provincia._Ancho = 2;
            this.txt_provincia._Decimales = 0;
            this.txt_provincia._Etiqueta = "Provincia";
            this.txt_provincia._Mask = "99";
            this.txt_provincia._MensajeError = null;
            this.txt_provincia._Nombre_campo = "id_usuario";
            this.txt_provincia._Nombre_tabla = null;
            this.txt_provincia._ReadOnly = false;
            this.txt_provincia._Text = "";
            this.txt_provincia._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_provincia._TipoDato = CLASE05.Clases.LabelText02.TipoDato.numero;
            this.txt_provincia._Validable = false;
            this.txt_provincia.BackColor = System.Drawing.Color.Transparent;
            this.txt_provincia.Enabled = false;
            this.txt_provincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_provincia.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_provincia.Location = new System.Drawing.Point(4, 16);
            this.txt_provincia.Margin = new System.Windows.Forms.Padding(4);
            this.txt_provincia.Name = "txt_provincia";
            this.txt_provincia.Size = new System.Drawing.Size(257, 28);
            this.txt_provincia.TabIndex = 13;
            // 
            // txt_estado
            // 
            this.txt_estado._Ancho = 30;
            this.txt_estado._Decimales = 2;
            this.txt_estado._Etiqueta = "Estado";
            this.txt_estado._Mask = "CCCCCCCCCCCCCCCCCCCCCCCCCCCCCC";
            this.txt_estado._MensajeError = "El nombre del usuario está vácio";
            this.txt_estado._Nombre_campo = "n_usuario";
            this.txt_estado._Nombre_tabla = null;
            this.txt_estado._ReadOnly = false;
            this.txt_estado._Text = "";
            this.txt_estado._TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_estado._TipoDato = CLASE05.Clases.LabelText02.TipoDato.texto;
            this.txt_estado._Validable = true;
            this.txt_estado.BackColor = System.Drawing.Color.Transparent;
            this.txt_estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_estado.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_estado.Location = new System.Drawing.Point(4, 52);
            this.txt_estado.Margin = new System.Windows.Forms.Padding(4);
            this.txt_estado.Name = "txt_estado";
            this.txt_estado.Size = new System.Drawing.Size(257, 31);
            this.txt_estado.TabIndex = 14;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btn_aceptar.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_aceptar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_aceptar.Location = new System.Drawing.Point(155, 212);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(95, 31);
            this.btn_aceptar.TabIndex = 22;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = false;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // Frm_Alta_EstadoProvincia
            // 
            this._PosiciónVisible = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(432, 353);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_titulo);
            this.Name = "Frm_Alta_EstadoProvincia";
            this.Text = "Frm_Alta_EstadoProvincia";
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
        public Clases.LabelText02 txt_id_cliente;
        public Clases.LabelText02 txt_provincia;
        public Clases.LabelText02 txt_estado;
        public System.Windows.Forms.Button btn_aceptar;
    }
}