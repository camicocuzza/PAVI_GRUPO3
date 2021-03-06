using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CLASE05.Formularios.Usuarios
{
    public partial class Prof_Frm_Usuario : CLASE05.Formularios.FrmBASE.FrmBase
    {
        public string _Titulo
        {
            get { return lbl_titulo.Text; } set { lbl_titulo.Text = value; }
        }
        public string id_usuario { get; set; }

        public Prof_Frm_Usuario()
        {
            InitializeComponent();
        }

        private void Frm_Usuario_Load(object sender, EventArgs e)
        {
            CargarCombos();
        }
        public void CargarCombos()
        {
            cmb_estadosUsuarios._Cargar();
            cmb_perfiles._Cargar();
        }
    }
}
