﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CLASE05.Formularios.InicioSistema;
using CLASE05.Formularios.FrmBASE;
using CLASE05.Formularios.Usuarios;
using CLASE05.Formularios.TipoFactura;
using CLASE05.Formularios.Rubros;

namespace CLASE05
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Frm_Escritorio());
            //Application.Run(new Frm_Login());
            //Application.Run(new FrmLogin());
            //Application.Run(new Frm_ABM_Usuario_Entrada());
            //Application.Run(new Frm_Usuario_Alta());
            //Application.Run(new Frm_Log());
            //Application.Run(new Frm_ABM_TipoFactura());
            //Application.Run(new Frm_ABM_Rubros());
        }
    }
}
