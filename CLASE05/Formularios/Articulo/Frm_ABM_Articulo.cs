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
using CLASE05.Clases;

namespace CLASE05.Formularios.Articulo
{
    public partial class Frm_ABM_Articulo : CLASE05.Formularios.FrmBASE.FrmBase_ABM_Entrada
    {
        public Frm_ABM_Articulo()
        {
            InitializeComponent();
        }
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            BuscarDatosArticulo();
        }
        private void BuscarDatosArticulo()
        {
            NE_Articulo usu = new NE_Articulo();
            DataTable tabla = new DataTable();
            if (rb_nombre_articulo.Checked == true)
            {
                grid_articulo.Cargar(usu.Recuperar_X_Patron(txt_patron.Text));
            }
            if (rb_todo_articulo.Checked == true)
            {
                tabla = usu.Recuperar_X_Todo();
                grid_articulo.Cargar(tabla);
                return;
            }
            if (rb_codigo_articulo.Checked == true)
            {
                grid_articulo.Cargar(usu.Recuperar_X_Patron(txt_id_articulo.Text));

            }
        }
        private void btn_consultar_Click(object sender, EventArgs e)
        {
            if (grid_articulo.Rows.Count == 0)
            {
                MessageBox.Show("Falta buscar Articulos", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (grid_articulo.CurrentCell.RowIndex == -1)
            {
                MessageBox.Show("Falta seleccionar un Articulo", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            Frm_Consulta_Articulo frm_alta = new Frm_Consulta_Articulo();
            frm_alta.cod_articulo = grid_articulo.CurrentRow.Cells[0].Value.ToString();
            frm_alta.ShowDialog();
        }
        private void btn_alta_Click(object sender, EventArgs e)
        {
            Frm_Alta_Articulo frm_alta = new Frm_Alta_Articulo();
            frm_alta.ShowDialog();
        }
        private void btn_modificar_Click(object sender, EventArgs e)
        {
            Frm_Modificar_Articulo frm_alta = new Frm_Modificar_Articulo();
            frm_alta.ShowDialog();
        }
        //private void Frm_ABM_Articulo_Load(object sender, EventArgs e)
        //{
        //    this.grid_articulo.Formatear("cod_ariculo, 75," +
        //        " C; num_serie, 200, I; num_lote, 75, I; nombre, 200, I;" +
        //        "cuit_proveedor, 200, I");
        //}
        private void btn_borrar_Click(object sender, EventArgs e)
        {
            Frm_Baja_Articulo frm_alta = new Frm_Baja_Articulo();
            frm_alta.ShowDialog();
        }
        //BORRAR

        private void btn_blan_patron_Click_1(object sender, EventArgs e)
        {
            this.txt_patron.Text = string.Empty;
            this.txt_id_articulo.Text = string.Empty;
            txt_id_articulo.Enabled = false;
            txt_patron.Enabled = false;
            grid_articulo.Rows.Clear();
        }

        private void rb_codigo_articulo_CheckedChanged(object sender, EventArgs e)
        {
            txt_patron.Enabled = false;
            txt_id_articulo.Enabled = true;
            txt_patron.Text = string.Empty;
        }

        private void rb_nombre_articulo_CheckedChanged(object sender, EventArgs e)
        {
            txt_id_articulo.Enabled = false;
            txt_patron.Enabled = true;
            txt_id_articulo.Clear();
        }

        private void rb_todo_articulo_CheckedChanged(object sender, EventArgs e)
        {
            txt_id_articulo.Enabled = false;
            txt_patron.Enabled = false;
            txt_patron.Text = string.Empty;
            txt_id_articulo.Clear();
        }

        private void txt_id_articulo_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            txt_id_articulo.SelectionStart = txt_id_articulo.Text.Length;

        }

        private void txt_patron_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            txt_patron.SelectionStart = txt_patron.Text.Length;

        }

        private void Frm_ABM_Articulo_Load(object sender, EventArgs e)
        {
            this.grid_articulo.Formatear("cod_articulo, 100, I; num_serie,100, I;num_lote,100,I;" +
                "nombre,100,I;cuit_proveedor,15,I;precio, 100, I;" +
                "tiempo_envio, 100, I;plazo_pago, 100, I;id_rubro, 100, I;stock, 100, I");
        }
    }
}
