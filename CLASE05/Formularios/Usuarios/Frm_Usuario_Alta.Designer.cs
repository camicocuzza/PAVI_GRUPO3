﻿
namespace CLASE05.Formularios.Usuarios
{
    partial class Frm_Usuario_Alta
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.Location = new System.Drawing.Point(26, 25);
            this.lbl_titulo.Size = new System.Drawing.Size(198, 31);
            this.lbl_titulo.Text = "Altas de usuario";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(13, 226);
            // 
            // txt_n_usuario
            // 
            this.txt_n_usuario.Location = new System.Drawing.Point(13, 174);
            // 
            // txt_id_usuario
            // 
            this.txt_id_usuario.Location = new System.Drawing.Point(13, 123);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            // 
            // btn_maximizar
            // 
            this.btn_maximizar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            // 
            // Frm_Usuario_Alta
            // 
            this._PosiciónVisible = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(432, 384);
            this.Name = "Frm_Usuario_Alta";
            this.Load += new System.EventHandler(this.Frm_Usuario_Alta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
