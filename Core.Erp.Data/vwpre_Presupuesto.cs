//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.Erp.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class vwpre_Presupuesto
    {
        public int IdEmpresa { get; set; }
        public decimal IdPresupuesto { get; set; }
        public int IdSucursal { get; set; }
        public string Su_Descripcion { get; set; }
        public decimal IdPeriodo { get; set; }
        public System.DateTime FechaInicio { get; set; }
        public System.DateTime FechaFin { get; set; }
        public bool EstadoCierre { get; set; }
        public int IdGrupo { get; set; }
        public string Descripcion { get; set; }
        public string Observacion { get; set; }
        public bool Estado { get; set; }
        public double MontoSolicitado { get; set; }
        public double MontoAprobado { get; set; }
        public string DescripciónPeriodo { get; set; }
        public string IdUsuarioAprobacion { get; set; }
        public Nullable<System.DateTime> FechaAprobacion { get; set; }
        public string MotivoAprobacion { get; set; }
    }
}
