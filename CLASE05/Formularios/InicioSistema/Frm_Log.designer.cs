﻿
namespace CLASE05.Formularios.InicioSistema
{
    partial class Frm_Log
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
            this.gb_login = new System.Windows.Forms.GroupBox();
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.lbl_Contraseña = new System.Windows.Forms.Label();
            this.txt_Usuario = new System.Windows.Forms.TextBox();
            this.txt_Contraseña = new System.Windows.Forms.TextBox();
            this.lbl_UserLogin = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_salir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel_contraseña = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel_usuario = new System.Windows.Forms.FlowLayoutPanel();
            this.gb_login.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_login
            // 
            this.gb_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.gb_login.Controls.Add(this.label3);
            this.gb_login.Controls.Add(this.btn_salir);
            this.gb_login.Controls.Add(this.label2);
            this.gb_login.Controls.Add(this.btn_Login);
            this.gb_login.Controls.Add(this.lbl_UserLogin);
            this.gb_login.Controls.Add(this.flowLayoutPanel_contraseña);
            this.gb_login.Controls.Add(this.flowLayoutPanel_usuario);
            this.gb_login.Controls.Add(this.txt_Contraseña);
            this.gb_login.Controls.Add(this.txt_Usuario);
            this.gb_login.Controls.Add(this.lbl_Contraseña);
            this.gb_login.Controls.Add(this.lbl_Usuario);
            this.gb_login.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_login.Location = new System.Drawing.Point(25, 23);
            this.gb_login.Name = "gb_login";
            this.gb_login.Size = new System.Drawing.Size(405, 384);
            this.gb_login.TabIndex = 0;
            this.gb_login.TabStop = false;
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Usuario.ForeColor = System.Drawing.Color.Silver;
            this.lbl_Usuario.Location = new System.Drawing.Point(21, 155);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(88, 21);
            this.lbl_Usuario.TabIndex = 0;
            this.lbl_Usuario.Text = "Username";
            // 
            // lbl_Contraseña
            // 
            this.lbl_Contraseña.AutoSize = true;
            this.lbl_Contraseña.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Contraseña.ForeColor = System.Drawing.Color.Silver;
            this.lbl_Contraseña.Location = new System.Drawing.Point(21, 205);
            this.lbl_Contraseña.Name = "lbl_Contraseña";
            this.lbl_Contraseña.Size = new System.Drawing.Size(84, 21);
            this.lbl_Contraseña.TabIndex = 1;
            this.lbl_Contraseña.Text = "Password";
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.AcceptsTab = true;
            this.txt_Usuario.AccessibleDescription = "";
            this.txt_Usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txt_Usuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Usuario.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Usuario.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.txt_Usuario.Location = new System.Drawing.Point(111, 154);
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(236, 27);
            this.txt_Usuario.TabIndex = 1;
            // 
            // txt_Contraseña
            // 
            this.txt_Contraseña.AcceptsTab = true;
            this.txt_Contraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txt_Contraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Contraseña.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold);
            this.txt_Contraseña.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.txt_Contraseña.Location = new System.Drawing.Point(111, 203);
            this.txt_Contraseña.Name = "txt_Contraseña";
            this.txt_Contraseña.PasswordChar = '*';
            this.txt_Contraseña.Size = new System.Drawing.Size(236, 29);
            this.txt_Contraseña.TabIndex = 2;
            this.txt_Contraseña.UseSystemPasswordChar = true;
            // 
            // lbl_UserLogin
            // 
            this.lbl_UserLogin.AutoSize = true;
            this.lbl_UserLogin.Font = new System.Drawing.Font("Microsoft JhengHei", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserLogin.ForeColor = System.Drawing.Color.Silver;
            this.lbl_UserLogin.Location = new System.Drawing.Point(147, 23);
            this.lbl_UserLogin.Name = "lbl_UserLogin";
            this.lbl_UserLogin.Size = new System.Drawing.Size(99, 22);
            this.lbl_UserLogin.TabIndex = 6;
            this.lbl_UserLogin.Text = "User Login";
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btn_Login.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.ForeColor = System.Drawing.Color.White;
            this.btn_Login.Location = new System.Drawing.Point(71, 318);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(266, 37);
            this.btn_Login.TabIndex = 7;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(38, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(331, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "______________________________________________";
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btn_salir.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.ForeColor = System.Drawing.Color.White;
            this.btn_salir.Location = new System.Drawing.Point(372, 16);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(27, 29);
            this.btn_salir.TabIndex = 10;
            this.btn_salir.Text = "X";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(38, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(331, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "______________________________________________";
            // 
            // flowLayoutPanel_contraseña
            // 
            this.flowLayoutPanel_contraseña.BackgroundImage = global::CLASE05.Properties.Resources.images;
            this.flowLayoutPanel_contraseña.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flowLayoutPanel_contraseña.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel_contraseña.Location = new System.Drawing.Point(353, 203);
            this.flowLayoutPanel_contraseña.Name = "flowLayoutPanel_contraseña";
            this.flowLayoutPanel_contraseña.Size = new System.Drawing.Size(26, 29);
            this.flowLayoutPanel_contraseña.TabIndex = 5;
            // 
            // flowLayoutPanel_usuario
            // 
            this.flowLayoutPanel_usuario.BackgroundImage = global::CLASE05.Properties.Resources.images__1_;
            this.flowLayoutPanel_usuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flowLayoutPanel_usuario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel_usuario.Location = new System.Drawing.Point(353, 154);
            this.flowLayoutPanel_usuario.Name = "flowLayoutPanel_usuario";
            this.flowLayoutPanel_usuario.Size = new System.Drawing.Size(26, 27);
            this.flowLayoutPanel_usuario.TabIndex = 4;
            // 
            // Frm_Log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(456, 431);
            this.Controls.Add(this.gb_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Log";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Log";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gb_login.ResumeLayout(false);
            this.gb_login.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_login;
        private System.Windows.Forms.Label lbl_Contraseña;
        private System.Windows.Forms.Label lbl_Usuario;
        public System.Windows.Forms.TextBox txt_Usuario;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Label lbl_UserLogin;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_contraseña;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_usuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txt_Contraseña;
    }
}