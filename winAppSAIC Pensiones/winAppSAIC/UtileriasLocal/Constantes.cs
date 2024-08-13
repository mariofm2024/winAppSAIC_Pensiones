using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace winAppSAIC.UtileriasLocal
{
    public class Constantes
    {
        public enum TipoOperacionABC
        {
            Ninguno = 0,
            Nuevo = 1,
            Editar = 2,
            EditarNuevo = 3
        }

        public enum TipoOperacion
        {
            ModificacionEmpleado = 1,
            AsignacionNSSBajaReingreso = 2,
        }

        public enum TipoDireccionEmpleado
        {
            CentroTrabajo = 1,
            Particular = 2,
            Fiscal = 3
        }

        public enum TipoPerfil      //perfil de acceso
        {
            Operacion = 1,
            Contabilidad = 2,
            IMSS = 3,
            Juridico = 4
        }
        public enum FiltraPorIdLoteCargaNomina
        {
            Si = 1,
            No = 2
        }
    }
}
