using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace compNominaCFDI
{
    public class PercepcionDeduccion
    {
        public Int64 IdPDODetail { get; set; }
        public string tipoPercepcionDeduccion{ get; set; }
        public string clave { get; set; }       //sueldos y salarios
        public Int32 IdConcepto { get; set; }
        public string concepto{ get; set; }
        public decimal importePDO{ get; set; }
        public decimal importeGravado { get; set; }        
        public decimal importeExento{ get; set; }
        public Int64 IdPDOHeader { get; set; }
        public string ClasifConcepto { get; set; }
        public string DescClasifConcepto { get; set; }      //columnas para timbre facil
        public short NoColumnaGravada { get; set; }
        public short NoColumnaExenta { get; set; }

        public int AplicaOtrosPagosSAT { get; set; }
        //objNomina.idTipoOtrasPer= Convert.ToInt32(row["idTipoOtrasPer"].ToString());

    }
}
