using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CLASE05.Negocios;
using CLASE05.Clases;


namespace CLASE05.Formularios.Compra
{
    public partial class Frm_Consulta_Compra : CLASE05.Formularios.FrmBASE.FrmBase
    {
        public Frm_Consulta_Compra()
        {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Consulta_Compra_Load(object sender, EventArgs e)
        {
            NE_Compra usu = new NE_Compra();
            CargarFormulario(usu.RecuperarCompra(id_compra));
        }

        private void CargarFormulario(DataTable tabla)
        {
            txt_id_compra._Text = tabla.Rows[0]["num_compra"].ToString();
            txt_n_compra._Text = tabla.Rows[0]["cuit_proveedor"].ToString();
            txt_fecha._Text = tabla.Rows[0]["fecha"].ToString();
            monto_compra._Text = tabla.Rows[0]["monto_total"].ToString();

            //txt_n_rubro.Enabled = false;

        }


    }
}
