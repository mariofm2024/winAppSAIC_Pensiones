using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;

namespace compEmail
{
    public static class ConfiguracionNotificacionBD
    {
        // Methods
        public static ConfiguracionNotificacion ObtenerConfiguracionNotificacionCorreos(DataTable dt)
        {
            ConfiguracionNotificacion notificacion = null;
            try
            {
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    notificacion = new ConfiguracionNotificacion
                    {
                        IdConfiguracionNotificaciones = (short)row["IdConfiguracionNotificaciones"],
                        DescFuncionalidad = row["DescFuncionalidad"].ToString(),
                        SMTPServer = row["SMTPServer"].ToString(),
                        EmailUser = row["EmailUser"].ToString(),
                        EmailPassword = row["EmailPassword"].ToString(),
                        Puerto = row["Puerto"].ToString(),
                        FormatoHTML = (bool)row["FormatoHTML"],
                        SSL = (bool)row["SSL"]
                    };
                }
            }
            catch
            {
                return null;
            }
            return notificacion;
        }
    }

}
