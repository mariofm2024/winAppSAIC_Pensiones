using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.ServiceModel.Channels;
using System.Net;
using System.Xml.Linq;
using winAppSAIC.srvComEnlaceFiscalAPI;

namespace winAppSAIC.NominaCFDI
{
    class APIEF
    {
        private string user;
        private string password;
        private Hashtable operations;

        ///<summary>
        ///Referencia al servicio API de Enlace Fiscal
        ///</summary>
        ///<remarks>
        ///Importante agregar como Service References
        ///</remarks>
        private wsAPIxmlSOAPClient wsEF;

        ///<summary>
        ///Constructor de la clase
        ///</summary>
        ///<param name="user">
        ///Usuario asignado para el acceso al API
        ///</param>
        ///<param name="password">
        ///Contraseña de acceso
        ///</param>
        public APIEF(string user, string password)
        {
            this.user = user;
            this.password = password;
        }

        ///<summary>
        ///Realiza la autenticación para la petición
        ///</summary>
        public void authenticate()
        {
            wsEF = new wsAPIxmlSOAPClient();
            wsEF.ClientCredentials.UserName.UserName = this.user;
            wsEF.ClientCredentials.UserName.Password = this.password;
        }

        ///<summary>
        ///Ejecuta una petición a la API de Enlace Fiscal
        ///</summary>
        ///<return type="string">
        ///Respuesta de la petición en formato XML
        ///</return>
        ///<param name="xmlRequestString" type="string">
        ///Cadena XML de la petición
        ///</param>
        ///<param name="operation" type="string">
        ///Tipo de operación a ejecutar
        ///</param>
        public string executeOperation(string xmlRequestString, string operation)
        {
            string xmlResponse = "";

            authenticate();

            //Se realiza la Pre-Autenticación de forma manual ya que WCF no lo soporta de forma nativa
            using (new System.ServiceModel.OperationContextScope((System.ServiceModel.IClientChannel)wsEF.InnerChannel))
            {
                string credentials = String.Format("{0}:{1}", wsEF.ClientCredentials.UserName.UserName, wsEF.ClientCredentials.UserName.Password);
                string credentialsToHeader = "Basic " + Convert.ToBase64String(Encoding.ASCII.GetBytes(credentials));

                //Se agrega el header de autenticación a la petición
                System.ServiceModel.Web.WebOperationContext.Current.OutgoingRequest.Headers.Add("Authorization", credentialsToHeader);

                //Se invoca la petición
                switch (operation)
                {
                    case "probarConexion":
                        xmlResponse = wsEF.probarConexionAsalariado(xmlRequestString);
                        break;

                    case "generarAsalariado":
                        xmlResponse = wsEF.generarAsalariado(xmlRequestString);
                        break;

                    case "generarAsimilable":
                        xmlResponse = wsEF.generarAsimilable(xmlRequestString);
                        break;


                    case "cancelarAsalariado":
                        xmlResponse = wsEF.cancelarAsalariado(xmlRequestString);
                        break;

                    case "cancelarAsimilable":
                        xmlResponse = wsEF.cancelarAsimilable(xmlRequestString);
                        break;
                }

            }

            return xmlResponse;
        }

        public string FormatXml(String Xml)
        {
            try
            {
                XDocument doc = XDocument.Parse(Xml);
                return doc.ToString();
            }
            catch (Exception)
            {
                return Xml;
            }
        }


    }
}
