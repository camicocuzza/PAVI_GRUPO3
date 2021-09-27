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
    public partial class Frm_Empleado_Baja : CLASE05.Formularios.FrmBASE.FrmBase
    {
        public string legajo_empleado { get; set; }
        public Frm_Empleado_Baja()
        {
            InitializeComponent();
        }

        private void Frm_Empleado_Baja_Load(object sender, EventArgs e)
        {
            NE_Empleado usu = new NE_Empleado();
            CargarFormulario(usu.RecuperarEmpleado(legajo_empleado));
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

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales _TE = new TratamientosEspeciales();

            if (_TE.Validar(this.Controls) == TratamientosEspeciales.RespuestaValidacion.Correcta)
            {
                NE_Empleado usu = new NE_Empleado();

                usu.legajo_empleado = legajo_empleado;

                if (MessageBox.Show("¿Está seguro de que desea eliminar el Empleado " + txt_apellido._Text + "?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    usu.Borrar();
                    MessageBox.Show("Se eliminó correctamente el Empleado " + txt_apellido._Text, "Importante");
                    this.Dispose();
                }
                else
                    MessageBox.Show("Eliminación cancelada");

            }
        }
    }
}
