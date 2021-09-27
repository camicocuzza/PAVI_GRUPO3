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

namespace CLASE05.Formularios.Empleado
{
    public partial class Frm_Empleado_Modificar : CLASE05.Formularios.FrmBASE.FrmBase
    {
        public string _Titulo
        {
            get { return lbl_posicion.Text; }
            set { lbl_posicion.Text = value; }
        }
        public string legajo_empleado { get; set; }
        public Frm_Empleado_Modificar()
        {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales _TE = new TratamientosEspeciales();

            if (_TE.Validar(this.Controls) == TratamientosEspeciales.RespuestaValidacion.Correcta)
            {

                // GRABAR NUEVO REGISTRO
                NE_Empleado usu = new NE_Empleado();

                usu.legajo_empleado = txt_legajo._Text;
                usu.apellido = txt_apellido._Text;
                usu.direccion = txt_direccion._Text;
                usu.documento = txt_documento._Text;
                usu.telefono = txt_telefono._Text;
                usu.fecha_ingreso = _TE.RecuperarFecha();
                usu.puesto = txt_puesto._Text;
                usu.Modificar();
                MessageBox.Show("Se modificó correctamente el Empleado " + txt_apellido._Text, "Importante");
                

            }
        }
        private void CargarFormulario(DataTable tabla)
        {
            txt_legajo._Text = tabla.Rows[0]["legajo_empleado"].ToString();
            txt_apellido._Text = tabla.Rows[0]["apellido"].ToString();
            txt_direccion._Text = tabla.Rows[0]["direccion"].ToString();
            txt_documento._Text = tabla.Rows[0]["documento"].ToString();
            txt_telefono._Text = tabla.Rows[0]["telefono"].ToString();
            txt_fecha_ingreso._Text = tabla.Rows[0]["fecha_ingreso"].ToString();
            txt_puesto._Text = tabla.Rows[0]["puesto"].ToString();

        }

        private void Frm_Empleado_Modificar_Load(object sender, EventArgs e)
        {
            NE_Empleado usu = new NE_Empleado();
            CargarFormulario(usu.RecuperarEmpleado(legajo_empleado));
        }
    }
}
