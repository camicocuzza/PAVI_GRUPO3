using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLASE05.Clases;
using System.Windows.Forms;

namespace CLASE05.Negocios
{
    class NE_Cliente
    {
        public enum Validacion { correcta, incorrecta }
        public string id_cliente { get; set; }
        public string cuit_cliente { get; set; }
        public string razon_social { get; set; }
        public string nombre_contacto { get; set; }
        public string domicilio { get; set; }
        public string ciudad { get; set; }


        BE_Acceso_Datos _BD = new BE_Acceso_Datos();
        public Validacion Validar(string id_cliente, string cuit_cliente, string razon_social, string nombre_contacto, string domicilio, string ciudad)
        {
            string sql = @"SELECT * FROM cliente_o
                          WHERE id_cliente = '" + id_cliente + "'" + " AND cuit_cliente = '" + cuit_cliente + "'" + " AND razon_social = '" + razon_social + "'" + "AND nombre_contacto = '" + nombre_contacto + "'" + "AND domicilio = '" + domicilio + "'" + "AND ciudad = '" + ciudad + "'";

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
        public DataTable RecuperarTodo()
        {
            string sql = @"SELECT * FROM cliente_o";
            return _BD.EjecutarSelect(sql);
        }
        public DataTable Recuperar_x_Id(string id)
        {
            string sql = @"SELECT * FROM cliente_o WHERE id_cliente = " + id;
            return _BD.EjecutarSelect(sql);
        }
        public DataTable Recuperar_x_Patron(string patron)
        {
            string sql = @"SELECT * "
                     + " FROM cliente_o "
                     + " WHERE razon_social like '%" + patron.Trim() + "%'";

            return _BD.EjecutarSelect(sql);
        }
        public DataTable RecuperarCliente(string id_cliente)
        {
            string sql = @"SELECT * 
                         FROM cliente_o WHERE id_cliente = " + id_cliente;
            return _BD.EjecutarSelect(sql);
        }
        
        
        public void Insertar()
        {
            string sqlInsert = "";

            sqlInsert = @"INSERT INTO cliente_o (cuit_cliente,razon_social, nombre_contacto, domicilio, ciudad) VALUES (";
            sqlInsert += "'" + cuit_cliente + "'";
            sqlInsert += ", '" + razon_social + "'";
            sqlInsert += ",'" + nombre_contacto + "'";
            sqlInsert += ", '" + domicilio + "'";
            sqlInsert += ",'" + ciudad + "')";


             _BD.Insertar(sqlInsert);
        }
        //public string Insertar(Control.ControlCollection Controles)
        //{
        //    TratamientosEspeciales _TE = new TratamientosEspeciales();
        //    return _BD.Insertar(_TE.SqlInsertAutomatico("cliente", Controles), BE_Acceso_Datos.RecuperacionPk.recuperar);
        //}
        public void Modificar()
        {

            string sqlUpdate = "";
            sqlUpdate = "UPDATE cliente_o SET ";
            sqlUpdate += "cuit_cliente = '" + cuit_cliente + "'";
            sqlUpdate += ", razon_social = '" + razon_social + "'";
            sqlUpdate += ", nombre_contacto = '" + nombre_contacto + "'";
            sqlUpdate += ", domicilio = '" + domicilio + "'";
            sqlUpdate += ", ciudad = '" + ciudad + "'";
            sqlUpdate += " WHERE id_cliente = " + id_cliente; 

            _BD.Modificar(sqlUpdate);
        }
        public void Borrar()
        {
            string sqlDelete = "DELETE FROM cliente_o WHERE id_cliente = " + id_cliente;

            _BD.Borrar(sqlDelete);
        }
    }
}
