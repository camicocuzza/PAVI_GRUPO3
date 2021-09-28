using CLASE05.Negocios;
using CLASE05.Clases;
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
    public partial class Frm_Baja_Articulo : CLASE05.Formularios.FrmBASE.FrmBase
    {
        public string cod_articulo { get; set; }
        public string _Titulo
        {
            get { return lbl_posicion.Text; }
            set { lbl_posicion.Text = value; }
        }
        public Frm_Baja_Articulo()
        {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales _TE = new TratamientosEspeciales();

            if (_TE.Validar(this.Controls) == TratamientosEspeciales.RespuestaValidacion.Correcta)
            {
                NE_Articulo usu = new NE_Articulo();

                usu.cod_articulo = cod_articulo;

                if (MessageBox.Show("¿Está seguro de que desea eliminar el Articulo " + txt_nombre._Text + "?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    usu.Borrar();
                    MessageBox.Show("Se eliminó correctamente el Articulo " + txt_nombre._Text, "Importante");
                    this.Dispose();
                }
                else
                    MessageBox.Show("Eliminación cancelada");
            }
        }

        private void Frm_Baja_Articulo_Load(object sender, EventArgs e)
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
