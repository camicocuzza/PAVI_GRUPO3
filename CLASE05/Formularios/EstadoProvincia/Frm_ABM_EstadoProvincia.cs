using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLASE05.Formularios.EstadoProvincia
{
    public partial class Frm_ABM_EstadoProvincia : CLASE05.Formularios.FrmBASE.FrmBase_ABM_Entrada
    {
        public Frm_ABM_EstadoProvincia()
        {
            InitializeComponent();
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            Frm_Consulta_EstadoProvincia frm_alta = new Frm_Consulta_EstadoProvincia();
            frm_alta.ShowDialog();
        }

        private void btn_alta_Click(object sender, EventArgs e)
        {
            Frm_Alta_EstadoProvincia frm_alta = new Frm_Alta_EstadoProvincia();
            frm_alta.ShowDialog();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            Frm_Modificar_EstadoProvincia frm_alta = new Frm_Modificar_EstadoProvincia();
            frm_alta.ShowDialog();
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            Frm_Baja_EstadoProvincia frm_alta = new Frm_Baja_EstadoProvincia();
            frm_alta.ShowDialog();
        }
    }
}
