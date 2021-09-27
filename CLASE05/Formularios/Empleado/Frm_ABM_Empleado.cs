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
    public partial class Frm_ABM_Empleado : CLASE05.Formularios.FrmBASE.FrmBase_ABM_Entrada
    {
        

        public Frm_ABM_Empleado()
        {
            InitializeComponent();
        }

        private void Frm_ABM_Empleado_Load(object sender, EventArgs e)
        {
            this.grid01_empleado.Formatear("legajo_empleado, 75, C; apellido, 100, I; direccion, 100, I; documento, 100, I; telefono, 100, I; fecha_ingreso, 100, I; puesto, 100, I");
        }

        private void btn_blan_patron_Click(object sender, EventArgs e)
        {
            this.txt_patron.Text = string.Empty;
            this.txt_legajo.Text = string.Empty;
            txt_legajo.Enabled = false;
            txt_patron.Enabled = false;
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        { 
            
                

            BuscarDatosEmpleado();
        }
        private void BuscarDatosEmpleado()
        {
            NE_Empleado usu = new NE_Empleado();
            DataTable tabla = new DataTable();

            if (txt_patron.Text != string.Empty)
            {
                if (rb_apellido.Checked == true)
                {
                    grid01_empleado.Cargar(usu.Recuperar_x_Patron(txt_patron.Text));

                    if (grid01_empleado.Rows.Count == 0)
                    {
                        MessageBox.Show("No se encontró ningún empleado", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    return;
                }
                   
            }
            if (txt_legajo.Text != string.Empty)
            {
                if (rb_legajo.Checked == true)
                {
                    grid01_empleado.Cargar(usu.Recuperar_x_Id(txt_legajo.Text));
                    if (grid01_empleado.Rows.Count == 0)
                        MessageBox.Show("No se encontró ningún empleado", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                
            }
            if (rb_todos.Checked == true)
            {
                tabla = usu.RecuperarTodo();
                grid01_empleado.Cargar(tabla);
                return;
            }
            MessageBox.Show("No hay parámetros de búsqueda", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btn_alta_Click(object sender, EventArgs e)
        {
            Frm_Empleado_Alta frm_alta = new Frm_Empleado_Alta();
            frm_alta.ShowDialog();
        }

        private void rb_apellido_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_apellido.Checked == true)
            {
                txt_patron.Enabled = true;
                txt_legajo.Enabled = false;
                txt_patron.Clear();
            }
        }

        private void rb_legajo_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_legajo.Checked == true)
            {
                txt_legajo.Enabled = true;
                txt_patron.Enabled = false;
                txt_patron.Clear();
            }
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (grid01_empleado.Rows.Count == 0)
            {
                MessageBox.Show("Falta buscar Empleado", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (grid01_empleado.CurrentCell.RowIndex == -1)
            {
                MessageBox.Show("Falta seleccionar un Empleado", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            //    if (cuit_cliente == "")
            //    {
            //        MessageBox.Show("Debe seleccionar un elemento de la grilla");
            //        return;
            //    }
            Frm_Empleado_Modificar Modificar = new Frm_Empleado_Modificar();
            Modificar.legajo_empleado = grid01_empleado.CurrentRow.Cells[0].Value.ToString(); ;
            Modificar.ShowDialog();
            grid01_empleado.Rows.Clear();

        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            if (grid01_empleado.Rows.Count == 0)
            {
                MessageBox.Show("Falta buscar Empleado", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (grid01_empleado.CurrentCell.RowIndex == -1)
            {
                MessageBox.Show("Falta seleccionar un Empleado", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            Frm_Empleado_Baja Borrar = new Frm_Empleado_Baja();
            Borrar.legajo_empleado = grid01_empleado.CurrentRow.Cells[0].Value.ToString(); ;
            Borrar.ShowDialog();
            grid01_empleado.Rows.Clear();
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            Frm_Empleado_Consulta Consulta = new Frm_Empleado_Consulta();
            Consulta.legajo_empleado = grid01_empleado.CurrentRow.Cells[0].Value.ToString();
            Consulta.ShowDialog();
        }

        private void grid01_empleado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Frm_Empleado_Consulta Consulta = new Frm_Empleado_Consulta();
            Consulta.legajo_empleado = grid01_empleado.CurrentRow.Cells[0].Value.ToString();
            Consulta.ShowDialog();
        }
    }
}
