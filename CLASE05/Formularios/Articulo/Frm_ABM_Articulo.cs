﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLASE05.Formularios.Articulo
{
    public partial class Frm_ABM_Articulo : CLASE05.Formularios.FrmBASE.FrmBase_ABM_Entrada
    {
        public Frm_ABM_Articulo()
        {
            InitializeComponent();
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            Frm_Consulta_Articulo frm_alta = new Frm_Consulta_Articulo();
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

        private void Frm_ABM_Articulo_Load(object sender, EventArgs e)
        {

        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            Frm_Baja_Articulo frm_alta = new Frm_Baja_Articulo();
            frm_alta.ShowDialog();
        }
    }
}
