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


namespace CLASE05.Formularios.Articulo
{
    public partial class Frm_Consulta_Articulo : CLASE05.Formularios.FrmBASE.FrmBase
    {
        public Frm_Consulta_Articulo()
        {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Consulta_Articulo_Load(object sender, EventArgs e)
        {
            NE_Articulo usu = new NE_Articulo();
            CargarFormulario(usu.RecuperarArticulo(cod_articulo));
        }
        private void CargarFormulario(DataTable tabla)
        {
            txt_codigo._Text = tabla.Rows[0]["cod_articulo"].ToString();
            txt_nro_lote._Text = tabla.Rows[0]["num_lote"].ToString();
            txt_nro_serie._Text = tabla.Rows[0]["num_serie"].ToString();
            txt_nro_lote._Text = tabla.Rows[0]["num_lote"].ToString();
            txt_nombre._Text = tabla.Rows[0]["nombre"].ToString();
            txt_cuit_proveedor._Text = tabla.Rows[0]["cuit_proveedor"].ToString();
            txt_tiempo_envio._Text = tabla.Rows[0]["tiempo_envio"].ToString();
            txt_plazo_pago._Text = tabla.Rows[0]["plazo_pago"].ToString();
            txt_id_rubro._Text = tabla.Rows[0]["id_rubro"].ToString();
            txt_stock._Text = tabla.Rows[0]["stock"].ToString();
        }
    }
}
