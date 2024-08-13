using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace compEmail
{
    public class Notificacion
    {
        private const string smtpServer = "smtp.gmail.com";
        private const string emailUsuarioNotificacion = "notificacionsaic@gmail.com";
        private const string emailPwdNotificacion = "Z+mnYSe7u@#&";

        /// <summary>
        /// Método para envio de notificaciones por correo electrónico
        /// </summary>
        /// <param name="pDestinatario">Correo electrónico del Destinatario</param>
        /// <param name="pAsuntoCorreo">Subject del Correo</param>
        /// <param name="pCuerpoCorreo">Body del Correo</param>
        /// <returns>Valor VERDADERO o FALSO</returns>
        public static bool EnviarNotificacionCorreoElectronico(string pDestinatario, string pAsuntoCorreo, string pCuerpoCorreo)
        {
            try
            {
                var client = new SmtpClient(smtpServer, 587)
                {
                    Credentials = new NetworkCredential(emailUsuarioNotificacion, emailPwdNotificacion),
                    EnableSsl = true
                };
                client.Send(emailUsuarioNotificacion, pDestinatario, pAsuntoCorreo, pCuerpoCorreo);
            }
            catch 
            {
                return false;
            }
            return true;
        }


        /// <summary>
        /// Método para envio de notificaciones por correo electrónico
        /// </summary>
        /// <param name="pSmtpServer">IP o Nombre SMTP Server</param>
        /// <param name="pEmailUsuarioNotificacion">Correo Electrónico Usuario</param>
        /// <param name="pEmailPwdNotificacion">Contraseña Usuario</param>
        /// <param name="pPuerto">No. de Puerto SMTP</param>
        /// <param name="bFlagSSL">Valor VERDADERO o FALSO para soportar SSL</param>
        /// <param name="bFlagHTML">Valor VERDADERO o FALSO para soportar HTML</param>
        /// <param name="pDestinatario">Correo electrónico del Destinatario</param>
        /// <param name="pAsuntoCorreo">Subject del Correo</param>
        /// <param name="pCuerpoCorreo">Body del Correo</param>
        /// <returns>Valor VERDADERO o FALSO</returns>
        public static bool EnviarNotificacionCorreoElectronico(string pSmtpServer, string pEmailUsuarioNotificacion, 
            string pEmailPwdNotificacion, string pPuerto, bool bFlagSSL, bool bFlagHTML, string pDestinatario, 
            string pAsuntoCorreo, string pCuerpoCorreo)
        {
            try
            {
                //armar mensaje correo electronico
                MailMessage mail = new MailMessage() { From = new MailAddress(pEmailUsuarioNotificacion) };
                mail.To.Add(pDestinatario);
                mail.Subject = pAsuntoCorreo;
                mail.IsBodyHtml = bFlagHTML;
                mail.Body = pCuerpoCorreo;

                //configurar conexion SMTP Server
                var client = new SmtpClient(pSmtpServer, Convert.ToInt32(pPuerto))
                {
                    Credentials = new NetworkCredential(pEmailUsuarioNotificacion, pEmailPwdNotificacion),
                    EnableSsl = bFlagSSL
                };
                
                client.Send(mail);  //enviar correo electronico
            }
            catch
            {
                return false;
            }
            return true;
        }

    }
}
