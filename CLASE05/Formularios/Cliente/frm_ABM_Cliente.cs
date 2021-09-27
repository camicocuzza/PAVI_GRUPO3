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
using CLASE05.Formularios;
using CLASE05.Formularios.Cliente;

namespace CLASE05.Formularios.TipoDocumento
{
    public partial class frm_ABM_tipoDocumento : CLASE05.Formularios.FrmBASE.FrmBase_ABM_Entrada
    {
        public frm_ABM_tipoDocumento()
        {
            InitializeComponent();
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            Frm_Validar_Cliente frm_consultar = new Frm_Validar_Cliente();
            //frm_consultar.id_cliente = dataGrid_cliente.CurrentRow.Cells[0].Value.ToString();
            frm_consultar.ShowDialog();
        }

        private void btn_alta_Click(object sender, EventArgs e)
        {
            Frm_Alta_tipoDocumento frm_alta = new Frm_Alta_tipoDocumento();
            frm_alta.ShowDialog();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (dataGrid_cliente.Rows.Count == 0)
            {
                MessageBox.Show("Falta buscar cliente", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (dataGrid_cliente.CurrentCell.RowIndex == -1)
            {
                MessageBox.Show("Falta seleccionar un cliente", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            //    if (cuit_cliente == "")
            //    {
            //        MessageBox.Show("Debe seleccionar un elemento de la grilla");
            //        return;
            //    }
            Frm_Modificar_tipoDocumento Modificar = new Frm_Modificar_tipoDocumento();
            Modificar.id_cliente = dataGrid_cliente.CurrentRow.Cells[0].Value.ToString(); ;
            Modificar.ShowDialog();
            dataGrid_cliente.Rows.Clear();

            
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            Frm_Baja_tipoDocumento frm_alta = new Frm_Baja_tipoDocumento();
            frm_alta.ShowDialog();
        }

        private void rb_cuit_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_id_cliente.Checked == true)
            {
                txt_id_cliente.Enabled = true;
                textBoxPatronBusqueda.Enabled = false;
                textBoxPatronBusqueda.Clear();
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            BuscarDatosCliente();

            

        }
        private void BuscarDatosCliente()
        {
            NE_Cliente  usu = new NE_Cliente();
            DataTable tabla = new DataTable();

            if (textBoxPatronBusqueda.Text != string.Empty)
            {
                if (rb_razon_social.Checked == true)
                {
                    dataGrid_cliente.Cargar(usu.Recuperar_x_Patron(textBoxPatronBusqueda.Text));

                    if (dataGrid_cliente.Rows.Count == 0)
                        MessageBox.Show("No se encontró ningún cliente", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                
            }
            if (txt_id_cliente.Text != string.Empty)
            {
                if (rb_id_cliente.Checked == true)
                {
                    dataGrid_cliente.Cargar(usu.Recuperar_x_Id(txt_id_cliente.Text));
                    if (dataGrid_cliente.Rows.Count == 0)
                        MessageBox.Show("No se encontró ningún cliente", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            
            if (rb_todo.Checked == true)
            {
                tabla = usu.RecuperarTodo();
                dataGrid_cliente.Cargar(tabla);
                return;
            }
            MessageBox.Show("No hay parámetros de búsqueda", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }


        private void btn_borrar_Click_1(object sender, EventArgs e)
        {
            if (dataGrid_cliente.Rows.Count == 0)
            {
                MessageBox.Show("Falta buscar Cliente", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (dataGrid_cliente.CurrentCell.RowIndex == -1)
            {
                MessageBox.Show("Falta seleccionar un Cliente", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            //    if (cuit_cliente == "")
            //    {
            //        MessageBox.Show("Debe seleccionar un elemento de la grilla");
            //        return;
            //    }
            Frm_Baja_tipoDocumento Borrar = new Frm_Baja_tipoDocumento();
            Borrar.id_cliente = dataGrid_cliente.CurrentRow.Cells[0].Value.ToString(); 
            Borrar.ShowDialog();
            dataGrid_cliente.Rows.Clear();
        }

        private void frm_ABM_tipoDocumento_Load(object sender, EventArgs e)
        {
            this.dataGrid_cliente.Formatear("id_cliente, 100, C; cuit_cliente, 100, I; razon_social, 150, I; nombre_contacto, 150, I; direccion, 150, I; ciudad, 150 ,I");
        }

        private void dataGrid_cliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //cuit_cliente = dataGrid_cliente.CurrentRow.Cells["cuit_cliente"].Value.ToString();
        }

        private void dataGrid_cliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Frm_Validar_Cliente frm_consultar = new Frm_Validar_Cliente();
            frm_consultar.id_cliente = dataGrid_cliente.CurrentRow.Cells[0].Value.ToString();
            frm_consultar.ShowDialog();
        }
    }
}
