using CLASE05.Clases;
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


namespace CLASE05.Formularios.Articulo
{
    public partial class Frm_Modificar_Articulo : CLASE05.Formularios.FrmBASE.FrmBase
    {
        public string cod_articulo { get; set; }
        public string _Titulo
        {
            get { return lbl_posicion.Text; }
            set { lbl_posicion.Text = value; }
        }
        public Frm_Modificar_Articulo()
        {
            InitializeComponent();
        }

        private void lbl_titulo_Click(object sender, EventArgs e)
        {

        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales _TE = new TratamientosEspeciales();

            if (_TE.Validar(this.Controls) == TratamientosEspeciales.RespuestaValidacion.Correcta)
            {
                NE_Articulo usu = new NE_Articulo();
                usu.cod_articulo = txt_codigo._Text;
                usu.num_serie = txt_nro_serie._Text;
                usu.num_lote = txt_nro_lote._Text;
                usu.nombre = txt_nombre._Text;
                usu.cuit_proveedor = txt_cuit_proveedor._Text;
                usu.nombre = txt_nombre._Text;
                usu.cuit_proveedor = txt_cuit_proveedor._Text;
                usu.precio = txt_precio._Text;
                usu.tiempo_envio = txt_tiempo_envio._Text;
                usu.plazo_pago = txt_plazo_pago._Text;
                usu.id_rubro = txt_id_rubro._Text;
                usu.stock = txt_stock._Text;

                usu.Modificar();
                MessageBox.Show("Se grabó correctamente", "Importante");
                this.Dispose();
            }
        }

        private void Frm_Modificar_Articulo_Load(object sender, EventArgs e)
        {
            NE_Articulo usu = new NE_Articulo();
            CargarFormulario(usu.RecuperarArticulo(cod_articulo));
        }
        private void CargarFormulario(DataTable tabla)
        {
            txt_codigo._Text = tabla.Rows[0]["cod_articulo"].ToString();
            txt_nro_serie._Text = tabla.Rows[0]["num_serie"].ToString();
            txt_nro_lote._Text = tabla.Rows[0]["num_lote"].ToString();
            txt_nombre._Text = tabla.Rows[0]["nombre"].ToString();
            txt_cuit_proveedor._Text = tabla.Rows[0]["cuit_proveedor"].ToString();
            txt_precio._Text = tabla.Rows[0]["precio"].ToString();
            txt_tiempo_envio._Text = tabla.Rows[0]["tiempo_envio"].ToString();
            txt_plazo_pago._Text = tabla.Rows[0]["plazo_pago"].ToString();
            txt_id_rubro._Text = tabla.Rows[0]["id_rubro"].ToString();
            txt_stock._Text = tabla.Rows[0]["stock"].ToString();
        }
    }
}
