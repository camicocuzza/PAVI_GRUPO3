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
    public partial class Frm_Alta_Articulo : CLASE05.Formularios.FrmBASE.FrmBase
    {
        public Frm_Alta_Articulo()
        {
            InitializeComponent();
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
                usu.nombre= txt_nombre._Text;
                usu.cuit_proveedor = txt_cuit_proveedor._Text;
                usu.nombre = txt_nombre._Text;
                usu.cuit_proveedor = txt_cuit_proveedor._Text;
                usu.precio = txt_precio._Text;
                usu.tiempo_envio = txt_tiempo_envio._Text;
                usu.plazo_pago= txt_plazo_pago._Text;
                usu.id_rubro = txt_id_rubro._Text;
                usu.stock = txt_stock._Text;

                usu.Insertar();
                MessageBox.Show("Se grabó correctamente", "Importante");
                this.Dispose();
            }
        }
    }
}
