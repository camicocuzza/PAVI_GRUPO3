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

namespace CLASE05.Formularios.TipoDocumento
{
    public partial class Frm_Modificar_tipoDocumento : CLASE05.Formularios.FrmBASE.FrmBase
    {
        public string id_cliente { get; set; }
        public string _Titulo
        {
            get { return lbl_posicion.Text; }
            set { lbl_posicion.Text = value; }
        }
        public Frm_Modificar_tipoDocumento()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales _TE = new TratamientosEspeciales();

            if (_TE.Validar(this.Controls) == TratamientosEspeciales.RespuestaValidacion.Correcta)
            {
                //// VALIDACION ESPECIFICA
                //if (_TE.ValidarEmail(txt_email._Text) == TratamientosEspeciales.RespuestaValidacion.Error)
                //{
                //    MessageBox.Show("El formato de correo es invalido");
                //    txt_email.Focus();
                //    return;
                //}

                // GRABAR NUEVO REGISTRO
                NE_Cliente usu = new NE_Cliente();
                usu.id_cliente = txt_id_cliente._Text;
                usu.cuit_cliente = txt_cuil._Text;
                usu.razon_social = txt_razon_social._Text;
                usu.nombre_contacto = txt_nombre_cliente._Text;
                usu.domicilio = txt_direccion._Text;
                usu.ciudad = txt_ciudad._Text;

                usu.Modificar();
                MessageBox.Show("Se modificó correctamente el cliente " , "Importante");

            }
        }

        private void Frm_Modificar_tipoDocumento_Load(object sender, EventArgs e)
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



    }
    
}
