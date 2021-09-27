using CLASE05.Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLASE05.Formularios.Cliente
{
    public partial class Frm_Validar_Cliente : CLASE05.Formularios.FrmBASE.FrmBase
    {
        public string _Titulo
        {
            get { return lbl_titulo.Text; }
            set { lbl_titulo.Text = value; }
        }
        public string id_cliente { get; set; }
        public Frm_Validar_Cliente()
        {
            InitializeComponent();
        }

        private void Frm_Validar_Cliente_Load(object sender, EventArgs e)
        {
            NE_Cliente usu = new NE_Cliente();
            CargarFormulario(usu.RecuperarCliente(id_cliente));

        }
        private void CargarFormulario(DataTable tabla)
        {
            txt_id_cliente._Text = tabla.Rows[0]["id_cliente"].ToString();
            txt_cuil._Text = tabla.Rows[0]["cuit_cliente"].ToString();
            txt_razon_social._Text = tabla.Rows[0]["razon_social"].ToString();
            txt_nombre_cliente._Text = tabla.Rows[0]["nombre_contacto"].ToString();
            txt_direccion._Text = tabla.Rows[0]["domicilio"].ToString();
            txt_ciudad._Text = tabla.Rows[0]["ciudad"].ToString();

        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
