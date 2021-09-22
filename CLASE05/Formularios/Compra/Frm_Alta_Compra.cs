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
    public partial class Frm_Alta_Compra : CLASE05.Formularios.FrmBASE.FrmBase
    {
        TratamientosEspeciales _TE = new TratamientosEspeciales();

        public Frm_Alta_Compra()
        {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            NE_Compra Facturaa = new NE_Compra();

            Facturaa.num_compra = txt_id_compra._Text;
            Facturaa.cuit_proveedor = txt_n_compra._Text;
            //Facturaa.fecha = txt_fecha._Text;
            Facturaa.monto_total = monto_compra._Text;
            Facturaa.Insertar();
            this.Close();

            
            MessageBox.Show("Se grabó correctamente", "Importante");

            //if (_TE.Validar(this.Controls) == TratamientosEspeciales.RespuestaValidacion.Correcta)
            //{
            //    NE_Compra usu = new NE_Compra();

            //    usu.cuit_proveedor = txt_n_compra._Text;
            //    usu.fecha = txt_fecha._Text;
            //    usu.monto_total = monto_compra._Text;

            //    usu.Insertar();
            //    MessageBox.Show("Se grabó correctamente", "Importante");
            //    this.Dispose();
            //}
        }

        private void Frm_Alta_Compra_Load(object sender, EventArgs e)
        {
            this.monto_compra.Focus();
            txt_fecha.Enabled = false;
            txt_fecha._Text = _TE.RecuperarFecha();
        }

        private void txt_fecha_Load(object sender, EventArgs e)
        {
            
        }
    }
}
