using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace winAppSAIC.UtileriasLocal
{
    public class Estructuras
    {
        public struct InformacionLoteCargaNomina
        {
            public long idLoteCargaNomina;
            public string folioLoteCargaNomina;
            public string tipoNomina;
            public Int32 idTenedora;
            public string rfcTenedora;
            public string idTipoMovimiento;
            public string TipoVersion;

            //Agregado Para Certificados
            public byte[] CertificadoPen;
            public byte[] KeyPen;
            public byte[] KeyEnc;
            public string ContrasenaKey;
            public string Usuario;
            public string Password;
            public byte[] Certificado;
            public byte[] Key;
            public int iAPPJ;
            public string Motivo;
        }

        public struct InformacionError
        {
            public bool existeError;
            public long noError;
            public string mensajeError;
        }
    }
}
