
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace winAppSAIC.NominaCFDI.Clases
{
    public class Lote
    {
        public int idLote { get; set; }
        public int idTenedora { get; set; }
        public String Tenedora_NombreComercial { get; set; }
        public int idCliente { get; set; }
        public String Cliente_NombreComercial { get; set; }
        public String FolioLoteCargaNomina { get; set; }
        public int idOperador { get; set; }
        public String Operador { get; set; }
        public int EstatusBorrado { get; set; }
        public int EstatusCierre { get; set; }
        public int EstatusNominaCerrada { get; set; }
        public int EstatusNominaContabilizada { get; set; }
        public int EstatusNominaPagada { get; set; }
        public int EstatusTimbradoCFDI { get; set; }


        public Lote ObtenerInformacionLoteCargaNomina(int idLoteCargaNomina)
        {
            Lote miLote = new Lote();

            String sConexionBD = winAppSAIC.Properties.Settings.Default.dbSAICBPOConnectionString;
            try
            {
                using (SqlConnection Cnn = new SqlConnection(sConexionBD))
                {
                    SqlCommand cmd = new SqlCommand("dbo.stpSelObtenerInfoLoteCargaNomina", Cnn)
                    { CommandType = CommandType.StoredProcedure };

                    cmd.Parameters.AddWithValue("@pIdLoteCargaNomina", idLoteCargaNomina);
                    Cnn.Open();
                    cmd.ExecuteNonQuery();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            miLote.idLote = idLoteCargaNomina;
                            miLote.FolioLoteCargaNomina = reader.GetString(1);
                            miLote.idTenedora = Convert.ToInt32(reader.GetValue(2).ToString());
                            miLote.Tenedora_NombreComercial = reader.GetString(3);
                            miLote.idCliente = Convert.ToInt32(reader.GetValue(4).ToString());
                            miLote.Cliente_NombreComercial = reader.GetString(5);
                            miLote.idOperador = Convert.ToInt32(reader.GetValue(6).ToString());
                            miLote.Operador = reader.GetString(7);
                            miLote.EstatusBorrado = Convert.ToInt32(reader.GetValue(8).ToString());
                            miLote.EstatusCierre = Convert.ToInt32(reader.GetValue(9).ToString());
                            miLote.EstatusNominaCerrada = Convert.ToInt32(reader.GetValue(10).ToString());
                            miLote.EstatusNominaContabilizada = Convert.ToInt32(reader.GetValue(11).ToString());
                            miLote.EstatusNominaPagada = Convert.ToInt32(reader.GetValue(12).ToString());
                            miLote.EstatusTimbradoCFDI = Convert.ToInt32(reader.GetValue(13).ToString());
                        }
                    }
                    Cnn.Close();    //cerrar conexion
                }
            }
            catch (SqlException ex) { }
            catch (Exception ex) { }

            return miLote;
        }
    }

}
