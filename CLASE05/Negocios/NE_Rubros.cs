﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLASE05.Clases;
using System.Data;
using System.Windows.Forms;

namespace CLASE05.Negocios
{
    class NE_Rubros
    {
        public enum Validacion { correcta, incorrecta }

        public string id_rubro { get; set; }
        public string nombre { get; set; }

        BE_Acceso_Datos _BD = new BE_Acceso_Datos();

        public Validacion Validar(string nombre)
        {
            string sql = @"SELECT * FROM rubro
                         WHERE nombre = '" + nombre + "'";

            DataTable tabla = new DataTable();
            tabla = _BD.EjecutarSelect(sql);

            if (tabla.Rows.Count == 1)
            {
                return Validacion.correcta;
            }
            else
            {
                return Validacion.incorrecta;
            }
        }

        public int RecuperarId(string nombre)
        {
            string sql = @"SELECT id_rubro FROM rubro
                         WHERE nombre = '" + nombre + "'";

            DataTable tabla = new DataTable();
            tabla = _BD.EjecutarSelect(sql);

            if (tabla.Rows.Count == 1)
                return int.Parse(tabla.Rows[0][0].ToString());
            else
                return 0;
        }

        public DataTable Recuperar_x_Patron(string patron)
        {
            string sql = @"SELECT * "
                     + " FROM rubro "
                     + " WHERE nombre like '%" + patron.Trim() + "%'";

            return _BD.EjecutarSelect(sql);

        }

        public DataTable Recuperar_x_Id(string id)
        {
            string sql = @"SELECT * FROM rubro WHERE id_rubro = " + id;
            return _BD.EjecutarSelect(sql);
        }

        public DataTable consultar_tipo_factura()
        {
            string sql = "SELECT id_rubro, nombre FROM rubro";

            DataTable Resultado = new DataTable();
            Resultado = _BD.EjecutarSelect(sql);
            return Resultado;
        }

        public DataTable Recuperar_Todos()
        {
            string sql = @"SELECT * FROM rubro";
            return _BD.EjecutarSelect(sql);
        }

        public DataTable BuscarRubro(string patron, string columna)
        {
            string sql = @"SELECT id_rubro, nombre
                          FROM rubro WHERE " + columna + " like '%" + patron + "%'";

            return _BD.EjecutarSelect(sql);
        }
        public DataTable BuscarRubro(string id_rubro)
        {
            string sql = @"SELECT id_rubro, nombre
                          FROM rubro WHERE id_rubro = " + id_rubro;

            return _BD.EjecutarSelect(sql);
        }
        public DataTable RecuperarRubro(string id_rubro)
        {
            string sql = @"SELECT * 
                          FROM rubro WHERE id_rubro = " + id_rubro;

            return _BD.EjecutarSelect(sql);
        }

        public void Insertar()
        {
            string sqlInsert = "";


            sqlInsert = @"INSERT INTO rubro (nombre) VALUES (";
            sqlInsert += "'" + nombre + "')";

            //MessageBox.Show(sqlInsert);
            _BD.Insertar(sqlInsert);
        }
        public void Modificar(int id)
        {
            string sqlUpdate = "";

            sqlUpdate = "UPDATE rubro SET ";
            sqlUpdate += " nombre = '" + nombre + "'";
            sqlUpdate += " WHERE id_rubro = '" + id + "'";

            _BD.Modificar(sqlUpdate);
        }

        public void Borrar()
        {
            string sqlDelete = "DELETE FROM rubro WHERE id_rubro = " + id_rubro;

            _BD.Borrar(sqlDelete);
        }

    }
}