//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.Erp.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_sis_Documento_Tipo_Talonario
    {
        public int IdEmpresa { get; set; }
        public string CodDocumentoTipo { get; set; }
        public string Establecimiento { get; set; }
        public string PuntoEmision { get; set; }
        public string NumDocumento { get; set; }
        public Nullable<System.DateTime> FechaCaducidad { get; set; }
        public Nullable<bool> Usado { get; set; }
        public string Estado { get; set; }
        public int IdSucursal { get; set; }
        public string NumAutorizacion { get; set; }
        public Nullable<bool> es_Documento_Electronico { get; set; }
    
        public virtual tb_sis_Documento_Tipo tb_sis_Documento_Tipo { get; set; }
        public virtual tb_sis_Documento_Tipo_x_Empresa tb_sis_Documento_Tipo_x_Empresa { get; set; }
    }
}