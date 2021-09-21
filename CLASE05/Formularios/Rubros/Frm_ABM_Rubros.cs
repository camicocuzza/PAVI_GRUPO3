using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CLASE05.Negocios;

namespace CLASE05.Formularios.Rubros
{
    public partial class Frm_ABM_Rubros : CLASE05.Formularios.FrmBASE.FrmBase_ABM_Entrada
    {
        public Frm_ABM_Rubros()
        {
            InitializeComponent();
        }

        private void Frm_ABM_Rubros_Load(object sender, EventArgs e)
        {
            this.grid_Rubros.Formatear("ID Rubro, 100, C; Nombre Rubro, 200, I");
        }

        ///BOTON DE BUSQUEDA

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            BuscarDatosRubros();
        }

        private void BuscarDatosRubros()
        {
            NE_Rubros usu = new NE_Rubros();
            DataTable tabla = new DataTable();
            if (rb_n_Rubro.Checked == true)
            {
                grid_Rubros.Cargar(usu.Recuperar_x_Patron(txt_patron.Text));
                if (grid_Rubros.Rows.Count == 0)
                    MessageBox.Show("No se encontró ningún Tipo de Factura", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
            if (rb_id_Rubro.Checked == true)
            {
                grid_Rubros.Cargar(usu.Recuperar_x_Id(txt_id_Rubro.Text));
                if (grid_Rubros.Rows.Count == 0)
                    MessageBox.Show("No se encontró ningún Tipo de Factura", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (rb_todos.Checked == true)
            {
                tabla = usu.Recuperar_Todos();
                grid_Rubros.Cargar(tabla);
                return;
            }
            MessageBox.Show("No hay parámetros de búsqueda", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


        }


        //CONSULTA
        private void btn_consultar_Click(object sender, EventArgs e)
        {
            if (grid_Rubros.Rows.Count == 0)
            {
                MessageBox.Show("Falta buscar Rubros", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (grid_Rubros.CurrentCell.RowIndex == -1)
            {
                MessageBox.Show("Falta seleccionar un Rubro", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            Frm_Consulta_Rubro frm_consulta = new Frm_Consulta_Rubro();
            frm_consulta.id_rubro = grid_Rubros.CurrentRow.Cells[0].Value.ToString();
            frm_consulta.ShowDialog();
        }

        //ALTA
        private void btn_alta_Click_1(object sender, EventArgs e)
        {
            Frm_Alta_Rubro frm_alta = new Frm_Alta_Rubro();
            frm_alta.ShowDialog();
        }

        //MODIFICACION
        private void btn_modificar_Click_1(object sender, EventArgs e)
        {
            if(grid_Rubros.Rows.Count == 0)
            {
                MessageBox.Show("Falta buscar Rubros", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (grid_Rubros.CurrentCell.RowIndex == -1)
            {
                MessageBox.Show("Falta seleccionar un Rubro", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            Frm_Modificacion_Rubro frm_modificacion = new Frm_Modificacion_Rubro();
            frm_modificacion.id_rubro = grid_Rubros.CurrentRow.Cells[0].Value.ToString();
            frm_modificacion.ShowDialog();
        }

        //BAJA
        private void btn_borrar_Click_1(object sender, EventArgs e)
        {
            if(grid_Rubros.Rows.Count == 0)
            {
                MessageBox.Show("Falta buscar Rubros", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (grid_Rubros.CurrentCell.RowIndex == -1)
            {
                MessageBox.Show("Falta seleccionar un Rubro", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            Frm_Baja_Rubro frm_baja = new Frm_Baja_Rubro();
            frm_baja.id_rubro = grid_Rubros.CurrentRow.Cells[0].Value.ToString();
            frm_baja.ShowDialog();
            grid_Rubros.Rows.Clear();
        }

        //BORRAR
        private void btn_blan_patron_Click(object sender, EventArgs e)
        {
            this.txt_patron.Text = string.Empty;
            this.txt_id_Rubro.Text = string.Empty;
            txt_id_Rubro.Enabled = false;
            txt_patron.Enabled = false;
            grid_Rubros.Rows.Clear();

        }

        private void rb_id_Rubro_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_id_Rubro.Checked == true)
            {
                txt_patron.Enabled = false;
                txt_id_Rubro.Clear();
                txt_id_Rubro.Enabled = true;
            }
        }

        private void rb_n_Rubro_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_n_Rubro.Checked == true)
            {
                txt_id_Rubro.Enabled = false;
                txt_patron.Clear();
                txt_patron.Enabled = true;
            }
        }

        private void txt_patron_Click(object sender, EventArgs e)
        {
            txt_patron.SelectionStart = txt_patron.Text.Length;
        }

        private void txt_id_Rubro_Click(object sender, EventArgs e)
        {
            txt_id_Rubro.SelectionStart = txt_id_Rubro.Text.Length;
        }
    }
}
