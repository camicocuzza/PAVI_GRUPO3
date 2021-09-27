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
    public partial class Frm_Baja_tipoDocumento : CLASE05.Formularios.FrmBASE.FrmBase
    {

        public string id_cliente { get; set; }
        public string _Titulo
        {
            get { return lbl_posicion.Text; }
            set { lbl_posicion.Text = value; }
        }

        public Frm_Baja_tipoDocumento()
        {
            InitializeComponent();
        }

        private void Frm_Baja_tipoDocumento_Load(object sender, EventArgs e)
        {
            NE_Cliente usu = new NE_Cliente();
            CargarFormulario(usu.RecuperarCliente(id_cliente));
        }
        private void CargarFormulario(DataTable tabla)
        {
            txt_id_cliente._Text = tabla.Rows[0]["id_cliente"].ToString();
            txt_cuit_cliente._Text = tabla.Rows[0]["cuit_cliente"].ToString();
            txt_razon_social._Text = tabla.Rows[0]["razon_social"].ToString();
           nombre_cliente._Text = tabla.Rows[0]["nombre_contacto"].ToString();
            txt_direccion_cliente._Text = tabla.Rows[0]["domicilio"].ToString();
            txt_ciudad_cliente._Text = tabla.Rows[0]["ciudad"].ToString();
            


        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales _TE = new TratamientosEspeciales();

            if (_TE.Validar(this.Controls) == TratamientosEspeciales.RespuestaValidacion.Correcta)
            {
                NE_Cliente usu = new NE_Cliente();

                usu.id_cliente = id_cliente;

                if (MessageBox.Show("¿Está seguro de que desea eliminar al cliente " + txt_razon_social._Text + "?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    usu.Borrar();
                    MessageBox.Show("Se eliminó correctamente el usuario " + txt_razon_social._Text, "Importante");
                    this.Dispose();
                }
                else
                    MessageBox.Show("Eliminación cancelada");

            }
        }
    }
}
