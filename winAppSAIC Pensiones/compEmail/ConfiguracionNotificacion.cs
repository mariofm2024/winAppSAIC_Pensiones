using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace compEmail
{
    public class ConfiguracionNotificacion
    {
        public string DescFuncionalidad { get; set; }
        public string EmailPassword { get; set; }
        public string EmailUser { get; set; }
        public bool FormatoHTML { get; set; }
        public short IdConfiguracionNotificaciones { get; set; }
        public string Puerto { get; set; }
        public string SMTPServer { get; set; }
        public bool SSL { get; set; }
    }
}
