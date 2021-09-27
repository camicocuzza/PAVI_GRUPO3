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
    public partial class Frm_Empleado : CLASE05.Formularios.FrmBASE.FrmBase
    {
        public string _Titulo
        {
            get { return lbl_posicion.Text; }
            set { lbl_posicion.Text = value; }
        }
        public string legajo_empleado { get; set; }
        public Frm_Empleado()
        {
            InitializeComponent();
        }
    }
}
