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

        NE_Compra Facturaa = new NE_Compra();

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            NE_Compra Facturaa = new NE_Compra();
            if (Facturaa.ValidarProveedor(txt_n_compra2.Text).Rows.Count == 1)
            {
                Facturaa.num_compra = txt_id_compra._Text;
                Facturaa.cuit_proveedor = txt_n_compra2.Text;
                Facturaa.fecha = _TE.RecuperarFecha();
                Facturaa.monto_total = monto_compra._Text;
                Facturaa.Insertar();
                this.Close();

                MessageBox.Show("Se grabó correctamente", "Importante");
            }
            else
            {
                MessageBox.Show("Se grabó correctamente", "Importante");
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            NE_Compra Facturaa = new NE_Compra();
            if (Facturaa.ValidarProveedor(txt_n_compra._Text).Rows.Count == 1)
            {
                MessageBox.Show("El Proveedor existe", "Importante");
            }
            else
            {
                DialogResult dg = MessageBox.Show("El Poveedor No existe", "Importante",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);
                if (dg == DialogResult.OK)
                {

                }
            }
        }
    }
}
