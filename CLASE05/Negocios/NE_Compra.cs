using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLASE05.Clases;
using System.Data;
using System.Windows.Forms;

namespace CLASE05.Negocios
{
    class NE_Compra
    {
        public enum Validacion { correcta, incorrecta }

        public string num_compra { get; set; }
        public string cuit_proveedor { get; set; }
        public string fecha { get; set; }
        public string monto_total { get; set; }

        BE_Acceso_Datos _BD = new BE_Acceso_Datos();

        public Validacion Validar(string fecha)
        {
            string sql = @"SELECT * FROM compra
                         WHERE fecha = '" + fecha + "'";

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

        public int RecuperarId(string fecha)
        {
            string sql = @"SELECT num_compra FROM compra
                         WHERE fecha = '" + fecha + "'";

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
                     + " FROM compra "
                     + " WHERE fecha like '%" + patron.Trim() + "%'";

            return _BD.EjecutarSelect(sql);

        }

        public DataTable Recuperar_x_Id(string id)
        {
            string sql = @"SELECT * FROM compra WHERE num_compra = " + id;
            return _BD.EjecutarSelect(sql);
        }

        public DataTable consultar_tipo_factura()
        {
            string sql = "SELECT num_compra, fecha FROM compra";

            DataTable Resultado = new DataTable();
            Resultado = _BD.EjecutarSelect(sql);
            return Resultado;
        }

        public DataTable Recuperar_Todos()
        {
            string sql = @"SELECT * FROM compra";
            return _BD.EjecutarSelect(sql);
        }

        public DataTable BuscarCompra(string patron, string columna)
        {
            string sql = @"SELECT num_compra, fecha
                          FROM compra WHERE " + columna + " like '%" + patron + "%'";

            return _BD.EjecutarSelect(sql);
        }

        public DataTable RecuperarCompra(string num_compra)
        {
            string sql = @"SELECT * 
                          FROM compra WHERE num_compra = " + num_compra;

            return _BD.EjecutarSelect(sql);
        }

        public void Insertar()
        {
            string sqlInsert = "";


            sqlInsert = @"INSERT INTO compra (cui_proveedor, fecha, monto_total) VALUES (";
            sqlInsert += "'" + cuit_proveedor + "'";
            sqlInsert += "'insert datetime sql'" + fecha + "'";
            sqlInsert += "'" + monto_total + "')";

            //MessageBox.Show(sqlInsert);
            _BD.Insertar(sqlInsert);
        }
        public void Modificar()
        {
            string sqlUpdate = "";

            sqlUpdate = "UPDATE compra SET ";

            sqlUpdate += ", cuit_proveedor = '" + cuit_proveedor + "'";
            sqlUpdate += " fehca = '" + fecha + "'";
            sqlUpdate += ", monto_total = '" + monto_total + "'";
            sqlUpdate += " WHERE num_compra = " + num_compra;

            _BD.Modificar(sqlUpdate);
        }

        public void Borrar()
        {
            string sqlDelete = "DELETE FROM compra WHERE num_compra = " + num_compra;

            _BD.Borrar(sqlDelete);
        }
    }
}