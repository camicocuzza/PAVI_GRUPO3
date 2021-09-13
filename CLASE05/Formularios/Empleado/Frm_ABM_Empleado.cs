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
    public partial class Frm_ABM_Empleado : CLASE05.Formularios.FrmBASE.FrmBase_ABM_Entrada
    {
        public Frm_ABM_Empleado()
        {
            InitializeComponent();
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            Frm_Consultar_Empleado frm_alta = new Frm_Consultar_Empleado();
            frm_alta.ShowDialog();
        }

        private void btn_alta_Click(object sender, EventArgs e)
        {
            Frm_Alta_Empleado frm_alta = new Frm_Alta_Empleado();
            frm_alta.ShowDialog();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            Frm_Modicar_Empleado frm_alto = new Frm_Modicar_Empleado();
            frm_alto.ShowDialog();
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            Frm_Baja_Empleado frm_baja = new Frm_Baja_Empleado();
            frm_baja.ShowDialog();
        }
    }
}
