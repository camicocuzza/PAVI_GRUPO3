using CLASE05.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLASE05.Negocios
{
    class NE_Empleado
    {
        public enum Validacion { correcta, incorrecta }

        public string legajo_empleado { get; set; }
        public string apellido { get; set; }
        public string direccion { get; set; }
        public string documento { get; set; }
        public string telefono { get; set; }
        public string fecha_ingreso { get; set; }
        public string puesto { get; set; }

        BE_Acceso_Datos _BD = new BE_Acceso_Datos();

        public Validacion Validar(string legajo_empleado, string apellido, string direccion, string documento, string telefono, string fecha_ingreso, string puesto)
        {
            string sql = @"SELECT * FROM empleado
                          WHERE legajo_empleado = '" + legajo_empleado + "'"
                         + " AND apellido = '" + apellido + "'" + "AND direccion = '" + direccion + "'" + "AND documento = '" + documento + "'"
                         + "AND telefono = '" + telefono + "'" + "AND fecha_ingreso = '" + fecha_ingreso + "'"
                         + "AND puesto = '" + puesto + "'";

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

        

        public int RecuperarId(string legajo_empleado, string apellido, string direccion, string documento, string telefono, string fecha_ingreso, string puesto)
        {
            string sql = @"SELECT * FROM empleado
                          WHERE legajo_empleado = '" + legajo_empleado + "'"
                         + " AND apellido = '" + apellido + "'" + "AND direccion = '" + direccion + "'" + "AND documento = '" + documento + "'"
                         + "AND telefono = '" + telefono + "'" + "AND fecha_ingreso = '" + fecha_ingreso + "'" + "AND puesto = '" + puesto + "'";

            DataTable tabla = new DataTable();
            tabla = _BD.EjecutarSelect(sql);

            if (tabla.Rows.Count == 1)
                return int.Parse(tabla.Rows[0][0].ToString());
            else
                return 0;
        }

        internal void ShowDialog()
        {
            throw new NotImplementedException();
        }

        public DataTable BuscarEmpleado_X_Patron(string patron, string columna)
        {
            string sql = @"SELECT legajo_empleado, apellido 
                          FROM empleado WHERE " + columna + " like '%" + patron + "%'";

            return _BD.EjecutarSelect(sql);
        }

        public DataTable RecuperarEmpleado(string legajo_empleado)
        {
            string sql = @"SELECT * 
                          FROM empleado WHERE legajo_empleado = " + legajo_empleado;

            return _BD.EjecutarSelect(sql);
        }
        public DataTable RecuperarTodo()
        {
            string sql = @"SELECT * FROM empleado";
            return _BD.EjecutarSelect(sql);
        }
        public DataTable Recuperar_x_Id(string legajo_empleado)
        {
            string sql = @"SELECT * FROM empleado WHERE legajo_empleado = " + legajo_empleado;
            return _BD.EjecutarSelect(sql);
        }
        public DataTable Recuperar_x_Patron(string patron)
        {
            string sql = @"SELECT * "
                     + " FROM empleado "
                     + " WHERE apellido like '%" + patron.Trim() + "%'";

            return _BD.EjecutarSelect(sql);
        }
        public DataTable RecuperarIdEmpleado(string legajo_empleado)
        {
            string sql = @"SELECT * 
                          FROM empleado WHERE legajo_empleado = " + legajo_empleado;

            return _BD.EjecutarSelect(sql);
        }

        //public string Insertar(Control.ControlCollection Controles)
        //{
        //    TratamientosEspeciales _TE = new TratamientosEspeciales();
        //    return _BD.Insertar(_TE.SqlInsertAutomatico("empleado", Controles), BE_Acceso_Datos.RecuperacionPk.recuperar);
        //}
        public void Insertar()
        {
            string sqlInsert = "";

            sqlInsert = @"INSERT INTO empleado (apellido,direccion,documento,telefono,fecha_ingreso,puesto) VALUES (";
            sqlInsert += "'" + apellido + "'";
            sqlInsert += ", '" + direccion + "'";
            sqlInsert += ",'" + documento + "'";
            sqlInsert += ", '" + telefono + "'";
            sqlInsert += ", '" + fecha_ingreso + "'";
            sqlInsert += ",'" + puesto + "')";

             _BD.Insertar(sqlInsert);
        }

        public void Modificar()
        {
            string sqlUpdate = "";

            sqlUpdate = "UPDATE empleado SET ";
            sqlUpdate += "apellido = '" + apellido + "'";
            sqlUpdate += ", direccion = '" + direccion + "'";
            sqlUpdate += ", documento = '" + documento + "'";
            sqlUpdate += ", telefono = '" + telefono + "'";
            sqlUpdate += ", fecha_ingreso = CONVERT(DATE, '" + fecha_ingreso + "', 103)";
            sqlUpdate += ", puesto = '" + puesto + "'";
            sqlUpdate += " WHERE legajo_empleado = " + legajo_empleado;
            
            _BD.Modificar(sqlUpdate);
        }
        public void Borrar()
        {
            string sqlDelete = "DELETE FROM empleado WHERE legajo_empleado = " + legajo_empleado;

            _BD.Borrar(sqlDelete);
        }
    }
} 
