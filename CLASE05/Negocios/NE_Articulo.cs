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
    class NE_Articulo
    {
        public enum Validacion { correcta, incorrecta }

        public string cod_articulo { get; set; }
        public string num_serie { get; set; }
        public string num_lote { get; set; }
        public string nombre { get; set; }
        public string cuit_proveedor { get; set; }

        BE_Acceso_Datos _BD = new BE_Acceso_Datos();

        public Validacion Validar(string cod_articulo,
            string num_serie,string num_lote, string nombre,
            string cuit_proveedor)
        {
            string sql = @"SELECT * FROM articulo
                          WHERE cod_articulo = '" + cod_articulo + "'"
                         + " AND num_serie = '" + num_serie + "'"
                         + " AND num_lote = '" + num_lote + "'"
                         + " AND nombre = '" + nombre + "'"
                         + " AND cuit_proveedor = '" + cuit_proveedor + "'";

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
        public int RecuperarCuit(string cuit_proveedor, string nombre)
        {
            string sql = @"SELECT cuit_proveedor FROM articulo
                         WHERE cuit_proveedor = '" + cuit_proveedor + "'"
                        + " AND nombre = '" + nombre + "'";

            DataTable tabla = new DataTable();
            tabla = _BD.EjecutarSelect(sql);

            if (tabla.Rows.Count == 1)
                return int.Parse(tabla.Rows[0][0].ToString());
            else
                return 0;
        }
        public DataTable BuscarArticulo(string patron, string columna)
        {
            string sql = @"SELECT cod_articulo, nombre 
                          FROM articulo WHERE " + columna + " like '%" + patron + "%'";

            return _BD.EjecutarSelect(sql);
        }
        public DataTable BuscarArticulo(string cod_articulo)
        {
            string sql = @"SELECT cod_articulo, nombre,cuit_proveedor 
                          FROM articulo WHERE cod_articulo = " + cod_articulo;

            return _BD.EjecutarSelect(sql);
        }
        public DataTable RecuperarArticulo(string cod_articulo)
        {
            string sql = @"SELECT * 
                          FROM articulo WHERE cod_articulo = " + cod_articulo;

            return _BD.EjecutarSelect(sql);
        }
        public void Insertar()
        {
            string sqlInsert = "";

            sqlInsert = @"INSERT INTO articulo (cod_articulo, num_serie, num_lote, 
                        nombre, cuit_proveedor) VALUES (";
            sqlInsert += "'" + cod_articulo + "'";
            sqlInsert += "'" + num_serie + "'";
            sqlInsert += "'" + num_lote + "'";
            sqlInsert += "'" + nombre + "'";
            sqlInsert += ", '" + cuit_proveedor + "')";

            //MessageBox.Show(sqlInsert);
            _BD.Insertar(sqlInsert);
        }
        public void Modificar()
        {
            string sqlUpdate = "";

            sqlUpdate = "UPDATE articulo SET ";
            sqlUpdate += "n_usuario = '" + cod_articulo + "'";
            sqlUpdate += ", password = '" + num_serie + "'";
            sqlUpdate += ", password = '" + num_lote + "'";
            sqlUpdate += ", password = '" + nombre + "'";
            sqlUpdate += " WHERE id_usuario = " + cuit_proveedor;

            _BD.Modificar(sqlUpdate);
        }
        public void Borrar()
        {
            string sqlDelete = "DELETE FROM articulo WHERE cod_articulo = " + cod_articulo;

            _BD.Borrar(sqlDelete);
        }

    }
}
