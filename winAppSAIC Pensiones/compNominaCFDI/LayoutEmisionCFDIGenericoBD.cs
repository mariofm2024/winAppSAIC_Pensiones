using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace compNominaCFDI
{
    public static class LayoutEmisionCFDIGenericoBD
    {
        // Methods
        public static Nomina ObtenerInfoReciboCFDI(DataTable dt, long pIntPDOHeader)
        {
            Func<DataRow, bool> predicate = null;
            Nomina nomina = new Nomina();
            try
            {
                if (predicate == null)
                {
                    predicate = o => o.Field<long>("IdPDOHeader") == pIntPDOHeader;
                }
                foreach (var type in dt.AsEnumerable().Where<DataRow>(predicate).Select(o => new { IdTenedora = o.Field<int>("IdTenedora"), RazonSocial = o.Field<string>("RazonSocial"), RFCTenedora = o.Field<string>("RFCTenedora"), NombreEmpleado = o.Field<string>("NombreEmpleado"), APaternoEmpleado = o.Field<string>("APaternoEmpleado"), AMaternoEmpleado = o.Field<string>("AMaternoEmpleado"), RFCEmpleado = o.Field<string>("RFCEmpleado"), IdEmpleado = o.Field<int>("IdEmpleado"), Serie = o.Field<string>("Serie"), Folio = o.Field<string>("FolioInterno"), IdCliente = o.Field<int>("IdCliente"), IdLoteCargaNomina = o.Field<long>("IdLoteCargaNomina"), FolioLoteCargaNomina = o.Field<string>("FolioLoteCargaNomina"), XmlCFDI = o.Field<string>("xmlCFDI"), FolioFiscalUUID = o.Field<string>("FolioFiscalUUID"), CorreoElectronico = o.Field<string>("CorreoElectronico"), APPJ = o.Field<bool>("APPJ"),
                    VersionCFDI = o.Field<string>("VersionCFDI")
                }))
                {
                    nomina.idTenedora = type.IdTenedora;
                    nomina.razonSocialTenedora = type.RazonSocial;
                    nomina.rfcTenedora = type.RFCTenedora;
                    nomina.rfc = type.RFCEmpleado;
                    nomina.nombre = string.Format("{0} {1} {2}", type.NombreEmpleado, type.APaternoEmpleado, type.AMaternoEmpleado);
                    nomina.numEmpleado = type.IdEmpleado.ToString();
                    nomina.serieRecibo = type.Serie;
                    nomina.folioRecibo = type.Folio;
                    nomina.idCliente = type.IdCliente;
                    nomina.IdLoteCargaNomina = type.IdLoteCargaNomina;
                    nomina.folioLoteCargaNomina = type.FolioLoteCargaNomina;
                    if (type.XmlCFDI.Contains("PD94"))
                    {
                        byte[] data = Convert.FromBase64String(type.XmlCFDI);  //xmlCFDi
                        nomina.xmlCFDI = Encoding.UTF8.GetString(data);
                    }
                    else
                        nomina.xmlCFDI = type.XmlCFDI;                  

                    nomina.renglon5Informativo = type.FolioFiscalUUID;
                    nomina.correoElectronico = type.CorreoElectronico;
                    nomina.iAPPJ = Convert.ToInt16(type.APPJ);
                    nomina.VersionCFDI = type.VersionCFDI;
                }
            }
            catch
            {
                nomina = null;
            }
            return nomina;
        }

    }
}
