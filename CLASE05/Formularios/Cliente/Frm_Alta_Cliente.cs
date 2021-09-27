using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CLASE05.Clases;
using CLASE05.Negocios;

namespace CLASE05.Formularios.TipoDocumento
{
    public partial class Frm_Alta_tipoDocumento : CLASE05.Formularios.FrmBASE.FrmBase
    {
        public Frm_Alta_tipoDocumento()
        {
            InitializeComponent();
        }

        private void labelText023_Load(object sender, EventArgs e)
        {

        }

        private void Frm_Alta_tipoDocumento_Load(object sender, EventArgs e)
        {
      
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
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
                NE_Cliente usu = new NE_Cliente();


                usu.cuit_cliente = txt_cuil._Text;
                usu.razon_social = txt_razonSocial._Text;
                usu.nombre_contacto = txt_n_cliente._Text;
                usu.domicilio = txt_direccionCliente._Text;
                usu.ciudad = txt_ciudadCliente._Text;
                usu.Insertar();
                MessageBox.Show("Se grabó correctamente", "Importante");
                this.Dispose();

                //string id;
                //id = usu.Insertar(this.Controls);
                //txt_cuil._Text = id;
                //MessageBox.Show("Se grabó correctamente", "Importante");
            }
        }
        private void Frm_Usuario_Alta_Activated(object sender, EventArgs e)
        {
            this.txt_razonSocial.Focus();
        }
    }
}
