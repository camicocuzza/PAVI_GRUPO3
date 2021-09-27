using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Data;

namespace CLASE05.Clases
{
    class TratamientosEspeciales
    {
        public enum RespuestaValidacion { Correcta, Error }

        public RespuestaValidacion Validar(Control.ControlCollection Controles)
        {
            foreach (var item in Controles)
            {
                if (item.GetType().Name == "LabelText02")
                {
                    if(((LabelText02)item)._Validable==true)
                    {
                        if(((LabelText02)item)._Text==string.Empty)
                        {
                            MessageBox.Show(((LabelText02)item)._MensajeError);
                            ((LabelText02)item).Focus();
                            return RespuestaValidacion.Error;
                        }
                    }
                }
                if (item.GetType().Name == "ComboBox01")
                {
                  if (((ComboBox01)item)._Validable == true)
                    {
                        if(((ComboBox01)item).SelectedIndex == -1)
                        {
                            MessageBox.Show(((ComboBox01)item)._MensajeError);
                            ((ComboBox01)item).Focus();
                            return RespuestaValidacion.Error;
                        }
                    }
                }
            }
            return RespuestaValidacion.Correcta;
        }
        public RespuestaValidacion ValidarEmail (string email)
        {
            if (email.IndexOf("@") == -1)
                return RespuestaValidacion.Error;
            else
                return RespuestaValidacion.Correcta;
        }
        public RespuestaValidacion ValidarFecha(string fecha)
        {
            DateTime fechadev;

            if (DateTime.TryParseExact(fecha, "dd/mm/yyyy", null, DateTimeStyles.AssumeLocal, out fechadev))
                return RespuestaValidacion.Correcta;
            else
                return RespuestaValidacion.Error;
        }
        public RespuestaValidacion ValidarFecha1 (string fecha)
        {
            try
            {
                DateTime.Parse(fecha);
                return RespuestaValidacion.Correcta;
            }
            catch (Exception)
            {
                return RespuestaValidacion.Error;
            }
        }
        public string RecuperarFecha()
        {
            BE_Acceso_Datos _BD = new BE_Acceso_Datos();
            return _BD.EjecutarSelect("select convert(char(10),getdate(),103)").Rows[0][0].ToString();
        }
        
        

    }
}
