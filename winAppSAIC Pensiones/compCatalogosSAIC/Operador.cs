using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace compCatalogosSAIC
{
    /// <summary>
    /// Clase que engloba las propiedades del Operador
    /// para su integracion en la Aplicacion
    /// </summary>
    public class Operador
    {
        public short IdOperador
        { get; set; }

        public string ClaveInternaOperador
        { get; set; }

        public string NombreOperador
        { get; set; }

        public string NombreUsuario
        { get; set; }

        public string Contrasena
        { get; set; }

        public string CorreoElectronico
        { get; set; }

        public byte IdAreaOperativa
        { get; set; }

        public String AreaOperativa
        { get; set; }

        public short IdPlaza
        { get; set; }

        public bool Confidencial
        { get; set; }

        public bool ActivoParaNominas
        { get; set; }

        public bool Activo
        { get; set; }

        public byte IdEstatusReportes
        { get; set; }

        public short IdGrupo
        { get; set; }

        public string UsuarioCreacion
        { get; set; }

        public string UsuarioModificacion
        { get; set; }

        public string Grupo
        { get; set; }

        public int VigenciaContrasenia
        { get; set; }


    }
}
