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

namespace CLASE05.Formularios.Compra
{
    public partial class Frm_ABM_Compra : CLASE05.Formularios.FrmBASE.FrmBase_ABM_Entrada
    {
        public Frm_ABM_Compra()
        {
            InitializeComponent();
        }

        private void Frm_ABM_Compra_Load(object sender, EventArgs e)
        {
            this.grid_Compra.Formatear("Numero de Compra, 100, I; CUIT Proveedor, 200, I; Fecha, 100, I; Monto TOTAl, 100, I");
        }

        ///BOTON DE BUSQUEDA
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            BuscarDatosCompra();
        }

        private void BuscarDatosCompra()
        {
            NE_Compra usu = new NE_Compra();
            DataTable tabla = new DataTable();
            if (rb_n_Compra.Checked == true)
            {
                grid_Compra.Cargar(usu.Recuperar_x_Patron(txt_date.Text));
                if (grid_Compra.Rows.Count == 0)
                    MessageBox.Show("No se encontró ningúna compra", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
            if (rb_id_Compra.Checked == true)
            {
                grid_Compra.Cargar(usu.Recuperar_x_Id(txt_id_Compra.Text));
                if (grid_Compra.Rows.Count == 0)
                    MessageBox.Show("No se encontró ningúna compra", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (rb_todos.Checked == true)
            {
                tabla = usu.Recuperar_Todos();
                grid_Compra.Cargar(tabla);
                return;
            }
            MessageBox.Show("No hay parámetros de búsqueda", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


        }

        //CONSULTA
        private void btn_consultar_Click(object sender, EventArgs e)
        {
            if (grid_Compra.Rows.Count == 0)
            {
                MessageBox.Show("Falta buscar una compra", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (grid_Compra.CurrentCell.RowIndex == -1)
            {
                MessageBox.Show("Falta seleccionar una Compra", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            Frm_Consulta_Compra frm_consulta = new Frm_Consulta_Compra();
            frm_consulta.id_compra = grid_Compra.CurrentRow.Cells[0].Value.ToString();
            frm_consulta.ShowDialog();
        }

        //ALTA
        private void btn_alta_Click(object sender, EventArgs e)
        {
            Frm_Alta_Compra frm_alta = new Frm_Alta_Compra();
            frm_alta.ShowDialog();
        }

        //MODIFICACION
        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (grid_Compra.Rows.Count == 0)
            {
                MessageBox.Show("Falta buscar una Compra", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (grid_Compra.CurrentCell.RowIndex == -1)
            {
                MessageBox.Show("Falta seleccionar una Compra", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            Frm_Modificacion_Compra frm_modificacion = new Frm_Modificacion_Compra();
            frm_modificacion.id_compra = grid_Compra.CurrentRow.Cells[0].Value.ToString();
            frm_modificacion.ShowDialog();
        }

        //BAJA
        private void btn_borrar_Click(object sender, EventArgs e)
        {
            if (grid_Compra.Rows.Count == 0)
            {
                MessageBox.Show("Falta buscar una Compra", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (grid_Compra.CurrentCell.RowIndex == -1)
            {
                MessageBox.Show("Falta seleccionar una Compra", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            Frm_Baja_Compra frm_baja = new Frm_Baja_Compra();
            frm_baja.id_compra = grid_Compra.CurrentRow.Cells[0].Value.ToString();
            frm_baja.ShowDialog();
            grid_Compra.Rows.Clear();
        }

        //BORRAR
        private void btn_blan_patron_Click(object sender, EventArgs e)
        {
            this.txt_date.Text = string.Empty;
            this.txt_id_Compra.Text = string.Empty;
            txt_id_Compra.Enabled = false;
            txt_date.Enabled = false;
            grid_Compra.Rows.Clear();

        }

        private void rb_id_Compra_CheckedChanged(object sender, EventArgs e)
        {

            txt_date.Enabled = false;
            txt_id_Compra.Enabled = true;
            txt_date.Text = string.Empty;

        }

        private void rb_n_Compra_CheckedChanged(object sender, EventArgs e)
        {
            txt_id_Compra.Enabled = false;
            txt_date.Enabled = true;
            txt_id_Compra.Clear();
        }

        private void rb_todos_CheckedChanged(object sender, EventArgs e)
        {
            txt_date.Enabled = false;
            txt_id_Compra.Enabled = false;
            txt_date.Text = string.Empty;
            txt_id_Compra.Clear();
        }

        private void txt_id_Compra_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            txt_id_Compra.SelectionStart = txt_id_Compra.Text.Length;
        }
           

    }
}
