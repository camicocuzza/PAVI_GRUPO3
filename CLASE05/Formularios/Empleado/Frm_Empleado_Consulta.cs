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
    public partial class Frm_Empleado_Consulta : CLASE05.Formularios.FrmBASE.FrmBase
    {
        public string _Titulo
        {
            get { return lbl_titulo.Text; }
            set { lbl_titulo.Text = value; }
        }
        public string legajo_empleado { get; set; }
        public Frm_Empleado_Consulta()
        {
            InitializeComponent();
        }

        private void lbl_titulo_Click(object sender, EventArgs e)
        {

        }

        private void CargarFormulario(DataTable tabla)
        {
            txt_legajo._Text = tabla.Rows[0]["legajo_empleado"].ToString();
            txt_apellido._Text = tabla.Rows[0]["apellido"].ToString();
            txt_direccion._Text = tabla.Rows[0]["direccion"].ToString();
            txt_documento._Text = tabla.Rows[0]["documento"].ToString();
            txt_telefono._Text = tabla.Rows[0]["telefono"].ToString();
            txt_fecha_ingreso._Text = tabla.Rows[0]["fecha_Ingreso"].ToString();
            txt_puesto._Text = tabla.Rows[0]["puesto"].ToString();

        }

        private void Frm_Empleado_Consulta_Load(object sender, EventArgs e)
        {
            NE_Empleado usu = new NE_Empleado();
            CargarFormulario(usu.RecuperarEmpleado(legajo_empleado));
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
