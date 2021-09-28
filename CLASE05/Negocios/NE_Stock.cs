using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLASE05.Clases;
using System.Windows.Forms;

namespace CLASE05.Negocios
{
    class NE_Stock
    {
        public enum Validacion { correcta, incorrecta }
        public string cod_articulo { get; set; }
        public string cantidad { get; set; }
        BE_Acceso_Datos _BD = new BE_Acceso_Datos();
    }
    public Validacion Validar(string num_serie, string num_lote, string nombre,
            string cuit_proveedor)
    {
        string sql = @"SELECT * FROM stock
                          WHERE cod_articulo = '" + cod_articulo + "'"
                     + " AND cantidad = '" + cantidad  + "'";

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
    public DataTable BuscarStock(string patron, string columna)
    {
        string sql = @"SELECT cod_articulo 
                          FROM stock WHERE " + columna + " like '%" + patron + "%'";

        return _BD.EjecutarSelect(sql);
    }
    public DataTable BuscarStock(string cod_articulo)
    {
        string sql = @"SELECT cod_articulo
                          FROM articulo WHERE cod_articulo = " + cod_articulo;

        return _BD.EjecutarSelect(sql);
    }
    public DataTable Recuperar_X_Todo()
    {
        string sql = @"SELECT * FROM stock";
        return _BD.EjecutarSelect(sql);
    }
    public DataTable RecuperarStock(string cod_articulo)
    {
        string sql = @"SELECT * 
                          FROM stock WHERE cod_articulo = " + cod_articulo;

        return _BD.EjecutarSelect(sql);
    }
    public DataTable Recuperar_X_Id(string id)
    {
        string sql = @"SELECT * FROM stock WHERE codigo_articulo = " + id;
        return _BD.EjecutarSelect(sql);
    }
    public DataTable Recuperar_X_Patron(string patron)
    {
        string sql = @"SELECT * FROM stock WHERE codigo_articulo = " + patron;
        return _BD.EjecutarSelect(sql);
    }

    public void Insertar()
    {
        string sqlInsert = "";

        sqlInsert = @"INSERT INTO articulo (cod_articulo, cantidad) VALUES (";
        sqlInsert += "'" + cod_articulo + "'";
        sqlInsert += ", '" + cantidad + "'";
        )";

        //MessageBox.Show(sqlInsert);
        _BD.Insertar(sqlInsert);
    }
    public void Modificar()
    {
        string sqlUpdate = "";

        sqlUpdate = "UPDATE stock SET ";
        sqlUpdate += "cantidad = '" + cantidad + "'";
        sqlUpdate += " WHERE cod_articulo = '" + cod_articulo + "'";

        _BD.Modificar(sqlUpdate);
    }
    public void Borrar()
    {
        string sqlDelete = "DELETE FROM stock WHERE cod_articulo = " + cod_articulo;

        _BD.Borrar(sqlDelete);
    }

}
