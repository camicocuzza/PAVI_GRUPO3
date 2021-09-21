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
        public Frm_Alta_Compra()
        {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            //N1  validar los datos del formulario
            //N1 la validacion de todo ok => realizo validación especifica
            //----N2 -------si la validacion especifica da ok => grabo
            //----N2 -------la validacion especifica da error => ir a corregir el error
            //N1 si validacion da error => ir a corregir el error
            TratamientosEspeciales _TE = new TratamientosEspeciales();

            if (_TE.Validar(this.Controls) == TratamientosEspeciales.RespuestaValidacion.Correcta)
            {
                // VALIDACION ESPECIFICA
                //if (_TE.ValidarEmail(txt_email._Text) == TratamientosEspeciales.RespuestaValidacion.Error)
                //{
                //    MessageBox.Show("El formato de correo es invalido");
                //    txt_email.Focus();
                //    return;
                //}
                // GRABAR NUEVO REGISTRO
                NE_Compra usu = new NE_Compra();


                
                usu.cuit_proveedor = txt_n_compra._Text;
                usu.fecha = txt_fecha._Text;
                usu.monto_total = monto_compra._Text;

                usu.Insertar();
                MessageBox.Show("Se grabó correctamente", "Importante");
                this.Dispose();
            }
        }

        private void Frm_Alta_Compra_Load(object sender, EventArgs e)
        {
            this.monto_compra.Focus();
        }
    }
}
